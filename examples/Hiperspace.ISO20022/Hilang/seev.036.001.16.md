# seev.036.001.16
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev036001.Account10Choice {
        + TaxAcct  : ISO20022.Seev036001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Seev036001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Seev036001.CashAccountIdentification9Choice
    }
    ISO20022.Seev036001.Account10Choice *-- ISO20022.Seev036001.CashAccountIdentification5Choice
    ISO20022.Seev036001.Account10Choice *-- ISO20022.Seev036001.CashAccountIdentification5Choice
    ISO20022.Seev036001.Account10Choice *-- ISO20022.Seev036001.CashAccountIdentification9Choice
    class ISO20022.Seev036001.AccountAndBalance58 {
        + Bal  : ISO20022.Seev036001.CorporateActionBalanceDetails41
        + SfkpgPlc  : ISO20022.Seev036001.SafekeepingPlaceFormat42Choice
        + AcctOwnr  : ISO20022.Seev036001.PartyIdentification127Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev036001.AccountAndBalance58 *-- ISO20022.Seev036001.CorporateActionBalanceDetails41
    ISO20022.Seev036001.AccountAndBalance58 *-- ISO20022.Seev036001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev036001.AccountAndBalance58 *-- ISO20022.Seev036001.PartyIdentification127Choice
    class ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev036001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev036001.AdditionalBusinessProcess12Code {
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
    class ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev036001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Seev036001.IdentificationType42Choice
    }
    ISO20022.Seev036001.AlternatePartyIdentification7 *-- ISO20022.Seev036001.IdentificationType42Choice
    class ISO20022.Seev036001.AmountAndQuantityRatio4 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.AmountAndQuantityRatio4 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountAndRateStatus1 {
        + RateSts  : String
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.AmountAndRateStatus1 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountPrice2 {
        + PricVal  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036001.AmountPrice2 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountPrice3 {
        + PricVal  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036001.AmountPrice3 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountPricePerAmount2 {
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036001.AmountPricePerAmount2 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.AmountPricePerAmount2 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10 {
        + FinInstrmQty  : ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
        + PricVal  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev036001.AmountPriceType2Code {
        ACTU = 1
    }
    class ISO20022.Seev036001.AmountToAmountRatio2 {
        + Amt2  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Amt1  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.AmountToAmountRatio2 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.AmountToAmountRatio2 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.BalanceFormat11Choice {
        + NotElgblBal  : ISO20022.Seev036001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev036001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev036001.SignedQuantityFormat11
    }
    ISO20022.Seev036001.BalanceFormat11Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat11Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat11Choice *-- ISO20022.Seev036001.SignedQuantityFormat11
    class ISO20022.Seev036001.BalanceFormat12Choice {
        + PartWayPrdUnits  : ISO20022.Seev036001.SignedQuantityFormat10
        + FullPrdUnits  : ISO20022.Seev036001.SignedQuantityFormat10
        + NotElgblBal  : ISO20022.Seev036001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev036001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev036001.SignedQuantityFormat11
    }
    ISO20022.Seev036001.BalanceFormat12Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat12Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat12Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat12Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.BalanceFormat12Choice *-- ISO20022.Seev036001.SignedQuantityFormat11
    class ISO20022.Seev036001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Seev036001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Seev036001.BlockChainAddressWallet3 *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Seev036001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev036001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Seev036001.CashAccountIdentification9Choice *-- ISO20022.Seev036001.BlockChainAddressWallet3
    class ISO20022.Seev036001.CashOption105 {
        + PricDtls  : ISO20022.Seev036001.PriceDetails37
        + RateAndAmtDtls  : ISO20022.Seev036001.Rate41
        + TaxVchrDtls  : ISO20022.Seev036001.TaxVoucher4
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Seev036001.ForeignExchangeTerms40~
        + DtDtls  : ISO20022.Seev036001.CorporateActionDate99
        + AmtDtls  : ISO20022.Seev036001.CorporateActionAmounts73
        + CshPties  : ISO20022.Seev036001.CashParties43
        + Acct  : ISO20022.Seev036001.Account10Choice
        + CtryOfIncmSrc  : String
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev036001.GenericIdentification30~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev036001.GenericIdentification30~
        + IncmTp  : ISO20022.Seev036001.GenericIdentification30
        + IssrOfferrTaxbltyInd  : ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice
        + CtrctlPmtInd  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.PriceDetails37
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.Rate41
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.TaxVoucher4
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.ForeignExchangeTerms40
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.CorporateActionDate99
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.CorporateActionAmounts73
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.CashParties43
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.Account10Choice
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.CashOption105 *-- ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice
    class ISO20022.Seev036001.CashParties43 {
        + MktClmCtrPty  : ISO20022.Seev036001.PartyIdentificationAndAccount225
        + CdtrAgt  : ISO20022.Seev036001.PartyIdentificationAndAccount226
        + Cdtr  : ISO20022.Seev036001.PartyIdentificationAndAccount225
    }
    ISO20022.Seev036001.CashParties43 *-- ISO20022.Seev036001.PartyIdentificationAndAccount225
    ISO20022.Seev036001.CashParties43 *-- ISO20022.Seev036001.PartyIdentificationAndAccount226
    ISO20022.Seev036001.CashParties43 *-- ISO20022.Seev036001.PartyIdentificationAndAccount225
    class ISO20022.Seev036001.CorporateAction85 {
        + LtryTp  : ISO20022.Seev036001.LotteryTypeFormat4Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice~
        + EvtStag  : ISO20022.Seev036001.CorporateActionEventStageFormat14Choice
        + DtDtls  : ISO20022.Seev036001.CorporateActionDate86
    }
    ISO20022.Seev036001.CorporateAction85 *-- ISO20022.Seev036001.LotteryTypeFormat4Choice
    ISO20022.Seev036001.CorporateAction85 *-- ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice
    ISO20022.Seev036001.CorporateAction85 *-- ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice
    ISO20022.Seev036001.CorporateAction85 *-- ISO20022.Seev036001.CorporateActionEventStageFormat14Choice
    ISO20022.Seev036001.CorporateAction85 *-- ISO20022.Seev036001.CorporateActionDate86
    class ISO20022.Seev036001.CorporateActionAmounts60 {
        + ScndLvlTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev036001.CorporateActionAmounts60 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts60 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    class ISO20022.Seev036001.CorporateActionAmounts73 {
        + BuyUpAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + RfnddSbcptAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + AdjstdSbcptAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + DmdRyltsAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + DmdIntrstAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + DmdFndAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + DmdDvddAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + FrgnIncmAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + DmdAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TxTax  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxOnIncmAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + BckUpWhldgTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + NRATaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + FATCATaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + EqulstnAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + AcrdIntrstAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + EUTaxRtntnAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + StockXchgTax  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + IncmPrtn  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + RedPrmAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + PrncplOrCrps  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxArrearsAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + NtnlTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + NtnlDvddPyblAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + CshAmtCrrdFwd  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + CshAmtBrghtFwd  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ChrgsAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ScndLvlTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + ManfctrdDvddPmtAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + MktClmAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + GrssAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + PstngAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    ISO20022.Seev036001.CorporateActionAmounts73 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    class ISO20022.Seev036001.CorporateActionBalanceDetails41 {
        + UafctdBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + AfctdBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + RegdBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + InTrnsShipmntBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + TradDtPosBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + StrtPosBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + SttlmPosBal  : global::System.Collections.Generic.List~ISO20022.Seev036001.BalanceFormat12Choice~
        + OutForRegnBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev036001.BalanceFormat12Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev036001.BalanceFormat12Choice~
        + OnLnBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + CollOutBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + CollInBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + BrrwdBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + BlckdBal  : ISO20022.Seev036001.BalanceFormat11Choice
        + TtlElgblBal  : ISO20022.Seev036001.TotalEligibleBalanceFormat10
        + ConfdBal  : ISO20022.Seev036001.BalanceFormat11Choice
    }
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat12Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat12Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat12Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.TotalEligibleBalanceFormat10
    ISO20022.Seev036001.CorporateActionBalanceDetails41 *-- ISO20022.Seev036001.BalanceFormat11Choice
    class ISO20022.Seev036001.CorporateActionDate86 {
        + ExDvddDt  : ISO20022.Seev036001.DateFormat30Choice
        + RcrdDt  : ISO20022.Seev036001.DateFormat30Choice
    }
    ISO20022.Seev036001.CorporateActionDate86 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.CorporateActionDate86 *-- ISO20022.Seev036001.DateFormat30Choice
    class ISO20022.Seev036001.CorporateActionDate88 {
        + TradgDt  : ISO20022.Seev036001.DateFormat43Choice
        + CoverXprtnDdln  : ISO20022.Seev036001.DateFormat43Choice
    }
    ISO20022.Seev036001.CorporateActionDate88 *-- ISO20022.Seev036001.DateFormat43Choice
    ISO20022.Seev036001.CorporateActionDate88 *-- ISO20022.Seev036001.DateFormat43Choice
    class ISO20022.Seev036001.CorporateActionDate99 {
        + PmtDt  : DateTime
        + EarlstPmtDt  : DateTime
        + FXRateFxgDt  : ISO20022.Seev036001.DateAndDateTime2Choice
        + ValDt  : DateTime
        + PstngDt  : ISO20022.Seev036001.DateAndDateTime2Choice
    }
    ISO20022.Seev036001.CorporateActionDate99 *-- ISO20022.Seev036001.DateAndDateTime2Choice
    ISO20022.Seev036001.CorporateActionDate99 *-- ISO20022.Seev036001.DateAndDateTime2Choice
    class ISO20022.Seev036001.CorporateActionEventReference3 {
        + LkgTp  : ISO20022.Seev036001.ProcessingPosition7Choice
        + EvtId  : ISO20022.Seev036001.CorporateActionEventReference3Choice
    }
    ISO20022.Seev036001.CorporateActionEventReference3 *-- ISO20022.Seev036001.ProcessingPosition7Choice
    ISO20022.Seev036001.CorporateActionEventReference3 *-- ISO20022.Seev036001.CorporateActionEventReference3Choice
    class ISO20022.Seev036001.CorporateActionEventReference3Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev036001.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev036001.CorporateActionEventStageFormat14Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.CorporateActionEventStageFormat14Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.CorporateActionEventType109Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.CorporateActionEventType109Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.CorporateActionEventType37Code {
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
    class ISO20022.Seev036001.CorporateActionGeneralInformation179 {
        + FrctnlQty  : ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
        + FinInstrmId  : ISO20022.Seev036001.SecurityIdentification19
        + EvtTp  : ISO20022.Seev036001.CorporateActionEventType109Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev036001.CorporateActionGeneralInformation179 *-- ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev036001.CorporateActionGeneralInformation179 *-- ISO20022.Seev036001.SecurityIdentification19
    ISO20022.Seev036001.CorporateActionGeneralInformation179 *-- ISO20022.Seev036001.CorporateActionEventType109Choice
    class ISO20022.Seev036001.CorporateActionMovementConfirmationV16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev036001.SupplementaryData1~
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev036001.PartyIdentification120Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev036001.PartyIdentification120Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev036001.PartyIdentification120Choice~
        + AddtlInf  : ISO20022.Seev036001.CorporateActionNarrative31
        + CorpActnConfDtls  : ISO20022.Seev036001.CorporateActionOption233
        + CorpActnDtls  : ISO20022.Seev036001.CorporateAction85
        + AcctDtls  : ISO20022.Seev036001.AccountAndBalance58
        + CorpActnGnlInf  : ISO20022.Seev036001.CorporateActionGeneralInformation179
        + TxId  : ISO20022.Seev036001.TransactionIdentification15
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev036001.CorporateActionEventReference3~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev036001.DocumentIdentification32~
        + InstrId  : ISO20022.Seev036001.DocumentIdentification9
        + MvmntPrlimryAdvcId  : ISO20022.Seev036001.DocumentIdentification31
        + NtfctnId  : ISO20022.Seev036001.DocumentIdentification31
        + MvmntConfId  : String
        + Pgntn  : ISO20022.Seev036001.Pagination1
    }
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.SupplementaryData1
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.PartyIdentification120Choice
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.PartyIdentification120Choice
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.PartyIdentification120Choice
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.CorporateActionNarrative31
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.CorporateActionOption233
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.CorporateAction85
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.AccountAndBalance58
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.CorporateActionGeneralInformation179
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.TransactionIdentification15
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.CorporateActionEventReference3
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.DocumentIdentification32
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.DocumentIdentification9
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.DocumentIdentification31
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.DocumentIdentification31
    ISO20022.Seev036001.CorporateActionMovementConfirmationV16 *-- ISO20022.Seev036001.Pagination1
    class ISO20022.Seev036001.CorporateActionNarrative31 {
        + TaxtnConds  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + NrrtvVrsn  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev036001.CorporateActionOption12Code {
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
    class ISO20022.Seev036001.CorporateActionOption233 {
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev036001.CashOption105~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev036001.SecuritiesOption112~
        + PlcOfTrad  : ISO20022.Seev036001.MarketIdentification84
        + PricDtls  : ISO20022.Seev036001.CorporateActionPrice84
        + RateAndAmtDtls  : ISO20022.Seev036001.CorporateActionRate120
        + PrdDtls  : ISO20022.Seev036001.CorporateActionPeriod13
        + DtDtls  : ISO20022.Seev036001.CorporateActionDate88
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev036001.FractionDispositionType27Choice
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev036001.OptionFeaturesFormat29Choice~
        + OptnTp  : ISO20022.Seev036001.CorporateActionOption33Choice
        + OptnNb  : ISO20022.Seev036001.OptionNumber1Choice
    }
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CashOption105
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.SecuritiesOption112
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.MarketIdentification84
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CorporateActionPrice84
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CorporateActionRate120
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CorporateActionPeriod13
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CorporateActionDate88
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.FractionDispositionType27Choice
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.OptionFeaturesFormat29Choice
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.CorporateActionOption33Choice
    ISO20022.Seev036001.CorporateActionOption233 *-- ISO20022.Seev036001.OptionNumber1Choice
    class ISO20022.Seev036001.CorporateActionOption33Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.CorporateActionOption33Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.CorporateActionPeriod13 {
        + ParllTradgPrd  : ISO20022.Seev036001.Period11
        + ActnPrd  : ISO20022.Seev036001.Period11
        + PricClctnPrd  : ISO20022.Seev036001.Period11
    }
    ISO20022.Seev036001.CorporateActionPeriod13 *-- ISO20022.Seev036001.Period11
    ISO20022.Seev036001.CorporateActionPeriod13 *-- ISO20022.Seev036001.Period11
    ISO20022.Seev036001.CorporateActionPeriod13 *-- ISO20022.Seev036001.Period11
    class ISO20022.Seev036001.CorporateActionPrice83 {
        + GncCshPricRcvdPerPdct  : ISO20022.Seev036001.PriceFormat76Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev036001.PriceFormat75Choice
        + CshValForTax  : ISO20022.Seev036001.AmountPrice2
        + IndctvOrMktPric  : ISO20022.Seev036001.IndicativeOrMarketPrice13Choice
        + CshInLieuOfShrPric  : ISO20022.Seev036001.PriceFormat77Choice
    }
    ISO20022.Seev036001.CorporateActionPrice83 *-- ISO20022.Seev036001.PriceFormat76Choice
    ISO20022.Seev036001.CorporateActionPrice83 *-- ISO20022.Seev036001.PriceFormat75Choice
    ISO20022.Seev036001.CorporateActionPrice83 *-- ISO20022.Seev036001.AmountPrice2
    ISO20022.Seev036001.CorporateActionPrice83 *-- ISO20022.Seev036001.IndicativeOrMarketPrice13Choice
    ISO20022.Seev036001.CorporateActionPrice83 *-- ISO20022.Seev036001.PriceFormat77Choice
    class ISO20022.Seev036001.CorporateActionPrice84 {
        + OverSbcptDpstPric  : ISO20022.Seev036001.PriceFormat77Choice
        + CshInLieuOfShrPric  : ISO20022.Seev036001.PriceFormat77Choice
    }
    ISO20022.Seev036001.CorporateActionPrice84 *-- ISO20022.Seev036001.PriceFormat77Choice
    ISO20022.Seev036001.CorporateActionPrice84 *-- ISO20022.Seev036001.PriceFormat77Choice
    class ISO20022.Seev036001.CorporateActionRate120 {
        + TaxblIncmPerDvddShr  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateTypeAndAmountAndStatus26~
        + AddtlTax  : ISO20022.Seev036001.RateAndAmountFormat59Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + PrratnRate  : Decimal
        + MaxAllwdOvrsbcptRate  : Decimal
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice~
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.NetDividendRateFormat37Choice~
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.GrossDividendRateFormat35Choice~
    }
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus26
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.NetDividendRateFormat37Choice
    ISO20022.Seev036001.CorporateActionRate120 *-- ISO20022.Seev036001.GrossDividendRateFormat35Choice
    class ISO20022.Seev036001.CorporateActionRate125 {
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + FinTxTaxRate  : Decimal
        + TaxCdtRate  : ISO20022.Seev036001.RateFormat27Choice
        + AplblRate  : Decimal
        + FsclStmp  : Decimal
        + ChrgsFees  : ISO20022.Seev036001.RateAndAmountFormat59Choice
        + NewToOd  : ISO20022.Seev036001.RatioFormat19Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev036001.RatioFormat20Choice
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev036001.RatioFormat20Choice
    }
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RateFormat27Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RatioFormat19Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RatioFormat20Choice
    ISO20022.Seev036001.CorporateActionRate125 *-- ISO20022.Seev036001.RatioFormat20Choice
    class ISO20022.Seev036001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev036001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev036001.DateCode19Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.DateCode19Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.DateFormat30Choice {
        + DtCd  : ISO20022.Seev036001.DateCode19Choice
        + Dt  : DateTime
    }
    ISO20022.Seev036001.DateFormat30Choice *-- ISO20022.Seev036001.DateCode19Choice
    class ISO20022.Seev036001.DateFormat43Choice {
        + DtCd  : ISO20022.Seev036001.DateCode19Choice
        + Dt  : ISO20022.Seev036001.DateAndDateTime2Choice
    }
    ISO20022.Seev036001.DateFormat43Choice *-- ISO20022.Seev036001.DateCode19Choice
    ISO20022.Seev036001.DateFormat43Choice *-- ISO20022.Seev036001.DateAndDateTime2Choice
    class ISO20022.Seev036001.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev036001.DateAndDateTime2Choice
    }
    ISO20022.Seev036001.DateFormat45Choice *-- ISO20022.Seev036001.DateAndDateTime2Choice
    class ISO20022.Seev036001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev036001.DeemedRateType1Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.DeemedRateType1Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.DeemedRateType1Code {
        DERY = 1
        DEIT = 2
        DEFP = 3
        DEDI = 4
    }
    class ISO20022.Seev036001.DividendRateType1Code {
        TXBL = 1
    }
    class ISO20022.Seev036001.DocumentIdentification31 {
        + LkgTp  : ISO20022.Seev036001.ProcessingPosition7Choice
        + Id  : String
    }
    ISO20022.Seev036001.DocumentIdentification31 *-- ISO20022.Seev036001.ProcessingPosition7Choice
    class ISO20022.Seev036001.DocumentIdentification32 {
        + LkgTp  : ISO20022.Seev036001.ProcessingPosition7Choice
        + DocNb  : ISO20022.Seev036001.DocumentNumber5Choice
        + Id  : ISO20022.Seev036001.DocumentIdentification3Choice
    }
    ISO20022.Seev036001.DocumentIdentification32 *-- ISO20022.Seev036001.ProcessingPosition7Choice
    ISO20022.Seev036001.DocumentIdentification32 *-- ISO20022.Seev036001.DocumentNumber5Choice
    ISO20022.Seev036001.DocumentIdentification32 *-- ISO20022.Seev036001.DocumentIdentification3Choice
    class ISO20022.Seev036001.DocumentIdentification3Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev036001.DocumentIdentification9 {
        + Id  : String
    }
    class ISO20022.Seev036001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Seev036001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev036001.DocumentNumber5Choice *-- ISO20022.Seev036001.GenericIdentification36
    class ISO20022.Seev036001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev036001.ForeignExchangeTerms40 {
        + RsltgAmt  : ISO20022.Seev036001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev036001.ForeignExchangeTerms40 *-- ISO20022.Seev036001.ActiveCurrencyAndAmount
    class ISO20022.Seev036001.FractionDispositionType11Code {
        RDUP = 1
        STAN = 2
        RDDN = 3
        DIST = 4
        CINL = 5
        BUYU = 6
    }
    class ISO20022.Seev036001.FractionDispositionType27Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.FractionDispositionType27Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev036001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev036001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev036001.GenericIdentification30
    }
    ISO20022.Seev036001.GenericIdentification78 *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.GrossDividendRateFormat35Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus55
        + AmtAndRateSts  : ISO20022.Seev036001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.GrossDividendRateFormat35Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus55
    ISO20022.Seev036001.GrossDividendRateFormat35Choice *-- ISO20022.Seev036001.AmountAndRateStatus1
    ISO20022.Seev036001.GrossDividendRateFormat35Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.GrossDividendRateFormat37Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus57
        + AmtAndRateSts  : ISO20022.Seev036001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.GrossDividendRateFormat37Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus57
    ISO20022.Seev036001.GrossDividendRateFormat37Choice *-- ISO20022.Seev036001.AmountAndRateStatus1
    ISO20022.Seev036001.GrossDividendRateFormat37Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.GrossDividendRateType6Code {
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
    class ISO20022.Seev036001.GrossDividendRateType7Code {
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
    class ISO20022.Seev036001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev036001.IdentificationType42Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.IdentificationType42Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.IndicativeOrMarketPrice13Choice {
        + MktPric  : ISO20022.Seev036001.PriceFormat77Choice
        + IndctvPric  : ISO20022.Seev036001.PriceFormat77Choice
    }
    ISO20022.Seev036001.IndicativeOrMarketPrice13Choice *-- ISO20022.Seev036001.PriceFormat77Choice
    ISO20022.Seev036001.IndicativeOrMarketPrice13Choice *-- ISO20022.Seev036001.PriceFormat77Choice
    class ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus24
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus24
    ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.IntermediateSecurityDistributionType5Code {
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
    class ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.IssuerTaxability2Code {
        TXBL = 1
    }
    class ISO20022.Seev036001.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev036001.LotteryTypeFormat4Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.LotteryTypeFormat4Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev036001.MarketIdentification84 {
        + Tp  : ISO20022.Seev036001.MarketType8Choice
        + Id  : ISO20022.Seev036001.MarketIdentification1Choice
    }
    ISO20022.Seev036001.MarketIdentification84 *-- ISO20022.Seev036001.MarketType8Choice
    ISO20022.Seev036001.MarketIdentification84 *-- ISO20022.Seev036001.MarketIdentification1Choice
    class ISO20022.Seev036001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Seev036001.MarketType8Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.MarketType8Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.NameAndAddress5 {
        + Adr  : ISO20022.Seev036001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev036001.NameAndAddress5 *-- ISO20022.Seev036001.PostalAddress1
    class ISO20022.Seev036001.NetDividendRateFormat37Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus56
        + AmtAndRateSts  : ISO20022.Seev036001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.NetDividendRateFormat37Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus56
    ISO20022.Seev036001.NetDividendRateFormat37Choice *-- ISO20022.Seev036001.AmountAndRateStatus1
    ISO20022.Seev036001.NetDividendRateFormat37Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.NetDividendRateFormat40Choice {
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus58
        + AmtAndRateSts  : ISO20022.Seev036001.AmountAndRateStatus1
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Seev036001.NetDividendRateFormat40Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus58
    ISO20022.Seev036001.NetDividendRateFormat40Choice *-- ISO20022.Seev036001.AmountAndRateStatus1
    ISO20022.Seev036001.NetDividendRateFormat40Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.NetDividendRateType6Code {
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
    class ISO20022.Seev036001.NetDividendRateType7Code {
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
    class ISO20022.Seev036001.NewSecuritiesIssuanceType6Code {
        NREF = 1
        REFU = 2
        NDEF = 3
        DEFE = 4
    }
    class ISO20022.Seev036001.OptionFeatures14Code {
        RNET = 1
        RGRS = 2
        VVPR = 3
        PROR = 4
        OPLF = 5
        MAXS = 6
        MAXC = 7
        COND = 8
    }
    class ISO20022.Seev036001.OptionFeaturesFormat29Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.OptionFeaturesFormat29Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev036001.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev036001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev036001.OriginalAndCurrentQuantities6 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev036001.OtherIdentification1 {
        + Tp  : ISO20022.Seev036001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev036001.OtherIdentification1 *-- ISO20022.Seev036001.IdentificationSource3Choice
    class ISO20022.Seev036001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev036001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Seev036001.NameAndAddress5
        + PrtryId  : ISO20022.Seev036001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev036001.PartyIdentification120Choice *-- ISO20022.Seev036001.NameAndAddress5
    ISO20022.Seev036001.PartyIdentification120Choice *-- ISO20022.Seev036001.GenericIdentification36
    class ISO20022.Seev036001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Seev036001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev036001.PartyIdentification127Choice *-- ISO20022.Seev036001.GenericIdentification36
    class ISO20022.Seev036001.PartyIdentification133Choice {
        + PrtryId  : ISO20022.Seev036001.GenericIdentification36
        + NmAndAdr  : ISO20022.Seev036001.NameAndAddress5
        + BICFI  : String
    }
    ISO20022.Seev036001.PartyIdentification133Choice *-- ISO20022.Seev036001.GenericIdentification36
    ISO20022.Seev036001.PartyIdentification133Choice *-- ISO20022.Seev036001.NameAndAddress5
    class ISO20022.Seev036001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Seev036001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Seev036001.PartyIdentification257Choice *-- ISO20022.Seev036001.NameAndAddress5
    class ISO20022.Seev036001.PartyIdentification316 {
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev036001.AlternatePartyIdentification7~
        + PrcgId  : String
        + Id  : ISO20022.Seev036001.PartyIdentification257Choice
    }
    ISO20022.Seev036001.PartyIdentification316 *-- ISO20022.Seev036001.AlternatePartyIdentification7
    ISO20022.Seev036001.PartyIdentification316 *-- ISO20022.Seev036001.PartyIdentification257Choice
    class ISO20022.Seev036001.PartyIdentificationAndAccount204 {
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev036001.AlternatePartyIdentification7~
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Id  : ISO20022.Seev036001.PartyIdentification120Choice
    }
    ISO20022.Seev036001.PartyIdentificationAndAccount204 *-- ISO20022.Seev036001.AlternatePartyIdentification7
    ISO20022.Seev036001.PartyIdentificationAndAccount204 *-- ISO20022.Seev036001.PartyIdentification120Choice
    class ISO20022.Seev036001.PartyIdentificationAndAccount225 {
        + AltrnId  : ISO20022.Seev036001.AlternatePartyIdentification7
        + PrcgId  : String
        + CshAcct  : ISO20022.Seev036001.CashAccountIdentification9Choice
        + Id  : ISO20022.Seev036001.PartyIdentification120Choice
    }
    ISO20022.Seev036001.PartyIdentificationAndAccount225 *-- ISO20022.Seev036001.AlternatePartyIdentification7
    ISO20022.Seev036001.PartyIdentificationAndAccount225 *-- ISO20022.Seev036001.CashAccountIdentification9Choice
    ISO20022.Seev036001.PartyIdentificationAndAccount225 *-- ISO20022.Seev036001.PartyIdentification120Choice
    class ISO20022.Seev036001.PartyIdentificationAndAccount226 {
        + AltrnId  : ISO20022.Seev036001.AlternatePartyIdentification7
        + PrcgId  : String
        + CshAcct  : ISO20022.Seev036001.CashAccountIdentification9Choice
        + Id  : ISO20022.Seev036001.PartyIdentification133Choice
    }
    ISO20022.Seev036001.PartyIdentificationAndAccount226 *-- ISO20022.Seev036001.AlternatePartyIdentification7
    ISO20022.Seev036001.PartyIdentificationAndAccount226 *-- ISO20022.Seev036001.CashAccountIdentification9Choice
    ISO20022.Seev036001.PartyIdentificationAndAccount226 *-- ISO20022.Seev036001.PartyIdentification133Choice
    class ISO20022.Seev036001.Payment1Code {
        CONT = 1
        ACTU = 2
    }
    class ISO20022.Seev036001.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev036001.Period11 {
        + EndDt  : ISO20022.Seev036001.DateFormat45Choice
        + StartDt  : ISO20022.Seev036001.DateFormat45Choice
    }
    ISO20022.Seev036001.Period11 *-- ISO20022.Seev036001.DateFormat45Choice
    ISO20022.Seev036001.Period11 *-- ISO20022.Seev036001.DateFormat45Choice
    class ISO20022.Seev036001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev036001.PriceDetails37 {
        + CshInLieuOfShrPric  : ISO20022.Seev036001.PriceFormat77Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev036001.PriceFormat76Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev036001.PriceFormat75Choice
    }
    ISO20022.Seev036001.PriceDetails37 *-- ISO20022.Seev036001.PriceFormat77Choice
    ISO20022.Seev036001.PriceDetails37 *-- ISO20022.Seev036001.PriceFormat76Choice
    ISO20022.Seev036001.PriceDetails37 *-- ISO20022.Seev036001.PriceFormat75Choice
    class ISO20022.Seev036001.PriceFormat75Choice {
        + IndxPts  : Decimal
        + AmtPric  : ISO20022.Seev036001.AmountPrice3
        + PctgPric  : ISO20022.Seev036001.PercentagePrice2
    }
    ISO20022.Seev036001.PriceFormat75Choice *-- ISO20022.Seev036001.AmountPrice3
    ISO20022.Seev036001.PriceFormat75Choice *-- ISO20022.Seev036001.PercentagePrice2
    class ISO20022.Seev036001.PriceFormat76Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev036001.AmountPricePerAmount2
        + AmtPricPerFinInstrmQty  : ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10
        + AmtPric  : ISO20022.Seev036001.AmountPrice3
        + PctgPric  : ISO20022.Seev036001.PercentagePrice2
    }
    ISO20022.Seev036001.PriceFormat76Choice *-- ISO20022.Seev036001.AmountPricePerAmount2
    ISO20022.Seev036001.PriceFormat76Choice *-- ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10
    ISO20022.Seev036001.PriceFormat76Choice *-- ISO20022.Seev036001.AmountPrice3
    ISO20022.Seev036001.PriceFormat76Choice *-- ISO20022.Seev036001.PercentagePrice2
    class ISO20022.Seev036001.PriceFormat77Choice {
        + AmtPric  : ISO20022.Seev036001.AmountPrice3
        + PctgPric  : ISO20022.Seev036001.PercentagePrice2
    }
    ISO20022.Seev036001.PriceFormat77Choice *-- ISO20022.Seev036001.AmountPrice3
    ISO20022.Seev036001.PriceFormat77Choice *-- ISO20022.Seev036001.PercentagePrice2
    class ISO20022.Seev036001.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev036001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev036001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.ProcessingPosition7Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.ProprietaryQuantity7 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev036001.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev036001.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev036001.ProprietaryQuantity8
        + Qty  : ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev036001.Quantity48Choice *-- ISO20022.Seev036001.ProprietaryQuantity8
    ISO20022.Seev036001.Quantity48Choice *-- ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev036001.Quantity49Choice {
        + PrtryQty  : ISO20022.Seev036001.ProprietaryQuantity7
        + QtyChc  : ISO20022.Seev036001.Quantity50Choice
    }
    ISO20022.Seev036001.Quantity49Choice *-- ISO20022.Seev036001.ProprietaryQuantity7
    ISO20022.Seev036001.Quantity49Choice *-- ISO20022.Seev036001.Quantity50Choice
    class ISO20022.Seev036001.Quantity50Choice {
        + SgndQty  : ISO20022.Seev036001.SignedQuantityFormat10
        + OrgnlAndCurFaceAmt  : ISO20022.Seev036001.OriginalAndCurrentQuantities6
    }
    ISO20022.Seev036001.Quantity50Choice *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.Quantity50Choice *-- ISO20022.Seev036001.OriginalAndCurrentQuantities6
    class ISO20022.Seev036001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Seev036001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev036001.Quantity51Choice *-- ISO20022.Seev036001.OriginalAndCurrentQuantities1
    ISO20022.Seev036001.Quantity51Choice *-- ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev036001.QuantityToQuantityRatio1 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev036001.Rate41 {
        + DmdRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat62Choice~
        + EqulstnRate  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + TaxRclmRate  : Decimal
        + TaxOnPrfts  : Decimal
        + TaxOnIncm  : ISO20022.Seev036001.RateAndAmountFormat59Choice
        + ScndLvlTax  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + WhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.RateAndAmountFormat55Choice~
        + TaxCdtRate  : ISO20022.Seev036001.RateFormat27Choice
        + SlctnFeeRate  : ISO20022.Seev036001.SolicitationFeeRateFormat12Choice
        + AplblRate  : Decimal
        + NetDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.NetDividendRateFormat40Choice~
        + GrssIntrstRateUsdForPmt  : global::System.Collections.Generic.List~ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice~
        + ThrdPtyIncntivRate  : ISO20022.Seev036001.RateAndAmountFormat59Choice
        + EarlySlctnFeeRate  : ISO20022.Seev036001.SolicitationFeeRateFormat12Choice
        + GrssDstrbtnRate  : global::System.Collections.Generic.List~ISO20022.Seev036001.GrossDividendRateFormat37Choice~
        + FsclStmp  : Decimal
        + ChrgsFees  : ISO20022.Seev036001.RateAndAmountFormat59Choice
        + AddtlTax  : ISO20022.Seev036001.RateAndAmountFormat59Choice
    }
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat62Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat55Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateFormat27Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.SolicitationFeeRateFormat12Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.NetDividendRateFormat40Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.SolicitationFeeRateFormat12Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.GrossDividendRateFormat37Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    ISO20022.Seev036001.Rate41 *-- ISO20022.Seev036001.RateAndAmountFormat59Choice
    class ISO20022.Seev036001.RateAndAmountFormat55Choice {
        + RateTpAndRate  : ISO20022.Seev036001.RateTypeAndPercentageRate12
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036001.RateAndAmountFormat55Choice *-- ISO20022.Seev036001.RateTypeAndPercentageRate12
    ISO20022.Seev036001.RateAndAmountFormat55Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.RateAndAmountFormat59Choice {
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036001.RateAndAmountFormat59Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.RateAndAmountFormat62Choice {
        + RateTpAndRate  : ISO20022.Seev036001.RateTypeAndPercentageRate14
        + RateTpAndAmtAndRateSts  : ISO20022.Seev036001.RateTypeAndAmountAndStatus37
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036001.RateAndAmountFormat62Choice *-- ISO20022.Seev036001.RateTypeAndPercentageRate14
    ISO20022.Seev036001.RateAndAmountFormat62Choice *-- ISO20022.Seev036001.RateTypeAndAmountAndStatus37
    ISO20022.Seev036001.RateAndAmountFormat62Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.RateFormat27Choice {
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev036001.RateFormat27Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev036001.RateStatus1Code {
        INDI = 1
        ACTU = 2
    }
    class ISO20022.Seev036001.RateStatus3Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateStatus3Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType33Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType33Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType36Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType36Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType42Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType42Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType76Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType76Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType77Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType77Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType78Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType78Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType79Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev036001.RateType79Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.RateType7Code {
        USCD = 1
        SCHD = 2
    }
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus24 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType33Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus24 *-- ISO20022.Seev036001.RateType33Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus26 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType36Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus26 *-- ISO20022.Seev036001.RateType36Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus37 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.DeemedRateType1Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus37 *-- ISO20022.Seev036001.DeemedRateType1Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus55 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType76Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus55 *-- ISO20022.Seev036001.RateType76Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus56 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType77Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus56 *-- ISO20022.Seev036001.RateType77Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus57 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType78Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus57 *-- ISO20022.Seev036001.RateType78Choice
    class ISO20022.Seev036001.RateTypeAndAmountAndStatus58 {
        + RateSts  : ISO20022.Seev036001.RateStatus3Choice
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + RateTp  : ISO20022.Seev036001.RateType79Choice
    }
    ISO20022.Seev036001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev036001.RateStatus3Choice
    ISO20022.Seev036001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.RateTypeAndAmountAndStatus58 *-- ISO20022.Seev036001.RateType79Choice
    class ISO20022.Seev036001.RateTypeAndPercentageRate12 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev036001.RateType42Choice
    }
    ISO20022.Seev036001.RateTypeAndPercentageRate12 *-- ISO20022.Seev036001.RateType42Choice
    class ISO20022.Seev036001.RateTypeAndPercentageRate14 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev036001.DeemedRateType1Choice
    }
    ISO20022.Seev036001.RateTypeAndPercentageRate14 *-- ISO20022.Seev036001.DeemedRateType1Choice
    class ISO20022.Seev036001.RatioFormat19Choice {
        + QtyToAmt  : ISO20022.Seev036001.AmountAndQuantityRatio4
        + AmtToQty  : ISO20022.Seev036001.AmountAndQuantityRatio4
        + AmtToAmt  : ISO20022.Seev036001.AmountToAmountRatio2
        + QtyToQty  : ISO20022.Seev036001.QuantityToQuantityRatio1
    }
    ISO20022.Seev036001.RatioFormat19Choice *-- ISO20022.Seev036001.AmountAndQuantityRatio4
    ISO20022.Seev036001.RatioFormat19Choice *-- ISO20022.Seev036001.AmountAndQuantityRatio4
    ISO20022.Seev036001.RatioFormat19Choice *-- ISO20022.Seev036001.AmountToAmountRatio2
    ISO20022.Seev036001.RatioFormat19Choice *-- ISO20022.Seev036001.QuantityToQuantityRatio1
    class ISO20022.Seev036001.RatioFormat20Choice {
        + AmtToAmt  : ISO20022.Seev036001.AmountToAmountRatio2
        + QtyToQty  : ISO20022.Seev036001.QuantityToQuantityRatio1
    }
    ISO20022.Seev036001.RatioFormat20Choice *-- ISO20022.Seev036001.AmountToAmountRatio2
    ISO20022.Seev036001.RatioFormat20Choice *-- ISO20022.Seev036001.QuantityToQuantityRatio1
    class ISO20022.Seev036001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev036001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev036001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Seev036001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification78
        + TpAndId  : ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev036001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Seev036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev036001.GenericIdentification78
    ISO20022.Seev036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Seev036001.SafekeepingPlaceTypeAndText8
    class ISO20022.Seev036001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification78
        + TpAndId  : ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev036001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev036001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev036001.GenericIdentification78
    ISO20022.Seev036001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev036001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev036001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev036001.SecuritiesOption112 {
        + DlvrgSttlmPties  : ISO20022.Seev036001.SettlementParties129
        + RcvgSttlmPties  : ISO20022.Seev036001.SettlementParties129
        + AmtDtls  : ISO20022.Seev036001.CorporateActionAmounts60
        + PricDtls  : ISO20022.Seev036001.CorporateActionPrice83
        + RateDtls  : ISO20022.Seev036001.CorporateActionRate125
        + DtDtls  : ISO20022.Seev036001.SecurityDate25
        + CcyOptn  : String
        + FrctnDspstn  : ISO20022.Seev036001.FractionDispositionType27Choice
        + SfkpgPlc  : ISO20022.Seev036001.SafekeepingPlaceFormat41Choice
        + PstngQty  : ISO20022.Seev036001.Quantity51Choice
        + CtryOfIncmSrc  : String
        + XmptnTp  : global::System.Collections.Generic.List~ISO20022.Seev036001.GenericIdentification30~
        + OthrIncmTp  : global::System.Collections.Generic.List~ISO20022.Seev036001.GenericIdentification30~
        + IncmTp  : ISO20022.Seev036001.GenericIdentification30
        + IssrOfferrTaxbltyInd  : ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice
        + NewSctiesIssncInd  : String
        + TempFinInstrmInd  : ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice
        + CdtDbtInd  : String
        + FinInstrmId  : ISO20022.Seev036001.SecurityIdentification19
    }
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.SettlementParties129
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.SettlementParties129
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.CorporateActionAmounts60
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.CorporateActionPrice83
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.CorporateActionRate125
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.SecurityDate25
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.FractionDispositionType27Choice
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.SafekeepingPlaceFormat41Choice
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.Quantity51Choice
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.GenericIdentification30
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice
    ISO20022.Seev036001.SecuritiesOption112 *-- ISO20022.Seev036001.SecurityIdentification19
    class ISO20022.Seev036001.SecurityDate25 {
        + PmtDt  : ISO20022.Seev036001.DateFormat30Choice
        + EarlstPmtDt  : ISO20022.Seev036001.DateFormat30Choice
        + DvddRnkgDt  : ISO20022.Seev036001.DateFormat30Choice
        + PrpssDt  : ISO20022.Seev036001.DateFormat30Choice
        + AvlblDt  : ISO20022.Seev036001.DateFormat30Choice
        + PstngDt  : ISO20022.Seev036001.DateAndDateTime2Choice
    }
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateFormat30Choice
    ISO20022.Seev036001.SecurityDate25 *-- ISO20022.Seev036001.DateAndDateTime2Choice
    class ISO20022.Seev036001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev036001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev036001.SecurityIdentification19 *-- ISO20022.Seev036001.OtherIdentification1
    class ISO20022.Seev036001.SettlementParties129 {
        + Pty3  : ISO20022.Seev036001.PartyIdentificationAndAccount204
        + Pty2  : ISO20022.Seev036001.PartyIdentificationAndAccount204
        + Pty1  : ISO20022.Seev036001.PartyIdentificationAndAccount204
        + Dpstry  : ISO20022.Seev036001.PartyIdentification316
    }
    ISO20022.Seev036001.SettlementParties129 *-- ISO20022.Seev036001.PartyIdentificationAndAccount204
    ISO20022.Seev036001.SettlementParties129 *-- ISO20022.Seev036001.PartyIdentificationAndAccount204
    ISO20022.Seev036001.SettlementParties129 *-- ISO20022.Seev036001.PartyIdentificationAndAccount204
    ISO20022.Seev036001.SettlementParties129 *-- ISO20022.Seev036001.PartyIdentification316
    class ISO20022.Seev036001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev036001.SignedQuantityFormat10 {
        + Qty  : ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev036001.SignedQuantityFormat10 *-- ISO20022.Seev036001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev036001.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev036001.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev036001.SignedQuantityFormat11 *-- ISO20022.Seev036001.Quantity48Choice
    class ISO20022.Seev036001.SolicitationFeeRateFormat12Choice {
        + Amt  : ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
        + AmtToQty  : ISO20022.Seev036001.AmountAndQuantityRatio4
        + Rate  : Decimal
    }
    ISO20022.Seev036001.SolicitationFeeRateFormat12Choice *-- ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev036001.SolicitationFeeRateFormat12Choice *-- ISO20022.Seev036001.AmountAndQuantityRatio4
    class ISO20022.Seev036001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev036001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev036001.SupplementaryData1 *-- ISO20022.Seev036001.SupplementaryDataEnvelope1
    class ISO20022.Seev036001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev036001.TaxVoucher4 {
        + BrgnSttlmDt  : ISO20022.Seev036001.DateAndDateTime2Choice
        + BrgnDt  : ISO20022.Seev036001.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Seev036001.TaxVoucher4 *-- ISO20022.Seev036001.DateAndDateTime2Choice
    ISO20022.Seev036001.TaxVoucher4 *-- ISO20022.Seev036001.DateAndDateTime2Choice
    class ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice {
        + Prtry  : ISO20022.Seev036001.GenericIdentification30
        + TempInd  : String
    }
    ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice *-- ISO20022.Seev036001.GenericIdentification30
    class ISO20022.Seev036001.TotalEligibleBalanceFormat10 {
        + PartWayPrdUnits  : ISO20022.Seev036001.SignedQuantityFormat10
        + FullPrdUnits  : ISO20022.Seev036001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev036001.Quantity49Choice
    }
    ISO20022.Seev036001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev036001.SignedQuantityFormat10
    ISO20022.Seev036001.TotalEligibleBalanceFormat10 *-- ISO20022.Seev036001.Quantity49Choice
    class ISO20022.Seev036001.TransactionIdentification15 {
        + MktInfrstrctrTxId  : String
    }
    class ISO20022.Seev036001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Seev036001.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev036001.Account10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxAcct|ISO20022.Seev036001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Seev036001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev036001.CashAccountIdentification9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAcct),validElement(ChrgsAcct),validElement(CshAcct),validChoice(TaxAcct,ChrgsAcct,CshAcct))|

---

## Value ISO20022.Seev036001.AccountAndBalance58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev036001.CorporateActionBalanceDetails41||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev036001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev036001.PartyIdentification127Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr))|

---

## Value ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev036001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev036001.AdditionalBusinessProcess12Code


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

## Value ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev036001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Seev036001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Seev036001.AmountAndQuantityRatio4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev036001.AmountAndRateStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|String||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev036001.AmountPrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev036001.AmountPrice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev036001.AmountPricePerAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev036001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PricVal|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev036001.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Enum ISO20022.Seev036001.AmountPriceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|

---

## Value ISO20022.Seev036001.AmountToAmountRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Amt1|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Value ISO20022.Seev036001.BalanceFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev036001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev036001.BalanceFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|NotElgblBal|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev036001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(PartWayPrdUnits,FullPrdUnits,NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev036001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev036001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Seev036001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev036001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev036001.CashOption105


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Seev036001.PriceDetails37||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev036001.Rate41||XmlElement()||
|+|TaxVchrDtls|ISO20022.Seev036001.TaxVoucher4||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Seev036001.ForeignExchangeTerms40>||XmlElement()||
|+|DtDtls|ISO20022.Seev036001.CorporateActionDate99||XmlElement()||
|+|AmtDtls|ISO20022.Seev036001.CorporateActionAmounts73||XmlElement()||
|+|CshPties|ISO20022.Seev036001.CashParties43||XmlElement()||
|+|Acct|ISO20022.Seev036001.Account10Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev036001.GenericIdentification30>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev036001.GenericIdentification30>||XmlElement()||
|+|IncmTp|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice||XmlElement()||
|+|CtrctlPmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(RateAndAmtDtls),validElement(TaxVchrDtls),validList("""FXDtls""",FXDtls),validElement(FXDtls),validElement(DtDtls),validElement(AmtDtls),validElement(CshPties),validElement(Acct),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd))|

---

## Value ISO20022.Seev036001.CashParties43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktClmCtrPty|ISO20022.Seev036001.PartyIdentificationAndAccount225||XmlElement()||
|+|CdtrAgt|ISO20022.Seev036001.PartyIdentificationAndAccount226||XmlElement()||
|+|Cdtr|ISO20022.Seev036001.PartyIdentificationAndAccount225||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktClmCtrPty),validElement(CdtrAgt),validElement(Cdtr))|

---

## Value ISO20022.Seev036001.CorporateAction85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev036001.LotteryTypeFormat4Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev036001.AdditionalBusinessProcessFormat23Choice>||XmlElement()||
|+|EvtStag|ISO20022.Seev036001.CorporateActionEventStageFormat14Choice||XmlElement()||
|+|DtDtls|ISO20022.Seev036001.CorporateActionDate86||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validElement(IntrmdtSctiesDstrbtnTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(DtDtls))|

---

## Value ISO20022.Seev036001.CorporateActionAmounts60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt))|

---

## Value ISO20022.Seev036001.CorporateActionAmounts73


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuyUpAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|RfnddSbcptAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|AdjstdSbcptAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdRyltsAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdIntrstAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdFndAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdDvddAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|FrgnIncmAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|DmdAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TxTax|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxOnIncmAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|BckUpWhldgTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|NRATaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|FATCATaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|EqulstnAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|EUTaxRtntnAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|StockXchgTax|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|IncmPrtn|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|RedPrmAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrncplOrCrps|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxArrearsAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|NtnlTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|NtnlDvddPyblAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshAmtCrrdFwd|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshAmtBrghtFwd|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ChrgsAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ScndLvlTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddPmtAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|MktClmAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrssAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|PstngAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuyUpAmt),validElement(RfnddSbcptAmt),validElement(AdjstdSbcptAmt),validElement(DmdRyltsAmt),validElement(DmdIntrstAmt),validElement(DmdFndAmt),validElement(DmdDvddAmt),validElement(FrgnIncmAmt),validElement(DmdAmt),validElement(TxTax),validElement(TaxOnIncmAmt),validElement(BckUpWhldgTaxAmt),validElement(NRATaxAmt),validElement(FATCATaxAmt),validElement(EqulstnAmt),validElement(AcrdIntrstAmt),validElement(EUTaxRtntnAmt),validElement(StockXchgTax),validElement(IncmPrtn),validElement(RedPrmAmt),validElement(PrncplOrCrps),validElement(OrgnlAmt),validElement(TaxArrearsAmt),validElement(NtnlTaxAmt),validElement(NtnlDvddPyblAmt),validElement(CshAmtCrrdFwd),validElement(CshAmtBrghtFwd),validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(ScndLvlTaxAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(ValAddedTaxAmt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(RinvstmtAmt),validElement(ManfctrdDvddPmtAmt),validElement(IndmntyAmt),validElement(MktClmAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(NetAmt),validElement(GrssAmt),validElement(PstngAmt))|

---

## Value ISO20022.Seev036001.CorporateActionBalanceDetails41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UafctdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|AfctdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|RegdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|SttlmPosBal|global::System.Collections.Generic.List<ISO20022.Seev036001.BalanceFormat12Choice>||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev036001.BalanceFormat12Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev036001.BalanceFormat12Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev036001.TotalEligibleBalanceFormat10||XmlElement()||
|+|ConfdBal|ISO20022.Seev036001.BalanceFormat11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UafctdBal),validElement(AfctdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validList("""SttlmPosBal""",SttlmPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal),validElement(ConfdBal))|

---

## Value ISO20022.Seev036001.CorporateActionDate86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExDvddDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExDvddDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev036001.CorporateActionDate88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgDt|ISO20022.Seev036001.DateFormat43Choice||XmlElement()||
|+|CoverXprtnDdln|ISO20022.Seev036001.DateFormat43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradgDt),validElement(CoverXprtnDdln))|

---

## Value ISO20022.Seev036001.CorporateActionDate99


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|DateTime||XmlElement()||
|+|EarlstPmtDt|DateTime||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|PstngDt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXRateFxgDt),validElement(PstngDt))|

---

## Value ISO20022.Seev036001.CorporateActionEventReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036001.ProcessingPosition7Choice||XmlElement()||
|+|EvtId|ISO20022.Seev036001.CorporateActionEventReference3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev036001.CorporateActionEventReference3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev036001.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev036001.CorporateActionEventStageFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.CorporateActionEventType109Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.CorporateActionEventType37Code


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

## Value ISO20022.Seev036001.CorporateActionGeneralInformation179


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrctnlQty|ISO20022.Seev036001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev036001.SecurityIdentification19||XmlElement()||
|+|EvtTp|ISO20022.Seev036001.CorporateActionEventType109Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrctnlQty),validElement(FinInstrmId),validElement(EvtTp))|

---

## Aspect ISO20022.Seev036001.CorporateActionMovementConfirmationV16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev036001.SupplementaryData1>||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev036001.PartyIdentification120Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev036001.PartyIdentification120Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev036001.PartyIdentification120Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev036001.CorporateActionNarrative31||XmlElement()||
|+|CorpActnConfDtls|ISO20022.Seev036001.CorporateActionOption233||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev036001.CorporateAction85||XmlElement()||
|+|AcctDtls|ISO20022.Seev036001.AccountAndBalance58||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev036001.CorporateActionGeneralInformation179||XmlElement()||
|+|TxId|ISO20022.Seev036001.TransactionIdentification15||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev036001.CorporateActionEventReference3>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev036001.DocumentIdentification32>||XmlElement()||
|+|InstrId|ISO20022.Seev036001.DocumentIdentification9||XmlElement()||
|+|MvmntPrlimryAdvcId|ISO20022.Seev036001.DocumentIdentification31||XmlElement()||
|+|NtfctnId|ISO20022.Seev036001.DocumentIdentification31||XmlElement()||
|+|MvmntConfId|String||XmlElement()||
|+|Pgntn|ISO20022.Seev036001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validElement(CorpActnConfDtls),validElement(CorpActnDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxId),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId),validElement(MvmntPrlimryAdvcId),validElement(NtfctnId),validElement(Pgntn))|

---

## Value ISO20022.Seev036001.CorporateActionNarrative31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxtnConds|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev036001.CorporateActionOption12Code


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

## Value ISO20022.Seev036001.CorporateActionOption233


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev036001.CashOption105>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev036001.SecuritiesOption112>||XmlElement()||
|+|PlcOfTrad|ISO20022.Seev036001.MarketIdentification84||XmlElement()||
|+|PricDtls|ISO20022.Seev036001.CorporateActionPrice84||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev036001.CorporateActionRate120||XmlElement()||
|+|PrdDtls|ISO20022.Seev036001.CorporateActionPeriod13||XmlElement()||
|+|DtDtls|ISO20022.Seev036001.CorporateActionDate88||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev036001.FractionDispositionType27Choice||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev036001.OptionFeaturesFormat29Choice>||XmlElement()||
|+|OptnTp|ISO20022.Seev036001.CorporateActionOption33Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev036001.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(PlcOfTrad),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(PrdDtls),validElement(DtDtls),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev036001.CorporateActionOption33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.CorporateActionPeriod13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ParllTradgPrd|ISO20022.Seev036001.Period11||XmlElement()||
|+|ActnPrd|ISO20022.Seev036001.Period11||XmlElement()||
|+|PricClctnPrd|ISO20022.Seev036001.Period11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ParllTradgPrd),validElement(ActnPrd),validElement(PricClctnPrd))|

---

## Value ISO20022.Seev036001.CorporateActionPrice83


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricRcvdPerPdct|ISO20022.Seev036001.PriceFormat76Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev036001.PriceFormat75Choice||XmlElement()||
|+|CshValForTax|ISO20022.Seev036001.AmountPrice2||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev036001.IndicativeOrMarketPrice13Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct),validElement(CshValForTax),validElement(IndctvOrMktPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev036001.CorporateActionPrice84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OverSbcptDpstPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OverSbcptDpstPric),validElement(CshInLieuOfShrPric))|

---

## Value ISO20022.Seev036001.CorporateActionRate120


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblIncmPerDvddShr|global::System.Collections.Generic.List<ISO20022.Seev036001.RateTypeAndAmountAndStatus26>||XmlElement()||
|+|AddtlTax|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|PrratnRate|Decimal||XmlElement()||
|+|MaxAllwdOvrsbcptRate|Decimal||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice>||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036001.NetDividendRateFormat37Choice>||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036001.GrossDividendRateFormat35Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxblIncmPerDvddShr""",TaxblIncmPerDvddShr),validElement(TaxblIncmPerDvddShr),validElement(AddtlTax),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate))|

---

## Value ISO20022.Seev036001.CorporateActionRate125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|FinTxTaxRate|Decimal||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev036001.RateFormat27Choice||XmlElement()||
|+|AplblRate|Decimal||XmlElement()||
|+|FsclStmp|Decimal||XmlElement()||
|+|ChrgsFees|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
|+|NewToOd|ISO20022.Seev036001.RatioFormat19Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev036001.RatioFormat20Choice||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev036001.RatioFormat20Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(TaxCdtRate),validElement(ChrgsFees),validElement(NewToOd),validElement(AddtlQtyForExstgScties),validElement(AddtlQtyForSbcbdRsltntScties))|

---

## Enum ISO20022.Seev036001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev036001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev036001.DateCode19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.DateFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev036001.DateCode19Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev036001.DateFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev036001.DateCode19Choice||XmlElement()||
|+|Dt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev036001.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Enum ISO20022.Seev036001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev036001.DeemedRateType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.DeemedRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERY|Int32||XmlEnum("""DERY""")|1|
||DEIT|Int32||XmlEnum("""DEIT""")|2|
||DEFP|Int32||XmlEnum("""DEFP""")|3|
||DEDI|Int32||XmlEnum("""DEDI""")|4|

---

## Enum ISO20022.Seev036001.DividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Type ISO20022.Seev036001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnMvmntConf|ISO20022.Seev036001.CorporateActionMovementConfirmationV16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnMvmntConf))|

---

## Value ISO20022.Seev036001.DocumentIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036001.ProcessingPosition7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp))|

---

## Value ISO20022.Seev036001.DocumentIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev036001.ProcessingPosition7Choice||XmlElement()||
|+|DocNb|ISO20022.Seev036001.DocumentNumber5Choice||XmlElement()||
|+|Id|ISO20022.Seev036001.DocumentIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev036001.DocumentIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev036001.DocumentIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev036001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev036001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev036001.ForeignExchangeTerms40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev036001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev036001.FractionDispositionType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDUP|Int32||XmlEnum("""RDUP""")|1|
||STAN|Int32||XmlEnum("""STAN""")|2|
||RDDN|Int32||XmlEnum("""RDDN""")|3|
||DIST|Int32||XmlEnum("""DIST""")|4|
||CINL|Int32||XmlEnum("""CINL""")|5|
||BUYU|Int32||XmlEnum("""BUYU""")|6|

---

## Value ISO20022.Seev036001.FractionDispositionType27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev036001.GrossDividendRateFormat35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus55||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev036001.GrossDividendRateFormat37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus57||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev036001.GrossDividendRateType6Code


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

## Enum ISO20022.Seev036001.GrossDividendRateType7Code


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

## Value ISO20022.Seev036001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.IndicativeOrMarketPrice13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Value ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus24||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev036001.IntermediateSecuritiesDistributionTypeFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.IntermediateSecurityDistributionType5Code


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

## Value ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.IssuerTaxability2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXBL|Int32||XmlEnum("""TXBL""")|1|

---

## Enum ISO20022.Seev036001.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev036001.LotteryTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev036001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev036001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Seev036001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Seev036001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Seev036001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev036001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev036001.NetDividendRateFormat37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus56||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Value ISO20022.Seev036001.NetDividendRateFormat40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus58||XmlElement()||
|+|AmtAndRateSts|ISO20022.Seev036001.AmountAndRateStatus1||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndAmtAndRateSts),validElement(AmtAndRateSts),validElement(Amt),validChoice(RateTpAndAmtAndRateSts,AmtAndRateSts,Amt))|

---

## Enum ISO20022.Seev036001.NetDividendRateType6Code


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

## Enum ISO20022.Seev036001.NetDividendRateType7Code


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

## Enum ISO20022.Seev036001.NewSecuritiesIssuanceType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NREF|Int32||XmlEnum("""NREF""")|1|
||REFU|Int32||XmlEnum("""REFU""")|2|
||NDEF|Int32||XmlEnum("""NDEF""")|3|
||DEFE|Int32||XmlEnum("""DEFE""")|4|

---

## Enum ISO20022.Seev036001.OptionFeatures14Code


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

## Value ISO20022.Seev036001.OptionFeaturesFormat29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev036001.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev036001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.OriginalAndCurrentQuantities6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev036001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev036001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev036001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev036001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev036001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev036001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev036001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev036001.PartyIdentification133Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev036001.GenericIdentification36||XmlElement()||
|+|NmAndAdr|ISO20022.Seev036001.NameAndAddress5||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Seev036001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev036001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Seev036001.PartyIdentification316


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev036001.AlternatePartyIdentification7>||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|Id|ISO20022.Seev036001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AltrnId""",AltrnId),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Seev036001.PartyIdentificationAndAccount204


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev036001.AlternatePartyIdentification7>||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Id|ISO20022.Seev036001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AltrnId""",AltrnId),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Seev036001.PartyIdentificationAndAccount225


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Seev036001.AlternatePartyIdentification7||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Seev036001.CashAccountIdentification9Choice||XmlElement()||
|+|Id|ISO20022.Seev036001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(CshAcct),validElement(Id))|

---

## Value ISO20022.Seev036001.PartyIdentificationAndAccount226


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Seev036001.AlternatePartyIdentification7||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Seev036001.CashAccountIdentification9Choice||XmlElement()||
|+|Id|ISO20022.Seev036001.PartyIdentification133Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(CshAcct),validElement(Id))|

---

## Enum ISO20022.Seev036001.Payment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONT|Int32||XmlEnum("""CONT""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev036001.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.Period11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev036001.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Seev036001.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev036001.PostalAddress1


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

## Value ISO20022.Seev036001.PriceDetails37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInLieuOfShrPric|ISO20022.Seev036001.PriceFormat77Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev036001.PriceFormat76Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev036001.PriceFormat75Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInLieuOfShrPric),validElement(GncCshPricRcvdPerPdct),validElement(GncCshPricPdPerPdct))|

---

## Value ISO20022.Seev036001.PriceFormat75Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPric|ISO20022.Seev036001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev036001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPric,PctgPric))|

---

## Value ISO20022.Seev036001.PriceFormat76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev036001.AmountPricePerAmount2||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev036001.AmountPricePerFinancialInstrumentQuantity10||XmlElement()||
|+|AmtPric|ISO20022.Seev036001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev036001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,AmtPric,PctgPric))|

---

## Value ISO20022.Seev036001.PriceFormat77Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtPric|ISO20022.Seev036001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev036001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(AmtPric,PctgPric))|

---

## Enum ISO20022.Seev036001.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev036001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev036001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.ProprietaryQuantity7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036001.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev036001.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev036001.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev036001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev036001.Quantity49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev036001.ProprietaryQuantity7||XmlElement()||
|+|QtyChc|ISO20022.Seev036001.Quantity50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev036001.Quantity50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev036001.OriginalAndCurrentQuantities6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev036001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev036001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Seev036001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev036001.QuantityToQuantityRatio1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.Rate41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmdRate|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat62Choice>||XmlElement()||
|+|EqulstnRate|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|TaxRclmRate|Decimal||XmlElement()||
|+|TaxOnPrfts|Decimal||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
|+|ScndLvlTax|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|WhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev036001.RateAndAmountFormat55Choice>||XmlElement()||
|+|TaxCdtRate|ISO20022.Seev036001.RateFormat27Choice||XmlElement()||
|+|SlctnFeeRate|ISO20022.Seev036001.SolicitationFeeRateFormat12Choice||XmlElement()||
|+|AplblRate|Decimal||XmlElement()||
|+|NetDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036001.NetDividendRateFormat40Choice>||XmlElement()||
|+|GrssIntrstRateUsdForPmt|global::System.Collections.Generic.List<ISO20022.Seev036001.InterestRateUsedForPaymentFormat12Choice>||XmlElement()||
|+|ThrdPtyIncntivRate|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
|+|EarlySlctnFeeRate|ISO20022.Seev036001.SolicitationFeeRateFormat12Choice||XmlElement()||
|+|GrssDstrbtnRate|global::System.Collections.Generic.List<ISO20022.Seev036001.GrossDividendRateFormat37Choice>||XmlElement()||
|+|FsclStmp|Decimal||XmlElement()||
|+|ChrgsFees|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
|+|AddtlTax|ISO20022.Seev036001.RateAndAmountFormat59Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DmdRate""",DmdRate),validElement(DmdRate),validElement(EqulstnRate),validElement(TaxOnIncm),validList("""ScndLvlTax""",ScndLvlTax),validElement(ScndLvlTax),validList("""WhldgTaxRate""",WhldgTaxRate),validElement(WhldgTaxRate),validElement(TaxCdtRate),validElement(SlctnFeeRate),validList("""NetDstrbtnRate""",NetDstrbtnRate),validElement(NetDstrbtnRate),validList("""GrssIntrstRateUsdForPmt""",GrssIntrstRateUsdForPmt),validElement(GrssIntrstRateUsdForPmt),validElement(ThrdPtyIncntivRate),validElement(EarlySlctnFeeRate),validList("""GrssDstrbtnRate""",GrssDstrbtnRate),validElement(GrssDstrbtnRate),validElement(ChrgsFees),validElement(AddtlTax))|

---

## Value ISO20022.Seev036001.RateAndAmountFormat55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev036001.RateTypeAndPercentageRate12||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,Rate))|

---

## Value ISO20022.Seev036001.RateAndAmountFormat59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev036001.RateAndAmountFormat62Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev036001.RateTypeAndPercentageRate14||XmlElement()||
|+|RateTpAndAmtAndRateSts|ISO20022.Seev036001.RateTypeAndAmountAndStatus37||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(RateTpAndAmtAndRateSts),validElement(Amt),validChoice(RateTpAndRate,RateTpAndAmtAndRateSts,Amt,Rate))|

---

## Value ISO20022.Seev036001.RateFormat27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Seev036001.RateStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDI|Int32||XmlEnum("""INDI""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|

---

## Value ISO20022.Seev036001.RateStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType77Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType78Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev036001.RateType79Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev036001.RateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USCD|Int32||XmlEnum("""USCD""")|1|
||SCHD|Int32||XmlEnum("""SCHD""")|2|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.DeemedRateType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus55


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType76Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType78Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndAmountAndStatus58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateSts|ISO20022.Seev036001.RateStatus3Choice||XmlElement()||
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType79Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateSts),validElement(Amt),validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndPercentageRate12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev036001.RateType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev036001.RateTypeAndPercentageRate14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev036001.DeemedRateType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Value ISO20022.Seev036001.RatioFormat19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyToAmt|ISO20022.Seev036001.AmountAndQuantityRatio4||XmlElement()||
|+|AmtToQty|ISO20022.Seev036001.AmountAndQuantityRatio4||XmlElement()||
|+|AmtToAmt|ISO20022.Seev036001.AmountToAmountRatio2||XmlElement()||
|+|QtyToQty|ISO20022.Seev036001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(QtyToAmt,AmtToQty,AmtToAmt,QtyToQty))|

---

## Value ISO20022.Seev036001.RatioFormat20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtToAmt|ISO20022.Seev036001.AmountToAmountRatio2||XmlElement()||
|+|QtyToQty|ISO20022.Seev036001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtToAmt),validElement(QtyToQty),validChoice(AmtToAmt,QtyToQty))|

---

## Enum ISO20022.Seev036001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev036001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Enum ISO20022.Seev036001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Seev036001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev036001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev036001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev036001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev036001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev036001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.SecuritiesOption112


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSttlmPties|ISO20022.Seev036001.SettlementParties129||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Seev036001.SettlementParties129||XmlElement()||
|+|AmtDtls|ISO20022.Seev036001.CorporateActionAmounts60||XmlElement()||
|+|PricDtls|ISO20022.Seev036001.CorporateActionPrice83||XmlElement()||
|+|RateDtls|ISO20022.Seev036001.CorporateActionRate125||XmlElement()||
|+|DtDtls|ISO20022.Seev036001.SecurityDate25||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev036001.FractionDispositionType27Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev036001.SafekeepingPlaceFormat41Choice||XmlElement()||
|+|PstngQty|ISO20022.Seev036001.Quantity51Choice||XmlElement()||
|+|CtryOfIncmSrc|String||XmlElement()||
|+|XmptnTp|global::System.Collections.Generic.List<ISO20022.Seev036001.GenericIdentification30>||XmlElement()||
|+|OthrIncmTp|global::System.Collections.Generic.List<ISO20022.Seev036001.GenericIdentification30>||XmlElement()||
|+|IncmTp|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|IssrOfferrTaxbltyInd|ISO20022.Seev036001.IssuerOfferorTaxabilityIndicator2Choice||XmlElement()||
|+|NewSctiesIssncInd|String||XmlElement()||
|+|TempFinInstrmInd|ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Seev036001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSttlmPties),validElement(RcvgSttlmPties),validElement(AmtDtls),validElement(PricDtls),validElement(RateDtls),validElement(DtDtls),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validElement(FrctnDspstn),validElement(SfkpgPlc),validElement(PstngQty),validPattern("""CtryOfIncmSrc""",CtryOfIncmSrc,"""[A-Z]{2,2}"""),validList("""XmptnTp""",XmptnTp),validElement(XmptnTp),validList("""OthrIncmTp""",OthrIncmTp),validElement(OthrIncmTp),validElement(IncmTp),validElement(IssrOfferrTaxbltyInd),validElement(TempFinInstrmInd),validElement(FinInstrmId))|

---

## Value ISO20022.Seev036001.SecurityDate25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev036001.DateFormat30Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtDt),validElement(EarlstPmtDt),validElement(DvddRnkgDt),validElement(PrpssDt),validElement(AvlblDt),validElement(PstngDt))|

---

## Value ISO20022.Seev036001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev036001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev036001.SettlementParties129


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty3|ISO20022.Seev036001.PartyIdentificationAndAccount204||XmlElement()||
|+|Pty2|ISO20022.Seev036001.PartyIdentificationAndAccount204||XmlElement()||
|+|Pty1|ISO20022.Seev036001.PartyIdentificationAndAccount204||XmlElement()||
|+|Dpstry|ISO20022.Seev036001.PartyIdentification316||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Seev036001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev036001.SignedQuantityFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev036001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev036001.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev036001.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev036001.SolicitationFeeRateFormat12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev036001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtToQty|ISO20022.Seev036001.AmountAndQuantityRatio4||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(AmtToQty),validChoice(Amt,AmtToQty,Rate))|

---

## Value ISO20022.Seev036001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev036001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev036001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev036001.TaxVoucher4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrgnSttlmDt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
|+|BrgnDt|ISO20022.Seev036001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrgnSttlmDt),validElement(BrgnDt))|

---

## Value ISO20022.Seev036001.TemporaryFinancialInstrumentIndicator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev036001.GenericIdentification30||XmlElement()||
|+|TempInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,TempInd))|

---

## Value ISO20022.Seev036001.TotalEligibleBalanceFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PartWayPrdUnits|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|FullPrdUnits|ISO20022.Seev036001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev036001.Quantity49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PartWayPrdUnits),validElement(FullPrdUnits),validElement(Bal))|

---

## Value ISO20022.Seev036001.TransactionIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktInfrstrctrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev036001.TypeOfIdentification1Code


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

## Enum ISO20022.Seev036001.WithholdingTaxRateType1Code


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

