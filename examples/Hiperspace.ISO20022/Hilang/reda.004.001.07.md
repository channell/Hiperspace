# reda.004.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda004001.AccountIdentificationAndName7 {
        + Nm  : String
        + Id  : ISO20022.Reda004001.CashAccountIdentification8Choice
    }
    ISO20022.Reda004001.AccountIdentificationAndName7 *-- ISO20022.Reda004001.CashAccountIdentification8Choice
    class ISO20022.Reda004001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda004001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda004001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda004001.AdditionalInformation15 {
        + InfVal  : String
        + InfTp  : ISO20022.Reda004001.GenericIdentification36
    }
    ISO20022.Reda004001.AdditionalInformation15 *-- ISO20022.Reda004001.GenericIdentification36
    class ISO20022.Reda004001.AdditionalProductInformation3 {
        + FinInstrmTxCostsExPstUK  : Decimal
        + FinInstrmTxCostsExAnteUK  : Decimal
    }
    class ISO20022.Reda004001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Reda004001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Reda004001.AdditionalReference10 *-- ISO20022.Reda004001.PartyIdentification139
    class ISO20022.Reda004001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda004001.AnnualChargePaymentType1Code {
        INCO = 1
        CAPL = 2
    }
    class ISO20022.Reda004001.AssessmentOfValueRequiredUnderCOLLUKType1Code {
        NSCO = 1
        YSCO = 2
    }
    class ISO20022.Reda004001.BusinessDayConvention1Code {
        PREC = 1
        FWNG = 2
    }
    class ISO20022.Reda004001.CashAccount205 {
        + ScndryAcct  : ISO20022.Reda004001.CashAccount206
        + PmryAcct  : ISO20022.Reda004001.CashAccount206
        + Ccy  : String
    }
    ISO20022.Reda004001.CashAccount205 *-- ISO20022.Reda004001.CashAccount206
    ISO20022.Reda004001.CashAccount205 *-- ISO20022.Reda004001.CashAccount206
    class ISO20022.Reda004001.CashAccount206 {
        + AcctTpDesc  : String
        + Svcr  : String
        + AcctId  : ISO20022.Reda004001.AccountIdentificationAndName7
    }
    ISO20022.Reda004001.CashAccount206 *-- ISO20022.Reda004001.AccountIdentificationAndName7
    class ISO20022.Reda004001.CashAccountIdentification8Choice {
        + IBAN  : String
        + Othr  : ISO20022.Reda004001.GenericAccountIdentification1
    }
    ISO20022.Reda004001.CashAccountIdentification8Choice *-- ISO20022.Reda004001.GenericAccountIdentification1
    class ISO20022.Reda004001.ChargeType8Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.ChargeType8Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.ContactAttributes5 {
        + LEI  : String
        + AnyBIC  : String
        + URLAdr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + PstlAdr  : ISO20022.Reda004001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda004001.ContactAttributes5 *-- ISO20022.Reda004001.PostalAddress1
    class ISO20022.Reda004001.ContactAttributes6 {
        + LEI  : String
        + AnyBIC  : String
        + URLAdr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + PstlAdr  : ISO20022.Reda004001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda004001.ContactAttributes6 *-- ISO20022.Reda004001.PostalAddress1
    class ISO20022.Reda004001.CostsAndCharges2 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + IndvCostOrChrg  : global::System.Collections.Generic.List~ISO20022.Reda004001.IndividualCostOrCharge2~
        + ExAnteRefDt  : DateTime
    }
    ISO20022.Reda004001.CostsAndCharges2 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.CostsAndCharges2 *-- ISO20022.Reda004001.IndividualCostOrCharge2
    class ISO20022.Reda004001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Reda004001.DistributionStrategy1 {
        + Othr  : ISO20022.Reda004001.OtherDistributionStrategy1
        + PrtflMgmt  : ISO20022.Reda004001.DistributionStrategy1Choice
        + InvstmtAdvc  : ISO20022.Reda004001.DistributionStrategy1Choice
        + ExctnWthApprprtnssTstOrNonAdvsdSvcs  : ISO20022.Reda004001.DistributionStrategy1Choice
        + ExctnOnly  : ISO20022.Reda004001.DistributionStrategy1Choice
    }
    ISO20022.Reda004001.DistributionStrategy1 *-- ISO20022.Reda004001.OtherDistributionStrategy1
    ISO20022.Reda004001.DistributionStrategy1 *-- ISO20022.Reda004001.DistributionStrategy1Choice
    ISO20022.Reda004001.DistributionStrategy1 *-- ISO20022.Reda004001.DistributionStrategy1Choice
    ISO20022.Reda004001.DistributionStrategy1 *-- ISO20022.Reda004001.DistributionStrategy1Choice
    ISO20022.Reda004001.DistributionStrategy1 *-- ISO20022.Reda004001.DistributionStrategy1Choice
    class ISO20022.Reda004001.DistributionStrategy1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.DistributionStrategy1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.DividendPolicy1Code {
        BOTH = 1
        UNIT = 2
        CASH = 3
    }
    class ISO20022.Reda004001.EMTDataReportingVFMUKType1Code {
        YSCO = 1
    }
    class ISO20022.Reda004001.EUSavingsDirective1Code {
        VARI = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Reda004001.EventFrequency5Code {
        TWMN = 1
        TOWK = 2
        TOMN = 3
        CLOS = 4
        DAIL = 5
        WEEK = 6
        MNTH = 7
        QUTR = 8
        SEMI = 9
        YEAR = 10
    }
    class ISO20022.Reda004001.EventFrequency8Code {
        WEEK = 1
        TWMN = 2
        SEMI = 3
        QUTR = 4
        OVNG = 5
        ONDE = 6
        MNTH = 7
        INDA = 8
        TYEA = 9
        TOWK = 10
        TOMN = 11
        FOMN = 12
        DAIL = 13
        YEAR = 14
        ADHO = 15
    }
    class ISO20022.Reda004001.ExPostCostCalculationBasis1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.ExPostCostCalculationBasis1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.ExPostCostCalculationBasis1Code {
        ROLL = 1
        FIXB = 2
    }
    class ISO20022.Reda004001.ExtendedParty13 {
        + OthrPtyDtls  : ISO20022.Reda004001.ContactAttributes5
        + PtyRole  : ISO20022.Reda004001.GenericIdentification36
    }
    ISO20022.Reda004001.ExtendedParty13 *-- ISO20022.Reda004001.ContactAttributes5
    ISO20022.Reda004001.ExtendedParty13 *-- ISO20022.Reda004001.GenericIdentification36
    class ISO20022.Reda004001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Reda004001.FinancialInstrument96 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + PrfrmncFee  : String
        + MgmtFeeSrc  : String
        + RDRCmplnt  : String
        + Authrsd  : String
        + TaxEffcntPdctElgbl  : String
        + Equlstn  : String
        + ClsdEndFnd  : String
        + MayBeTermntdEarly  : String
        + MtrtyDt  : DateTime
        + SspnsnEndDt  : DateTime
        + SspnsnStartDt  : DateTime
        + InitlOfferEndDt  : DateTime
        + TermntnDt  : DateTime
        + FndEndDt  : DateTime
        + LnchDt  : DateTime
        + EUSvgsDrctv  : String
        + SwtchFee  : String
        + BckEndLd  : String
        + FrntEndLd  : String
        + RinvstmtFrqcy  : String
        + DvddFrqcy  : String
        + DvddPlcy  : String
        + DstrbtnPlcy  : String
        + DmtrlsdRegdScties  : String
        + PhysRegdScties  : String
        + DmtrlsdBrScties  : String
        + PhysBrScties  : String
    }
    ISO20022.Reda004001.FinancialInstrument96 *-- ISO20022.Reda004001.AdditionalInformation15
    class ISO20022.Reda004001.Forms1 {
        + SgntrTp  : String
        + ApplForm  : String
    }
    class ISO20022.Reda004001.Frequency20Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.Frequency20Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.FundOrderType10Code {
        WIDP = 1
        RGSV = 2
        REDM = 3
        RDIV = 4
        SUBS = 5
    }
    class ISO20022.Reda004001.FundOrderType5Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Reda004001.FundOrderType5Choice *-- ISO20022.Reda004001.GenericIdentification36
    class ISO20022.Reda004001.FundParties1 {
        + OthrPty  : global::System.Collections.Generic.List~ISO20022.Reda004001.ExtendedParty13~
        + Trstee  : ISO20022.Reda004001.ContactAttributes5
        + Audtr  : ISO20022.Reda004001.ContactAttributes5
        + Guarntr  : ISO20022.Reda004001.ContactAttributes5
    }
    ISO20022.Reda004001.FundParties1 *-- ISO20022.Reda004001.ExtendedParty13
    ISO20022.Reda004001.FundParties1 *-- ISO20022.Reda004001.ContactAttributes5
    ISO20022.Reda004001.FundParties1 *-- ISO20022.Reda004001.ContactAttributes5
    ISO20022.Reda004001.FundParties1 *-- ISO20022.Reda004001.ContactAttributes5
    class ISO20022.Reda004001.FundPaymentType1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Reda004001.FundPaymentType1Choice *-- ISO20022.Reda004001.GenericIdentification36
    class ISO20022.Reda004001.FundPaymentType1Code {
        CARD = 1
        DDEB = 2
        CRDT = 3
        CHEQ = 4
        CACC = 5
        DRAF = 6
    }
    class ISO20022.Reda004001.FundReferenceDataReport5 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Reda004001.Extension1~
        + ValForMny  : ISO20022.Reda004001.ValueForMoney1
        + AddtlInfUKMkt  : ISO20022.Reda004001.AdditionalProductInformation3
        + CostsAndChrgs  : global::System.Collections.Generic.List~ISO20022.Reda004001.CostsAndCharges2~
        + DstrbtnStrtgy  : ISO20022.Reda004001.DistributionStrategy1
        + TrgtMkt  : ISO20022.Reda004001.TargetMarket4
        + LclMktAnx  : global::System.Collections.Generic.List~ISO20022.Reda004001.LocalMarketAnnex6~
        + CshSttlmDtls  : global::System.Collections.Generic.List~ISO20022.Reda004001.CashAccount205~
        + PmtInstrm  : global::System.Collections.Generic.List~ISO20022.Reda004001.PaymentInstrument16~
        + PlanChrtcs  : global::System.Collections.Generic.List~ISO20022.Reda004001.InvestmentPlanCharacteristics1~
        + SwtchPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics9
        + RedPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics12
        + SbcptPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics11
        + InvstmtRstrctns  : ISO20022.Reda004001.InvestmentRestrictions3
        + ValtnDealgChrtcs  : ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3
        + FndDtls  : ISO20022.Reda004001.FinancialInstrument96
        + FndMgmtCpny  : ISO20022.Reda004001.ContactAttributes5
        + MainFndOrdrDsk  : ISO20022.Reda004001.OrderDesk1
        + FndPties  : ISO20022.Reda004001.FundParties1
        + SctyId  : ISO20022.Reda004001.SecurityIdentification47
        + ExPstInd  : String
        + ExAnteInd  : String
        + TrgtMktInd  : String
        + GnlRefDt  : DateTime
        + AuthrsdPrxy  : ISO20022.Reda004001.ContactAttributes6
        + Vrsn  : ISO20022.Reda004001.MarketPracticeVersion1
        + Id  : String
    }
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.Extension1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ValueForMoney1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.AdditionalProductInformation3
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.CostsAndCharges2
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.DistributionStrategy1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.TargetMarket4
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.LocalMarketAnnex6
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.CashAccount205
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.PaymentInstrument16
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.InvestmentPlanCharacteristics1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ProcessingCharacteristics9
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ProcessingCharacteristics12
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ProcessingCharacteristics11
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.InvestmentRestrictions3
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.FinancialInstrument96
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ContactAttributes5
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.OrderDesk1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.FundParties1
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.SecurityIdentification47
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.ContactAttributes6
    ISO20022.Reda004001.FundReferenceDataReport5 *-- ISO20022.Reda004001.MarketPracticeVersion1
    class ISO20022.Reda004001.FundReferenceDataReportV07 {
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Reda004001.FundReferenceDataReport5~
        + FndRefDataRptId  : String
        + RltdRef  : ISO20022.Reda004001.AdditionalReference10
        + PrvsRef  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalReference10~
        + MsgId  : ISO20022.Reda004001.MessageIdentification1
    }
    ISO20022.Reda004001.FundReferenceDataReportV07 *-- ISO20022.Reda004001.FundReferenceDataReport5
    ISO20022.Reda004001.FundReferenceDataReportV07 *-- ISO20022.Reda004001.AdditionalReference10
    ISO20022.Reda004001.FundReferenceDataReportV07 *-- ISO20022.Reda004001.AdditionalReference10
    ISO20022.Reda004001.FundReferenceDataReportV07 *-- ISO20022.Reda004001.MessageIdentification1
    class ISO20022.Reda004001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Reda004001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Reda004001.GenericAccountIdentification1 *-- ISO20022.Reda004001.AccountSchemeName1Choice
    class ISO20022.Reda004001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda004001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda004001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda004001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda004001.GovernanceProcess1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.GovernanceProcess1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.GovernanceProcessType1Code {
        AMIF = 1
        CMIF = 2
        NINF = 3
        BMIF = 4
    }
    class ISO20022.Reda004001.HoldingTransferable1Code {
        RFOD = 1
        TRNA = 2
        TRAL = 3
    }
    class ISO20022.Reda004001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda004001.IndividualCostOrCharge2 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + RefPrd  : ISO20022.Reda004001.Period15
        + Rate  : Decimal
        + Sgn  : String
        + Amt  : ISO20022.Reda004001.ActiveCurrencyAnd13DecimalAmount
        + ExAnteOrExPst  : String
        + CostTp  : ISO20022.Reda004001.ChargeType8Choice
    }
    ISO20022.Reda004001.IndividualCostOrCharge2 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.IndividualCostOrCharge2 *-- ISO20022.Reda004001.Period15
    ISO20022.Reda004001.IndividualCostOrCharge2 *-- ISO20022.Reda004001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Reda004001.IndividualCostOrCharge2 *-- ISO20022.Reda004001.ChargeType8Choice
    class ISO20022.Reda004001.IntendedOrActual2Code {
        POST = 1
        ANTE = 2
    }
    class ISO20022.Reda004001.InvestmentFundMiFIDFee2Code {
        TRS1 = 1
        RPSS = 2
        OCAS = 3
        OTES = 4
        PENO = 5
        BEND = 6
        ENBX = 7
        EXAC = 8
        ENFX = 9
        ENAC = 10
        BENS = 11
        OOSS = 12
        OOSF = 13
        OOEA = 14
        NRAM = 15
        NETO = 16
        NESF = 17
        NET2 = 18
        MANS = 19
        MNF1 = 20
        INCS = 21
        INCF = 22
        GOCS = 23
        GOC1 = 24
        FES2 = 25
        FEND = 26
        FES3 = 27
        DIS2 = 28
        BORF = 29
    }
    class ISO20022.Reda004001.InvestmentFundPlanType1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Reda004001.InvestmentFundPlanType1Choice *-- ISO20022.Reda004001.GenericIdentification36
    class ISO20022.Reda004001.InvestmentFundPlanType1Code {
        WTHP = 1
        SWIP = 2
        INVP = 3
    }
    class ISO20022.Reda004001.InvestmentNeed2Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.InvestmentNeed2Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.InvestmentNeed2Code {
        ISLB = 1
        OTHR = 2
        NSPE = 3
    }
    class ISO20022.Reda004001.InvestmentPlanCharacteristics1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + AddtlSbcptFctn  : String
        + AddtlSbcpt  : String
        + PlanConttn  : String
        + Qty  : ISO20022.Reda004001.UnitsOrAmount1Choice
        + TtlNbOfInstlmts  : Decimal
        + Frqcy  : ISO20022.Reda004001.Frequency20Choice
        + PlanTp  : ISO20022.Reda004001.InvestmentFundPlanType1Choice
    }
    ISO20022.Reda004001.InvestmentPlanCharacteristics1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.InvestmentPlanCharacteristics1 *-- ISO20022.Reda004001.UnitsOrAmount1Choice
    ISO20022.Reda004001.InvestmentPlanCharacteristics1 *-- ISO20022.Reda004001.Frequency20Choice
    ISO20022.Reda004001.InvestmentPlanCharacteristics1 *-- ISO20022.Reda004001.InvestmentFundPlanType1Choice
    class ISO20022.Reda004001.InvestmentRestrictions3 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + HldgTrfbl  : String
        + MinHldgPrd  : String
        + MinHldgUnits  : Decimal
        + MinHldgAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
        + OthrSwtchRstrctns  : String
        + MaxSwtchRedUnits  : Decimal
        + MaxSwtchRedAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
        + MinSwtchSbcptUnits  : Decimal
        + MinSwtchSbcptAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
        + OthrRedRstrctns  : String
        + MinRedPctg  : Decimal
        + MaxRedUnits  : Decimal
        + MaxRedAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
        + MinSbsqntSbcptUnits  : Decimal
        + MinSbsqntSbcptAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
        + MinInitlSbcptUnits  : Decimal
        + MinInitlSbcptAmt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
    }
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    ISO20022.Reda004001.InvestmentRestrictions3 *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    class ISO20022.Reda004001.InvestorKnowledge1 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1~
        + ExprtInvstrDE  : String
        + AdvncdInvstr  : String
        + InfrmdInvstr  : String
        + BsicInvstr  : String
    }
    ISO20022.Reda004001.InvestorKnowledge1 *-- ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1
    class ISO20022.Reda004001.InvestorRequirements4 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherInvestmentNeed1~
        + OthrSpcfcInvstmtNeed  : ISO20022.Reda004001.InvestmentNeed2Choice
        + SstnbltyPrefs  : String
        + MinHldgPrd  : ISO20022.Reda004001.TimeHorizon2Choice
        + RtrPrflPnsnSchmeDE  : String
        + OptnOrLvrgdRtrPrfl  : String
        + RtrPrflHdgg  : String
        + RtrPrflIncm  : String
        + RtrPrflGrwth  : String
        + RtrPrflPrsrvtn  : String
    }
    ISO20022.Reda004001.InvestorRequirements4 *-- ISO20022.Reda004001.OtherInvestmentNeed1
    ISO20022.Reda004001.InvestorRequirements4 *-- ISO20022.Reda004001.InvestmentNeed2Choice
    ISO20022.Reda004001.InvestorRequirements4 *-- ISO20022.Reda004001.TimeHorizon2Choice
    class ISO20022.Reda004001.InvestorType2 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherTargetMarketInvestor1~
        + InvstrTpElgblCtrPty  : String
        + InvstrTpPrfssnl  : ISO20022.Reda004001.TargetMarket5Choice
        + InvstrTpRtl  : String
    }
    ISO20022.Reda004001.InvestorType2 *-- ISO20022.Reda004001.OtherTargetMarketInvestor1
    ISO20022.Reda004001.InvestorType2 *-- ISO20022.Reda004001.TargetMarket5Choice
    class ISO20022.Reda004001.InvestorType2Code {
        PRF2 = 1
        EPRO = 2
        BOT3 = 3
    }
    class ISO20022.Reda004001.InvestorType3Code {
        BOT2 = 1
        NEI1 = 2
        PRF2 = 3
        RETL = 4
    }
    class ISO20022.Reda004001.InvestorType4Code {
        PRF4 = 1
        PRF3 = 2
        NPRF = 3
        BOT3 = 4
    }
    class ISO20022.Reda004001.LocalMarketAnnex6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + CshSttlmDtls  : global::System.Collections.Generic.List~ISO20022.Reda004001.CashAccount205~
        + SwtchPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics9
        + RedPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics10
        + SbcptPrcgChrtcs  : ISO20022.Reda004001.ProcessingCharacteristics11
        + LclOrdrDsk  : ISO20022.Reda004001.OrderDesk1
        + Ctry  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.CashAccount205
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.ProcessingCharacteristics9
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.ProcessingCharacteristics10
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.ProcessingCharacteristics11
    ISO20022.Reda004001.LocalMarketAnnex6 *-- ISO20022.Reda004001.OrderDesk1
    class ISO20022.Reda004001.LossBearing2 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherTargetMarketLossBearing1~
        + LossByndCptl  : String
        + NoCptlGrnt  : String
        + LtdCptlLossLvl  : Decimal
        + LtdCptlLoss  : String
        + NoCptlLoss  : String
    }
    ISO20022.Reda004001.LossBearing2 *-- ISO20022.Reda004001.OtherTargetMarketLossBearing1
    class ISO20022.Reda004001.MainFundOrderDeskLocation1 {
        + TmZoneOffSet  : ISO20022.Reda004001.UTCOffset1
        + Ctry  : String
    }
    ISO20022.Reda004001.MainFundOrderDeskLocation1 *-- ISO20022.Reda004001.UTCOffset1
    class ISO20022.Reda004001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Reda004001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Reda004001.NameAndAddress5 {
        + Adr  : ISO20022.Reda004001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda004001.NameAndAddress5 *-- ISO20022.Reda004001.PostalAddress1
    class ISO20022.Reda004001.NotionalOrUnitBased1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.NotionalOrUnitBased1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.NotionalOrUnitBased1Code {
        NOTI = 1
        UNIT = 2
    }
    class ISO20022.Reda004001.OrderDesk1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + ClsrDts  : global::System.Collections.Generic.List~DateTime~
        + OrdrDsk  : ISO20022.Reda004001.ContactAttributes5
    }
    ISO20022.Reda004001.OrderDesk1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OrderDesk1 *-- ISO20022.Reda004001.ContactAttributes5
    class ISO20022.Reda004001.OtherDistributionStrategy1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.DistributionStrategy1Choice
        + DstrbtnStrtgyTp  : String
    }
    ISO20022.Reda004001.OtherDistributionStrategy1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherDistributionStrategy1 *-- ISO20022.Reda004001.DistributionStrategy1Choice
    class ISO20022.Reda004001.OtherIdentification1 {
        + Tp  : ISO20022.Reda004001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Reda004001.OtherIdentification1 *-- ISO20022.Reda004001.IdentificationSource3Choice
    class ISO20022.Reda004001.OtherInvestmentNeed1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.TargetMarket1Choice
        + ClntObjctvsAndNeedsTp  : String
    }
    ISO20022.Reda004001.OtherInvestmentNeed1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherInvestmentNeed1 *-- ISO20022.Reda004001.TargetMarket1Choice
    class ISO20022.Reda004001.OtherReviewRelatedToValueAndOrChargesUKType1Code {
        REVO = 1
        REVA = 2
    }
    class ISO20022.Reda004001.OtherTargetMarket1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + TrgtMktTp  : String
    }
    ISO20022.Reda004001.OtherTargetMarket1 *-- ISO20022.Reda004001.AdditionalInformation15
    class ISO20022.Reda004001.OtherTargetMarketInvestor1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.TargetMarket3Choice
        + InvstrTp  : String
    }
    ISO20022.Reda004001.OtherTargetMarketInvestor1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherTargetMarketInvestor1 *-- ISO20022.Reda004001.TargetMarket3Choice
    class ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.TargetMarket1Choice
        + InvstrKnwldgTp  : String
    }
    ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1 *-- ISO20022.Reda004001.TargetMarket1Choice
    class ISO20022.Reda004001.OtherTargetMarketLossBearing1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.TargetMarket1Choice
        + AbltyToBearLossesTp  : String
    }
    ISO20022.Reda004001.OtherTargetMarketLossBearing1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherTargetMarketLossBearing1 *-- ISO20022.Reda004001.TargetMarket1Choice
    class ISO20022.Reda004001.OtherTargetMarketRiskTolerance1 {
        + AddtlInf  : ISO20022.Reda004001.AdditionalInformation15
        + Trgt  : ISO20022.Reda004001.TargetMarket1Choice
        + RskTlrnceTp  : String
    }
    ISO20022.Reda004001.OtherTargetMarketRiskTolerance1 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.OtherTargetMarketRiskTolerance1 *-- ISO20022.Reda004001.TargetMarket1Choice
    class ISO20022.Reda004001.OutcomeOfCOLLAssessmentOfValueUKType1Code {
        COL2 = 1
        COL1 = 2
    }
    class ISO20022.Reda004001.OutcomeOfPRINValueAssessmentOrReviewUKType1Code {
        PRI1 = 1
        PRI2 = 2
    }
    class ISO20022.Reda004001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Reda004001.NameAndAddress5
        + PrtryId  : ISO20022.Reda004001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Reda004001.PartyIdentification125Choice *-- ISO20022.Reda004001.NameAndAddress5
    ISO20022.Reda004001.PartyIdentification125Choice *-- ISO20022.Reda004001.GenericIdentification1
    class ISO20022.Reda004001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Reda004001.PartyIdentification125Choice
    }
    ISO20022.Reda004001.PartyIdentification139 *-- ISO20022.Reda004001.PartyIdentification125Choice
    class ISO20022.Reda004001.PaymentInstrument16 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + InstrmTp  : ISO20022.Reda004001.FundPaymentType1Choice
        + OrdrTp  : ISO20022.Reda004001.FundOrderType5Choice
    }
    ISO20022.Reda004001.PaymentInstrument16 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.PaymentInstrument16 *-- ISO20022.Reda004001.FundPaymentType1Choice
    ISO20022.Reda004001.PaymentInstrument16 *-- ISO20022.Reda004001.FundOrderType5Choice
    class ISO20022.Reda004001.Period15 {
        + EndDt  : DateTime
        + StartDt  : DateTime
    }
    class ISO20022.Reda004001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda004001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Reda004001.ProcessingCharacteristics10 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + SttlmCycl  : ISO20022.Reda004001.TimeFrame8Choice
        + LtdPrd  : String
        + DealConfTmFrame  : ISO20022.Reda004001.TimeFrame8
        + DealConfTm  : DateTime
        + DealgCutOffTmFrame  : ISO20022.Reda004001.TimeFrame9
        + DealgCutOffTm  : DateTime
        + DealgFrqcyDesc  : String
        + DealgFrqcy  : String
        + MainFndOrdrDskLctn  : ISO20022.Reda004001.MainFundOrderDeskLocation1
        + PctgInd  : String
        + Rndg  : String
        + UnitsInd  : String
        + AmtInd  : String
        + RedAuthstn  : ISO20022.Reda004001.Forms1
        + DealgCcyAccptd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.TimeFrame8Choice
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.TimeFrame8
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.TimeFrame9
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.MainFundOrderDeskLocation1
    ISO20022.Reda004001.ProcessingCharacteristics10 *-- ISO20022.Reda004001.Forms1
    class ISO20022.Reda004001.ProcessingCharacteristics11 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + SttlmCycl  : ISO20022.Reda004001.TimeFrame7Choice
        + LtdPrd  : String
        + DealConfTmFrame  : ISO20022.Reda004001.TimeFrame11
        + DealConfTm  : DateTime
        + DealgCutOffTmFrame  : ISO20022.Reda004001.TimeFrame9
        + DealgCutOffTm  : DateTime
        + DealgFrqcyDesc  : String
        + DealgFrqcy  : String
        + MainFndOrdrDskLctn  : ISO20022.Reda004001.MainFundOrderDeskLocation1
        + Rndg  : String
        + UnitsInd  : String
        + AmtInd  : String
        + SbsqntInvstmtAppl  : ISO20022.Reda004001.Forms1
        + InitlInvstmtAppl  : ISO20022.Reda004001.Forms1
        + DealgCcyAccptd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.TimeFrame7Choice
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.TimeFrame11
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.TimeFrame9
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.MainFundOrderDeskLocation1
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.Forms1
    ISO20022.Reda004001.ProcessingCharacteristics11 *-- ISO20022.Reda004001.Forms1
    class ISO20022.Reda004001.ProcessingCharacteristics12 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + SttlmCycl  : ISO20022.Reda004001.TimeFrame8Choice
        + LtdPrd  : String
        + DealConfTmFrame  : ISO20022.Reda004001.TimeFrame10
        + DealConfTm  : DateTime
        + DealgCutOffTmFrame  : ISO20022.Reda004001.TimeFrame9
        + DealgCutOffTm  : DateTime
        + DealgFrqcyDesc  : String
        + DealgFrqcy  : String
        + MainFndOrdrDskLctn  : ISO20022.Reda004001.MainFundOrderDeskLocation1
        + PctgInd  : String
        + Rndg  : String
        + UnitsInd  : String
        + AmtInd  : String
        + RedAuthstn  : ISO20022.Reda004001.Forms1
        + DealgCcyAccptd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.TimeFrame8Choice
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.TimeFrame10
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.TimeFrame9
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.MainFundOrderDeskLocation1
    ISO20022.Reda004001.ProcessingCharacteristics12 *-- ISO20022.Reda004001.Forms1
    class ISO20022.Reda004001.ProcessingCharacteristics9 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + SttlmCycl  : ISO20022.Reda004001.TimeFrame8Choice
        + LtdPrd  : String
        + DealConfTmFrame  : ISO20022.Reda004001.TimeFrame8
        + DealConfTm  : DateTime
        + DealgCutOffTmFrame  : ISO20022.Reda004001.TimeFrame9
        + DealgCutOffTm  : DateTime
        + DealgFrqcyDesc  : String
        + DealgFrqcy  : String
        + MainFndOrdrDskLctn  : ISO20022.Reda004001.MainFundOrderDeskLocation1
        + Rndg  : String
        + UnitsInd  : String
        + AmtInd  : String
        + SwtchAuthstn  : ISO20022.Reda004001.Forms1
        + DealgCcyAccptd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.TimeFrame8Choice
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.TimeFrame8
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.TimeFrame9
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.MainFundOrderDeskLocation1
    ISO20022.Reda004001.ProcessingCharacteristics9 *-- ISO20022.Reda004001.Forms1
    class ISO20022.Reda004001.ProductStructure1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.ProductStructure1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.ProductStructure1Code {
        NUCI = 1
        SFUN = 2
        SSEC = 3
        UCIT = 4
        EXTC = 5
        UCMM = 6
        NUMM = 7
        BOND = 8
    }
    class ISO20022.Reda004001.QuotationType1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.QuotationType1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.QuotationType1Code {
        PRCT = 1
        ACTU = 2
    }
    class ISO20022.Reda004001.ReferToFundOrderDesk1Code {
        RFOD = 1
    }
    class ISO20022.Reda004001.RiskLevel1Code {
        MEDM = 1
        LOWW = 2
        HIGH = 3
    }
    class ISO20022.Reda004001.RiskTolerance1 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherTargetMarketRiskTolerance1~
        + NotForInvstrsWthTheLwstRskTlrnceDE  : String
        + RskTlrnceForNonPRIIPSAndNonUCITSES  : Decimal
        + RskTlrnceIntl  : String
        + RskTlrnceUCITSMthdlgy  : Decimal
        + RskTlrncePRIIPSMthdlgy  : Decimal
    }
    ISO20022.Reda004001.RiskTolerance1 *-- ISO20022.Reda004001.OtherTargetMarketRiskTolerance1
    class ISO20022.Reda004001.RoundingDirection2Code {
        RDWN = 1
        RDUP = 2
    }
    class ISO20022.Reda004001.SecurityClassificationType2Choice {
        + AltrnClssfctn  : ISO20022.Reda004001.GenericIdentification3
        + CFI  : String
    }
    ISO20022.Reda004001.SecurityClassificationType2Choice *-- ISO20022.Reda004001.GenericIdentification3
    class ISO20022.Reda004001.SecurityIdentification40 {
        + ISIN  : String
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherIdentification1~
    }
    ISO20022.Reda004001.SecurityIdentification40 *-- ISO20022.Reda004001.OtherIdentification1
    class ISO20022.Reda004001.SecurityIdentification47 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + ExPstCostClctnBsis  : ISO20022.Reda004001.ExPostCostCalculationBasis1Choice
        + NoRtrcssnInd  : String
        + LvrgdOrCntngntLblty  : String
        + QtnTp  : ISO20022.Reda004001.QuotationType1Choice
        + NtnlOrUnitBased  : ISO20022.Reda004001.NotionalOrUnitBased1Choice
        + PdctCtgyDE  : String
        + PdctCtgy  : String
        + IssrPdctGovncPrc  : ISO20022.Reda004001.GovernanceProcess1Choice
        + Issr  : ISO20022.Reda004001.ContactAttributes5
        + PdctTp  : ISO20022.Reda004001.ProductStructure1Choice
        + RegdDstrbtnCtry  : global::System.Collections.Generic.List~String~
        + CtryOfDmcl  : String
        + BaseCcy  : String
        + ClssfctnTp  : ISO20022.Reda004001.SecurityClassificationType2Choice
        + NewUmbrll  : String
        + UmbrllNm  : String
        + ClssTp  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Reda004001.SecurityIdentification40
    }
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.AdditionalInformation15
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.ExPostCostCalculationBasis1Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.QuotationType1Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.NotionalOrUnitBased1Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.GovernanceProcess1Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.ContactAttributes5
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.ProductStructure1Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.SecurityClassificationType2Choice
    ISO20022.Reda004001.SecurityIdentification47 *-- ISO20022.Reda004001.SecurityIdentification40
    class ISO20022.Reda004001.SignatureType1Code {
        NONE = 1
        ELEC = 2
        DIGI = 3
        ORIG = 4
    }
    class ISO20022.Reda004001.SustainabilityPreferences2Code {
        YSCO = 1
        NEUT = 2
    }
    class ISO20022.Reda004001.TargetMarket1Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.TargetMarket1Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.TargetMarket1Code {
        NSCO = 1
        NEUT = 2
        YSCO = 3
    }
    class ISO20022.Reda004001.TargetMarket2Code {
        YSCO = 1
        NEUT = 2
    }
    class ISO20022.Reda004001.TargetMarket3Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Othr  : String
        + Tp  : String
    }
    ISO20022.Reda004001.TargetMarket3Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.TargetMarket3Code {
        NSCO = 1
        YSCO = 2
    }
    class ISO20022.Reda004001.TargetMarket4 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Reda004001.OtherTargetMarket1~
        + ClntObjctvsAndNeeds  : ISO20022.Reda004001.InvestorRequirements4
        + RskTlrnce  : ISO20022.Reda004001.RiskTolerance1
        + AbltyToBearLosses  : ISO20022.Reda004001.LossBearing2
        + KnwldgAndOrExprnc  : ISO20022.Reda004001.InvestorKnowledge1
        + InvstrTp  : ISO20022.Reda004001.InvestorType2
        + RefDt  : DateTime
    }
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.OtherTargetMarket1
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.InvestorRequirements4
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.RiskTolerance1
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.LossBearing2
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.InvestorKnowledge1
    ISO20022.Reda004001.TargetMarket4 *-- ISO20022.Reda004001.InvestorType2
    class ISO20022.Reda004001.TargetMarket5Choice {
        + Othr  : String
        + Tp  : String
    }
    class ISO20022.Reda004001.TimeFrame10 {
        + RefrToOrdrDsk  : String
        + NonWorkgDayAdjstmnt  : String
        + TPlus  : Decimal
        + OthrTmFrameDesc  : String
    }
    class ISO20022.Reda004001.TimeFrame11 {
        + RefrToOrdrDsk  : String
        + NonWorkgDayAdjstmnt  : String
        + TPlus  : Decimal
        + OthrTmFrameDesc  : String
    }
    class ISO20022.Reda004001.TimeFrame2Code {
        VSHT = 1
        SHOR = 2
        MEDM = 3
        LONG = 4
        HOLD = 5
    }
    class ISO20022.Reda004001.TimeFrame7Choice {
        + Prepmt  : String
        + TPlus  : Decimal
    }
    class ISO20022.Reda004001.TimeFrame8 {
        + RefrToOrdrDsk  : String
        + NonWorkgDayAdjstmnt  : String
        + TPlus  : Decimal
        + OthrTmFrameDesc  : String
    }
    class ISO20022.Reda004001.TimeFrame8Choice {
        + RPlus  : Decimal
        + TPlus  : Decimal
    }
    class ISO20022.Reda004001.TimeFrame9 {
        + RefrToOrdrDsk  : String
        + NonWorkgDayAdjstmnt  : String
        + TMns  : Decimal
        + OthrTmFrameDesc  : String
    }
    class ISO20022.Reda004001.TimeFrame9Choice {
        + Prtry  : ISO20022.Reda004001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Reda004001.TimeFrame9Choice *-- ISO20022.Reda004001.GenericIdentification47
    class ISO20022.Reda004001.TimeHorizon2Choice {
        + TmFrame  : ISO20022.Reda004001.TimeFrame9Choice
        + NbOfYrs  : Decimal
    }
    ISO20022.Reda004001.TimeHorizon2Choice *-- ISO20022.Reda004001.TimeFrame9Choice
    class ISO20022.Reda004001.UTCOffset1 {
        + NbOfHrs  : DateTime
        + Sgn  : String
    }
    class ISO20022.Reda004001.UnitsOrAmount1Choice {
        + Unit  : Decimal
        + Amt  : ISO20022.Reda004001.ActiveCurrencyAndAmount
    }
    ISO20022.Reda004001.UnitsOrAmount1Choice *-- ISO20022.Reda004001.ActiveCurrencyAndAmount
    class ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Reda004001.AdditionalInformation15~
        + PricCcy  : global::System.Collections.Generic.List~String~
        + PricMtd  : String
        + DualFndInd  : String
        + DcmlstnPric  : Decimal
        + DcmlstnUnits  : Decimal
        + ValtnTm  : DateTime
        + ValtnFrqcyDesc  : String
        + ValtnFrqcy  : String
    }
    ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3 *-- ISO20022.Reda004001.AdditionalInformation15
    class ISO20022.Reda004001.ValueForMoney1 {
        + RvwNxtDueUK  : DateTime
        + RvwDtUK  : DateTime
        + FrthrInfUK  : String
        + OthrRvwRltdToValAndOrChrgsUK  : String
        + OutcmOfPRINValAssmntOrRvwUK  : String
        + OutcmOfCOLLAssmntOfValUK  : String
        + AssmntOfValReqrdUdrCOLLUK  : String
        + EMTDataRptgVFMUK  : String
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

## Value ISO20022.Reda004001.AccountIdentificationAndName7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Reda004001.CashAccountIdentification8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Reda004001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda004001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.AdditionalInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|InfTp|ISO20022.Reda004001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfTp))|

---

## Value ISO20022.Reda004001.AdditionalProductInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmTxCostsExPstUK|Decimal||XmlElement()||
|+|FinInstrmTxCostsExAnteUK|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Reda004001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Reda004001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Reda004001.AnnualChargePaymentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCO|Int32||XmlEnum("""INCO""")|1|
||CAPL|Int32||XmlEnum("""CAPL""")|2|

---

## Enum ISO20022.Reda004001.AssessmentOfValueRequiredUnderCOLLUKType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSCO|Int32||XmlEnum("""NSCO""")|1|
||YSCO|Int32||XmlEnum("""YSCO""")|2|

---

## Enum ISO20022.Reda004001.BusinessDayConvention1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREC|Int32||XmlEnum("""PREC""")|1|
||FWNG|Int32||XmlEnum("""FWNG""")|2|

---

## Value ISO20022.Reda004001.CashAccount205


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndryAcct|ISO20022.Reda004001.CashAccount206||XmlElement()||
|+|PmryAcct|ISO20022.Reda004001.CashAccount206||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndryAcct),validElement(PmryAcct),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.CashAccount206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctTpDesc|String||XmlElement()||
|+|Svcr|String||XmlElement()||
|+|AcctId|ISO20022.Reda004001.AccountIdentificationAndName7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Svcr""",Svcr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(AcctId))|

---

## Value ISO20022.Reda004001.CashAccountIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IBAN|String||XmlElement()||
|+|Othr|ISO20022.Reda004001.GenericAccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validElement(Othr),validChoice(IBAN,Othr))|

---

## Value ISO20022.Reda004001.ChargeType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda004001.ContactAttributes5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|PstlAdr|ISO20022.Reda004001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(PstlAdr))|

---

## Value ISO20022.Reda004001.ContactAttributes6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|PstlAdr|ISO20022.Reda004001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(PstlAdr))|

---

## Value ISO20022.Reda004001.CostsAndCharges2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|IndvCostOrChrg|global::System.Collections.Generic.List<ISO20022.Reda004001.IndividualCostOrCharge2>||XmlElement()||
|+|ExAnteRefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validRequired("""IndvCostOrChrg""",IndvCostOrChrg),validList("""IndvCostOrChrg""",IndvCostOrChrg),validElement(IndvCostOrChrg))|

---

## Enum ISO20022.Reda004001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Value ISO20022.Reda004001.DistributionStrategy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Reda004001.OtherDistributionStrategy1||XmlElement()||
|+|PrtflMgmt|ISO20022.Reda004001.DistributionStrategy1Choice||XmlElement()||
|+|InvstmtAdvc|ISO20022.Reda004001.DistributionStrategy1Choice||XmlElement()||
|+|ExctnWthApprprtnssTstOrNonAdvsdSvcs|ISO20022.Reda004001.DistributionStrategy1Choice||XmlElement()||
|+|ExctnOnly|ISO20022.Reda004001.DistributionStrategy1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PrtflMgmt),validElement(InvstmtAdvc),validElement(ExctnWthApprprtnssTstOrNonAdvsdSvcs),validElement(ExctnOnly))|

---

## Value ISO20022.Reda004001.DistributionStrategy1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.DividendPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||UNIT|Int32||XmlEnum("""UNIT""")|2|
||CASH|Int32||XmlEnum("""CASH""")|3|

---

## Type ISO20022.Reda004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FndRefDataRpt|ISO20022.Reda004001.FundReferenceDataReportV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FndRefDataRpt))|

---

## Enum ISO20022.Reda004001.EMTDataReportingVFMUKType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSCO|Int32||XmlEnum("""YSCO""")|1|

---

## Enum ISO20022.Reda004001.EUSavingsDirective1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Enum ISO20022.Reda004001.EventFrequency5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TWMN|Int32||XmlEnum("""TWMN""")|1|
||TOWK|Int32||XmlEnum("""TOWK""")|2|
||TOMN|Int32||XmlEnum("""TOMN""")|3|
||CLOS|Int32||XmlEnum("""CLOS""")|4|
||DAIL|Int32||XmlEnum("""DAIL""")|5|
||WEEK|Int32||XmlEnum("""WEEK""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||QUTR|Int32||XmlEnum("""QUTR""")|8|
||SEMI|Int32||XmlEnum("""SEMI""")|9|
||YEAR|Int32||XmlEnum("""YEAR""")|10|

---

## Enum ISO20022.Reda004001.EventFrequency8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||TWMN|Int32||XmlEnum("""TWMN""")|2|
||SEMI|Int32||XmlEnum("""SEMI""")|3|
||QUTR|Int32||XmlEnum("""QUTR""")|4|
||OVNG|Int32||XmlEnum("""OVNG""")|5|
||ONDE|Int32||XmlEnum("""ONDE""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||INDA|Int32||XmlEnum("""INDA""")|8|
||TYEA|Int32||XmlEnum("""TYEA""")|9|
||TOWK|Int32||XmlEnum("""TOWK""")|10|
||TOMN|Int32||XmlEnum("""TOMN""")|11|
||FOMN|Int32||XmlEnum("""FOMN""")|12|
||DAIL|Int32||XmlEnum("""DAIL""")|13|
||YEAR|Int32||XmlEnum("""YEAR""")|14|
||ADHO|Int32||XmlEnum("""ADHO""")|15|

---

## Value ISO20022.Reda004001.ExPostCostCalculationBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.ExPostCostCalculationBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ROLL|Int32||XmlEnum("""ROLL""")|1|
||FIXB|Int32||XmlEnum("""FIXB""")|2|

---

## Value ISO20022.Reda004001.ExtendedParty13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPtyDtls|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
|+|PtyRole|ISO20022.Reda004001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPtyDtls),validElement(PtyRole))|

---

## Value ISO20022.Reda004001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.FinancialInstrument96


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|PrfrmncFee|String||XmlElement()||
|+|MgmtFeeSrc|String||XmlElement()||
|+|RDRCmplnt|String||XmlElement()||
|+|Authrsd|String||XmlElement()||
|+|TaxEffcntPdctElgbl|String||XmlElement()||
|+|Equlstn|String||XmlElement()||
|+|ClsdEndFnd|String||XmlElement()||
|+|MayBeTermntdEarly|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|SspnsnEndDt|DateTime||XmlElement()||
|+|SspnsnStartDt|DateTime||XmlElement()||
|+|InitlOfferEndDt|DateTime||XmlElement()||
|+|TermntnDt|DateTime||XmlElement()||
|+|FndEndDt|DateTime||XmlElement()||
|+|LnchDt|DateTime||XmlElement()||
|+|EUSvgsDrctv|String||XmlElement()||
|+|SwtchFee|String||XmlElement()||
|+|BckEndLd|String||XmlElement()||
|+|FrntEndLd|String||XmlElement()||
|+|RinvstmtFrqcy|String||XmlElement()||
|+|DvddFrqcy|String||XmlElement()||
|+|DvddPlcy|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|DmtrlsdRegdScties|String||XmlElement()||
|+|PhysRegdScties|String||XmlElement()||
|+|DmtrlsdBrScties|String||XmlElement()||
|+|PhysBrScties|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf))|

---

## Value ISO20022.Reda004001.Forms1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgntrTp|String||XmlElement()||
|+|ApplForm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.Frequency20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.FundOrderType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIDP|Int32||XmlEnum("""WIDP""")|1|
||RGSV|Int32||XmlEnum("""RGSV""")|2|
||REDM|Int32||XmlEnum("""REDM""")|3|
||RDIV|Int32||XmlEnum("""RDIV""")|4|
||SUBS|Int32||XmlEnum("""SUBS""")|5|

---

## Value ISO20022.Reda004001.FundOrderType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda004001.FundParties1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPty|global::System.Collections.Generic.List<ISO20022.Reda004001.ExtendedParty13>||XmlElement()||
|+|Trstee|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
|+|Audtr|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
|+|Guarntr|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrPty""",OthrPty),validElement(OthrPty),validElement(Trstee),validElement(Audtr),validElement(Guarntr))|

---

## Value ISO20022.Reda004001.FundPaymentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.FundPaymentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CARD|Int32||XmlEnum("""CARD""")|1|
||DDEB|Int32||XmlEnum("""DDEB""")|2|
||CRDT|Int32||XmlEnum("""CRDT""")|3|
||CHEQ|Int32||XmlEnum("""CHEQ""")|4|
||CACC|Int32||XmlEnum("""CACC""")|5|
||DRAF|Int32||XmlEnum("""DRAF""")|6|

---

## Value ISO20022.Reda004001.FundReferenceDataReport5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Reda004001.Extension1>||XmlElement()||
|+|ValForMny|ISO20022.Reda004001.ValueForMoney1||XmlElement()||
|+|AddtlInfUKMkt|ISO20022.Reda004001.AdditionalProductInformation3||XmlElement()||
|+|CostsAndChrgs|global::System.Collections.Generic.List<ISO20022.Reda004001.CostsAndCharges2>||XmlElement()||
|+|DstrbtnStrtgy|ISO20022.Reda004001.DistributionStrategy1||XmlElement()||
|+|TrgtMkt|ISO20022.Reda004001.TargetMarket4||XmlElement()||
|+|LclMktAnx|global::System.Collections.Generic.List<ISO20022.Reda004001.LocalMarketAnnex6>||XmlElement()||
|+|CshSttlmDtls|global::System.Collections.Generic.List<ISO20022.Reda004001.CashAccount205>||XmlElement()||
|+|PmtInstrm|global::System.Collections.Generic.List<ISO20022.Reda004001.PaymentInstrument16>||XmlElement()||
|+|PlanChrtcs|global::System.Collections.Generic.List<ISO20022.Reda004001.InvestmentPlanCharacteristics1>||XmlElement()||
|+|SwtchPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics9||XmlElement()||
|+|RedPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics12||XmlElement()||
|+|SbcptPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics11||XmlElement()||
|+|InvstmtRstrctns|ISO20022.Reda004001.InvestmentRestrictions3||XmlElement()||
|+|ValtnDealgChrtcs|ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3||XmlElement()||
|+|FndDtls|ISO20022.Reda004001.FinancialInstrument96||XmlElement()||
|+|FndMgmtCpny|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
|+|MainFndOrdrDsk|ISO20022.Reda004001.OrderDesk1||XmlElement()||
|+|FndPties|ISO20022.Reda004001.FundParties1||XmlElement()||
|+|SctyId|ISO20022.Reda004001.SecurityIdentification47||XmlElement()||
|+|ExPstInd|String||XmlElement()||
|+|ExAnteInd|String||XmlElement()||
|+|TrgtMktInd|String||XmlElement()||
|+|GnlRefDt|DateTime||XmlElement()||
|+|AuthrsdPrxy|ISO20022.Reda004001.ContactAttributes6||XmlElement()||
|+|Vrsn|ISO20022.Reda004001.MarketPracticeVersion1||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(ValForMny),validElement(AddtlInfUKMkt),validList("""CostsAndChrgs""",CostsAndChrgs),validListMax("""CostsAndChrgs""",CostsAndChrgs,2),validElement(CostsAndChrgs),validElement(DstrbtnStrtgy),validElement(TrgtMkt),validList("""LclMktAnx""",LclMktAnx),validElement(LclMktAnx),validList("""CshSttlmDtls""",CshSttlmDtls),validElement(CshSttlmDtls),validList("""PmtInstrm""",PmtInstrm),validElement(PmtInstrm),validList("""PlanChrtcs""",PlanChrtcs),validElement(PlanChrtcs),validElement(SwtchPrcgChrtcs),validElement(RedPrcgChrtcs),validElement(SbcptPrcgChrtcs),validElement(InvstmtRstrctns),validElement(ValtnDealgChrtcs),validElement(FndDtls),validElement(FndMgmtCpny),validElement(MainFndOrdrDsk),validElement(FndPties),validElement(SctyId),validElement(AuthrsdPrxy),validElement(Vrsn))|

---

## Aspect ISO20022.Reda004001.FundReferenceDataReportV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Reda004001.FundReferenceDataReport5>||XmlElement()||
|+|FndRefDataRptId|String||XmlElement()||
|+|RltdRef|ISO20022.Reda004001.AdditionalReference10||XmlElement()||
|+|PrvsRef|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalReference10>||XmlElement()||
|+|MsgId|ISO20022.Reda004001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(MsgId))|

---

## Value ISO20022.Reda004001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Reda004001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Reda004001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda004001.GovernanceProcess1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.GovernanceProcessType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMIF|Int32||XmlEnum("""AMIF""")|1|
||CMIF|Int32||XmlEnum("""CMIF""")|2|
||NINF|Int32||XmlEnum("""NINF""")|3|
||BMIF|Int32||XmlEnum("""BMIF""")|4|

---

## Enum ISO20022.Reda004001.HoldingTransferable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RFOD|Int32||XmlEnum("""RFOD""")|1|
||TRNA|Int32||XmlEnum("""TRNA""")|2|
||TRAL|Int32||XmlEnum("""TRAL""")|3|

---

## Value ISO20022.Reda004001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda004001.IndividualCostOrCharge2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|RefPrd|ISO20022.Reda004001.Period15||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Reda004001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|ExAnteOrExPst|String||XmlElement()||
|+|CostTp|ISO20022.Reda004001.ChargeType8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(RefPrd),validElement(Amt),validElement(CostTp))|

---

## Enum ISO20022.Reda004001.IntendedOrActual2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POST|Int32||XmlEnum("""POST""")|1|
||ANTE|Int32||XmlEnum("""ANTE""")|2|

---

## Enum ISO20022.Reda004001.InvestmentFundMiFIDFee2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRS1|Int32||XmlEnum("""TRS1""")|1|
||RPSS|Int32||XmlEnum("""RPSS""")|2|
||OCAS|Int32||XmlEnum("""OCAS""")|3|
||OTES|Int32||XmlEnum("""OTES""")|4|
||PENO|Int32||XmlEnum("""PENO""")|5|
||BEND|Int32||XmlEnum("""BEND""")|6|
||ENBX|Int32||XmlEnum("""ENBX""")|7|
||EXAC|Int32||XmlEnum("""EXAC""")|8|
||ENFX|Int32||XmlEnum("""ENFX""")|9|
||ENAC|Int32||XmlEnum("""ENAC""")|10|
||BENS|Int32||XmlEnum("""BENS""")|11|
||OOSS|Int32||XmlEnum("""OOSS""")|12|
||OOSF|Int32||XmlEnum("""OOSF""")|13|
||OOEA|Int32||XmlEnum("""OOEA""")|14|
||NRAM|Int32||XmlEnum("""NRAM""")|15|
||NETO|Int32||XmlEnum("""NETO""")|16|
||NESF|Int32||XmlEnum("""NESF""")|17|
||NET2|Int32||XmlEnum("""NET2""")|18|
||MANS|Int32||XmlEnum("""MANS""")|19|
||MNF1|Int32||XmlEnum("""MNF1""")|20|
||INCS|Int32||XmlEnum("""INCS""")|21|
||INCF|Int32||XmlEnum("""INCF""")|22|
||GOCS|Int32||XmlEnum("""GOCS""")|23|
||GOC1|Int32||XmlEnum("""GOC1""")|24|
||FES2|Int32||XmlEnum("""FES2""")|25|
||FEND|Int32||XmlEnum("""FEND""")|26|
||FES3|Int32||XmlEnum("""FES3""")|27|
||DIS2|Int32||XmlEnum("""DIS2""")|28|
||BORF|Int32||XmlEnum("""BORF""")|29|

---

## Value ISO20022.Reda004001.InvestmentFundPlanType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.InvestmentFundPlanType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHP|Int32||XmlEnum("""WTHP""")|1|
||SWIP|Int32||XmlEnum("""SWIP""")|2|
||INVP|Int32||XmlEnum("""INVP""")|3|

---

## Value ISO20022.Reda004001.InvestmentNeed2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.InvestmentNeed2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISLB|Int32||XmlEnum("""ISLB""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NSPE|Int32||XmlEnum("""NSPE""")|3|

---

## Value ISO20022.Reda004001.InvestmentPlanCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|AddtlSbcptFctn|String||XmlElement()||
|+|AddtlSbcpt|String||XmlElement()||
|+|PlanConttn|String||XmlElement()||
|+|Qty|ISO20022.Reda004001.UnitsOrAmount1Choice||XmlElement()||
|+|TtlNbOfInstlmts|Decimal||XmlElement()||
|+|Frqcy|ISO20022.Reda004001.Frequency20Choice||XmlElement()||
|+|PlanTp|ISO20022.Reda004001.InvestmentFundPlanType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(Qty),validElement(Frqcy),validElement(PlanTp))|

---

## Value ISO20022.Reda004001.InvestmentRestrictions3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|HldgTrfbl|String||XmlElement()||
|+|MinHldgPrd|String||XmlElement()||
|+|MinHldgUnits|Decimal||XmlElement()||
|+|MinHldgAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
|+|OthrSwtchRstrctns|String||XmlElement()||
|+|MaxSwtchRedUnits|Decimal||XmlElement()||
|+|MaxSwtchRedAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
|+|MinSwtchSbcptUnits|Decimal||XmlElement()||
|+|MinSwtchSbcptAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
|+|OthrRedRstrctns|String||XmlElement()||
|+|MinRedPctg|Decimal||XmlElement()||
|+|MaxRedUnits|Decimal||XmlElement()||
|+|MaxRedAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
|+|MinSbsqntSbcptUnits|Decimal||XmlElement()||
|+|MinSbsqntSbcptAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
|+|MinInitlSbcptUnits|Decimal||XmlElement()||
|+|MinInitlSbcptAmt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(MinHldgAmt),validElement(MaxSwtchRedAmt),validElement(MinSwtchSbcptAmt),validElement(MaxRedAmt),validElement(MinSbsqntSbcptAmt),validElement(MinInitlSbcptAmt))|

---

## Value ISO20022.Reda004001.InvestorKnowledge1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1>||XmlElement()||
|+|ExprtInvstrDE|String||XmlElement()||
|+|AdvncdInvstr|String||XmlElement()||
|+|InfrmdInvstr|String||XmlElement()||
|+|BsicInvstr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr))|

---

## Value ISO20022.Reda004001.InvestorRequirements4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherInvestmentNeed1>||XmlElement()||
|+|OthrSpcfcInvstmtNeed|ISO20022.Reda004001.InvestmentNeed2Choice||XmlElement()||
|+|SstnbltyPrefs|String||XmlElement()||
|+|MinHldgPrd|ISO20022.Reda004001.TimeHorizon2Choice||XmlElement()||
|+|RtrPrflPnsnSchmeDE|String||XmlElement()||
|+|OptnOrLvrgdRtrPrfl|String||XmlElement()||
|+|RtrPrflHdgg|String||XmlElement()||
|+|RtrPrflIncm|String||XmlElement()||
|+|RtrPrflGrwth|String||XmlElement()||
|+|RtrPrflPrsrvtn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(OthrSpcfcInvstmtNeed),validElement(MinHldgPrd))|

---

## Value ISO20022.Reda004001.InvestorType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherTargetMarketInvestor1>||XmlElement()||
|+|InvstrTpElgblCtrPty|String||XmlElement()||
|+|InvstrTpPrfssnl|ISO20022.Reda004001.TargetMarket5Choice||XmlElement()||
|+|InvstrTpRtl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(InvstrTpPrfssnl))|

---

## Enum ISO20022.Reda004001.InvestorType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRF2|Int32||XmlEnum("""PRF2""")|1|
||EPRO|Int32||XmlEnum("""EPRO""")|2|
||BOT3|Int32||XmlEnum("""BOT3""")|3|

---

## Enum ISO20022.Reda004001.InvestorType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOT2|Int32||XmlEnum("""BOT2""")|1|
||NEI1|Int32||XmlEnum("""NEI1""")|2|
||PRF2|Int32||XmlEnum("""PRF2""")|3|
||RETL|Int32||XmlEnum("""RETL""")|4|

---

## Enum ISO20022.Reda004001.InvestorType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRF4|Int32||XmlEnum("""PRF4""")|1|
||PRF3|Int32||XmlEnum("""PRF3""")|2|
||NPRF|Int32||XmlEnum("""NPRF""")|3|
||BOT3|Int32||XmlEnum("""BOT3""")|4|

---

## Value ISO20022.Reda004001.LocalMarketAnnex6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|CshSttlmDtls|global::System.Collections.Generic.List<ISO20022.Reda004001.CashAccount205>||XmlElement()||
|+|SwtchPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics9||XmlElement()||
|+|RedPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics10||XmlElement()||
|+|SbcptPrcgChrtcs|ISO20022.Reda004001.ProcessingCharacteristics11||XmlElement()||
|+|LclOrdrDsk|ISO20022.Reda004001.OrderDesk1||XmlElement()||
|+|Ctry|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""CshSttlmDtls""",CshSttlmDtls),validElement(CshSttlmDtls),validElement(SwtchPrcgChrtcs),validElement(RedPrcgChrtcs),validElement(SbcptPrcgChrtcs),validElement(LclOrdrDsk),validRequired("""Ctry""",Ctry),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Reda004001.LossBearing2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherTargetMarketLossBearing1>||XmlElement()||
|+|LossByndCptl|String||XmlElement()||
|+|NoCptlGrnt|String||XmlElement()||
|+|LtdCptlLossLvl|Decimal||XmlElement()||
|+|LtdCptlLoss|String||XmlElement()||
|+|NoCptlLoss|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr))|

---

## Value ISO20022.Reda004001.MainFundOrderDeskLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmZoneOffSet|ISO20022.Reda004001.UTCOffset1||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmZoneOffSet),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Reda004001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda004001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda004001.NotionalOrUnitBased1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.NotionalOrUnitBased1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTI|Int32||XmlEnum("""NOTI""")|1|
||UNIT|Int32||XmlEnum("""UNIT""")|2|

---

## Value ISO20022.Reda004001.OrderDesk1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|ClsrDts|global::System.Collections.Generic.List<DateTime>||XmlElement()||
|+|OrdrDsk|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(OrdrDsk))|

---

## Value ISO20022.Reda004001.OtherDistributionStrategy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.DistributionStrategy1Choice||XmlElement()||
|+|DstrbtnStrtgyTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Value ISO20022.Reda004001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Reda004001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Reda004001.OtherInvestmentNeed1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.TargetMarket1Choice||XmlElement()||
|+|ClntObjctvsAndNeedsTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Enum ISO20022.Reda004001.OtherReviewRelatedToValueAndOrChargesUKType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REVO|Int32||XmlEnum("""REVO""")|1|
||REVA|Int32||XmlEnum("""REVA""")|2|

---

## Value ISO20022.Reda004001.OtherTargetMarket1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|TrgtMktTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf))|

---

## Value ISO20022.Reda004001.OtherTargetMarketInvestor1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.TargetMarket3Choice||XmlElement()||
|+|InvstrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Value ISO20022.Reda004001.OtherTargetMarketInvestorKnowledge1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.TargetMarket1Choice||XmlElement()||
|+|InvstrKnwldgTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Value ISO20022.Reda004001.OtherTargetMarketLossBearing1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.TargetMarket1Choice||XmlElement()||
|+|AbltyToBearLossesTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Value ISO20022.Reda004001.OtherTargetMarketRiskTolerance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Reda004001.AdditionalInformation15||XmlElement()||
|+|Trgt|ISO20022.Reda004001.TargetMarket1Choice||XmlElement()||
|+|RskTlrnceTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(Trgt))|

---

## Enum ISO20022.Reda004001.OutcomeOfCOLLAssessmentOfValueUKType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COL2|Int32||XmlEnum("""COL2""")|1|
||COL1|Int32||XmlEnum("""COL1""")|2|

---

## Enum ISO20022.Reda004001.OutcomeOfPRINValueAssessmentOrReviewUKType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRI1|Int32||XmlEnum("""PRI1""")|1|
||PRI2|Int32||XmlEnum("""PRI2""")|2|

---

## Value ISO20022.Reda004001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda004001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda004001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda004001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Reda004001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Reda004001.PaymentInstrument16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|InstrmTp|ISO20022.Reda004001.FundPaymentType1Choice||XmlElement()||
|+|OrdrTp|ISO20022.Reda004001.FundOrderType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(InstrmTp),validElement(OrdrTp))|

---

## Value ISO20022.Reda004001.Period15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.PostalAddress1


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

## Enum ISO20022.Reda004001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Reda004001.ProcessingCharacteristics10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|SttlmCycl|ISO20022.Reda004001.TimeFrame8Choice||XmlElement()||
|+|LtdPrd|String||XmlElement()||
|+|DealConfTmFrame|ISO20022.Reda004001.TimeFrame8||XmlElement()||
|+|DealConfTm|DateTime||XmlElement()||
|+|DealgCutOffTmFrame|ISO20022.Reda004001.TimeFrame9||XmlElement()||
|+|DealgCutOffTm|DateTime||XmlElement()||
|+|DealgFrqcyDesc|String||XmlElement()||
|+|DealgFrqcy|String||XmlElement()||
|+|MainFndOrdrDskLctn|ISO20022.Reda004001.MainFundOrderDeskLocation1||XmlElement()||
|+|PctgInd|String||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsInd|String||XmlElement()||
|+|AmtInd|String||XmlElement()||
|+|RedAuthstn|ISO20022.Reda004001.Forms1||XmlElement()||
|+|DealgCcyAccptd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmCycl),validElement(DealConfTmFrame),validElement(DealgCutOffTmFrame),validElement(MainFndOrdrDskLctn),validElement(RedAuthstn),validPattern("""DealgCcyAccptd""",DealgCcyAccptd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ProcessingCharacteristics11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|SttlmCycl|ISO20022.Reda004001.TimeFrame7Choice||XmlElement()||
|+|LtdPrd|String||XmlElement()||
|+|DealConfTmFrame|ISO20022.Reda004001.TimeFrame11||XmlElement()||
|+|DealConfTm|DateTime||XmlElement()||
|+|DealgCutOffTmFrame|ISO20022.Reda004001.TimeFrame9||XmlElement()||
|+|DealgCutOffTm|DateTime||XmlElement()||
|+|DealgFrqcyDesc|String||XmlElement()||
|+|DealgFrqcy|String||XmlElement()||
|+|MainFndOrdrDskLctn|ISO20022.Reda004001.MainFundOrderDeskLocation1||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsInd|String||XmlElement()||
|+|AmtInd|String||XmlElement()||
|+|SbsqntInvstmtAppl|ISO20022.Reda004001.Forms1||XmlElement()||
|+|InitlInvstmtAppl|ISO20022.Reda004001.Forms1||XmlElement()||
|+|DealgCcyAccptd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmCycl),validElement(DealConfTmFrame),validElement(DealgCutOffTmFrame),validElement(MainFndOrdrDskLctn),validElement(SbsqntInvstmtAppl),validElement(InitlInvstmtAppl),validPattern("""DealgCcyAccptd""",DealgCcyAccptd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ProcessingCharacteristics12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|SttlmCycl|ISO20022.Reda004001.TimeFrame8Choice||XmlElement()||
|+|LtdPrd|String||XmlElement()||
|+|DealConfTmFrame|ISO20022.Reda004001.TimeFrame10||XmlElement()||
|+|DealConfTm|DateTime||XmlElement()||
|+|DealgCutOffTmFrame|ISO20022.Reda004001.TimeFrame9||XmlElement()||
|+|DealgCutOffTm|DateTime||XmlElement()||
|+|DealgFrqcyDesc|String||XmlElement()||
|+|DealgFrqcy|String||XmlElement()||
|+|MainFndOrdrDskLctn|ISO20022.Reda004001.MainFundOrderDeskLocation1||XmlElement()||
|+|PctgInd|String||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsInd|String||XmlElement()||
|+|AmtInd|String||XmlElement()||
|+|RedAuthstn|ISO20022.Reda004001.Forms1||XmlElement()||
|+|DealgCcyAccptd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmCycl),validElement(DealConfTmFrame),validElement(DealgCutOffTmFrame),validElement(MainFndOrdrDskLctn),validElement(RedAuthstn),validPattern("""DealgCcyAccptd""",DealgCcyAccptd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ProcessingCharacteristics9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|SttlmCycl|ISO20022.Reda004001.TimeFrame8Choice||XmlElement()||
|+|LtdPrd|String||XmlElement()||
|+|DealConfTmFrame|ISO20022.Reda004001.TimeFrame8||XmlElement()||
|+|DealConfTm|DateTime||XmlElement()||
|+|DealgCutOffTmFrame|ISO20022.Reda004001.TimeFrame9||XmlElement()||
|+|DealgCutOffTm|DateTime||XmlElement()||
|+|DealgFrqcyDesc|String||XmlElement()||
|+|DealgFrqcy|String||XmlElement()||
|+|MainFndOrdrDskLctn|ISO20022.Reda004001.MainFundOrderDeskLocation1||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsInd|String||XmlElement()||
|+|AmtInd|String||XmlElement()||
|+|SwtchAuthstn|ISO20022.Reda004001.Forms1||XmlElement()||
|+|DealgCcyAccptd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmCycl),validElement(DealConfTmFrame),validElement(DealgCutOffTmFrame),validElement(MainFndOrdrDskLctn),validElement(SwtchAuthstn),validPattern("""DealgCcyAccptd""",DealgCcyAccptd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ProductStructure1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.ProductStructure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NUCI|Int32||XmlEnum("""NUCI""")|1|
||SFUN|Int32||XmlEnum("""SFUN""")|2|
||SSEC|Int32||XmlEnum("""SSEC""")|3|
||UCIT|Int32||XmlEnum("""UCIT""")|4|
||EXTC|Int32||XmlEnum("""EXTC""")|5|
||UCMM|Int32||XmlEnum("""UCMM""")|6|
||NUMM|Int32||XmlEnum("""NUMM""")|7|
||BOND|Int32||XmlEnum("""BOND""")|8|

---

## Value ISO20022.Reda004001.QuotationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.QuotationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRCT|Int32||XmlEnum("""PRCT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Enum ISO20022.Reda004001.ReferToFundOrderDesk1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RFOD|Int32||XmlEnum("""RFOD""")|1|

---

## Enum ISO20022.Reda004001.RiskLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MEDM|Int32||XmlEnum("""MEDM""")|1|
||LOWW|Int32||XmlEnum("""LOWW""")|2|
||HIGH|Int32||XmlEnum("""HIGH""")|3|

---

## Value ISO20022.Reda004001.RiskTolerance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherTargetMarketRiskTolerance1>||XmlElement()||
|+|NotForInvstrsWthTheLwstRskTlrnceDE|String||XmlElement()||
|+|RskTlrnceForNonPRIIPSAndNonUCITSES|Decimal||XmlElement()||
|+|RskTlrnceIntl|String||XmlElement()||
|+|RskTlrnceUCITSMthdlgy|Decimal||XmlElement()||
|+|RskTlrncePRIIPSMthdlgy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr))|

---

## Enum ISO20022.Reda004001.RoundingDirection2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDWN|Int32||XmlEnum("""RDWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|

---

## Value ISO20022.Reda004001.SecurityClassificationType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Reda004001.GenericIdentification3||XmlElement()||
|+|CFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""CFI""",CFI,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,CFI))|

---

## Value ISO20022.Reda004001.SecurityIdentification40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ISIN|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validList("""OthrId""",OthrId),validElement(OthrId))|

---

## Value ISO20022.Reda004001.SecurityIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|ExPstCostClctnBsis|ISO20022.Reda004001.ExPostCostCalculationBasis1Choice||XmlElement()||
|+|NoRtrcssnInd|String||XmlElement()||
|+|LvrgdOrCntngntLblty|String||XmlElement()||
|+|QtnTp|ISO20022.Reda004001.QuotationType1Choice||XmlElement()||
|+|NtnlOrUnitBased|ISO20022.Reda004001.NotionalOrUnitBased1Choice||XmlElement()||
|+|PdctCtgyDE|String||XmlElement()||
|+|PdctCtgy|String||XmlElement()||
|+|IssrPdctGovncPrc|ISO20022.Reda004001.GovernanceProcess1Choice||XmlElement()||
|+|Issr|ISO20022.Reda004001.ContactAttributes5||XmlElement()||
|+|PdctTp|ISO20022.Reda004001.ProductStructure1Choice||XmlElement()||
|+|RegdDstrbtnCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtryOfDmcl|String||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|ClssfctnTp|ISO20022.Reda004001.SecurityClassificationType2Choice||XmlElement()||
|+|NewUmbrll|String||XmlElement()||
|+|UmbrllNm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Reda004001.SecurityIdentification40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(ExPstCostClctnBsis),validElement(QtnTp),validElement(NtnlOrUnitBased),validElement(IssrPdctGovncPrc),validElement(Issr),validElement(PdctTp),validPattern("""RegdDstrbtnCtry""",RegdDstrbtnCtry,"""[A-Z]{2,2}"""),validPattern("""CtryOfDmcl""",CtryOfDmcl,"""[A-Z]{2,2}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""),validElement(ClssfctnTp),validElement(Id))|

---

## Enum ISO20022.Reda004001.SignatureType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONE|Int32||XmlEnum("""NONE""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|
||DIGI|Int32||XmlEnum("""DIGI""")|3|
||ORIG|Int32||XmlEnum("""ORIG""")|4|

---

## Enum ISO20022.Reda004001.SustainabilityPreferences2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSCO|Int32||XmlEnum("""YSCO""")|1|
||NEUT|Int32||XmlEnum("""NEUT""")|2|

---

## Value ISO20022.Reda004001.TargetMarket1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda004001.TargetMarket1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSCO|Int32||XmlEnum("""NSCO""")|1|
||NEUT|Int32||XmlEnum("""NEUT""")|2|
||YSCO|Int32||XmlEnum("""YSCO""")|3|

---

## Enum ISO20022.Reda004001.TargetMarket2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSCO|Int32||XmlEnum("""YSCO""")|1|
||NEUT|Int32||XmlEnum("""NEUT""")|2|

---

## Value ISO20022.Reda004001.TargetMarket3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Othr|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Othr,Tp))|

---

## Enum ISO20022.Reda004001.TargetMarket3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSCO|Int32||XmlEnum("""NSCO""")|1|
||YSCO|Int32||XmlEnum("""YSCO""")|2|

---

## Value ISO20022.Reda004001.TargetMarket4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Reda004001.OtherTargetMarket1>||XmlElement()||
|+|ClntObjctvsAndNeeds|ISO20022.Reda004001.InvestorRequirements4||XmlElement()||
|+|RskTlrnce|ISO20022.Reda004001.RiskTolerance1||XmlElement()||
|+|AbltyToBearLosses|ISO20022.Reda004001.LossBearing2||XmlElement()||
|+|KnwldgAndOrExprnc|ISO20022.Reda004001.InvestorKnowledge1||XmlElement()||
|+|InvstrTp|ISO20022.Reda004001.InvestorType2||XmlElement()||
|+|RefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(ClntObjctvsAndNeeds),validElement(RskTlrnce),validElement(AbltyToBearLosses),validElement(KnwldgAndOrExprnc),validElement(InvstrTp))|

---

## Value ISO20022.Reda004001.TargetMarket5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Othr,Tp))|

---

## Value ISO20022.Reda004001.TimeFrame10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefrToOrdrDsk|String||XmlElement()||
|+|NonWorkgDayAdjstmnt|String||XmlElement()||
|+|TPlus|Decimal||XmlElement()||
|+|OthrTmFrameDesc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.TimeFrame11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefrToOrdrDsk|String||XmlElement()||
|+|NonWorkgDayAdjstmnt|String||XmlElement()||
|+|TPlus|Decimal||XmlElement()||
|+|OthrTmFrameDesc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda004001.TimeFrame2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VSHT|Int32||XmlEnum("""VSHT""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|
||MEDM|Int32||XmlEnum("""MEDM""")|3|
||LONG|Int32||XmlEnum("""LONG""")|4|
||HOLD|Int32||XmlEnum("""HOLD""")|5|

---

## Value ISO20022.Reda004001.TimeFrame7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prepmt|String||XmlElement()||
|+|TPlus|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prepmt,TPlus))|

---

## Value ISO20022.Reda004001.TimeFrame8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefrToOrdrDsk|String||XmlElement()||
|+|NonWorkgDayAdjstmnt|String||XmlElement()||
|+|TPlus|Decimal||XmlElement()||
|+|OthrTmFrameDesc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.TimeFrame8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RPlus|Decimal||XmlElement()||
|+|TPlus|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(RPlus,TPlus))|

---

## Value ISO20022.Reda004001.TimeFrame9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefrToOrdrDsk|String||XmlElement()||
|+|NonWorkgDayAdjstmnt|String||XmlElement()||
|+|TMns|Decimal||XmlElement()||
|+|OthrTmFrameDesc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.TimeFrame9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda004001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda004001.TimeHorizon2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmFrame|ISO20022.Reda004001.TimeFrame9Choice||XmlElement()||
|+|NbOfYrs|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmFrame),validChoice(TmFrame,NbOfYrs))|

---

## Value ISO20022.Reda004001.UTCOffset1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfHrs|DateTime||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda004001.UnitsOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|Decimal||XmlElement()||
|+|Amt|ISO20022.Reda004001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Unit,Amt))|

---

## Value ISO20022.Reda004001.ValuationDealingProcessingCharacteristics3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Reda004001.AdditionalInformation15>||XmlElement()||
|+|PricCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|DualFndInd|String||XmlElement()||
|+|DcmlstnPric|Decimal||XmlElement()||
|+|DcmlstnUnits|Decimal||XmlElement()||
|+|ValtnTm|DateTime||XmlElement()||
|+|ValtnFrqcyDesc|String||XmlElement()||
|+|ValtnFrqcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validPattern("""PricCcy""",PricCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda004001.ValueForMoney1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RvwNxtDueUK|DateTime||XmlElement()||
|+|RvwDtUK|DateTime||XmlElement()||
|+|FrthrInfUK|String||XmlElement()||
|+|OthrRvwRltdToValAndOrChrgsUK|String||XmlElement()||
|+|OutcmOfPRINValAssmntOrRvwUK|String||XmlElement()||
|+|OutcmOfCOLLAssmntOfValUK|String||XmlElement()||
|+|AssmntOfValReqrdUdrCOLLUK|String||XmlElement()||
|+|EMTDataRptgVFMUK|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

