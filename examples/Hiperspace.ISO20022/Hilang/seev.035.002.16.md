# seev.035.002.16
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev035002.AccountAndBalance64 {
        + Bal  : ISO20022.Seev035002.CorporateActionBalanceDetails46
        + SfkpgPlc  : ISO20022.Seev035002.SafekeepingPlaceFormat52Choice
        + AcctOwnr  : ISO20022.Seev035002.PartyIdentification136Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev035002.AccountAndBalance64 *-- ISO20022.Seev035002.CorporateActionBalanceDetails46
    ISO20022.Seev035002.AccountAndBalance64 *-- ISO20022.Seev035002.SafekeepingPlaceFormat52Choice
    ISO20022.Seev035002.AccountAndBalance64 *-- ISO20022.Seev035002.PartyIdentification136Choice
    class ISO20022.Seev035002.AccountIdentification10 {
        + IdCd  : String
    }
    class ISO20022.Seev035002.AccountIdentification76Choice {
        + AcctsListAndBalDtls  : global::System.Collections.Generic.List~ISO20022.Seev035002.AccountAndBalance64~
        + ForAllAccts  : ISO20022.Seev035002.AccountIdentification10
    }
    ISO20022.Seev035002.AccountIdentification76Choice *-- ISO20022.Seev035002.AccountAndBalance64
    ISO20022.Seev035002.AccountIdentification76Choice *-- ISO20022.Seev035002.AccountIdentification10
    class ISO20022.Seev035002.AdditionalBusinessProcess10Code {
        INCP = 1
        REAC = 2
        FPRE = 3
        PPRE = 4
        PPUT = 5
        TAXR = 6
        REVR = 7
        CLAI = 8
    }
    class ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.AmountAndQuantityRatio5 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.AmountAndQuantityRatio5 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountAndRateStatus2 {
        + RateSts  : String
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.AmountAndRateStatus2 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPrice4 {
        + PricVal  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev035002.AmountPrice4 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPrice5 {
        + PricVal  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev035002.AmountPrice5 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPrice7 {
        + PricVal  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev035002.AmountPrice7 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPricePerAmount3 {
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev035002.AmountPricePerAmount3 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.AmountPricePerAmount3 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11 {
        + FinInstrmQty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + PricVal  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev035002.AmountPriceType2Code {
        ACTU = 1
    }
    class ISO20022.Seev035002.AmountPriceType3Code {
        PLOT = 1
        ACTU = 2
    }
    class ISO20022.Seev035002.AmountToAmountRatio3 {
        + Amt2  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Amt1  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.AmountToAmountRatio3 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.AmountToAmountRatio3 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev035002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev035002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev035002.SignedQuantityFormat12
    }
    ISO20022.Seev035002.BalanceFormat14Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat14Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat14Choice *-- ISO20022.Seev035002.SignedQuantityFormat12
    class ISO20022.Seev035002.BalanceFormat16Choice {
        + PartWayPrdUnits  : ISO20022.Seev035002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev035002.SignedQuantityFormat13
        + NotElgblBal  : ISO20022.Seev035002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev035002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev035002.SignedQuantityFormat12
    }
    ISO20022.Seev035002.BalanceFormat16Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat16Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat16Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat16Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.BalanceFormat16Choice *-- ISO20022.Seev035002.SignedQuantityFormat12
    class ISO20022.Seev035002.BeneficiaryCertificationType14Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.BeneficiaryCertificationType14Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.BeneficiaryCertificationType6Code {
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
    class ISO20022.Seev035002.BlockChainAddressWallet11 {
        + Nm  : String
        + Tp  : ISO20022.Seev035002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Seev035002.BlockChainAddressWallet11 *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.BorrowerLendingDeadline6 {
        + Brrwr  : ISO20022.Seev035002.PartyIdentification136Choice
        + StockLndgDdln  : ISO20022.Seev035002.DateFormat49Choice
    }
    ISO20022.Seev035002.BorrowerLendingDeadline6 *-- ISO20022.Seev035002.PartyIdentification136Choice
    ISO20022.Seev035002.BorrowerLendingDeadline6 *-- ISO20022.Seev035002.DateFormat49Choice
    class ISO20022.Seev035002.CashAccountIdentification13Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev035002.BlockChainAddressWallet11
        + IBAN  : String
    }
    ISO20022.Seev035002.CashAccountIdentification13Choice *-- ISO20022.Seev035002.BlockChainAddressWallet11
    class ISO20022.Seev035002.CashOption111 {
        + PricDtls  : ISO20022.Seev035002.PriceDetails42
        + RateAndAmtDtls  : ISO20022.Seev035002.Rate46
        + FXDtls  : ISO20022.Seev035002.ForeignExchangeTerms42
        + DtDtls  : ISO20022.Seev035002.CorporateActionDate94
        + AmtDtls  : ISO20022.Seev035002.CorporateActionAmounts75
        + CshAcctId  : ISO20022.Seev035002.CashAccountIdentification13Choice
        + CtryOfIncmSrc  : String
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev035002.GenericIdentification47
        + IssrOfferrTaxbltyInd  : ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice
        + NonElgblPrcdsInd  : ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice
        + CtrctlPmtInd  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.PriceDetails42
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.Rate46
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.ForeignExchangeTerms42
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.CorporateActionDate94
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.CorporateActionAmounts75
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.CashAccountIdentification13Choice
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice
    ISO20022.Seev035002.CashOption111 *-- ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice
    class ISO20022.Seev035002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Seev035002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Seev035002.ClassificationType33Choice *-- ISO20022.Seev035002.GenericIdentification86
    class ISO20022.Seev035002.CorporateAction77 {
        + LtryTp  : ISO20022.Seev035002.LotteryTypeFormat5Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice~
        + EvtStag  : ISO20022.Seev035002.CorporateActionEventStageFormat15Choice
        + SctiesQty  : ISO20022.Seev035002.CorporateActionQuantity13
        + DtDtls  : ISO20022.Seev035002.CorporateActionDate93
    }
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.LotteryTypeFormat5Choice
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.CorporateActionEventStageFormat15Choice
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.CorporateActionQuantity13
    ISO20022.Seev035002.CorporateAction77 *-- ISO20022.Seev035002.CorporateActionDate93
    class ISO20022.Seev035002.CorporateActionAmounts61 {
        + ScndLvlTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev035002.CorporateActionAmounts61 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts61 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev035002.CorporateActionAmounts75 {
        + BuyUpAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + DmdRyltsAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + DmdIntrstAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + DmdFndAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + DmdDvddAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + FrgnIncmAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + DmdAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TxTax  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TaxOnIncmAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + BckUpWhldgTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + NRATaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + FATCATaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + EqulstnAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + IncmPrtn  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + EntitldAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ChrgsAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ScndLvlTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + ManfctrdDvddPmtAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + MktClmAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + GrssAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev035002.CorporateActionAmounts75 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev035002.CorporateActionBalanceDetails46 {
        + UafctdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + AfctdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + InstdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + UinstdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + OblgtdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + RegdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + InTrnsShipmntBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + TradDtPosBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + StrtPosBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + SttlmPosBal  : global::System.Collections.Generic.List~ISO20022.Seev035002.BalanceFormat16Choice~
        + OutForRegnBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev035002.BalanceFormat16Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev035002.BalanceFormat16Choice~
        + OnLnBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + CollOutBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + CollInBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + BrrwdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + BlckdBal  : ISO20022.Seev035002.BalanceFormat14Choice
        + TtlElgblBal  : ISO20022.Seev035002.TotalEligibleBalanceFormat11
    }
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat16Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat16Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat16Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.BalanceFormat14Choice
    ISO20022.Seev035002.CorporateActionBalanceDetails46 *-- ISO20022.Seev035002.TotalEligibleBalanceFormat11
    class ISO20022.Seev035002.CorporateActionDate107 {
        + DcmnttnDdln  : ISO20022.Seev035002.DateFormat49Choice
        + BrrwrStockLndgDdln  : global::System.Collections.Generic.List~ISO20022.Seev035002.BorrowerLendingDeadline6~
        + StockLndgDdln  : ISO20022.Seev035002.DateFormat49Choice
        + DpstryCoverXprtnDt  : ISO20022.Seev035002.DateFormat49Choice
        + SbcptCostDbtDt  : ISO20022.Seev035002.DateFormat49Choice
        + XpryDt  : ISO20022.Seev035002.DateFormat49Choice
        + RspnDdln  : ISO20022.Seev035002.DateFormat54Choice
        + MktDdln  : ISO20022.Seev035002.DateFormat49Choice
        + PrtctDdln  : ISO20022.Seev035002.DateFormat49Choice
        + CoverXprtnDdln  : ISO20022.Seev035002.DateFormat49Choice
        + EarlyRspnDdln  : ISO20022.Seev035002.DateFormat49Choice
    }
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.BorrowerLendingDeadline6
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat54Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate107 *-- ISO20022.Seev035002.DateFormat49Choice
    class ISO20022.Seev035002.CorporateActionDate93 {
        + LtryDt  : ISO20022.Seev035002.DateFormat41Choice
        + ExDvddDt  : ISO20022.Seev035002.DateFormat41Choice
        + RcrdDt  : ISO20022.Seev035002.DateFormat41Choice
    }
    ISO20022.Seev035002.CorporateActionDate93 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.CorporateActionDate93 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.CorporateActionDate93 *-- ISO20022.Seev035002.DateFormat41Choice
    class ISO20022.Seev035002.CorporateActionDate94 {
        + EarlstPmtDt  : ISO20022.Seev035002.DateFormat41Choice
        + FXRateFxgDt  : ISO20022.Seev035002.DateFormat49Choice
        + ValDt  : ISO20022.Seev035002.DateFormat64Choice
        + PmtDt  : ISO20022.Seev035002.DateFormat41Choice
    }
    ISO20022.Seev035002.CorporateActionDate94 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.CorporateActionDate94 *-- ISO20022.Seev035002.DateFormat49Choice
    ISO20022.Seev035002.CorporateActionDate94 *-- ISO20022.Seev035002.DateFormat64Choice
    ISO20022.Seev035002.CorporateActionDate94 *-- ISO20022.Seev035002.DateFormat41Choice
    class ISO20022.Seev035002.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev035002.CorporateActionEventProcessingType3Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionEventProcessingType3Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionEventReference4 {
        + LkgTp  : ISO20022.Seev035002.ProcessingPosition10Choice
        + EvtId  : ISO20022.Seev035002.CorporateActionEventReference4Choice
    }
    ISO20022.Seev035002.CorporateActionEventReference4 *-- ISO20022.Seev035002.ProcessingPosition10Choice
    ISO20022.Seev035002.CorporateActionEventReference4 *-- ISO20022.Seev035002.CorporateActionEventReference4Choice
    class ISO20022.Seev035002.CorporateActionEventReference4Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev035002.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev035002.CorporateActionEventStageFormat15Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionEventStageFormat15Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionEventType122Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionEventType122Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionEventType36Code {
        RCLA = 1
        TNDP = 2
        ACCU = 3
        WRTH = 4
        WTRC = 5
        EXWA = 6
        SUSP = 7
        DLST = 8
        TEND = 9
        TREC = 10
        SPLF = 11
        DVSE = 12
        SOFF = 13
        SMAL = 14
        SHPR = 15
        DVSC = 16
        RHTS = 17
        SPLR = 18
        BIDS = 19
        REMK = 20
        REDO = 21
        BPUT = 22
        PRIO = 23
        PDEF = 24
        PLAC = 25
        PINK = 26
        PRED = 27
        PCAL = 28
        PARI = 29
        OTHR = 30
        ODLT = 31
        CERT = 32
        NOOF = 33
        MRGR = 34
        EXTM = 35
        LIQU = 36
        RHDI = 37
        INTR = 38
        PPMT = 39
        INCR = 40
        MCAL = 41
        REDM = 42
        EXOF = 43
        DTCH = 44
        DRAW = 45
        DRIP = 46
        DVOP = 47
        DSCL = 48
        DETI = 49
        DECR = 50
        CREV = 51
        CONV = 52
        CONS = 53
        CLSA = 54
        COOP = 55
        CHAN = 56
        DVCA = 57
        DRCA = 58
        CAPI = 59
        CAPG = 60
        CAPD = 61
        EXRI = 62
        BONU = 63
        DFLT = 64
        BRUP = 65
        ATTI = 66
        ACTV = 67
    }
    class ISO20022.Seev035002.CorporateActionGeneralInformation192 {
        + UndrlygScty  : ISO20022.Seev035002.FinancialInstrumentAttributes134
        + MndtryVlntryEvtTp  : ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice
        + EvtTp  : ISO20022.Seev035002.CorporateActionEventType122Choice
        + EvtPrcgTp  : ISO20022.Seev035002.CorporateActionEventProcessingType3Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev035002.CorporateActionGeneralInformation192 *-- ISO20022.Seev035002.FinancialInstrumentAttributes134
    ISO20022.Seev035002.CorporateActionGeneralInformation192 *-- ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice
    ISO20022.Seev035002.CorporateActionGeneralInformation192 *-- ISO20022.Seev035002.CorporateActionEventType122Choice
    ISO20022.Seev035002.CorporateActionGeneralInformation192 *-- ISO20022.Seev035002.CorporateActionEventProcessingType3Choice
    class ISO20022.Seev035002.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev035002.SupplementaryData1~
        + TrfAgt  : ISO20022.Seev035002.PartyIdentification151Choice
        + Offerr  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification151Choice~
        + Issr  : ISO20022.Seev035002.PartyIdentification151Choice
        + InfAgt  : ISO20022.Seev035002.PartyIdentification137Choice
        + SlctnAgt  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification137Choice~
        + DrpAgt  : ISO20022.Seev035002.PartyIdentification137Choice
        + PhysSctiesAgt  : ISO20022.Seev035002.PartyIdentification137Choice
        + RsellngAgt  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification137Choice~
        + Regar  : ISO20022.Seev035002.PartyIdentification137Choice
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification137Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification137Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev035002.PartyIdentification151Choice~
        + AddtlInf  : ISO20022.Seev035002.CorporateActionNarrative62
        + CorpActnMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev035002.CorporateActionOption245~
        + CorpActnDtls  : ISO20022.Seev035002.CorporateAction77
        + AcctDtls  : ISO20022.Seev035002.AccountIdentification76Choice
        + CorpActnGnlInf  : ISO20022.Seev035002.CorporateActionGeneralInformation192
        + RvslRsn  : ISO20022.Seev035002.CorporateActionReversalReason9
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev035002.CorporateActionEventReference4~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev035002.DocumentIdentification38~
        + InstrId  : ISO20022.Seev035002.DocumentIdentification17
        + MvmntConfId  : ISO20022.Seev035002.DocumentIdentification37
        + NtfctnId  : ISO20022.Seev035002.DocumentIdentification37
        + PrvsMvmntPrlimryAdvcId  : ISO20022.Seev035002.DocumentIdentification37
        + MvmntPrlimryAdvcGnlInf  : ISO20022.Seev035002.CorporateActionPreliminaryAdviceType5
        + Pgntn  : ISO20022.Seev035002.Pagination1
    }
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.SupplementaryData1
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification151Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification151Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification151Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification137Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.PartyIdentification151Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionNarrative62
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionOption245
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateAction77
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.AccountIdentification76Choice
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionGeneralInformation192
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionReversalReason9
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionEventReference4
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.DocumentIdentification38
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.DocumentIdentification17
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.DocumentIdentification37
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.DocumentIdentification37
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.DocumentIdentification37
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.CorporateActionPreliminaryAdviceType5
    ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16 *-- ISO20022.Seev035002.Pagination1
    class ISO20022.Seev035002.CorporateActionMovementPreliminaryAdviceFunction1Code {
        CAPA = 1
        ENTL = 2
    }
    class ISO20022.Seev035002.CorporateActionNarrative61 {
        + CertfctnBrkdwn  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + Dsclmr  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + TaxtnConds  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + SctyRstrctn  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + InfToCmplyWth  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + InfConds  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + NrrtvVrsn  : ISO20022.Seev035002.UpdatedAdditionalInformation22
        + AddtlTxt  : ISO20022.Seev035002.UpdatedAdditionalInformation22
    }
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation22
    ISO20022.Seev035002.CorporateActionNarrative61 *-- ISO20022.Seev035002.UpdatedAdditionalInformation22
    class ISO20022.Seev035002.CorporateActionNarrative62 {
        + PrcgTxtForNxtIntrmy  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + CertfctnBrkdwn  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + BsktOrIndxInf  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + RegnDtls  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + PtyCtctNrrtv  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + Dsclmr  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + TaxtnConds  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + InfToCmplyWth  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + InfConds  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + NrrtvVrsn  : ISO20022.Seev035002.UpdatedAdditionalInformation23
        + AddtlTxt  : ISO20022.Seev035002.UpdatedAdditionalInformation23
    }
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    ISO20022.Seev035002.CorporateActionNarrative62 *-- ISO20022.Seev035002.UpdatedAdditionalInformation23
    class ISO20022.Seev035002.CorporateActionOption15Code {
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
    class ISO20022.Seev035002.CorporateActionOption245 {
        + AddtlInf  : ISO20022.Seev035002.CorporateActionNarrative61
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev035002.CashOption111~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev035002.SecuritiesOption116~
        + SctiesQty  : ISO20022.Seev035002.SecuritiesOption84
        + PricDtls  : ISO20022.Seev035002.CorporateActionPrice94
        + RateAndAmtDtls  : ISO20022.Seev035002.CorporateActionRate133
        + PrdDtls  : ISO20022.Seev035002.CorporateActionPeriod12
        + DtDtls  : ISO20022.Seev035002.CorporateActionDate107
        + SctyId  : ISO20022.Seev035002.SecurityIdentification20
        + ApldOptnInd  : String
        + ChngAllwdInd  : String
        + WdrwlAllwdInd  : String
        + CertfctnBrkdwnInd  : String
        + AccptncPrtyLvl  : String
        + ChrgsApldInd  : String
        + DfltPrcgOrStgInstr  : ISO20022.Seev035002.DefaultProcessingOrStandingInstruction2Choice
        + CcyOptn  : String
        + VldDmclCtry  : global::System.Collections.Generic.List~String~
        + NonDmclCtry  : global::System.Collections.Generic.List~String~
        + CertfctnBrkdwnTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.BeneficiaryCertificationType14Choice~
        + OptnAvlbtySts  : ISO20022.Seev035002.OptionAvailabilityStatus4Choice
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev035002.OptionFeaturesFormat31Choice~
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.OfferTypeFormat15Choice~
        + FrctnDspstn  : ISO20022.Seev035002.FractionDispositionType31Choice
        + OptnTp  : ISO20022.Seev035002.CorporateActionOption46Choice
        + OptnNb  : String
    }
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionNarrative61
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CashOption111
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.SecuritiesOption116
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.SecuritiesOption84
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionPrice94
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionRate133
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionPeriod12
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionDate107
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.SecurityIdentification20
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.DefaultProcessingOrStandingInstruction2Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.BeneficiaryCertificationType14Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.OptionAvailabilityStatus4Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.OptionFeaturesFormat31Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.OfferTypeFormat15Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.FractionDispositionType31Choice
    ISO20022.Seev035002.CorporateActionOption245 *-- ISO20022.Seev035002.CorporateActionOption46Choice
    class ISO20022.Seev035002.CorporateActionOption46Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionOption46Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionPeriod12 {
        + DpstrySspnsnPrdForWdrwl  : ISO20022.Seev035002.Period6Choice
        + AcctSvcrRvcbltyPrd  : ISO20022.Seev035002.Period6Choice
        + PrvlgSspnsnPrd  : ISO20022.Seev035002.Period6Choice
        + RvcbltyPrd  : ISO20022.Seev035002.Period6Choice
        + ActnPrd  : ISO20022.Seev035002.Period6Choice
        + ParllTradgPrd  : ISO20022.Seev035002.Period6Choice
        + PricClctnPrd  : ISO20022.Seev035002.Period6Choice
    }
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.CorporateActionPeriod12 *-- ISO20022.Seev035002.Period6Choice
    class ISO20022.Seev035002.CorporateActionPreliminaryAdviceType1Code {
        REPL = 1
        NEWM = 2
    }
    class ISO20022.Seev035002.CorporateActionPreliminaryAdviceType5 {
        + Fctn  : String
        + Tp  : String
        + MvmntPrlimryAdvcId  : String
    }
    class ISO20022.Seev035002.CorporateActionPrice94 {
        + MinMltplCshToInst  : ISO20022.Seev035002.PriceFormat62Choice
        + MinCshToInst  : ISO20022.Seev035002.PriceFormat62Choice
        + MaxCshToInst  : ISO20022.Seev035002.PriceFormat62Choice
        + OverSbcptDpstPric  : ISO20022.Seev035002.PriceFormat88Choice
        + CshInLieuOfShrPric  : ISO20022.Seev035002.PriceFormat88Choice
    }
    ISO20022.Seev035002.CorporateActionPrice94 *-- ISO20022.Seev035002.PriceFormat62Choice
    ISO20022.Seev035002.CorporateActionPrice94 *-- ISO20022.Seev035002.PriceFormat62Choice
    ISO20022.Seev035002.CorporateActionPrice94 *-- ISO20022.Seev035002.PriceFormat62Choice
    ISO20022.Seev035002.CorporateActionPrice94 *-- ISO20022.Seev035002.PriceFormat88Choice
    ISO20022.Seev035002.CorporateActionPrice94 *-- ISO20022.Seev035002.PriceFormat88Choice
    class ISO20022.Seev035002.CorporateActionPrice95 {
        + GncCshPricRcvdPerPdct  : ISO20022.Seev035002.PriceFormat90Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev035002.PriceFormat89Choice
        + CshValForTax  : ISO20022.Seev035002.PriceFormat58Choice
        + CshInLieuOfShrPric  : ISO20022.Seev035002.PriceFormat88Choice
        + IndctvOrMktPric  : ISO20022.Seev035002.IndicativeOrMarketPrice17Choice
    }
    ISO20022.Seev035002.CorporateActionPrice95 *-- ISO20022.Seev035002.PriceFormat90Choice
    ISO20022.Seev035002.CorporateActionPrice95 *-- ISO20022.Seev035002.PriceFormat89Choice
    ISO20022.Seev035002.CorporateActionPrice95 *-- ISO20022.Seev035002.PriceFormat58Choice
    ISO20022.Seev035002.CorporateActionPrice95 *-- ISO20022.Seev035002.PriceFormat88Choice
    ISO20022.Seev035002.CorporateActionPrice95 *-- ISO20022.Seev035002.IndicativeOrMarketPrice17Choice
    class ISO20022.Seev035002.CorporateActionQuantity13 {
        + IncrmtlDnmtn  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + BaseDnmtn  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    }
    ISO20022.Seev035002.CorporateActionQuantity13 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.CorporateActionQuantity13 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    class ISO20022.Seev035002.CorporateActionRate133 {
        + TaxOnIncm  : ISO20022.Seev035002.RateAndAmountFormat69Choice
        + TaxblIncmPerDvddShr  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateTypeAndAmountAndStatus33~
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + PrratnRate  : ISO20022.Seev035002.RateFormat24Choice
        + MaxAllwdOvrsbcptRate  : ISO20022.Seev035002.RateFormat24Choice
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice~
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.NetDividendRateFormat43Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.GrossDividendRateFormat41Choice~
        + AddtlTax  : ISO20022.Seev035002.RateAndAmountFormat69Choice
    }
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateTypeAndAmountAndStatus33
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.NetDividendRateFormat43Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.GrossDividendRateFormat41Choice
    ISO20022.Seev035002.CorporateActionRate133 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    class ISO20022.Seev035002.CorporateActionRate134 {
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + FinTxTaxRate  : ISO20022.Seev035002.RateFormat24Choice
        + TaxCdtRate  : ISO20022.Seev035002.RateFormat29Choice
        + AplblRate  : ISO20022.Seev035002.RateFormat24Choice
        + FsclStmp  : ISO20022.Seev035002.RateFormat24Choice
        + ChrgsFees  : ISO20022.Seev035002.RateAndAmountFormat69Choice
        + TrfrmatnRate  : Decimal
        + NewToOd  : ISO20022.Seev035002.RatioFormat24Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev035002.RatioFormat23Choice
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev035002.RatioFormat23Choice
    }
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateFormat29Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RatioFormat24Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RatioFormat23Choice
    ISO20022.Seev035002.CorporateActionRate134 *-- ISO20022.Seev035002.RatioFormat23Choice
    class ISO20022.Seev035002.CorporateActionReversalReason11Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.CorporateActionReversalReason11Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.CorporateActionReversalReason3Code {
        OTHR = 1
        UPAY = 2
        IVAD = 3
        IPRI = 4
        IPCU = 5
        IETR = 6
        IRED = 7
        FNRC = 8
        DCBD = 9
    }
    class ISO20022.Seev035002.CorporateActionReversalReason9 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev035002.CorporateActionReversalReason11Choice
    }
    ISO20022.Seev035002.CorporateActionReversalReason9 *-- ISO20022.Seev035002.CorporateActionReversalReason11Choice
    class ISO20022.Seev035002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev035002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev035002.DateCode22Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.DateCode22Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.DateCode26Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.DateCode26Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.DateCode27Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.DateCode27Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.DateCodeAndTimeFormat4 {
        + Tm  : DateTime
        + DtCd  : ISO20022.Seev035002.DateCode26Choice
    }
    ISO20022.Seev035002.DateCodeAndTimeFormat4 *-- ISO20022.Seev035002.DateCode26Choice
    class ISO20022.Seev035002.DateFormat41Choice {
        + DtCd  : ISO20022.Seev035002.DateCode22Choice
        + Dt  : DateTime
    }
    ISO20022.Seev035002.DateFormat41Choice *-- ISO20022.Seev035002.DateCode22Choice
    class ISO20022.Seev035002.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev035002.DateAndDateTime2Choice
    }
    ISO20022.Seev035002.DateFormat45Choice *-- ISO20022.Seev035002.DateAndDateTime2Choice
    class ISO20022.Seev035002.DateFormat49Choice {
        + DtCd  : ISO20022.Seev035002.DateCode22Choice
        + Dt  : ISO20022.Seev035002.DateAndDateTime2Choice
    }
    ISO20022.Seev035002.DateFormat49Choice *-- ISO20022.Seev035002.DateCode22Choice
    ISO20022.Seev035002.DateFormat49Choice *-- ISO20022.Seev035002.DateAndDateTime2Choice
    class ISO20022.Seev035002.DateFormat54Choice {
        + DtCd  : ISO20022.Seev035002.DateCode22Choice
        + DtCdAndTm  : ISO20022.Seev035002.DateCodeAndTimeFormat4
        + Dt  : ISO20022.Seev035002.DateAndDateTime2Choice
    }
    ISO20022.Seev035002.DateFormat54Choice *-- ISO20022.Seev035002.DateCode22Choice
    ISO20022.Seev035002.DateFormat54Choice *-- ISO20022.Seev035002.DateCodeAndTimeFormat4
    ISO20022.Seev035002.DateFormat54Choice *-- ISO20022.Seev035002.DateAndDateTime2Choice
    class ISO20022.Seev035002.DateFormat64Choice {
        + DtCd  : ISO20022.Seev035002.DateCode27Choice
        + Dt  : DateTime
    }
    ISO20022.Seev035002.DateFormat64Choice *-- ISO20022.Seev035002.DateCode27Choice
    class ISO20022.Seev035002.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev035002.DateType7Code {
        ONGO = 1
    }
    class ISO20022.Seev035002.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev035002.DeemedRateType1Code {
        DERY = 1
        DEIT = 2
        DEFP = 3
        DEDI = 4
    }
    class ISO20022.Seev035002.DeemedRateType2Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.DeemedRateType2Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.DefaultProcessingOrStandingInstruction2Choice {
        + StgInstrInd  : String
        + DfltOptnInd  : String
    }
    class ISO20022.Seev035002.DividendRateType1Code {
        TXBL = 1
    }
    class ISO20022.Seev035002.DocumentIdentification17 {
        + Id  : String
    }
    class ISO20022.Seev035002.DocumentIdentification37 {
        + LkgTp  : ISO20022.Seev035002.ProcessingPosition10Choice
        + Id  : String
    }
    ISO20022.Seev035002.DocumentIdentification37 *-- ISO20022.Seev035002.ProcessingPosition10Choice
    class ISO20022.Seev035002.DocumentIdentification38 {
        + LkgTp  : ISO20022.Seev035002.ProcessingPosition10Choice
        + DocNb  : ISO20022.Seev035002.DocumentNumber6Choice
        + Id  : ISO20022.Seev035002.DocumentIdentification4Choice
    }
    ISO20022.Seev035002.DocumentIdentification38 *-- ISO20022.Seev035002.ProcessingPosition10Choice
    ISO20022.Seev035002.DocumentIdentification38 *-- ISO20022.Seev035002.DocumentNumber6Choice
    ISO20022.Seev035002.DocumentIdentification38 *-- ISO20022.Seev035002.DocumentIdentification4Choice
    class ISO20022.Seev035002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev035002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev035002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev035002.DocumentNumber6Choice *-- ISO20022.Seev035002.GenericIdentification86
    class ISO20022.Seev035002.FinancialInstrumentAttributes134 {
        + CtrctSz  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + WarrtParity  : ISO20022.Seev035002.QuantityToQuantityRatio2
        + NxtFctr  : ISO20022.Seev035002.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev035002.RateFormat12Choice
        + PctgOfDebtClm  : ISO20022.Seev035002.RateFormat24Choice
        + NxtIntrstRate  : ISO20022.Seev035002.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev035002.RateFormat24Choice
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
        + OptnStyle  : ISO20022.Seev035002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Seev035002.ClassificationType33Choice
        + DayCntBsis  : ISO20022.Seev035002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Seev035002.MarketIdentification4Choice
        + FinInstrmId  : ISO20022.Seev035002.SecurityIdentification20
    }
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.QuantityToQuantityRatio2
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.RateFormat12Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.RateFormat12Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.OptionStyle9Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.ClassificationType33Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.InterestComputationMethodFormat5Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.MarketIdentification4Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes134 *-- ISO20022.Seev035002.SecurityIdentification20
    class ISO20022.Seev035002.FinancialInstrumentAttributes135 {
        + IssePric  : ISO20022.Seev035002.PriceFormat88Choice
        + CtrctSz  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + MinMltplQtyToInst  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + MinQtyToInst  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + NxtIntrstRate  : ISO20022.Seev035002.RateFormat24Choice
        + IntrstRate  : ISO20022.Seev035002.RateFormat24Choice
        + NxtFctr  : ISO20022.Seev035002.RateFormat12Choice
        + PrvsFctr  : ISO20022.Seev035002.RateFormat12Choice
        + ConvsDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + NxtCpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnStyle  : ISO20022.Seev035002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Seev035002.ClassificationType33Choice
        + DayCntBsis  : ISO20022.Seev035002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Seev035002.MarketIdentification4Choice
        + FinInstrmId  : ISO20022.Seev035002.SecurityIdentification20
    }
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.PriceFormat88Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.RateFormat12Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.RateFormat12Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.OptionStyle9Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.ClassificationType33Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.InterestComputationMethodFormat5Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.MarketIdentification4Choice
    ISO20022.Seev035002.FinancialInstrumentAttributes135 *-- ISO20022.Seev035002.SecurityIdentification20
    class ISO20022.Seev035002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev035002.FinancialInstrumentQuantity43Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev035002.FinancialInstrumentQuantity44Choice {
        + DgtlTknUnit  : Decimal
        + Cd  : String
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev035002.ForeignExchangeTerms42 {
        + RsltgAmt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev035002.ForeignExchangeTerms42 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev035002.FractionDispositionType31Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.FractionDispositionType31Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.FractionDispositionType8Code {
        UKWN = 1
        RDUP = 2
        STAN = 3
        RDDN = 4
        DIST = 5
        CINL = 6
        BUYU = 7
    }
    class ISO20022.Seev035002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev035002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev035002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev035002.GenericIdentification47
    }
    ISO20022.Seev035002.GenericIdentification85 *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev035002.GrossDividendRateFormat41Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev035002.RateTypeAndAmountAndStatus59
        + AmtAndRateSts  : ISO20022.Seev035002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.GrossDividendRateFormat41Choice *-- ISO20022.Seev035002.RateTypeAndAmountAndStatus59
    ISO20022.Seev035002.GrossDividendRateFormat41Choice *-- ISO20022.Seev035002.AmountAndRateStatus2
    ISO20022.Seev035002.GrossDividendRateFormat41Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.GrossDividendRateType6Code {
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
    class ISO20022.Seev035002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev035002.IndicativeOrMarketPrice17Choice {
        + MktPric  : ISO20022.Seev035002.PriceFormat88Choice
        + IndctvPric  : ISO20022.Seev035002.PriceFormat88Choice
    }
    ISO20022.Seev035002.IndicativeOrMarketPrice17Choice *-- ISO20022.Seev035002.PriceFormat88Choice
    ISO20022.Seev035002.IndicativeOrMarketPrice17Choice *-- ISO20022.Seev035002.PriceFormat88Choice
    class ISO20022.Seev035002.InterestComputationMethod2Code {
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
    class ISO20022.Seev035002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.InterestComputationMethodFormat5Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev035002.RateTypeAndAmountAndStatus32
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice *-- ISO20022.Seev035002.RateTypeAndAmountAndStatus32
    ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.IntermediateSecurityDistributionType5Code {
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
    class ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.IssuerTaxability2Code {
        TXBL = 1
    }
    class ISO20022.Seev035002.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev035002.LotteryTypeFormat5Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.LotteryTypeFormat5Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev035002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Seev035002.NetDividendRateFormat43Choice {
        + NotSpcfdRate  : String
        + RateTpAndAmtAndRateSts  : ISO20022.Seev035002.RateTypeAndAmountAndStatus60
        + AmtAndRateSts  : ISO20022.Seev035002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.NetDividendRateFormat43Choice *-- ISO20022.Seev035002.RateTypeAndAmountAndStatus60
    ISO20022.Seev035002.NetDividendRateFormat43Choice *-- ISO20022.Seev035002.AmountAndRateStatus2
    ISO20022.Seev035002.NetDividendRateFormat43Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.NetDividendRateType6Code {
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
    class ISO20022.Seev035002.NewSecuritiesIssuanceType5Code {
        REFU = 1
        NREF = 2
        UKWN = 3
        NDEF = 4
        NEIS = 5
        EXIS = 6
        DEFE = 7
    }
    class ISO20022.Seev035002.NonEligibleProceedsIndicator1Code {
        ONEL = 1
        ACLI = 2
        NELC = 3
    }
    class ISO20022.Seev035002.NonEligibleProceedsIndicator2Code {
        NELS = 1
        ONEL = 2
        ACLI = 3
        NELC = 4
    }
    class ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.OfferType5Code {
        ACPR = 1
        SQUE = 2
        ERUN = 3
        PART = 4
        FCFS = 5
        FINL = 6
        NDIS = 7
        DISS = 8
    }
    class ISO20022.Seev035002.OfferTypeFormat15Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.OfferTypeFormat15Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.OptionAvailabilityStatus1Code {
        CANC = 1
        INTV = 2
    }
    class ISO20022.Seev035002.OptionAvailabilityStatus4Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.OptionAvailabilityStatus4Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.OptionFeatures13Code {
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
    class ISO20022.Seev035002.OptionFeaturesFormat31Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.OptionFeaturesFormat31Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Seev035002.OptionStyle9Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.OptionStyle9Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev035002.OriginalAndCurrentQuantities7 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev035002.OtherIdentification2 {
        + Tp  : ISO20022.Seev035002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev035002.OtherIdentification2 *-- ISO20022.Seev035002.IdentificationSource4Choice
    class ISO20022.Seev035002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev035002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev035002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev035002.PartyIdentification136Choice *-- ISO20022.Seev035002.GenericIdentification84
    class ISO20022.Seev035002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Seev035002.NameAndAddress12
        + PrtryId  : ISO20022.Seev035002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev035002.PartyIdentification137Choice *-- ISO20022.Seev035002.NameAndAddress12
    ISO20022.Seev035002.PartyIdentification137Choice *-- ISO20022.Seev035002.GenericIdentification84
    class ISO20022.Seev035002.PartyIdentification151Choice {
        + LEI  : String
        + NmAndAdr  : ISO20022.Seev035002.NameAndAddress12
        + PrtryId  : ISO20022.Seev035002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev035002.PartyIdentification151Choice *-- ISO20022.Seev035002.NameAndAddress12
    ISO20022.Seev035002.PartyIdentification151Choice *-- ISO20022.Seev035002.GenericIdentification84
    class ISO20022.Seev035002.Payment1Code {
        CONT = 1
        ACTU = 2
    }
    class ISO20022.Seev035002.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev035002.Period11 {
        + EndDt  : ISO20022.Seev035002.DateFormat45Choice
        + StartDt  : ISO20022.Seev035002.DateFormat45Choice
    }
    ISO20022.Seev035002.Period11 *-- ISO20022.Seev035002.DateFormat45Choice
    ISO20022.Seev035002.Period11 *-- ISO20022.Seev035002.DateFormat45Choice
    class ISO20022.Seev035002.Period6Choice {
        + PrdCd  : String
        + Prd  : ISO20022.Seev035002.Period11
    }
    ISO20022.Seev035002.Period6Choice *-- ISO20022.Seev035002.Period11
    class ISO20022.Seev035002.PriceDetails42 {
        + CshInLieuOfShrPric  : ISO20022.Seev035002.PriceFormat88Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev035002.PriceFormat90Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev035002.PriceFormat89Choice
    }
    ISO20022.Seev035002.PriceDetails42 *-- ISO20022.Seev035002.PriceFormat88Choice
    ISO20022.Seev035002.PriceDetails42 *-- ISO20022.Seev035002.PriceFormat90Choice
    ISO20022.Seev035002.PriceDetails42 *-- ISO20022.Seev035002.PriceFormat89Choice
    class ISO20022.Seev035002.PriceFormat58Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev035002.AmountPrice4
    }
    ISO20022.Seev035002.PriceFormat58Choice *-- ISO20022.Seev035002.AmountPrice4
    class ISO20022.Seev035002.PriceFormat62Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev035002.AmountPrice7
    }
    ISO20022.Seev035002.PriceFormat62Choice *-- ISO20022.Seev035002.AmountPrice7
    class ISO20022.Seev035002.PriceFormat88Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev035002.AmountPrice5
        + PctgPric  : ISO20022.Seev035002.PercentagePrice2
    }
    ISO20022.Seev035002.PriceFormat88Choice *-- ISO20022.Seev035002.AmountPrice5
    ISO20022.Seev035002.PriceFormat88Choice *-- ISO20022.Seev035002.PercentagePrice2
    class ISO20022.Seev035002.PriceFormat89Choice {
        + IndxPts  : Decimal
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev035002.AmountPrice5
        + PctgPric  : ISO20022.Seev035002.PercentagePrice2
    }
    ISO20022.Seev035002.PriceFormat89Choice *-- ISO20022.Seev035002.AmountPrice5
    ISO20022.Seev035002.PriceFormat89Choice *-- ISO20022.Seev035002.PercentagePrice2
    class ISO20022.Seev035002.PriceFormat90Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev035002.AmountPricePerAmount3
        + AmtPricPerFinInstrmQty  : ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev035002.AmountPrice5
        + PctgPric  : ISO20022.Seev035002.PercentagePrice2
    }
    ISO20022.Seev035002.PriceFormat90Choice *-- ISO20022.Seev035002.AmountPricePerAmount3
    ISO20022.Seev035002.PriceFormat90Choice *-- ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11
    ISO20022.Seev035002.PriceFormat90Choice *-- ISO20022.Seev035002.AmountPrice5
    ISO20022.Seev035002.PriceFormat90Choice *-- ISO20022.Seev035002.PercentagePrice2
    class ISO20022.Seev035002.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev035002.PriceValueType10Code {
        UKWN = 1
    }
    class ISO20022.Seev035002.PriceValueType8Code {
        NILP = 1
        UKWN = 2
        UNSP = 3
        TBSP = 4
    }
    class ISO20022.Seev035002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.ProcessingPosition10Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev035002.ProprietaryQuantity10 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev035002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev035002.Quantity4Code {
        ANYA = 1
        UKWN = 2
    }
    class ISO20022.Seev035002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev035002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev035002.Quantity53Choice *-- ISO20022.Seev035002.ProprietaryQuantity9
    ISO20022.Seev035002.Quantity53Choice *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev035002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Seev035002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev035002.Quantity54Choice *-- ISO20022.Seev035002.OriginalAndCurrentQuantities4
    ISO20022.Seev035002.Quantity54Choice *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev035002.Quantity57Choice {
        + SgndQty  : ISO20022.Seev035002.SignedQuantityFormat13
        + OrgnlAndCurFaceAmt  : ISO20022.Seev035002.OriginalAndCurrentQuantities7
    }
    ISO20022.Seev035002.Quantity57Choice *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.Quantity57Choice *-- ISO20022.Seev035002.OriginalAndCurrentQuantities7
    class ISO20022.Seev035002.Quantity5Code {
        UKWN = 1
    }
    class ISO20022.Seev035002.Quantity80Choice {
        + PrtryQty  : ISO20022.Seev035002.ProprietaryQuantity10
        + QtyChc  : ISO20022.Seev035002.Quantity57Choice
    }
    ISO20022.Seev035002.Quantity80Choice *-- ISO20022.Seev035002.ProprietaryQuantity10
    ISO20022.Seev035002.Quantity80Choice *-- ISO20022.Seev035002.Quantity57Choice
    class ISO20022.Seev035002.QuantityToQuantityRatio2 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev035002.Rate46 {
        + DmdRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat71Choice~
        + EqulstnRate  : ISO20022.Seev035002.RateAndAmountFormat48Choice
        + TaxRclmRate  : ISO20022.Seev035002.RateFormat24Choice
        + TaxOnPrfts  : ISO20022.Seev035002.RateFormat24Choice
        + TaxOnIncm  : ISO20022.Seev035002.RateAndAmountFormat69Choice
        + TaxCdtRate  : ISO20022.Seev035002.RateFormat29Choice
        + SlctnFeeRate  : ISO20022.Seev035002.SolicitationFeeRateFormat14Choice
        + AplblRate  : ISO20022.Seev035002.RateFormat24Choice
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.NetDividendRateFormat43Choice~
        + ThrdPtyIncntivRate  : ISO20022.Seev035002.RateFormat29Choice
        + FsclStmp  : ISO20022.Seev035002.RateFormat24Choice
        + EarlySlctnFeeRate  : ISO20022.Seev035002.SolicitationFeeRateFormat14Choice
        + ChrgsFees  : ISO20022.Seev035002.RateAndAmountFormat69Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.RateAndAmountFormat70Choice~
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev035002.GrossDividendRateFormat41Choice~
        + AddtlTax  : ISO20022.Seev035002.RateAndAmountFormat69Choice
    }
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat71Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat48Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat29Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.SolicitationFeeRateFormat14Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.NetDividendRateFormat43Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat29Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateFormat24Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.SolicitationFeeRateFormat14Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat70Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.GrossDividendRateFormat41Choice
    ISO20022.Seev035002.Rate46 *-- ISO20022.Seev035002.RateAndAmountFormat69Choice
    class ISO20022.Seev035002.RateAndAmountFormat48Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev035002.RateAndAmountFormat48Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.RateAndAmountFormat69Choice {
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev035002.RateAndAmountFormat69Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.RateAndAmountFormat70Choice {
        + RateTpAndRate  : ISO20022.Seev035002.RateTypeAndPercentageRate18
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev035002.RateAndAmountFormat70Choice *-- ISO20022.Seev035002.RateTypeAndPercentageRate18
    ISO20022.Seev035002.RateAndAmountFormat70Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.RateAndAmountFormat71Choice {
        + RateTpAndRate  : ISO20022.Seev035002.RateTypeAndPercentageRate19
        + RateTpAndAmtAndRateSts  : ISO20022.Seev035002.RateTypeAndAmountAndStatus54
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev035002.RateAndAmountFormat71Choice *-- ISO20022.Seev035002.RateTypeAndPercentageRate19
    ISO20022.Seev035002.RateAndAmountFormat71Choice *-- ISO20022.Seev035002.RateTypeAndAmountAndStatus54
    ISO20022.Seev035002.RateAndAmountFormat71Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.RateFormat12Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev035002.RateFormat24Choice {
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    class ISO20022.Seev035002.RateFormat29Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev035002.RateFormat29Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev035002.RateStatus1Code {
        INDI = 1
        ACTU = 2
    }
    class ISO20022.Seev035002.RateStatus4Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateStatus4Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateType13Code {
        NILP = 1
        UKWN = 2
    }
    class ISO20022.Seev035002.RateType45Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateType45Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateType46Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateType46Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateType47Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateType47Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateType5Code {
        UKWN = 1
    }
    class ISO20022.Seev035002.RateType7Code {
        USCD = 1
        SCHD = 2
    }
    class ISO20022.Seev035002.RateType80Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateType80Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateType81Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev035002.RateType81Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.RateTypeAndAmountAndStatus32 {
        + RateSts  : ISO20022.Seev035002.RateStatus4Choice
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev035002.RateType45Choice
    }
    ISO20022.Seev035002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev035002.RateStatus4Choice
    ISO20022.Seev035002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev035002.RateType45Choice
    class ISO20022.Seev035002.RateTypeAndAmountAndStatus33 {
        + RateSts  : ISO20022.Seev035002.RateStatus4Choice
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev035002.RateType47Choice
    }
    ISO20022.Seev035002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev035002.RateStatus4Choice
    ISO20022.Seev035002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev035002.RateType47Choice
    class ISO20022.Seev035002.RateTypeAndAmountAndStatus54 {
        + RateSts  : ISO20022.Seev035002.RateStatus4Choice
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev035002.DeemedRateType2Choice
    }
    ISO20022.Seev035002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev035002.RateStatus4Choice
    ISO20022.Seev035002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev035002.DeemedRateType2Choice
    class ISO20022.Seev035002.RateTypeAndAmountAndStatus59 {
        + RateSts  : ISO20022.Seev035002.RateStatus4Choice
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev035002.RateType80Choice
    }
    ISO20022.Seev035002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev035002.RateStatus4Choice
    ISO20022.Seev035002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev035002.RateType80Choice
    class ISO20022.Seev035002.RateTypeAndAmountAndStatus60 {
        + RateSts  : ISO20022.Seev035002.RateStatus4Choice
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev035002.RateType81Choice
    }
    ISO20022.Seev035002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev035002.RateStatus4Choice
    ISO20022.Seev035002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev035002.RateType81Choice
    class ISO20022.Seev035002.RateTypeAndPercentageRate18 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev035002.RateType46Choice
    }
    ISO20022.Seev035002.RateTypeAndPercentageRate18 *-- ISO20022.Seev035002.RateType46Choice
    class ISO20022.Seev035002.RateTypeAndPercentageRate19 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev035002.DeemedRateType2Choice
    }
    ISO20022.Seev035002.RateTypeAndPercentageRate19 *-- ISO20022.Seev035002.DeemedRateType2Choice
    class ISO20022.Seev035002.RateValueType7Code {
        UKWN = 1
    }
    class ISO20022.Seev035002.RatioFormat23Choice {
        + AmtToAmt  : ISO20022.Seev035002.AmountToAmountRatio3
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev035002.QuantityToQuantityRatio2
    }
    ISO20022.Seev035002.RatioFormat23Choice *-- ISO20022.Seev035002.AmountToAmountRatio3
    ISO20022.Seev035002.RatioFormat23Choice *-- ISO20022.Seev035002.QuantityToQuantityRatio2
    class ISO20022.Seev035002.RatioFormat24Choice {
        + QtyToAmt  : ISO20022.Seev035002.AmountAndQuantityRatio5
        + AmtToQty  : ISO20022.Seev035002.AmountAndQuantityRatio5
        + AmtToAmt  : ISO20022.Seev035002.AmountToAmountRatio3
        + NotSpcfdRate  : String
        + QtyToQty  : ISO20022.Seev035002.QuantityToQuantityRatio2
    }
    ISO20022.Seev035002.RatioFormat24Choice *-- ISO20022.Seev035002.AmountAndQuantityRatio5
    ISO20022.Seev035002.RatioFormat24Choice *-- ISO20022.Seev035002.AmountAndQuantityRatio5
    ISO20022.Seev035002.RatioFormat24Choice *-- ISO20022.Seev035002.AmountToAmountRatio3
    ISO20022.Seev035002.RatioFormat24Choice *-- ISO20022.Seev035002.QuantityToQuantityRatio2
    class ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev035002.SafekeepingAccountIdentification1Code {
        GENR = 1
    }
    class ISO20022.Seev035002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev035002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev035002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Seev035002.SafekeepingPlaceFormat52Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification85
        + TpAndId  : ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev035002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev035002.SafekeepingPlaceFormat52Choice *-- ISO20022.Seev035002.GenericIdentification85
    ISO20022.Seev035002.SafekeepingPlaceFormat52Choice *-- ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev035002.SafekeepingPlaceFormat52Choice *-- ISO20022.Seev035002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev035002.SafekeepingPlaceFormat53Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification85
        + TpAndId  : ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev035002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Seev035002.SafekeepingPlaceFormat53Choice *-- ISO20022.Seev035002.GenericIdentification85
    ISO20022.Seev035002.SafekeepingPlaceFormat53Choice *-- ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev035002.SafekeepingPlaceFormat53Choice *-- ISO20022.Seev035002.SafekeepingPlaceTypeAndText15
    class ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev035002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev035002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev035002.SecuritiesOption116 {
        + AmtDtls  : ISO20022.Seev035002.CorporateActionAmounts61
        + PricDtls  : ISO20022.Seev035002.CorporateActionPrice95
        + RateDtls  : ISO20022.Seev035002.CorporateActionRate134
        + DtDtls  : ISO20022.Seev035002.SecurityDate23
        + TradgPrd  : ISO20022.Seev035002.Period6Choice
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev035002.FractionDispositionType31Choice
        + CtryOfIncmSrc  : String
        + SfkpgPlc  : ISO20022.Seev035002.SafekeepingPlaceFormat53Choice
        + EntitldQty  : ISO20022.Seev035002.Quantity54Choice
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev035002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev035002.GenericIdentification47
        + NewSctiesIssncInd  : String
        + IssrOfferrTaxbltyInd  : ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice
        + NonElgblPrcdsInd  : ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice
        + TempFinInstrmInd  : ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice
        + CdtDbtInd  : String
        + SctyDtls  : ISO20022.Seev035002.FinancialInstrumentAttributes135
    }
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.CorporateActionAmounts61
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.CorporateActionPrice95
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.CorporateActionRate134
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.SecurityDate23
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.Period6Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.FractionDispositionType31Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.SafekeepingPlaceFormat53Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.Quantity54Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.GenericIdentification47
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice
    ISO20022.Seev035002.SecuritiesOption116 *-- ISO20022.Seev035002.FinancialInstrumentAttributes135
    class ISO20022.Seev035002.SecuritiesOption84 {
        + BckEndOddLotQty  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + FrntEndOddLotQty  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + NewDnmtnQty  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + NewBrdLotQty  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + MinMltplQtyToInst  : ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
        + MinQtyToInst  : ISO20022.Seev035002.FinancialInstrumentQuantity44Choice
        + MaxQtyToInst  : ISO20022.Seev035002.FinancialInstrumentQuantity44Choice
    }
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity43Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity44Choice
    ISO20022.Seev035002.SecuritiesOption84 *-- ISO20022.Seev035002.FinancialInstrumentQuantity44Choice
    class ISO20022.Seev035002.SecurityDate23 {
        + LastTradgDt  : ISO20022.Seev035002.DateFormat41Choice
        + PrpssDt  : ISO20022.Seev035002.DateFormat41Choice
        + EarlstPmtDt  : ISO20022.Seev035002.DateFormat41Choice
        + DvddRnkgDt  : ISO20022.Seev035002.DateFormat41Choice
        + AvlblDt  : ISO20022.Seev035002.DateFormat41Choice
        + PmtDt  : ISO20022.Seev035002.DateFormat41Choice
    }
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    ISO20022.Seev035002.SecurityDate23 *-- ISO20022.Seev035002.DateFormat41Choice
    class ISO20022.Seev035002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev035002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev035002.SecurityIdentification20 *-- ISO20022.Seev035002.OtherIdentification2
    class ISO20022.Seev035002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev035002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev035002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev035002.SignedQuantityFormat12 *-- ISO20022.Seev035002.Quantity53Choice
    class ISO20022.Seev035002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev035002.SignedQuantityFormat13 *-- ISO20022.Seev035002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev035002.SolicitationFeeRateFormat14Choice {
        + NotSpcfdRate  : String
        + Amt  : ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtToQty  : ISO20022.Seev035002.AmountAndQuantityRatio5
        + Rate  : Decimal
    }
    ISO20022.Seev035002.SolicitationFeeRateFormat14Choice *-- ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev035002.SolicitationFeeRateFormat14Choice *-- ISO20022.Seev035002.AmountAndQuantityRatio5
    class ISO20022.Seev035002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev035002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev035002.SupplementaryData1 *-- ISO20022.Seev035002.SupplementaryDataEnvelope1
    class ISO20022.Seev035002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice {
        + Prtry  : ISO20022.Seev035002.GenericIdentification47
        + TempInd  : String
    }
    ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice *-- ISO20022.Seev035002.GenericIdentification47
    class ISO20022.Seev035002.TotalEligibleBalanceFormat11 {
        + PartWayPrdUnits  : ISO20022.Seev035002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev035002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev035002.Quantity80Choice
    }
    ISO20022.Seev035002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev035002.SignedQuantityFormat13
    ISO20022.Seev035002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev035002.Quantity80Choice
    class ISO20022.Seev035002.UpdatedAdditionalInformation22 {
        + AddtlInf  : String
    }
    class ISO20022.Seev035002.UpdatedAdditionalInformation23 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev035002.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev035002.AccountAndBalance64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev035002.CorporateActionBalanceDetails46||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev035002.SafekeepingPlaceFormat52Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev035002.PartyIdentification136Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Seev035002.AccountIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.AccountIdentification76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctsListAndBalDtls|global::System.Collections.Generic.List<ISO20022.Seev035002.AccountAndBalance64>||XmlElement()||
|+|ForAllAccts|ISO20022.Seev035002.AccountIdentification10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validList("""AcctsListAndBalDtls""",AcctsListAndBalDtls),validElement(AcctsListAndBalDtls),validElement(ForAllAccts),validChoice(AcctsListAndBalDtls,ForAllAccts))|

---

## Enum ISO20022.Seev035002.AdditionalBusinessProcess10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCP|Int32||XmlEnum("""INCP""")|1|
||REAC|Int32||XmlEnum("""REAC""")|2|
||FPRE|Int32||XmlEnum("""FPRE""")|3|
||PPRE|Int32||XmlEnum("""PPRE""")|4|
||PPUT|Int32||XmlEnum("""PPUT""")|5|
||TAXR|Int32||XmlEnum("""TAXR""")|6|
||REVR|Int32||XmlEnum("""REVR""")|7|
||CLAI|Int32||XmlEnum("""CLAI""")|8|

---

## Value ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.AmountAndQuantityRatio5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev035002.AmountAndRateStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|String||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev035002.AmountPrice4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev035002.AmountPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev035002.AmountPrice7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev035002.AmountPricePerAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PricVal|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev035002.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Enum ISO20022.Seev035002.AmountPriceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Enum ISO20022.Seev035002.AmountPriceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLOT|Int32||XmlEnum("""PLOT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev035002.AmountToAmountRatio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Amt1|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Value ISO20022.Seev035002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev035002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev035002.BalanceFormat16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|NotElgblBal|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev035002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(PartWayPrdUnits,FullPrdUnits,NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev035002.BeneficiaryCertificationType14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.BeneficiaryCertificationType6Code


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

## Value ISO20022.Seev035002.BlockChainAddressWallet11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev035002.BorrowerLendingDeadline6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brrwr|ISO20022.Seev035002.PartyIdentification136Choice||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brrwr),validElement(StockLndgDdln))|

---

## Value ISO20022.Seev035002.CashAccountIdentification13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev035002.BlockChainAddressWallet11||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev035002.CashOption111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Seev035002.PriceDetails42||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev035002.Rate46||XmlElement()||
|+|FXDtls|ISO20022.Seev035002.ForeignExchangeTerms42||XmlElement()||
|+|DtDtls|ISO20022.Seev035002.CorporateActionDate94||XmlElement()||
|+|AmtDtls|ISO20022.Seev035002.CorporateActionAmounts75||XmlElement()||
|+|CshAcctId|ISO20022.Seev035002.CashAccountIdentification13Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev035002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev035002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice||XmlElement()||
|+|CtrctlPmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(RateAndAmtDtls),validElement(FXDtls),validElement(DtDtls),validElement(AmtDtls),validElement(CshAcctId),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd))|

---

## Value ISO20022.Seev035002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Seev035002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Seev035002.CorporateAction77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev035002.LotteryTypeFormat5Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev035002.AdditionalBusinessProcessFormat21Choice>||XmlElement()||
|+|EvtStag|ISO20022.Seev035002.CorporateActionEventStageFormat15Choice||XmlElement()||
|+|SctiesQty|ISO20022.Seev035002.CorporateActionQuantity13||XmlElement()||
|+|DtDtls|ISO20022.Seev035002.CorporateActionDate93||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validElement(IntrmdtSctiesDstrbtnTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(SctiesQty),validElement(DtDtls))|

---

## Value ISO20022.Seev035002.CorporateActionAmounts61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt))|

---

## Value ISO20022.Seev035002.CorporateActionAmounts75


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuyUpAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdRyltsAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdIntrstAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdFndAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdDvddAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FrgnIncmAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TxTax|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxOnIncmAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|BckUpWhldgTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NRATaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FATCATaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EqulstnAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IncmPrtn|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EntitldAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ChrgsAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ScndLvlTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddPmtAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|MktClmAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|GrssAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyUpAmt),validElement(DmdRyltsAmt),validElement(DmdIntrstAmt),validElement(DmdFndAmt),validElement(DmdDvddAmt),validElement(FrgnIncmAmt),validElement(DmdAmt),validElement(TxTax),validElement(TaxOnIncmAmt),validElement(BckUpWhldgTaxAmt),validElement(NRATaxAmt),validElement(FATCATaxAmt),validElement(EqulstnAmt),validElement(IncmPrtn),validElement(AcrdIntrstAmt),validElement(OrgnlAmt),validElement(EntitldAmt),validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(ValAddedTaxAmt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(RinvstmtAmt),validElement(ManfctrdDvddPmtAmt),validElement(IndmntyAmt),validElement(MktClmAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(NetAmt),validElement(GrssAmt))|

---

## Value ISO20022.Seev035002.CorporateActionBalanceDetails46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UafctdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|AfctdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|InstdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|UinstdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|OblgtdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|RegdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|SttlmPosBal|global::System.Collections.Generic.List<ISO20022.Seev035002.BalanceFormat16Choice>||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev035002.BalanceFormat16Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev035002.BalanceFormat16Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev035002.BalanceFormat14Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev035002.TotalEligibleBalanceFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UafctdBal),validElement(AfctdBal),validElement(InstdBal),validElement(UinstdBal),validElement(OblgtdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validList("""SttlmPosBal""",SttlmPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal))|

---

## Value ISO20022.Seev035002.CorporateActionDate107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DcmnttnDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|BrrwrStockLndgDdln|global::System.Collections.Generic.List<ISO20022.Seev035002.BorrowerLendingDeadline6>||XmlElement()||
|+|StockLndgDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|DpstryCoverXprtnDt|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|SbcptCostDbtDt|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|RspnDdln|ISO20022.Seev035002.DateFormat54Choice||XmlElement()||
|+|MktDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|PrtctDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|CoverXprtnDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|EarlyRspnDdln|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DcmnttnDdln),validList("""BrrwrStockLndgDdln""",BrrwrStockLndgDdln),validElement(BrrwrStockLndgDdln),validElement(StockLndgDdln),validElement(DpstryCoverXprtnDt),validElement(SbcptCostDbtDt),validElement(XpryDt),validElement(RspnDdln),validElement(MktDdln),validElement(PrtctDdln),validElement(CoverXprtnDdln),validElement(EarlyRspnDdln))|

---

## Value ISO20022.Seev035002.CorporateActionDate93


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|ExDvddDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryDt),validElement(ExDvddDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev035002.CorporateActionDate94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarlstPmtDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev035002.DateFormat49Choice||XmlElement()||
|+|ValDt|ISO20022.Seev035002.DateFormat64Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarlstPmtDt),validElement(FXRateFxgDt),validElement(ValDt),validElement(PmtDt))|

---

## Enum ISO20022.Seev035002.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev035002.CorporateActionEventProcessingType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.CorporateActionEventReference4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev035002.ProcessingPosition10Choice||XmlElement()||
|+|EvtId|ISO20022.Seev035002.CorporateActionEventReference4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev035002.CorporateActionEventReference4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LkdCorpActnId""",LkdCorpActnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LkdOffclCorpActnEvtId""",LkdOffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev035002.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev035002.CorporateActionEventStageFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.CorporateActionEventType122Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.CorporateActionEventType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
||ACCU|Int32||XmlEnum("""ACCU""")|3|
||WRTH|Int32||XmlEnum("""WRTH""")|4|
||WTRC|Int32||XmlEnum("""WTRC""")|5|
||EXWA|Int32||XmlEnum("""EXWA""")|6|
||SUSP|Int32||XmlEnum("""SUSP""")|7|
||DLST|Int32||XmlEnum("""DLST""")|8|
||TEND|Int32||XmlEnum("""TEND""")|9|
||TREC|Int32||XmlEnum("""TREC""")|10|
||SPLF|Int32||XmlEnum("""SPLF""")|11|
||DVSE|Int32||XmlEnum("""DVSE""")|12|
||SOFF|Int32||XmlEnum("""SOFF""")|13|
||SMAL|Int32||XmlEnum("""SMAL""")|14|
||SHPR|Int32||XmlEnum("""SHPR""")|15|
||DVSC|Int32||XmlEnum("""DVSC""")|16|
||RHTS|Int32||XmlEnum("""RHTS""")|17|
||SPLR|Int32||XmlEnum("""SPLR""")|18|
||BIDS|Int32||XmlEnum("""BIDS""")|19|
||REMK|Int32||XmlEnum("""REMK""")|20|
||REDO|Int32||XmlEnum("""REDO""")|21|
||BPUT|Int32||XmlEnum("""BPUT""")|22|
||PRIO|Int32||XmlEnum("""PRIO""")|23|
||PDEF|Int32||XmlEnum("""PDEF""")|24|
||PLAC|Int32||XmlEnum("""PLAC""")|25|
||PINK|Int32||XmlEnum("""PINK""")|26|
||PRED|Int32||XmlEnum("""PRED""")|27|
||PCAL|Int32||XmlEnum("""PCAL""")|28|
||PARI|Int32||XmlEnum("""PARI""")|29|
||OTHR|Int32||XmlEnum("""OTHR""")|30|
||ODLT|Int32||XmlEnum("""ODLT""")|31|
||CERT|Int32||XmlEnum("""CERT""")|32|
||NOOF|Int32||XmlEnum("""NOOF""")|33|
||MRGR|Int32||XmlEnum("""MRGR""")|34|
||EXTM|Int32||XmlEnum("""EXTM""")|35|
||LIQU|Int32||XmlEnum("""LIQU""")|36|
||RHDI|Int32||XmlEnum("""RHDI""")|37|
||INTR|Int32||XmlEnum("""INTR""")|38|
||PPMT|Int32||XmlEnum("""PPMT""")|39|
||INCR|Int32||XmlEnum("""INCR""")|40|
||MCAL|Int32||XmlEnum("""MCAL""")|41|
||REDM|Int32||XmlEnum("""REDM""")|42|
||EXOF|Int32||XmlEnum("""EXOF""")|43|
||DTCH|Int32||XmlEnum("""DTCH""")|44|
||DRAW|Int32||XmlEnum("""DRAW""")|45|
||DRIP|Int32||XmlEnum("""DRIP""")|46|
||DVOP|Int32||XmlEnum("""DVOP""")|47|
||DSCL|Int32||XmlEnum("""DSCL""")|48|
||DETI|Int32||XmlEnum("""DETI""")|49|
||DECR|Int32||XmlEnum("""DECR""")|50|
||CREV|Int32||XmlEnum("""CREV""")|51|
||CONV|Int32||XmlEnum("""CONV""")|52|
||CONS|Int32||XmlEnum("""CONS""")|53|
||CLSA|Int32||XmlEnum("""CLSA""")|54|
||COOP|Int32||XmlEnum("""COOP""")|55|
||CHAN|Int32||XmlEnum("""CHAN""")|56|
||DVCA|Int32||XmlEnum("""DVCA""")|57|
||DRCA|Int32||XmlEnum("""DRCA""")|58|
||CAPI|Int32||XmlEnum("""CAPI""")|59|
||CAPG|Int32||XmlEnum("""CAPG""")|60|
||CAPD|Int32||XmlEnum("""CAPD""")|61|
||EXRI|Int32||XmlEnum("""EXRI""")|62|
||BONU|Int32||XmlEnum("""BONU""")|63|
||DFLT|Int32||XmlEnum("""DFLT""")|64|
||BRUP|Int32||XmlEnum("""BRUP""")|65|
||ATTI|Int32||XmlEnum("""ATTI""")|66|
||ACTV|Int32||XmlEnum("""ACTV""")|67|

---

## Value ISO20022.Seev035002.CorporateActionGeneralInformation192


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev035002.FinancialInstrumentAttributes134||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice||XmlElement()||
|+|EvtTp|ISO20022.Seev035002.CorporateActionEventType122Choice||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev035002.CorporateActionEventProcessingType3Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validElement(EvtPrcgTp),validPattern("""ClssActnNb""",ClssActnNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Seev035002.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev035002.CorporateActionMandatoryVoluntary4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Aspect ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev035002.SupplementaryData1>||XmlElement()||
|+|TrfAgt|ISO20022.Seev035002.PartyIdentification151Choice||XmlElement()||
|+|Offerr|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification151Choice>||XmlElement()||
|+|Issr|ISO20022.Seev035002.PartyIdentification151Choice||XmlElement()||
|+|InfAgt|ISO20022.Seev035002.PartyIdentification137Choice||XmlElement()||
|+|SlctnAgt|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification137Choice>||XmlElement()||
|+|DrpAgt|ISO20022.Seev035002.PartyIdentification137Choice||XmlElement()||
|+|PhysSctiesAgt|ISO20022.Seev035002.PartyIdentification137Choice||XmlElement()||
|+|RsellngAgt|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification137Choice>||XmlElement()||
|+|Regar|ISO20022.Seev035002.PartyIdentification137Choice||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification137Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification137Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev035002.PartyIdentification151Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev035002.CorporateActionNarrative62||XmlElement()||
|+|CorpActnMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev035002.CorporateActionOption245>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev035002.CorporateAction77||XmlElement()||
|+|AcctDtls|ISO20022.Seev035002.AccountIdentification76Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev035002.CorporateActionGeneralInformation192||XmlElement()||
|+|RvslRsn|ISO20022.Seev035002.CorporateActionReversalReason9||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev035002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev035002.DocumentIdentification38>||XmlElement()||
|+|InstrId|ISO20022.Seev035002.DocumentIdentification17||XmlElement()||
|+|MvmntConfId|ISO20022.Seev035002.DocumentIdentification37||XmlElement()||
|+|NtfctnId|ISO20022.Seev035002.DocumentIdentification37||XmlElement()||
|+|PrvsMvmntPrlimryAdvcId|ISO20022.Seev035002.DocumentIdentification37||XmlElement()||
|+|MvmntPrlimryAdvcGnlInf|ISO20022.Seev035002.CorporateActionPreliminaryAdviceType5||XmlElement()||
|+|Pgntn|ISO20022.Seev035002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TrfAgt),validList("""Offerr""",Offerr),validElement(Offerr),validElement(Issr),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validList("""CorpActnMvmntDtls""",CorpActnMvmntDtls),validElement(CorpActnMvmntDtls),validElement(CorpActnDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(RvslRsn),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(MvmntConfId),validElement(NtfctnId),validElement(PrvsMvmntPrlimryAdvcId),validElement(MvmntPrlimryAdvcGnlInf),validElement(Pgntn))|

---

## Enum ISO20022.Seev035002.CorporateActionMovementPreliminaryAdviceFunction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CAPA|Int32||XmlEnum("""CAPA""")|1|
||ENTL|Int32||XmlEnum("""ENTL""")|2|

---

## Value ISO20022.Seev035002.CorporateActionNarrative61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|Dsclmr|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|TaxtnConds|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|SctyRstrctn|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|InfToCmplyWth|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|InfConds|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|NrrtvVrsn|ISO20022.Seev035002.UpdatedAdditionalInformation22||XmlElement()||
|+|AddtlTxt|ISO20022.Seev035002.UpdatedAdditionalInformation22||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertfctnBrkdwn),validElement(Dsclmr),validElement(TaxtnConds),validElement(SctyRstrctn),validElement(InfToCmplyWth),validElement(InfConds),validElement(NrrtvVrsn),validElement(AddtlTxt))|

---

## Value ISO20022.Seev035002.CorporateActionNarrative62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgTxtForNxtIntrmy|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|CertfctnBrkdwn|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|BsktOrIndxInf|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|RegnDtls|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|PtyCtctNrrtv|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|Dsclmr|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|TaxtnConds|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|InfToCmplyWth|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|InfConds|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|NrrtvVrsn|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
|+|AddtlTxt|ISO20022.Seev035002.UpdatedAdditionalInformation23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgTxtForNxtIntrmy),validElement(CertfctnBrkdwn),validElement(BsktOrIndxInf),validElement(RegnDtls),validElement(PtyCtctNrrtv),validElement(Dsclmr),validElement(TaxtnConds),validElement(InfToCmplyWth),validElement(InfConds),validElement(NrrtvVrsn),validElement(AddtlTxt))|

---

## Enum ISO20022.Seev035002.CorporateActionOption15Code


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

## Value ISO20022.Seev035002.CorporateActionOption245


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev035002.CorporateActionNarrative61||XmlElement()||
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev035002.CashOption111>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev035002.SecuritiesOption116>||XmlElement()||
|+|SctiesQty|ISO20022.Seev035002.SecuritiesOption84||XmlElement()||
|+|PricDtls|ISO20022.Seev035002.CorporateActionPrice94||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev035002.CorporateActionRate133||XmlElement()||
|+|PrdDtls|ISO20022.Seev035002.CorporateActionPeriod12||XmlElement()||
|+|DtDtls|ISO20022.Seev035002.CorporateActionDate107||XmlElement()||
|+|SctyId|ISO20022.Seev035002.SecurityIdentification20||XmlElement()||
|+|ApldOptnInd|String||XmlElement()||
|+|ChngAllwdInd|String||XmlElement()||
|+|WdrwlAllwdInd|String||XmlElement()||
|+|CertfctnBrkdwnInd|String||XmlElement()||
|+|AccptncPrtyLvl|String||XmlElement()||
|+|ChrgsApldInd|String||XmlElement()||
|+|DfltPrcgOrStgInstr|ISO20022.Seev035002.DefaultProcessingOrStandingInstruction2Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|VldDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NonDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CertfctnBrkdwnTp|global::System.Collections.Generic.List<ISO20022.Seev035002.BeneficiaryCertificationType14Choice>||XmlElement()||
|+|OptnAvlbtySts|ISO20022.Seev035002.OptionAvailabilityStatus4Choice||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev035002.OptionFeaturesFormat31Choice>||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev035002.OfferTypeFormat15Choice>||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev035002.FractionDispositionType31Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev035002.CorporateActionOption46Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(SctiesQty),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls),validElement(SctyId),validPattern("""AccptncPrtyLvl""",AccptncPrtyLvl,"""[A-Z0-9]{3}"""),validElement(DfltPrcgOrStgInstr),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validPattern("""VldDmclCtry""",VldDmclCtry,"""[A-Z]{2,2}"""),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validList("""CertfctnBrkdwnTp""",CertfctnBrkdwnTp),validElement(CertfctnBrkdwnTp),validElement(OptnAvlbtySts),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(FrctnDspstn),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev035002.CorporateActionOption46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.CorporateActionPeriod12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DpstrySspnsnPrdForWdrwl|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|AcctSvcrRvcbltyPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|PrvlgSspnsnPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|RvcbltyPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|ActnPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|ParllTradgPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DpstrySspnsnPrdForWdrwl),validElement(AcctSvcrRvcbltyPrd),validElement(PrvlgSspnsnPrd),validElement(RvcbltyPrd),validElement(ActnPrd),validElement(ParllTradgPrd),validElement(PricClctnPrd))|

---

## Enum ISO20022.Seev035002.CorporateActionPreliminaryAdviceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPL|Int32||XmlEnum("""REPL""")|1|
||NEWM|Int32||XmlEnum("""NEWM""")|2|

---

## Value ISO20022.Seev035002.CorporateActionPreliminaryAdviceType5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctn|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|MvmntPrlimryAdvcId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MvmntPrlimryAdvcId""",MvmntPrlimryAdvcId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.CorporateActionPrice94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MinMltplCshToInst|ISO20022.Seev035002.PriceFormat62Choice||XmlElement()||
|+|MinCshToInst|ISO20022.Seev035002.PriceFormat62Choice||XmlElement()||
|+|MaxCshToInst|ISO20022.Seev035002.PriceFormat62Choice||XmlElement()||
|+|OverSbcptDpstPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MinMltplCshToInst),validElement(MinCshToInst),validElement(MaxCshToInst),validElement(OverSbcptDpstPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev035002.CorporateActionPrice95


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricRcvdPerPdct|ISO20022.Seev035002.PriceFormat90Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev035002.PriceFormat89Choice||XmlElement()||
|+|CshValForTax|ISO20022.Seev035002.PriceFormat58Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev035002.IndicativeOrMarketPrice17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct),validElement(CshValForTax),validElement(CshInLieuOfShrPric),validElement(IndctvOrMktPric))|

---

## Value ISO20022.Seev035002.CorporateActionQuantity13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IncrmtlDnmtn|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|BaseDnmtn|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IncrmtlDnmtn),validElement(BaseDnmtn))|

---

## Value ISO20022.Seev035002.CorporateActionRate133


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxOnIncm|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
|+|TaxblIncmPerDvddShr|global::System.Collections.Generic.List<ISO20022.Seev035002.RateTypeAndAmountAndStatus33>||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|PrratnRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|MaxAllwdOvrsbcptRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice>||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev035002.NetDividendRateFormat43Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev035002.GrossDividendRateFormat41Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxOnIncm),validList("""TaxblIncmPerDvddShr""",TaxblIncmPerDvddShr),validElement(TaxblIncmPerDvddShr),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(PrratnRate),validElement(MaxAllwdOvrsbcptRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev035002.CorporateActionRate134


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|FinTxTaxRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev035002.RateFormat29Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
|+|TrfrmatnRate|Decimal||XmlElement()||
|+|NewToOd|ISO20022.Seev035002.RatioFormat24Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev035002.RatioFormat23Choice||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev035002.RatioFormat23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(FinTxTaxRate),validElement(TaxCdtRate),validElement(AplblRate),validElement(FsclStmp),validElement(ChrgsFees),validElement(NewToOd),validElement(AddtlQtyForExstgScties),validElement(AddtlQtyForSbcbdRsltntScties))|

---

## Value ISO20022.Seev035002.CorporateActionReversalReason11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.CorporateActionReversalReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||UPAY|Int32||XmlEnum("""UPAY""")|2|
||IVAD|Int32||XmlEnum("""IVAD""")|3|
||IPRI|Int32||XmlEnum("""IPRI""")|4|
||IPCU|Int32||XmlEnum("""IPCU""")|5|
||IETR|Int32||XmlEnum("""IETR""")|6|
||IRED|Int32||XmlEnum("""IRED""")|7|
||FNRC|Int32||XmlEnum("""FNRC""")|8|
||DCBD|Int32||XmlEnum("""DCBD""")|9|

---

## Value ISO20022.Seev035002.CorporateActionReversalReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev035002.CorporateActionReversalReason11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,256}"""),validElement(Rsn))|

---

## Enum ISO20022.Seev035002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev035002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev035002.DateCode22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.DateCode26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.DateCode27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.DateCodeAndTimeFormat4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|DtCd|ISO20022.Seev035002.DateCode26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd))|

---

## Value ISO20022.Seev035002.DateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev035002.DateCode22Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev035002.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev035002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Value ISO20022.Seev035002.DateFormat49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev035002.DateCode22Choice||XmlElement()||
|+|Dt|ISO20022.Seev035002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev035002.DateFormat54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev035002.DateCode22Choice||XmlElement()||
|+|DtCdAndTm|ISO20022.Seev035002.DateCodeAndTimeFormat4||XmlElement()||
|+|Dt|ISO20022.Seev035002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(DtCdAndTm),validElement(Dt),validChoice(DtCd,DtCdAndTm,Dt))|

---

## Value ISO20022.Seev035002.DateFormat64Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev035002.DateCode27Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev035002.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev035002.DateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|

---

## Enum ISO20022.Seev035002.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Enum ISO20022.Seev035002.DeemedRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERY|Int32||XmlEnum("""DERY""")|1|
||DEIT|Int32||XmlEnum("""DEIT""")|2|
||DEFP|Int32||XmlEnum("""DEFP""")|3|
||DEDI|Int32||XmlEnum("""DEDI""")|4|

---

## Value ISO20022.Seev035002.DeemedRateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.DefaultProcessingOrStandingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgInstrInd|String||XmlElement()||
|+|DfltOptnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(StgInstrInd,DfltOptnInd))|

---

## Enum ISO20022.Seev035002.DividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Type ISO20022.Seev035002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnMvmntPrlimryAdvc|ISO20022.Seev035002.CorporateActionMovementPreliminaryAdvice002V16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnMvmntPrlimryAdvc))|

---

## Value ISO20022.Seev035002.DocumentIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.DocumentIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev035002.ProcessingPosition10Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.DocumentIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev035002.ProcessingPosition10Choice||XmlElement()||
|+|DocNb|ISO20022.Seev035002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev035002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev035002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev035002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev035002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev035002.FinancialInstrumentAttributes134


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctSz|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|WarrtParity|ISO20022.Seev035002.QuantityToQuantityRatio2||XmlElement()||
|+|NxtFctr|ISO20022.Seev035002.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev035002.RateFormat12Choice||XmlElement()||
|+|PctgOfDebtClm|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
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
|+|OptnStyle|ISO20022.Seev035002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev035002.ClassificationType33Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev035002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev035002.MarketIdentification4Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev035002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinNmnlQty),validElement(WarrtParity),validElement(NxtFctr),validElement(PrvsFctr),validElement(PctgOfDebtClm),validElement(NxtIntrstRate),validElement(IntrstRate),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev035002.FinancialInstrumentAttributes135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssePric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
|+|CtrctSz|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|NxtIntrstRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|IntrstRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|NxtFctr|ISO20022.Seev035002.RateFormat12Choice||XmlElement()||
|+|PrvsFctr|ISO20022.Seev035002.RateFormat12Choice||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|NxtCpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnStyle|ISO20022.Seev035002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev035002.ClassificationType33Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev035002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev035002.MarketIdentification4Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev035002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssePric),validElement(CtrctSz),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MinNmnlQty),validElement(NxtIntrstRate),validElement(IntrstRate),validElement(NxtFctr),validElement(PrvsFctr),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnStyle),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev035002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev035002.FinancialInstrumentQuantity43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev035002.FinancialInstrumentQuantity44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,Cd,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev035002.ForeignExchangeTerms42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev035002.FractionDispositionType31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.FractionDispositionType8Code


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

## Value ISO20022.Seev035002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev035002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev035002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.GrossDividendRateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev035002.RateTypeAndAmountAndStatus59||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev035002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev035002.GrossDividendRateType6Code


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

## Value ISO20022.Seev035002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.IndicativeOrMarketPrice17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Enum ISO20022.Seev035002.InterestComputationMethod2Code


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

## Value ISO20022.Seev035002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev035002.RateTypeAndAmountAndStatus32||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev035002.IntermediateSecuritiesDistributionTypeFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.IntermediateSecurityDistributionType5Code


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

## Value ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.IssuerTaxability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Enum ISO20022.Seev035002.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev035002.LotteryTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev035002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Seev035002.NetDividendRateFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev035002.RateTypeAndAmountAndStatus60||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev035002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(NotSpcfdRate,RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev035002.NetDividendRateType6Code


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

## Enum ISO20022.Seev035002.NewSecuritiesIssuanceType5Code


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

## Enum ISO20022.Seev035002.NonEligibleProceedsIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONEL|Int32||XmlEnum("""ONEL""")|1|
||ACLI|Int32||XmlEnum("""ACLI""")|2|
||NELC|Int32||XmlEnum("""NELC""")|3|

---

## Enum ISO20022.Seev035002.NonEligibleProceedsIndicator2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NELS|Int32||XmlEnum("""NELS""")|1|
||ONEL|Int32||XmlEnum("""ONEL""")|2|
||ACLI|Int32||XmlEnum("""ACLI""")|3|
||NELC|Int32||XmlEnum("""NELC""")|4|

---

## Value ISO20022.Seev035002.NonEligibleProceedsIndicator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.OfferType5Code


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

## Value ISO20022.Seev035002.OfferTypeFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.OptionAvailabilityStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||INTV|Int32||XmlEnum("""INTV""")|2|

---

## Value ISO20022.Seev035002.OptionAvailabilityStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.OptionFeatures13Code


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

## Value ISO20022.Seev035002.OptionFeaturesFormat31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Seev035002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.OriginalAndCurrentQuantities7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev035002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev035002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev035002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev035002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev035002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev035002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev035002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev035002.PartyIdentification151Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev035002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev035002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,NmAndAdr,PrtryId,AnyBIC))|

---

## Enum ISO20022.Seev035002.Payment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONT|Int32||XmlEnum("""CONT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev035002.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.Period11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev035002.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Seev035002.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev035002.Period6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrdCd|String||XmlElement()||
|+|Prd|ISO20022.Seev035002.Period11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validChoice(PrdCd,Prd))|

---

## Value ISO20022.Seev035002.PriceDetails42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInLieuOfShrPric|ISO20022.Seev035002.PriceFormat88Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev035002.PriceFormat90Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev035002.PriceFormat89Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInLieuOfShrPric),validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct))|

---

## Value ISO20022.Seev035002.PriceFormat58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev035002.AmountPrice4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev035002.PriceFormat62Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev035002.AmountPrice7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validChoice(NotSpcfdPric,AmtPric))|

---

## Value ISO20022.Seev035002.PriceFormat88Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev035002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev035002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev035002.PriceFormat89Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev035002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev035002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,NotSpcfdPric,AmtPric,PctgPric))|

---

## Value ISO20022.Seev035002.PriceFormat90Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev035002.AmountPricePerAmount3||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev035002.AmountPricePerFinancialInstrumentQuantity11||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev035002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev035002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev035002.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev035002.PriceValueType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev035002.PriceValueType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||UNSP|Int32||XmlEnum("""UNSP""")|3|
||TBSP|Int32||XmlEnum("""TBSP""")|4|

---

## Value ISO20022.Seev035002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev035002.ProprietaryQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev035002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Enum ISO20022.Seev035002.Quantity4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANYA|Int32||XmlEnum("""ANYA""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev035002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev035002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev035002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev035002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev035002.Quantity57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev035002.OriginalAndCurrentQuantities7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Enum ISO20022.Seev035002.Quantity5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev035002.Quantity80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev035002.ProprietaryQuantity10||XmlElement()||
|+|QtyChc|ISO20022.Seev035002.Quantity57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev035002.QuantityToQuantityRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.Rate46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmdRate|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat71Choice>||XmlElement()||
|+|EqulstnRate|ISO20022.Seev035002.RateAndAmountFormat48Choice||XmlElement()||
|+|TaxRclmRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|TaxOnPrfts|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev035002.RateFormat29Choice||XmlElement()||
|+|SlctnFeeRate|ISO20022.Seev035002.SolicitationFeeRateFormat14Choice||XmlElement()||
|+|AplblRate|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev035002.NetDividendRateFormat43Choice>||XmlElement()||
|+|ThrdPtyIncntivRate|ISO20022.Seev035002.RateFormat29Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev035002.RateFormat24Choice||XmlElement()||
|+|EarlySlctnFeeRate|ISO20022.Seev035002.SolicitationFeeRateFormat14Choice||XmlElement()||
|+|ChrgsFees|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev035002.RateAndAmountFormat70Choice>||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev035002.InterestRateUsedForPaymentFormat18Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev035002.GrossDividendRateFormat41Choice>||XmlElement()||
|+|AddtlTax|ISO20022.Seev035002.RateAndAmountFormat69Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DmdRate""",DmdRate),validElement(DmdRate),validElement(EqulstnRate),validElement(TaxRclmRate),validElement(TaxOnPrfts),validElement(TaxOnIncm),validElement(TaxCdtRate),validElement(SlctnFeeRate),validElement(AplblRate),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validElement(ThrdPtyIncntivRate),validElement(FsclStmp),validElement(EarlySlctnFeeRate),validElement(ChrgsFees),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(AddtlTax))|

---

## Value ISO20022.Seev035002.RateAndAmountFormat48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt))|

---

## Value ISO20022.Seev035002.RateAndAmountFormat69Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev035002.RateAndAmountFormat70Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev035002.RateTypeAndPercentageRate18||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev035002.RateAndAmountFormat71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev035002.RateTypeAndPercentageRate19||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev035002.RateTypeAndAmountAndStatus54||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndRate,RateTpAndAmtAndRateSts,NotSpcfdRate,Amt,Rate))|

---

## Value ISO20022.Seev035002.RateFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev035002.RateFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev035002.RateFormat29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(NotSpcfdRate,Amt,Rate))|

---

## Enum ISO20022.Seev035002.RateStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDI|Int32||XmlEnum("""INDI""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev035002.RateStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.RateType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev035002.RateType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.RateType46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.RateType47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev035002.RateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev035002.RateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USCD|Int32||XmlEnum("""USCD""")|1|
||SCHD|Int32||XmlEnum("""SCHD""")|2|

---

## Value ISO20022.Seev035002.RateType80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.RateType81Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev035002.RateTypeAndAmountAndStatus32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev035002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev035002.RateType45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndAmountAndStatus33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev035002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev035002.RateType47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndAmountAndStatus54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev035002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev035002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndAmountAndStatus59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev035002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev035002.RateType80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndAmountAndStatus60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev035002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev035002.RateType81Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndPercentageRate18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev035002.RateType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev035002.RateTypeAndPercentageRate19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev035002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev035002.RateValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev035002.RatioFormat23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtToAmt|ISO20022.Seev035002.AmountToAmountRatio3||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev035002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtToAmt),validElement(QtyToQty),validChoice(AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev035002.RatioFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyToAmt|ISO20022.Seev035002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToQty|ISO20022.Seev035002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToAmt|ISO20022.Seev035002.AmountToAmountRatio3||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|QtyToQty|ISO20022.Seev035002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(QtyToAmt,AmtToQty,AmtToAmt,NotSpcfdRate,QtyToQty))|

---

## Value ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev035002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev035002.SafekeepingAccountIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GENR|Int32||XmlEnum("""GENR""")|1|

---

## Enum ISO20022.Seev035002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev035002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Enum ISO20022.Seev035002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Seev035002.SafekeepingPlaceFormat52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev035002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev035002.SafekeepingPlaceFormat53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev035002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev035002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev035002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev035002.SecuritiesOption116


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtDtls|ISO20022.Seev035002.CorporateActionAmounts61||XmlElement()||
|+|PricDtls|ISO20022.Seev035002.CorporateActionPrice95||XmlElement()||
|+|RateDtls|ISO20022.Seev035002.CorporateActionRate134||XmlElement()||
|+|DtDtls|ISO20022.Seev035002.SecurityDate23||XmlElement()||
|+|TradgPrd|ISO20022.Seev035002.Period6Choice||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev035002.FractionDispositionType31Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev035002.SafekeepingPlaceFormat53Choice||XmlElement()||
|+|EntitldQty|ISO20022.Seev035002.Quantity54Choice||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev035002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev035002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|NewSctiesIssncInd|String||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev035002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|NonElgblPrcdsInd|ISO20022.Seev035002.NonEligibleProceedsIndicator6Choice||XmlElement()||
|+|TempFinInstrmInd|ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|SctyDtls|ISO20022.Seev035002.FinancialInstrumentAttributes135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtDtls),validElement(PricDtls),validElement(RateDtls),validElement(DtDtls),validElement(TradgPrd),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validElement(SfkpgPlc),validElement(EntitldQty),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(NonElgblPrcdsInd),validElement(TempFinInstrmInd),validElement(SctyDtls))|

---

## Value ISO20022.Seev035002.SecuritiesOption84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BckEndOddLotQty|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|FrntEndOddLotQty|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewDnmtnQty|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|NewBrdLotQty|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|MinMltplQtyToInst|ISO20022.Seev035002.FinancialInstrumentQuantity43Choice||XmlElement()||
|+|MinQtyToInst|ISO20022.Seev035002.FinancialInstrumentQuantity44Choice||XmlElement()||
|+|MaxQtyToInst|ISO20022.Seev035002.FinancialInstrumentQuantity44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BckEndOddLotQty),validElement(FrntEndOddLotQty),validElement(NewDnmtnQty),validElement(NewBrdLotQty),validElement(MinMltplQtyToInst),validElement(MinQtyToInst),validElement(MaxQtyToInst))|

---

## Value ISO20022.Seev035002.SecurityDate23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastTradgDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev035002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastTradgDt),validElement(PrpssDt),validElement(EarlstPmtDt),validElement(DvddRnkgDt),validElement(AvlblDt),validElement(PmtDt))|

---

## Value ISO20022.Seev035002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev035002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev035002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev035002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev035002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev035002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev035002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev035002.SolicitationFeeRateFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|String||XmlElement()||
|+|Amt|ISO20022.Seev035002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtToQty|ISO20022.Seev035002.AmountAndQuantityRatio5||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(AmtToQty),validChoice(NotSpcfdRate,Amt,AmtToQty,Rate))|

---

## Value ISO20022.Seev035002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev035002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev035002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev035002.TemporaryFinancialInstrumentIndicator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev035002.GenericIdentification47||XmlElement()||
|+|TempInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,TempInd))|

---

## Value ISO20022.Seev035002.TotalEligibleBalanceFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev035002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev035002.Quantity80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(Bal))|

---

## Value ISO20022.Seev035002.UpdatedAdditionalInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Seev035002.UpdatedAdditionalInformation23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AddtlInf""",AddtlInf),validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Seev035002.WithholdingTaxRateType1Code


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

