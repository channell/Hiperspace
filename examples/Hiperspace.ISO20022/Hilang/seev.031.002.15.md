# seev.031.002.15
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev031002.AccountAndBalance65 {
        + Bal  : ISO20022.Seev031002.CorporateActionBalanceDetails46
        + SfkpgPlc  : ISO20022.Seev031002.SafekeepingPlaceFormat55Choice
        + AcctOwnr  : ISO20022.Seev031002.PartyIdentification136Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev031002.AccountAndBalance65 *-- ISO20022.Seev031002.CorporateActionBalanceDetails46
    ISO20022.Seev031002.AccountAndBalance65 *-- ISO20022.Seev031002.SafekeepingPlaceFormat55Choice
    ISO20022.Seev031002.AccountAndBalance65 *-- ISO20022.Seev031002.PartyIdentification136Choice
    class ISO20022.Seev031002.AccountIdentification10 {
        + IdCd  : String
    }
    class ISO20022.Seev031002.AccountIdentification78Choice {
        + AcctsListAndBalDtls  : global::System.Collections.Generic.List~ISO20022.Seev031002.AccountAndBalance65~
        + ForAllAccts  : ISO20022.Seev031002.AccountIdentification10
    }
    ISO20022.Seev031002.AccountIdentification78Choice *-- ISO20022.Seev031002.AccountAndBalance65
    ISO20022.Seev031002.AccountIdentification78Choice *-- ISO20022.Seev031002.AccountIdentification10
    class ISO20022.Seev031002.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev031002.AdditionalBusinessProcess9Code {
        INCP = 1
        REAC = 2
        PPRE = 3
        FPRE = 4
        PPUT = 5
        CONS = 6
        SCHM = 7
        NPLE = 8
        NAMC = 9
        CNTR = 10
        ATXF = 11
        ACLA = 12
    }
    class ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.AmountAndQuantityRatio5 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.AmountAndQuantityRatio5 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountAndRateStatus2 {
        + RateSts  : String
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.AmountAndRateStatus2 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPrice4 {
        + PricVal  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031002.AmountPrice4 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPrice5 {
        + PricVal  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031002.AmountPrice5 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPrice7 {
        + PricVal  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031002.AmountPrice7 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPricePerAmount3 {
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031002.AmountPricePerAmount3 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.AmountPricePerAmount3 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11 {
        + FinInstrmQty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + PricVal  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev031002.AmountPriceType2Code {
        ACTU = 1
    }
    class ISO20022.Seev031002.AmountPriceType3Code {
        PLOT = 1
        ACTU = 2
    }
    class ISO20022.Seev031002.AmountToAmountRatio3 {
        + Amt2  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Amt1  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.AmountToAmountRatio3 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.AmountToAmountRatio3 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev031002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev031002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev031002.SignedQuantityFormat12
    }
    ISO20022.Seev031002.BalanceFormat14Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat14Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat14Choice *-- ISO20022.Seev031002.SignedQuantityFormat12
    class ISO20022.Seev031002.BalanceFormat16Choice {
        + PartWayPrdUnits  : ISO20022.Seev031002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev031002.SignedQuantityFormat13
        + NotElgblBal  : ISO20022.Seev031002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev031002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev031002.SignedQuantityFormat12
    }
    ISO20022.Seev031002.BalanceFormat16Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat16Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat16Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat16Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.BalanceFormat16Choice *-- ISO20022.Seev031002.SignedQuantityFormat12
    class ISO20022.Seev031002.BeneficiaryCertificationType15Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.BeneficiaryCertificationType15Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.BeneficiaryCertificationType6Code {
        DIOR = 1
        PAPW = 2
        FRAC = 3
        PABD = 4
        TRBD = 5
        QIBB = 6
        NCOM = 7
        FULL = 8
        NDOM = 9
        DOMI = 10
        ACCI = 11
    }
    class ISO20022.Seev031002.BidRangeType1Code {
        MULT = 1
        INCR = 2
        DIVI = 3
    }
    class ISO20022.Seev031002.BidRangeType2Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.BidRangeType2Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.BlockChainAddressWallet11 {
        + Nm  : String
        + Tp  : ISO20022.Seev031002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Seev031002.BlockChainAddressWallet11 *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.BorrowerLendingDeadline6 {
        + Brrwr  : ISO20022.Seev031002.PartyIdentification136Choice
        + StockLndgDdln  : ISO20022.Seev031002.DateFormat49Choice
    }
    ISO20022.Seev031002.BorrowerLendingDeadline6 *-- ISO20022.Seev031002.PartyIdentification136Choice
    ISO20022.Seev031002.BorrowerLendingDeadline6 *-- ISO20022.Seev031002.DateFormat49Choice
    class ISO20022.Seev031002.CapitalGainFormat4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CapitalGainFormat4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CashAccountIdentification15Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev031002.BlockChainAddressWallet11
        + IBAN  : String
    }
    ISO20022.Seev031002.CashAccountIdentification15Choice *-- ISO20022.Seev031002.BlockChainAddressWallet11
    class ISO20022.Seev031002.CashOption113 {
        + PricDtls  : ISO20022.Seev031002.PriceDetails43
        + RateAndAmtDtls  : ISO20022.Seev031002.Rate47
        + FXDtls  : ISO20022.Seev031002.ForeignExchangeTerms43
        + DtDtls  : ISO20022.Seev031002.CorporateActionDate97
        + AmtDtls  : ISO20022.Seev031002.CorporateActionAmounts76
        + CshAcctId  : ISO20022.Seev031002.CashAccountIdentification15Choice
        + CtryOfIncmSrc  : String
        + PricClctnMtd  : ISO20022.Seev031002.PriceCalculationMethod1Choice
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev031002.GenericIdentification47
        + IssrOfferrTaxbltyInd  : ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice
        + NonElgblPrcdsInd  : ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice
        + CtrctlPmtInd  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.PriceDetails43
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.Rate47
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.ForeignExchangeTerms43
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.CorporateActionDate97
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.CorporateActionAmounts76
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.CashAccountIdentification15Choice
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.PriceCalculationMethod1Choice
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice
    ISO20022.Seev031002.CashOption113 *-- ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice
    class ISO20022.Seev031002.CertificationFormatType1Code {
        PHYS = 1
        ELEC = 2
    }
    class ISO20022.Seev031002.CertificationTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CertificationTypeFormat4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Seev031002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Seev031002.ClassificationType33Choice *-- ISO20022.Seev031002.GenericIdentification86
    class ISO20022.Seev031002.ConsentType1Code {
        DUPY = 1
        CTRM = 2
    }
    class ISO20022.Seev031002.ConsentTypeFormat5Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.ConsentTypeFormat5Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateAction87 {
        + AddtlInf  : ISO20022.Seev031002.CorporateActionNarrative63
        + NewPlcOfIncorprtn  : String
        + DtchAuctnTp  : ISO20022.Seev031002.DutchAuctionTypeFormat2Choice
        + TaxOnNonDstrbtdPrcdsInd  : global::System.Collections.Generic.List~ISO20022.Seev031002.GenericIdentification47~
        + InfTp  : ISO20022.Seev031002.InformationTypeFormat5Choice
        + CnsntTp  : ISO20022.Seev031002.ConsentTypeFormat5Choice
        + CertfctnTp  : ISO20022.Seev031002.CertificationTypeFormat4Choice
        + LtryTp  : ISO20022.Seev031002.LotteryTypeFormat5Choice
        + ElctnTp  : ISO20022.Seev031002.ElectionTypeFormat4Choice
        + TaxblIncmPerShrClctd  : ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice
        + CptlGnInOutInd  : ISO20022.Seev031002.CapitalGainFormat4Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice
        + ChngTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice~
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice~
        + EvtStag  : global::System.Collections.Generic.List~ISO20022.Seev031002.CorporateActionEventStageFormat20Choice~
        + RnncblEntitlmntStsTp  : ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.OfferTypeFormat16Choice~
        + OcrncTp  : ISO20022.Seev031002.DistributionTypeFormat8Choice
        + EvtSeqTp  : ISO20022.Seev031002.EventSequenceTypeFormat2Choice
        + DvddTp  : ISO20022.Seev031002.DividendTypeFormat10Choice
        + ShrhldrRghtsDrctvInd  : String
        + LttrOfGrntedDlvryInd  : String
        + FrftrOfIntrstInd  : String
        + AcrdIntrstInd  : String
        + RstrctnInd  : String
        + ChrgsApldInd  : String
        + CertfctnBrkdwnInd  : String
        + AccptncPrtyLvl  : String
        + CpnNb  : global::System.Collections.Generic.List~ISO20022.Seev031002.IdentificationFormat4Choice~
        + IntrstAcrdNbOfDays  : Decimal
        + SctiesQty  : ISO20022.Seev031002.CorporateActionQuantity14
        + PricDtls  : ISO20022.Seev031002.CorporateActionPrice96
        + RateAndAmtDtls  : ISO20022.Seev031002.CorporateActionRate135
        + PrdDtls  : ISO20022.Seev031002.CorporateActionPeriod16
        + DtDtls  : ISO20022.Seev031002.CorporateActionDate96
    }
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionNarrative63
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.DutchAuctionTypeFormat2Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.InformationTypeFormat5Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.ConsentTypeFormat5Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CertificationTypeFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.LotteryTypeFormat5Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.ElectionTypeFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CapitalGainFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionEventStageFormat20Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.OfferTypeFormat16Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.DistributionTypeFormat8Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.EventSequenceTypeFormat2Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.DividendTypeFormat10Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.IdentificationFormat4Choice
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionQuantity14
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionPrice96
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionRate135
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionPeriod16
    ISO20022.Seev031002.CorporateAction87 *-- ISO20022.Seev031002.CorporateActionDate96
    class ISO20022.Seev031002.CorporateActionAmounts61 {
        + ScndLvlTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev031002.CorporateActionAmounts61 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts61 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev031002.CorporateActionAmounts76 {
        + BuyUpAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + DmdRyltsAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + DmdIntrstAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + DmdFndAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + DmdDvddAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + FrgnIncmAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + DmdAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TxTax  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TaxOnIncmAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + BckUpWhldgTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + NRATaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + FATCATaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + EqulstnAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + EUTaxRtntnAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + StockXchgTax  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + IncmPrtn  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + RedPrmAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + PrncplOrCrps  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + EntitldAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ChrgsAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ScndLvlTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + ManfctrdDvddPmtAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + GrssAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev031002.CorporateActionAmounts76 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev031002.CorporateActionBalanceDetails46 {
        + UafctdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + AfctdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + InstdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + UinstdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + OblgtdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + RegdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + InTrnsShipmntBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + TradDtPosBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + StrtPosBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + SttlmPosBal  : global::System.Collections.Generic.List~ISO20022.Seev031002.BalanceFormat16Choice~
        + OutForRegnBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev031002.BalanceFormat16Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev031002.BalanceFormat16Choice~
        + OnLnBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + CollOutBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + CollInBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + BrrwdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + BlckdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + TtlElgblBal  : ISO20022.Seev031002.TotalEligibleBalanceFormat11
    }
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat16Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat16Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat16Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.CorporateActionBalanceDetails46 *-- ISO20022.Seev031002.TotalEligibleBalanceFormat11
    class ISO20022.Seev031002.CorporateActionChangeType1Code {
        DECI = 1
        TERM = 2
        REBE = 3
        PHDE = 4
        NAME = 5
        GTPH = 6
        GTGP = 7
        GPPH = 8
        DEPH = 9
        CERT = 10
        BERE = 11
    }
    class ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionDate108 {
        + DcmnttnDdln  : ISO20022.Seev031002.DateFormat49Choice
        + EndOfSctiesBlckgPrd  : ISO20022.Seev031002.DateFormat71Choice
        + BrrwrStockLndgDdln  : global::System.Collections.Generic.List~ISO20022.Seev031002.BorrowerLendingDeadline6~
        + StockLndgDdln  : ISO20022.Seev031002.DateFormat49Choice
        + DpstryCoverXprtnDt  : ISO20022.Seev031002.DateFormat49Choice
        + SbcptCostDbtDt  : ISO20022.Seev031002.DateFormat49Choice
        + XpryDt  : ISO20022.Seev031002.DateFormat49Choice
        + RspnDdln  : ISO20022.Seev031002.DateFormat54Choice
        + MktDdln  : ISO20022.Seev031002.DateFormat49Choice
        + PrtctDdln  : ISO20022.Seev031002.DateFormat49Choice
        + CoverXprtnDdln  : ISO20022.Seev031002.DateFormat49Choice
        + EarlyRspnDdln  : ISO20022.Seev031002.DateFormat49Choice
    }
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat71Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.BorrowerLendingDeadline6
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat54Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate108 *-- ISO20022.Seev031002.DateFormat49Choice
    class ISO20022.Seev031002.CorporateActionDate96 {
        + HrgDt  : ISO20022.Seev031002.DateFormat41Choice
        + FilgDt  : ISO20022.Seev031002.DateFormat41Choice
        + LeadPlntffDdln  : ISO20022.Seev031002.DateFormat49Choice
        + MktClmTrckgEndDt  : ISO20022.Seev031002.DateFormat41Choice
        + EarlyThrdPtyDdln  : ISO20022.Seev031002.DateFormat49Choice
        + ThrdPtyDdln  : ISO20022.Seev031002.DateFormat49Choice
        + PmtDt  : ISO20022.Seev031002.DateFormat41Choice
        + LpsdDt  : ISO20022.Seev031002.DateFormat41Choice
        + ElctnToCtrPtyRspnDdln  : ISO20022.Seev031002.DateFormat49Choice
        + ElctnToCtrPtyMktDdln  : ISO20022.Seev031002.DateFormat49Choice
        + GrntedPrtcptnDt  : ISO20022.Seev031002.DateFormat41Choice
        + SpclExDt  : ISO20022.Seev031002.DateFormat41Choice
        + OffclAnncmntPblctnDt  : ISO20022.Seev031002.DateFormat49Choice
        + ExDvddDt  : ISO20022.Seev031002.DateFormat41Choice
        + WhlyUcondlDt  : ISO20022.Seev031002.DateFormat41Choice
        + UcondlDt  : ISO20022.Seev031002.DateFormat41Choice
        + TradgSspdDt  : ISO20022.Seev031002.DateFormat49Choice
        + DdlnForTaxBrkdwnInstr  : ISO20022.Seev031002.DateFormat49Choice
        + DdlnToSplt  : ISO20022.Seev031002.DateFormat49Choice
        + RsltsPblctnDt  : ISO20022.Seev031002.DateFormat49Choice
        + RegnDdln  : ISO20022.Seev031002.DateFormat49Choice
        + RcrdDt  : ISO20022.Seev031002.DateFormat41Choice
        + PrratnDt  : ISO20022.Seev031002.DateFormat41Choice
        + MrgnFxgDt  : ISO20022.Seev031002.DateFormat41Choice
        + MtgDt  : ISO20022.Seev031002.DateFormat49Choice
        + NewMtrtyDt  : ISO20022.Seev031002.DateFormat41Choice
        + LtryDt  : ISO20022.Seev031002.DateFormat41Choice
        + FxgDt  : ISO20022.Seev031002.DateFormat49Choice
        + FrthrDtldAnncmntDt  : ISO20022.Seev031002.DateFormat49Choice
        + EqulstnDt  : ISO20022.Seev031002.DateFormat41Choice
        + FctvDt  : ISO20022.Seev031002.DateFormat41Choice
        + EarlyClsgDt  : ISO20022.Seev031002.DateFormat49Choice
        + CrtApprvlDt  : ISO20022.Seev031002.DateFormat41Choice
        + CertfctnDdln  : ISO20022.Seev031002.DateFormat49Choice
        + AnncmntDt  : ISO20022.Seev031002.DateFormat49Choice
    }
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate96 *-- ISO20022.Seev031002.DateFormat49Choice
    class ISO20022.Seev031002.CorporateActionDate97 {
        + EarlstPmtDt  : ISO20022.Seev031002.DateFormat41Choice
        + FXRateFxgDt  : ISO20022.Seev031002.DateFormat49Choice
        + ValDt  : ISO20022.Seev031002.DateFormat64Choice
        + PmtDt  : ISO20022.Seev031002.DateFormat41Choice
    }
    ISO20022.Seev031002.CorporateActionDate97 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.CorporateActionDate97 *-- ISO20022.Seev031002.DateFormat49Choice
    ISO20022.Seev031002.CorporateActionDate97 *-- ISO20022.Seev031002.DateFormat64Choice
    ISO20022.Seev031002.CorporateActionDate97 *-- ISO20022.Seev031002.DateFormat41Choice
    class ISO20022.Seev031002.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev031002.CorporateActionEventProcessingType3Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionEventProcessingType3Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionEventReference4 {
        + LkgTp  : ISO20022.Seev031002.ProcessingPosition10Choice
        + EvtId  : ISO20022.Seev031002.CorporateActionEventReference4Choice
    }
    ISO20022.Seev031002.CorporateActionEventReference4 *-- ISO20022.Seev031002.ProcessingPosition10Choice
    ISO20022.Seev031002.CorporateActionEventReference4 *-- ISO20022.Seev031002.CorporateActionEventReference4Choice
    class ISO20022.Seev031002.CorporateActionEventReference4Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev031002.CorporateActionEventStage3Code {
        WHOU = 1
        UNAC = 2
        SUAP = 3
        RESC = 4
        PWAL = 5
        PART = 6
        LAPS = 7
        FULL = 8
        CLDE = 9
        APPD = 10
    }
    class ISO20022.Seev031002.CorporateActionEventStageFormat20Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionEventStageFormat20Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionEventStatus1 {
        + EvtConfSts  : String
        + EvtCmpltnsSts  : String
    }
    class ISO20022.Seev031002.CorporateActionEventType124Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionEventType124Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionEventType35Code {
        RCLA = 1
        TNDP = 2
        INFO = 3
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
    class ISO20022.Seev031002.CorporateActionFrequencyType5Code {
        SPRE = 1
        SPEC = 2
        REGR = 3
        REIN = 4
        INTE = 5
        FINL = 6
    }
    class ISO20022.Seev031002.CorporateActionGeneralInformation194 {
        + UndrlygScty  : ISO20022.Seev031002.FinancialInstrumentAttributes136
        + MndtryVlntryEvtTp  : ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice
        + EvtTp  : ISO20022.Seev031002.CorporateActionEventType124Choice
        + EvtPrcgTp  : ISO20022.Seev031002.CorporateActionEventProcessingType3Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev031002.CorporateActionGeneralInformation194 *-- ISO20022.Seev031002.FinancialInstrumentAttributes136
    ISO20022.Seev031002.CorporateActionGeneralInformation194 *-- ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice
    ISO20022.Seev031002.CorporateActionGeneralInformation194 *-- ISO20022.Seev031002.CorporateActionEventType124Choice
    ISO20022.Seev031002.CorporateActionGeneralInformation194 *-- ISO20022.Seev031002.CorporateActionEventProcessingType3Choice
    class ISO20022.Seev031002.CorporateActionInformationType1Code {
        CONF = 1
    }
    class ISO20022.Seev031002.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionNarrative63 {
        + EvtPrcgWebSiteAdr  : String
        + URLAdr  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedURLlnformation7~
        + NewCpnyNm  : String
        + Offerr  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Seev031002.CorporateActionNarrative63 *-- ISO20022.Seev031002.UpdatedURLlnformation7
    class ISO20022.Seev031002.CorporateActionNarrative64 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + Dsclmr  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + TaxtnConds  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + SctyRstrctn  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + InfToCmplyWth  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + InfConds  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation25~
        + NrrtvVrsn  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation24~
        + AddtlTxt  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation24~
    }
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation25
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation24
    ISO20022.Seev031002.CorporateActionNarrative64 *-- ISO20022.Seev031002.UpdatedAdditionalInformation24
    class ISO20022.Seev031002.CorporateActionNarrative65 {
        + PrcgTxtForNxtIntrmy  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + URLAdr  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedURLlnformation7~
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + BsktOrIndxInf  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + RegnDtls  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + Dsclmr  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + TaxtnConds  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + InfToCmplyWth  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + InfConds  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + NrrtvVrsn  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
        + AddtlTxt  : global::System.Collections.Generic.List~ISO20022.Seev031002.UpdatedAdditionalInformation26~
    }
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedURLlnformation7
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    ISO20022.Seev031002.CorporateActionNarrative65 *-- ISO20022.Seev031002.UpdatedAdditionalInformation26
    class ISO20022.Seev031002.CorporateActionNotification002V15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev031002.SupplementaryData1~
        + TrfAgt  : ISO20022.Seev031002.PartyIdentification151Choice
        + Offerr  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification151Choice~
        + Issr  : ISO20022.Seev031002.PartyIdentification151Choice
        + InfAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + SlctnAgt  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification137Choice~
        + DrpAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + PhysSctiesAgt  : ISO20022.Seev031002.PartyIdentification137Choice
        + RsellngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification137Choice~
        + Regar  : ISO20022.Seev031002.PartyIdentification137Choice
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification137Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification137Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev031002.PartyIdentification151Choice~
        + AddtlInf  : ISO20022.Seev031002.CorporateActionNarrative65
        + CorpActnOptnDtls  : global::System.Collections.Generic.List~ISO20022.Seev031002.CorporateActionOption247~
        + CorpActnDtls  : ISO20022.Seev031002.CorporateAction87
        + IntrmdtScty  : ISO20022.Seev031002.FinancialInstrumentAttributes117
        + AcctDtls  : ISO20022.Seev031002.AccountIdentification78Choice
        + CorpActnGnlInf  : ISO20022.Seev031002.CorporateActionGeneralInformation194
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev031002.CorporateActionEventReference4~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev031002.DocumentIdentification38~
        + InstrId  : ISO20022.Seev031002.DocumentIdentification17
        + PrvsNtfctnId  : ISO20022.Seev031002.DocumentIdentification37
        + NtfctnGnlInf  : ISO20022.Seev031002.CorporateActionNotification11
        + Pgntn  : ISO20022.Seev031002.Pagination1
    }
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.SupplementaryData1
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification151Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification151Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification151Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification137Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.PartyIdentification151Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateActionNarrative65
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateActionOption247
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateAction87
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.FinancialInstrumentAttributes117
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.AccountIdentification78Choice
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateActionGeneralInformation194
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateActionEventReference4
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.DocumentIdentification38
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.DocumentIdentification17
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.DocumentIdentification37
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.CorporateActionNotification11
    ISO20022.Seev031002.CorporateActionNotification002V15 *-- ISO20022.Seev031002.Pagination1
    class ISO20022.Seev031002.CorporateActionNotification11 {
        + PrcgSts  : ISO20022.Seev031002.CorporateActionProcessingStatus6Choice
        + NtfctnTp  : String
        + NtfctnId  : String
    }
    ISO20022.Seev031002.CorporateActionNotification11 *-- ISO20022.Seev031002.CorporateActionProcessingStatus6Choice
    class ISO20022.Seev031002.CorporateActionNotificationType1Code {
        RMDR = 1
        REPL = 2
        NEWM = 3
    }
    class ISO20022.Seev031002.CorporateActionOption15Code {
        BOBD = 1
        PRUN = 2
        SLLE = 3
        SECU = 4
        QINV = 5
        OVER = 6
        OTHR = 7
        OFFR = 8
        NOQU = 9
        NOAC = 10
        MPUT = 11
        LAPS = 12
        EXER = 13
        CTEN = 14
        CONY = 15
        CONN = 16
        CEXC = 17
        CASH = 18
        CASE = 19
        BUYA = 20
        BSPL = 21
        ABST = 22
    }
    class ISO20022.Seev031002.CorporateActionOption247 {
        + AddtlInf  : ISO20022.Seev031002.CorporateActionNarrative64
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev031002.CashOption113~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev031002.SecuritiesOption117~
        + SctiesQty  : ISO20022.Seev031002.SecuritiesOption84
        + PricDtls  : ISO20022.Seev031002.CorporateActionPrice97
        + RateAndAmtDtls  : ISO20022.Seev031002.CorporateActionRate136
        + PrdDtls  : ISO20022.Seev031002.CorporateActionPeriod12
        + DtDtls  : ISO20022.Seev031002.CorporateActionDate108
        + FinInstrmId  : ISO20022.Seev031002.SecurityIdentification20
        + ApldOptnInd  : String
        + ChngAllwdInd  : String
        + WdrwlAllwdInd  : String
        + CertfctnBrkdwnInd  : String
        + ChrgsApldInd  : String
        + DfltPrcgOrStgInstr  : ISO20022.Seev031002.DefaultProcessingOrStandingInstruction2Choice
        + CcyOptn  : String
        + VldDmclCtry  : global::System.Collections.Generic.List~String~
        + NonDmclCtry  : global::System.Collections.Generic.List~String~
        + PrratnBlwMinQty  : ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice
        + BidRgTp  : ISO20022.Seev031002.BidRangeType2Choice
        + CertfctnBrkdwnTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.BeneficiaryCertificationType15Choice~
        + AccptncPrtyLvl  : String
        + OptnAvlbtySts  : ISO20022.Seev031002.OptionAvailabilityStatus4Choice
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev031002.OptionFeaturesFormat31Choice~
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.OfferTypeFormat16Choice~
        + FrctnDspstn  : ISO20022.Seev031002.FractionDispositionType31Choice
        + OptnTp  : ISO20022.Seev031002.CorporateActionOption46Choice
        + OptnNb  : String
    }
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionNarrative64
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CashOption113
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.SecuritiesOption117
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.SecuritiesOption84
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionPrice97
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionRate136
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionPeriod12
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionDate108
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.SecurityIdentification20
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.DefaultProcessingOrStandingInstruction2Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.BidRangeType2Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.BeneficiaryCertificationType15Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.OptionAvailabilityStatus4Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.OptionFeaturesFormat31Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.OfferTypeFormat16Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.FractionDispositionType31Choice
    ISO20022.Seev031002.CorporateActionOption247 *-- ISO20022.Seev031002.CorporateActionOption46Choice
    class ISO20022.Seev031002.CorporateActionOption46Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.CorporateActionOption46Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.CorporateActionPeriod12 {
        + DpstrySspnsnPrdForWdrwl  : ISO20022.Seev031002.Period6Choice
        + AcctSvcrRvcbltyPrd  : ISO20022.Seev031002.Period6Choice
        + PrvlgSspnsnPrd  : ISO20022.Seev031002.Period6Choice
        + RvcbltyPrd  : ISO20022.Seev031002.Period6Choice
        + ActnPrd  : ISO20022.Seev031002.Period6Choice
        + ParllTradgPrd  : ISO20022.Seev031002.Period6Choice
        + PricClctnPrd  : ISO20022.Seev031002.Period6Choice
    }
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod12 *-- ISO20022.Seev031002.Period6Choice
    class ISO20022.Seev031002.CorporateActionPeriod16 {
        + FsclYrPrd  : ISO20022.Seev031002.Period6Choice
        + SpltPrd  : ISO20022.Seev031002.Period6Choice
        + CoDpstriesSspnsnPrd  : ISO20022.Seev031002.Period6Choice
        + BookClsrPrd  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForWdrwlInStrtNm  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForWdrwlInNmneeNm  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForWdrwlAtAgt  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForSgrtn  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForPldg  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForDpst  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForDpstAtAgt  : ISO20022.Seev031002.Period6Choice
        + DpstrySspnsnPrdForBookNtryTrf  : ISO20022.Seev031002.Period6Choice
        + ClmPrd  : ISO20022.Seev031002.Period6Choice
        + CmplsryPurchsPrd  : ISO20022.Seev031002.Period6Choice
        + IntrstPrd  : ISO20022.Seev031002.Period6Choice
        + PricClctnPrd  : ISO20022.Seev031002.Period6Choice
    }
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.CorporateActionPeriod16 *-- ISO20022.Seev031002.Period6Choice
    class ISO20022.Seev031002.CorporateActionPrice96 {
        + LastBidIncrmtPric  : ISO20022.Seev031002.PriceFormat91Choice
        + FrstBidIncrmtPric  : ISO20022.Seev031002.PriceFormat91Choice
        + MinPric  : ISO20022.Seev031002.PriceFormat91Choice
        + MaxPric  : ISO20022.Seev031002.PriceFormat91Choice
    }
    ISO20022.Seev031002.CorporateActionPrice96 *-- ISO20022.Seev031002.PriceFormat91Choice
    ISO20022.Seev031002.CorporateActionPrice96 *-- ISO20022.Seev031002.PriceFormat91Choice
    ISO20022.Seev031002.CorporateActionPrice96 *-- ISO20022.Seev031002.PriceFormat91Choice
    ISO20022.Seev031002.CorporateActionPrice96 *-- ISO20022.Seev031002.PriceFormat91Choice
    class ISO20022.Seev031002.CorporateActionPrice97 {
        + LastBidIncrmtPric  : ISO20022.Seev031002.PriceFormat93Choice
        + FrstBidIncrmtPric  : ISO20022.Seev031002.PriceFormat93Choice
        + MinPric  : ISO20022.Seev031002.PriceFormat93Choice
        + MaxPric  : ISO20022.Seev031002.PriceFormat93Choice
        + MinMltplCshToInst  : ISO20022.Seev031002.PriceFormat62Choice
        + MinCshToInst  : ISO20022.Seev031002.PriceFormat62Choice
        + MaxCshToInst  : ISO20022.Seev031002.PriceFormat62Choice
        + OverSbcptDpstPric  : ISO20022.Seev031002.PriceFormat92Choice
        + CshInLieuOfShrPric  : ISO20022.Seev031002.PriceFormat92Choice
    }
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat93Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat93Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat93Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat93Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat62Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat62Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat62Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat92Choice
    ISO20022.Seev031002.CorporateActionPrice97 *-- ISO20022.Seev031002.PriceFormat92Choice
    class ISO20022.Seev031002.CorporateActionPrice98 {
        + GncCshPricRcvdPerPdct  : ISO20022.Seev031002.PriceFormat94Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev031002.PriceFormat93Choice
        + CshValForTax  : ISO20022.Seev031002.PriceFormat58Choice
        + CshInLieuOfShrPric  : ISO20022.Seev031002.PriceFormat92Choice
        + IndctvOrMktPric  : ISO20022.Seev031002.IndicativeOrMarketPrice18Choice
    }
    ISO20022.Seev031002.CorporateActionPrice98 *-- ISO20022.Seev031002.PriceFormat94Choice
    ISO20022.Seev031002.CorporateActionPrice98 *-- ISO20022.Seev031002.PriceFormat93Choice
    ISO20022.Seev031002.CorporateActionPrice98 *-- ISO20022.Seev031002.PriceFormat58Choice
    ISO20022.Seev031002.CorporateActionPrice98 *-- ISO20022.Seev031002.PriceFormat92Choice
    ISO20022.Seev031002.CorporateActionPrice98 *-- ISO20022.Seev031002.IndicativeOrMarketPrice18Choice
    class ISO20022.Seev031002.CorporateActionProcessingStatus6Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : ISO20022.Seev031002.CorporateActionEventStatus1
    }
    ISO20022.Seev031002.CorporateActionProcessingStatus6Choice *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.CorporateActionProcessingStatus6Choice *-- ISO20022.Seev031002.CorporateActionEventStatus1
    class ISO20022.Seev031002.CorporateActionQuantity14 {
        + IncrmtlDnmtn  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + BaseDnmtn  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + NewDnmtnQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + NewBrdLotQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + MinQtySght  : ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
        + MaxQty  : ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    }
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    ISO20022.Seev031002.CorporateActionQuantity14 *-- ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    class ISO20022.Seev031002.CorporateActionRate135 {
        + IndxFctr  : ISO20022.Seev031002.RateAndAmountFormat57Choice
        + DclrdRate  : ISO20022.Seev031002.RateAndAmountFormat74Choice
        + RealsdLoss  : ISO20022.Seev031002.RateAndAmountFormat74Choice
        + IntrstShrtfll  : ISO20022.Seev031002.RateAndAmountFormat74Choice
        + RinvstmtDscntRateToMkt  : ISO20022.Seev031002.RateFormat24Choice
        + NxtFctr  : ISO20022.Seev031002.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031002.RateFormat12Choice
        + BidIntrvl  : ISO20022.Seev031002.RateAndAmountFormat73Choice
        + Sprd  : ISO20022.Seev031002.RateFormat24Choice
        + RltdIndx  : ISO20022.Seev031002.RateFormat24Choice
        + PctgSght  : ISO20022.Seev031002.RateFormat25Choice
        + IntrstRate  : ISO20022.Seev031002.RateAndAmountFormat72Choice
    }
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat57Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat74Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat74Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat74Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat73Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateFormat25Choice
    ISO20022.Seev031002.CorporateActionRate135 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    class ISO20022.Seev031002.CorporateActionRate136 {
        + BidIntrvl  : ISO20022.Seev031002.RateAndAmountFormat73Choice
        + TaxOnIncm  : ISO20022.Seev031002.RateAndAmountFormat72Choice
        + IssrDclrdXchgRate  : ISO20022.Seev031002.ForeignExchangeTerms38
        + TaxblIncmPerDvddShr  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateTypeAndAmountAndStatus33~
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat75Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat75Choice~
        + PrratnRate  : ISO20022.Seev031002.RateFormat24Choice
        + MaxAllwdOvrsbcptRate  : ISO20022.Seev031002.RateFormat24Choice
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice~
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.NetDividendRateFormat43Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.GrossDividendRateFormat41Choice~
        + AddtlTax  : ISO20022.Seev031002.RateAndAmountFormat72Choice
    }
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateAndAmountFormat73Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.ForeignExchangeTerms38
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateTypeAndAmountAndStatus33
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateAndAmountFormat75Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateAndAmountFormat75Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.NetDividendRateFormat43Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.GrossDividendRateFormat41Choice
    ISO20022.Seev031002.CorporateActionRate136 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    class ISO20022.Seev031002.CorporateActionRate137 {
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat76Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat76Choice~
        + FinTxTaxRate  : ISO20022.Seev031002.RateFormat24Choice
        + TaxCdtRate  : ISO20022.Seev031002.RateFormat30Choice
        + AplblRate  : ISO20022.Seev031002.RateFormat24Choice
        + FsclStmp  : ISO20022.Seev031002.RateFormat24Choice
        + ChrgsFees  : ISO20022.Seev031002.RateAndAmountFormat72Choice
        + TrfrmatnRate  : Decimal
        + NewToOd  : ISO20022.Seev031002.RatioFormat24Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev031002.RatioFormat23Choice
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev031002.RatioFormat23Choice
    }
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateAndAmountFormat76Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateAndAmountFormat76Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateFormat30Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RatioFormat24Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RatioFormat23Choice
    ISO20022.Seev031002.CorporateActionRate137 *-- ISO20022.Seev031002.RatioFormat23Choice
    class ISO20022.Seev031002.CorporateActionTaxableIncomePerShareCalculated1Code {
        UKWN = 1
        TDIN = 2
        TDIY = 3
    }
    class ISO20022.Seev031002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev031002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev031002.DateCode22Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DateCode22Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DateCode26Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DateCode26Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DateCode27Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DateCode27Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DateCode39Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DateCode39Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DateCodeAndTimeFormat4 {
        + Tm  : DateTime
        + DtCd  : ISO20022.Seev031002.DateCode26Choice
    }
    ISO20022.Seev031002.DateCodeAndTimeFormat4 *-- ISO20022.Seev031002.DateCode26Choice
    class ISO20022.Seev031002.DateFormat41Choice {
        + DtCd  : ISO20022.Seev031002.DateCode22Choice
        + Dt  : DateTime
    }
    ISO20022.Seev031002.DateFormat41Choice *-- ISO20022.Seev031002.DateCode22Choice
    class ISO20022.Seev031002.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev031002.DateAndDateTime2Choice
    }
    ISO20022.Seev031002.DateFormat45Choice *-- ISO20022.Seev031002.DateAndDateTime2Choice
    class ISO20022.Seev031002.DateFormat49Choice {
        + DtCd  : ISO20022.Seev031002.DateCode22Choice
        + Dt  : ISO20022.Seev031002.DateAndDateTime2Choice
    }
    ISO20022.Seev031002.DateFormat49Choice *-- ISO20022.Seev031002.DateCode22Choice
    ISO20022.Seev031002.DateFormat49Choice *-- ISO20022.Seev031002.DateAndDateTime2Choice
    class ISO20022.Seev031002.DateFormat54Choice {
        + DtCd  : ISO20022.Seev031002.DateCode22Choice
        + DtCdAndTm  : ISO20022.Seev031002.DateCodeAndTimeFormat4
        + Dt  : ISO20022.Seev031002.DateAndDateTime2Choice
    }
    ISO20022.Seev031002.DateFormat54Choice *-- ISO20022.Seev031002.DateCode22Choice
    ISO20022.Seev031002.DateFormat54Choice *-- ISO20022.Seev031002.DateCodeAndTimeFormat4
    ISO20022.Seev031002.DateFormat54Choice *-- ISO20022.Seev031002.DateAndDateTime2Choice
    class ISO20022.Seev031002.DateFormat64Choice {
        + DtCd  : ISO20022.Seev031002.DateCode27Choice
        + Dt  : DateTime
    }
    ISO20022.Seev031002.DateFormat64Choice *-- ISO20022.Seev031002.DateCode27Choice
    class ISO20022.Seev031002.DateFormat71Choice {
        + DtCd  : ISO20022.Seev031002.DateCode39Choice
        + Dt  : ISO20022.Seev031002.DateAndDateTime2Choice
    }
    ISO20022.Seev031002.DateFormat71Choice *-- ISO20022.Seev031002.DateCode39Choice
    ISO20022.Seev031002.DateFormat71Choice *-- ISO20022.Seev031002.DateAndDateTime2Choice
    class ISO20022.Seev031002.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev031002.DateType7Code {
        ONGO = 1
    }
    class ISO20022.Seev031002.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev031002.DateType9Code {
        UKWN = 1
        NARR = 2
        RDDT = 3
        RDTE = 4
        PAYD = 5
        MEET = 6
        MKDT = 7
        PWAL = 8
    }
    class ISO20022.Seev031002.DeemedRateType1Code {
        DERY = 1
        DEIT = 2
        DEFP = 3
        DEDI = 4
    }
    class ISO20022.Seev031002.DeemedRateType2Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DeemedRateType2Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DefaultProcessingOrStandingInstruction2Choice {
        + StgInstrInd  : String
        + DfltOptnInd  : String
    }
    class ISO20022.Seev031002.DistributionType3Code {
        ROLL = 1
        ONGO = 2
        INTE = 3
        FINL = 4
    }
    class ISO20022.Seev031002.DistributionTypeFormat8Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DistributionTypeFormat8Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DividendRateType1Code {
        TXBL = 1
    }
    class ISO20022.Seev031002.DividendTypeFormat10Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DividendTypeFormat10Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.DocumentIdentification17 {
        + Id  : String
    }
    class ISO20022.Seev031002.DocumentIdentification37 {
        + LkgTp  : ISO20022.Seev031002.ProcessingPosition10Choice
        + Id  : String
    }
    ISO20022.Seev031002.DocumentIdentification37 *-- ISO20022.Seev031002.ProcessingPosition10Choice
    class ISO20022.Seev031002.DocumentIdentification38 {
        + LkgTp  : ISO20022.Seev031002.ProcessingPosition10Choice
        + DocNb  : ISO20022.Seev031002.DocumentNumber6Choice
        + Id  : ISO20022.Seev031002.DocumentIdentification4Choice
    }
    ISO20022.Seev031002.DocumentIdentification38 *-- ISO20022.Seev031002.ProcessingPosition10Choice
    ISO20022.Seev031002.DocumentIdentification38 *-- ISO20022.Seev031002.DocumentNumber6Choice
    ISO20022.Seev031002.DocumentIdentification38 *-- ISO20022.Seev031002.DocumentIdentification4Choice
    class ISO20022.Seev031002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev031002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev031002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev031002.DocumentNumber6Choice *-- ISO20022.Seev031002.GenericIdentification86
    class ISO20022.Seev031002.DutchAuctionType1Code {
        UNMD = 1
        MDFD = 2
    }
    class ISO20022.Seev031002.DutchAuctionTypeFormat2Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.DutchAuctionTypeFormat2Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Seev031002.ElectionMovementType2Code {
        SEQD = 1
        DRCT = 2
    }
    class ISO20022.Seev031002.ElectionTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.ElectionTypeFormat4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.EventCompletenessStatus1Code {
        INCO = 1
        COMP = 2
    }
    class ISO20022.Seev031002.EventConfirmationStatus1Code {
        UCON = 1
        CONF = 2
    }
    class ISO20022.Seev031002.EventSequenceType1Code {
        INTE = 1
        FINL = 2
    }
    class ISO20022.Seev031002.EventSequenceTypeFormat2Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.EventSequenceTypeFormat2Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.FinancialInstrumentAttributes117 {
        + InstdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + UinstdBal  : ISO20022.Seev031002.BalanceFormat14Choice
        + TradgPrd  : ISO20022.Seev031002.Period11
        + PstngDt  : ISO20022.Seev031002.DateFormat41Choice
        + XpryDt  : ISO20022.Seev031002.DateFormat41Choice
        + MktPric  : ISO20022.Seev031002.AmountPrice4
        + IntrmdtSctiesToUndrlygRatio  : ISO20022.Seev031002.QuantityToQuantityRatio2
        + FrctnDspstn  : ISO20022.Seev031002.FractionDispositionType32Choice
        + RnncblEntitlmntStsTp  : ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice
        + Qty  : Decimal
        + SctyId  : ISO20022.Seev031002.SecurityIdentification20
    }
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.BalanceFormat14Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.Period11
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.AmountPrice4
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.QuantityToQuantityRatio2
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.FractionDispositionType32Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes117 *-- ISO20022.Seev031002.SecurityIdentification20
    class ISO20022.Seev031002.FinancialInstrumentAttributes136 {
        + CtrctSz  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + WarrtParity  : ISO20022.Seev031002.QuantityToQuantityRatio2
        + NxtFctr  : ISO20022.Seev031002.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031002.RateFormat12Choice
        + PctgOfDebtClm  : ISO20022.Seev031002.RateFormat24Choice
        + NxtIntrstRate  : ISO20022.Seev031002.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev031002.RateFormat24Choice
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
        + OptnStyle  : ISO20022.Seev031002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Seev031002.ClassificationType33Choice
        + DayCntBsis  : ISO20022.Seev031002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Seev031002.MarketIdentification4Choice
        + FinInstrmId  : ISO20022.Seev031002.SecurityIdentification20
    }
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.QuantityToQuantityRatio2
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.OptionStyle9Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.ClassificationType33Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.InterestComputationMethodFormat5Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.MarketIdentification4Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes136 *-- ISO20022.Seev031002.SecurityIdentification20
    class ISO20022.Seev031002.FinancialInstrumentAttributes137 {
        + IssePric  : ISO20022.Seev031002.PriceFormat92Choice
        + CtrctSz  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + MinMltplQtyToInst  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + MinQtyToInst  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + NxtIntrstRate  : ISO20022.Seev031002.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev031002.RateFormat24Choice
        + NxtFctr  : ISO20022.Seev031002.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031002.RateFormat12Choice
        + ConvsDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + NxtCpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnStyle  : ISO20022.Seev031002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Seev031002.ClassificationType33Choice
        + DayCntBsis  : ISO20022.Seev031002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Seev031002.MarketIdentification4Choice
        + FinInstrmId  : ISO20022.Seev031002.SecurityIdentification20
    }
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.PriceFormat92Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.RateFormat12Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.OptionStyle9Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.ClassificationType33Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.InterestComputationMethodFormat5Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.MarketIdentification4Choice
    ISO20022.Seev031002.FinancialInstrumentAttributes137 *-- ISO20022.Seev031002.SecurityIdentification20
    class ISO20022.Seev031002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031002.FinancialInstrumentQuantity43Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031002.FinancialInstrumentQuantity44Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031002.ForeignExchangeTerms38 {
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    class ISO20022.Seev031002.ForeignExchangeTerms43 {
        + RsltgAmt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev031002.ForeignExchangeTerms43 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev031002.FractionDispositionType31Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.FractionDispositionType31Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.FractionDispositionType32Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.FractionDispositionType32Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.FractionDispositionType8Code {
        UKWN = 1
        RDUP = 2
        STAN = 3
        RDDN = 4
        DIST = 5
        CINL = 6
        BUYU = 7
    }
    class ISO20022.Seev031002.FractionDispositionType9Code {
        UKWN = 1
        RDUP = 2
        STAN = 3
        RDDN = 4
        DIST = 5
    }
    class ISO20022.Seev031002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev031002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev031002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev031002.GenericIdentification47
    }
    ISO20022.Seev031002.GenericIdentification85 *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev031002.GrossDividendRateFormat41Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031002.RateTypeAndAmountAndStatus59
        + AmtAndRateSts  : ISO20022.Seev031002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.GrossDividendRateFormat41Choice *-- ISO20022.Seev031002.RateTypeAndAmountAndStatus59
    ISO20022.Seev031002.GrossDividendRateFormat41Choice *-- ISO20022.Seev031002.AmountAndRateStatus2
    ISO20022.Seev031002.GrossDividendRateFormat41Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.GrossDividendRateType6Code {
        CDFI = 1
        UNFR = 2
        TXFR = 3
        TXDF = 4
        TXBL = 5
        SOIC = 6
        STCG = 7
        REES = 8
        LTCG = 9
        INTR = 10
        INCO = 11
        FLFR = 12
        CAPO = 13
    }
    class ISO20022.Seev031002.IdentificationFormat4Choice {
        + PrtryId  : ISO20022.Seev031002.GenericIdentification86
        + LngId  : String
        + ShrtId  : String
    }
    ISO20022.Seev031002.IdentificationFormat4Choice *-- ISO20022.Seev031002.GenericIdentification86
    class ISO20022.Seev031002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev031002.IndicativeOrMarketPrice18Choice {
        + MktPric  : ISO20022.Seev031002.PriceFormat92Choice
        + IndctvPric  : ISO20022.Seev031002.PriceFormat92Choice
    }
    ISO20022.Seev031002.IndicativeOrMarketPrice18Choice *-- ISO20022.Seev031002.PriceFormat92Choice
    ISO20022.Seev031002.IndicativeOrMarketPrice18Choice *-- ISO20022.Seev031002.PriceFormat92Choice
    class ISO20022.Seev031002.InformationTypeFormat5Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.InformationTypeFormat5Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.InterestComputationMethod2Code {
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
    class ISO20022.Seev031002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.InterestComputationMethodFormat5Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031002.RateTypeAndAmountAndStatus32
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice *-- ISO20022.Seev031002.RateTypeAndAmountAndStatus32
    ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.IntermediateSecurityDistributionType5Code {
        MRGR = 1
        EXOF = 2
        BONU = 3
        SPLF = 4
        SOFF = 5
        LIQU = 6
        INTR = 7
        DVSE = 8
        DVSC = 9
        PRIO = 10
        EXRI = 11
        DVOP = 12
        DVCA = 13
        DRIP = 14
        BIDS = 15
    }
    class ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.IssuerTaxability2Code {
        TXBL = 1
    }
    class ISO20022.Seev031002.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev031002.LotteryTypeFormat5Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.LotteryTypeFormat5Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev031002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Seev031002.NetDividendRateFormat43Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031002.RateTypeAndAmountAndStatus60
        + AmtAndRateSts  : ISO20022.Seev031002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.NetDividendRateFormat43Choice *-- ISO20022.Seev031002.RateTypeAndAmountAndStatus60
    ISO20022.Seev031002.NetDividendRateFormat43Choice *-- ISO20022.Seev031002.AmountAndRateStatus2
    ISO20022.Seev031002.NetDividendRateFormat43Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.NetDividendRateType6Code {
        UNFR = 1
        TXFR = 2
        TXDF = 3
        TXBL = 4
        SOIC = 5
        REES = 6
        INTR = 7
        INCO = 8
        FLFR = 9
        CDFI = 10
        CAPO = 11
    }
    class ISO20022.Seev031002.NewSecuritiesIssuanceType5Code {
        REFU = 1
        NREF = 2
        UKWN = 3
        NDEF = 4
        NEIS = 5
        EXIS = 6
        DEFE = 7
    }
    class ISO20022.Seev031002.NonEligibleProceedsIndicator2Code {
        NELS = 1
        ONEL = 2
        ACLI = 3
        NELC = 4
    }
    class ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.OfferType5Code {
        ACPR = 1
        SQUE = 2
        ERUN = 3
        PART = 4
        FCFS = 5
        FINL = 6
        NDIS = 7
        DISS = 8
    }
    class ISO20022.Seev031002.OfferTypeFormat16Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.OfferTypeFormat16Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.OptionAvailabilityStatus1Code {
        CANC = 1
        INTV = 2
    }
    class ISO20022.Seev031002.OptionAvailabilityStatus4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.OptionAvailabilityStatus4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.OptionFeatures13Code {
        RNET = 1
        RGRS = 2
        SHAR = 3
        QCAS = 4
        VVPR = 5
        PROR = 6
        PINS = 7
        CAOS = 8
        OPLF = 9
        NOSE = 10
        MAXS = 11
        MAXC = 12
        COND = 13
        BOIS = 14
        ASVO = 15
    }
    class ISO20022.Seev031002.OptionFeaturesFormat31Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.OptionFeaturesFormat31Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Seev031002.OptionStyle9Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.OptionStyle9Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev031002.OriginalAndCurrentQuantities7 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev031002.OtherIdentification2 {
        + Tp  : ISO20022.Seev031002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev031002.OtherIdentification2 *-- ISO20022.Seev031002.IdentificationSource4Choice
    class ISO20022.Seev031002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev031002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev031002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev031002.PartyIdentification136Choice *-- ISO20022.Seev031002.GenericIdentification84
    class ISO20022.Seev031002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Seev031002.NameAndAddress12
        + PrtryId  : ISO20022.Seev031002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev031002.PartyIdentification137Choice *-- ISO20022.Seev031002.NameAndAddress12
    ISO20022.Seev031002.PartyIdentification137Choice *-- ISO20022.Seev031002.GenericIdentification84
    class ISO20022.Seev031002.PartyIdentification151Choice {
        + LEI  : String
        + NmAndAdr  : ISO20022.Seev031002.NameAndAddress12
        + PrtryId  : ISO20022.Seev031002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev031002.PartyIdentification151Choice *-- ISO20022.Seev031002.NameAndAddress12
    ISO20022.Seev031002.PartyIdentification151Choice *-- ISO20022.Seev031002.GenericIdentification84
    class ISO20022.Seev031002.Payment2Code {
        ACTU = 1
    }
    class ISO20022.Seev031002.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev031002.PercentagePrice3 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev031002.Period11 {
        + EndDt  : ISO20022.Seev031002.DateFormat45Choice
        + StartDt  : ISO20022.Seev031002.DateFormat45Choice
    }
    ISO20022.Seev031002.Period11 *-- ISO20022.Seev031002.DateFormat45Choice
    ISO20022.Seev031002.Period11 *-- ISO20022.Seev031002.DateFormat45Choice
    class ISO20022.Seev031002.Period6Choice {
        + PrdCd  : String
        + Prd  : ISO20022.Seev031002.Period11
    }
    ISO20022.Seev031002.Period6Choice *-- ISO20022.Seev031002.Period11
    class ISO20022.Seev031002.PriceCalculationMethod1Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.PriceCalculationMethod1Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.PriceCalculationMethod1Code {
        AVCL = 1
        NAVA = 2
        MIMP = 3
        NAVF = 4
        VWAP = 5
    }
    class ISO20022.Seev031002.PriceDetails43 {
        + CshInLieuOfShrPric  : ISO20022.Seev031002.PriceFormat92Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev031002.PriceFormat94Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev031002.PriceFormat93Choice
    }
    ISO20022.Seev031002.PriceDetails43 *-- ISO20022.Seev031002.PriceFormat92Choice
    ISO20022.Seev031002.PriceDetails43 *-- ISO20022.Seev031002.PriceFormat94Choice
    ISO20022.Seev031002.PriceDetails43 *-- ISO20022.Seev031002.PriceFormat93Choice
    class ISO20022.Seev031002.PriceFormat58Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice4
    }
    ISO20022.Seev031002.PriceFormat58Choice *-- ISO20022.Seev031002.AmountPrice4
    class ISO20022.Seev031002.PriceFormat62Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice7
    }
    ISO20022.Seev031002.PriceFormat62Choice *-- ISO20022.Seev031002.AmountPrice7
    class ISO20022.Seev031002.PriceFormat91Choice {
        + IndxPts  : Decimal
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice5
        + PctgPric  : ISO20022.Seev031002.PercentagePrice2
    }
    ISO20022.Seev031002.PriceFormat91Choice *-- ISO20022.Seev031002.AmountPrice5
    ISO20022.Seev031002.PriceFormat91Choice *-- ISO20022.Seev031002.PercentagePrice2
    class ISO20022.Seev031002.PriceFormat92Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice5
        + PctgPric  : ISO20022.Seev031002.PercentagePrice3
    }
    ISO20022.Seev031002.PriceFormat92Choice *-- ISO20022.Seev031002.AmountPrice5
    ISO20022.Seev031002.PriceFormat92Choice *-- ISO20022.Seev031002.PercentagePrice3
    class ISO20022.Seev031002.PriceFormat93Choice {
        + IndxPts  : Decimal
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice5
        + PctgPric  : ISO20022.Seev031002.PercentagePrice3
    }
    ISO20022.Seev031002.PriceFormat93Choice *-- ISO20022.Seev031002.AmountPrice5
    ISO20022.Seev031002.PriceFormat93Choice *-- ISO20022.Seev031002.PercentagePrice3
    class ISO20022.Seev031002.PriceFormat94Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev031002.AmountPricePerAmount3
        + AmtPricPerFinInstrmQty  : ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031002.AmountPrice5
        + PctgPric  : ISO20022.Seev031002.PercentagePrice3
    }
    ISO20022.Seev031002.PriceFormat94Choice *-- ISO20022.Seev031002.AmountPricePerAmount3
    ISO20022.Seev031002.PriceFormat94Choice *-- ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11
    ISO20022.Seev031002.PriceFormat94Choice *-- ISO20022.Seev031002.AmountPrice5
    ISO20022.Seev031002.PriceFormat94Choice *-- ISO20022.Seev031002.PercentagePrice3
    class ISO20022.Seev031002.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev031002.PriceValueType10Code {
        UKWN = 1
    }
    class ISO20022.Seev031002.PriceValueType8Code {
        NILP = 1
        UKWN = 2
        UNSP = 3
        TBSP = 4
    }
    class ISO20022.Seev031002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.ProcessingPosition10Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev031002.ProprietaryQuantity10 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev031002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.ProrationBelowMinimumQuantity1Code {
        UKWN = 1
        REJT = 2
        MILT = 3
        MIEX = 4
        FULL = 5
    }
    class ISO20022.Seev031002.Quantity4Code {
        ANYA = 1
        UKWN = 2
    }
    class ISO20022.Seev031002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev031002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev031002.Quantity53Choice *-- ISO20022.Seev031002.ProprietaryQuantity9
    ISO20022.Seev031002.Quantity53Choice *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev031002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Seev031002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev031002.Quantity54Choice *-- ISO20022.Seev031002.OriginalAndCurrentQuantities4
    ISO20022.Seev031002.Quantity54Choice *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev031002.Quantity57Choice {
        + SgndQty  : ISO20022.Seev031002.SignedQuantityFormat13
        + OrgnlAndCurFaceAmt  : ISO20022.Seev031002.OriginalAndCurrentQuantities7
    }
    ISO20022.Seev031002.Quantity57Choice *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.Quantity57Choice *-- ISO20022.Seev031002.OriginalAndCurrentQuantities7
    class ISO20022.Seev031002.Quantity5Code {
        UKWN = 1
    }
    class ISO20022.Seev031002.Quantity80Choice {
        + PrtryQty  : ISO20022.Seev031002.ProprietaryQuantity10
        + QtyChc  : ISO20022.Seev031002.Quantity57Choice
    }
    ISO20022.Seev031002.Quantity80Choice *-- ISO20022.Seev031002.ProprietaryQuantity10
    ISO20022.Seev031002.Quantity80Choice *-- ISO20022.Seev031002.Quantity57Choice
    class ISO20022.Seev031002.QuantityToQuantityRatio2 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev031002.Rate47 {
        + DmdRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat77Choice~
        + EqulstnRate  : ISO20022.Seev031002.RateAndAmountFormat48Choice
        + TaxRclmRate  : ISO20022.Seev031002.RateFormat24Choice
        + TaxOnPrfts  : ISO20022.Seev031002.RateFormat24Choice
        + TaxOnIncm  : ISO20022.Seev031002.RateAndAmountFormat72Choice
        + TaxCdtRate  : ISO20022.Seev031002.RateFormat30Choice
        + SlctnFeeRate  : ISO20022.Seev031002.SolicitationFeeRateFormat15Choice
        + AplblRate  : ISO20022.Seev031002.RateFormat24Choice
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.NetDividendRateFormat43Choice~
        + ThrdPtyIncntivRate  : ISO20022.Seev031002.RateFormat30Choice
        + FsclStmp  : ISO20022.Seev031002.RateFormat24Choice
        + EarlySlctnFeeRate  : ISO20022.Seev031002.SolicitationFeeRateFormat15Choice
        + ChrgsFees  : ISO20022.Seev031002.RateAndAmountFormat72Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat76Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.RateAndAmountFormat76Choice~
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031002.GrossDividendRateFormat41Choice~
        + AddtlTax  : ISO20022.Seev031002.RateAndAmountFormat72Choice
    }
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat77Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat48Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat30Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.SolicitationFeeRateFormat15Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.NetDividendRateFormat43Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat30Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateFormat24Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.SolicitationFeeRateFormat15Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat76Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat76Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.GrossDividendRateFormat41Choice
    ISO20022.Seev031002.Rate47 *-- ISO20022.Seev031002.RateAndAmountFormat72Choice
    class ISO20022.Seev031002.RateAndAmountFormat48Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031002.RateAndAmountFormat48Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat57Choice {
        + Amt  : ISO20022.Seev031002.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat57Choice *-- ISO20022.Seev031002.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat72Choice {
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat72Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat73Choice {
        + IndxPts  : Decimal
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat73Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat74Choice {
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat74Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat75Choice {
        + RateTpAndRate  : ISO20022.Seev031002.RateTypeAndPercentageRate20
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat75Choice *-- ISO20022.Seev031002.RateTypeAndPercentageRate20
    ISO20022.Seev031002.RateAndAmountFormat75Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat76Choice {
        + RateTpAndRate  : ISO20022.Seev031002.RateTypeAndPercentageRate21
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat76Choice *-- ISO20022.Seev031002.RateTypeAndPercentageRate21
    ISO20022.Seev031002.RateAndAmountFormat76Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateAndAmountFormat77Choice {
        + RateTpAndRate  : ISO20022.Seev031002.RateTypeAndPercentageRate22
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031002.RateTypeAndAmountAndStatus54
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateAndAmountFormat77Choice *-- ISO20022.Seev031002.RateTypeAndPercentageRate22
    ISO20022.Seev031002.RateAndAmountFormat77Choice *-- ISO20022.Seev031002.RateTypeAndAmountAndStatus54
    ISO20022.Seev031002.RateAndAmountFormat77Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateFormat12Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031002.RateFormat24Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031002.RateFormat25Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031002.RateFormat30Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031002.RateFormat30Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031002.RateStatus1Code {
        INDI = 1
        ACTU = 2
    }
    class ISO20022.Seev031002.RateStatus4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateStatus4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateType10Code {
        UKWN = 1
        ANYA = 2
    }
    class ISO20022.Seev031002.RateType13Code {
        NILP = 1
        UKWN = 2
    }
    class ISO20022.Seev031002.RateType45Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateType45Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateType46Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateType46Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateType47Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateType47Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateType5Code {
        UKWN = 1
    }
    class ISO20022.Seev031002.RateType7Code {
        USCD = 1
        SCHD = 2
    }
    class ISO20022.Seev031002.RateType80Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateType80Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateType81Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RateType81Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RateTypeAndAmountAndStatus32 {
        + RateSts  : ISO20022.Seev031002.RateStatus4Choice
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031002.RateType45Choice
    }
    ISO20022.Seev031002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev031002.RateStatus4Choice
    ISO20022.Seev031002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev031002.RateType45Choice
    class ISO20022.Seev031002.RateTypeAndAmountAndStatus33 {
        + RateSts  : ISO20022.Seev031002.RateStatus4Choice
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031002.RateType47Choice
    }
    ISO20022.Seev031002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev031002.RateStatus4Choice
    ISO20022.Seev031002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev031002.RateType47Choice
    class ISO20022.Seev031002.RateTypeAndAmountAndStatus54 {
        + RateSts  : ISO20022.Seev031002.RateStatus4Choice
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031002.DeemedRateType2Choice
    }
    ISO20022.Seev031002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev031002.RateStatus4Choice
    ISO20022.Seev031002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev031002.DeemedRateType2Choice
    class ISO20022.Seev031002.RateTypeAndAmountAndStatus59 {
        + RateSts  : ISO20022.Seev031002.RateStatus4Choice
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031002.RateType80Choice
    }
    ISO20022.Seev031002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev031002.RateStatus4Choice
    ISO20022.Seev031002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev031002.RateType80Choice
    class ISO20022.Seev031002.RateTypeAndAmountAndStatus60 {
        + RateSts  : ISO20022.Seev031002.RateStatus4Choice
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031002.RateType81Choice
    }
    ISO20022.Seev031002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev031002.RateStatus4Choice
    ISO20022.Seev031002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev031002.RateType81Choice
    class ISO20022.Seev031002.RateTypeAndPercentageRate20 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031002.RateType46Choice
    }
    ISO20022.Seev031002.RateTypeAndPercentageRate20 *-- ISO20022.Seev031002.RateType46Choice
    class ISO20022.Seev031002.RateTypeAndPercentageRate21 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031002.RateType46Choice
    }
    ISO20022.Seev031002.RateTypeAndPercentageRate21 *-- ISO20022.Seev031002.RateType46Choice
    class ISO20022.Seev031002.RateTypeAndPercentageRate22 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031002.DeemedRateType2Choice
    }
    ISO20022.Seev031002.RateTypeAndPercentageRate22 *-- ISO20022.Seev031002.DeemedRateType2Choice
    class ISO20022.Seev031002.RateValueType7Code {
        UKWN = 1
    }
    class ISO20022.Seev031002.RatioFormat23Choice {
        + AmtToAmt  : ISO20022.Seev031002.AmountToAmountRatio3
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev031002.QuantityToQuantityRatio2
    }
    ISO20022.Seev031002.RatioFormat23Choice *-- ISO20022.Seev031002.AmountToAmountRatio3
    ISO20022.Seev031002.RatioFormat23Choice *-- ISO20022.Seev031002.QuantityToQuantityRatio2
    class ISO20022.Seev031002.RatioFormat24Choice {
        + QtyToAmt  : ISO20022.Seev031002.AmountAndQuantityRatio5
        + AmtToQty  : ISO20022.Seev031002.AmountAndQuantityRatio5
        + AmtToAmt  : ISO20022.Seev031002.AmountToAmountRatio3
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev031002.QuantityToQuantityRatio2
    }
    ISO20022.Seev031002.RatioFormat24Choice *-- ISO20022.Seev031002.AmountAndQuantityRatio5
    ISO20022.Seev031002.RatioFormat24Choice *-- ISO20022.Seev031002.AmountAndQuantityRatio5
    ISO20022.Seev031002.RatioFormat24Choice *-- ISO20022.Seev031002.AmountToAmountRatio3
    ISO20022.Seev031002.RatioFormat24Choice *-- ISO20022.Seev031002.QuantityToQuantityRatio2
    class ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.RenounceableStatus1Code {
        RENO = 1
        NREN = 2
    }
    class ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev031002.SafekeepingAccountIdentification1Code {
        GENR = 1
    }
    class ISO20022.Seev031002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev031002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev031002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Seev031002.SafekeepingPlaceFormat55Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification85
        + TpAndId  : ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev031002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev031002.SafekeepingPlaceFormat55Choice *-- ISO20022.Seev031002.GenericIdentification85
    ISO20022.Seev031002.SafekeepingPlaceFormat55Choice *-- ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev031002.SafekeepingPlaceFormat55Choice *-- ISO20022.Seev031002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev031002.SafekeepingPlaceFormat56Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification85
        + TpAndId  : ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev031002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Seev031002.SafekeepingPlaceFormat56Choice *-- ISO20022.Seev031002.GenericIdentification85
    ISO20022.Seev031002.SafekeepingPlaceFormat56Choice *-- ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev031002.SafekeepingPlaceFormat56Choice *-- ISO20022.Seev031002.SafekeepingPlaceTypeAndText15
    class ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031002.SecuritiesOption117 {
        + AmtDtls  : ISO20022.Seev031002.CorporateActionAmounts61
        + PricDtls  : ISO20022.Seev031002.CorporateActionPrice98
        + RateDtls  : ISO20022.Seev031002.CorporateActionRate137
        + DtDtls  : ISO20022.Seev031002.SecurityDate24
        + TradgPrd  : ISO20022.Seev031002.Period6Choice
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev031002.FractionDispositionType31Choice
        + CtryOfIncmSrc  : String
        + SfkpgPlc  : ISO20022.Seev031002.SafekeepingPlaceFormat56Choice
        + EntitldQty  : ISO20022.Seev031002.Quantity54Choice
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev031002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev031002.GenericIdentification47
        + NewSctiesIssncInd  : String
        + IssrOfferrTaxbltyInd  : ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice
        + NonElgblPrcdsInd  : ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice
        + TempFinInstrmInd  : ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice
        + CdtDbtInd  : String
        + SctyDtls  : ISO20022.Seev031002.FinancialInstrumentAttributes137
    }
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.CorporateActionAmounts61
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.CorporateActionPrice98
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.CorporateActionRate137
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.SecurityDate24
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.Period6Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.FractionDispositionType31Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.SafekeepingPlaceFormat56Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.Quantity54Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.GenericIdentification47
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice
    ISO20022.Seev031002.SecuritiesOption117 *-- ISO20022.Seev031002.FinancialInstrumentAttributes137
    class ISO20022.Seev031002.SecuritiesOption84 {
        + BckEndOddLotQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + FrntEndOddLotQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + NewDnmtnQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + NewBrdLotQty  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + MinMltplQtyToInst  : ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
        + MinQtyToInst  : ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
        + MaxQtyToInst  : ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    }
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    ISO20022.Seev031002.SecuritiesOption84 *-- ISO20022.Seev031002.FinancialInstrumentQuantity44Choice
    class ISO20022.Seev031002.SecurityDate24 {
        + LastTradgDt  : ISO20022.Seev031002.DateFormat41Choice
        + PrpssDt  : ISO20022.Seev031002.DateFormat41Choice
        + EarlstPmtDt  : ISO20022.Seev031002.DateFormat41Choice
        + DvddRnkgDt  : ISO20022.Seev031002.DateFormat41Choice
        + AvlblDt  : ISO20022.Seev031002.DateFormat41Choice
        + PmtDt  : ISO20022.Seev031002.DateFormat41Choice
    }
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    ISO20022.Seev031002.SecurityDate24 *-- ISO20022.Seev031002.DateFormat41Choice
    class ISO20022.Seev031002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev031002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev031002.SecurityIdentification20 *-- ISO20022.Seev031002.OtherIdentification2
    class ISO20022.Seev031002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev031002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev031002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev031002.SignedQuantityFormat12 *-- ISO20022.Seev031002.Quantity53Choice
    class ISO20022.Seev031002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev031002.SignedQuantityFormat13 *-- ISO20022.Seev031002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev031002.SolicitationFeeRateFormat15Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtToQty  : ISO20022.Seev031002.AmountAndQuantityRatio5
        + Rate  : Decimal
    }
    ISO20022.Seev031002.SolicitationFeeRateFormat15Choice *-- ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031002.SolicitationFeeRateFormat15Choice *-- ISO20022.Seev031002.AmountAndQuantityRatio5
    class ISO20022.Seev031002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev031002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev031002.SupplementaryData1 *-- ISO20022.Seev031002.SupplementaryDataEnvelope1
    class ISO20022.Seev031002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice {
        + Prtry  : ISO20022.Seev031002.GenericIdentification47
        + TempInd  : String
    }
    ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice *-- ISO20022.Seev031002.GenericIdentification47
    class ISO20022.Seev031002.TotalEligibleBalanceFormat11 {
        + PartWayPrdUnits  : ISO20022.Seev031002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev031002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev031002.Quantity80Choice
    }
    ISO20022.Seev031002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev031002.SignedQuantityFormat13
    ISO20022.Seev031002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev031002.Quantity80Choice
    class ISO20022.Seev031002.UpdatedAdditionalInformation24 {
        + AddtlInf  : String
        + Lang  : String
    }
    class ISO20022.Seev031002.UpdatedAdditionalInformation25 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Lang  : String
    }
    class ISO20022.Seev031002.UpdatedAdditionalInformation26 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Lang  : String
    }
    class ISO20022.Seev031002.UpdatedURLlnformation7 {
        + URLAdr  : String
        + Lang  : String
    }
    class ISO20022.Seev031002.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev031002.AccountAndBalance65


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev031002.CorporateActionBalanceDetails46||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev031002.SafekeepingPlaceFormat55Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev031002.PartyIdentification136Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Seev031002.AccountIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.AccountIdentification78Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctsListAndBalDtls|global::System.Collections.Generic.List<ISO20022.Seev031002.AccountAndBalance65>||XmlElement()||
|+|ForAllAccts|ISO20022.Seev031002.AccountIdentification10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validList("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validElement(AcctsListAndBalDtls),validElement(ForAllAccts),validChoice(AcctsListAndBalDtls,ForAllAccts))|

---

## Value ISO20022.Seev031002.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev031002.AdditionalBusinessProcess9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCP|Int32||XmlEnum("""INCP""")|1|
||REAC|Int32||XmlEnum("""REAC""")|2|
||PPRE|Int32||XmlEnum("""PPRE""")|3|
||FPRE|Int32||XmlEnum("""FPRE""")|4|
||PPUT|Int32||XmlEnum("""PPUT""")|5|
||CONS|Int32||XmlEnum("""CONS""")|6|
||SCHM|Int32||XmlEnum("""SCHM""")|7|
||NPLE|Int32||XmlEnum("""NPLE""")|8|
||NAMC|Int32||XmlEnum("""NAMC""")|9|
||CNTR|Int32||XmlEnum("""CNTR""")|10|
||ATXF|Int32||XmlEnum("""ATXF""")|11|
||ACLA|Int32||XmlEnum("""ACLA""")|12|

---

## Value ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.AmountAndQuantityRatio5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev031002.AmountAndRateStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|String||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev031002.AmountPrice4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031002.AmountPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031002.AmountPrice7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031002.AmountPricePerAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PricVal|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev031002.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Enum ISO20022.Seev031002.AmountPriceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Enum ISO20022.Seev031002.AmountPriceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLOT|Int32||XmlEnum("""PLOT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev031002.AmountToAmountRatio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Amt1|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Value ISO20022.Seev031002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev031002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev031002.BalanceFormat16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|NotElgblBal|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev031002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(PartWayPrdUnits,FullPrdUnits,NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev031002.BeneficiaryCertificationType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.BeneficiaryCertificationType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIOR|Int32||XmlEnum("""DIOR""")|1|
||PAPW|Int32||XmlEnum("""PAPW""")|2|
||FRAC|Int32||XmlEnum("""FRAC""")|3|
||PABD|Int32||XmlEnum("""PABD""")|4|
||TRBD|Int32||XmlEnum("""TRBD""")|5|
||QIBB|Int32||XmlEnum("""QIBB""")|6|
||NCOM|Int32||XmlEnum("""NCOM""")|7|
||FULL|Int32||XmlEnum("""FULL""")|8|
||NDOM|Int32||XmlEnum("""NDOM""")|9|
||DOMI|Int32||XmlEnum("""DOMI""")|10|
||ACCI|Int32||XmlEnum("""ACCI""")|11|

---

## Enum ISO20022.Seev031002.BidRangeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MULT|Int32||XmlEnum("""MULT""")|1|
||INCR|Int32||XmlEnum("""INCR""")|2|
||DIVI|Int32||XmlEnum("""DIVI""")|3|

---

## Value ISO20022.Seev031002.BidRangeType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.BlockChainAddressWallet11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev031002.BorrowerLendingDeadline6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brrwr|ISO20022.Seev031002.PartyIdentification136Choice||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brrwr),validElement(StockLndgDdln))|

---

## Value ISO20022.Seev031002.CapitalGainFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CashAccountIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev031002.BlockChainAddressWallet11||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev031002.CashOption113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Seev031002.PriceDetails43||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031002.Rate47||XmlElement()||
|+|FXDtls|ISO20022.Seev031002.ForeignExchangeTerms43||XmlElement()||
|+|DtDtls|ISO20022.Seev031002.CorporateActionDate97||XmlElement()||
|+|AmtDtls|ISO20022.Seev031002.CorporateActionAmounts76||XmlElement()||
|+|CshAcctId|ISO20022.Seev031002.CashAccountIdentification15Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|PricClctnMtd|ISO20022.Seev031002.PriceCalculationMethod1Choice||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev031002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev031002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice||XmlElement()||
|+|CtrctlPmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(RateAndAmtDtls),validElement(FXDtls),validElement(DtDtls),validElement(AmtDtls),validElement(CshAcctId),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validElement(PricClctnMtd),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd))|

---

## Enum ISO20022.Seev031002.CertificationFormatType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|

---

## Value ISO20022.Seev031002.CertificationTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Seev031002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Seev031002.ConsentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPY|Int32||XmlEnum("""DUPY""")|1|
||CTRM|Int32||XmlEnum("""CTRM""")|2|

---

## Value ISO20022.Seev031002.ConsentTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateAction87


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev031002.CorporateActionNarrative63||XmlElement()||
|+|NewPlcOfIncorprtn|String||XmlElement()||
|+|DtchAuctnTp|ISO20022.Seev031002.DutchAuctionTypeFormat2Choice||XmlElement()||
|+|TaxOnNonDstrbtdPrcdsInd|global::System.Collections.Generic.List<ISO20022.Seev031002.GenericIdentification47>||XmlElement()||
|+|InfTp|ISO20022.Seev031002.InformationTypeFormat5Choice||XmlElement()||
|+|CnsntTp|ISO20022.Seev031002.ConsentTypeFormat5Choice||XmlElement()||
|+|CertfctnTp|ISO20022.Seev031002.CertificationTypeFormat4Choice||XmlElement()||
|+|LtryTp|ISO20022.Seev031002.LotteryTypeFormat5Choice||XmlElement()||
|+|ElctnTp|ISO20022.Seev031002.ElectionTypeFormat4Choice||XmlElement()||
|+|TaxblIncmPerShrClctd|ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice||XmlElement()||
|+|CptlGnInOutInd|ISO20022.Seev031002.CapitalGainFormat4Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice||XmlElement()||
|+|ChngTp|global::System.Collections.Generic.List<ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice>||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev031002.AdditionalBusinessProcessFormat22Choice>||XmlElement()||
|+|EvtStag|global::System.Collections.Generic.List<ISO20022.Seev031002.CorporateActionEventStageFormat20Choice>||XmlElement()||
|+|RnncblEntitlmntStsTp|ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev031002.OfferTypeFormat16Choice>||XmlElement()||
|+|OcrncTp|ISO20022.Seev031002.DistributionTypeFormat8Choice||XmlElement()||
|+|EvtSeqTp|ISO20022.Seev031002.EventSequenceTypeFormat2Choice||XmlElement()||
|+|DvddTp|ISO20022.Seev031002.DividendTypeFormat10Choice||XmlElement()||
|+|ShrhldrRghtsDrctvInd|String||XmlElement()||
|+|LttrOfGrntedDlvryInd|String||XmlElement()||
|+|FrftrOfIntrstInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
|+|RstrctnInd|String||XmlElement()||
|+|ChrgsApldInd|String||XmlElement()||
|+|CertfctnBrkdwnInd|String||XmlElement()||
|+|AccptncPrtyLvl|String||XmlElement()||
|+|CpnNb|global::System.Collections.Generic.List<ISO20022.Seev031002.IdentificationFormat4Choice>||XmlElement()||
|+|IntrstAcrdNbOfDays|Decimal||XmlElement()||
|+|SctiesQty|ISO20022.Seev031002.CorporateActionQuantity14||XmlElement()||
|+|PricDtls|ISO20022.Seev031002.CorporateActionPrice96||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031002.CorporateActionRate135||XmlElement()||
|+|PrdDtls|ISO20022.Seev031002.CorporateActionPeriod16||XmlElement()||
|+|DtDtls|ISO20022.Seev031002.CorporateActionDate96||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""NewPlcOfIncorprtn""",NewPlcOfIncorprtn,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(DtchAuctnTp),validList("""TaxOnNonDstrbtdPrcdsInd""",TaxOnNonDstrbtdPrcdsInd),validElement(TaxOnNonDstrbtdPrcdsInd),validElement(InfTp),validElement(CnsntTp),validElement(CertfctnTp),validElement(LtryTp),validElement(ElctnTp),validElement(TaxblIncmPerShrClctd),validElement(CptlGnInOutInd),validElement(IntrmdtSctiesDstrbtnTp),validList("""ChngTp""",ChngTp),validElement(ChngTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validList("""EvtStag""",EvtStag),validElement(EvtStag),validElement(RnncblEntitlmntStsTp),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(OcrncTp),validElement(EvtSeqTp),validElement(DvddTp),validPattern("""AccptncPrtyLvl""",AccptncPrtyLvl,"""[A-Z0-9]{3}"""),validList("""CpnNb""",CpnNb),validElement(CpnNb),validElement(SctiesQty),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls))|

---

## Value ISO20022.Seev031002.CorporateActionAmounts61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt))|

---

## Value ISO20022.Seev031002.CorporateActionAmounts76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuyUpAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdRyltsAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdIntrstAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdFndAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdDvddAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FrgnIncmAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TxTax|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxOnIncmAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|BckUpWhldgTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NRATaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FATCATaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EqulstnAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EUTaxRtntnAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StockXchgTax|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IncmPrtn|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RedPrmAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PrncplOrCrps|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EntitldAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ChrgsAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ScndLvlTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddPmtAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|GrssAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyUpAmt),validElement(DmdRyltsAmt),validElement(DmdIntrstAmt),validElement(DmdFndAmt),validElement(DmdDvddAmt),validElement(FrgnIncmAmt),validElement(DmdAmt),validElement(TxTax),validElement(TaxOnIncmAmt),validElement(BckUpWhldgTaxAmt),validElement(NRATaxAmt),validElement(FATCATaxAmt),validElement(EqulstnAmt),validElement(AcrdIntrstAmt),validElement(EUTaxRtntnAmt),validElement(StockXchgTax),validElement(IncmPrtn),validElement(RedPrmAmt),validElement(PrncplOrCrps),validElement(OrgnlAmt),validElement(EntitldAmt),validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(ValAddedTaxAmt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(RinvstmtAmt),validElement(ManfctrdDvddPmtAmt),validElement(IndmntyAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(NetAmt),validElement(GrssAmt))|

---

## Value ISO20022.Seev031002.CorporateActionBalanceDetails46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UafctdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|AfctdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|InstdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|UinstdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|OblgtdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|RegdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|SttlmPosBal|global::System.Collections.Generic.List<ISO20022.Seev031002.BalanceFormat16Choice>||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev031002.BalanceFormat16Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev031002.BalanceFormat16Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev031002.TotalEligibleBalanceFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UafctdBal),validElement(AfctdBal),validElement(InstdBal),validElement(UinstdBal),validElement(OblgtdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validList("""SttlmPosBal""",SttlmPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal))|

---

## Enum ISO20022.Seev031002.CorporateActionChangeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DECI|Int32||XmlEnum("""DECI""")|1|
||TERM|Int32||XmlEnum("""TERM""")|2|
||REBE|Int32||XmlEnum("""REBE""")|3|
||PHDE|Int32||XmlEnum("""PHDE""")|4|
||NAME|Int32||XmlEnum("""NAME""")|5|
||GTPH|Int32||XmlEnum("""GTPH""")|6|
||GTGP|Int32||XmlEnum("""GTGP""")|7|
||GPPH|Int32||XmlEnum("""GPPH""")|8|
||DEPH|Int32||XmlEnum("""DEPH""")|9|
||CERT|Int32||XmlEnum("""CERT""")|10|
||BERE|Int32||XmlEnum("""BERE""")|11|

---

## Value ISO20022.Seev031002.CorporateActionChangeTypeFormat8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionDate108


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DcmnttnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|EndOfSctiesBlckgPrd|ISO20022.Seev031002.DateFormat71Choice||XmlElement()||
|+|BrrwrStockLndgDdln|global::System.Collections.Generic.List<ISO20022.Seev031002.BorrowerLendingDeadline6>||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|DpstryCoverXprtnDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|SbcptCostDbtDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|RspnDdln|ISO20022.Seev031002.DateFormat54Choice||XmlElement()||
|+|MktDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|PrtctDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|CoverXprtnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|EarlyRspnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DcmnttnDdln),validElement(EndOfSctiesBlckgPrd),validList("""BrrwrStockLndgDdln""",BrrwrStockLndgDdln),validElement(BrrwrStockLndgDdln),validElement(StockLndgDdln),validElement(DpstryCoverXprtnDt),validElement(SbcptCostDbtDt),validElement(XpryDt),validElement(RspnDdln),validElement(MktDdln),validElement(PrtctDdln),validElement(CoverXprtnDdln),validElement(EarlyRspnDdln))|

---

## Value ISO20022.Seev031002.CorporateActionDate96


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrgDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|FilgDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|LeadPlntffDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|MktClmTrckgEndDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|EarlyThrdPtyDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|ThrdPtyDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|LpsdDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|ElctnToCtrPtyRspnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|ElctnToCtrPtyMktDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|GrntedPrtcptnDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|SpclExDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|OffclAnncmntPblctnDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|ExDvddDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|WhlyUcondlDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|UcondlDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|TradgSspdDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|DdlnForTaxBrkdwnInstr|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|DdlnToSplt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|RsltsPblctnDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|RegnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|PrratnDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|MrgnFxgDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|MtgDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|NewMtrtyDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|LtryDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|FxgDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|FrthrDtldAnncmntDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|EqulstnDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|FctvDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|EarlyClsgDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|CrtApprvlDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|CertfctnDdln|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|AnncmntDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrgDt),validElement(FilgDt),validElement(LeadPlntffDdln),validElement(MktClmTrckgEndDt),validElement(EarlyThrdPtyDdln),validElement(ThrdPtyDdln),validElement(PmtDt),validElement(LpsdDt),validElement(ElctnToCtrPtyRspnDdln),validElement(ElctnToCtrPtyMktDdln),validElement(GrntedPrtcptnDt),validElement(SpclExDt),validElement(OffclAnncmntPblctnDt),validElement(ExDvddDt),validElement(WhlyUcondlDt),validElement(UcondlDt),validElement(TradgSspdDt),validElement(DdlnForTaxBrkdwnInstr),validElement(DdlnToSplt),validElement(RsltsPblctnDt),validElement(RegnDdln),validElement(RcrdDt),validElement(PrratnDt),validElement(MrgnFxgDt),validElement(MtgDt),validElement(NewMtrtyDt),validElement(LtryDt),validElement(FxgDt),validElement(FrthrDtldAnncmntDt),validElement(EqulstnDt),validElement(FctvDt),validElement(EarlyClsgDt),validElement(CrtApprvlDt),validElement(CertfctnDdln),validElement(AnncmntDt))|

---

## Value ISO20022.Seev031002.CorporateActionDate97


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarlstPmtDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev031002.DateFormat49Choice||XmlElement()||
|+|ValDt|ISO20022.Seev031002.DateFormat64Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarlstPmtDt),validElement(FXRateFxgDt),validElement(ValDt),validElement(PmtDt))|

---

## Enum ISO20022.Seev031002.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev031002.CorporateActionEventProcessingType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionEventReference4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031002.ProcessingPosition10Choice||XmlElement()||
|+|EvtId|ISO20022.Seev031002.CorporateActionEventReference4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev031002.CorporateActionEventReference4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LkdCorpActnId""",LkdCorpActnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LkdOffclCorpActnEvtId""",LkdOffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev031002.CorporateActionEventStage3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WHOU|Int32||XmlEnum("""WHOU""")|1|
||UNAC|Int32||XmlEnum("""UNAC""")|2|
||SUAP|Int32||XmlEnum("""SUAP""")|3|
||RESC|Int32||XmlEnum("""RESC""")|4|
||PWAL|Int32||XmlEnum("""PWAL""")|5|
||PART|Int32||XmlEnum("""PART""")|6|
||LAPS|Int32||XmlEnum("""LAPS""")|7|
||FULL|Int32||XmlEnum("""FULL""")|8|
||CLDE|Int32||XmlEnum("""CLDE""")|9|
||APPD|Int32||XmlEnum("""APPD""")|10|

---

## Value ISO20022.Seev031002.CorporateActionEventStageFormat20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionEventStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtConfSts|String||XmlElement()||
|+|EvtCmpltnsSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.CorporateActionEventType124Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.CorporateActionEventType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
||INFO|Int32||XmlEnum("""INFO""")|3|
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

## Enum ISO20022.Seev031002.CorporateActionFrequencyType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPRE|Int32||XmlEnum("""SPRE""")|1|
||SPEC|Int32||XmlEnum("""SPEC""")|2|
||REGR|Int32||XmlEnum("""REGR""")|3|
||REIN|Int32||XmlEnum("""REIN""")|4|
||INTE|Int32||XmlEnum("""INTE""")|5|
||FINL|Int32||XmlEnum("""FINL""")|6|

---

## Value ISO20022.Seev031002.CorporateActionGeneralInformation194


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev031002.FinancialInstrumentAttributes136||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice||XmlElement()||
|+|EvtTp|ISO20022.Seev031002.CorporateActionEventType124Choice||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev031002.CorporateActionEventProcessingType3Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validElement(EvtPrcgTp),validPattern("""ClssActnNb""",ClssActnNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Seev031002.CorporateActionInformationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONF|Int32||XmlEnum("""CONF""")|1|

---

## Enum ISO20022.Seev031002.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev031002.CorporateActionMandatoryVoluntary4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionNarrative63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtPrcgWebSiteAdr|String||XmlElement()||
|+|URLAdr|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedURLlnformation7>||XmlElement()||
|+|NewCpnyNm|String||XmlElement()||
|+|Offerr|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""EvtPrcgWebSiteAdr""",EvtPrcgWebSiteAdr,"""[0-9a-zA-Z!"%&\*;<> \.,\(\)\n\r/='\+:\?@#\{\-_]{1,2048}"""),validList("""URLAdr""",URLAdr),validElement(URLAdr),validPattern("""NewCpnyNm""",NewCpnyNm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""Offerr""",Offerr,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Seev031002.CorporateActionNarrative64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|Dsclmr|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|TaxtnConds|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|SctyRstrctn|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|InfConds|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation25>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation24>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation24>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertfctnBrkdwn""",CertfctnBrkdwn),validElement(CertfctnBrkdwn),validList("""Dsclmr""",Dsclmr),validElement(Dsclmr),validList("""TaxtnConds""",TaxtnConds),validElement(TaxtnConds),validList("""SctyRstrctn""",SctyRstrctn),validElement(SctyRstrctn),validList("""InfToCmplyWth""",InfToCmplyWth),validElement(InfToCmplyWth),validList("""InfConds""",InfConds),validElement(InfConds),validList("""NrrtvVrsn""",NrrtvVrsn),validElement(NrrtvVrsn),validList("""AddtlTxt""",AddtlTxt),validElement(AddtlTxt))|

---

## Value ISO20022.Seev031002.CorporateActionNarrative65


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgTxtForNxtIntrmy|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|URLAdr|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedURLlnformation7>||XmlElement()||
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|BsktOrIndxInf|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|RegnDtls|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|Dsclmr|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|TaxtnConds|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|InfConds|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<ISO20022.Seev031002.UpdatedAdditionalInformation26>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrcgTxtForNxtIntrmy""",PrcgTxtForNxtIntrmy),validElement(PrcgTxtForNxtIntrmy),validList("""URLAdr""",URLAdr),validElement(URLAdr),validList("""CertfctnBrkdwn""",CertfctnBrkdwn),validElement(CertfctnBrkdwn),validList("""BsktOrIndxInf""",BsktOrIndxInf),validElement(BsktOrIndxInf),validList("""RegnDtls""",RegnDtls),validElement(RegnDtls),validList("""PtyCtctNrrtv""",PtyCtctNrrtv),validElement(PtyCtctNrrtv),validList("""Dsclmr""",Dsclmr),validElement(Dsclmr),validList("""TaxtnConds""",TaxtnConds),validElement(TaxtnConds),validList("""InfToCmplyWth""",InfToCmplyWth),validElement(InfToCmplyWth),validList("""InfConds""",InfConds),validElement(InfConds),validList("""NrrtvVrsn""",NrrtvVrsn),validElement(NrrtvVrsn),validList("""AddtlTxt""",AddtlTxt),validElement(AddtlTxt))|

---

## Aspect ISO20022.Seev031002.CorporateActionNotification002V15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev031002.SupplementaryData1>||XmlElement()||
|+|TrfAgt|ISO20022.Seev031002.PartyIdentification151Choice||XmlElement()||
|+|Offerr|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification151Choice>||XmlElement()||
|+|Issr|ISO20022.Seev031002.PartyIdentification151Choice||XmlElement()||
|+|InfAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|SlctnAgt|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|DrpAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|PhysSctiesAgt|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|RsellngAgt|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|Regar|ISO20022.Seev031002.PartyIdentification137Choice||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification137Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev031002.PartyIdentification151Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev031002.CorporateActionNarrative65||XmlElement()||
|+|CorpActnOptnDtls|global::System.Collections.Generic.List<ISO20022.Seev031002.CorporateActionOption247>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev031002.CorporateAction87||XmlElement()||
|+|IntrmdtScty|ISO20022.Seev031002.FinancialInstrumentAttributes117||XmlElement()||
|+|AcctDtls|ISO20022.Seev031002.AccountIdentification78Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev031002.CorporateActionGeneralInformation194||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev031002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev031002.DocumentIdentification38>||XmlElement()||
|+|InstrId|ISO20022.Seev031002.DocumentIdentification17||XmlElement()||
|+|PrvsNtfctnId|ISO20022.Seev031002.DocumentIdentification37||XmlElement()||
|+|NtfctnGnlInf|ISO20022.Seev031002.CorporateActionNotification11||XmlElement()||
|+|Pgntn|ISO20022.Seev031002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TrfAgt),validList("""Offerr""",Offerr),validElement(Offerr),validElement(Issr),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validList("""CorpActnOptnDtls""",CorpActnOptnDtls),validElement(CorpActnOptnDtls),validElement(CorpActnDtls),validElement(IntrmdtScty),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(PrvsNtfctnId),validElement(NtfctnGnlInf),validElement(Pgntn))|

---

## Value ISO20022.Seev031002.CorporateActionNotification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgSts|ISO20022.Seev031002.CorporateActionProcessingStatus6Choice||XmlElement()||
|+|NtfctnTp|String||XmlElement()||
|+|NtfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgSts),validPattern("""NtfctnId""",NtfctnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Seev031002.CorporateActionNotificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RMDR|Int32||XmlEnum("""RMDR""")|1|
||REPL|Int32||XmlEnum("""REPL""")|2|
||NEWM|Int32||XmlEnum("""NEWM""")|3|

---

## Enum ISO20022.Seev031002.CorporateActionOption15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOBD|Int32||XmlEnum("""BOBD""")|1|
||PRUN|Int32||XmlEnum("""PRUN""")|2|
||SLLE|Int32||XmlEnum("""SLLE""")|3|
||SECU|Int32||XmlEnum("""SECU""")|4|
||QINV|Int32||XmlEnum("""QINV""")|5|
||OVER|Int32||XmlEnum("""OVER""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||OFFR|Int32||XmlEnum("""OFFR""")|8|
||NOQU|Int32||XmlEnum("""NOQU""")|9|
||NOAC|Int32||XmlEnum("""NOAC""")|10|
||MPUT|Int32||XmlEnum("""MPUT""")|11|
||LAPS|Int32||XmlEnum("""LAPS""")|12|
||EXER|Int32||XmlEnum("""EXER""")|13|
||CTEN|Int32||XmlEnum("""CTEN""")|14|
||CONY|Int32||XmlEnum("""CONY""")|15|
||CONN|Int32||XmlEnum("""CONN""")|16|
||CEXC|Int32||XmlEnum("""CEXC""")|17|
||CASH|Int32||XmlEnum("""CASH""")|18|
||CASE|Int32||XmlEnum("""CASE""")|19|
||BUYA|Int32||XmlEnum("""BUYA""")|20|
||BSPL|Int32||XmlEnum("""BSPL""")|21|
||ABST|Int32||XmlEnum("""ABST""")|22|

---

## Value ISO20022.Seev031002.CorporateActionOption247


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev031002.CorporateActionNarrative64||XmlElement()||
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev031002.CashOption113>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev031002.SecuritiesOption117>||XmlElement()||
|+|SctiesQty|ISO20022.Seev031002.SecuritiesOption84||XmlElement()||
|+|PricDtls|ISO20022.Seev031002.CorporateActionPrice97||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031002.CorporateActionRate136||XmlElement()||
|+|PrdDtls|ISO20022.Seev031002.CorporateActionPeriod12||XmlElement()||
|+|DtDtls|ISO20022.Seev031002.CorporateActionDate108||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031002.SecurityIdentification20||XmlElement()||
|+|ApldOptnInd|String||XmlElement()||
|+|ChngAllwdInd|String||XmlElement()||
|+|WdrwlAllwdInd|String||XmlElement()||
|+|CertfctnBrkdwnInd|String||XmlElement()||
|+|ChrgsApldInd|String||XmlElement()||
|+|DfltPrcgOrStgInstr|ISO20022.Seev031002.DefaultProcessingOrStandingInstruction2Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|VldDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NonDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrratnBlwMinQty|ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice||XmlElement()||
|+|BidRgTp|ISO20022.Seev031002.BidRangeType2Choice||XmlElement()||
|+|CertfctnBrkdwnTp|global::System.Collections.Generic.List<ISO20022.Seev031002.BeneficiaryCertificationType15Choice>||XmlElement()||
|+|AccptncPrtyLvl|String||XmlElement()||
|+|OptnAvlbtySts|ISO20022.Seev031002.OptionAvailabilityStatus4Choice||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev031002.OptionFeaturesFormat31Choice>||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev031002.OfferTypeFormat16Choice>||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031002.FractionDispositionType31Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev031002.CorporateActionOption46Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(SctiesQty),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls),validElement(FinInstrmId),validElement(DfltPrcgOrStgInstr),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validPattern("""VldDmclCtry""",VldDmclCtry,"""[A-Z]{2,2}"""),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validElement(PrratnBlwMinQty),validElement(BidRgTp),validList("""CertfctnBrkdwnTp""",CertfctnBrkdwnTp),validElement(CertfctnBrkdwnTp),validPattern("""AccptncPrtyLvl""",AccptncPrtyLvl,"""[A-Z0-9]{3}"""),validElement(OptnAvlbtySts),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(FrctnDspstn),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev031002.CorporateActionOption46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionPeriod12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DpstrySspnsnPrdForWdrwl|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|AcctSvcrRvcbltyPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|PrvlgSspnsnPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|RvcbltyPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|ActnPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|ParllTradgPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DpstrySspnsnPrdForWdrwl),validElement(AcctSvcrRvcbltyPrd),validElement(PrvlgSspnsnPrd),validElement(RvcbltyPrd),validElement(ActnPrd),validElement(ParllTradgPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev031002.CorporateActionPeriod16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FsclYrPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|SpltPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|CoDpstriesSspnsnPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|BookClsrPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlInStrtNm|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlInNmneeNm|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlAtAgt|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForSgrtn|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForPldg|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForDpst|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForDpstAtAgt|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForBookNtryTrf|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|ClmPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|CmplsryPurchsPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|IntrstPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FsclYrPrd),validElement(SpltPrd),validElement(CoDpstriesSspnsnPrd),validElement(BookClsrPrd),validElement(DpstrySspnsnPrdForWdrwlInStrtNm),validElement(DpstrySspnsnPrdForWdrwlInNmneeNm),validElement(DpstrySspnsnPrdForWdrwlAtAgt),validElement(DpstrySspnsnPrdForSgrtn),validElement(DpstrySspnsnPrdForPldg),validElement(DpstrySspnsnPrdForDpst),validElement(DpstrySspnsnPrdForDpstAtAgt),validElement(DpstrySspnsnPrdForBookNtryTrf),validElement(ClmPrd),validElement(CmplsryPurchsPrd),validElement(IntrstPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev031002.CorporateActionPrice96


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastBidIncrmtPric|ISO20022.Seev031002.PriceFormat91Choice||XmlElement()||
|+|FrstBidIncrmtPric|ISO20022.Seev031002.PriceFormat91Choice||XmlElement()||
|+|MinPric|ISO20022.Seev031002.PriceFormat91Choice||XmlElement()||
|+|MaxPric|ISO20022.Seev031002.PriceFormat91Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastBidIncrmtPric),validElement(FrstBidIncrmtPric),validElement(MinPric),validElement(MaxPric))|

---

## Value ISO20022.Seev031002.CorporateActionPrice97


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastBidIncrmtPric|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
|+|FrstBidIncrmtPric|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
|+|MinPric|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
|+|MaxPric|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
|+|MinMltplCshToInst|ISO20022.Seev031002.PriceFormat62Choice||XmlElement()||
|+|MinCshToInst|ISO20022.Seev031002.PriceFormat62Choice||XmlElement()||
|+|MaxCshToInst|ISO20022.Seev031002.PriceFormat62Choice||XmlElement()||
|+|OverSbcptDpstPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastBidIncrmtPric),validElement(FrstBidIncrmtPric),validElement(MinPric),validElement(MaxPric),validElement(MinMltplCshToInst),validElement(MinCshToInst),validElement(MaxCshToInst),validElement(OverSbcptDpstPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev031002.CorporateActionPrice98


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricRcvdPerPdct|ISO20022.Seev031002.PriceFormat94Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
|+|CshValForTax|ISO20022.Seev031002.PriceFormat58Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev031002.IndicativeOrMarketPrice18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct),validElement(CshValForTax),validElement(CshInLieuOfShrPric),validElement(IndctvOrMktPric))|

---

## Value ISO20022.Seev031002.CorporateActionProcessingStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|ISO20022.Seev031002.CorporateActionEventStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Cd),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.CorporateActionQuantity14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IncrmtlDnmtn|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|BaseDnmtn|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewDnmtnQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewBrdLotQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|MinQtySght|ISO20022.Seev031002.FinancialInstrumentQuantity44Choice||XmlElement()||
|+|MaxQty|ISO20022.Seev031002.FinancialInstrumentQuantity44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IncrmtlDnmtn),validElement(BaseDnmtn),validElement(NewDnmtnQty),validElement(NewBrdLotQty),validElement(MinQtySght),validElement(MaxQty))|

---

## Value ISO20022.Seev031002.CorporateActionRate135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxFctr|ISO20022.Seev031002.RateAndAmountFormat57Choice||XmlElement()||
|+|DclrdRate|ISO20022.Seev031002.RateAndAmountFormat74Choice||XmlElement()||
|+|RealsdLoss|ISO20022.Seev031002.RateAndAmountFormat74Choice||XmlElement()||
|+|IntrstShrtfll|ISO20022.Seev031002.RateAndAmountFormat74Choice||XmlElement()||
|+|RinvstmtDscntRateToMkt|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|NxtFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|BidIntrvl|ISO20022.Seev031002.RateAndAmountFormat73Choice||XmlElement()||
|+|Sprd|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|RltdIndx|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|PctgSght|ISO20022.Seev031002.RateFormat25Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndxFctr),validElement(DclrdRate),validElement(RealsdLoss),validElement(IntrstShrtfll),validElement(RinvstmtDscntRateToMkt),validElement(NxtFctr),validElement(PrvsFctr),validElement(BidIntrvl),validElement(Sprd),validElement(RltdIndx),validElement(PctgSght),validElement(IntrstRate))|

---

## Value ISO20022.Seev031002.CorporateActionRate136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BidIntrvl|ISO20022.Seev031002.RateAndAmountFormat73Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
|+|IssrDclrdXchgRate|ISO20022.Seev031002.ForeignExchangeTerms38||XmlElement()||
|+|TaxblIncmPerDvddShr|global::System.Collections.Generic.List<ISO20022.Seev031002.RateTypeAndAmountAndStatus33>||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat75Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat75Choice>||XmlElement()||
|+|PrratnRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|MaxAllwdOvrsbcptRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice>||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031002.NetDividendRateFormat43Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031002.GrossDividendRateFormat41Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BidIntrvl),validElement(TaxOnIncm),validElement(IssrDclrdXchgRate),validList("""TaxblIncmPerDvddShr""",TaxblIncmPerDvddShr),validElement(TaxblIncmPerDvddShr),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(PrratnRate),validElement(MaxAllwdOvrsbcptRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev031002.CorporateActionRate137


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat76Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat76Choice>||XmlElement()||
|+|FinTxTaxRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev031002.RateFormat30Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
|+|TrfrmatnRate|Decimal||XmlElement()||
|+|NewToOd|ISO20022.Seev031002.RatioFormat24Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev031002.RatioFormat23Choice||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev031002.RatioFormat23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(FinTxTaxRate),validElement(TaxCdtRate),validElement(AplblRate),validElement(FsclStmp),validElement(ChrgsFees),validElement(NewToOd),validElement(AddtlQtyForExstgScties),validElement(AddtlQtyForSbcbdRsltntScties))|

---

## Enum ISO20022.Seev031002.CorporateActionTaxableIncomePerShareCalculated1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TDIN|Int32||XmlEnum("""TDIN""")|2|
||TDIY|Int32||XmlEnum("""TDIY""")|3|

---

## Enum ISO20022.Seev031002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev031002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev031002.DateCode22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.DateCode26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.DateCode27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.DateCode39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.DateCodeAndTimeFormat4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|DtCd|ISO20022.Seev031002.DateCode26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd))|

---

## Value ISO20022.Seev031002.DateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031002.DateCode22Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031002.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev031002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Value ISO20022.Seev031002.DateFormat49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031002.DateCode22Choice||XmlElement()||
|+|Dt|ISO20022.Seev031002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031002.DateFormat54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031002.DateCode22Choice||XmlElement()||
|+|DtCdAndTm|ISO20022.Seev031002.DateCodeAndTimeFormat4||XmlElement()||
|+|Dt|ISO20022.Seev031002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(DtCdAndTm),validElement(Dt),validChoice(DtCd,DtCdAndTm,Dt))|

---

## Value ISO20022.Seev031002.DateFormat64Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031002.DateCode27Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031002.DateFormat71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031002.DateCode39Choice||XmlElement()||
|+|Dt|ISO20022.Seev031002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev031002.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev031002.DateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|

---

## Enum ISO20022.Seev031002.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Enum ISO20022.Seev031002.DateType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|
||RDDT|Int32||XmlEnum("""RDDT""")|3|
||RDTE|Int32||XmlEnum("""RDTE""")|4|
||PAYD|Int32||XmlEnum("""PAYD""")|5|
||MEET|Int32||XmlEnum("""MEET""")|6|
||MKDT|Int32||XmlEnum("""MKDT""")|7|
||PWAL|Int32||XmlEnum("""PWAL""")|8|

---

## Enum ISO20022.Seev031002.DeemedRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERY|Int32||XmlEnum("""DERY""")|1|
||DEIT|Int32||XmlEnum("""DEIT""")|2|
||DEFP|Int32||XmlEnum("""DEFP""")|3|
||DEDI|Int32||XmlEnum("""DEDI""")|4|

---

## Value ISO20022.Seev031002.DeemedRateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.DefaultProcessingOrStandingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgInstrInd|String||XmlElement()||
|+|DfltOptnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(StgInstrInd,DfltOptnInd))|

---

## Enum ISO20022.Seev031002.DistributionType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ROLL|Int32||XmlEnum("""ROLL""")|1|
||ONGO|Int32||XmlEnum("""ONGO""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|
||FINL|Int32||XmlEnum("""FINL""")|4|

---

## Value ISO20022.Seev031002.DistributionTypeFormat8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.DividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Value ISO20022.Seev031002.DividendTypeFormat10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev031002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnNtfctn|ISO20022.Seev031002.CorporateActionNotification002V15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnNtfctn))|

---

## Value ISO20022.Seev031002.DocumentIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.DocumentIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031002.ProcessingPosition10Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.DocumentIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031002.ProcessingPosition10Choice||XmlElement()||
|+|DocNb|ISO20022.Seev031002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev031002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev031002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev031002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev031002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Seev031002.DutchAuctionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNMD|Int32||XmlEnum("""UNMD""")|1|
||MDFD|Int32||XmlEnum("""MDFD""")|2|

---

## Value ISO20022.Seev031002.DutchAuctionTypeFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Enum ISO20022.Seev031002.ElectionMovementType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEQD|Int32||XmlEnum("""SEQD""")|1|
||DRCT|Int32||XmlEnum("""DRCT""")|2|

---

## Value ISO20022.Seev031002.ElectionTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.EventCompletenessStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCO|Int32||XmlEnum("""INCO""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Enum ISO20022.Seev031002.EventConfirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCON|Int32||XmlEnum("""UCON""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Enum ISO20022.Seev031002.EventSequenceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INTE|Int32||XmlEnum("""INTE""")|1|
||FINL|Int32||XmlEnum("""FINL""")|2|

---

## Value ISO20022.Seev031002.EventSequenceTypeFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.FinancialInstrumentAttributes117


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|UinstdBal|ISO20022.Seev031002.BalanceFormat14Choice||XmlElement()||
|+|TradgPrd|ISO20022.Seev031002.Period11||XmlElement()||
|+|PstngDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|MktPric|ISO20022.Seev031002.AmountPrice4||XmlElement()||
|+|IntrmdtSctiesToUndrlygRatio|ISO20022.Seev031002.QuantityToQuantityRatio2||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031002.FractionDispositionType32Choice||XmlElement()||
|+|RnncblEntitlmntStsTp|ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|SctyId|ISO20022.Seev031002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdBal),validElement(UinstdBal),validElement(TradgPrd),validElement(PstngDt),validElement(XpryDt),validElement(MktPric),validElement(IntrmdtSctiesToUndrlygRatio),validElement(FrctnDspstn),validElement(RnncblEntitlmntStsTp),validElement(SctyId))|

---

## Value ISO20022.Seev031002.FinancialInstrumentAttributes136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctSz|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|WarrtParity|ISO20022.Seev031002.QuantityToQuantityRatio2||XmlElement()||
|+|NxtFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|PctgOfDebtClm|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
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
|+|OptnStyle|ISO20022.Seev031002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev031002.ClassificationType33Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev031002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev031002.MarketIdentification4Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinNmnlQty),validElement(WarrtParity),validElement(NxtFctr),validElement(PrvsFctr),validElement(PctgOfDebtClm),validElement(NxtIntrstRate),validElement(IntrstRate),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev031002.FinancialInstrumentAttributes137


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssePric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
|+|CtrctSz|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|NxtFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031002.RateFormat12Choice||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|NxtCpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnStyle|ISO20022.Seev031002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev031002.ClassificationType33Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev031002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev031002.MarketIdentification4Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssePric),validElement(CtrctSz),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MinNmnlQty),validElement(NxtIntrstRate),validElement(IntrstRate),validElement(NxtFctr),validElement(PrvsFctr),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev031002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031002.FinancialInstrumentQuantity43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031002.FinancialInstrumentQuantity44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031002.ForeignExchangeTerms38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031002.ForeignExchangeTerms43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031002.FractionDispositionType31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.FractionDispositionType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.FractionDispositionType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|
||STAN|Int32||XmlEnum("""STAN""")|3|
||RDDN|Int32||XmlEnum("""RDDN""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|
||CINL|Int32||XmlEnum("""CINL""")|6|
||BUYU|Int32||XmlEnum("""BUYU""")|7|

---

## Enum ISO20022.Seev031002.FractionDispositionType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|
||STAN|Int32||XmlEnum("""STAN""")|3|
||RDDN|Int32||XmlEnum("""RDDN""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|

---

## Value ISO20022.Seev031002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev031002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev031002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.GrossDividendRateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031002.RateTypeAndAmountAndStatus59||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev031002.GrossDividendRateType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDFI|Int32||XmlEnum("""CDFI""")|1|
||UNFR|Int32||XmlEnum("""UNFR""")|2|
||TXFR|Int32||XmlEnum("""TXFR""")|3|
||TXDF|Int32||XmlEnum("""TXDF""")|4|
||TXBL|Int32||XmlEnum("""TXBL""")|5|
||SOIC|Int32||XmlEnum("""SOIC""")|6|
||STCG|Int32||XmlEnum("""STCG""")|7|
||REES|Int32||XmlEnum("""REES""")|8|
||LTCG|Int32||XmlEnum("""LTCG""")|9|
||INTR|Int32||XmlEnum("""INTR""")|10|
||INCO|Int32||XmlEnum("""INCO""")|11|
||FLFR|Int32||XmlEnum("""FLFR""")|12|
||CAPO|Int32||XmlEnum("""CAPO""")|13|

---

## Value ISO20022.Seev031002.IdentificationFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev031002.GenericIdentification86||XmlElement()||
|+|LngId|String||XmlElement()||
|+|ShrtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""LngId""",LngId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ShrtId""",ShrtId,"""[A-Z0-9]{3}"""),validChoice(PrtryId,LngId,ShrtId))|

---

## Value ISO20022.Seev031002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.IndicativeOrMarketPrice18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Value ISO20022.Seev031002.InformationTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.InterestComputationMethod2Code


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

## Value ISO20022.Seev031002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031002.RateTypeAndAmountAndStatus32||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev031002.IntermediateSecuritiesDistributionTypeFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.IntermediateSecurityDistributionType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MRGR|Int32||XmlEnum("""MRGR""")|1|
||EXOF|Int32||XmlEnum("""EXOF""")|2|
||BONU|Int32||XmlEnum("""BONU""")|3|
||SPLF|Int32||XmlEnum("""SPLF""")|4|
||SOFF|Int32||XmlEnum("""SOFF""")|5|
||LIQU|Int32||XmlEnum("""LIQU""")|6|
||INTR|Int32||XmlEnum("""INTR""")|7|
||DVSE|Int32||XmlEnum("""DVSE""")|8|
||DVSC|Int32||XmlEnum("""DVSC""")|9|
||PRIO|Int32||XmlEnum("""PRIO""")|10|
||EXRI|Int32||XmlEnum("""EXRI""")|11|
||DVOP|Int32||XmlEnum("""DVOP""")|12|
||DVCA|Int32||XmlEnum("""DVCA""")|13|
||DRIP|Int32||XmlEnum("""DRIP""")|14|
||BIDS|Int32||XmlEnum("""BIDS""")|15|

---

## Value ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.IssuerTaxability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Enum ISO20022.Seev031002.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev031002.LotteryTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev031002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Seev031002.NetDividendRateFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031002.RateTypeAndAmountAndStatus60||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev031002.NetDividendRateType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNFR|Int32||XmlEnum("""UNFR""")|1|
||TXFR|Int32||XmlEnum("""TXFR""")|2|
||TXDF|Int32||XmlEnum("""TXDF""")|3|
||TXBL|Int32||XmlEnum("""TXBL""")|4|
||SOIC|Int32||XmlEnum("""SOIC""")|5|
||REES|Int32||XmlEnum("""REES""")|6|
||INTR|Int32||XmlEnum("""INTR""")|7|
||INCO|Int32||XmlEnum("""INCO""")|8|
||FLFR|Int32||XmlEnum("""FLFR""")|9|
||CDFI|Int32||XmlEnum("""CDFI""")|10|
||CAPO|Int32||XmlEnum("""CAPO""")|11|

---

## Enum ISO20022.Seev031002.NewSecuritiesIssuanceType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REFU|Int32||XmlEnum("""REFU""")|1|
||NREF|Int32||XmlEnum("""NREF""")|2|
||UKWN|Int32||XmlEnum("""UKWN""")|3|
||NDEF|Int32||XmlEnum("""NDEF""")|4|
||NEIS|Int32||XmlEnum("""NEIS""")|5|
||EXIS|Int32||XmlEnum("""EXIS""")|6|
||DEFE|Int32||XmlEnum("""DEFE""")|7|

---

## Enum ISO20022.Seev031002.NonEligibleProceedsIndicator2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NELS|Int32||XmlEnum("""NELS""")|1|
||ONEL|Int32||XmlEnum("""ONEL""")|2|
||ACLI|Int32||XmlEnum("""ACLI""")|3|
||NELC|Int32||XmlEnum("""NELC""")|4|

---

## Value ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.OfferType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACPR|Int32||XmlEnum("""ACPR""")|1|
||SQUE|Int32||XmlEnum("""SQUE""")|2|
||ERUN|Int32||XmlEnum("""ERUN""")|3|
||PART|Int32||XmlEnum("""PART""")|4|
||FCFS|Int32||XmlEnum("""FCFS""")|5|
||FINL|Int32||XmlEnum("""FINL""")|6|
||NDIS|Int32||XmlEnum("""NDIS""")|7|
||DISS|Int32||XmlEnum("""DISS""")|8|

---

## Value ISO20022.Seev031002.OfferTypeFormat16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.OptionAvailabilityStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||INTV|Int32||XmlEnum("""INTV""")|2|

---

## Value ISO20022.Seev031002.OptionAvailabilityStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.OptionFeatures13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNET|Int32||XmlEnum("""RNET""")|1|
||RGRS|Int32||XmlEnum("""RGRS""")|2|
||SHAR|Int32||XmlEnum("""SHAR""")|3|
||QCAS|Int32||XmlEnum("""QCAS""")|4|
||VVPR|Int32||XmlEnum("""VVPR""")|5|
||PROR|Int32||XmlEnum("""PROR""")|6|
||PINS|Int32||XmlEnum("""PINS""")|7|
||CAOS|Int32||XmlEnum("""CAOS""")|8|
||OPLF|Int32||XmlEnum("""OPLF""")|9|
||NOSE|Int32||XmlEnum("""NOSE""")|10|
||MAXS|Int32||XmlEnum("""MAXS""")|11|
||MAXC|Int32||XmlEnum("""MAXC""")|12|
||COND|Int32||XmlEnum("""COND""")|13|
||BOIS|Int32||XmlEnum("""BOIS""")|14|
||ASVO|Int32||XmlEnum("""ASVO""")|15|

---

## Value ISO20022.Seev031002.OptionFeaturesFormat31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Seev031002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.OriginalAndCurrentQuantities7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev031002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev031002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev031002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev031002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev031002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev031002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev031002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev031002.PartyIdentification151Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev031002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev031002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,NmAndAdr,PrtryId,AnyBIC))|

---

## Enum ISO20022.Seev031002.Payment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Value ISO20022.Seev031002.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.PercentagePrice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.Period11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev031002.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Seev031002.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev031002.Period6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrdCd|String||XmlElement()||
|+|Prd|ISO20022.Seev031002.Period11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validChoice(PrdCd,Prd))|

---

## Value ISO20022.Seev031002.PriceCalculationMethod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.PriceCalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVCL|Int32||XmlEnum("""AVCL""")|1|
||NAVA|Int32||XmlEnum("""NAVA""")|2|
||MIMP|Int32||XmlEnum("""MIMP""")|3|
||NAVF|Int32||XmlEnum("""NAVF""")|4|
||VWAP|Int32||XmlEnum("""VWAP""")|5|

---

## Value ISO20022.Seev031002.PriceDetails43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInLieuOfShrPric|ISO20022.Seev031002.PriceFormat92Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev031002.PriceFormat94Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev031002.PriceFormat93Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInLieuOfShrPric),validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct))|

---

## Value ISO20022.Seev031002.PriceFormat58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev031002.PriceFormat62Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev031002.PriceFormat91Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev031002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031002.PriceFormat92Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev031002.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031002.PriceFormat93Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev031002.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031002.PriceFormat94Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev031002.AmountPricePerAmount3||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev031002.AmountPricePerFinancialInstrumentQuantity11||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev031002.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev031002.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev031002.PriceValueType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev031002.PriceValueType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||UNSP|Int32||XmlEnum("""UNSP""")|3|
||TBSP|Int32||XmlEnum("""TBSP""")|4|

---

## Value ISO20022.Seev031002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev031002.ProprietaryQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev031002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev031002.ProrationBelowMinimumQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.ProrationBelowMinimumQuantity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|
||MILT|Int32||XmlEnum("""MILT""")|3|
||MIEX|Int32||XmlEnum("""MIEX""")|4|
||FULL|Int32||XmlEnum("""FULL""")|5|

---

## Enum ISO20022.Seev031002.Quantity4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANYA|Int32||XmlEnum("""ANYA""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev031002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev031002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev031002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev031002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev031002.Quantity57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev031002.OriginalAndCurrentQuantities7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Enum ISO20022.Seev031002.Quantity5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev031002.Quantity80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev031002.ProprietaryQuantity10||XmlElement()||
|+|QtyChc|ISO20022.Seev031002.Quantity57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev031002.QuantityToQuantityRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.Rate47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmdRate|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat77Choice>||XmlElement()||
|+|EqulstnRate|ISO20022.Seev031002.RateAndAmountFormat48Choice||XmlElement()||
|+|TaxRclmRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|TaxOnPrfts|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev031002.RateFormat30Choice||XmlElement()||
|+|SlctnFeeRate|ISO20022.Seev031002.SolicitationFeeRateFormat15Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031002.NetDividendRateFormat43Choice>||XmlElement()||
|+|ThrdPtyIncntivRate|ISO20022.Seev031002.RateFormat30Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev031002.RateFormat24Choice||XmlElement()||
|+|EarlySlctnFeeRate|ISO20022.Seev031002.SolicitationFeeRateFormat15Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat76Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031002.RateAndAmountFormat76Choice>||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev031002.InterestRateUsedForPaymentFormat18Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031002.GrossDividendRateFormat41Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev031002.RateAndAmountFormat72Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DmdRate""",DmdRate),validElement(DmdRate),validElement(EqulstnRate),validElement(TaxRclmRate),validElement(TaxOnPrfts),validElement(TaxOnIncm),validElement(TaxCdtRate),validElement(SlctnFeeRate),validElement(AplblRate),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validElement(ThrdPtyIncntivRate),validElement(FsclStmp),validElement(EarlySlctnFeeRate),validElement(ChrgsFees),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031002.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat72Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(IndxPts,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat74Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat75Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031002.RateTypeAndPercentageRate20||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031002.RateTypeAndPercentageRate21||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateAndAmountFormat77Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031002.RateTypeAndPercentageRate22||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031002.RateTypeAndAmountAndStatus54||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndRate,RateTpAndAmtAndRateSts,NotSpcfdRate,Amt,Rate))|

---

## Value ISO20022.Seev031002.RateFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateFormat25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031002.RateFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt,Rate))|

---

## Enum ISO20022.Seev031002.RateStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDI|Int32||XmlEnum("""INDI""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev031002.RateStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.RateType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||ANYA|Int32||XmlEnum("""ANYA""")|2|

---

## Enum ISO20022.Seev031002.RateType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev031002.RateType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.RateType46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.RateType47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.RateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev031002.RateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USCD|Int32||XmlEnum("""USCD""")|1|
||SCHD|Int32||XmlEnum("""SCHD""")|2|

---

## Value ISO20022.Seev031002.RateType80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.RateType81Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.RateTypeAndAmountAndStatus32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndAmountAndStatus33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndAmountAndStatus54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndAmountAndStatus59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndAmountAndStatus60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType81Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndPercentageRate20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndPercentageRate21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031002.RateType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev031002.RateTypeAndPercentageRate22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev031002.RateValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev031002.RatioFormat23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtToAmt|ISO20022.Seev031002.AmountToAmountRatio3||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev031002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtToAmt),validElement(QtyToQty),validChoice(AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev031002.RatioFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyToAmt|ISO20022.Seev031002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToQty|ISO20022.Seev031002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToAmt|ISO20022.Seev031002.AmountToAmountRatio3||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev031002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(QtyToAmt,AmtToQty,AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev031002.RenounceableEntitlementStatusTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031002.RenounceableStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RENO|Int32||XmlEnum("""RENO""")|1|
||NREN|Int32||XmlEnum("""NREN""")|2|

---

## Value ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev031002.SafekeepingAccountIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GENR|Int32||XmlEnum("""GENR""")|1|

---

## Enum ISO20022.Seev031002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev031002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Enum ISO20022.Seev031002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Seev031002.SafekeepingPlaceFormat55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev031002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev031002.SafekeepingPlaceFormat56Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev031002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev031002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev031002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev031002.SecuritiesOption117


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtDtls|ISO20022.Seev031002.CorporateActionAmounts61||XmlElement()||
|+|PricDtls|ISO20022.Seev031002.CorporateActionPrice98||XmlElement()||
|+|RateDtls|ISO20022.Seev031002.CorporateActionRate137||XmlElement()||
|+|DtDtls|ISO20022.Seev031002.SecurityDate24||XmlElement()||
|+|TradgPrd|ISO20022.Seev031002.Period6Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031002.FractionDispositionType31Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev031002.SafekeepingPlaceFormat56Choice||XmlElement()||
|+|EntitldQty|ISO20022.Seev031002.Quantity54Choice||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev031002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev031002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|NewSctiesIssncInd|String||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev031002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev031002.NonEligibleProceedsIndicator6Choice||XmlElement()||
|+|TempFinInstrmInd|ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|SctyDtls|ISO20022.Seev031002.FinancialInstrumentAttributes137||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtDtls),validElement(PricDtls),validElement(RateDtls),validElement(DtDtls),validElement(TradgPrd),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validElement(SfkpgPlc),validElement(EntitldQty),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd),validElement(TempFinInstrmInd),validElement(SctyDtls))|

---

## Value ISO20022.Seev031002.SecuritiesOption84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BckEndOddLotQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|FrntEndOddLotQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewDnmtnQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewBrdLotQty|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev031002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev031002.FinancialInstrumentQuantity44Choice||XmlElement()||
|+|MaxQtyToInst|ISO20022.Seev031002.FinancialInstrumentQuantity44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BckEndOddLotQty),validElement(FrntEndOddLotQty),validElement(NewDnmtnQty),validElement(NewBrdLotQty),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MaxQtyToInst))|

---

## Value ISO20022.Seev031002.SecurityDate24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastTradgDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastTradgDt),validElement(PrpssDt),validElement(EarlstPmtDt),validElement(DvddRnkgDt),validElement(AvlblDt),validElement(PmtDt))|

---

## Value ISO20022.Seev031002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev031002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev031002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev031002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev031002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev031002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev031002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev031002.SolicitationFeeRateFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtToQty|ISO20022.Seev031002.AmountAndQuantityRatio5||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(AmtToQty),validChoice(NotSpcfdRate,Amt,AmtToQty,Rate))|

---

## Value ISO20022.Seev031002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev031002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev031002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031002.TaxableIncomePerShareCalculatedFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031002.TemporaryFinancialInstrumentIndicator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031002.GenericIdentification47||XmlElement()||
|+|TempInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,TempInd))|

---

## Value ISO20022.Seev031002.TotalEligibleBalanceFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev031002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev031002.Quantity80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(Bal))|

---

## Value ISO20022.Seev031002.UpdatedAdditionalInformation24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031002.UpdatedAdditionalInformation25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AddtlInf""",AddtlInf),validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031002.UpdatedAdditionalInformation26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AddtlInf""",AddtlInf),validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z!"%&\*;<> \.,\(\)\n\r/='\+:\?@#\{\-_]{1,8000}"""),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031002.UpdatedURLlnformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""URLAdr""",URLAdr,"""[0-9a-zA-Z!"%&\*;<> \.,\(\)\n\r/='\+:\?@#\{\-_]{1,2048}"""),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Enum ISO20022.Seev031002.WithholdingTaxRateType1Code


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

