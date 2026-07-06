# seev.031.001.15
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev031001.AccountAndBalance60 {
        + Bal  : ISO20022.Seev031001.CorporateActionBalanceDetails43
        + SfkpgPlc  : ISO20022.Seev031001.SafekeepingPlaceFormat42Choice
        + AcctOwnr  : ISO20022.Seev031001.PartyIdentification127Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev031001.AccountAndBalance60 *-- ISO20022.Seev031001.CorporateActionBalanceDetails43
    ISO20022.Seev031001.AccountAndBalance60 *-- ISO20022.Seev031001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev031001.AccountAndBalance60 *-- ISO20022.Seev031001.PartyIdentification127Choice
    class ISO20022.Seev031001.AccountIdentification10 {
        + IdCd  : String
    }
    class ISO20022.Seev031001.AccountIdentification71Choice {
        + AcctsListAndBalDtls  : global::System.Collections.Generic.List~ISO20022.Seev031001.AccountAndBalance60~
        + ForAllAccts  : ISO20022.Seev031001.AccountIdentification10
    }
    ISO20022.Seev031001.AccountIdentification71Choice *-- ISO20022.Seev031001.AccountAndBalance60
    ISO20022.Seev031001.AccountIdentification71Choice *-- ISO20022.Seev031001.AccountIdentification10
    class ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev031001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev031001.AdditionalBusinessProcess9Code {
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
    class ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev031001.AmountAndQuantityRatio4 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.AmountAndQuantityRatio4 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountAndRateStatus1 {
        + RateSts  : String
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.AmountAndRateStatus1 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPrice2 {
        + PricVal  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031001.AmountPrice2 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPrice3 {
        + PricVal  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031001.AmountPrice3 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPrice6 {
        + PricVal  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031001.AmountPrice6 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPricePerAmount2 {
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031001.AmountPricePerAmount2 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.AmountPricePerAmount2 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10 {
        + FinInstrmQty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + PricVal  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev031001.AmountPriceType2Code {
        ACTU = 1
    }
    class ISO20022.Seev031001.AmountPriceType3Code {
        PLOT = 1
        ACTU = 2
    }
    class ISO20022.Seev031001.AmountToAmountRatio2 {
        + Amt2  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + Amt1  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.AmountToAmountRatio2 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.AmountToAmountRatio2 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.BalanceFormat11Choice {
        + NotElgblBal  : ISO20022.Seev031001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev031001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev031001.SignedQuantityFormat11
    }
    ISO20022.Seev031001.BalanceFormat11Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat11Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat11Choice *-- ISO20022.Seev031001.SignedQuantityFormat11
    class ISO20022.Seev031001.BalanceFormat12Choice {
        + PartWayPrdUnits  : ISO20022.Seev031001.SignedQuantityFormat10
        + FullPrdUnits  : ISO20022.Seev031001.SignedQuantityFormat10
        + NotElgblBal  : ISO20022.Seev031001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev031001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev031001.SignedQuantityFormat11
    }
    ISO20022.Seev031001.BalanceFormat12Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat12Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat12Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat12Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.BalanceFormat12Choice *-- ISO20022.Seev031001.SignedQuantityFormat11
    class ISO20022.Seev031001.BeneficiaryCertificationType13Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.BeneficiaryCertificationType13Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.BeneficiaryCertificationType6Code {
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
    class ISO20022.Seev031001.BidRangeType1Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.BidRangeType1Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.BidRangeType1Code {
        MULT = 1
        INCR = 2
        DIVI = 3
    }
    class ISO20022.Seev031001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Seev031001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Seev031001.BlockChainAddressWallet3 *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.BorrowerLendingDeadline5 {
        + Brrwr  : ISO20022.Seev031001.PartyIdentification127Choice
        + StockLndgDdln  : ISO20022.Seev031001.DateFormat43Choice
    }
    ISO20022.Seev031001.BorrowerLendingDeadline5 *-- ISO20022.Seev031001.PartyIdentification127Choice
    ISO20022.Seev031001.BorrowerLendingDeadline5 *-- ISO20022.Seev031001.DateFormat43Choice
    class ISO20022.Seev031001.CapitalGainFormat3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CapitalGainFormat3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev031001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Seev031001.CashAccountIdentification9Choice *-- ISO20022.Seev031001.BlockChainAddressWallet3
    class ISO20022.Seev031001.CashOption107 {
        + PricDtls  : ISO20022.Seev031001.PriceDetails40
        + RateAndAmtDtls  : ISO20022.Seev031001.Rate43
        + FXDtls  : ISO20022.Seev031001.ForeignExchangeTerms39
        + DtDtls  : ISO20022.Seev031001.CorporateActionDate84
        + AmtDtls  : ISO20022.Seev031001.CorporateActionAmounts71
        + CshAcctId  : ISO20022.Seev031001.CashAccountIdentification9Choice
        + CtryOfIncmSrc  : String
        + PricClctnMtd  : ISO20022.Seev031001.PriceCalculationMethod2Choice
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.GenericIdentification30~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.GenericIdentification30~
        + IncmTp  : ISO20022.Seev031001.GenericIdentification30
        + IssrOfferrTaxbltyInd  : ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice
        + NonElgblPrcdsInd  : ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice
        + CtrctlPmtInd  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.PriceDetails40
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.Rate43
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.ForeignExchangeTerms39
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.CorporateActionDate84
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.CorporateActionAmounts71
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.CashAccountIdentification9Choice
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.PriceCalculationMethod2Choice
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice
    ISO20022.Seev031001.CashOption107 *-- ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice
    class ISO20022.Seev031001.CertificationFormatType1Code {
        PHYS = 1
        ELEC = 2
    }
    class ISO20022.Seev031001.CertificationTypeFormat3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CertificationTypeFormat3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Seev031001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Seev031001.ClassificationType32Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.ConsentType1Code {
        DUPY = 1
        CTRM = 2
    }
    class ISO20022.Seev031001.ConsentTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.ConsentTypeFormat4Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateAction84 {
        + AddtlInf  : ISO20022.Seev031001.CorporateActionNarrative58
        + NewPlcOfIncorprtn  : String
        + DtchAuctnTp  : ISO20022.Seev031001.DutchAuctionTypeFormat1Choice
        + TaxOnNonDstrbtdPrcdsInd  : global::System.Collections.Generic.List~ISO20022.Seev031001.GenericIdentification30~
        + InfTp  : ISO20022.Seev031001.InformationTypeFormat4Choice
        + CnsntTp  : ISO20022.Seev031001.ConsentTypeFormat4Choice
        + CertfctnTp  : ISO20022.Seev031001.CertificationTypeFormat3Choice
        + LtryTp  : ISO20022.Seev031001.LotteryTypeFormat4Choice
        + ElctnTp  : ISO20022.Seev031001.ElectionTypeFormat3Choice
        + TaxblIncmPerShrClctd  : ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice
        + CptlGnInOutInd  : ISO20022.Seev031001.CapitalGainFormat3Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice
        + ChngTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice~
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice~
        + EvtStag  : global::System.Collections.Generic.List~ISO20022.Seev031001.CorporateActionEventStageFormat13Choice~
        + RnncblEntitlmntStsTp  : ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.OfferTypeFormat14Choice~
        + OcrncTp  : ISO20022.Seev031001.DistributionTypeFormat7Choice
        + EvtSeqTp  : ISO20022.Seev031001.EventSequenceTypeFormat1Choice
        + DvddTp  : ISO20022.Seev031001.DividendTypeFormat9Choice
        + ShrhldrRghtsDrctvInd  : String
        + LttrOfGrntedDlvryInd  : String
        + FrftrOfIntrstInd  : String
        + AcrdIntrstInd  : String
        + RstrctnInd  : String
        + ChrgsApldInd  : String
        + CertfctnBrkdwnInd  : String
        + AccptncPrtyLvl  : String
        + CpnNb  : global::System.Collections.Generic.List~ISO20022.Seev031001.IdentificationFormat3Choice~
        + IntrstAcrdNbOfDays  : Decimal
        + SctiesQty  : ISO20022.Seev031001.CorporateActionQuantity11
        + PricDtls  : ISO20022.Seev031001.CorporateActionPrice85
        + RateAndAmtDtls  : ISO20022.Seev031001.CorporateActionRate122
        + PrdDtls  : ISO20022.Seev031001.CorporateActionPeriod16
        + DtDtls  : ISO20022.Seev031001.CorporateActionDate83
    }
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionNarrative58
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.DutchAuctionTypeFormat1Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.InformationTypeFormat4Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.ConsentTypeFormat4Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CertificationTypeFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.LotteryTypeFormat4Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.ElectionTypeFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CapitalGainFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionEventStageFormat13Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.OfferTypeFormat14Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.DistributionTypeFormat7Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.EventSequenceTypeFormat1Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.DividendTypeFormat9Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.IdentificationFormat3Choice
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionQuantity11
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionPrice85
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionRate122
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionPeriod16
    ISO20022.Seev031001.CorporateAction84 *-- ISO20022.Seev031001.CorporateActionDate83
    class ISO20022.Seev031001.CorporateActionAmounts60 {
        + ScndLvlTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev031001.CorporateActionAmounts60 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts60 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    class ISO20022.Seev031001.CorporateActionAmounts71 {
        + BuyUpAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + DmdRyltsAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + DmdIntrstAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + DmdFndAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + DmdDvddAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + FrgnIncmAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + DmdAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TxTax  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TaxOnIncmAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + BckUpWhldgTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + NRATaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + FATCATaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + EqulstnAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + EUTaxRtntnAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + StockXchgTax  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + IncmPrtn  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + RedPrmAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + PrncplOrCrps  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + EntitldAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ChrgsAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ScndLvlTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + ManfctrdDvddPmtAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + GrssAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    ISO20022.Seev031001.CorporateActionAmounts71 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    class ISO20022.Seev031001.CorporateActionBalanceDetails43 {
        + UafctdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + AfctdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + InstdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + UinstdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + OblgtdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + RegdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + InTrnsShipmntBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + TradDtPosBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + StrtPosBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + SttlmPosBal  : global::System.Collections.Generic.List~ISO20022.Seev031001.BalanceFormat12Choice~
        + OutForRegnBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev031001.BalanceFormat12Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev031001.BalanceFormat12Choice~
        + OnLnBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + CollOutBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + CollInBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + BrrwdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + BlckdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + TtlElgblBal  : ISO20022.Seev031001.TotalEligibleBalanceFormat10
    }
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat12Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat12Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat12Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.CorporateActionBalanceDetails43 *-- ISO20022.Seev031001.TotalEligibleBalanceFormat10
    class ISO20022.Seev031001.CorporateActionChangeType1Code {
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
    class ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionDate104 {
        + DcmnttnDdln  : ISO20022.Seev031001.DateFormat43Choice
        + EndOfSctiesBlckgPrd  : ISO20022.Seev031001.DateFormat59Choice
        + BrrwrStockLndgDdln  : global::System.Collections.Generic.List~ISO20022.Seev031001.BorrowerLendingDeadline5~
        + StockLndgDdln  : ISO20022.Seev031001.DateFormat43Choice
        + DpstryCoverXprtnDt  : ISO20022.Seev031001.DateFormat43Choice
        + SbcptCostDbtDt  : ISO20022.Seev031001.DateFormat43Choice
        + XpryDt  : ISO20022.Seev031001.DateFormat43Choice
        + RspnDdln  : ISO20022.Seev031001.DateFormat44Choice
        + MktDdln  : ISO20022.Seev031001.DateFormat43Choice
        + PrtctDdln  : ISO20022.Seev031001.DateFormat43Choice
        + CoverXprtnDdln  : ISO20022.Seev031001.DateFormat43Choice
        + EarlyRspnDdln  : ISO20022.Seev031001.DateFormat43Choice
    }
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat59Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.BorrowerLendingDeadline5
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat44Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate104 *-- ISO20022.Seev031001.DateFormat43Choice
    class ISO20022.Seev031001.CorporateActionDate83 {
        + HrgDt  : ISO20022.Seev031001.DateFormat30Choice
        + FilgDt  : ISO20022.Seev031001.DateFormat30Choice
        + LeadPlntffDdln  : ISO20022.Seev031001.DateFormat43Choice
        + MktClmTrckgEndDt  : ISO20022.Seev031001.DateFormat30Choice
        + EarlyThrdPtyDdln  : ISO20022.Seev031001.DateFormat43Choice
        + ThrdPtyDdln  : ISO20022.Seev031001.DateFormat43Choice
        + PmtDt  : ISO20022.Seev031001.DateFormat30Choice
        + LpsdDt  : ISO20022.Seev031001.DateFormat30Choice
        + ElctnToCtrPtyRspnDdln  : ISO20022.Seev031001.DateFormat43Choice
        + ElctnToCtrPtyMktDdln  : ISO20022.Seev031001.DateFormat43Choice
        + GrntedPrtcptnDt  : ISO20022.Seev031001.DateFormat30Choice
        + SpclExDt  : ISO20022.Seev031001.DateFormat30Choice
        + OffclAnncmntPblctnDt  : ISO20022.Seev031001.DateFormat43Choice
        + ExDvddDt  : ISO20022.Seev031001.DateFormat30Choice
        + WhlyUcondlDt  : ISO20022.Seev031001.DateFormat30Choice
        + UcondlDt  : ISO20022.Seev031001.DateFormat30Choice
        + TradgSspdDt  : ISO20022.Seev031001.DateFormat43Choice
        + DdlnForTaxBrkdwnInstr  : ISO20022.Seev031001.DateFormat43Choice
        + DdlnToSplt  : ISO20022.Seev031001.DateFormat43Choice
        + RsltsPblctnDt  : ISO20022.Seev031001.DateFormat43Choice
        + RegnDdln  : ISO20022.Seev031001.DateFormat43Choice
        + RcrdDt  : ISO20022.Seev031001.DateFormat30Choice
        + PrratnDt  : ISO20022.Seev031001.DateFormat30Choice
        + MrgnFxgDt  : ISO20022.Seev031001.DateFormat30Choice
        + MtgDt  : ISO20022.Seev031001.DateFormat43Choice
        + NewMtrtyDt  : ISO20022.Seev031001.DateFormat30Choice
        + LtryDt  : ISO20022.Seev031001.DateFormat30Choice
        + FxgDt  : ISO20022.Seev031001.DateFormat43Choice
        + FrthrDtldAnncmntDt  : ISO20022.Seev031001.DateFormat43Choice
        + EqulstnDt  : ISO20022.Seev031001.DateFormat30Choice
        + FctvDt  : ISO20022.Seev031001.DateFormat30Choice
        + EarlyClsgDt  : ISO20022.Seev031001.DateFormat43Choice
        + CrtApprvlDt  : ISO20022.Seev031001.DateFormat30Choice
        + CertfctnDdln  : ISO20022.Seev031001.DateFormat43Choice
        + AnncmntDt  : ISO20022.Seev031001.DateFormat43Choice
    }
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate83 *-- ISO20022.Seev031001.DateFormat43Choice
    class ISO20022.Seev031001.CorporateActionDate84 {
        + EarlstPmtDt  : ISO20022.Seev031001.DateFormat30Choice
        + FXRateFxgDt  : ISO20022.Seev031001.DateFormat43Choice
        + ValDt  : ISO20022.Seev031001.DateFormat57Choice
        + PmtDt  : ISO20022.Seev031001.DateFormat30Choice
    }
    ISO20022.Seev031001.CorporateActionDate84 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.CorporateActionDate84 *-- ISO20022.Seev031001.DateFormat43Choice
    ISO20022.Seev031001.CorporateActionDate84 *-- ISO20022.Seev031001.DateFormat57Choice
    ISO20022.Seev031001.CorporateActionDate84 *-- ISO20022.Seev031001.DateFormat30Choice
    class ISO20022.Seev031001.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev031001.CorporateActionEventProcessingType2Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionEventProcessingType2Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionEventReference3 {
        + LkgTp  : ISO20022.Seev031001.ProcessingPosition7Choice
        + EvtId  : ISO20022.Seev031001.CorporateActionEventReference3Choice
    }
    ISO20022.Seev031001.CorporateActionEventReference3 *-- ISO20022.Seev031001.ProcessingPosition7Choice
    ISO20022.Seev031001.CorporateActionEventReference3 *-- ISO20022.Seev031001.CorporateActionEventReference3Choice
    class ISO20022.Seev031001.CorporateActionEventReference3Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev031001.CorporateActionEventStage3Code {
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
    class ISO20022.Seev031001.CorporateActionEventStageFormat13Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionEventStageFormat13Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionEventStatus1 {
        + EvtConfSts  : String
        + EvtCmpltnsSts  : String
    }
    class ISO20022.Seev031001.CorporateActionEventType107Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionEventType107Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionEventType35Code {
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
    class ISO20022.Seev031001.CorporateActionFrequencyType5Code {
        SPRE = 1
        SPEC = 2
        REGR = 3
        REIN = 4
        INTE = 5
        FINL = 6
    }
    class ISO20022.Seev031001.CorporateActionGeneralInformation176 {
        + UndrlygScty  : ISO20022.Seev031001.FinancialInstrumentAttributes128
        + MndtryVlntryEvtTp  : ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice
        + EvtTp  : ISO20022.Seev031001.CorporateActionEventType107Choice
        + EvtPrcgTp  : ISO20022.Seev031001.CorporateActionEventProcessingType2Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev031001.CorporateActionGeneralInformation176 *-- ISO20022.Seev031001.FinancialInstrumentAttributes128
    ISO20022.Seev031001.CorporateActionGeneralInformation176 *-- ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice
    ISO20022.Seev031001.CorporateActionGeneralInformation176 *-- ISO20022.Seev031001.CorporateActionEventType107Choice
    ISO20022.Seev031001.CorporateActionGeneralInformation176 *-- ISO20022.Seev031001.CorporateActionEventProcessingType2Choice
    class ISO20022.Seev031001.CorporateActionInformationType1Code {
        CONF = 1
    }
    class ISO20022.Seev031001.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionNarrative58 {
        + EvtPrcgWebSiteAdr  : String
        + URLAdr  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedURLlnformation6~
        + NewCpnyNm  : String
        + Offerr  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Seev031001.CorporateActionNarrative58 *-- ISO20022.Seev031001.UpdatedURLlnformation6
    class ISO20022.Seev031001.CorporateActionNarrative59 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + Dsclmr  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + TaxtnConds  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + SctyRstrctn  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + InfToCmplyWth  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + InfConds  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation21~
        + NrrtvVrsn  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation19~
        + AddtlTxt  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation19~
    }
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation21
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation19
    ISO20022.Seev031001.CorporateActionNarrative59 *-- ISO20022.Seev031001.UpdatedAdditionalInformation19
    class ISO20022.Seev031001.CorporateActionNarrative60 {
        + PrcgTxtForNxtIntrmy  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + URLAdr  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedURLlnformation6~
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + BsktOrIndxInf  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + RegnDtls  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + Dsclmr  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + TaxtnConds  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + InfToCmplyWth  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + InfConds  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + NrrtvVrsn  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
        + AddtlTxt  : global::System.Collections.Generic.List~ISO20022.Seev031001.UpdatedAdditionalInformation20~
    }
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedURLlnformation6
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    ISO20022.Seev031001.CorporateActionNarrative60 *-- ISO20022.Seev031001.UpdatedAdditionalInformation20
    class ISO20022.Seev031001.CorporateActionNotification9 {
        + PrcgSts  : ISO20022.Seev031001.CorporateActionProcessingStatus5Choice
        + NtfctnTp  : String
        + NtfctnId  : String
    }
    ISO20022.Seev031001.CorporateActionNotification9 *-- ISO20022.Seev031001.CorporateActionProcessingStatus5Choice
    class ISO20022.Seev031001.CorporateActionNotificationType1Code {
        RMDR = 1
        REPL = 2
        NEWM = 3
    }
    class ISO20022.Seev031001.CorporateActionNotificationV15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev031001.SupplementaryData1~
        + TrfAgt  : ISO20022.Seev031001.PartyIdentification129Choice
        + Offerr  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification129Choice~
        + Issr  : ISO20022.Seev031001.PartyIdentification129Choice
        + InfAgt  : ISO20022.Seev031001.PartyIdentification120Choice
        + SlctnAgt  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification120Choice~
        + DrpAgt  : ISO20022.Seev031001.PartyIdentification120Choice
        + PhysSctiesAgt  : ISO20022.Seev031001.PartyIdentification120Choice
        + RsellngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification120Choice~
        + Regar  : ISO20022.Seev031001.PartyIdentification120Choice
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification120Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification120Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev031001.PartyIdentification129Choice~
        + AddtlInf  : ISO20022.Seev031001.CorporateActionNarrative60
        + CorpActnOptnDtls  : global::System.Collections.Generic.List~ISO20022.Seev031001.CorporateActionOption236~
        + CorpActnDtls  : ISO20022.Seev031001.CorporateAction84
        + IntrmdtScty  : ISO20022.Seev031001.FinancialInstrumentAttributes110
        + AcctDtls  : ISO20022.Seev031001.AccountIdentification71Choice
        + CorpActnGnlInf  : ISO20022.Seev031001.CorporateActionGeneralInformation176
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev031001.CorporateActionEventReference3~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev031001.DocumentIdentification32~
        + InstrId  : ISO20022.Seev031001.DocumentIdentification9
        + PrvsNtfctnId  : ISO20022.Seev031001.DocumentIdentification31
        + NtfctnGnlInf  : ISO20022.Seev031001.CorporateActionNotification9
        + Pgntn  : ISO20022.Seev031001.Pagination1
    }
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.SupplementaryData1
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification129Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification129Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification129Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification120Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.PartyIdentification129Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateActionNarrative60
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateActionOption236
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateAction84
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.FinancialInstrumentAttributes110
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.AccountIdentification71Choice
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateActionGeneralInformation176
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateActionEventReference3
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.DocumentIdentification32
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.DocumentIdentification9
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.DocumentIdentification31
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.CorporateActionNotification9
    ISO20022.Seev031001.CorporateActionNotificationV15 *-- ISO20022.Seev031001.Pagination1
    class ISO20022.Seev031001.CorporateActionOption15Code {
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
    class ISO20022.Seev031001.CorporateActionOption236 {
        + AddtlInf  : ISO20022.Seev031001.CorporateActionNarrative59
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev031001.CashOption107~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev031001.SecuritiesOption113~
        + SctiesQty  : ISO20022.Seev031001.SecuritiesOption81
        + PricDtls  : ISO20022.Seev031001.CorporateActionPrice90
        + RateAndAmtDtls  : ISO20022.Seev031001.CorporateActionRate126
        + PrdDtls  : ISO20022.Seev031001.CorporateActionPeriod12
        + DtDtls  : ISO20022.Seev031001.CorporateActionDate104
        + FinInstrmId  : ISO20022.Seev031001.SecurityIdentification19
        + ApldOptnInd  : String
        + ChngAllwdInd  : String
        + WdrwlAllwdInd  : String
        + CertfctnBrkdwnInd  : String
        + ChrgsApldInd  : String
        + DfltPrcgOrStgInstr  : ISO20022.Seev031001.DefaultProcessingOrStandingInstruction2Choice
        + CcyOptn  : String
        + VldDmclCtry  : global::System.Collections.Generic.List~String~
        + NonDmclCtry  : global::System.Collections.Generic.List~String~
        + PrratnBlwMinQty  : ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice
        + BidRgTp  : ISO20022.Seev031001.BidRangeType1Choice
        + CertfctnBrkdwnTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.BeneficiaryCertificationType13Choice~
        + AccptncPrtyLvl  : String
        + OptnAvlbtySts  : ISO20022.Seev031001.OptionAvailabilityStatus3Choice
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev031001.OptionFeaturesFormat28Choice~
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.OfferTypeFormat14Choice~
        + FrctnDspstn  : ISO20022.Seev031001.FractionDispositionType26Choice
        + OptnTp  : ISO20022.Seev031001.CorporateActionOption37Choice
        + OptnNb  : String
    }
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionNarrative59
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CashOption107
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.SecuritiesOption113
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.SecuritiesOption81
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionPrice90
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionRate126
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionPeriod12
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionDate104
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.SecurityIdentification19
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.DefaultProcessingOrStandingInstruction2Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.BidRangeType1Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.BeneficiaryCertificationType13Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.OptionAvailabilityStatus3Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.OptionFeaturesFormat28Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.OfferTypeFormat14Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.FractionDispositionType26Choice
    ISO20022.Seev031001.CorporateActionOption236 *-- ISO20022.Seev031001.CorporateActionOption37Choice
    class ISO20022.Seev031001.CorporateActionOption37Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.CorporateActionOption37Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.CorporateActionPeriod12 {
        + DpstrySspnsnPrdForWdrwl  : ISO20022.Seev031001.Period6Choice
        + AcctSvcrRvcbltyPrd  : ISO20022.Seev031001.Period6Choice
        + PrvlgSspnsnPrd  : ISO20022.Seev031001.Period6Choice
        + RvcbltyPrd  : ISO20022.Seev031001.Period6Choice
        + ActnPrd  : ISO20022.Seev031001.Period6Choice
        + ParllTradgPrd  : ISO20022.Seev031001.Period6Choice
        + PricClctnPrd  : ISO20022.Seev031001.Period6Choice
    }
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod12 *-- ISO20022.Seev031001.Period6Choice
    class ISO20022.Seev031001.CorporateActionPeriod16 {
        + FsclYrPrd  : ISO20022.Seev031001.Period6Choice
        + SpltPrd  : ISO20022.Seev031001.Period6Choice
        + CoDpstriesSspnsnPrd  : ISO20022.Seev031001.Period6Choice
        + BookClsrPrd  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForWdrwlInStrtNm  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForWdrwlInNmneeNm  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForWdrwlAtAgt  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForSgrtn  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForPldg  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForDpst  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForDpstAtAgt  : ISO20022.Seev031001.Period6Choice
        + DpstrySspnsnPrdForBookNtryTrf  : ISO20022.Seev031001.Period6Choice
        + ClmPrd  : ISO20022.Seev031001.Period6Choice
        + CmplsryPurchsPrd  : ISO20022.Seev031001.Period6Choice
        + IntrstPrd  : ISO20022.Seev031001.Period6Choice
        + PricClctnPrd  : ISO20022.Seev031001.Period6Choice
    }
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.CorporateActionPeriod16 *-- ISO20022.Seev031001.Period6Choice
    class ISO20022.Seev031001.CorporateActionPrice85 {
        + LastBidIncrmtPric  : ISO20022.Seev031001.PriceFormat73Choice
        + FrstBidIncrmtPric  : ISO20022.Seev031001.PriceFormat73Choice
        + MinPric  : ISO20022.Seev031001.PriceFormat73Choice
        + MaxPric  : ISO20022.Seev031001.PriceFormat73Choice
    }
    ISO20022.Seev031001.CorporateActionPrice85 *-- ISO20022.Seev031001.PriceFormat73Choice
    ISO20022.Seev031001.CorporateActionPrice85 *-- ISO20022.Seev031001.PriceFormat73Choice
    ISO20022.Seev031001.CorporateActionPrice85 *-- ISO20022.Seev031001.PriceFormat73Choice
    ISO20022.Seev031001.CorporateActionPrice85 *-- ISO20022.Seev031001.PriceFormat73Choice
    class ISO20022.Seev031001.CorporateActionPrice89 {
        + GncCshPricRcvdPerPdct  : ISO20022.Seev031001.PriceFormat79Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev031001.PriceFormat80Choice
        + CshValForTax  : ISO20022.Seev031001.PriceFormat46Choice
        + CshInLieuOfShrPric  : ISO20022.Seev031001.PriceFormat81Choice
        + IndctvOrMktPric  : ISO20022.Seev031001.IndicativeOrMarketPrice14Choice
    }
    ISO20022.Seev031001.CorporateActionPrice89 *-- ISO20022.Seev031001.PriceFormat79Choice
    ISO20022.Seev031001.CorporateActionPrice89 *-- ISO20022.Seev031001.PriceFormat80Choice
    ISO20022.Seev031001.CorporateActionPrice89 *-- ISO20022.Seev031001.PriceFormat46Choice
    ISO20022.Seev031001.CorporateActionPrice89 *-- ISO20022.Seev031001.PriceFormat81Choice
    ISO20022.Seev031001.CorporateActionPrice89 *-- ISO20022.Seev031001.IndicativeOrMarketPrice14Choice
    class ISO20022.Seev031001.CorporateActionPrice90 {
        + LastBidIncrmtPric  : ISO20022.Seev031001.PriceFormat80Choice
        + FrstBidIncrmtPric  : ISO20022.Seev031001.PriceFormat80Choice
        + MinPric  : ISO20022.Seev031001.PriceFormat80Choice
        + MaxPric  : ISO20022.Seev031001.PriceFormat80Choice
        + MinMltplCshToInst  : ISO20022.Seev031001.PriceFormat61Choice
        + MinCshToInst  : ISO20022.Seev031001.PriceFormat61Choice
        + MaxCshToInst  : ISO20022.Seev031001.PriceFormat61Choice
        + OverSbcptDpstPric  : ISO20022.Seev031001.PriceFormat81Choice
        + CshInLieuOfShrPric  : ISO20022.Seev031001.PriceFormat81Choice
    }
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat80Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat80Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat80Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat80Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat61Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat61Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat61Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat81Choice
    ISO20022.Seev031001.CorporateActionPrice90 *-- ISO20022.Seev031001.PriceFormat81Choice
    class ISO20022.Seev031001.CorporateActionProcessingStatus5Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : ISO20022.Seev031001.CorporateActionEventStatus1
    }
    ISO20022.Seev031001.CorporateActionProcessingStatus5Choice *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.CorporateActionProcessingStatus5Choice *-- ISO20022.Seev031001.CorporateActionEventStatus1
    class ISO20022.Seev031001.CorporateActionQuantity11 {
        + IncrmtlDnmtn  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + BaseDnmtn  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + NewDnmtnQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + NewBrdLotQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + MinQtySght  : ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
        + MaxQty  : ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    }
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    ISO20022.Seev031001.CorporateActionQuantity11 *-- ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    class ISO20022.Seev031001.CorporateActionRate122 {
        + IndxFctr  : ISO20022.Seev031001.RateAndAmountFormat57Choice
        + DclrdRate  : ISO20022.Seev031001.RateAndAmountFormat59Choice
        + RealsdLoss  : ISO20022.Seev031001.RateAndAmountFormat59Choice
        + IntrstShrtfll  : ISO20022.Seev031001.RateAndAmountFormat59Choice
        + RinvstmtDscntRateToMkt  : ISO20022.Seev031001.RateFormat24Choice
        + NxtFctr  : ISO20022.Seev031001.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031001.RateFormat12Choice
        + BidIntrvl  : ISO20022.Seev031001.RateAndAmountFormat58Choice
        + Sprd  : ISO20022.Seev031001.RateFormat24Choice
        + RltdIndx  : ISO20022.Seev031001.RateFormat24Choice
        + PctgSght  : ISO20022.Seev031001.RateFormat25Choice
        + IntrstRate  : ISO20022.Seev031001.RateAndAmountFormat57Choice
    }
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat59Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat59Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat59Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat58Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateFormat25Choice
    ISO20022.Seev031001.CorporateActionRate122 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    class ISO20022.Seev031001.CorporateActionRate126 {
        + BidIntrvl  : ISO20022.Seev031001.RateAndAmountFormat58Choice
        + TaxOnIncm  : ISO20022.Seev031001.RateAndAmountFormat57Choice
        + IssrDclrdXchgRate  : ISO20022.Seev031001.ForeignExchangeTerms38
        + TaxblIncmPerDvddShr  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateTypeAndAmountAndStatus26~
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat60Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat56Choice~
        + PrratnRate  : ISO20022.Seev031001.RateFormat24Choice
        + MaxAllwdOvrsbcptRate  : ISO20022.Seev031001.RateFormat24Choice
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice~
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.NetDividendRateFormat38Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.GrossDividendRateFormat36Choice~
        + AddtlTax  : ISO20022.Seev031001.RateAndAmountFormat57Choice
    }
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateAndAmountFormat58Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.ForeignExchangeTerms38
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus26
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateAndAmountFormat60Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateAndAmountFormat56Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.NetDividendRateFormat38Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.GrossDividendRateFormat36Choice
    ISO20022.Seev031001.CorporateActionRate126 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    class ISO20022.Seev031001.CorporateActionRate128 {
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat60Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat60Choice~
        + FinTxTaxRate  : ISO20022.Seev031001.RateFormat24Choice
        + TaxCdtRate  : ISO20022.Seev031001.RateFormat26Choice
        + AplblRate  : ISO20022.Seev031001.RateFormat24Choice
        + FsclStmp  : ISO20022.Seev031001.RateFormat24Choice
        + ChrgsFees  : ISO20022.Seev031001.RateAndAmountFormat57Choice
        + TrfrmatnRate  : Decimal
        + NewToOd  : ISO20022.Seev031001.RatioFormat18Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev031001.RatioFormat17Choice
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev031001.RatioFormat17Choice
    }
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateAndAmountFormat60Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateAndAmountFormat60Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateFormat26Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RatioFormat18Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RatioFormat17Choice
    ISO20022.Seev031001.CorporateActionRate128 *-- ISO20022.Seev031001.RatioFormat17Choice
    class ISO20022.Seev031001.CorporateActionTaxableIncomePerShareCalculated1Code {
        UKWN = 1
        TDIN = 2
        TDIY = 3
    }
    class ISO20022.Seev031001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev031001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev031001.DateCode19Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DateCode19Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DateCode20Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DateCode20Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DateCode21Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DateCode21Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DateCode33Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DateCode33Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DateCodeAndTimeFormat3 {
        + Tm  : DateTime
        + DtCd  : ISO20022.Seev031001.DateCode21Choice
    }
    ISO20022.Seev031001.DateCodeAndTimeFormat3 *-- ISO20022.Seev031001.DateCode21Choice
    class ISO20022.Seev031001.DateFormat30Choice {
        + DtCd  : ISO20022.Seev031001.DateCode19Choice
        + Dt  : DateTime
    }
    ISO20022.Seev031001.DateFormat30Choice *-- ISO20022.Seev031001.DateCode19Choice
    class ISO20022.Seev031001.DateFormat43Choice {
        + DtCd  : ISO20022.Seev031001.DateCode19Choice
        + Dt  : ISO20022.Seev031001.DateAndDateTime2Choice
    }
    ISO20022.Seev031001.DateFormat43Choice *-- ISO20022.Seev031001.DateCode19Choice
    ISO20022.Seev031001.DateFormat43Choice *-- ISO20022.Seev031001.DateAndDateTime2Choice
    class ISO20022.Seev031001.DateFormat44Choice {
        + DtCd  : ISO20022.Seev031001.DateCode19Choice
        + DtCdAndTm  : ISO20022.Seev031001.DateCodeAndTimeFormat3
        + Dt  : ISO20022.Seev031001.DateAndDateTime2Choice
    }
    ISO20022.Seev031001.DateFormat44Choice *-- ISO20022.Seev031001.DateCode19Choice
    ISO20022.Seev031001.DateFormat44Choice *-- ISO20022.Seev031001.DateCodeAndTimeFormat3
    ISO20022.Seev031001.DateFormat44Choice *-- ISO20022.Seev031001.DateAndDateTime2Choice
    class ISO20022.Seev031001.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev031001.DateAndDateTime2Choice
    }
    ISO20022.Seev031001.DateFormat45Choice *-- ISO20022.Seev031001.DateAndDateTime2Choice
    class ISO20022.Seev031001.DateFormat57Choice {
        + DtCd  : ISO20022.Seev031001.DateCode20Choice
        + Dt  : DateTime
    }
    ISO20022.Seev031001.DateFormat57Choice *-- ISO20022.Seev031001.DateCode20Choice
    class ISO20022.Seev031001.DateFormat59Choice {
        + DtCd  : ISO20022.Seev031001.DateCode33Choice
        + Dt  : ISO20022.Seev031001.DateAndDateTime2Choice
    }
    ISO20022.Seev031001.DateFormat59Choice *-- ISO20022.Seev031001.DateCode33Choice
    ISO20022.Seev031001.DateFormat59Choice *-- ISO20022.Seev031001.DateAndDateTime2Choice
    class ISO20022.Seev031001.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev031001.DateType7Code {
        ONGO = 1
    }
    class ISO20022.Seev031001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev031001.DateType9Code {
        UKWN = 1
        NARR = 2
        RDDT = 3
        RDTE = 4
        PAYD = 5
        MEET = 6
        MKDT = 7
        PWAL = 8
    }
    class ISO20022.Seev031001.DeemedRateType1Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DeemedRateType1Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DeemedRateType1Code {
        DERY = 1
        DEIT = 2
        DEFP = 3
        DEDI = 4
    }
    class ISO20022.Seev031001.DefaultProcessingOrStandingInstruction2Choice {
        + StgInstrInd  : String
        + DfltOptnInd  : String
    }
    class ISO20022.Seev031001.DistributionType3Code {
        ROLL = 1
        ONGO = 2
        INTE = 3
        FINL = 4
    }
    class ISO20022.Seev031001.DistributionTypeFormat7Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DistributionTypeFormat7Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DividendRateType1Code {
        TXBL = 1
    }
    class ISO20022.Seev031001.DividendTypeFormat9Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DividendTypeFormat9Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.DocumentIdentification31 {
        + LkgTp  : ISO20022.Seev031001.ProcessingPosition7Choice
        + Id  : String
    }
    ISO20022.Seev031001.DocumentIdentification31 *-- ISO20022.Seev031001.ProcessingPosition7Choice
    class ISO20022.Seev031001.DocumentIdentification32 {
        + LkgTp  : ISO20022.Seev031001.ProcessingPosition7Choice
        + DocNb  : ISO20022.Seev031001.DocumentNumber5Choice
        + Id  : ISO20022.Seev031001.DocumentIdentification3Choice
    }
    ISO20022.Seev031001.DocumentIdentification32 *-- ISO20022.Seev031001.ProcessingPosition7Choice
    ISO20022.Seev031001.DocumentIdentification32 *-- ISO20022.Seev031001.DocumentNumber5Choice
    ISO20022.Seev031001.DocumentIdentification32 *-- ISO20022.Seev031001.DocumentIdentification3Choice
    class ISO20022.Seev031001.DocumentIdentification3Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev031001.DocumentIdentification9 {
        + Id  : String
    }
    class ISO20022.Seev031001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Seev031001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev031001.DocumentNumber5Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.DutchAuctionType1Code {
        UNMD = 1
        MDFD = 2
    }
    class ISO20022.Seev031001.DutchAuctionTypeFormat1Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.DutchAuctionTypeFormat1Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Seev031001.ElectionMovementType2Code {
        SEQD = 1
        DRCT = 2
    }
    class ISO20022.Seev031001.ElectionTypeFormat3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.ElectionTypeFormat3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.EventCompletenessStatus1Code {
        INCO = 1
        COMP = 2
    }
    class ISO20022.Seev031001.EventConfirmationStatus1Code {
        UCON = 1
        CONF = 2
    }
    class ISO20022.Seev031001.EventSequenceType1Code {
        INTE = 1
        FINL = 2
    }
    class ISO20022.Seev031001.EventSequenceTypeFormat1Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.EventSequenceTypeFormat1Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.FinancialInstrumentAttributes110 {
        + InstdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + UinstdBal  : ISO20022.Seev031001.BalanceFormat11Choice
        + TradgPrd  : ISO20022.Seev031001.Period11
        + PstngDt  : ISO20022.Seev031001.DateFormat30Choice
        + XpryDt  : ISO20022.Seev031001.DateFormat30Choice
        + MktPric  : ISO20022.Seev031001.AmountPrice2
        + IntrmdtSctiesToUndrlygRatio  : ISO20022.Seev031001.QuantityToQuantityRatio1
        + FrctnDspstn  : ISO20022.Seev031001.FractionDispositionType25Choice
        + RnncblEntitlmntStsTp  : ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice
        + Qty  : Decimal
        + SctyId  : ISO20022.Seev031001.SecurityIdentification19
    }
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.BalanceFormat11Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.Period11
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.AmountPrice2
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.QuantityToQuantityRatio1
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.FractionDispositionType25Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes110 *-- ISO20022.Seev031001.SecurityIdentification19
    class ISO20022.Seev031001.FinancialInstrumentAttributes128 {
        + CtrctSz  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + WarrtParity  : ISO20022.Seev031001.QuantityToQuantityRatio1
        + NxtFctr  : ISO20022.Seev031001.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031001.RateFormat12Choice
        + PctgOfDebtClm  : ISO20022.Seev031001.RateFormat24Choice
        + NxtIntrstRate  : ISO20022.Seev031001.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev031001.RateFormat24Choice
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
        + OptnStyle  : ISO20022.Seev031001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Seev031001.ClassificationType32Choice
        + DayCntBsis  : ISO20022.Seev031001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Seev031001.MarketIdentification3Choice
        + FinInstrmId  : ISO20022.Seev031001.SecurityIdentification19
    }
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.QuantityToQuantityRatio1
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.OptionStyle8Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.ClassificationType32Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.InterestComputationMethodFormat4Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.MarketIdentification3Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes128 *-- ISO20022.Seev031001.SecurityIdentification19
    class ISO20022.Seev031001.FinancialInstrumentAttributes131 {
        + IssePric  : ISO20022.Seev031001.PriceFormat81Choice
        + CtrctSz  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + MinMltplQtyToInst  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + MinQtyToInst  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + NxtIntrstRate  : ISO20022.Seev031001.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev031001.RateFormat24Choice
        + NxtFctr  : ISO20022.Seev031001.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev031001.RateFormat12Choice
        + ConvsDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + NxtCpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnStyle  : ISO20022.Seev031001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Seev031001.ClassificationType32Choice
        + DayCntBsis  : ISO20022.Seev031001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Seev031001.MarketIdentification3Choice
        + FinInstrmId  : ISO20022.Seev031001.SecurityIdentification19
    }
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.PriceFormat81Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.RateFormat12Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.OptionStyle8Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.ClassificationType32Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.InterestComputationMethodFormat4Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.MarketIdentification3Choice
    ISO20022.Seev031001.FinancialInstrumentAttributes131 *-- ISO20022.Seev031001.SecurityIdentification19
    class ISO20022.Seev031001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031001.FinancialInstrumentQuantity34Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031001.FinancialInstrumentQuantity35Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev031001.ForeignExchangeTerms38 {
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    class ISO20022.Seev031001.ForeignExchangeTerms39 {
        + RsltgAmt  : ISO20022.Seev031001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev031001.ForeignExchangeTerms39 *-- ISO20022.Seev031001.ActiveCurrencyAndAmount
    class ISO20022.Seev031001.FractionDispositionType25Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.FractionDispositionType25Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.FractionDispositionType26Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.FractionDispositionType26Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.FractionDispositionType8Code {
        UKWN = 1
        RDUP = 2
        STAN = 3
        RDDN = 4
        DIST = 5
        CINL = 6
        BUYU = 7
    }
    class ISO20022.Seev031001.FractionDispositionType9Code {
        UKWN = 1
        RDUP = 2
        STAN = 3
        RDDN = 4
        DIST = 5
    }
    class ISO20022.Seev031001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev031001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev031001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev031001.GenericIdentification30
    }
    ISO20022.Seev031001.GenericIdentification78 *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.GrossDividendRateFormat36Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus55
        + AmtAndRateSts  : ISO20022.Seev031001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.GrossDividendRateFormat36Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus55
    ISO20022.Seev031001.GrossDividendRateFormat36Choice *-- ISO20022.Seev031001.AmountAndRateStatus1
    ISO20022.Seev031001.GrossDividendRateFormat36Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.GrossDividendRateFormat38Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus57
        + AmtAndRateSts  : ISO20022.Seev031001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.GrossDividendRateFormat38Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus57
    ISO20022.Seev031001.GrossDividendRateFormat38Choice *-- ISO20022.Seev031001.AmountAndRateStatus1
    ISO20022.Seev031001.GrossDividendRateFormat38Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.GrossDividendRateType6Code {
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
    class ISO20022.Seev031001.GrossDividendRateType7Code {
        UNFR = 1
        TXFR = 2
        TXDF = 3
        TXBL = 4
        SOIC = 5
        STCG = 6
        REES = 7
        PAPU = 8
        LTCG = 9
        INTR = 10
        INCO = 11
        FLFR = 12
        FUPU = 13
        CDFI = 14
        CAPO = 15
    }
    class ISO20022.Seev031001.IdentificationFormat3Choice {
        + PrtryId  : ISO20022.Seev031001.GenericIdentification36
        + LngId  : String
        + ShrtId  : String
    }
    ISO20022.Seev031001.IdentificationFormat3Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev031001.IndicativeOrMarketPrice14Choice {
        + MktPric  : ISO20022.Seev031001.PriceFormat81Choice
        + IndctvPric  : ISO20022.Seev031001.PriceFormat81Choice
    }
    ISO20022.Seev031001.IndicativeOrMarketPrice14Choice *-- ISO20022.Seev031001.PriceFormat81Choice
    ISO20022.Seev031001.IndicativeOrMarketPrice14Choice *-- ISO20022.Seev031001.PriceFormat81Choice
    class ISO20022.Seev031001.InformationTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.InformationTypeFormat4Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.InterestComputationMethod2Code {
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
    class ISO20022.Seev031001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.InterestComputationMethodFormat4Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus24
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus24
    ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.IntermediateSecurityDistributionType5Code {
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
    class ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.IssuerTaxability2Code {
        TXBL = 1
    }
    class ISO20022.Seev031001.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev031001.LotteryTypeFormat4Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.LotteryTypeFormat4Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev031001.NameAndAddress5 {
        + Adr  : ISO20022.Seev031001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev031001.NameAndAddress5 *-- ISO20022.Seev031001.PostalAddress1
    class ISO20022.Seev031001.NetDividendRateFormat38Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus56
        + AmtAndRateSts  : ISO20022.Seev031001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.NetDividendRateFormat38Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus56
    ISO20022.Seev031001.NetDividendRateFormat38Choice *-- ISO20022.Seev031001.AmountAndRateStatus1
    ISO20022.Seev031001.NetDividendRateFormat38Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.NetDividendRateFormat39Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus58
        + AmtAndRateSts  : ISO20022.Seev031001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.NetDividendRateFormat39Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus58
    ISO20022.Seev031001.NetDividendRateFormat39Choice *-- ISO20022.Seev031001.AmountAndRateStatus1
    ISO20022.Seev031001.NetDividendRateFormat39Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.NetDividendRateType6Code {
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
    class ISO20022.Seev031001.NetDividendRateType7Code {
        REES = 1
        PAPU = 2
        UNFR = 3
        TXFR = 4
        TXDF = 5
        TXBL = 6
        SOIC = 7
        INTR = 8
        INCO = 9
        FLFR = 10
        FUPU = 11
        CDFI = 12
        CAPO = 13
    }
    class ISO20022.Seev031001.NewSecuritiesIssuanceType5Code {
        REFU = 1
        NREF = 2
        UKWN = 3
        NDEF = 4
        NEIS = 5
        EXIS = 6
        DEFE = 7
    }
    class ISO20022.Seev031001.NonEligibleProceedsIndicator2Code {
        NELS = 1
        ONEL = 2
        ACLI = 3
        NELC = 4
    }
    class ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.OfferType5Code {
        ACPR = 1
        SQUE = 2
        ERUN = 3
        PART = 4
        FCFS = 5
        FINL = 6
        NDIS = 7
        DISS = 8
    }
    class ISO20022.Seev031001.OfferTypeFormat14Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.OfferTypeFormat14Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.OptionAvailabilityStatus1Code {
        CANC = 1
        INTV = 2
    }
    class ISO20022.Seev031001.OptionAvailabilityStatus3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.OptionAvailabilityStatus3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.OptionFeatures13Code {
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
    class ISO20022.Seev031001.OptionFeaturesFormat28Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.OptionFeaturesFormat28Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Seev031001.OptionStyle8Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.OptionStyle8Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev031001.OriginalAndCurrentQuantities6 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev031001.OtherIdentification1 {
        + Tp  : ISO20022.Seev031001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev031001.OtherIdentification1 *-- ISO20022.Seev031001.IdentificationSource3Choice
    class ISO20022.Seev031001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev031001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Seev031001.NameAndAddress5
        + PrtryId  : ISO20022.Seev031001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev031001.PartyIdentification120Choice *-- ISO20022.Seev031001.NameAndAddress5
    ISO20022.Seev031001.PartyIdentification120Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Seev031001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev031001.PartyIdentification127Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.PartyIdentification129Choice {
        + LEI  : String
        + NmAndAdr  : ISO20022.Seev031001.NameAndAddress5
        + PrtryId  : ISO20022.Seev031001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev031001.PartyIdentification129Choice *-- ISO20022.Seev031001.NameAndAddress5
    ISO20022.Seev031001.PartyIdentification129Choice *-- ISO20022.Seev031001.GenericIdentification36
    class ISO20022.Seev031001.Payment2Code {
        ACTU = 1
    }
    class ISO20022.Seev031001.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev031001.PercentagePrice3 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev031001.Period11 {
        + EndDt  : ISO20022.Seev031001.DateFormat45Choice
        + StartDt  : ISO20022.Seev031001.DateFormat45Choice
    }
    ISO20022.Seev031001.Period11 *-- ISO20022.Seev031001.DateFormat45Choice
    ISO20022.Seev031001.Period11 *-- ISO20022.Seev031001.DateFormat45Choice
    class ISO20022.Seev031001.Period6Choice {
        + PrdCd  : String
        + Prd  : ISO20022.Seev031001.Period11
    }
    ISO20022.Seev031001.Period6Choice *-- ISO20022.Seev031001.Period11
    class ISO20022.Seev031001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev031001.PriceCalculationMethod1Code {
        AVCL = 1
        NAVA = 2
        MIMP = 3
        NAVF = 4
        VWAP = 5
    }
    class ISO20022.Seev031001.PriceCalculationMethod2Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.PriceCalculationMethod2Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.PriceDetails40 {
        + CshInLieuOfShrPric  : ISO20022.Seev031001.PriceFormat81Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev031001.PriceFormat79Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev031001.PriceFormat80Choice
    }
    ISO20022.Seev031001.PriceDetails40 *-- ISO20022.Seev031001.PriceFormat81Choice
    ISO20022.Seev031001.PriceDetails40 *-- ISO20022.Seev031001.PriceFormat79Choice
    ISO20022.Seev031001.PriceDetails40 *-- ISO20022.Seev031001.PriceFormat80Choice
    class ISO20022.Seev031001.PriceFormat46Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice2
    }
    ISO20022.Seev031001.PriceFormat46Choice *-- ISO20022.Seev031001.AmountPrice2
    class ISO20022.Seev031001.PriceFormat61Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice6
    }
    ISO20022.Seev031001.PriceFormat61Choice *-- ISO20022.Seev031001.AmountPrice6
    class ISO20022.Seev031001.PriceFormat73Choice {
        + IndxPts  : Decimal
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice3
        + PctgPric  : ISO20022.Seev031001.PercentagePrice2
    }
    ISO20022.Seev031001.PriceFormat73Choice *-- ISO20022.Seev031001.AmountPrice3
    ISO20022.Seev031001.PriceFormat73Choice *-- ISO20022.Seev031001.PercentagePrice2
    class ISO20022.Seev031001.PriceFormat79Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev031001.AmountPricePerAmount2
        + AmtPricPerFinInstrmQty  : ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice3
        + PctgPric  : ISO20022.Seev031001.PercentagePrice3
    }
    ISO20022.Seev031001.PriceFormat79Choice *-- ISO20022.Seev031001.AmountPricePerAmount2
    ISO20022.Seev031001.PriceFormat79Choice *-- ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10
    ISO20022.Seev031001.PriceFormat79Choice *-- ISO20022.Seev031001.AmountPrice3
    ISO20022.Seev031001.PriceFormat79Choice *-- ISO20022.Seev031001.PercentagePrice3
    class ISO20022.Seev031001.PriceFormat80Choice {
        + IndxPts  : Decimal
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice3
        + PctgPric  : ISO20022.Seev031001.PercentagePrice3
    }
    ISO20022.Seev031001.PriceFormat80Choice *-- ISO20022.Seev031001.AmountPrice3
    ISO20022.Seev031001.PriceFormat80Choice *-- ISO20022.Seev031001.PercentagePrice3
    class ISO20022.Seev031001.PriceFormat81Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev031001.AmountPrice3
        + PctgPric  : ISO20022.Seev031001.PercentagePrice3
    }
    ISO20022.Seev031001.PriceFormat81Choice *-- ISO20022.Seev031001.AmountPrice3
    ISO20022.Seev031001.PriceFormat81Choice *-- ISO20022.Seev031001.PercentagePrice3
    class ISO20022.Seev031001.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev031001.PriceValueType10Code {
        UKWN = 1
    }
    class ISO20022.Seev031001.PriceValueType8Code {
        NILP = 1
        UKWN = 2
        UNSP = 3
        TBSP = 4
    }
    class ISO20022.Seev031001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev031001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.ProcessingPosition7Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.ProprietaryQuantity7 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev031001.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev031001.ProrationBelowMinimumQuantity1Code {
        UKWN = 1
        REJT = 2
        MILT = 3
        MIEX = 4
        FULL = 5
    }
    class ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev031001.ProprietaryQuantity8
        + Qty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev031001.Quantity48Choice *-- ISO20022.Seev031001.ProprietaryQuantity8
    ISO20022.Seev031001.Quantity48Choice *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev031001.Quantity49Choice {
        + PrtryQty  : ISO20022.Seev031001.ProprietaryQuantity7
        + QtyChc  : ISO20022.Seev031001.Quantity50Choice
    }
    ISO20022.Seev031001.Quantity49Choice *-- ISO20022.Seev031001.ProprietaryQuantity7
    ISO20022.Seev031001.Quantity49Choice *-- ISO20022.Seev031001.Quantity50Choice
    class ISO20022.Seev031001.Quantity4Code {
        ANYA = 1
        UKWN = 2
    }
    class ISO20022.Seev031001.Quantity50Choice {
        + SgndQty  : ISO20022.Seev031001.SignedQuantityFormat10
        + OrgnlAndCurFaceAmt  : ISO20022.Seev031001.OriginalAndCurrentQuantities6
    }
    ISO20022.Seev031001.Quantity50Choice *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.Quantity50Choice *-- ISO20022.Seev031001.OriginalAndCurrentQuantities6
    class ISO20022.Seev031001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Seev031001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev031001.Quantity51Choice *-- ISO20022.Seev031001.OriginalAndCurrentQuantities1
    ISO20022.Seev031001.Quantity51Choice *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev031001.Quantity5Code {
        UKWN = 1
    }
    class ISO20022.Seev031001.QuantityToQuantityRatio1 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev031001.Rate43 {
        + DmdRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat61Choice~
        + EqulstnRate  : ISO20022.Seev031001.RateAndAmountFormat42Choice
        + TaxRclmRate  : ISO20022.Seev031001.RateFormat24Choice
        + TaxOnPrfts  : ISO20022.Seev031001.RateFormat24Choice
        + TaxOnIncm  : ISO20022.Seev031001.RateAndAmountFormat57Choice
        + TaxCdtRate  : ISO20022.Seev031001.RateFormat26Choice
        + SlctnFeeRate  : ISO20022.Seev031001.SolicitationFeeRateFormat11Choice
        + AplblRate  : ISO20022.Seev031001.RateFormat24Choice
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.NetDividendRateFormat39Choice~
        + ThrdPtyIncntivRate  : ISO20022.Seev031001.RateFormat26Choice
        + FsclStmp  : ISO20022.Seev031001.RateFormat24Choice
        + EarlySlctnFeeRate  : ISO20022.Seev031001.SolicitationFeeRateFormat11Choice
        + ChrgsFees  : ISO20022.Seev031001.RateAndAmountFormat57Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat60Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.RateAndAmountFormat60Choice~
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev031001.GrossDividendRateFormat38Choice~
        + AddtlTax  : ISO20022.Seev031001.RateAndAmountFormat57Choice
    }
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat61Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat42Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat26Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.SolicitationFeeRateFormat11Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.NetDividendRateFormat39Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat26Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateFormat24Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.SolicitationFeeRateFormat11Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat60Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat60Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.GrossDividendRateFormat38Choice
    ISO20022.Seev031001.Rate43 *-- ISO20022.Seev031001.RateAndAmountFormat57Choice
    class ISO20022.Seev031001.RateAndAmountFormat42Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev031001.RateAndAmountFormat42Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat56Choice {
        + RateTpAndRate  : ISO20022.Seev031001.RateTypeAndPercentageRate12
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat56Choice *-- ISO20022.Seev031001.RateTypeAndPercentageRate12
    ISO20022.Seev031001.RateAndAmountFormat56Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat57Choice {
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat57Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat58Choice {
        + IndxPts  : Decimal
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat58Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat59Choice {
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat59Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat60Choice {
        + RateTpAndRate  : ISO20022.Seev031001.RateTypeAndPercentageRate13
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat60Choice *-- ISO20022.Seev031001.RateTypeAndPercentageRate13
    ISO20022.Seev031001.RateAndAmountFormat60Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateAndAmountFormat61Choice {
        + RateTpAndRate  : ISO20022.Seev031001.RateTypeAndPercentageRate14
        + RateTpAndAmtAndRateSts  : ISO20022.Seev031001.RateTypeAndAmountAndStatus37
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateAndAmountFormat61Choice *-- ISO20022.Seev031001.RateTypeAndPercentageRate14
    ISO20022.Seev031001.RateAndAmountFormat61Choice *-- ISO20022.Seev031001.RateTypeAndAmountAndStatus37
    ISO20022.Seev031001.RateAndAmountFormat61Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateFormat12Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031001.RateFormat24Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031001.RateFormat25Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev031001.RateFormat26Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev031001.RateFormat26Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev031001.RateStatus1Code {
        INDI = 1
        ACTU = 2
    }
    class ISO20022.Seev031001.RateStatus3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateStatus3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType10Code {
        UKWN = 1
        ANYA = 2
    }
    class ISO20022.Seev031001.RateType13Code {
        NILP = 1
        UKWN = 2
    }
    class ISO20022.Seev031001.RateType33Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType33Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType36Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType36Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType42Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType42Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType5Code {
        UKWN = 1
    }
    class ISO20022.Seev031001.RateType76Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType76Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType77Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType77Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType78Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType78Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType79Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RateType79Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RateType7Code {
        USCD = 1
        SCHD = 2
    }
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus24 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType33Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev031001.RateType33Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus26 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType36Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev031001.RateType36Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus37 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.DeemedRateType1Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev031001.DeemedRateType1Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus55 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType76Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev031001.RateType76Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus56 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType77Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev031001.RateType77Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus57 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType78Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev031001.RateType78Choice
    class ISO20022.Seev031001.RateTypeAndAmountAndStatus58 {
        + RateSts  : ISO20022.Seev031001.RateStatus3Choice
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev031001.RateType79Choice
    }
    ISO20022.Seev031001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev031001.RateStatus3Choice
    ISO20022.Seev031001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev031001.RateType79Choice
    class ISO20022.Seev031001.RateTypeAndPercentageRate12 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031001.RateType42Choice
    }
    ISO20022.Seev031001.RateTypeAndPercentageRate12 *-- ISO20022.Seev031001.RateType42Choice
    class ISO20022.Seev031001.RateTypeAndPercentageRate13 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031001.RateType42Choice
    }
    ISO20022.Seev031001.RateTypeAndPercentageRate13 *-- ISO20022.Seev031001.RateType42Choice
    class ISO20022.Seev031001.RateTypeAndPercentageRate14 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev031001.DeemedRateType1Choice
    }
    ISO20022.Seev031001.RateTypeAndPercentageRate14 *-- ISO20022.Seev031001.DeemedRateType1Choice
    class ISO20022.Seev031001.RateValueType7Code {
        UKWN = 1
    }
    class ISO20022.Seev031001.RatioFormat17Choice {
        + AmtToAmt  : ISO20022.Seev031001.AmountToAmountRatio2
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev031001.QuantityToQuantityRatio1
    }
    ISO20022.Seev031001.RatioFormat17Choice *-- ISO20022.Seev031001.AmountToAmountRatio2
    ISO20022.Seev031001.RatioFormat17Choice *-- ISO20022.Seev031001.QuantityToQuantityRatio1
    class ISO20022.Seev031001.RatioFormat18Choice {
        + QtyToAmt  : ISO20022.Seev031001.AmountAndQuantityRatio4
        + AmtToQty  : ISO20022.Seev031001.AmountAndQuantityRatio4
        + AmtToAmt  : ISO20022.Seev031001.AmountToAmountRatio2
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev031001.QuantityToQuantityRatio1
    }
    ISO20022.Seev031001.RatioFormat18Choice *-- ISO20022.Seev031001.AmountAndQuantityRatio4
    ISO20022.Seev031001.RatioFormat18Choice *-- ISO20022.Seev031001.AmountAndQuantityRatio4
    ISO20022.Seev031001.RatioFormat18Choice *-- ISO20022.Seev031001.AmountToAmountRatio2
    ISO20022.Seev031001.RatioFormat18Choice *-- ISO20022.Seev031001.QuantityToQuantityRatio1
    class ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.RenounceableStatus1Code {
        RENO = 1
        NREN = 2
    }
    class ISO20022.Seev031001.SafekeepingAccountIdentification1Code {
        GENR = 1
    }
    class ISO20022.Seev031001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev031001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev031001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Seev031001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification78
        + TpAndId  : ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev031001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Seev031001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev031001.GenericIdentification78
    ISO20022.Seev031001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev031001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev031001.SafekeepingPlaceTypeAndText8
    class ISO20022.Seev031001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification78
        + TpAndId  : ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev031001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev031001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev031001.GenericIdentification78
    ISO20022.Seev031001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev031001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev031001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev031001.SecuritiesOption113 {
        + AmtDtls  : ISO20022.Seev031001.CorporateActionAmounts60
        + PricDtls  : ISO20022.Seev031001.CorporateActionPrice89
        + RateDtls  : ISO20022.Seev031001.CorporateActionRate128
        + DtDtls  : ISO20022.Seev031001.SecurityDate20
        + TradgPrd  : ISO20022.Seev031001.Period6Choice
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev031001.FractionDispositionType26Choice
        + CtryOfIncmSrc  : String
        + SfkpgPlc  : ISO20022.Seev031001.SafekeepingPlaceFormat41Choice
        + EntitldQty  : ISO20022.Seev031001.Quantity51Choice
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.GenericIdentification30~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev031001.GenericIdentification30~
        + IncmTp  : ISO20022.Seev031001.GenericIdentification30
        + NewSctiesIssncInd  : String
        + IssrOfferrTaxbltyInd  : ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice
        + NonElgblPrcdsInd  : ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice
        + TempFinInstrmInd  : ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice
        + CdtDbtInd  : String
        + SctyDtls  : ISO20022.Seev031001.FinancialInstrumentAttributes131
    }
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.CorporateActionAmounts60
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.CorporateActionPrice89
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.CorporateActionRate128
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.SecurityDate20
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.Period6Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.FractionDispositionType26Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.SafekeepingPlaceFormat41Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.Quantity51Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.GenericIdentification30
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice
    ISO20022.Seev031001.SecuritiesOption113 *-- ISO20022.Seev031001.FinancialInstrumentAttributes131
    class ISO20022.Seev031001.SecuritiesOption81 {
        + BckEndOddLotQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + FrntEndOddLotQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + NewDnmtnQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + NewBrdLotQty  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + MinMltplQtyToInst  : ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
        + MinQtyToInst  : ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
        + MaxQtyToInst  : ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    }
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity35Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    ISO20022.Seev031001.SecuritiesOption81 *-- ISO20022.Seev031001.FinancialInstrumentQuantity34Choice
    class ISO20022.Seev031001.SecurityDate20 {
        + LastTradgDt  : ISO20022.Seev031001.DateFormat30Choice
        + PrpssDt  : ISO20022.Seev031001.DateFormat30Choice
        + EarlstPmtDt  : ISO20022.Seev031001.DateFormat30Choice
        + DvddRnkgDt  : ISO20022.Seev031001.DateFormat30Choice
        + AvlblDt  : ISO20022.Seev031001.DateFormat30Choice
        + PmtDt  : ISO20022.Seev031001.DateFormat30Choice
    }
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    ISO20022.Seev031001.SecurityDate20 *-- ISO20022.Seev031001.DateFormat30Choice
    class ISO20022.Seev031001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev031001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev031001.SecurityIdentification19 *-- ISO20022.Seev031001.OtherIdentification1
    class ISO20022.Seev031001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev031001.SignedQuantityFormat10 {
        + Qty  : ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev031001.SignedQuantityFormat10 *-- ISO20022.Seev031001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev031001.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev031001.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev031001.SignedQuantityFormat11 *-- ISO20022.Seev031001.Quantity48Choice
    class ISO20022.Seev031001.SolicitationFeeRateFormat11Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
        + AmtToQty  : ISO20022.Seev031001.AmountAndQuantityRatio4
        + Rate  : Decimal
    }
    ISO20022.Seev031001.SolicitationFeeRateFormat11Choice *-- ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev031001.SolicitationFeeRateFormat11Choice *-- ISO20022.Seev031001.AmountAndQuantityRatio4
    class ISO20022.Seev031001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev031001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev031001.SupplementaryData1 *-- ISO20022.Seev031001.SupplementaryDataEnvelope1
    class ISO20022.Seev031001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice {
        + Prtry  : ISO20022.Seev031001.GenericIdentification30
        + TempInd  : String
    }
    ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice *-- ISO20022.Seev031001.GenericIdentification30
    class ISO20022.Seev031001.TotalEligibleBalanceFormat10 {
        + PartWayPrdUnits  : ISO20022.Seev031001.SignedQuantityFormat10
        + FullPrdUnits  : ISO20022.Seev031001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev031001.Quantity49Choice
    }
    ISO20022.Seev031001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev031001.SignedQuantityFormat10
    ISO20022.Seev031001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev031001.Quantity49Choice
    class ISO20022.Seev031001.UpdatedAdditionalInformation19 {
        + AddtlInf  : String
        + Lang  : String
    }
    class ISO20022.Seev031001.UpdatedAdditionalInformation20 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Lang  : String
    }
    class ISO20022.Seev031001.UpdatedAdditionalInformation21 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Lang  : String
    }
    class ISO20022.Seev031001.UpdatedURLlnformation6 {
        + URLAdr  : String
        + Lang  : String
    }
    class ISO20022.Seev031001.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev031001.AccountAndBalance60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev031001.CorporateActionBalanceDetails43||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev031001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev031001.PartyIdentification127Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr))|

---

## Value ISO20022.Seev031001.AccountIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.AccountIdentification71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctsListAndBalDtls|global::System.Collections.Generic.List<ISO20022.Seev031001.AccountAndBalance60>||XmlElement()||
|+|ForAllAccts|ISO20022.Seev031001.AccountIdentification10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validList("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validElement(AcctsListAndBalDtls),validElement(ForAllAccts),validChoice(AcctsListAndBalDtls,ForAllAccts))|

---

## Value ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev031001.AdditionalBusinessProcess9Code


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

## Value ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev031001.AmountAndQuantityRatio4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev031001.AmountAndRateStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|String||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev031001.AmountPrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031001.AmountPrice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031001.AmountPrice6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev031001.AmountPricePerAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PricVal|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev031001.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Enum ISO20022.Seev031001.AmountPriceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Enum ISO20022.Seev031001.AmountPriceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLOT|Int32||XmlEnum("""PLOT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev031001.AmountToAmountRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Amt1|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Value ISO20022.Seev031001.BalanceFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev031001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev031001.BalanceFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|NotElgblBal|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev031001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(PartWayPrdUnits,FullPrdUnits,NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev031001.BeneficiaryCertificationType13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.BeneficiaryCertificationType6Code


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

## Value ISO20022.Seev031001.BidRangeType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.BidRangeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MULT|Int32||XmlEnum("""MULT""")|1|
||INCR|Int32||XmlEnum("""INCR""")|2|
||DIVI|Int32||XmlEnum("""DIVI""")|3|

---

## Value ISO20022.Seev031001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev031001.BorrowerLendingDeadline5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brrwr|ISO20022.Seev031001.PartyIdentification127Choice||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brrwr),validElement(StockLndgDdln))|

---

## Value ISO20022.Seev031001.CapitalGainFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev031001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev031001.CashOption107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Seev031001.PriceDetails40||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031001.Rate43||XmlElement()||
|+|FXDtls|ISO20022.Seev031001.ForeignExchangeTerms39||XmlElement()||
|+|DtDtls|ISO20022.Seev031001.CorporateActionDate84||XmlElement()||
|+|AmtDtls|ISO20022.Seev031001.CorporateActionAmounts71||XmlElement()||
|+|CshAcctId|ISO20022.Seev031001.CashAccountIdentification9Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|PricClctnMtd|ISO20022.Seev031001.PriceCalculationMethod2Choice||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev031001.GenericIdentification30>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev031001.GenericIdentification30>||XmlElement()||
|+|IncmTp|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice||XmlElement()||
|+|CtrctlPmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(RateAndAmtDtls),validElement(FXDtls),validElement(DtDtls),validElement(AmtDtls),validElement(CshAcctId),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validElement(PricClctnMtd),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd))|

---

## Enum ISO20022.Seev031001.CertificationFormatType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|

---

## Value ISO20022.Seev031001.CertificationTypeFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Seev031001.ConsentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPY|Int32||XmlEnum("""DUPY""")|1|
||CTRM|Int32||XmlEnum("""CTRM""")|2|

---

## Value ISO20022.Seev031001.ConsentTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateAction84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev031001.CorporateActionNarrative58||XmlElement()||
|+|NewPlcOfIncorprtn|String||XmlElement()||
|+|DtchAuctnTp|ISO20022.Seev031001.DutchAuctionTypeFormat1Choice||XmlElement()||
|+|TaxOnNonDstrbtdPrcdsInd|global::System.Collections.Generic.List<ISO20022.Seev031001.GenericIdentification30>||XmlElement()||
|+|InfTp|ISO20022.Seev031001.InformationTypeFormat4Choice||XmlElement()||
|+|CnsntTp|ISO20022.Seev031001.ConsentTypeFormat4Choice||XmlElement()||
|+|CertfctnTp|ISO20022.Seev031001.CertificationTypeFormat3Choice||XmlElement()||
|+|LtryTp|ISO20022.Seev031001.LotteryTypeFormat4Choice||XmlElement()||
|+|ElctnTp|ISO20022.Seev031001.ElectionTypeFormat3Choice||XmlElement()||
|+|TaxblIncmPerShrClctd|ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice||XmlElement()||
|+|CptlGnInOutInd|ISO20022.Seev031001.CapitalGainFormat3Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice||XmlElement()||
|+|ChngTp|global::System.Collections.Generic.List<ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice>||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev031001.AdditionalBusinessProcessFormat17Choice>||XmlElement()||
|+|EvtStag|global::System.Collections.Generic.List<ISO20022.Seev031001.CorporateActionEventStageFormat13Choice>||XmlElement()||
|+|RnncblEntitlmntStsTp|ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev031001.OfferTypeFormat14Choice>||XmlElement()||
|+|OcrncTp|ISO20022.Seev031001.DistributionTypeFormat7Choice||XmlElement()||
|+|EvtSeqTp|ISO20022.Seev031001.EventSequenceTypeFormat1Choice||XmlElement()||
|+|DvddTp|ISO20022.Seev031001.DividendTypeFormat9Choice||XmlElement()||
|+|ShrhldrRghtsDrctvInd|String||XmlElement()||
|+|LttrOfGrntedDlvryInd|String||XmlElement()||
|+|FrftrOfIntrstInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
|+|RstrctnInd|String||XmlElement()||
|+|ChrgsApldInd|String||XmlElement()||
|+|CertfctnBrkdwnInd|String||XmlElement()||
|+|AccptncPrtyLvl|String||XmlElement()||
|+|CpnNb|global::System.Collections.Generic.List<ISO20022.Seev031001.IdentificationFormat3Choice>||XmlElement()||
|+|IntrstAcrdNbOfDays|Decimal||XmlElement()||
|+|SctiesQty|ISO20022.Seev031001.CorporateActionQuantity11||XmlElement()||
|+|PricDtls|ISO20022.Seev031001.CorporateActionPrice85||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031001.CorporateActionRate122||XmlElement()||
|+|PrdDtls|ISO20022.Seev031001.CorporateActionPeriod16||XmlElement()||
|+|DtDtls|ISO20022.Seev031001.CorporateActionDate83||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(DtchAuctnTp),validList("""TaxOnNonDstrbtdPrcdsInd""",TaxOnNonDstrbtdPrcdsInd),validElement(TaxOnNonDstrbtdPrcdsInd),validElement(InfTp),validElement(CnsntTp),validElement(CertfctnTp),validElement(LtryTp),validElement(ElctnTp),validElement(TaxblIncmPerShrClctd),validElement(CptlGnInOutInd),validElement(IntrmdtSctiesDstrbtnTp),validList("""ChngTp""",ChngTp),validElement(ChngTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validList("""EvtStag""",EvtStag),validElement(EvtStag),validElement(RnncblEntitlmntStsTp),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(OcrncTp),validElement(EvtSeqTp),validElement(DvddTp),validPattern("""AccptncPrtyLvl""",AccptncPrtyLvl,"""[A-Z0-9]{3}"""),validList("""CpnNb""",CpnNb),validElement(CpnNb),validElement(SctiesQty),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls))|

---

## Value ISO20022.Seev031001.CorporateActionAmounts60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt))|

---

## Value ISO20022.Seev031001.CorporateActionAmounts71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuyUpAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdRyltsAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdIntrstAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdFndAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdDvddAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|FrgnIncmAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TxTax|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxOnIncmAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|BckUpWhldgTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|NRATaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|FATCATaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|EqulstnAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|EUTaxRtntnAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|StockXchgTax|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|IncmPrtn|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|RedPrmAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrncplOrCrps|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|EntitldAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ChrgsAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ScndLvlTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddPmtAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrssAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyUpAmt),validElement(DmdRyltsAmt),validElement(DmdIntrstAmt),validElement(DmdFndAmt),validElement(DmdDvddAmt),validElement(FrgnIncmAmt),validElement(DmdAmt),validElement(TxTax),validElement(TaxOnIncmAmt),validElement(BckUpWhldgTaxAmt),validElement(NRATaxAmt),validElement(FATCATaxAmt),validElement(EqulstnAmt),validElement(AcrdIntrstAmt),validElement(EUTaxRtntnAmt),validElement(StockXchgTax),validElement(IncmPrtn),validElement(RedPrmAmt),validElement(PrncplOrCrps),validElement(OrgnlAmt),validElement(EntitldAmt),validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(ValAddedTaxAmt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(RinvstmtAmt),validElement(ManfctrdDvddPmtAmt),validElement(IndmntyAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(NetAmt),validElement(GrssAmt))|

---

## Value ISO20022.Seev031001.CorporateActionBalanceDetails43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UafctdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|AfctdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|InstdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|UinstdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|OblgtdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|RegdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|SttlmPosBal|global::System.Collections.Generic.List<ISO20022.Seev031001.BalanceFormat12Choice>||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev031001.BalanceFormat12Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev031001.BalanceFormat12Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev031001.TotalEligibleBalanceFormat10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UafctdBal),validElement(AfctdBal),validElement(InstdBal),validElement(UinstdBal),validElement(OblgtdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validList("""SttlmPosBal""",SttlmPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal))|

---

## Enum ISO20022.Seev031001.CorporateActionChangeType1Code


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

## Value ISO20022.Seev031001.CorporateActionChangeTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionDate104


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DcmnttnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|EndOfSctiesBlckgPrd|ISO20022.Seev031001.DateFormat59Choice||XmlElement()||
|+|BrrwrStockLndgDdln|global::System.Collections.Generic.List<ISO20022.Seev031001.BorrowerLendingDeadline5>||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|DpstryCoverXprtnDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|SbcptCostDbtDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|RspnDdln|ISO20022.Seev031001.DateFormat44Choice||XmlElement()||
|+|MktDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|PrtctDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|CoverXprtnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|EarlyRspnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DcmnttnDdln),validElement(EndOfSctiesBlckgPrd),validList("""BrrwrStockLndgDdln""",BrrwrStockLndgDdln),validElement(BrrwrStockLndgDdln),validElement(StockLndgDdln),validElement(DpstryCoverXprtnDt),validElement(SbcptCostDbtDt),validElement(XpryDt),validElement(RspnDdln),validElement(MktDdln),validElement(PrtctDdln),validElement(CoverXprtnDdln),validElement(EarlyRspnDdln))|

---

## Value ISO20022.Seev031001.CorporateActionDate83


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrgDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|FilgDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|LeadPlntffDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|MktClmTrckgEndDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|EarlyThrdPtyDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|ThrdPtyDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|LpsdDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|ElctnToCtrPtyRspnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|ElctnToCtrPtyMktDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|GrntedPrtcptnDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|SpclExDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|OffclAnncmntPblctnDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|ExDvddDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|WhlyUcondlDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|UcondlDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|TradgSspdDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|DdlnForTaxBrkdwnInstr|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|DdlnToSplt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|RsltsPblctnDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|RegnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|PrratnDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|MrgnFxgDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|MtgDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|NewMtrtyDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|LtryDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|FxgDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|FrthrDtldAnncmntDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|EqulstnDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|FctvDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|EarlyClsgDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|CrtApprvlDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|CertfctnDdln|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|AnncmntDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrgDt),validElement(FilgDt),validElement(LeadPlntffDdln),validElement(MktClmTrckgEndDt),validElement(EarlyThrdPtyDdln),validElement(ThrdPtyDdln),validElement(PmtDt),validElement(LpsdDt),validElement(ElctnToCtrPtyRspnDdln),validElement(ElctnToCtrPtyMktDdln),validElement(GrntedPrtcptnDt),validElement(SpclExDt),validElement(OffclAnncmntPblctnDt),validElement(ExDvddDt),validElement(WhlyUcondlDt),validElement(UcondlDt),validElement(TradgSspdDt),validElement(DdlnForTaxBrkdwnInstr),validElement(DdlnToSplt),validElement(RsltsPblctnDt),validElement(RegnDdln),validElement(RcrdDt),validElement(PrratnDt),validElement(MrgnFxgDt),validElement(MtgDt),validElement(NewMtrtyDt),validElement(LtryDt),validElement(FxgDt),validElement(FrthrDtldAnncmntDt),validElement(EqulstnDt),validElement(FctvDt),validElement(EarlyClsgDt),validElement(CrtApprvlDt),validElement(CertfctnDdln),validElement(AnncmntDt))|

---

## Value ISO20022.Seev031001.CorporateActionDate84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarlstPmtDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev031001.DateFormat43Choice||XmlElement()||
|+|ValDt|ISO20022.Seev031001.DateFormat57Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarlstPmtDt),validElement(FXRateFxgDt),validElement(ValDt),validElement(PmtDt))|

---

## Enum ISO20022.Seev031001.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev031001.CorporateActionEventProcessingType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionEventReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031001.ProcessingPosition7Choice||XmlElement()||
|+|EvtId|ISO20022.Seev031001.CorporateActionEventReference3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev031001.CorporateActionEventReference3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev031001.CorporateActionEventStage3Code


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

## Value ISO20022.Seev031001.CorporateActionEventStageFormat13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionEventStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtConfSts|String||XmlElement()||
|+|EvtCmpltnsSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.CorporateActionEventType107Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.CorporateActionEventType35Code


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

## Enum ISO20022.Seev031001.CorporateActionFrequencyType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPRE|Int32||XmlEnum("""SPRE""")|1|
||SPEC|Int32||XmlEnum("""SPEC""")|2|
||REGR|Int32||XmlEnum("""REGR""")|3|
||REIN|Int32||XmlEnum("""REIN""")|4|
||INTE|Int32||XmlEnum("""INTE""")|5|
||FINL|Int32||XmlEnum("""FINL""")|6|

---

## Value ISO20022.Seev031001.CorporateActionGeneralInformation176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev031001.FinancialInstrumentAttributes128||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice||XmlElement()||
|+|EvtTp|ISO20022.Seev031001.CorporateActionEventType107Choice||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev031001.CorporateActionEventProcessingType2Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validElement(EvtPrcgTp))|

---

## Enum ISO20022.Seev031001.CorporateActionInformationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONF|Int32||XmlEnum("""CONF""")|1|

---

## Enum ISO20022.Seev031001.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev031001.CorporateActionMandatoryVoluntary3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionNarrative58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtPrcgWebSiteAdr|String||XmlElement()||
|+|URLAdr|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedURLlnformation6>||XmlElement()||
|+|NewCpnyNm|String||XmlElement()||
|+|Offerr|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""URLAdr""",URLAdr),validElement(URLAdr))|

---

## Value ISO20022.Seev031001.CorporateActionNarrative59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|Dsclmr|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|TaxtnConds|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|SctyRstrctn|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|InfConds|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation21>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation19>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation19>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertfctnBrkdwn""",CertfctnBrkdwn),validElement(CertfctnBrkdwn),validList("""Dsclmr""",Dsclmr),validElement(Dsclmr),validList("""TaxtnConds""",TaxtnConds),validElement(TaxtnConds),validList("""SctyRstrctn""",SctyRstrctn),validElement(SctyRstrctn),validList("""InfToCmplyWth""",InfToCmplyWth),validElement(InfToCmplyWth),validList("""InfConds""",InfConds),validElement(InfConds),validList("""NrrtvVrsn""",NrrtvVrsn),validElement(NrrtvVrsn),validList("""AddtlTxt""",AddtlTxt),validElement(AddtlTxt))|

---

## Value ISO20022.Seev031001.CorporateActionNarrative60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgTxtForNxtIntrmy|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|URLAdr|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedURLlnformation6>||XmlElement()||
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|BsktOrIndxInf|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|RegnDtls|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|Dsclmr|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|TaxtnConds|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|InfConds|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<ISO20022.Seev031001.UpdatedAdditionalInformation20>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrcgTxtForNxtIntrmy""",PrcgTxtForNxtIntrmy),validElement(PrcgTxtForNxtIntrmy),validList("""URLAdr""",URLAdr),validElement(URLAdr),validList("""CertfctnBrkdwn""",CertfctnBrkdwn),validElement(CertfctnBrkdwn),validList("""BsktOrIndxInf""",BsktOrIndxInf),validElement(BsktOrIndxInf),validList("""RegnDtls""",RegnDtls),validElement(RegnDtls),validList("""PtyCtctNrrtv""",PtyCtctNrrtv),validElement(PtyCtctNrrtv),validList("""Dsclmr""",Dsclmr),validElement(Dsclmr),validList("""TaxtnConds""",TaxtnConds),validElement(TaxtnConds),validList("""InfToCmplyWth""",InfToCmplyWth),validElement(InfToCmplyWth),validList("""InfConds""",InfConds),validElement(InfConds),validList("""NrrtvVrsn""",NrrtvVrsn),validElement(NrrtvVrsn),validList("""AddtlTxt""",AddtlTxt),validElement(AddtlTxt))|

---

## Value ISO20022.Seev031001.CorporateActionNotification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgSts|ISO20022.Seev031001.CorporateActionProcessingStatus5Choice||XmlElement()||
|+|NtfctnTp|String||XmlElement()||
|+|NtfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgSts))|

---

## Enum ISO20022.Seev031001.CorporateActionNotificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RMDR|Int32||XmlEnum("""RMDR""")|1|
||REPL|Int32||XmlEnum("""REPL""")|2|
||NEWM|Int32||XmlEnum("""NEWM""")|3|

---

## Aspect ISO20022.Seev031001.CorporateActionNotificationV15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev031001.SupplementaryData1>||XmlElement()||
|+|TrfAgt|ISO20022.Seev031001.PartyIdentification129Choice||XmlElement()||
|+|Offerr|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification129Choice>||XmlElement()||
|+|Issr|ISO20022.Seev031001.PartyIdentification129Choice||XmlElement()||
|+|InfAgt|ISO20022.Seev031001.PartyIdentification120Choice||XmlElement()||
|+|SlctnAgt|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification120Choice>||XmlElement()||
|+|DrpAgt|ISO20022.Seev031001.PartyIdentification120Choice||XmlElement()||
|+|PhysSctiesAgt|ISO20022.Seev031001.PartyIdentification120Choice||XmlElement()||
|+|RsellngAgt|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification120Choice>||XmlElement()||
|+|Regar|ISO20022.Seev031001.PartyIdentification120Choice||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification120Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification120Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev031001.PartyIdentification129Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev031001.CorporateActionNarrative60||XmlElement()||
|+|CorpActnOptnDtls|global::System.Collections.Generic.List<ISO20022.Seev031001.CorporateActionOption236>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev031001.CorporateAction84||XmlElement()||
|+|IntrmdtScty|ISO20022.Seev031001.FinancialInstrumentAttributes110||XmlElement()||
|+|AcctDtls|ISO20022.Seev031001.AccountIdentification71Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev031001.CorporateActionGeneralInformation176||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev031001.CorporateActionEventReference3>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev031001.DocumentIdentification32>||XmlElement()||
|+|InstrId|ISO20022.Seev031001.DocumentIdentification9||XmlElement()||
|+|PrvsNtfctnId|ISO20022.Seev031001.DocumentIdentification31||XmlElement()||
|+|NtfctnGnlInf|ISO20022.Seev031001.CorporateActionNotification9||XmlElement()||
|+|Pgntn|ISO20022.Seev031001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TrfAgt),validList("""Offerr""",Offerr),validElement(Offerr),validElement(Issr),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validList("""CorpActnOptnDtls""",CorpActnOptnDtls),validElement(CorpActnOptnDtls),validElement(CorpActnDtls),validElement(IntrmdtScty),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(PrvsNtfctnId),validElement(NtfctnGnlInf),validElement(Pgntn))|

---

## Enum ISO20022.Seev031001.CorporateActionOption15Code


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

## Value ISO20022.Seev031001.CorporateActionOption236


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev031001.CorporateActionNarrative59||XmlElement()||
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev031001.CashOption107>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev031001.SecuritiesOption113>||XmlElement()||
|+|SctiesQty|ISO20022.Seev031001.SecuritiesOption81||XmlElement()||
|+|PricDtls|ISO20022.Seev031001.CorporateActionPrice90||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev031001.CorporateActionRate126||XmlElement()||
|+|PrdDtls|ISO20022.Seev031001.CorporateActionPeriod12||XmlElement()||
|+|DtDtls|ISO20022.Seev031001.CorporateActionDate104||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031001.SecurityIdentification19||XmlElement()||
|+|ApldOptnInd|String||XmlElement()||
|+|ChngAllwdInd|String||XmlElement()||
|+|WdrwlAllwdInd|String||XmlElement()||
|+|CertfctnBrkdwnInd|String||XmlElement()||
|+|ChrgsApldInd|String||XmlElement()||
|+|DfltPrcgOrStgInstr|ISO20022.Seev031001.DefaultProcessingOrStandingInstruction2Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|VldDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NonDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrratnBlwMinQty|ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice||XmlElement()||
|+|BidRgTp|ISO20022.Seev031001.BidRangeType1Choice||XmlElement()||
|+|CertfctnBrkdwnTp|global::System.Collections.Generic.List<ISO20022.Seev031001.BeneficiaryCertificationType13Choice>||XmlElement()||
|+|AccptncPrtyLvl|String||XmlElement()||
|+|OptnAvlbtySts|ISO20022.Seev031001.OptionAvailabilityStatus3Choice||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev031001.OptionFeaturesFormat28Choice>||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev031001.OfferTypeFormat14Choice>||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031001.FractionDispositionType26Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev031001.CorporateActionOption37Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(SctiesQty),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls),validElement(FinInstrmId),validElement(DfltPrcgOrStgInstr),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validPattern("""VldDmclCtry""",VldDmclCtry,"""[A-Z]{2,2}"""),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validElement(PrratnBlwMinQty),validElement(BidRgTp),validList("""CertfctnBrkdwnTp""",CertfctnBrkdwnTp),validElement(CertfctnBrkdwnTp),validPattern("""AccptncPrtyLvl""",AccptncPrtyLvl,"""[A-Z0-9]{3}"""),validElement(OptnAvlbtySts),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(FrctnDspstn),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev031001.CorporateActionOption37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionPeriod12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DpstrySspnsnPrdForWdrwl|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|AcctSvcrRvcbltyPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|PrvlgSspnsnPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|RvcbltyPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|ActnPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|ParllTradgPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DpstrySspnsnPrdForWdrwl),validElement(AcctSvcrRvcbltyPrd),validElement(PrvlgSspnsnPrd),validElement(RvcbltyPrd),validElement(ActnPrd),validElement(ParllTradgPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev031001.CorporateActionPeriod16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FsclYrPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|SpltPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|CoDpstriesSspnsnPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|BookClsrPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlInStrtNm|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlInNmneeNm|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForWdrwlAtAgt|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForSgrtn|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForPldg|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForDpst|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForDpstAtAgt|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|DpstrySspnsnPrdForBookNtryTrf|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|ClmPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|CmplsryPurchsPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|IntrstPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FsclYrPrd),validElement(SpltPrd),validElement(CoDpstriesSspnsnPrd),validElement(BookClsrPrd),validElement(DpstrySspnsnPrdForWdrwlInStrtNm),validElement(DpstrySspnsnPrdForWdrwlInNmneeNm),validElement(DpstrySspnsnPrdForWdrwlAtAgt),validElement(DpstrySspnsnPrdForSgrtn),validElement(DpstrySspnsnPrdForPldg),validElement(DpstrySspnsnPrdForDpst),validElement(DpstrySspnsnPrdForDpstAtAgt),validElement(DpstrySspnsnPrdForBookNtryTrf),validElement(ClmPrd),validElement(CmplsryPurchsPrd),validElement(IntrstPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev031001.CorporateActionPrice85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastBidIncrmtPric|ISO20022.Seev031001.PriceFormat73Choice||XmlElement()||
|+|FrstBidIncrmtPric|ISO20022.Seev031001.PriceFormat73Choice||XmlElement()||
|+|MinPric|ISO20022.Seev031001.PriceFormat73Choice||XmlElement()||
|+|MaxPric|ISO20022.Seev031001.PriceFormat73Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastBidIncrmtPric),validElement(FrstBidIncrmtPric),validElement(MinPric),validElement(MaxPric))|

---

## Value ISO20022.Seev031001.CorporateActionPrice89


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricRcvdPerPdct|ISO20022.Seev031001.PriceFormat79Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
|+|CshValForTax|ISO20022.Seev031001.PriceFormat46Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev031001.IndicativeOrMarketPrice14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct),validElement(CshValForTax),validElement(CshInLieuOfShrPric),validElement(IndctvOrMktPric))|

---

## Value ISO20022.Seev031001.CorporateActionPrice90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastBidIncrmtPric|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
|+|FrstBidIncrmtPric|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
|+|MinPric|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
|+|MaxPric|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
|+|MinMltplCshToInst|ISO20022.Seev031001.PriceFormat61Choice||XmlElement()||
|+|MinCshToInst|ISO20022.Seev031001.PriceFormat61Choice||XmlElement()||
|+|MaxCshToInst|ISO20022.Seev031001.PriceFormat61Choice||XmlElement()||
|+|OverSbcptDpstPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastBidIncrmtPric),validElement(FrstBidIncrmtPric),validElement(MinPric),validElement(MaxPric),validElement(MinMltplCshToInst),validElement(MinCshToInst),validElement(MaxCshToInst),validElement(OverSbcptDpstPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev031001.CorporateActionProcessingStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|ISO20022.Seev031001.CorporateActionEventStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Cd),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.CorporateActionQuantity11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IncrmtlDnmtn|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|BaseDnmtn|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|NewDnmtnQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|NewBrdLotQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|MinQtySght|ISO20022.Seev031001.FinancialInstrumentQuantity34Choice||XmlElement()||
|+|MaxQty|ISO20022.Seev031001.FinancialInstrumentQuantity34Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IncrmtlDnmtn),validElement(BaseDnmtn),validElement(NewDnmtnQty),validElement(NewBrdLotQty),validElement(MinQtySght),validElement(MaxQty))|

---

## Value ISO20022.Seev031001.CorporateActionRate122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxFctr|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
|+|DclrdRate|ISO20022.Seev031001.RateAndAmountFormat59Choice||XmlElement()||
|+|RealsdLoss|ISO20022.Seev031001.RateAndAmountFormat59Choice||XmlElement()||
|+|IntrstShrtfll|ISO20022.Seev031001.RateAndAmountFormat59Choice||XmlElement()||
|+|RinvstmtDscntRateToMkt|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|NxtFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|BidIntrvl|ISO20022.Seev031001.RateAndAmountFormat58Choice||XmlElement()||
|+|Sprd|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|RltdIndx|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|PctgSght|ISO20022.Seev031001.RateFormat25Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndxFctr),validElement(DclrdRate),validElement(RealsdLoss),validElement(IntrstShrtfll),validElement(RinvstmtDscntRateToMkt),validElement(NxtFctr),validElement(PrvsFctr),validElement(BidIntrvl),validElement(Sprd),validElement(RltdIndx),validElement(PctgSght),validElement(IntrstRate))|

---

## Value ISO20022.Seev031001.CorporateActionRate126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BidIntrvl|ISO20022.Seev031001.RateAndAmountFormat58Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
|+|IssrDclrdXchgRate|ISO20022.Seev031001.ForeignExchangeTerms38||XmlElement()||
|+|TaxblIncmPerDvddShr|global::System.Collections.Generic.List<ISO20022.Seev031001.RateTypeAndAmountAndStatus26>||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat60Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat56Choice>||XmlElement()||
|+|PrratnRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|MaxAllwdOvrsbcptRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice>||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031001.NetDividendRateFormat38Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031001.GrossDividendRateFormat36Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BidIntrvl),validElement(TaxOnIncm),validElement(IssrDclrdXchgRate),validList("""TaxblIncmPerDvddShr""",TaxblIncmPerDvddShr),validElement(TaxblIncmPerDvddShr),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(PrratnRate),validElement(MaxAllwdOvrsbcptRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev031001.CorporateActionRate128


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat60Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat60Choice>||XmlElement()||
|+|FinTxTaxRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev031001.RateFormat26Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
|+|TrfrmatnRate|Decimal||XmlElement()||
|+|NewToOd|ISO20022.Seev031001.RatioFormat18Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev031001.RatioFormat17Choice||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev031001.RatioFormat17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(FinTxTaxRate),validElement(TaxCdtRate),validElement(AplblRate),validElement(FsclStmp),validElement(ChrgsFees),validElement(NewToOd),validElement(AddtlQtyForExstgScties),validElement(AddtlQtyForSbcbdRsltntScties))|

---

## Enum ISO20022.Seev031001.CorporateActionTaxableIncomePerShareCalculated1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TDIN|Int32||XmlEnum("""TDIN""")|2|
||TDIY|Int32||XmlEnum("""TDIY""")|3|

---

## Enum ISO20022.Seev031001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev031001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev031001.DateCode19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.DateCode20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.DateCode21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.DateCode33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.DateCodeAndTimeFormat3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|DtCd|ISO20022.Seev031001.DateCode21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd))|

---

## Value ISO20022.Seev031001.DateFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031001.DateCode19Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031001.DateFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031001.DateCode19Choice||XmlElement()||
|+|Dt|ISO20022.Seev031001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031001.DateFormat44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031001.DateCode19Choice||XmlElement()||
|+|DtCdAndTm|ISO20022.Seev031001.DateCodeAndTimeFormat3||XmlElement()||
|+|Dt|ISO20022.Seev031001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(DtCdAndTm),validElement(Dt),validChoice(DtCd,DtCdAndTm,Dt))|

---

## Value ISO20022.Seev031001.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev031001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Value ISO20022.Seev031001.DateFormat57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031001.DateCode20Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev031001.DateFormat59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev031001.DateCode33Choice||XmlElement()||
|+|Dt|ISO20022.Seev031001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev031001.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev031001.DateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|

---

## Enum ISO20022.Seev031001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Enum ISO20022.Seev031001.DateType9Code


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

## Value ISO20022.Seev031001.DeemedRateType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.DeemedRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERY|Int32||XmlEnum("""DERY""")|1|
||DEIT|Int32||XmlEnum("""DEIT""")|2|
||DEFP|Int32||XmlEnum("""DEFP""")|3|
||DEDI|Int32||XmlEnum("""DEDI""")|4|

---

## Value ISO20022.Seev031001.DefaultProcessingOrStandingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgInstrInd|String||XmlElement()||
|+|DfltOptnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(StgInstrInd,DfltOptnInd))|

---

## Enum ISO20022.Seev031001.DistributionType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ROLL|Int32||XmlEnum("""ROLL""")|1|
||ONGO|Int32||XmlEnum("""ONGO""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|
||FINL|Int32||XmlEnum("""FINL""")|4|

---

## Value ISO20022.Seev031001.DistributionTypeFormat7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.DividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Value ISO20022.Seev031001.DividendTypeFormat9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev031001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnNtfctn|ISO20022.Seev031001.CorporateActionNotificationV15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnNtfctn))|

---

## Value ISO20022.Seev031001.DocumentIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031001.ProcessingPosition7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp))|

---

## Value ISO20022.Seev031001.DocumentIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev031001.ProcessingPosition7Choice||XmlElement()||
|+|DocNb|ISO20022.Seev031001.DocumentNumber5Choice||XmlElement()||
|+|Id|ISO20022.Seev031001.DocumentIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev031001.DocumentIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev031001.DocumentIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Seev031001.DutchAuctionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNMD|Int32||XmlEnum("""UNMD""")|1|
||MDFD|Int32||XmlEnum("""MDFD""")|2|

---

## Value ISO20022.Seev031001.DutchAuctionTypeFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Enum ISO20022.Seev031001.ElectionMovementType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEQD|Int32||XmlEnum("""SEQD""")|1|
||DRCT|Int32||XmlEnum("""DRCT""")|2|

---

## Value ISO20022.Seev031001.ElectionTypeFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.EventCompletenessStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCO|Int32||XmlEnum("""INCO""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Enum ISO20022.Seev031001.EventConfirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCON|Int32||XmlEnum("""UCON""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Enum ISO20022.Seev031001.EventSequenceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INTE|Int32||XmlEnum("""INTE""")|1|
||FINL|Int32||XmlEnum("""FINL""")|2|

---

## Value ISO20022.Seev031001.EventSequenceTypeFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.FinancialInstrumentAttributes110


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|UinstdBal|ISO20022.Seev031001.BalanceFormat11Choice||XmlElement()||
|+|TradgPrd|ISO20022.Seev031001.Period11||XmlElement()||
|+|PstngDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|MktPric|ISO20022.Seev031001.AmountPrice2||XmlElement()||
|+|IntrmdtSctiesToUndrlygRatio|ISO20022.Seev031001.QuantityToQuantityRatio1||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031001.FractionDispositionType25Choice||XmlElement()||
|+|RnncblEntitlmntStsTp|ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|SctyId|ISO20022.Seev031001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdBal),validElement(UinstdBal),validElement(TradgPrd),validElement(PstngDt),validElement(XpryDt),validElement(MktPric),validElement(IntrmdtSctiesToUndrlygRatio),validElement(FrctnDspstn),validElement(RnncblEntitlmntStsTp),validElement(SctyId))|

---

## Value ISO20022.Seev031001.FinancialInstrumentAttributes128


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctSz|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|WarrtParity|ISO20022.Seev031001.QuantityToQuantityRatio1||XmlElement()||
|+|NxtFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|PctgOfDebtClm|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
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
|+|OptnStyle|ISO20022.Seev031001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev031001.ClassificationType32Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev031001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev031001.MarketIdentification3Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinNmnlQty),validElement(WarrtParity),validElement(NxtFctr),validElement(PrvsFctr),validElement(PctgOfDebtClm),validElement(NxtIntrstRate),validElement(IntrstRate),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev031001.FinancialInstrumentAttributes131


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssePric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
|+|CtrctSz|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|NxtFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev031001.RateFormat12Choice||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|NxtCpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnStyle|ISO20022.Seev031001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev031001.ClassificationType32Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev031001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev031001.MarketIdentification3Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev031001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssePric),validElement(CtrctSz),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MinNmnlQty),validElement(NxtIntrstRate),validElement(IntrstRate),validElement(NxtFctr),validElement(PrvsFctr),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev031001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031001.FinancialInstrumentQuantity34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031001.FinancialInstrumentQuantity35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev031001.ForeignExchangeTerms38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031001.ForeignExchangeTerms39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev031001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev031001.FractionDispositionType25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.FractionDispositionType26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.FractionDispositionType8Code


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

## Enum ISO20022.Seev031001.FractionDispositionType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|
||STAN|Int32||XmlEnum("""STAN""")|3|
||RDDN|Int32||XmlEnum("""RDDN""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|

---

## Value ISO20022.Seev031001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev031001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev031001.GrossDividendRateFormat36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus55||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev031001.GrossDividendRateFormat38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus57||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev031001.GrossDividendRateType6Code


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

## Enum ISO20022.Seev031001.GrossDividendRateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNFR|Int32||XmlEnum("""UNFR""")|1|
||TXFR|Int32||XmlEnum("""TXFR""")|2|
||TXDF|Int32||XmlEnum("""TXDF""")|3|
||TXBL|Int32||XmlEnum("""TXBL""")|4|
||SOIC|Int32||XmlEnum("""SOIC""")|5|
||STCG|Int32||XmlEnum("""STCG""")|6|
||REES|Int32||XmlEnum("""REES""")|7|
||PAPU|Int32||XmlEnum("""PAPU""")|8|
||LTCG|Int32||XmlEnum("""LTCG""")|9|
||INTR|Int32||XmlEnum("""INTR""")|10|
||INCO|Int32||XmlEnum("""INCO""")|11|
||FLFR|Int32||XmlEnum("""FLFR""")|12|
||FUPU|Int32||XmlEnum("""FUPU""")|13|
||CDFI|Int32||XmlEnum("""CDFI""")|14|
||CAPO|Int32||XmlEnum("""CAPO""")|15|

---

## Value ISO20022.Seev031001.IdentificationFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|LngId|String||XmlElement()||
|+|ShrtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""ShrtId""",ShrtId,"""[A-Z0-9]{3}"""),validChoice(PrtryId,LngId,ShrtId))|

---

## Value ISO20022.Seev031001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.IndicativeOrMarketPrice14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Value ISO20022.Seev031001.InformationTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.InterestComputationMethod2Code


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

## Value ISO20022.Seev031001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus24||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev031001.IntermediateSecuritiesDistributionTypeFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.IntermediateSecurityDistributionType5Code


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

## Value ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.IssuerTaxability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Enum ISO20022.Seev031001.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev031001.LotteryTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev031001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev031001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev031001.NetDividendRateFormat38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus56||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev031001.NetDividendRateFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus58||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev031001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev031001.NetDividendRateType6Code


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

## Enum ISO20022.Seev031001.NetDividendRateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REES|Int32||XmlEnum("""REES""")|1|
||PAPU|Int32||XmlEnum("""PAPU""")|2|
||UNFR|Int32||XmlEnum("""UNFR""")|3|
||TXFR|Int32||XmlEnum("""TXFR""")|4|
||TXDF|Int32||XmlEnum("""TXDF""")|5|
||TXBL|Int32||XmlEnum("""TXBL""")|6|
||SOIC|Int32||XmlEnum("""SOIC""")|7|
||INTR|Int32||XmlEnum("""INTR""")|8|
||INCO|Int32||XmlEnum("""INCO""")|9|
||FLFR|Int32||XmlEnum("""FLFR""")|10|
||FUPU|Int32||XmlEnum("""FUPU""")|11|
||CDFI|Int32||XmlEnum("""CDFI""")|12|
||CAPO|Int32||XmlEnum("""CAPO""")|13|

---

## Enum ISO20022.Seev031001.NewSecuritiesIssuanceType5Code


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

## Enum ISO20022.Seev031001.NonEligibleProceedsIndicator2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NELS|Int32||XmlEnum("""NELS""")|1|
||ONEL|Int32||XmlEnum("""ONEL""")|2|
||ACLI|Int32||XmlEnum("""ACLI""")|3|
||NELC|Int32||XmlEnum("""NELC""")|4|

---

## Value ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.OfferType5Code


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

## Value ISO20022.Seev031001.OfferTypeFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.OptionAvailabilityStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||INTV|Int32||XmlEnum("""INTV""")|2|

---

## Value ISO20022.Seev031001.OptionAvailabilityStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.OptionFeatures13Code


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

## Value ISO20022.Seev031001.OptionFeaturesFormat28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Seev031001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.OriginalAndCurrentQuantities6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev031001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev031001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev031001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev031001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev031001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev031001.PartyIdentification129Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev031001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev031001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,NmAndAdr,PrtryId,AnyBIC))|

---

## Enum ISO20022.Seev031001.Payment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Value ISO20022.Seev031001.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.PercentagePrice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.Period11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev031001.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Seev031001.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev031001.Period6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrdCd|String||XmlElement()||
|+|Prd|ISO20022.Seev031001.Period11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validChoice(PrdCd,Prd))|

---

## Value ISO20022.Seev031001.PostalAddress1


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

## Enum ISO20022.Seev031001.PriceCalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVCL|Int32||XmlEnum("""AVCL""")|1|
||NAVA|Int32||XmlEnum("""NAVA""")|2|
||MIMP|Int32||XmlEnum("""MIMP""")|3|
||NAVF|Int32||XmlEnum("""NAVF""")|4|
||VWAP|Int32||XmlEnum("""VWAP""")|5|

---

## Value ISO20022.Seev031001.PriceCalculationMethod2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.PriceDetails40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInLieuOfShrPric|ISO20022.Seev031001.PriceFormat81Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev031001.PriceFormat79Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev031001.PriceFormat80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInLieuOfShrPric),validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct))|

---

## Value ISO20022.Seev031001.PriceFormat46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev031001.PriceFormat61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev031001.PriceFormat73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev031001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031001.PriceFormat79Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev031001.AmountPricePerAmount2||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev031001.AmountPricePerFinancialInstrumentQuantity10||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev031001.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031001.PriceFormat80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev031001.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev031001.PriceFormat81Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev031001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev031001.PercentagePrice3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev031001.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev031001.PriceValueType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev031001.PriceValueType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||UNSP|Int32||XmlEnum("""UNSP""")|3|
||TBSP|Int32||XmlEnum("""TBSP""")|4|

---

## Enum ISO20022.Seev031001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev031001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.ProprietaryQuantity7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev031001.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Enum ISO20022.Seev031001.ProrationBelowMinimumQuantity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|
||MILT|Int32||XmlEnum("""MILT""")|3|
||MIEX|Int32||XmlEnum("""MIEX""")|4|
||FULL|Int32||XmlEnum("""FULL""")|5|

---

## Value ISO20022.Seev031001.ProrationBelowMinimumQuantity2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev031001.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev031001.Quantity49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev031001.ProprietaryQuantity7||XmlElement()||
|+|QtyChc|ISO20022.Seev031001.Quantity50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Enum ISO20022.Seev031001.Quantity4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANYA|Int32||XmlEnum("""ANYA""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev031001.Quantity50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev031001.OriginalAndCurrentQuantities6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev031001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev031001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Seev031001.Quantity5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev031001.QuantityToQuantityRatio1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.Rate43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmdRate|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat61Choice>||XmlElement()||
|+|EqulstnRate|ISO20022.Seev031001.RateAndAmountFormat42Choice||XmlElement()||
|+|TaxRclmRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|TaxOnPrfts|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev031001.RateFormat26Choice||XmlElement()||
|+|SlctnFeeRate|ISO20022.Seev031001.SolicitationFeeRateFormat11Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031001.NetDividendRateFormat39Choice>||XmlElement()||
|+|ThrdPtyIncntivRate|ISO20022.Seev031001.RateFormat26Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev031001.RateFormat24Choice||XmlElement()||
|+|EarlySlctnFeeRate|ISO20022.Seev031001.SolicitationFeeRateFormat11Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat60Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev031001.RateAndAmountFormat60Choice>||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev031001.InterestRateUsedForPaymentFormat11Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev031001.GrossDividendRateFormat38Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev031001.RateAndAmountFormat57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DmdRate""",DmdRate),validElement(DmdRate),validElement(EqulstnRate),validElement(TaxRclmRate),validElement(TaxOnPrfts),validElement(TaxOnIncm),validElement(TaxCdtRate),validElement(SlctnFeeRate),validElement(AplblRate),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validElement(ThrdPtyIncntivRate),validElement(FsclStmp),validElement(EarlySlctnFeeRate),validElement(ChrgsFees),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat56Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031001.RateTypeAndPercentageRate12||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(IndxPts,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat60Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031001.RateTypeAndPercentageRate13||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateAndAmountFormat61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev031001.RateTypeAndPercentageRate14||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev031001.RateTypeAndAmountAndStatus37||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndRate,RateTpAndAmtAndRateSts,NotSpcfdRate,Amt,Rate))|

---

## Value ISO20022.Seev031001.RateFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateFormat25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev031001.RateFormat26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt,Rate))|

---

## Enum ISO20022.Seev031001.RateStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDI|Int32||XmlEnum("""INDI""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev031001.RateStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.RateType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||ANYA|Int32||XmlEnum("""ANYA""")|2|

---

## Enum ISO20022.Seev031001.RateType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev031001.RateType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.RateType36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.RateType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.RateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev031001.RateType76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.RateType77Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.RateType78Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.RateType79Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.RateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USCD|Int32||XmlEnum("""USCD""")|1|
||SCHD|Int32||XmlEnum("""SCHD""")|2|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.DeemedRateType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus55


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType76Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType78Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndAmountAndStatus58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev031001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType79Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndPercentageRate12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndPercentageRate13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031001.RateType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev031001.RateTypeAndPercentageRate14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev031001.DeemedRateType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev031001.RateValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev031001.RatioFormat17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtToAmt|ISO20022.Seev031001.AmountToAmountRatio2||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev031001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtToAmt),validElement(QtyToQty),validChoice(AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev031001.RatioFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyToAmt|ISO20022.Seev031001.AmountAndQuantityRatio4||XmlElement()||
|+|AmtToQty|ISO20022.Seev031001.AmountAndQuantityRatio4||XmlElement()||
|+|AmtToAmt|ISO20022.Seev031001.AmountToAmountRatio2||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev031001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(QtyToAmt,AmtToQty,AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev031001.RenounceableEntitlementStatusTypeFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev031001.RenounceableStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RENO|Int32||XmlEnum("""RENO""")|1|
||NREN|Int32||XmlEnum("""NREN""")|2|

---

## Enum ISO20022.Seev031001.SafekeepingAccountIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GENR|Int32||XmlEnum("""GENR""")|1|

---

## Enum ISO20022.Seev031001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev031001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Enum ISO20022.Seev031001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Seev031001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev031001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev031001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev031001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev031001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev031001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.SecuritiesOption113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtDtls|ISO20022.Seev031001.CorporateActionAmounts60||XmlElement()||
|+|PricDtls|ISO20022.Seev031001.CorporateActionPrice89||XmlElement()||
|+|RateDtls|ISO20022.Seev031001.CorporateActionRate128||XmlElement()||
|+|DtDtls|ISO20022.Seev031001.SecurityDate20||XmlElement()||
|+|TradgPrd|ISO20022.Seev031001.Period6Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev031001.FractionDispositionType26Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev031001.SafekeepingPlaceFormat41Choice||XmlElement()||
|+|EntitldQty|ISO20022.Seev031001.Quantity51Choice||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev031001.GenericIdentification30>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev031001.GenericIdentification30>||XmlElement()||
|+|IncmTp|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|NewSctiesIssncInd|String||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev031001.IssuerOfferorTaxabilityIndicator2Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev031001.NonEligibleProceedsIndicator5Choice||XmlElement()||
|+|TempFinInstrmInd|ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|SctyDtls|ISO20022.Seev031001.FinancialInstrumentAttributes131||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtDtls),validElement(PricDtls),validElement(RateDtls),validElement(DtDtls),validElement(TradgPrd),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validElement(SfkpgPlc),validElement(EntitldQty),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd),validElement(TempFinInstrmInd),validElement(SctyDtls))|

---

## Value ISO20022.Seev031001.SecuritiesOption81


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BckEndOddLotQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|FrntEndOddLotQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|NewDnmtnQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|NewBrdLotQty|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev031001.FinancialInstrumentQuantity35Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev031001.FinancialInstrumentQuantity34Choice||XmlElement()||
|+|MaxQtyToInst|ISO20022.Seev031001.FinancialInstrumentQuantity34Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BckEndOddLotQty),validElement(FrntEndOddLotQty),validElement(NewDnmtnQty),validElement(NewBrdLotQty),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MaxQtyToInst))|

---

## Value ISO20022.Seev031001.SecurityDate20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastTradgDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev031001.DateFormat30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastTradgDt),validElement(PrpssDt),validElement(EarlstPmtDt),validElement(DvddRnkgDt),validElement(AvlblDt),validElement(PmtDt))|

---

## Value ISO20022.Seev031001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev031001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev031001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev031001.SignedQuantityFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev031001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev031001.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev031001.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev031001.SolicitationFeeRateFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtToQty|ISO20022.Seev031001.AmountAndQuantityRatio4||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(AmtToQty),validChoice(NotSpcfdRate,Amt,AmtToQty,Rate))|

---

## Value ISO20022.Seev031001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev031001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev031001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev031001.TaxableIncomePerShareCalculatedFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev031001.TemporaryFinancialInstrumentIndicator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev031001.GenericIdentification30||XmlElement()||
|+|TempInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,TempInd))|

---

## Value ISO20022.Seev031001.TotalEligibleBalanceFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev031001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev031001.Quantity49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(Bal))|

---

## Value ISO20022.Seev031001.UpdatedAdditionalInformation19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031001.UpdatedAdditionalInformation20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AddtlInf""",AddtlInf),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031001.UpdatedAdditionalInformation21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AddtlInf""",AddtlInf),validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev031001.UpdatedURLlnformation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Enum ISO20022.Seev031001.WithholdingTaxRateType1Code


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

