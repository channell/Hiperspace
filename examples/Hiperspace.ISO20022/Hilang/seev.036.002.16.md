# seev.036.002.16
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev036002.Account11Choice {
        + TaxAcct  : ISO20022.Seev036002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Seev036002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Seev036002.CashAccountIdentification12Choice
    }
    ISO20022.Seev036002.Account11Choice *-- ISO20022.Seev036002.CashAccountIdentification6Choice
    ISO20022.Seev036002.Account11Choice *-- ISO20022.Seev036002.CashAccountIdentification6Choice
    ISO20022.Seev036002.Account11Choice *-- ISO20022.Seev036002.CashAccountIdentification12Choice
    class ISO20022.Seev036002.AccountAndBalance63 {
        + Bal  : ISO20022.Seev036002.CorporateActionBalanceDetails45
        + SfkpgPlc  : ISO20022.Seev036002.SafekeepingPlaceFormat49Choice
        + AcctOwnr  : ISO20022.Seev036002.PartyIdentification136Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev036002.AccountAndBalance63 *-- ISO20022.Seev036002.CorporateActionBalanceDetails45
    ISO20022.Seev036002.AccountAndBalance63 *-- ISO20022.Seev036002.SafekeepingPlaceFormat49Choice
    ISO20022.Seev036002.AccountAndBalance63 *-- ISO20022.Seev036002.PartyIdentification136Choice
    class ISO20022.Seev036002.AdditionalBusinessProcess12Code {
        SCHM = 1
        PPRE = 2
        PPUT = 3
        NPLE = 4
        INCP = 5
        FPRE = 6
        CONS = 7
        TAXR = 8
        CLPT = 9
        CLNT = 10
        CLAI = 11
        CLFT = 12
    }
    class ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Seev036002.IdentificationType44Choice
    }
    ISO20022.Seev036002.AlternatePartyIdentification9 *-- ISO20022.Seev036002.IdentificationType44Choice
    class ISO20022.Seev036002.AmountAndQuantityRatio5 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.AmountAndQuantityRatio5 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountAndRateStatus2 {
        + RateSts  : String
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.AmountAndRateStatus2 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountPrice4 {
        + PricVal  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036002.AmountPrice4 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountPrice5 {
        + PricVal  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036002.AmountPrice5 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountPricePerAmount3 {
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036002.AmountPricePerAmount3 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.AmountPricePerAmount3 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11 {
        + FinInstrmQty  : ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
        + PricVal  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev036002.AmountPriceType2Code {
        ACTU = 1
    }
    class ISO20022.Seev036002.AmountToAmountRatio3 {
        + Amt2  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Amt1  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.AmountToAmountRatio3 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.AmountToAmountRatio3 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev036002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev036002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev036002.SignedQuantityFormat12
    }
    ISO20022.Seev036002.BalanceFormat14Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat14Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat14Choice *-- ISO20022.Seev036002.SignedQuantityFormat12
    class ISO20022.Seev036002.BalanceFormat16Choice {
        + PartWayPrdUnits  : ISO20022.Seev036002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev036002.SignedQuantityFormat13
        + NotElgblBal  : ISO20022.Seev036002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev036002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev036002.SignedQuantityFormat12
    }
    ISO20022.Seev036002.BalanceFormat16Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat16Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat16Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat16Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.BalanceFormat16Choice *-- ISO20022.Seev036002.SignedQuantityFormat12
    class ISO20022.Seev036002.BlockChainAddressWallet11 {
        + Nm  : String
        + Tp  : ISO20022.Seev036002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Seev036002.BlockChainAddressWallet11 *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.CashAccountIdentification12Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev036002.BlockChainAddressWallet11
        + IBAN  : String
    }
    ISO20022.Seev036002.CashAccountIdentification12Choice *-- ISO20022.Seev036002.BlockChainAddressWallet11
    class ISO20022.Seev036002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Seev036002.CashOption110 {
        + PricDtls  : ISO20022.Seev036002.PriceDetails41
        + RateAndAmtDtls  : ISO20022.Seev036002.Rate45
        + TaxVchrDtls  : ISO20022.Seev036002.TaxVoucher5
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Seev036002.ForeignExchangeTerms41~
        + DtDtls  : ISO20022.Seev036002.CorporateActionDate99
        + AmtDtls  : ISO20022.Seev036002.CorporateActionAmounts74
        + CshPties  : ISO20022.Seev036002.CashParties44
        + Acct  : ISO20022.Seev036002.Account11Choice
        + CtryOfIncmSrc  : String
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev036002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev036002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev036002.GenericIdentification47
        + IssrOfferrTaxbltyInd  : ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice
        + CtrctlPmtInd  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.PriceDetails41
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.Rate45
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.TaxVoucher5
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.ForeignExchangeTerms41
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.CorporateActionDate99
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.CorporateActionAmounts74
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.CashParties44
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.Account11Choice
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.CashOption110 *-- ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice
    class ISO20022.Seev036002.CashParties44 {
        + MktClmCtrPty  : ISO20022.Seev036002.PartyIdentificationAndAccount231
        + CdtrAgt  : ISO20022.Seev036002.PartyIdentificationAndAccount232
        + Cdtr  : ISO20022.Seev036002.PartyIdentificationAndAccount231
    }
    ISO20022.Seev036002.CashParties44 *-- ISO20022.Seev036002.PartyIdentificationAndAccount231
    ISO20022.Seev036002.CashParties44 *-- ISO20022.Seev036002.PartyIdentificationAndAccount232
    ISO20022.Seev036002.CashParties44 *-- ISO20022.Seev036002.PartyIdentificationAndAccount231
    class ISO20022.Seev036002.CorporateAction86 {
        + LtryTp  : ISO20022.Seev036002.LotteryTypeFormat5Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice~
        + EvtStag  : ISO20022.Seev036002.CorporateActionEventStageFormat15Choice
        + DtDtls  : ISO20022.Seev036002.CorporateActionDate89
    }
    ISO20022.Seev036002.CorporateAction86 *-- ISO20022.Seev036002.LotteryTypeFormat5Choice
    ISO20022.Seev036002.CorporateAction86 *-- ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice
    ISO20022.Seev036002.CorporateAction86 *-- ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice
    ISO20022.Seev036002.CorporateAction86 *-- ISO20022.Seev036002.CorporateActionEventStageFormat15Choice
    ISO20022.Seev036002.CorporateAction86 *-- ISO20022.Seev036002.CorporateActionDate89
    class ISO20022.Seev036002.CorporateActionAmounts61 {
        + ScndLvlTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev036002.CorporateActionAmounts61 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts61 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev036002.CorporateActionAmounts74 {
        + BuyUpAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + RfnddSbcptAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + AdjstdSbcptAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + DmdRyltsAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + DmdIntrstAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + DmdFndAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + DmdDvddAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + FrgnIncmAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + DmdAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TxTax  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxOnIncmAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + BckUpWhldgTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + NRATaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + FATCATaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + EqulstnAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + EUTaxRtntnAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + StockXchgTax  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + IncmPrtn  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + RedPrmAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + PrncplOrCrps  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxArrearsAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + NtnlTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + NtnlDvddPyblAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + CshAmtCrrdFwd  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + CshAmtBrghtFwd  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ChrgsAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ScndLvlTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + ManfctrdDvddPmtAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + MktClmAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + GrssAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + PstngAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev036002.CorporateActionAmounts74 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev036002.CorporateActionBalanceDetails45 {
        + UafctdBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + AfctdBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + RegdBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + InTrnsShipmntBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + TradDtPosBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + StrtPosBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + SttlmPosBal  : global::System.Collections.Generic.List~ISO20022.Seev036002.BalanceFormat16Choice~
        + OutForRegnBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev036002.BalanceFormat16Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev036002.BalanceFormat16Choice~
        + OnLnBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + CollOutBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + CollInBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + BrrwdBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + BlckdBal  : ISO20022.Seev036002.BalanceFormat14Choice
        + TtlElgblBal  : ISO20022.Seev036002.TotalEligibleBalanceFormat11
        + ConfdBal  : ISO20022.Seev036002.BalanceFormat14Choice
    }
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat16Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat16Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat16Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.TotalEligibleBalanceFormat11
    ISO20022.Seev036002.CorporateActionBalanceDetails45 *-- ISO20022.Seev036002.BalanceFormat14Choice
    class ISO20022.Seev036002.CorporateActionDate109 {
        + TradgDt  : ISO20022.Seev036002.DateFormat49Choice
        + CoverXprtnDdln  : ISO20022.Seev036002.DateFormat67Choice
    }
    ISO20022.Seev036002.CorporateActionDate109 *-- ISO20022.Seev036002.DateFormat49Choice
    ISO20022.Seev036002.CorporateActionDate109 *-- ISO20022.Seev036002.DateFormat67Choice
    class ISO20022.Seev036002.CorporateActionDate89 {
        + ExDvddDt  : ISO20022.Seev036002.DateFormat41Choice
        + RcrdDt  : ISO20022.Seev036002.DateFormat41Choice
    }
    ISO20022.Seev036002.CorporateActionDate89 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.CorporateActionDate89 *-- ISO20022.Seev036002.DateFormat41Choice
    class ISO20022.Seev036002.CorporateActionDate99 {
        + PmtDt  : DateTime
        + EarlstPmtDt  : DateTime
        + FXRateFxgDt  : ISO20022.Seev036002.DateAndDateTime2Choice
        + ValDt  : DateTime
        + PstngDt  : ISO20022.Seev036002.DateAndDateTime2Choice
    }
    ISO20022.Seev036002.CorporateActionDate99 *-- ISO20022.Seev036002.DateAndDateTime2Choice
    ISO20022.Seev036002.CorporateActionDate99 *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.CorporateActionEventReference4 {
        + LkgTp  : ISO20022.Seev036002.ProcessingPosition10Choice
        + EvtId  : ISO20022.Seev036002.CorporateActionEventReference4Choice
    }
    ISO20022.Seev036002.CorporateActionEventReference4 *-- ISO20022.Seev036002.ProcessingPosition10Choice
    ISO20022.Seev036002.CorporateActionEventReference4 *-- ISO20022.Seev036002.CorporateActionEventReference4Choice
    class ISO20022.Seev036002.CorporateActionEventReference4Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev036002.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev036002.CorporateActionEventStageFormat15Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.CorporateActionEventStageFormat15Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.CorporateActionEventType120Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.CorporateActionEventType120Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.CorporateActionEventType37Code {
        RCLA = 1
        TNDP = 2
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
    class ISO20022.Seev036002.CorporateActionGeneralInformation190 {
        + FrctnlQty  : ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
        + FinInstrmId  : ISO20022.Seev036002.SecurityIdentification20
        + EvtTp  : ISO20022.Seev036002.CorporateActionEventType120Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev036002.CorporateActionGeneralInformation190 *-- ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev036002.CorporateActionGeneralInformation190 *-- ISO20022.Seev036002.SecurityIdentification20
    ISO20022.Seev036002.CorporateActionGeneralInformation190 *-- ISO20022.Seev036002.CorporateActionEventType120Choice
    class ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev036002.SupplementaryData1~
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev036002.PartyIdentification137Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev036002.PartyIdentification137Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev036002.PartyIdentification137Choice~
        + AddtlInf  : ISO20022.Seev036002.CorporateActionNarrative35
        + CorpActnConfDtls  : ISO20022.Seev036002.CorporateActionOption244
        + CorpActnDtls  : ISO20022.Seev036002.CorporateAction86
        + AcctDtls  : ISO20022.Seev036002.AccountAndBalance63
        + CorpActnGnlInf  : ISO20022.Seev036002.CorporateActionGeneralInformation190
        + TxId  : ISO20022.Seev036002.TransactionIdentification1
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev036002.CorporateActionEventReference4~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev036002.DocumentIdentification38~
        + InstrId  : ISO20022.Seev036002.DocumentIdentification17
        + MvmntPrlimryAdvcId  : ISO20022.Seev036002.DocumentIdentification37
        + NtfctnId  : ISO20022.Seev036002.DocumentIdentification37
        + MvmntConfId  : String
        + Pgntn  : ISO20022.Seev036002.Pagination1
    }
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.SupplementaryData1
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.PartyIdentification137Choice
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.PartyIdentification137Choice
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.PartyIdentification137Choice
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.CorporateActionNarrative35
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.CorporateActionOption244
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.CorporateAction86
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.AccountAndBalance63
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.CorporateActionGeneralInformation190
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.TransactionIdentification1
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.CorporateActionEventReference4
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.DocumentIdentification38
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.DocumentIdentification17
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.DocumentIdentification37
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.DocumentIdentification37
    ISO20022.Seev036002.CorporateActionMovementConfirmation002V16 *-- ISO20022.Seev036002.Pagination1
    class ISO20022.Seev036002.CorporateActionNarrative35 {
        + TaxtnConds  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + NrrtvVrsn  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev036002.CorporateActionOption12Code {
        PRUN = 1
        SLLE = 2
        SECU = 3
        QINV = 4
        OVER = 5
        OTHR = 6
        OFFR = 7
        NOQU = 8
        NOAC = 9
        MPUT = 10
        MKUP = 11
        MKDW = 12
        LAPS = 13
        EXER = 14
        CTEN = 15
        CONY = 16
        CONN = 17
        CEXC = 18
        CASH = 19
        CASE = 20
        BUYA = 21
        BSPL = 22
        ABST = 23
    }
    class ISO20022.Seev036002.CorporateActionOption244 {
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev036002.CashOption110~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev036002.SecuritiesOption115~
        + PlcOfTrad  : ISO20022.Seev036002.MarketIdentification90
        + PricDtls  : ISO20022.Seev036002.CorporateActionPrice92
        + RateAndAmtDtls  : ISO20022.Seev036002.CorporateActionRate131
        + PrdDtls  : ISO20022.Seev036002.CorporateActionPeriod13
        + DtDtls  : ISO20022.Seev036002.CorporateActionDate109
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev036002.FractionDispositionType30Choice
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev036002.OptionFeaturesFormat30Choice~
        + OptnTp  : ISO20022.Seev036002.CorporateActionOption39Choice
        + OptnNb  : ISO20022.Seev036002.OptionNumber1Choice
    }
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CashOption110
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.SecuritiesOption115
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.MarketIdentification90
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CorporateActionPrice92
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CorporateActionRate131
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CorporateActionPeriod13
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CorporateActionDate109
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.FractionDispositionType30Choice
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.OptionFeaturesFormat30Choice
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.CorporateActionOption39Choice
    ISO20022.Seev036002.CorporateActionOption244 *-- ISO20022.Seev036002.OptionNumber1Choice
    class ISO20022.Seev036002.CorporateActionOption39Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.CorporateActionOption39Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.CorporateActionPeriod13 {
        + ParllTradgPrd  : ISO20022.Seev036002.Period11
        + ActnPrd  : ISO20022.Seev036002.Period11
        + PricClctnPrd  : ISO20022.Seev036002.Period11
    }
    ISO20022.Seev036002.CorporateActionPeriod13 *-- ISO20022.Seev036002.Period11
    ISO20022.Seev036002.CorporateActionPeriod13 *-- ISO20022.Seev036002.Period11
    ISO20022.Seev036002.CorporateActionPeriod13 *-- ISO20022.Seev036002.Period11
    class ISO20022.Seev036002.CorporateActionPrice92 {
        + OverSbcptDpstPric  : ISO20022.Seev036002.PriceFormat85Choice
        + CshInLieuOfShrPric  : ISO20022.Seev036002.PriceFormat85Choice
    }
    ISO20022.Seev036002.CorporateActionPrice92 *-- ISO20022.Seev036002.PriceFormat85Choice
    ISO20022.Seev036002.CorporateActionPrice92 *-- ISO20022.Seev036002.PriceFormat85Choice
    class ISO20022.Seev036002.CorporateActionPrice93 {
        + GncCshPricRcvdPerPdct  : ISO20022.Seev036002.PriceFormat87Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev036002.PriceFormat86Choice
        + CshValForTax  : ISO20022.Seev036002.AmountPrice4
        + IndctvOrMktPric  : ISO20022.Seev036002.IndicativeOrMarketPrice16Choice
        + CshInLieuOfShrPric  : ISO20022.Seev036002.PriceFormat85Choice
    }
    ISO20022.Seev036002.CorporateActionPrice93 *-- ISO20022.Seev036002.PriceFormat87Choice
    ISO20022.Seev036002.CorporateActionPrice93 *-- ISO20022.Seev036002.PriceFormat86Choice
    ISO20022.Seev036002.CorporateActionPrice93 *-- ISO20022.Seev036002.AmountPrice4
    ISO20022.Seev036002.CorporateActionPrice93 *-- ISO20022.Seev036002.IndicativeOrMarketPrice16Choice
    ISO20022.Seev036002.CorporateActionPrice93 *-- ISO20022.Seev036002.PriceFormat85Choice
    class ISO20022.Seev036002.CorporateActionRate131 {
        + TaxblIncmPerDvddShr  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateTypeAndAmountAndStatus33~
        + AddtlTax  : ISO20022.Seev036002.RateAndAmountFormat67Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + PrratnRate  : Decimal
        + MaxAllwdOvrsbcptRate  : Decimal
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice~
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.NetDividendRateFormat41Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.GrossDividendRateFormat39Choice~
    }
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus33
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.NetDividendRateFormat41Choice
    ISO20022.Seev036002.CorporateActionRate131 *-- ISO20022.Seev036002.GrossDividendRateFormat39Choice
    class ISO20022.Seev036002.CorporateActionRate132 {
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + FinTxTaxRate  : Decimal
        + TaxCdtRate  : ISO20022.Seev036002.RateFormat28Choice
        + AplblRate  : Decimal
        + FsclStmp  : Decimal
        + ChrgsFees  : ISO20022.Seev036002.RateAndAmountFormat67Choice
        + NewToOd  : ISO20022.Seev036002.RatioFormat22Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev036002.RatioFormat21Choice
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev036002.RatioFormat21Choice
    }
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RateFormat28Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RatioFormat22Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RatioFormat21Choice
    ISO20022.Seev036002.CorporateActionRate132 *-- ISO20022.Seev036002.RatioFormat21Choice
    class ISO20022.Seev036002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev036002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev036002.DateCode22Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.DateCode22Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.DateCode35Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.DateCode35Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.DateFormat41Choice {
        + DtCd  : ISO20022.Seev036002.DateCode22Choice
        + Dt  : DateTime
    }
    ISO20022.Seev036002.DateFormat41Choice *-- ISO20022.Seev036002.DateCode22Choice
    class ISO20022.Seev036002.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev036002.DateAndDateTime2Choice
    }
    ISO20022.Seev036002.DateFormat45Choice *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.DateFormat49Choice {
        + DtCd  : ISO20022.Seev036002.DateCode22Choice
        + Dt  : ISO20022.Seev036002.DateAndDateTime2Choice
    }
    ISO20022.Seev036002.DateFormat49Choice *-- ISO20022.Seev036002.DateCode22Choice
    ISO20022.Seev036002.DateFormat49Choice *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.DateFormat67Choice {
        + DtCd  : ISO20022.Seev036002.DateCode35Choice
        + Dt  : ISO20022.Seev036002.DateAndDateTime2Choice
    }
    ISO20022.Seev036002.DateFormat67Choice *-- ISO20022.Seev036002.DateCode35Choice
    ISO20022.Seev036002.DateFormat67Choice *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev036002.DeemedRateType1Code {
        DERY = 1
        DEIT = 2
        DEFP = 3
        DEDI = 4
    }
    class ISO20022.Seev036002.DeemedRateType2Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.DeemedRateType2Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.DividendRateType1Code {
        TXBL = 1
    }
    class ISO20022.Seev036002.DocumentIdentification17 {
        + Id  : String
    }
    class ISO20022.Seev036002.DocumentIdentification37 {
        + LkgTp  : ISO20022.Seev036002.ProcessingPosition10Choice
        + Id  : String
    }
    ISO20022.Seev036002.DocumentIdentification37 *-- ISO20022.Seev036002.ProcessingPosition10Choice
    class ISO20022.Seev036002.DocumentIdentification38 {
        + LkgTp  : ISO20022.Seev036002.ProcessingPosition10Choice
        + DocNb  : ISO20022.Seev036002.DocumentNumber6Choice
        + Id  : ISO20022.Seev036002.DocumentIdentification4Choice
    }
    ISO20022.Seev036002.DocumentIdentification38 *-- ISO20022.Seev036002.ProcessingPosition10Choice
    ISO20022.Seev036002.DocumentIdentification38 *-- ISO20022.Seev036002.DocumentNumber6Choice
    ISO20022.Seev036002.DocumentIdentification38 *-- ISO20022.Seev036002.DocumentIdentification4Choice
    class ISO20022.Seev036002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev036002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev036002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev036002.DocumentNumber6Choice *-- ISO20022.Seev036002.GenericIdentification86
    class ISO20022.Seev036002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev036002.ForeignExchangeTerms41 {
        + RsltgAmt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev036002.ForeignExchangeTerms41 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Seev036002.FractionDispositionType11Code {
        RDUP = 1
        STAN = 2
        RDDN = 3
        DIST = 4
        CINL = 5
        BUYU = 6
    }
    class ISO20022.Seev036002.FractionDispositionType30Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.FractionDispositionType30Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev036002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev036002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev036002.GenericIdentification47
    }
    ISO20022.Seev036002.GenericIdentification85 *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev036002.GrossDividendRateFormat39Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus59
        + AmtAndRateSts  : ISO20022.Seev036002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.GrossDividendRateFormat39Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus59
    ISO20022.Seev036002.GrossDividendRateFormat39Choice *-- ISO20022.Seev036002.AmountAndRateStatus2
    ISO20022.Seev036002.GrossDividendRateFormat39Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.GrossDividendRateFormat40Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus61
        + AmtAndRateSts  : ISO20022.Seev036002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.GrossDividendRateFormat40Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus61
    ISO20022.Seev036002.GrossDividendRateFormat40Choice *-- ISO20022.Seev036002.AmountAndRateStatus2
    ISO20022.Seev036002.GrossDividendRateFormat40Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.GrossDividendRateType6Code {
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
    class ISO20022.Seev036002.GrossDividendRateType7Code {
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
    class ISO20022.Seev036002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev036002.IdentificationType44Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.IdentificationType44Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.IndicativeOrMarketPrice16Choice {
        + MktPric  : ISO20022.Seev036002.PriceFormat85Choice
        + IndctvPric  : ISO20022.Seev036002.PriceFormat85Choice
    }
    ISO20022.Seev036002.IndicativeOrMarketPrice16Choice *-- ISO20022.Seev036002.PriceFormat85Choice
    ISO20022.Seev036002.IndicativeOrMarketPrice16Choice *-- ISO20022.Seev036002.PriceFormat85Choice
    class ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus32
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus32
    ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.IntermediateSecurityDistributionType5Code {
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
    class ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.IssuerTaxability2Code {
        TXBL = 1
    }
    class ISO20022.Seev036002.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev036002.LotteryTypeFormat5Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.LotteryTypeFormat5Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev036002.MarketIdentification90 {
        + Tp  : ISO20022.Seev036002.MarketType16Choice
        + Id  : ISO20022.Seev036002.MarketIdentification2Choice
    }
    ISO20022.Seev036002.MarketIdentification90 *-- ISO20022.Seev036002.MarketType16Choice
    ISO20022.Seev036002.MarketIdentification90 *-- ISO20022.Seev036002.MarketIdentification2Choice
    class ISO20022.Seev036002.MarketType16Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.MarketType16Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Seev036002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Seev036002.NetDividendRateFormat41Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus60
        + AmtAndRateSts  : ISO20022.Seev036002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.NetDividendRateFormat41Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus60
    ISO20022.Seev036002.NetDividendRateFormat41Choice *-- ISO20022.Seev036002.AmountAndRateStatus2
    ISO20022.Seev036002.NetDividendRateFormat41Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.NetDividendRateFormat42Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus62
        + AmtAndRateSts  : ISO20022.Seev036002.AmountAndRateStatus2
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036002.NetDividendRateFormat42Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus62
    ISO20022.Seev036002.NetDividendRateFormat42Choice *-- ISO20022.Seev036002.AmountAndRateStatus2
    ISO20022.Seev036002.NetDividendRateFormat42Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.NetDividendRateType6Code {
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
    class ISO20022.Seev036002.NetDividendRateType7Code {
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
    class ISO20022.Seev036002.NewSecuritiesIssuanceType6Code {
        NREF = 1
        REFU = 2
        NDEF = 3
        DEFE = 4
    }
    class ISO20022.Seev036002.OptionFeatures14Code {
        RNET = 1
        RGRS = 2
        VVPR = 3
        PROR = 4
        OPLF = 5
        MAXS = 6
        MAXC = 7
        COND = 8
    }
    class ISO20022.Seev036002.OptionFeaturesFormat30Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.OptionFeaturesFormat30Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev036002.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev036002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev036002.OriginalAndCurrentQuantities7 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev036002.OtherIdentification2 {
        + Tp  : ISO20022.Seev036002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev036002.OtherIdentification2 *-- ISO20022.Seev036002.IdentificationSource4Choice
    class ISO20022.Seev036002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev036002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev036002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev036002.PartyIdentification136Choice *-- ISO20022.Seev036002.GenericIdentification84
    class ISO20022.Seev036002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Seev036002.NameAndAddress12
        + PrtryId  : ISO20022.Seev036002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev036002.PartyIdentification137Choice *-- ISO20022.Seev036002.NameAndAddress12
    ISO20022.Seev036002.PartyIdentification137Choice *-- ISO20022.Seev036002.GenericIdentification84
    class ISO20022.Seev036002.PartyIdentification147Choice {
        + PrtryId  : ISO20022.Seev036002.GenericIdentification84
        + NmAndAdr  : ISO20022.Seev036002.NameAndAddress12
        + BICFI  : String
    }
    ISO20022.Seev036002.PartyIdentification147Choice *-- ISO20022.Seev036002.GenericIdentification84
    ISO20022.Seev036002.PartyIdentification147Choice *-- ISO20022.Seev036002.NameAndAddress12
    class ISO20022.Seev036002.PartyIdentification258Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Seev036002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Seev036002.PartyIdentification258Choice *-- ISO20022.Seev036002.NameAndAddress12
    class ISO20022.Seev036002.PartyIdentification318 {
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev036002.AlternatePartyIdentification9~
        + PrcgId  : String
        + Id  : ISO20022.Seev036002.PartyIdentification258Choice
    }
    ISO20022.Seev036002.PartyIdentification318 *-- ISO20022.Seev036002.AlternatePartyIdentification9
    ISO20022.Seev036002.PartyIdentification318 *-- ISO20022.Seev036002.PartyIdentification258Choice
    class ISO20022.Seev036002.PartyIdentificationAndAccount205 {
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev036002.AlternatePartyIdentification9~
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Id  : ISO20022.Seev036002.PartyIdentification137Choice
    }
    ISO20022.Seev036002.PartyIdentificationAndAccount205 *-- ISO20022.Seev036002.AlternatePartyIdentification9
    ISO20022.Seev036002.PartyIdentificationAndAccount205 *-- ISO20022.Seev036002.PartyIdentification137Choice
    class ISO20022.Seev036002.PartyIdentificationAndAccount231 {
        + AltrnId  : ISO20022.Seev036002.AlternatePartyIdentification9
        + PrcgId  : String
        + CshAcct  : ISO20022.Seev036002.CashAccountIdentification12Choice
        + Id  : ISO20022.Seev036002.PartyIdentification137Choice
    }
    ISO20022.Seev036002.PartyIdentificationAndAccount231 *-- ISO20022.Seev036002.AlternatePartyIdentification9
    ISO20022.Seev036002.PartyIdentificationAndAccount231 *-- ISO20022.Seev036002.CashAccountIdentification12Choice
    ISO20022.Seev036002.PartyIdentificationAndAccount231 *-- ISO20022.Seev036002.PartyIdentification137Choice
    class ISO20022.Seev036002.PartyIdentificationAndAccount232 {
        + AltrnId  : ISO20022.Seev036002.AlternatePartyIdentification9
        + PrcgId  : String
        + CshAcct  : ISO20022.Seev036002.CashAccountIdentification12Choice
        + Id  : ISO20022.Seev036002.PartyIdentification147Choice
    }
    ISO20022.Seev036002.PartyIdentificationAndAccount232 *-- ISO20022.Seev036002.AlternatePartyIdentification9
    ISO20022.Seev036002.PartyIdentificationAndAccount232 *-- ISO20022.Seev036002.CashAccountIdentification12Choice
    ISO20022.Seev036002.PartyIdentificationAndAccount232 *-- ISO20022.Seev036002.PartyIdentification147Choice
    class ISO20022.Seev036002.Payment1Code {
        CONT = 1
        ACTU = 2
    }
    class ISO20022.Seev036002.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev036002.Period11 {
        + EndDt  : ISO20022.Seev036002.DateFormat45Choice
        + StartDt  : ISO20022.Seev036002.DateFormat45Choice
    }
    ISO20022.Seev036002.Period11 *-- ISO20022.Seev036002.DateFormat45Choice
    ISO20022.Seev036002.Period11 *-- ISO20022.Seev036002.DateFormat45Choice
    class ISO20022.Seev036002.PriceDetails41 {
        + CshInLieuOfShrPric  : ISO20022.Seev036002.PriceFormat85Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev036002.PriceFormat87Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev036002.PriceFormat86Choice
    }
    ISO20022.Seev036002.PriceDetails41 *-- ISO20022.Seev036002.PriceFormat85Choice
    ISO20022.Seev036002.PriceDetails41 *-- ISO20022.Seev036002.PriceFormat87Choice
    ISO20022.Seev036002.PriceDetails41 *-- ISO20022.Seev036002.PriceFormat86Choice
    class ISO20022.Seev036002.PriceFormat85Choice {
        + AmtPric  : ISO20022.Seev036002.AmountPrice5
        + PctgPric  : ISO20022.Seev036002.PercentagePrice2
    }
    ISO20022.Seev036002.PriceFormat85Choice *-- ISO20022.Seev036002.AmountPrice5
    ISO20022.Seev036002.PriceFormat85Choice *-- ISO20022.Seev036002.PercentagePrice2
    class ISO20022.Seev036002.PriceFormat86Choice {
        + IndxPts  : Decimal
        + AmtPric  : ISO20022.Seev036002.AmountPrice5
        + PctgPric  : ISO20022.Seev036002.PercentagePrice2
    }
    ISO20022.Seev036002.PriceFormat86Choice *-- ISO20022.Seev036002.AmountPrice5
    ISO20022.Seev036002.PriceFormat86Choice *-- ISO20022.Seev036002.PercentagePrice2
    class ISO20022.Seev036002.PriceFormat87Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev036002.AmountPricePerAmount3
        + AmtPricPerFinInstrmQty  : ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11
        + AmtPric  : ISO20022.Seev036002.AmountPrice5
        + PctgPric  : ISO20022.Seev036002.PercentagePrice2
    }
    ISO20022.Seev036002.PriceFormat87Choice *-- ISO20022.Seev036002.AmountPricePerAmount3
    ISO20022.Seev036002.PriceFormat87Choice *-- ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11
    ISO20022.Seev036002.PriceFormat87Choice *-- ISO20022.Seev036002.AmountPrice5
    ISO20022.Seev036002.PriceFormat87Choice *-- ISO20022.Seev036002.PercentagePrice2
    class ISO20022.Seev036002.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev036002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.ProcessingPosition10Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev036002.ProprietaryQuantity10 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev036002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev036002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev036002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev036002.Quantity53Choice *-- ISO20022.Seev036002.ProprietaryQuantity9
    ISO20022.Seev036002.Quantity53Choice *-- ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev036002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Seev036002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev036002.Quantity54Choice *-- ISO20022.Seev036002.OriginalAndCurrentQuantities4
    ISO20022.Seev036002.Quantity54Choice *-- ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev036002.Quantity57Choice {
        + SgndQty  : ISO20022.Seev036002.SignedQuantityFormat13
        + OrgnlAndCurFaceAmt  : ISO20022.Seev036002.OriginalAndCurrentQuantities7
    }
    ISO20022.Seev036002.Quantity57Choice *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.Quantity57Choice *-- ISO20022.Seev036002.OriginalAndCurrentQuantities7
    class ISO20022.Seev036002.Quantity80Choice {
        + PrtryQty  : ISO20022.Seev036002.ProprietaryQuantity10
        + QtyChc  : ISO20022.Seev036002.Quantity57Choice
    }
    ISO20022.Seev036002.Quantity80Choice *-- ISO20022.Seev036002.ProprietaryQuantity10
    ISO20022.Seev036002.Quantity80Choice *-- ISO20022.Seev036002.Quantity57Choice
    class ISO20022.Seev036002.QuantityToQuantityRatio2 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev036002.Rate45 {
        + DmdRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat68Choice~
        + EqulstnRate  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + TaxRclmRate  : Decimal
        + TaxOnPrfts  : Decimal
        + TaxOnIncm  : ISO20022.Seev036002.RateAndAmountFormat67Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.RateAndAmountFormat66Choice~
        + TaxCdtRate  : ISO20022.Seev036002.RateFormat28Choice
        + SlctnFeeRate  : ISO20022.Seev036002.SolicitationFeeRateFormat13Choice
        + AplblRate  : Decimal
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.NetDividendRateFormat42Choice~
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice~
        + ThrdPtyIncntivRate  : ISO20022.Seev036002.RateAndAmountFormat67Choice
        + EarlySlctnFeeRate  : ISO20022.Seev036002.SolicitationFeeRateFormat13Choice
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036002.GrossDividendRateFormat40Choice~
        + FsclStmp  : Decimal
        + ChrgsFees  : ISO20022.Seev036002.RateAndAmountFormat67Choice
        + AddtlTax  : ISO20022.Seev036002.RateAndAmountFormat67Choice
    }
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat68Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat66Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateFormat28Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.SolicitationFeeRateFormat13Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.NetDividendRateFormat42Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.SolicitationFeeRateFormat13Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.GrossDividendRateFormat40Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    ISO20022.Seev036002.Rate45 *-- ISO20022.Seev036002.RateAndAmountFormat67Choice
    class ISO20022.Seev036002.RateAndAmountFormat66Choice {
        + RateTpAndRate  : ISO20022.Seev036002.RateTypeAndPercentageRate16
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036002.RateAndAmountFormat66Choice *-- ISO20022.Seev036002.RateTypeAndPercentageRate16
    ISO20022.Seev036002.RateAndAmountFormat66Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.RateAndAmountFormat67Choice {
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036002.RateAndAmountFormat67Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.RateAndAmountFormat68Choice {
        + RateTpAndRate  : ISO20022.Seev036002.RateTypeAndPercentageRate17
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036002.RateTypeAndAmountAndStatus54
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036002.RateAndAmountFormat68Choice *-- ISO20022.Seev036002.RateTypeAndPercentageRate17
    ISO20022.Seev036002.RateAndAmountFormat68Choice *-- ISO20022.Seev036002.RateTypeAndAmountAndStatus54
    ISO20022.Seev036002.RateAndAmountFormat68Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.RateFormat28Choice {
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036002.RateFormat28Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036002.RateStatus1Code {
        INDI = 1
        ACTU = 2
    }
    class ISO20022.Seev036002.RateStatus4Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateStatus4Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType45Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType45Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType46Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType46Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType47Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType47Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType7Code {
        USCD = 1
        SCHD = 2
    }
    class ISO20022.Seev036002.RateType80Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType80Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType81Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType81Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType82Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType82Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateType83Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev036002.RateType83Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus32 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType45Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus32 *-- ISO20022.Seev036002.RateType45Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus33 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType47Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus33 *-- ISO20022.Seev036002.RateType47Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus54 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.DeemedRateType2Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus54 *-- ISO20022.Seev036002.DeemedRateType2Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus59 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType80Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus59 *-- ISO20022.Seev036002.RateType80Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus60 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType81Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus60 *-- ISO20022.Seev036002.RateType81Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus61 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType82Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus61 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus61 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus61 *-- ISO20022.Seev036002.RateType82Choice
    class ISO20022.Seev036002.RateTypeAndAmountAndStatus62 {
        + RateSts  : ISO20022.Seev036002.RateStatus4Choice
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036002.RateType83Choice
    }
    ISO20022.Seev036002.RateTypeAndAmountAndStatus62 *-- ISO20022.Seev036002.RateStatus4Choice
    ISO20022.Seev036002.RateTypeAndAmountAndStatus62 *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.RateTypeAndAmountAndStatus62 *-- ISO20022.Seev036002.RateType83Choice
    class ISO20022.Seev036002.RateTypeAndPercentageRate16 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev036002.RateType46Choice
    }
    ISO20022.Seev036002.RateTypeAndPercentageRate16 *-- ISO20022.Seev036002.RateType46Choice
    class ISO20022.Seev036002.RateTypeAndPercentageRate17 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev036002.DeemedRateType2Choice
    }
    ISO20022.Seev036002.RateTypeAndPercentageRate17 *-- ISO20022.Seev036002.DeemedRateType2Choice
    class ISO20022.Seev036002.RatioFormat21Choice {
        + AmtToAmt  : ISO20022.Seev036002.AmountToAmountRatio3
        + QtyToQty  : ISO20022.Seev036002.QuantityToQuantityRatio2
    }
    ISO20022.Seev036002.RatioFormat21Choice *-- ISO20022.Seev036002.AmountToAmountRatio3
    ISO20022.Seev036002.RatioFormat21Choice *-- ISO20022.Seev036002.QuantityToQuantityRatio2
    class ISO20022.Seev036002.RatioFormat22Choice {
        + QtyToAmt  : ISO20022.Seev036002.AmountAndQuantityRatio5
        + AmtToQty  : ISO20022.Seev036002.AmountAndQuantityRatio5
        + AmtToAmt  : ISO20022.Seev036002.AmountToAmountRatio3
        + QtyToQty  : ISO20022.Seev036002.QuantityToQuantityRatio2
    }
    ISO20022.Seev036002.RatioFormat22Choice *-- ISO20022.Seev036002.AmountAndQuantityRatio5
    ISO20022.Seev036002.RatioFormat22Choice *-- ISO20022.Seev036002.AmountAndQuantityRatio5
    ISO20022.Seev036002.RatioFormat22Choice *-- ISO20022.Seev036002.AmountToAmountRatio3
    ISO20022.Seev036002.RatioFormat22Choice *-- ISO20022.Seev036002.QuantityToQuantityRatio2
    class ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev036002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev036002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev036002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Seev036002.SafekeepingPlaceFormat49Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification85
        + TpAndId  : ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev036002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev036002.SafekeepingPlaceFormat49Choice *-- ISO20022.Seev036002.GenericIdentification85
    ISO20022.Seev036002.SafekeepingPlaceFormat49Choice *-- ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev036002.SafekeepingPlaceFormat49Choice *-- ISO20022.Seev036002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev036002.SafekeepingPlaceFormat50Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification85
        + TpAndId  : ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev036002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Seev036002.SafekeepingPlaceFormat50Choice *-- ISO20022.Seev036002.GenericIdentification85
    ISO20022.Seev036002.SafekeepingPlaceFormat50Choice *-- ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev036002.SafekeepingPlaceFormat50Choice *-- ISO20022.Seev036002.SafekeepingPlaceTypeAndText15
    class ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036002.SecuritiesOption115 {
        + DlvrgSttlmPties  : ISO20022.Seev036002.SettlementParties130
        + RcvgSttlmPties  : ISO20022.Seev036002.SettlementParties130
        + AmtDtls  : ISO20022.Seev036002.CorporateActionAmounts61
        + PricDtls  : ISO20022.Seev036002.CorporateActionPrice93
        + RateDtls  : ISO20022.Seev036002.CorporateActionRate132
        + DtDtls  : ISO20022.Seev036002.SecurityDate26
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev036002.FractionDispositionType30Choice
        + SfkpgPlc  : ISO20022.Seev036002.SafekeepingPlaceFormat50Choice
        + PstngQty  : ISO20022.Seev036002.Quantity54Choice
        + CtryOfIncmSrc  : String
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev036002.GenericIdentification47~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev036002.GenericIdentification47~
        + IncmTp  : ISO20022.Seev036002.GenericIdentification47
        + IssrOfferrTaxbltyInd  : ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice
        + NewSctiesIssncInd  : String
        + TempFinInstrmInd  : ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice
        + CdtDbtInd  : String
        + FinInstrmId  : ISO20022.Seev036002.SecurityIdentification20
    }
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.SettlementParties130
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.SettlementParties130
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.CorporateActionAmounts61
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.CorporateActionPrice93
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.CorporateActionRate132
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.SecurityDate26
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.FractionDispositionType30Choice
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.SafekeepingPlaceFormat50Choice
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.Quantity54Choice
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.GenericIdentification47
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice
    ISO20022.Seev036002.SecuritiesOption115 *-- ISO20022.Seev036002.SecurityIdentification20
    class ISO20022.Seev036002.SecurityDate26 {
        + PmtDt  : ISO20022.Seev036002.DateFormat41Choice
        + EarlstPmtDt  : ISO20022.Seev036002.DateFormat41Choice
        + DvddRnkgDt  : ISO20022.Seev036002.DateFormat41Choice
        + PrpssDt  : ISO20022.Seev036002.DateFormat41Choice
        + AvlblDt  : ISO20022.Seev036002.DateFormat41Choice
        + PstngDt  : ISO20022.Seev036002.DateAndDateTime2Choice
    }
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateFormat41Choice
    ISO20022.Seev036002.SecurityDate26 *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev036002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev036002.SecurityIdentification20 *-- ISO20022.Seev036002.OtherIdentification2
    class ISO20022.Seev036002.SettlementParties130 {
        + Pty3  : ISO20022.Seev036002.PartyIdentificationAndAccount205
        + Pty2  : ISO20022.Seev036002.PartyIdentificationAndAccount205
        + Pty1  : ISO20022.Seev036002.PartyIdentificationAndAccount205
        + Dpstry  : ISO20022.Seev036002.PartyIdentification318
    }
    ISO20022.Seev036002.SettlementParties130 *-- ISO20022.Seev036002.PartyIdentificationAndAccount205
    ISO20022.Seev036002.SettlementParties130 *-- ISO20022.Seev036002.PartyIdentificationAndAccount205
    ISO20022.Seev036002.SettlementParties130 *-- ISO20022.Seev036002.PartyIdentificationAndAccount205
    ISO20022.Seev036002.SettlementParties130 *-- ISO20022.Seev036002.PartyIdentification318
    class ISO20022.Seev036002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev036002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev036002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev036002.SignedQuantityFormat12 *-- ISO20022.Seev036002.Quantity53Choice
    class ISO20022.Seev036002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev036002.SignedQuantityFormat13 *-- ISO20022.Seev036002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev036002.SolicitationFeeRateFormat13Choice {
        + Amt  : ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtToQty  : ISO20022.Seev036002.AmountAndQuantityRatio5
        + Rate  : Decimal
    }
    ISO20022.Seev036002.SolicitationFeeRateFormat13Choice *-- ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036002.SolicitationFeeRateFormat13Choice *-- ISO20022.Seev036002.AmountAndQuantityRatio5
    class ISO20022.Seev036002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev036002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev036002.SupplementaryData1 *-- ISO20022.Seev036002.SupplementaryDataEnvelope1
    class ISO20022.Seev036002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev036002.TaxVoucher5 {
        + BrgnSttlmDt  : ISO20022.Seev036002.DateAndDateTime2Choice
        + BrgnDt  : ISO20022.Seev036002.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Seev036002.TaxVoucher5 *-- ISO20022.Seev036002.DateAndDateTime2Choice
    ISO20022.Seev036002.TaxVoucher5 *-- ISO20022.Seev036002.DateAndDateTime2Choice
    class ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice {
        + Prtry  : ISO20022.Seev036002.GenericIdentification47
        + TempInd  : String
    }
    ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice *-- ISO20022.Seev036002.GenericIdentification47
    class ISO20022.Seev036002.TotalEligibleBalanceFormat11 {
        + PartWayPrdUnits  : ISO20022.Seev036002.SignedQuantityFormat13
        + FullPrdUnits  : ISO20022.Seev036002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev036002.Quantity80Choice
    }
    ISO20022.Seev036002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev036002.SignedQuantityFormat13
    ISO20022.Seev036002.TotalEligibleBalanceFormat11 *-- ISO20022.Seev036002.Quantity80Choice
    class ISO20022.Seev036002.TransactionIdentification1 {
        + MktInfrstrctrTxId  : String
    }
    class ISO20022.Seev036002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Seev036002.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev036002.Account11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxAcct|ISO20022.Seev036002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Seev036002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev036002.CashAccountIdentification12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAcct),validElement(ChrgsAcct),validElement(CshAcct),validChoice(TaxAcct,ChrgsAcct,CshAcct))|

---

## Value ISO20022.Seev036002.AccountAndBalance63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev036002.CorporateActionBalanceDetails45||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev036002.SafekeepingPlaceFormat49Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev036002.PartyIdentification136Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Seev036002.AdditionalBusinessProcess12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCHM|Int32||XmlEnum("""SCHM""")|1|
||PPRE|Int32||XmlEnum("""PPRE""")|2|
||PPUT|Int32||XmlEnum("""PPUT""")|3|
||NPLE|Int32||XmlEnum("""NPLE""")|4|
||INCP|Int32||XmlEnum("""INCP""")|5|
||FPRE|Int32||XmlEnum("""FPRE""")|6|
||CONS|Int32||XmlEnum("""CONS""")|7|
||TAXR|Int32||XmlEnum("""TAXR""")|8|
||CLPT|Int32||XmlEnum("""CLPT""")|9|
||CLNT|Int32||XmlEnum("""CLNT""")|10|
||CLAI|Int32||XmlEnum("""CLAI""")|11|
||CLFT|Int32||XmlEnum("""CLFT""")|12|

---

## Value ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Seev036002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Seev036002.AmountAndQuantityRatio5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev036002.AmountAndRateStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|String||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev036002.AmountPrice4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev036002.AmountPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev036002.AmountPricePerAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev036002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PricVal|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev036002.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Enum ISO20022.Seev036002.AmountPriceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Value ISO20022.Seev036002.AmountToAmountRatio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Amt1|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Value ISO20022.Seev036002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev036002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev036002.BalanceFormat16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|NotElgblBal|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev036002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(PartWayPrdUnits,FullPrdUnits,NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev036002.BlockChainAddressWallet11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev036002.CashAccountIdentification12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev036002.BlockChainAddressWallet11||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev036002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Seev036002.CashOption110


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Seev036002.PriceDetails41||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev036002.Rate45||XmlElement()||
|+|TaxVchrDtls|ISO20022.Seev036002.TaxVoucher5||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Seev036002.ForeignExchangeTerms41>||XmlElement()||
|+|DtDtls|ISO20022.Seev036002.CorporateActionDate99||XmlElement()||
|+|AmtDtls|ISO20022.Seev036002.CorporateActionAmounts74||XmlElement()||
|+|CshPties|ISO20022.Seev036002.CashParties44||XmlElement()||
|+|Acct|ISO20022.Seev036002.Account11Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev036002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev036002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|CtrctlPmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(RateAndAmtDtls),validElement(TaxVchrDtls),validList("""FXDtls""",FXDtls),validElement(FXDtls),validElement(DtDtls),validElement(AmtDtls),validElement(CshPties),validElement(Acct),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd))|

---

## Value ISO20022.Seev036002.CashParties44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktClmCtrPty|ISO20022.Seev036002.PartyIdentificationAndAccount231||XmlElement()||
|+|CdtrAgt|ISO20022.Seev036002.PartyIdentificationAndAccount232||XmlElement()||
|+|Cdtr|ISO20022.Seev036002.PartyIdentificationAndAccount231||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktClmCtrPty),validElement(CdtrAgt),validElement(Cdtr))|

---

## Value ISO20022.Seev036002.CorporateAction86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev036002.LotteryTypeFormat5Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev036002.AdditionalBusinessProcessFormat24Choice>||XmlElement()||
|+|EvtStag|ISO20022.Seev036002.CorporateActionEventStageFormat15Choice||XmlElement()||
|+|DtDtls|ISO20022.Seev036002.CorporateActionDate89||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validElement(IntrmdtSctiesDstrbtnTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(DtDtls))|

---

## Value ISO20022.Seev036002.CorporateActionAmounts61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt))|

---

## Value ISO20022.Seev036002.CorporateActionAmounts74


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuyUpAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RfnddSbcptAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AdjstdSbcptAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdRyltsAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdIntrstAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdFndAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdDvddAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FrgnIncmAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|DmdAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TxTax|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxOnIncmAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|BckUpWhldgTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NRATaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FATCATaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EqulstnAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|EUTaxRtntnAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StockXchgTax|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IncmPrtn|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RedPrmAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PrncplOrCrps|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxArrearsAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NtnlTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NtnlDvddPyblAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CshAmtCrrdFwd|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CshAmtBrghtFwd|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ChrgsAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ScndLvlTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddPmtAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|MktClmAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|GrssAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|PstngAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyUpAmt),validElement(RfnddSbcptAmt),validElement(AdjstdSbcptAmt),validElement(DmdRyltsAmt),validElement(DmdIntrstAmt),validElement(DmdFndAmt),validElement(DmdDvddAmt),validElement(FrgnIncmAmt),validElement(DmdAmt),validElement(TxTax),validElement(TaxOnIncmAmt),validElement(BckUpWhldgTaxAmt),validElement(NRATaxAmt),validElement(FATCATaxAmt),validElement(EqulstnAmt),validElement(AcrdIntrstAmt),validElement(EUTaxRtntnAmt),validElement(StockXchgTax),validElement(IncmPrtn),validElement(RedPrmAmt),validElement(PrncplOrCrps),validElement(OrgnlAmt),validElement(TaxArrearsAmt),validElement(NtnlTaxAmt),validElement(NtnlDvddPyblAmt),validElement(CshAmtCrrdFwd),validElement(CshAmtBrghtFwd),validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(ValAddedTaxAmt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(RinvstmtAmt),validElement(ManfctrdDvddPmtAmt),validElement(IndmntyAmt),validElement(MktClmAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(NetAmt),validElement(GrssAmt),validElement(PstngAmt))|

---

## Value ISO20022.Seev036002.CorporateActionBalanceDetails45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UafctdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|AfctdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|RegdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|SttlmPosBal|global::System.Collections.Generic.List<ISO20022.Seev036002.BalanceFormat16Choice>||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev036002.BalanceFormat16Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev036002.BalanceFormat16Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev036002.TotalEligibleBalanceFormat11||XmlElement()||
|+|ConfdBal|ISO20022.Seev036002.BalanceFormat14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UafctdBal),validElement(AfctdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validList("""SttlmPosBal""",SttlmPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal),validElement(ConfdBal))|

---

## Value ISO20022.Seev036002.CorporateActionDate109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgDt|ISO20022.Seev036002.DateFormat49Choice||XmlElement()||
|+|CoverXprtnDdln|ISO20022.Seev036002.DateFormat67Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradgDt),validElement(CoverXprtnDdln))|

---

## Value ISO20022.Seev036002.CorporateActionDate89


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExDvddDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExDvddDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev036002.CorporateActionDate99


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|DateTime||XmlElement()||
|+|EarlstPmtDt|DateTime||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|PstngDt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXRateFxgDt),validElement(PstngDt))|

---

## Value ISO20022.Seev036002.CorporateActionEventReference4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036002.ProcessingPosition10Choice||XmlElement()||
|+|EvtId|ISO20022.Seev036002.CorporateActionEventReference4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev036002.CorporateActionEventReference4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LkdCorpActnId""",LkdCorpActnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LkdOffclCorpActnEvtId""",LkdOffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev036002.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev036002.CorporateActionEventStageFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.CorporateActionEventType120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.CorporateActionEventType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
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

## Value ISO20022.Seev036002.CorporateActionGeneralInformation190


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrctnlQty|ISO20022.Seev036002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev036002.SecurityIdentification20||XmlElement()||
|+|EvtTp|ISO20022.Seev036002.CorporateActionEventType120Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrctnlQty),validElement(FinInstrmId),validElement(EvtTp),validPattern("""ClssActnNb""",ClssActnNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Aspect ISO20022.Seev036002.CorporateActionMovementConfirmation002V16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev036002.SupplementaryData1>||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev036002.PartyIdentification137Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev036002.PartyIdentification137Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev036002.PartyIdentification137Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev036002.CorporateActionNarrative35||XmlElement()||
|+|CorpActnConfDtls|ISO20022.Seev036002.CorporateActionOption244||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev036002.CorporateAction86||XmlElement()||
|+|AcctDtls|ISO20022.Seev036002.AccountAndBalance63||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev036002.CorporateActionGeneralInformation190||XmlElement()||
|+|TxId|ISO20022.Seev036002.TransactionIdentification1||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev036002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev036002.DocumentIdentification38>||XmlElement()||
|+|InstrId|ISO20022.Seev036002.DocumentIdentification17||XmlElement()||
|+|MvmntPrlimryAdvcId|ISO20022.Seev036002.DocumentIdentification37||XmlElement()||
|+|NtfctnId|ISO20022.Seev036002.DocumentIdentification37||XmlElement()||
|+|MvmntConfId|String||XmlElement()||
|+|Pgntn|ISO20022.Seev036002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validElement(CorpActnConfDtls),validElement(CorpActnDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxId),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(MvmntPrlimryAdvcId),validElement(NtfctnId),validPattern("""MvmntConfId""",MvmntConfId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Pgntn))|

---

## Value ISO20022.Seev036002.CorporateActionNarrative35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxtnConds|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TaxtnConds""",TaxtnConds,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctNrrtv""",PtyCtctNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""NrrtvVrsn""",NrrtvVrsn,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""AddtlTxt""",AddtlTxt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Seev036002.CorporateActionOption12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRUN|Int32||XmlEnum("""PRUN""")|1|
||SLLE|Int32||XmlEnum("""SLLE""")|2|
||SECU|Int32||XmlEnum("""SECU""")|3|
||QINV|Int32||XmlEnum("""QINV""")|4|
||OVER|Int32||XmlEnum("""OVER""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||OFFR|Int32||XmlEnum("""OFFR""")|7|
||NOQU|Int32||XmlEnum("""NOQU""")|8|
||NOAC|Int32||XmlEnum("""NOAC""")|9|
||MPUT|Int32||XmlEnum("""MPUT""")|10|
||MKUP|Int32||XmlEnum("""MKUP""")|11|
||MKDW|Int32||XmlEnum("""MKDW""")|12|
||LAPS|Int32||XmlEnum("""LAPS""")|13|
||EXER|Int32||XmlEnum("""EXER""")|14|
||CTEN|Int32||XmlEnum("""CTEN""")|15|
||CONY|Int32||XmlEnum("""CONY""")|16|
||CONN|Int32||XmlEnum("""CONN""")|17|
||CEXC|Int32||XmlEnum("""CEXC""")|18|
||CASH|Int32||XmlEnum("""CASH""")|19|
||CASE|Int32||XmlEnum("""CASE""")|20|
||BUYA|Int32||XmlEnum("""BUYA""")|21|
||BSPL|Int32||XmlEnum("""BSPL""")|22|
||ABST|Int32||XmlEnum("""ABST""")|23|

---

## Value ISO20022.Seev036002.CorporateActionOption244


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev036002.CashOption110>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev036002.SecuritiesOption115>||XmlElement()||
|+|PlcOfTrad|ISO20022.Seev036002.MarketIdentification90||XmlElement()||
|+|PricDtls|ISO20022.Seev036002.CorporateActionPrice92||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev036002.CorporateActionRate131||XmlElement()||
|+|PrdDtls|ISO20022.Seev036002.CorporateActionPeriod13||XmlElement()||
|+|DtDtls|ISO20022.Seev036002.CorporateActionDate109||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev036002.FractionDispositionType30Choice||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev036002.OptionFeaturesFormat30Choice>||XmlElement()||
|+|OptnTp|ISO20022.Seev036002.CorporateActionOption39Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev036002.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(PlcOfTrad),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev036002.CorporateActionOption39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.CorporateActionPeriod13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ParllTradgPrd|ISO20022.Seev036002.Period11||XmlElement()||
|+|ActnPrd|ISO20022.Seev036002.Period11||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev036002.Period11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ParllTradgPrd),validElement(ActnPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev036002.CorporateActionPrice92


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OverSbcptDpstPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OverSbcptDpstPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev036002.CorporateActionPrice93


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricRcvdPerPdct|ISO20022.Seev036002.PriceFormat87Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev036002.PriceFormat86Choice||XmlElement()||
|+|CshValForTax|ISO20022.Seev036002.AmountPrice4||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev036002.IndicativeOrMarketPrice16Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct),validElement(CshValForTax),validElement(IndctvOrMktPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev036002.CorporateActionRate131


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblIncmPerDvddShr|global::System.Collections.Generic.List<ISO20022.Seev036002.RateTypeAndAmountAndStatus33>||XmlElement()||
|+|AddtlTax|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|PrratnRate|Decimal||XmlElement()||
|+|MaxAllwdOvrsbcptRate|Decimal||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice>||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036002.NetDividendRateFormat41Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036002.GrossDividendRateFormat39Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxblIncmPerDvddShr""",TaxblIncmPerDvddShr),validElement(TaxblIncmPerDvddShr),validElement(AddtlTax),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate))|

---

## Value ISO20022.Seev036002.CorporateActionRate132


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|FinTxTaxRate|Decimal||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev036002.RateFormat28Choice||XmlElement()||
|+|AplblRate|Decimal||XmlElement()||
|+|FsclStmp|Decimal||XmlElement()||
|+|ChrgsFees|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
|+|NewToOd|ISO20022.Seev036002.RatioFormat22Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev036002.RatioFormat21Choice||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev036002.RatioFormat21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(TaxCdtRate),validElement(ChrgsFees),validElement(NewToOd),validElement(AddtlQtyForExstgScties),validElement(AddtlQtyForSbcbdRsltntScties))|

---

## Enum ISO20022.Seev036002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev036002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev036002.DateCode22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.DateCode35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.DateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev036002.DateCode22Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev036002.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Value ISO20022.Seev036002.DateFormat49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev036002.DateCode22Choice||XmlElement()||
|+|Dt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev036002.DateFormat67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev036002.DateCode35Choice||XmlElement()||
|+|Dt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev036002.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Enum ISO20022.Seev036002.DeemedRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERY|Int32||XmlEnum("""DERY""")|1|
||DEIT|Int32||XmlEnum("""DEIT""")|2|
||DEFP|Int32||XmlEnum("""DEFP""")|3|
||DEDI|Int32||XmlEnum("""DEDI""")|4|

---

## Value ISO20022.Seev036002.DeemedRateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.DividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Type ISO20022.Seev036002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnMvmntConf|ISO20022.Seev036002.CorporateActionMovementConfirmation002V16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnMvmntConf))|

---

## Value ISO20022.Seev036002.DocumentIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.DocumentIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036002.ProcessingPosition10Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.DocumentIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036002.ProcessingPosition10Choice||XmlElement()||
|+|DocNb|ISO20022.Seev036002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev036002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev036002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev036002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev036002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev036002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev036002.ForeignExchangeTerms41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev036002.FractionDispositionType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDUP|Int32||XmlEnum("""RDUP""")|1|
||STAN|Int32||XmlEnum("""STAN""")|2|
||RDDN|Int32||XmlEnum("""RDDN""")|3|
||DIST|Int32||XmlEnum("""DIST""")|4|
||CINL|Int32||XmlEnum("""CINL""")|5|
||BUYU|Int32||XmlEnum("""BUYU""")|6|

---

## Value ISO20022.Seev036002.FractionDispositionType30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev036002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.GrossDividendRateFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus59||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev036002.GrossDividendRateFormat40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus61||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev036002.GrossDividendRateType6Code


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

## Enum ISO20022.Seev036002.GrossDividendRateType7Code


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

## Value ISO20022.Seev036002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.IndicativeOrMarketPrice16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Value ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus32||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev036002.IntermediateSecuritiesDistributionTypeFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.IntermediateSecurityDistributionType5Code


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

## Value ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.IssuerTaxability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Enum ISO20022.Seev036002.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev036002.LotteryTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev036002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev036002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Seev036002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Seev036002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Seev036002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Seev036002.NetDividendRateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus60||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev036002.NetDividendRateFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus62||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036002.AmountAndRateStatus2||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev036002.NetDividendRateType6Code


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

## Enum ISO20022.Seev036002.NetDividendRateType7Code


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

## Enum ISO20022.Seev036002.NewSecuritiesIssuanceType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NREF|Int32||XmlEnum("""NREF""")|1|
||REFU|Int32||XmlEnum("""REFU""")|2|
||NDEF|Int32||XmlEnum("""NDEF""")|3|
||DEFE|Int32||XmlEnum("""DEFE""")|4|

---

## Enum ISO20022.Seev036002.OptionFeatures14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNET|Int32||XmlEnum("""RNET""")|1|
||RGRS|Int32||XmlEnum("""RGRS""")|2|
||VVPR|Int32||XmlEnum("""VVPR""")|3|
||PROR|Int32||XmlEnum("""PROR""")|4|
||OPLF|Int32||XmlEnum("""OPLF""")|5|
||MAXS|Int32||XmlEnum("""MAXS""")|6|
||MAXC|Int32||XmlEnum("""MAXC""")|7|
||COND|Int32||XmlEnum("""COND""")|8|

---

## Value ISO20022.Seev036002.OptionFeaturesFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev036002.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev036002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036002.OriginalAndCurrentQuantities7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev036002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev036002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev036002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev036002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev036002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev036002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev036002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev036002.PartyIdentification147Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev036002.GenericIdentification84||XmlElement()||
|+|NmAndAdr|ISO20022.Seev036002.NameAndAddress12||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Seev036002.PartyIdentification258Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev036002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Seev036002.PartyIdentification318


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev036002.AlternatePartyIdentification9>||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|Id|ISO20022.Seev036002.PartyIdentification258Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AltrnId""",AltrnId),validElement(AltrnId),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Id))|

---

## Value ISO20022.Seev036002.PartyIdentificationAndAccount205


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev036002.AlternatePartyIdentification9>||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Id|ISO20022.Seev036002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AltrnId""",AltrnId),validElement(AltrnId),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(Id))|

---

## Value ISO20022.Seev036002.PartyIdentificationAndAccount231


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Seev036002.AlternatePartyIdentification9||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Seev036002.CashAccountIdentification12Choice||XmlElement()||
|+|Id|ISO20022.Seev036002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(CshAcct),validElement(Id))|

---

## Value ISO20022.Seev036002.PartyIdentificationAndAccount232


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Seev036002.AlternatePartyIdentification9||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Seev036002.CashAccountIdentification12Choice||XmlElement()||
|+|Id|ISO20022.Seev036002.PartyIdentification147Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(CshAcct),validElement(Id))|

---

## Enum ISO20022.Seev036002.Payment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONT|Int32||XmlEnum("""CONT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev036002.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036002.Period11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev036002.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Seev036002.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev036002.PriceDetails41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInLieuOfShrPric|ISO20022.Seev036002.PriceFormat85Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev036002.PriceFormat87Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev036002.PriceFormat86Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInLieuOfShrPric),validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct))|

---

## Value ISO20022.Seev036002.PriceFormat85Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtPric|ISO20022.Seev036002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev036002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(AmtPric,PctgPric))|

---

## Value ISO20022.Seev036002.PriceFormat86Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPric|ISO20022.Seev036002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev036002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPric,PctgPric))|

---

## Value ISO20022.Seev036002.PriceFormat87Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev036002.AmountPricePerAmount3||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev036002.AmountPricePerFinancialInstrumentQuantity11||XmlElement()||
|+|AmtPric|ISO20022.Seev036002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev036002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev036002.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Value ISO20022.Seev036002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev036002.ProprietaryQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev036002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev036002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev036002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev036002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Seev036002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev036002.Quantity57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev036002.OriginalAndCurrentQuantities7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev036002.Quantity80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev036002.ProprietaryQuantity10||XmlElement()||
|+|QtyChc|ISO20022.Seev036002.Quantity57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev036002.QuantityToQuantityRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036002.Rate45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmdRate|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat68Choice>||XmlElement()||
|+|EqulstnRate|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|TaxRclmRate|Decimal||XmlElement()||
|+|TaxOnPrfts|Decimal||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036002.RateAndAmountFormat66Choice>||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev036002.RateFormat28Choice||XmlElement()||
|+|SlctnFeeRate|ISO20022.Seev036002.SolicitationFeeRateFormat13Choice||XmlElement()||
|+|AplblRate|Decimal||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036002.NetDividendRateFormat42Choice>||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev036002.InterestRateUsedForPaymentFormat19Choice>||XmlElement()||
|+|ThrdPtyIncntivRate|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
|+|EarlySlctnFeeRate|ISO20022.Seev036002.SolicitationFeeRateFormat13Choice||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036002.GrossDividendRateFormat40Choice>||XmlElement()||
|+|FsclStmp|Decimal||XmlElement()||
|+|ChrgsFees|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
|+|AddtlTax|ISO20022.Seev036002.RateAndAmountFormat67Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DmdRate""",DmdRate),validElement(DmdRate),validElement(EqulstnRate),validElement(TaxOnIncm),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(TaxCdtRate),validElement(SlctnFeeRate),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validElement(ThrdPtyIncntivRate),validElement(EarlySlctnFeeRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(ChrgsFees),validElement(AddtlTax))|

---

## Value ISO20022.Seev036002.RateAndAmountFormat66Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev036002.RateTypeAndPercentageRate16||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,Rate))|

---

## Value ISO20022.Seev036002.RateAndAmountFormat67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev036002.RateAndAmountFormat68Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev036002.RateTypeAndPercentageRate17||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036002.RateTypeAndAmountAndStatus54||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndRate,RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev036002.RateFormat28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Seev036002.RateStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDI|Int32||XmlEnum("""INDI""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev036002.RateStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036002.RateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USCD|Int32||XmlEnum("""USCD""")|1|
||SCHD|Int32||XmlEnum("""SCHD""")|2|

---

## Value ISO20022.Seev036002.RateType80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType81Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType82Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateType83Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType81Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType82Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndAmountAndStatus62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036002.RateStatus4Choice||XmlElement()||
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType83Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndPercentageRate16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev036002.RateType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev036002.RateTypeAndPercentageRate17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev036002.DeemedRateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev036002.RatioFormat21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtToAmt|ISO20022.Seev036002.AmountToAmountRatio3||XmlElement()||
|+|QtyToQty|ISO20022.Seev036002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtToAmt),validElement(QtyToQty),validChoice(AmtToAmt,QtyToQty))|

---

## Value ISO20022.Seev036002.RatioFormat22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyToAmt|ISO20022.Seev036002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToQty|ISO20022.Seev036002.AmountAndQuantityRatio5||XmlElement()||
|+|AmtToAmt|ISO20022.Seev036002.AmountToAmountRatio3||XmlElement()||
|+|QtyToQty|ISO20022.Seev036002.QuantityToQuantityRatio2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(QtyToAmt,AmtToQty,AmtToAmt,QtyToQty))|

---

## Value ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev036002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev036002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev036002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Enum ISO20022.Seev036002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Seev036002.SafekeepingPlaceFormat49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev036002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev036002.SafekeepingPlaceFormat50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev036002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev036002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev036002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.SecuritiesOption115


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSttlmPties|ISO20022.Seev036002.SettlementParties130||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Seev036002.SettlementParties130||XmlElement()||
|+|AmtDtls|ISO20022.Seev036002.CorporateActionAmounts61||XmlElement()||
|+|PricDtls|ISO20022.Seev036002.CorporateActionPrice93||XmlElement()||
|+|RateDtls|ISO20022.Seev036002.CorporateActionRate132||XmlElement()||
|+|DtDtls|ISO20022.Seev036002.SecurityDate26||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev036002.FractionDispositionType30Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev036002.SafekeepingPlaceFormat50Choice||XmlElement()||
|+|PstngQty|ISO20022.Seev036002.Quantity54Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev036002.GenericIdentification47>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev036002.GenericIdentification47>||XmlElement()||
|+|IncmTp|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev036002.IssuerOfferorTaxabilityIndicator1Choice||XmlElement()||
|+|NewSctiesIssncInd|String||XmlElement()||
|+|TempFinInstrmInd|ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Seev036002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSttlmPties),validElement(RcvgSttlmPties),validElement(AmtDtls),validElement(PricDtls),validElement(RateDtls),validElement(DtDtls),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validElement(SfkpgPlc),validElement(PstngQty),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(TempFinInstrmInd),validElement(FinInstrmId))|

---

## Value ISO20022.Seev036002.SecurityDate26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev036002.DateFormat41Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtDt),validElement(EarlstPmtDt),validElement(DvddRnkgDt),validElement(PrpssDt),validElement(AvlblDt),validElement(PstngDt))|

---

## Value ISO20022.Seev036002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev036002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev036002.SettlementParties130


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty3|ISO20022.Seev036002.PartyIdentificationAndAccount205||XmlElement()||
|+|Pty2|ISO20022.Seev036002.PartyIdentificationAndAccount205||XmlElement()||
|+|Pty1|ISO20022.Seev036002.PartyIdentificationAndAccount205||XmlElement()||
|+|Dpstry|ISO20022.Seev036002.PartyIdentification318||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Seev036002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev036002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev036002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev036002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev036002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev036002.SolicitationFeeRateFormat13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtToQty|ISO20022.Seev036002.AmountAndQuantityRatio5||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(AmtToQty),validChoice(Amt,AmtToQty,Rate))|

---

## Value ISO20022.Seev036002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev036002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev036002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036002.TaxVoucher5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrgnSttlmDt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
|+|BrgnDt|ISO20022.Seev036002.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrgnSttlmDt),validElement(BrgnDt),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev036002.TemporaryFinancialInstrumentIndicator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036002.GenericIdentification47||XmlElement()||
|+|TempInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,TempInd))|

---

## Value ISO20022.Seev036002.TotalEligibleBalanceFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev036002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev036002.Quantity80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(Bal))|

---

## Value ISO20022.Seev036002.TransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktInfrstrctrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Enum ISO20022.Seev036002.TypeOfIdentification1Code


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

## Enum ISO20022.Seev036002.WithholdingTaxRateType1Code


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

