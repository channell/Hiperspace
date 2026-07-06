# seev.010.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev010001.AccountIdentification2Choice {
        + SctiesAcctId  : String
        + CshAcctId  : String
    }
    class ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev010001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev010001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev010001.AgentCANotificationCancellationRequestV01 {
        + CorpActnNtfctnDtls  : ISO20022.Seev010001.CorporateActionNotificationAdvice1
        + CorpActnGnlInf  : ISO20022.Seev010001.CorporateActionInformation2
        + NtfctnCxlTpAndLkg  : ISO20022.Seev010001.NotificationCancellation1
        + Id  : ISO20022.Seev010001.DocumentIdentification8
    }
    ISO20022.Seev010001.AgentCANotificationCancellationRequestV01 *-- ISO20022.Seev010001.CorporateActionNotificationAdvice1
    ISO20022.Seev010001.AgentCANotificationCancellationRequestV01 *-- ISO20022.Seev010001.CorporateActionInformation2
    ISO20022.Seev010001.AgentCANotificationCancellationRequestV01 *-- ISO20022.Seev010001.NotificationCancellation1
    ISO20022.Seev010001.AgentCANotificationCancellationRequestV01 *-- ISO20022.Seev010001.DocumentIdentification8
    class ISO20022.Seev010001.AgentRole1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.AgentRole1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.AgentRole2Code {
        PAYA = 1
        REGR = 2
        ISAG = 3
        CODO = 4
        SPAY = 5
    }
    class ISO20022.Seev010001.AlternateSecurityIdentification3 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Seev010001.AmountAndQuantityRatio1 {
        + Qty  : Decimal
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev010001.AmountAndQuantityRatio1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.AmountAndRateFormat2Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateType12FormatChoice
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev010001.AmountAndRateFormat2Choice *-- ISO20022.Seev010001.RateType12FormatChoice
    ISO20022.Seev010001.AmountAndRateFormat2Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.AmountAndRateFormat3Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateValueType6FormatChoice
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev010001.AmountAndRateFormat3Choice *-- ISO20022.Seev010001.RateValueType6FormatChoice
    ISO20022.Seev010001.AmountAndRateFormat3Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.AmountPrice1 {
        + PricVal  : ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : ISO20022.Seev010001.AmountPriceType1FormatChoice
    }
    ISO20022.Seev010001.AmountPrice1 *-- ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev010001.AmountPrice1 *-- ISO20022.Seev010001.AmountPriceType1FormatChoice
    class ISO20022.Seev010001.AmountPricePerAmount1 {
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : ISO20022.Seev010001.AmountPriceType1FormatChoice
    }
    ISO20022.Seev010001.AmountPricePerAmount1 *-- ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev010001.AmountPricePerAmount1 *-- ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev010001.AmountPricePerAmount1 *-- ISO20022.Seev010001.AmountPriceType1FormatChoice
    class ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1 {
        + FinInstrmQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + PricVal  : ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : ISO20022.Seev010001.AmountPriceType1FormatChoice
    }
    ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1 *-- ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1 *-- ISO20022.Seev010001.AmountPriceType1FormatChoice
    class ISO20022.Seev010001.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev010001.AmountPriceType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.AmountPriceType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.AmountToAmountRatio1 {
        + Amt2  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + Amt1  : ISO20022.Seev010001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev010001.AmountToAmountRatio1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.AmountToAmountRatio1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.BeneficiaryCertificationType1Code {
        NCOM = 1
        TRBD = 2
        QIBB = 3
        FULL = 4
        DOMI = 5
        ACCI = 6
    }
    class ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CashOption1 {
        + XchgRate  : ISO20022.Seev010001.ForeignExchangeTerms8
        + AmtDtls  : ISO20022.Seev010001.CorporateActionAmounts1
        + DtDtls  : ISO20022.Seev010001.CorporateActionDate5
        + Ccy  : String
        + CdtDbtInd  : String
    }
    ISO20022.Seev010001.CashOption1 *-- ISO20022.Seev010001.ForeignExchangeTerms8
    ISO20022.Seev010001.CashOption1 *-- ISO20022.Seev010001.CorporateActionAmounts1
    ISO20022.Seev010001.CashOption1 *-- ISO20022.Seev010001.CorporateActionDate5
    class ISO20022.Seev010001.ConversionType1Code {
        INTE = 1
        FINL = 2
    }
    class ISO20022.Seev010001.ConversionType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.ConversionType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateAction2 {
        + DstrbtnTp  : ISO20022.Seev010001.DistributionType1FormatChoice
        + RedChrgsApldInd  : String
        + ConvsTp  : ISO20022.Seev010001.ConversionType1FormatChoice
        + RnncblEntitlmntStsTp  : ISO20022.Seev010001.RenounceableStatus1FormatChoice
        + NewPlcOfIncorprtn  : String
        + TaxblIncmPerShrClctd  : String
        + CptlGn  : String
        + CertfctnTp  : ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice
        + CertfctnReqrdInd  : String
        + CorpActnAddtlInf  : ISO20022.Seev010001.CorporateActionNarrative1
        + RateAndAmtDtls  : ISO20022.Seev010001.CorporateActionRate1
        + PrdDtls  : ISO20022.Seev010001.CorporateActionPeriod1
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Seev010001.CorporateActionPrice2~
        + DtDtls  : ISO20022.Seev010001.CorporateActionDate2
        + NewDnmtnCcy  : String
        + IntrstAcrdNbOfDays  : Decimal
        + CpnNb  : global::System.Collections.Generic.List~String~
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice
        + DvddTp  : ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice
        + IncmTp  : ISO20022.Seev010001.GenericIdentification13
        + LtryTp  : ISO20022.Seev010001.LotteryType1FormatChoice
        + ElctnTp  : ISO20022.Seev010001.ElectionMovementType1FormatChoice
        + PrtlElctnInd  : String
        + RstrctnInd  : String
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev010001.OfferType1FormatChoice~
        + ChngTp  : global::System.Collections.Generic.List~ISO20022.Seev010001.CorporateActionChangeType1FormatChoice~
        + BaseDnmtn  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + SctiesQtySght  : ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
        + NewBrdLotSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + NewDnmtnSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + IncrmtlDnmtn  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + MinExrcblMltplSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + MinExrcblSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + FrntEndOddLotSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
        + BckEndOddLotSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
        + ClctnMtd  : ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice
        + DfltOptnNb  : String
        + DfltOptnTp  : ISO20022.Seev010001.CorporateActionOption1FormatChoice
        + EvtStag  : global::System.Collections.Generic.List~ISO20022.Seev010001.CorporateActionEventStage1FormatChoice~
    }
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.DistributionType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.ConversionType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.RenounceableStatus1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionNarrative1
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionRate1
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionPeriod1
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionPrice2
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionDate2
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.GenericIdentification13
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.LotteryType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.ElectionMovementType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.OfferType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionChangeType1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionOption1FormatChoice
    ISO20022.Seev010001.CorporateAction2 *-- ISO20022.Seev010001.CorporateActionEventStage1FormatChoice
    class ISO20022.Seev010001.CorporateActionAgent1 {
        + CtctPrsn  : ISO20022.Seev010001.NameAndAddress5
        + AgtRole  : ISO20022.Seev010001.AgentRole1FormatChoice
        + AgtId  : ISO20022.Seev010001.PartyIdentification2Choice
    }
    ISO20022.Seev010001.CorporateActionAgent1 *-- ISO20022.Seev010001.NameAndAddress5
    ISO20022.Seev010001.CorporateActionAgent1 *-- ISO20022.Seev010001.AgentRole1FormatChoice
    ISO20022.Seev010001.CorporateActionAgent1 *-- ISO20022.Seev010001.PartyIdentification2Choice
    class ISO20022.Seev010001.CorporateActionAmounts1 {
        + ChrgsAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + ShppgFeesAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + RgltryFeesAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + PstgFeeAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + LclBrkrComssnAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + PngAgtComssnAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + ExctgBrkrAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + FsclStmpAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + WhldgTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + AddtlTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + WhldgOfLclTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + WhldgOfFrgnTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TaxCdtAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TaxRclmAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + StmpDtyAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + CtryNtlFdrlTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + PmtLevyTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + LclTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + EURtntnTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + ValAddedTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TxTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TrfTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + StockXchgTaxAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + GrmnLclTax4Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + GrmnLclTax3Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + GrmnLclTax2Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + GrmnLclTax1Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TaxDfrrdAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TaxFreeAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + AddtlSbcptCost  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + CshIncntiv  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + EntitldAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + SpclCncssnAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + SndryOrOthrAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + UfrnkdAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + FullyFrnkdAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + MktClmAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + RinvstmtAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + PrncplOrCrps  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + ManfctrdDvddAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + RedPrmAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + IndmntyAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + IntrstAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + CptlGn  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + OrgnlAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + CshInLieuOfShr  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + SlctnFees  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + IsseDscntAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + NetCshAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + GrssCshAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
    }
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionAmounts1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.CorporateActionCalculationMethod1Code {
        NNOM = 1
        NOMI = 2
        LOTT = 3
        PROR = 4
    }
    class ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionChangeType1Code {
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
    class ISO20022.Seev010001.CorporateActionChangeType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionChangeType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionDate2 {
        + SpclExDt  : ISO20022.Seev010001.DateFormat4Choice
        + ElctnToCtrPtyDdln  : ISO20022.Seev010001.DateFormat4Choice
        + GrntedPrtcptnDt  : ISO20022.Seev010001.DateFormat4Choice
        + LpsdDt  : ISO20022.Seev010001.DateFormat4Choice
        + DdlnForTaxBrkdwnInstr  : ISO20022.Seev010001.DateFormat4Choice
        + PrratnDt  : ISO20022.Seev010001.DateFormat4Choice
        + RegnDdln  : ISO20022.Seev010001.DateFormat4Choice
        + RedDt  : ISO20022.Seev010001.DateFormat4Choice
        + CertfctnDdln  : ISO20022.Seev010001.DateFormat4Choice
        + TradgSspdDt  : ISO20022.Seev010001.DateFormat4Choice
        + MtrtyDt  : ISO20022.Seev010001.DateFormat4Choice
        + IndxFxgDt  : ISO20022.Seev010001.DateFormat4Choice
        + ExDvddDt  : ISO20022.Seev010001.DateFormat4Choice
        + EarlyClsgDt  : ISO20022.Seev010001.DateFormat4Choice
        + CrtApprvlDt  : ISO20022.Seev010001.DateFormat4Choice
        + RsltsPblctnDt  : ISO20022.Seev010001.DateFormat4Choice
        + WhlyUcondlDt  : ISO20022.Seev010001.DateFormat4Choice
        + UcondlDt  : ISO20022.Seev010001.DateFormat4Choice
        + PrtctDt  : ISO20022.Seev010001.DateFormat4Choice
        + LtryDt  : ISO20022.Seev010001.DateFormat4Choice
        + MrgnFxgDt  : ISO20022.Seev010001.DateFormat4Choice
        + EqulstnDt  : ISO20022.Seev010001.DateFormat4Choice
        + CoverXprtnDt  : ISO20022.Seev010001.DateFormat4Choice
        + FctvDt  : ISO20022.Seev010001.DateFormat4Choice
        + RcrdDt  : ISO20022.Seev010001.DateFormat4Choice
    }
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate2 *-- ISO20022.Seev010001.DateFormat4Choice
    class ISO20022.Seev010001.CorporateActionDate3 {
        + EarlstPmtDt  : ISO20022.Seev010001.DateFormat4Choice
        + FrstDealgDt  : ISO20022.Seev010001.DateFormat4Choice
        + PrpssDt  : ISO20022.Seev010001.DateFormat4Choice
        + DvddRnkgDt  : ISO20022.Seev010001.DateFormat4Choice
        + AvlblDt  : ISO20022.Seev010001.DateFormat4Choice
        + PmtDt  : ISO20022.Seev010001.DateFormat4Choice
    }
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate3 *-- ISO20022.Seev010001.DateFormat4Choice
    class ISO20022.Seev010001.CorporateActionDate4 {
        + SbcptCostDbtDt  : ISO20022.Seev010001.DateFormat4Choice
        + QtnSetngDt  : ISO20022.Seev010001.DateFormat4Choice
        + XpryDt  : ISO20022.Seev010001.DateFormat4Choice
        + DdlnToSplt  : ISO20022.Seev010001.DateFormat4Choice
        + RspnDdln  : ISO20022.Seev010001.DateFormat4Choice
        + MktDdln  : ISO20022.Seev010001.DateFormat4Choice
        + EarlstPmtDt  : ISO20022.Seev010001.DateFormat4Choice
        + PmtDt  : ISO20022.Seev010001.DateFormat4Choice
        + CnsntRcrdDt  : ISO20022.Seev010001.DateFormat4Choice
        + CnsntXprtnDt  : ISO20022.Seev010001.DateFormat4Choice
        + CpnClpngDt  : ISO20022.Seev010001.DateFormat4Choice
    }
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate4 *-- ISO20022.Seev010001.DateFormat4Choice
    class ISO20022.Seev010001.CorporateActionDate5 {
        + EarlstPmtDt  : ISO20022.Seev010001.DateFormat4Choice
        + PmtDt  : ISO20022.Seev010001.DateFormat4Choice
        + ValDt  : ISO20022.Seev010001.DateFormat4Choice
        + FXRateFxgDt  : ISO20022.Seev010001.DateFormat4Choice
    }
    ISO20022.Seev010001.CorporateActionDate5 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate5 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate5 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.CorporateActionDate5 *-- ISO20022.Seev010001.DateFormat4Choice
    class ISO20022.Seev010001.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionEventStage1Code {
        RESC = 1
        PART = 2
        LAPS = 3
        FULL = 4
        WHOU = 5
        UNAC = 6
        SUAP = 7
        PWAL = 8
        CLDE = 9
        APPD = 10
    }
    class ISO20022.Seev010001.CorporateActionEventStage1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionEventStage1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionEventStatus2Code {
        INAC = 1
        CANC = 2
        ACTI = 3
    }
    class ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionEventType2Code {
        OTHR = 1
        WTRC = 2
        WRTH = 3
        TREC = 4
        TEND = 5
        SUSP = 6
        SPLR = 7
        SPLF = 8
        SOFF = 9
        SMAL = 10
        SHPR = 11
        RHTS = 12
        RHDI = 13
        REMK = 14
        REDO = 15
        REDM = 16
        PRIO = 17
        PRII = 18
        PRED = 19
        PPMT = 20
        PLAC = 21
        PINK = 22
        PDEF = 23
        PCAL = 24
        PARI = 25
        ODLT = 26
        MRGR = 27
        MCAL = 28
        LIQU = 29
        INTR = 30
        INCR = 31
        EXWA = 32
        EXTM = 33
        EXRI = 34
        EXOF = 35
        DVSE = 36
        DVSC = 37
        DVOP = 38
        DVCA = 39
        DTCH = 40
        DSCL = 41
        DRIP = 42
        DRAW = 43
        DLST = 44
        DFLT = 45
        DETI = 46
        DECR = 47
        COOP = 48
        CONV = 49
        CONS = 50
        CLSA = 51
        CHAN = 52
        CERT = 53
        CAPI = 54
        CAPG = 55
        BRUP = 56
        BPUT = 57
        BONU = 58
        BIDS = 59
        ATTI = 60
        ACTV = 61
    }
    class ISO20022.Seev010001.CorporateActionEventType2FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionEventType2FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionFrequencyType1Code {
        SPEC = 1
        REGR = 2
        INTE = 3
        FINL = 4
    }
    class ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionInformation2 {
        + OthrUndrlygScty  : global::System.Collections.Generic.List~ISO20022.Seev010001.FinancialInstrumentDescription3~
        + UndrlygScty  : ISO20022.Seev010001.FinancialInstrumentDescription3
        + MndtryVlntryEvtTp  : ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice
        + EvtPrcgTp  : ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice
        + EvtTp  : ISO20022.Seev010001.CorporateActionEventType2FormatChoice
        + CorpActnPrcgId  : String
        + IssrCorpActnId  : String
        + AgtId  : ISO20022.Seev010001.PartyIdentification2Choice
    }
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.FinancialInstrumentDescription3
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.FinancialInstrumentDescription3
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.CorporateActionEventType2FormatChoice
    ISO20022.Seev010001.CorporateActionInformation2 *-- ISO20022.Seev010001.PartyIdentification2Choice
    class ISO20022.Seev010001.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionNarrative1 {
        + AddtlTxt  : String
        + URLAdr  : String
        + Offerr  : ISO20022.Seev010001.PartyIdentification2Choice
        + NewCpnyNm  : String
        + TaxtnConds  : String
        + InfToCmplyWth  : String
        + InfConds  : String
    }
    ISO20022.Seev010001.CorporateActionNarrative1 *-- ISO20022.Seev010001.PartyIdentification2Choice
    class ISO20022.Seev010001.CorporateActionNotificationAdvice1 {
        + CorpActnOptnDtls  : global::System.Collections.Generic.List~ISO20022.Seev010001.CorporateActionOption1~
        + CorpActnDtls  : ISO20022.Seev010001.CorporateAction2
    }
    ISO20022.Seev010001.CorporateActionNotificationAdvice1 *-- ISO20022.Seev010001.CorporateActionOption1
    ISO20022.Seev010001.CorporateActionNotificationAdvice1 *-- ISO20022.Seev010001.CorporateAction2
    class ISO20022.Seev010001.CorporateActionNotificationType2Code {
        CANC = 1
        WITH = 2
    }
    class ISO20022.Seev010001.CorporateActionOption1 {
        + CorpActnAddtlInf  : ISO20022.Seev010001.CorporateActionNarrative1
        + OptnFeatrs  : global::System.Collections.Generic.List~ISO20022.Seev010001.OptionFeatures1FormatChoice~
        + RedChrgsApldInd  : String
        + FrctnDspstn  : ISO20022.Seev010001.FractionDispositionType1FormatChoice
        + CorpActnOthrAgtDtls  : global::System.Collections.Generic.List~ISO20022.Seev010001.CorporateActionAgent1~
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev010001.CashOption1~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev010001.SecurityOption1~
        + PrdDtls  : ISO20022.Seev010001.CorporateActionPeriod2
        + PricDtls  : ISO20022.Seev010001.CorporateActionPrice1
        + RateAndAmtDtls  : ISO20022.Seev010001.CorporateActionRate2
        + DtDtls  : ISO20022.Seev010001.CorporateActionDate4
        + ChngAllwdInd  : String
        + WdrwlAllwdInd  : String
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice
        + OfferTp  : global::System.Collections.Generic.List~ISO20022.Seev010001.OfferType1FormatChoice~
        + AgtCshAcctId  : ISO20022.Seev010001.AccountIdentification2Choice
        + AgtSctiesAcctId  : String
        + AssntdLineSctyId  : ISO20022.Seev010001.SecurityIdentification7
        + CertfctnTp  : ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice
        + CertfctnInd  : String
        + OptnAvlbtySts  : ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice
        + OptnTp  : ISO20022.Seev010001.CorporateActionOption1FormatChoice
        + OptnNb  : String
    }
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionNarrative1
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.OptionFeatures1FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.FractionDispositionType1FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionAgent1
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CashOption1
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.SecurityOption1
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionPeriod2
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionPrice1
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionRate2
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionDate4
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.OfferType1FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.AccountIdentification2Choice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.SecurityIdentification7
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice
    ISO20022.Seev010001.CorporateActionOption1 *-- ISO20022.Seev010001.CorporateActionOption1FormatChoice
    class ISO20022.Seev010001.CorporateActionOption1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.CorporateActionOption1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.CorporateActionOptionType1Code {
        QINV = 1
        OTHR = 2
        NOQU = 3
        SPLI = 4
        SLLE = 5
        SECU = 6
        OVER = 7
        OFFR = 8
        NOAC = 9
        MPUT = 10
        LAPS = 11
        EXER = 12
        CONY = 13
        CONN = 14
        CTEN = 15
        CEXC = 16
        CASH = 17
        CASE = 18
        BUYA = 19
        BSPL = 20
    }
    class ISO20022.Seev010001.CorporateActionPeriod1 {
        + PricClctnPrd  : ISO20022.Seev010001.Period1
        + BlckgPrd  : ISO20022.Seev010001.Period1
        + IntrstPrd  : ISO20022.Seev010001.Period1
        + CmplsryPurchsPrd  : ISO20022.Seev010001.Period1
        + ActnPrd  : ISO20022.Seev010001.Period1
    }
    ISO20022.Seev010001.CorporateActionPeriod1 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod1 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod1 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod1 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod1 *-- ISO20022.Seev010001.Period1
    class ISO20022.Seev010001.CorporateActionPeriod2 {
        + PricClctnPrd  : ISO20022.Seev010001.Period1
        + RvcbltyPrd  : ISO20022.Seev010001.Period1
        + SellThruIssrPrd  : ISO20022.Seev010001.Period1
        + ParllTradgPrd  : ISO20022.Seev010001.Period1
        + PrvlgSspnsnPrd  : ISO20022.Seev010001.Period1
        + ActnPrd  : ISO20022.Seev010001.Period1
        + AssntdLinePrd  : ISO20022.Seev010001.Period1
    }
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.CorporateActionPeriod2 *-- ISO20022.Seev010001.Period1
    class ISO20022.Seev010001.CorporateActionPrice1 {
        + OverSbcptDpstPric  : ISO20022.Seev010001.PriceFormat2Choice
        + GncCshPricPdPerPdct  : ISO20022.Seev010001.PriceFormat2Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev010001.PriceFormat1Choice
        + TaxblIncmPerDvddShr  : ISO20022.Seev010001.AmountPrice1
        + CshInLieuOfShrPric  : ISO20022.Seev010001.PriceFormat2Choice
        + IssePric  : ISO20022.Seev010001.PriceFormat2Choice
        + ExrcPric  : ISO20022.Seev010001.PriceFormat4Choice
    }
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat2Choice
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat2Choice
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat1Choice
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.AmountPrice1
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat2Choice
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat2Choice
    ISO20022.Seev010001.CorporateActionPrice1 *-- ISO20022.Seev010001.PriceFormat4Choice
    class ISO20022.Seev010001.CorporateActionPrice2 {
        + MinPric  : ISO20022.Seev010001.PriceFormat3Choice
        + MaxPric  : ISO20022.Seev010001.PriceFormat3Choice
    }
    ISO20022.Seev010001.CorporateActionPrice2 *-- ISO20022.Seev010001.PriceFormat3Choice
    ISO20022.Seev010001.CorporateActionPrice2 *-- ISO20022.Seev010001.PriceFormat3Choice
    class ISO20022.Seev010001.CorporateActionPrice4 {
        + MktPric  : ISO20022.Seev010001.PriceFormat2Choice
        + IndctvPric  : ISO20022.Seev010001.PriceFormat2Choice
    }
    ISO20022.Seev010001.CorporateActionPrice4 *-- ISO20022.Seev010001.PriceFormat2Choice
    ISO20022.Seev010001.CorporateActionPrice4 *-- ISO20022.Seev010001.PriceFormat2Choice
    class ISO20022.Seev010001.CorporateActionRate1 {
        + Chrgs  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + BidIntrvl  : ISO20022.Seev010001.AmountAndRateFormat3Choice
        + Sprd  : ISO20022.Seev010001.RateFormat1Choice
        + RinvstmtDscntToMkt  : ISO20022.Seev010001.RateFormat1Choice
        + PctgSght  : ISO20022.Seev010001.RateFormat1Choice
        + RltdIndx  : ISO20022.Seev010001.RateFormat1Choice
        + Intrst  : ISO20022.Seev010001.RateAndAmountFormat1Choice
    }
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.AmountAndRateFormat3Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate1 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    class ISO20022.Seev010001.CorporateActionRate2 {
        + AplblRate  : ISO20022.Seev010001.RateFormat1Choice
        + XchgRate  : ISO20022.Seev010001.ForeignExchangeTerms8
        + OrgnlAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + AddtlTax  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + MaxAllwdOvrsbcpt  : ISO20022.Seev010001.RateFormat1Choice
        + SlctnFee  : ISO20022.Seev010001.RateFormat1Choice
        + CshIncntiv  : ISO20022.Seev010001.RateFormat1Choice
        + PrvsnlDvdd  : ISO20022.Seev010001.AmountAndRateFormat2Choice
        + FnlDvdd  : ISO20022.Seev010001.AmountAndRateFormat2Choice
        + NetDvdd  : ISO20022.Seev010001.NetDividendRate1Choice
        + GrssDvdd  : ISO20022.Seev010001.GrossDividendRate1Choice
        + FullyFrnkd  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + IndxFctr  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + IntrstForUsdPmt  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + Chrgs  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + NonResdtRate  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + RltdTax  : ISO20022.Seev010001.RelatedTaxType1
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev010001.RatioFormat1Choice
        + AddtlQtyForExstgScties  : ISO20022.Seev010001.RatioFormat1Choice
        + NewSctiesToUndrlygScties  : ISO20022.Seev010001.RatioFormat2Choice
        + NewToOd  : ISO20022.Seev010001.RatioFormat2Choice
        + Prratn  : ISO20022.Seev010001.RateFormat1Choice
        + FsclStmp  : ISO20022.Seev010001.RateFormat1Choice
        + TaxRclm  : ISO20022.Seev010001.RateFormat1Choice
        + TaxOnPrft  : ISO20022.Seev010001.RateFormat1Choice
        + TaxOnIncm  : ISO20022.Seev010001.RateFormat1Choice
        + GrmnLclTax4  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + GrmnLclTax3  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + GrmnLclTax2  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + GrmnLclTax1  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + WhldgOfLclTax  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + WhldgOfFrgnTax  : ISO20022.Seev010001.RateAndAmountFormat1Choice
        + WhldgTax  : ISO20022.Seev010001.RateFormat1Choice
    }
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.ForeignExchangeTerms8
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.AmountAndRateFormat2Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.AmountAndRateFormat2Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.NetDividendRate1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.GrossDividendRate1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RelatedTaxType1
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RatioFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RatioFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RatioFormat2Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RatioFormat2Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateAndAmountFormat1Choice
    ISO20022.Seev010001.CorporateActionRate2 *-- ISO20022.Seev010001.RateFormat1Choice
    class ISO20022.Seev010001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev010001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev010001.DateFormat4Choice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Seev010001.DateAndDateTimeChoice
    }
    ISO20022.Seev010001.DateFormat4Choice *-- ISO20022.Seev010001.GenericIdentification13
    ISO20022.Seev010001.DateFormat4Choice *-- ISO20022.Seev010001.DateAndDateTimeChoice
    class ISO20022.Seev010001.DateType6Code {
        ONGO = 1
        UKWN = 2
        OPEN = 3
    }
    class ISO20022.Seev010001.DistributionType1Code {
        ROLL = 1
    }
    class ISO20022.Seev010001.DistributionType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.DistributionType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.DocumentIdentification8 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Seev010001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Seev010001.ElectionMovementType1Code {
        DRCT = 1
        REST = 2
    }
    class ISO20022.Seev010001.ElectionMovementType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.ElectionMovementType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.FinancialInstrumentDescription3 {
        + SfkpgPlc  : ISO20022.Seev010001.PartyIdentification2Choice
        + PlcOfListg  : String
        + SctyId  : ISO20022.Seev010001.SecurityIdentification7
    }
    ISO20022.Seev010001.FinancialInstrumentDescription3 *-- ISO20022.Seev010001.PartyIdentification2Choice
    ISO20022.Seev010001.FinancialInstrumentDescription3 *-- ISO20022.Seev010001.SecurityIdentification7
    class ISO20022.Seev010001.ForeignExchangeTerms8 {
        + RsltgAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Seev010001.ForeignExchangeTerms8 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.FractionDispositionType1Code {
        STAN = 1
        RDUP = 2
        RDDN = 3
        DIST = 4
        CINL = 5
        BUYU = 6
    }
    class ISO20022.Seev010001.FractionDispositionType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.FractionDispositionType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev010001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev010001.GrossDividendRate1Choice {
        + RateTpAmt  : ISO20022.Seev010001.GrossDividendRate2
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + NotSpcfdRate  : ISO20022.Seev010001.RateValueType2FormatChoice
    }
    ISO20022.Seev010001.GrossDividendRate1Choice *-- ISO20022.Seev010001.GrossDividendRate2
    ISO20022.Seev010001.GrossDividendRate1Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.GrossDividendRate1Choice *-- ISO20022.Seev010001.RateValueType2FormatChoice
    class ISO20022.Seev010001.GrossDividendRate2 {
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + RateTp  : ISO20022.Seev010001.GrossDividendRateType1FormatChoice
    }
    ISO20022.Seev010001.GrossDividendRate2 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.GrossDividendRate2 *-- ISO20022.Seev010001.GrossDividendRateType1FormatChoice
    class ISO20022.Seev010001.GrossDividendRateType1Code {
        STCG = 1
        LTCG = 2
        UNFR = 3
        TXFR = 4
        TXDF = 5
        TXBL = 6
        SOIC = 7
        INTR = 8
        INCO = 9
        FLFR = 10
        CAPO = 11
    }
    class ISO20022.Seev010001.GrossDividendRateType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.GrossDividendRateType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.IntermediateSecurityDistributionType1Code {
        SOFF = 1
        LIQU = 2
        INTR = 3
        DVSE = 4
        DVSC = 5
        PRIO = 6
        EXRI = 7
        DVOP = 8
        DVCA = 9
        DRIP = 10
        BONU = 11
        BIDS = 12
    }
    class ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev010001.LotteryType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.LotteryType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.NameAndAddress5 {
        + Adr  : ISO20022.Seev010001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev010001.NameAndAddress5 *-- ISO20022.Seev010001.PostalAddress1
    class ISO20022.Seev010001.NetDividendRate1Choice {
        + RateTpAmt  : ISO20022.Seev010001.NetDividendRate2
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + NotSpcfdRate  : ISO20022.Seev010001.RateValueType6FormatChoice
    }
    ISO20022.Seev010001.NetDividendRate1Choice *-- ISO20022.Seev010001.NetDividendRate2
    ISO20022.Seev010001.NetDividendRate1Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.NetDividendRate1Choice *-- ISO20022.Seev010001.RateValueType6FormatChoice
    class ISO20022.Seev010001.NetDividendRate2 {
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + RateTp  : ISO20022.Seev010001.NetDividendRateType1FormatChoice
    }
    ISO20022.Seev010001.NetDividendRate2 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.NetDividendRate2 *-- ISO20022.Seev010001.NetDividendRateType1FormatChoice
    class ISO20022.Seev010001.NetDividendRateType1Code {
        UNFR = 1
        TXFR = 2
        TXDF = 3
        TXBL = 4
        SOIC = 5
        INTR = 6
        INCO = 7
        FLFR = 8
        CAPO = 9
    }
    class ISO20022.Seev010001.NetDividendRateType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.NetDividendRateType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.NotificationCancellation1 {
        + LkdAgtCANtfctnAdvcId  : ISO20022.Seev010001.DocumentIdentification8
        + NtfctnCxlTp  : String
    }
    ISO20022.Seev010001.NotificationCancellation1 *-- ISO20022.Seev010001.DocumentIdentification8
    class ISO20022.Seev010001.OfferType1Code {
        SQUE = 1
        PART = 2
        MINI = 3
        FINL = 4
        FCFS = 5
        ERUN = 6
        DISS = 7
    }
    class ISO20022.Seev010001.OfferType1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.OfferType1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.OptionFeatures1Code {
        VVPR = 1
        QREC = 2
        QOVE = 3
        PROR = 4
        OPLF = 5
        MAXS = 6
        MAXC = 7
        COND = 8
    }
    class ISO20022.Seev010001.OptionFeatures1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.OptionFeatures1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Seev010001.NameAndAddress5
        + PrtryId  : ISO20022.Seev010001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Seev010001.PartyIdentification2Choice *-- ISO20022.Seev010001.NameAndAddress5
    ISO20022.Seev010001.PartyIdentification2Choice *-- ISO20022.Seev010001.GenericIdentification1
    class ISO20022.Seev010001.Period1 {
        + EndDt  : ISO20022.Seev010001.DateFormat4Choice
        + StartDt  : ISO20022.Seev010001.DateFormat4Choice
    }
    ISO20022.Seev010001.Period1 *-- ISO20022.Seev010001.DateFormat4Choice
    ISO20022.Seev010001.Period1 *-- ISO20022.Seev010001.DateFormat4Choice
    class ISO20022.Seev010001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev010001.PriceFormat1Choice {
        + NotSpcfd  : ISO20022.Seev010001.PriceValueType6FormatChoice
        + AmtPricPerAmt  : ISO20022.Seev010001.AmountPricePerAmount1
        + AmtPricPerFinInstrmQty  : ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1
        + Rate  : Decimal
        + Amt  : ISO20022.Seev010001.AmountPrice1
    }
    ISO20022.Seev010001.PriceFormat1Choice *-- ISO20022.Seev010001.PriceValueType6FormatChoice
    ISO20022.Seev010001.PriceFormat1Choice *-- ISO20022.Seev010001.AmountPricePerAmount1
    ISO20022.Seev010001.PriceFormat1Choice *-- ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1
    ISO20022.Seev010001.PriceFormat1Choice *-- ISO20022.Seev010001.AmountPrice1
    class ISO20022.Seev010001.PriceFormat2Choice {
        + NotSpcfd  : ISO20022.Seev010001.PriceValueType5FormatChoice
        + Rate  : ISO20022.Seev010001.PriceRate1
        + Amt  : ISO20022.Seev010001.AmountPrice1
    }
    ISO20022.Seev010001.PriceFormat2Choice *-- ISO20022.Seev010001.PriceValueType5FormatChoice
    ISO20022.Seev010001.PriceFormat2Choice *-- ISO20022.Seev010001.PriceRate1
    ISO20022.Seev010001.PriceFormat2Choice *-- ISO20022.Seev010001.AmountPrice1
    class ISO20022.Seev010001.PriceFormat3Choice {
        + Rate  : ISO20022.Seev010001.PriceRate1
        + Amt  : ISO20022.Seev010001.AmountPrice1
    }
    ISO20022.Seev010001.PriceFormat3Choice *-- ISO20022.Seev010001.PriceRate1
    ISO20022.Seev010001.PriceFormat3Choice *-- ISO20022.Seev010001.AmountPrice1
    class ISO20022.Seev010001.PriceFormat4Choice {
        + IndxPts  : Decimal
        + NotSpcfd  : ISO20022.Seev010001.PriceValueType5FormatChoice
        + Rate  : ISO20022.Seev010001.PriceRate1
        + Amt  : ISO20022.Seev010001.AmountPrice1
    }
    ISO20022.Seev010001.PriceFormat4Choice *-- ISO20022.Seev010001.PriceValueType5FormatChoice
    ISO20022.Seev010001.PriceFormat4Choice *-- ISO20022.Seev010001.PriceRate1
    ISO20022.Seev010001.PriceFormat4Choice *-- ISO20022.Seev010001.AmountPrice1
    class ISO20022.Seev010001.PriceRate1 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev010001.PriceRateType3FormatChoice
    }
    ISO20022.Seev010001.PriceRate1 *-- ISO20022.Seev010001.PriceRateType3FormatChoice
    class ISO20022.Seev010001.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev010001.PriceRateType3FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.PriceRateType3FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.PriceValueType5Code {
        OPEN = 1
        UKWN = 2
    }
    class ISO20022.Seev010001.PriceValueType5FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.PriceValueType5FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.PriceValueType6Code {
        TBSP = 1
        UNSP = 2
        OPEN = 3
        UKWN = 4
    }
    class ISO20022.Seev010001.PriceValueType6FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.PriceValueType6FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.Quantity1Code {
        QALL = 1
    }
    class ISO20022.Seev010001.QuantityToQuantityRatio1 {
        + Qty2  : Decimal
        + Qty1  : Decimal
    }
    class ISO20022.Seev010001.RateAndAmountFormat1Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateType12FormatChoice
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Seev010001.RateAndAmountFormat1Choice *-- ISO20022.Seev010001.RateType12FormatChoice
    ISO20022.Seev010001.RateAndAmountFormat1Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.RateFormat1Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateType12FormatChoice
        + Rate  : Decimal
    }
    ISO20022.Seev010001.RateFormat1Choice *-- ISO20022.Seev010001.RateType12FormatChoice
    class ISO20022.Seev010001.RateType12Code {
        NILP = 1
        UKWN = 2
        OPEN = 3
    }
    class ISO20022.Seev010001.RateType12FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.RateType12FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.RateValueType2Code {
        NILP = 1
        OPEN = 2
        UKWN = 3
    }
    class ISO20022.Seev010001.RateValueType2FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.RateValueType2FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.RateValueType6Code {
        OPEN = 1
        UKWN = 2
    }
    class ISO20022.Seev010001.RateValueType6FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.RateValueType6FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.RatioFormat1Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateType12FormatChoice
        + AmtToAmt  : ISO20022.Seev010001.AmountToAmountRatio1
        + QtyToQty  : ISO20022.Seev010001.QuantityToQuantityRatio1
    }
    ISO20022.Seev010001.RatioFormat1Choice *-- ISO20022.Seev010001.RateType12FormatChoice
    ISO20022.Seev010001.RatioFormat1Choice *-- ISO20022.Seev010001.AmountToAmountRatio1
    ISO20022.Seev010001.RatioFormat1Choice *-- ISO20022.Seev010001.QuantityToQuantityRatio1
    class ISO20022.Seev010001.RatioFormat2Choice {
        + NotSpcfdRate  : ISO20022.Seev010001.RateType12FormatChoice
        + QtyToAmt  : ISO20022.Seev010001.AmountAndQuantityRatio1
        + AmtToQty  : ISO20022.Seev010001.AmountAndQuantityRatio1
        + AmtToAmt  : ISO20022.Seev010001.AmountToAmountRatio1
        + QtyToQty  : ISO20022.Seev010001.QuantityToQuantityRatio1
    }
    ISO20022.Seev010001.RatioFormat2Choice *-- ISO20022.Seev010001.RateType12FormatChoice
    ISO20022.Seev010001.RatioFormat2Choice *-- ISO20022.Seev010001.AmountAndQuantityRatio1
    ISO20022.Seev010001.RatioFormat2Choice *-- ISO20022.Seev010001.AmountAndQuantityRatio1
    ISO20022.Seev010001.RatioFormat2Choice *-- ISO20022.Seev010001.AmountToAmountRatio1
    ISO20022.Seev010001.RatioFormat2Choice *-- ISO20022.Seev010001.QuantityToQuantityRatio1
    class ISO20022.Seev010001.RelatedTaxType1 {
        + Amt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + TaxTp  : ISO20022.Seev010001.TaxType3FormatChoice
    }
    ISO20022.Seev010001.RelatedTaxType1 *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    ISO20022.Seev010001.RelatedTaxType1 *-- ISO20022.Seev010001.TaxType3FormatChoice
    class ISO20022.Seev010001.RenounceableStatus1Code {
        RENO = 1
        NREN = 2
    }
    class ISO20022.Seev010001.RenounceableStatus1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.RenounceableStatus1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.SecurityIdentification7 {
        + Desc  : String
        + OthrId  : ISO20022.Seev010001.AlternateSecurityIdentification3
        + ISIN  : String
    }
    ISO20022.Seev010001.SecurityIdentification7 *-- ISO20022.Seev010001.AlternateSecurityIdentification3
    class ISO20022.Seev010001.SecurityOption1 {
        + FrctnDspstn  : ISO20022.Seev010001.FractionDispositionType1FormatChoice
        + TempFinInstrmInd  : String
        + AddtlQtyForExstgScties  : ISO20022.Seev010001.QuantityToQuantityRatio1
        + TradgPrd  : ISO20022.Seev010001.Period1
        + PricDtls  : ISO20022.Seev010001.CorporateActionPrice4
        + DtDtls  : ISO20022.Seev010001.CorporateActionDate3
        + AddtlQtyForSbcbdRsltntScties  : ISO20022.Seev010001.QuantityToQuantityRatio1
        + ShrRnkg  : ISO20022.Seev010001.ShareRanking1FormatChoice
        + NewBrdLotSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + NewDnmtnSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + MinExrcblMltplSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + MinExrcblSctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + SctiesQty  : ISO20022.Seev010001.UnitOrFaceAmount1Choice
        + CdtDbtInd  : String
        + SctyId  : ISO20022.Seev010001.FinancialInstrumentDescription3
    }
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.FractionDispositionType1FormatChoice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.QuantityToQuantityRatio1
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.Period1
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.CorporateActionPrice4
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.CorporateActionDate3
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.QuantityToQuantityRatio1
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.ShareRanking1FormatChoice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.UnitOrFaceAmount1Choice
    ISO20022.Seev010001.SecurityOption1 *-- ISO20022.Seev010001.FinancialInstrumentDescription3
    class ISO20022.Seev010001.ShareRanking1Code {
        PARI = 1
        DIVI = 2
    }
    class ISO20022.Seev010001.ShareRanking1FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.ShareRanking1FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.TaxType3Code {
        WITL = 1
        WITF = 2
        LIDT = 3
    }
    class ISO20022.Seev010001.TaxType3FormatChoice {
        + Prtry  : ISO20022.Seev010001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev010001.TaxType3FormatChoice *-- ISO20022.Seev010001.GenericIdentification13
    class ISO20022.Seev010001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Seev010001.UnitOrFaceAmount1Choice {
        + FaceAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + Unit  : Decimal
    }
    ISO20022.Seev010001.UnitOrFaceAmount1Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
    class ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice {
        + Cd  : String
        + FaceAmt  : ISO20022.Seev010001.ActiveCurrencyAndAmount
        + Unit  : Decimal
    }
    ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice *-- ISO20022.Seev010001.ActiveCurrencyAndAmount
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

## Value ISO20022.Seev010001.AccountIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctId|String||XmlElement()||
|+|CshAcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(SctiesAcctId,CshAcctId))|

---

## Value ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev010001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev010001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Aspect ISO20022.Seev010001.AgentCANotificationCancellationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnNtfctnDtls|ISO20022.Seev010001.CorporateActionNotificationAdvice1||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev010001.CorporateActionInformation2||XmlElement()||
|+|NtfctnCxlTpAndLkg|ISO20022.Seev010001.NotificationCancellation1||XmlElement()||
|+|Id|ISO20022.Seev010001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnNtfctnDtls),validElement(CorpActnGnlInf),validElement(NtfctnCxlTpAndLkg),validElement(Id))|

---

## Value ISO20022.Seev010001.AgentRole1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.AgentRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAYA|Int32||XmlEnum("""PAYA""")|1|
||REGR|Int32||XmlEnum("""REGR""")|2|
||ISAG|Int32||XmlEnum("""ISAG""")|3|
||CODO|Int32||XmlEnum("""CODO""")|4|
||SPAY|Int32||XmlEnum("""SPAY""")|5|

---

## Value ISO20022.Seev010001.AlternateSecurityIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Seev010001.AmountAndQuantityRatio1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Seev010001.AmountAndRateFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateType12FormatChoice||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(Amt),validChoice(NotSpcfdRate,Amt))|

---

## Value ISO20022.Seev010001.AmountAndRateFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateValueType6FormatChoice||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(Amt),validChoice(NotSpcfdRate,Amt))|

---

## Value ISO20022.Seev010001.AmountPrice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|ISO20022.Seev010001.AmountPriceType1FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal),validElement(AmtPricTp))|

---

## Value ISO20022.Seev010001.AmountPricePerAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|ISO20022.Seev010001.AmountPriceType1FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal),validElement(AmtPricTp))|

---

## Value ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|PricVal|ISO20022.Seev010001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|ISO20022.Seev010001.AmountPriceType1FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal),validElement(AmtPricTp))|

---

## Enum ISO20022.Seev010001.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Value ISO20022.Seev010001.AmountPriceType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.AmountToAmountRatio1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt2|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Amt1|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt2),validElement(Amt1))|

---

## Enum ISO20022.Seev010001.BeneficiaryCertificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCOM|Int32||XmlEnum("""NCOM""")|1|
||TRBD|Int32||XmlEnum("""TRBD""")|2|
||QIBB|Int32||XmlEnum("""QIBB""")|3|
||FULL|Int32||XmlEnum("""FULL""")|4|
||DOMI|Int32||XmlEnum("""DOMI""")|5|
||ACCI|Int32||XmlEnum("""ACCI""")|6|

---

## Value ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.CashOption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRate|ISO20022.Seev010001.ForeignExchangeTerms8||XmlElement()||
|+|AmtDtls|ISO20022.Seev010001.CorporateActionAmounts1||XmlElement()||
|+|DtDtls|ISO20022.Seev010001.CorporateActionDate5||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XchgRate),validElement(AmtDtls),validElement(DtDtls),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev010001.ConversionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INTE|Int32||XmlEnum("""INTE""")|1|
||FINL|Int32||XmlEnum("""FINL""")|2|

---

## Value ISO20022.Seev010001.ConversionType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.CorporateAction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DstrbtnTp|ISO20022.Seev010001.DistributionType1FormatChoice||XmlElement()||
|+|RedChrgsApldInd|String||XmlElement()||
|+|ConvsTp|ISO20022.Seev010001.ConversionType1FormatChoice||XmlElement()||
|+|RnncblEntitlmntStsTp|ISO20022.Seev010001.RenounceableStatus1FormatChoice||XmlElement()||
|+|NewPlcOfIncorprtn|String||XmlElement()||
|+|TaxblIncmPerShrClctd|String||XmlElement()||
|+|CptlGn|String||XmlElement()||
|+|CertfctnTp|ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice||XmlElement()||
|+|CertfctnReqrdInd|String||XmlElement()||
|+|CorpActnAddtlInf|ISO20022.Seev010001.CorporateActionNarrative1||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev010001.CorporateActionRate1||XmlElement()||
|+|PrdDtls|ISO20022.Seev010001.CorporateActionPeriod1||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Seev010001.CorporateActionPrice2>||XmlElement()||
|+|DtDtls|ISO20022.Seev010001.CorporateActionDate2||XmlElement()||
|+|NewDnmtnCcy|String||XmlElement()||
|+|IntrstAcrdNbOfDays|Decimal||XmlElement()||
|+|CpnNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice||XmlElement()||
|+|DvddTp|ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice||XmlElement()||
|+|IncmTp|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|LtryTp|ISO20022.Seev010001.LotteryType1FormatChoice||XmlElement()||
|+|ElctnTp|ISO20022.Seev010001.ElectionMovementType1FormatChoice||XmlElement()||
|+|PrtlElctnInd|String||XmlElement()||
|+|RstrctnInd|String||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev010001.OfferType1FormatChoice>||XmlElement()||
|+|ChngTp|global::System.Collections.Generic.List<ISO20022.Seev010001.CorporateActionChangeType1FormatChoice>||XmlElement()||
|+|BaseDnmtn|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|SctiesQtySght|ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice||XmlElement()||
|+|NewBrdLotSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|NewDnmtnSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|IncrmtlDnmtn|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|MinExrcblMltplSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|MinExrcblSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|FrntEndOddLotSctiesQty|ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice||XmlElement()||
|+|BckEndOddLotSctiesQty|ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice||XmlElement()||
|+|ClctnMtd|ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice||XmlElement()||
|+|DfltOptnNb|String||XmlElement()||
|+|DfltOptnTp|ISO20022.Seev010001.CorporateActionOption1FormatChoice||XmlElement()||
|+|EvtStag|global::System.Collections.Generic.List<ISO20022.Seev010001.CorporateActionEventStage1FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DstrbtnTp),validElement(ConvsTp),validElement(RnncblEntitlmntStsTp),validElement(CertfctnTp),validElement(CorpActnAddtlInf),validElement(RateAndAmtDtls),validElement(PrdDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(DtDtls),validPattern("""NewDnmtnCcy""",NewDnmtnCcy,"""[A-Z]{3,3}"""),validPattern("""CpnNb""",CpnNb,"""[0-9]{1,3}"""),validElement(IntrmdtSctiesDstrbtnTp),validElement(DvddTp),validElement(IncmTp),validElement(LtryTp),validElement(ElctnTp),validList("""OfferTp""",OfferTp),validElement(OfferTp),validList("""ChngTp""",ChngTp),validElement(ChngTp),validElement(BaseDnmtn),validElement(SctiesQtySght),validElement(NewBrdLotSctiesQty),validElement(NewDnmtnSctiesQty),validElement(IncrmtlDnmtn),validElement(MinExrcblMltplSctiesQty),validElement(MinExrcblSctiesQty),validElement(FrntEndOddLotSctiesQty),validElement(BckEndOddLotSctiesQty),validElement(ClctnMtd),validPattern("""DfltOptnNb""",DfltOptnNb,"""[0-9]{3}"""),validElement(DfltOptnTp),validList("""EvtStag""",EvtStag),validElement(EvtStag))|

---

## Value ISO20022.Seev010001.CorporateActionAgent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Seev010001.NameAndAddress5||XmlElement()||
|+|AgtRole|ISO20022.Seev010001.AgentRole1FormatChoice||XmlElement()||
|+|AgtId|ISO20022.Seev010001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(AgtRole),validElement(AgtId))|

---

## Value ISO20022.Seev010001.CorporateActionAmounts1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChrgsAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|ShppgFeesAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|RgltryFeesAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|PstgFeeAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LclBrkrComssnAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|PngAgtComssnAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|FsclStmpAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgOfLclTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|WhldgOfFrgnTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxCdtAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxRclmAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CtryNtlFdrlTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|PmtLevyTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|LclTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|EURtntnTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValAddedTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TxTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TrfTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|StockXchgTaxAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrmnLclTax4Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrmnLclTax3Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrmnLclTax2Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrmnLclTax1Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxDfrrdAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxFreeAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|AddtlSbcptCost|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshIncntiv|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|EntitldAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|SpclCncssnAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|SndryOrOthrAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|UfrnkdAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|FullyFrnkdAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|MktClmAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|RinvstmtAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrncplOrCrps|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|ManfctrdDvddAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|RedPrmAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|IndmntyAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|IntrstAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CptlGn|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshInLieuOfShr|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|SlctnFees|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|IsseDscntAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|NetCshAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|GrssCshAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgsAmt),validElement(ShppgFeesAmt),validElement(RgltryFeesAmt),validElement(PstgFeeAmt),validElement(LclBrkrComssnAmt),validElement(PngAgtComssnAmt),validElement(ExctgBrkrAmt),validElement(FsclStmpAmt),validElement(WhldgTaxAmt),validElement(AddtlTaxAmt),validElement(WhldgOfLclTaxAmt),validElement(WhldgOfFrgnTaxAmt),validElement(TaxCdtAmt),validElement(TaxRclmAmt),validElement(StmpDtyAmt),validElement(CtryNtlFdrlTaxAmt),validElement(PmtLevyTaxAmt),validElement(LclTaxAmt),validElement(EURtntnTaxAmt),validElement(ValAddedTaxAmt),validElement(TxTaxAmt),validElement(TrfTaxAmt),validElement(StockXchgTaxAmt),validElement(GrmnLclTax4Amt),validElement(GrmnLclTax3Amt),validElement(GrmnLclTax2Amt),validElement(GrmnLclTax1Amt),validElement(TaxDfrrdAmt),validElement(TaxFreeAmt),validElement(AddtlSbcptCost),validElement(CshIncntiv),validElement(EntitldAmt),validElement(SpclCncssnAmt),validElement(SndryOrOthrAmt),validElement(UfrnkdAmt),validElement(FullyFrnkdAmt),validElement(MktClmAmt),validElement(RinvstmtAmt),validElement(PrncplOrCrps),validElement(ManfctrdDvddAmt),validElement(RedPrmAmt),validElement(IndmntyAmt),validElement(IntrstAmt),validElement(CptlGn),validElement(OrgnlAmt),validElement(CshInLieuOfShr),validElement(SlctnFees),validElement(IsseDscntAmt),validElement(NetCshAmt),validElement(GrssCshAmt))|

---

## Enum ISO20022.Seev010001.CorporateActionCalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NNOM|Int32||XmlEnum("""NNOM""")|1|
||NOMI|Int32||XmlEnum("""NOMI""")|2|
||LOTT|Int32||XmlEnum("""LOTT""")|3|
||PROR|Int32||XmlEnum("""PROR""")|4|

---

## Value ISO20022.Seev010001.CorporateActionCalculationMethod1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionChangeType1Code


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

## Value ISO20022.Seev010001.CorporateActionChangeType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.CorporateActionDate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SpclExDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|ElctnToCtrPtyDdln|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|GrntedPrtcptnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|LpsdDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|DdlnForTaxBrkdwnInstr|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PrratnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|RegnDdln|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|RedDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CertfctnDdln|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|TradgSspdDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|MtrtyDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|IndxFxgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|ExDvddDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|EarlyClsgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CrtApprvlDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|RsltsPblctnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|WhlyUcondlDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|UcondlDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PrtctDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|LtryDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|MrgnFxgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|EqulstnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CoverXprtnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|FctvDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SpclExDt),validElement(ElctnToCtrPtyDdln),validElement(GrntedPrtcptnDt),validElement(LpsdDt),validElement(DdlnForTaxBrkdwnInstr),validElement(PrratnDt),validElement(RegnDdln),validElement(RedDt),validElement(CertfctnDdln),validElement(TradgSspdDt),validElement(MtrtyDt),validElement(IndxFxgDt),validElement(ExDvddDt),validElement(EarlyClsgDt),validElement(CrtApprvlDt),validElement(RsltsPblctnDt),validElement(WhlyUcondlDt),validElement(UcondlDt),validElement(PrtctDt),validElement(LtryDt),validElement(MrgnFxgDt),validElement(EqulstnDt),validElement(CoverXprtnDt),validElement(FctvDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev010001.CorporateActionDate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarlstPmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|FrstDealgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PrpssDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|DvddRnkgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|AvlblDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarlstPmtDt),validElement(FrstDealgDt),validElement(PrpssDt),validElement(DvddRnkgDt),validElement(AvlblDt),validElement(PmtDt))|

---

## Value ISO20022.Seev010001.CorporateActionDate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbcptCostDbtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|QtnSetngDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|XpryDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|DdlnToSplt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|RspnDdln|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|MktDdln|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|EarlstPmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CnsntRcrdDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CnsntXprtnDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|CpnClpngDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SbcptCostDbtDt),validElement(QtnSetngDt),validElement(XpryDt),validElement(DdlnToSplt),validElement(RspnDdln),validElement(MktDdln),validElement(EarlstPmtDt),validElement(PmtDt),validElement(CnsntRcrdDt),validElement(CnsntXprtnDt),validElement(CpnClpngDt))|

---

## Value ISO20022.Seev010001.CorporateActionDate5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarlstPmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|PmtDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|ValDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|FXRateFxgDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarlstPmtDt),validElement(PmtDt),validElement(ValDt),validElement(FXRateFxgDt))|

---

## Enum ISO20022.Seev010001.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionEventStage1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||LAPS|Int32||XmlEnum("""LAPS""")|3|
||FULL|Int32||XmlEnum("""FULL""")|4|
||WHOU|Int32||XmlEnum("""WHOU""")|5|
||UNAC|Int32||XmlEnum("""UNAC""")|6|
||SUAP|Int32||XmlEnum("""SUAP""")|7|
||PWAL|Int32||XmlEnum("""PWAL""")|8|
||CLDE|Int32||XmlEnum("""CLDE""")|9|
||APPD|Int32||XmlEnum("""APPD""")|10|

---

## Value ISO20022.Seev010001.CorporateActionEventStage1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionEventStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INAC|Int32||XmlEnum("""INAC""")|1|
||CANC|Int32||XmlEnum("""CANC""")|2|
||ACTI|Int32||XmlEnum("""ACTI""")|3|

---

## Value ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionEventType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WTRC|Int32||XmlEnum("""WTRC""")|2|
||WRTH|Int32||XmlEnum("""WRTH""")|3|
||TREC|Int32||XmlEnum("""TREC""")|4|
||TEND|Int32||XmlEnum("""TEND""")|5|
||SUSP|Int32||XmlEnum("""SUSP""")|6|
||SPLR|Int32||XmlEnum("""SPLR""")|7|
||SPLF|Int32||XmlEnum("""SPLF""")|8|
||SOFF|Int32||XmlEnum("""SOFF""")|9|
||SMAL|Int32||XmlEnum("""SMAL""")|10|
||SHPR|Int32||XmlEnum("""SHPR""")|11|
||RHTS|Int32||XmlEnum("""RHTS""")|12|
||RHDI|Int32||XmlEnum("""RHDI""")|13|
||REMK|Int32||XmlEnum("""REMK""")|14|
||REDO|Int32||XmlEnum("""REDO""")|15|
||REDM|Int32||XmlEnum("""REDM""")|16|
||PRIO|Int32||XmlEnum("""PRIO""")|17|
||PRII|Int32||XmlEnum("""PRII""")|18|
||PRED|Int32||XmlEnum("""PRED""")|19|
||PPMT|Int32||XmlEnum("""PPMT""")|20|
||PLAC|Int32||XmlEnum("""PLAC""")|21|
||PINK|Int32||XmlEnum("""PINK""")|22|
||PDEF|Int32||XmlEnum("""PDEF""")|23|
||PCAL|Int32||XmlEnum("""PCAL""")|24|
||PARI|Int32||XmlEnum("""PARI""")|25|
||ODLT|Int32||XmlEnum("""ODLT""")|26|
||MRGR|Int32||XmlEnum("""MRGR""")|27|
||MCAL|Int32||XmlEnum("""MCAL""")|28|
||LIQU|Int32||XmlEnum("""LIQU""")|29|
||INTR|Int32||XmlEnum("""INTR""")|30|
||INCR|Int32||XmlEnum("""INCR""")|31|
||EXWA|Int32||XmlEnum("""EXWA""")|32|
||EXTM|Int32||XmlEnum("""EXTM""")|33|
||EXRI|Int32||XmlEnum("""EXRI""")|34|
||EXOF|Int32||XmlEnum("""EXOF""")|35|
||DVSE|Int32||XmlEnum("""DVSE""")|36|
||DVSC|Int32||XmlEnum("""DVSC""")|37|
||DVOP|Int32||XmlEnum("""DVOP""")|38|
||DVCA|Int32||XmlEnum("""DVCA""")|39|
||DTCH|Int32||XmlEnum("""DTCH""")|40|
||DSCL|Int32||XmlEnum("""DSCL""")|41|
||DRIP|Int32||XmlEnum("""DRIP""")|42|
||DRAW|Int32||XmlEnum("""DRAW""")|43|
||DLST|Int32||XmlEnum("""DLST""")|44|
||DFLT|Int32||XmlEnum("""DFLT""")|45|
||DETI|Int32||XmlEnum("""DETI""")|46|
||DECR|Int32||XmlEnum("""DECR""")|47|
||COOP|Int32||XmlEnum("""COOP""")|48|
||CONV|Int32||XmlEnum("""CONV""")|49|
||CONS|Int32||XmlEnum("""CONS""")|50|
||CLSA|Int32||XmlEnum("""CLSA""")|51|
||CHAN|Int32||XmlEnum("""CHAN""")|52|
||CERT|Int32||XmlEnum("""CERT""")|53|
||CAPI|Int32||XmlEnum("""CAPI""")|54|
||CAPG|Int32||XmlEnum("""CAPG""")|55|
||BRUP|Int32||XmlEnum("""BRUP""")|56|
||BPUT|Int32||XmlEnum("""BPUT""")|57|
||BONU|Int32||XmlEnum("""BONU""")|58|
||BIDS|Int32||XmlEnum("""BIDS""")|59|
||ATTI|Int32||XmlEnum("""ATTI""")|60|
||ACTV|Int32||XmlEnum("""ACTV""")|61|

---

## Value ISO20022.Seev010001.CorporateActionEventType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionFrequencyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPEC|Int32||XmlEnum("""SPEC""")|1|
||REGR|Int32||XmlEnum("""REGR""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|
||FINL|Int32||XmlEnum("""FINL""")|4|

---

## Value ISO20022.Seev010001.CorporateActionFrequencyType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.CorporateActionInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrUndrlygScty|global::System.Collections.Generic.List<ISO20022.Seev010001.FinancialInstrumentDescription3>||XmlElement()||
|+|UndrlygScty|ISO20022.Seev010001.FinancialInstrumentDescription3||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev010001.CorporateActionEventProcessingType1FormatChoice||XmlElement()||
|+|EvtTp|ISO20022.Seev010001.CorporateActionEventType2FormatChoice||XmlElement()||
|+|CorpActnPrcgId|String||XmlElement()||
|+|IssrCorpActnId|String||XmlElement()||
|+|AgtId|ISO20022.Seev010001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrUndrlygScty""",OthrUndrlygScty),validElement(OthrUndrlygScty),validElement(UndrlygScty),validElement(MndtryVlntryEvtTp),validElement(EvtPrcgTp),validElement(EvtTp),validElement(AgtId))|

---

## Enum ISO20022.Seev010001.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev010001.CorporateActionMandatoryVoluntary1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.CorporateActionNarrative1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlTxt|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|Offerr|ISO20022.Seev010001.PartyIdentification2Choice||XmlElement()||
|+|NewCpnyNm|String||XmlElement()||
|+|TaxtnConds|String||XmlElement()||
|+|InfToCmplyWth|String||XmlElement()||
|+|InfConds|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Offerr))|

---

## Value ISO20022.Seev010001.CorporateActionNotificationAdvice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnOptnDtls|global::System.Collections.Generic.List<ISO20022.Seev010001.CorporateActionOption1>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev010001.CorporateAction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CorpActnOptnDtls""",CorpActnOptnDtls),validElement(CorpActnOptnDtls),validElement(CorpActnDtls))|

---

## Enum ISO20022.Seev010001.CorporateActionNotificationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||WITH|Int32||XmlEnum("""WITH""")|2|

---

## Value ISO20022.Seev010001.CorporateActionOption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnAddtlInf|ISO20022.Seev010001.CorporateActionNarrative1||XmlElement()||
|+|OptnFeatrs|global::System.Collections.Generic.List<ISO20022.Seev010001.OptionFeatures1FormatChoice>||XmlElement()||
|+|RedChrgsApldInd|String||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev010001.FractionDispositionType1FormatChoice||XmlElement()||
|+|CorpActnOthrAgtDtls|global::System.Collections.Generic.List<ISO20022.Seev010001.CorporateActionAgent1>||XmlElement()||
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev010001.CashOption1>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev010001.SecurityOption1>||XmlElement()||
|+|PrdDtls|ISO20022.Seev010001.CorporateActionPeriod2||XmlElement()||
|+|PricDtls|ISO20022.Seev010001.CorporateActionPrice1||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev010001.CorporateActionRate2||XmlElement()||
|+|DtDtls|ISO20022.Seev010001.CorporateActionDate4||XmlElement()||
|+|ChngAllwdInd|String||XmlElement()||
|+|WdrwlAllwdInd|String||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice||XmlElement()||
|+|OfferTp|global::System.Collections.Generic.List<ISO20022.Seev010001.OfferType1FormatChoice>||XmlElement()||
|+|AgtCshAcctId|ISO20022.Seev010001.AccountIdentification2Choice||XmlElement()||
|+|AgtSctiesAcctId|String||XmlElement()||
|+|AssntdLineSctyId|ISO20022.Seev010001.SecurityIdentification7||XmlElement()||
|+|CertfctnTp|ISO20022.Seev010001.BeneficiaryCertificationType1FormatChoice||XmlElement()||
|+|CertfctnInd|String||XmlElement()||
|+|OptnAvlbtySts|ISO20022.Seev010001.CorporateActionEventStatus2FormatChoice||XmlElement()||
|+|OptnTp|ISO20022.Seev010001.CorporateActionOption1FormatChoice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnAddtlInf),validList("""OptnFeatrs""",OptnFeatrs),validElement(OptnFeatrs),validElement(FrctnDspstn),validList("""CorpActnOthrAgtDtls""",CorpActnOthrAgtDtls),validElement(CorpActnOthrAgtDtls),validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(PrdDtls),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(DtDtls),validElement(IntrmdtSctiesDstrbtnTp),validList("""OfferTp""",OfferTp),validElement(OfferTp),validElement(AgtCshAcctId),validElement(AssntdLineSctyId),validElement(CertfctnTp),validElement(OptnAvlbtySts),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev010001.CorporateActionOption1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.CorporateActionOptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QINV|Int32||XmlEnum("""QINV""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NOQU|Int32||XmlEnum("""NOQU""")|3|
||SPLI|Int32||XmlEnum("""SPLI""")|4|
||SLLE|Int32||XmlEnum("""SLLE""")|5|
||SECU|Int32||XmlEnum("""SECU""")|6|
||OVER|Int32||XmlEnum("""OVER""")|7|
||OFFR|Int32||XmlEnum("""OFFR""")|8|
||NOAC|Int32||XmlEnum("""NOAC""")|9|
||MPUT|Int32||XmlEnum("""MPUT""")|10|
||LAPS|Int32||XmlEnum("""LAPS""")|11|
||EXER|Int32||XmlEnum("""EXER""")|12|
||CONY|Int32||XmlEnum("""CONY""")|13|
||CONN|Int32||XmlEnum("""CONN""")|14|
||CTEN|Int32||XmlEnum("""CTEN""")|15|
||CEXC|Int32||XmlEnum("""CEXC""")|16|
||CASH|Int32||XmlEnum("""CASH""")|17|
||CASE|Int32||XmlEnum("""CASE""")|18|
||BUYA|Int32||XmlEnum("""BUYA""")|19|
||BSPL|Int32||XmlEnum("""BSPL""")|20|

---

## Value ISO20022.Seev010001.CorporateActionPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricClctnPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|BlckgPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|IntrstPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|CmplsryPurchsPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|ActnPrd|ISO20022.Seev010001.Period1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricClctnPrd),validElement(BlckgPrd),validElement(IntrstPrd),validElement(CmplsryPurchsPrd),validElement(ActnPrd))|

---

## Value ISO20022.Seev010001.CorporateActionPeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricClctnPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|RvcbltyPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|SellThruIssrPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|ParllTradgPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|PrvlgSspnsnPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|ActnPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|AssntdLinePrd|ISO20022.Seev010001.Period1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricClctnPrd),validElement(RvcbltyPrd),validElement(SellThruIssrPrd),validElement(ParllTradgPrd),validElement(PrvlgSspnsnPrd),validElement(ActnPrd),validElement(AssntdLinePrd))|

---

## Value ISO20022.Seev010001.CorporateActionPrice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OverSbcptDpstPric|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
|+|GncCshPricPdPerPdct|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev010001.PriceFormat1Choice||XmlElement()||
|+|TaxblIncmPerDvddShr|ISO20022.Seev010001.AmountPrice1||XmlElement()||
|+|CshInLieuOfShrPric|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
|+|IssePric|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
|+|ExrcPric|ISO20022.Seev010001.PriceFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OverSbcptDpstPric),validElement(GncCshPricPdPerPdct),validElement(GncCshPricRcvdPerPdct),validElement(TaxblIncmPerDvddShr),validElement(CshInLieuOfShrPric),validElement(IssePric),validElement(ExrcPric))|

---

## Value ISO20022.Seev010001.CorporateActionPrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MinPric|ISO20022.Seev010001.PriceFormat3Choice||XmlElement()||
|+|MaxPric|ISO20022.Seev010001.PriceFormat3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MinPric),validElement(MaxPric))|

---

## Value ISO20022.Seev010001.CorporateActionPrice4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev010001.PriceFormat2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric))|

---

## Value ISO20022.Seev010001.CorporateActionRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrgs|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|BidIntrvl|ISO20022.Seev010001.AmountAndRateFormat3Choice||XmlElement()||
|+|Sprd|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|RinvstmtDscntToMkt|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|PctgSght|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|RltdIndx|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|Intrst|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Chrgs),validElement(BidIntrvl),validElement(Sprd),validElement(RinvstmtDscntToMkt),validElement(PctgSght),validElement(RltdIndx),validElement(Intrst))|

---

## Value ISO20022.Seev010001.CorporateActionRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AplblRate|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|XchgRate|ISO20022.Seev010001.ForeignExchangeTerms8||XmlElement()||
|+|OrgnlAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|AddtlTax|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|MaxAllwdOvrsbcpt|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|SlctnFee|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|CshIncntiv|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|PrvsnlDvdd|ISO20022.Seev010001.AmountAndRateFormat2Choice||XmlElement()||
|+|FnlDvdd|ISO20022.Seev010001.AmountAndRateFormat2Choice||XmlElement()||
|+|NetDvdd|ISO20022.Seev010001.NetDividendRate1Choice||XmlElement()||
|+|GrssDvdd|ISO20022.Seev010001.GrossDividendRate1Choice||XmlElement()||
|+|FullyFrnkd|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|IndxFctr|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|IntrstForUsdPmt|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|Chrgs|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|NonResdtRate|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|RltdTax|ISO20022.Seev010001.RelatedTaxType1||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev010001.RatioFormat1Choice||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev010001.RatioFormat1Choice||XmlElement()||
|+|NewSctiesToUndrlygScties|ISO20022.Seev010001.RatioFormat2Choice||XmlElement()||
|+|NewToOd|ISO20022.Seev010001.RatioFormat2Choice||XmlElement()||
|+|Prratn|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|FsclStmp|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|TaxRclm|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|TaxOnPrft|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|TaxOnIncm|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
|+|GrmnLclTax4|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|GrmnLclTax3|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|GrmnLclTax2|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|GrmnLclTax1|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|WhldgOfLclTax|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|WhldgOfFrgnTax|ISO20022.Seev010001.RateAndAmountFormat1Choice||XmlElement()||
|+|WhldgTax|ISO20022.Seev010001.RateFormat1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AplblRate),validElement(XchgRate),validElement(OrgnlAmt),validElement(AddtlTax),validElement(MaxAllwdOvrsbcpt),validElement(SlctnFee),validElement(CshIncntiv),validElement(PrvsnlDvdd),validElement(FnlDvdd),validElement(NetDvdd),validElement(GrssDvdd),validElement(FullyFrnkd),validElement(IndxFctr),validElement(IntrstForUsdPmt),validElement(Chrgs),validElement(NonResdtRate),validElement(RltdTax),validElement(AddtlQtyForSbcbdRsltntScties),validElement(AddtlQtyForExstgScties),validElement(NewSctiesToUndrlygScties),validElement(NewToOd),validElement(Prratn),validElement(FsclStmp),validElement(TaxRclm),validElement(TaxOnPrft),validElement(TaxOnIncm),validElement(GrmnLclTax4),validElement(GrmnLclTax3),validElement(GrmnLclTax2),validElement(GrmnLclTax1),validElement(WhldgOfLclTax),validElement(WhldgOfFrgnTax),validElement(WhldgTax))|

---

## Enum ISO20022.Seev010001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev010001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev010001.DateFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Seev010001.DateAndDateTimeChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Dt),validChoice(Prtry,NotSpcfdDt,Dt))|

---

## Enum ISO20022.Seev010001.DateType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|

---

## Enum ISO20022.Seev010001.DistributionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ROLL|Int32||XmlEnum("""ROLL""")|1|

---

## Value ISO20022.Seev010001.DistributionType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtCANtfctnCxlReq|ISO20022.Seev010001.AgentCANotificationCancellationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCANtfctnCxlReq))|

---

## Value ISO20022.Seev010001.DocumentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev010001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Enum ISO20022.Seev010001.ElectionMovementType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRCT|Int32||XmlEnum("""DRCT""")|1|
||REST|Int32||XmlEnum("""REST""")|2|

---

## Value ISO20022.Seev010001.ElectionMovementType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.FinancialInstrumentDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev010001.PartyIdentification2Choice||XmlElement()||
|+|PlcOfListg|String||XmlElement()||
|+|SctyId|ISO20022.Seev010001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(SctyId))|

---

## Value ISO20022.Seev010001.ForeignExchangeTerms8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev010001.FractionDispositionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STAN|Int32||XmlEnum("""STAN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|
||RDDN|Int32||XmlEnum("""RDDN""")|3|
||DIST|Int32||XmlEnum("""DIST""")|4|
||CINL|Int32||XmlEnum("""CINL""")|5|
||BUYU|Int32||XmlEnum("""BUYU""")|6|

---

## Value ISO20022.Seev010001.FractionDispositionType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev010001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev010001.GrossDividendRate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAmt|ISO20022.Seev010001.GrossDividendRate2||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|NotSpcfdRate|ISO20022.Seev010001.RateValueType2FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAmt),validElement(Amt),validElement(NotSpcfdRate),validChoice(RateTpAmt,Amt,NotSpcfdRate))|

---

## Value ISO20022.Seev010001.GrossDividendRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|RateTp|ISO20022.Seev010001.GrossDividendRateType1FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(RateTp))|

---

## Enum ISO20022.Seev010001.GrossDividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STCG|Int32||XmlEnum("""STCG""")|1|
||LTCG|Int32||XmlEnum("""LTCG""")|2|
||UNFR|Int32||XmlEnum("""UNFR""")|3|
||TXFR|Int32||XmlEnum("""TXFR""")|4|
||TXDF|Int32||XmlEnum("""TXDF""")|5|
||TXBL|Int32||XmlEnum("""TXBL""")|6|
||SOIC|Int32||XmlEnum("""SOIC""")|7|
||INTR|Int32||XmlEnum("""INTR""")|8|
||INCO|Int32||XmlEnum("""INCO""")|9|
||FLFR|Int32||XmlEnum("""FLFR""")|10|
||CAPO|Int32||XmlEnum("""CAPO""")|11|

---

## Value ISO20022.Seev010001.GrossDividendRateType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.IntermediateSecurityDistributionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFF|Int32||XmlEnum("""SOFF""")|1|
||LIQU|Int32||XmlEnum("""LIQU""")|2|
||INTR|Int32||XmlEnum("""INTR""")|3|
||DVSE|Int32||XmlEnum("""DVSE""")|4|
||DVSC|Int32||XmlEnum("""DVSC""")|5|
||PRIO|Int32||XmlEnum("""PRIO""")|6|
||EXRI|Int32||XmlEnum("""EXRI""")|7|
||DVOP|Int32||XmlEnum("""DVOP""")|8|
||DVCA|Int32||XmlEnum("""DVCA""")|9|
||DRIP|Int32||XmlEnum("""DRIP""")|10|
||BONU|Int32||XmlEnum("""BONU""")|11|
||BIDS|Int32||XmlEnum("""BIDS""")|12|

---

## Value ISO20022.Seev010001.IntermediateSecurityDistributionType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev010001.LotteryType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev010001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev010001.NetDividendRate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAmt|ISO20022.Seev010001.NetDividendRate2||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|NotSpcfdRate|ISO20022.Seev010001.RateValueType6FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAmt),validElement(Amt),validElement(NotSpcfdRate),validChoice(RateTpAmt,Amt,NotSpcfdRate))|

---

## Value ISO20022.Seev010001.NetDividendRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|RateTp|ISO20022.Seev010001.NetDividendRateType1FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(RateTp))|

---

## Enum ISO20022.Seev010001.NetDividendRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNFR|Int32||XmlEnum("""UNFR""")|1|
||TXFR|Int32||XmlEnum("""TXFR""")|2|
||TXDF|Int32||XmlEnum("""TXDF""")|3|
||TXBL|Int32||XmlEnum("""TXBL""")|4|
||SOIC|Int32||XmlEnum("""SOIC""")|5|
||INTR|Int32||XmlEnum("""INTR""")|6|
||INCO|Int32||XmlEnum("""INCO""")|7|
||FLFR|Int32||XmlEnum("""FLFR""")|8|
||CAPO|Int32||XmlEnum("""CAPO""")|9|

---

## Value ISO20022.Seev010001.NetDividendRateType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.NotificationCancellation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdAgtCANtfctnAdvcId|ISO20022.Seev010001.DocumentIdentification8||XmlElement()||
|+|NtfctnCxlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkdAgtCANtfctnAdvcId))|

---

## Enum ISO20022.Seev010001.OfferType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SQUE|Int32||XmlEnum("""SQUE""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||MINI|Int32||XmlEnum("""MINI""")|3|
||FINL|Int32||XmlEnum("""FINL""")|4|
||FCFS|Int32||XmlEnum("""FCFS""")|5|
||ERUN|Int32||XmlEnum("""ERUN""")|6|
||DISS|Int32||XmlEnum("""DISS""")|7|

---

## Value ISO20022.Seev010001.OfferType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.OptionFeatures1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VVPR|Int32||XmlEnum("""VVPR""")|1|
||QREC|Int32||XmlEnum("""QREC""")|2|
||QOVE|Int32||XmlEnum("""QOVE""")|3|
||PROR|Int32||XmlEnum("""PROR""")|4|
||OPLF|Int32||XmlEnum("""OPLF""")|5|
||MAXS|Int32||XmlEnum("""MAXS""")|6|
||MAXC|Int32||XmlEnum("""MAXC""")|7|
||COND|Int32||XmlEnum("""COND""")|8|

---

## Value ISO20022.Seev010001.OptionFeatures1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev010001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev010001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Seev010001.Period1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
|+|StartDt|ISO20022.Seev010001.DateFormat4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Value ISO20022.Seev010001.PostalAddress1


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

## Value ISO20022.Seev010001.PriceFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfd|ISO20022.Seev010001.PriceValueType6FormatChoice||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev010001.AmountPricePerAmount1||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev010001.AmountPricePerFinancialInstrumentQuantity1||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Seev010001.AmountPrice1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfd),validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(Amt),validChoice(NotSpcfd,AmtPricPerAmt,AmtPricPerFinInstrmQty,Rate,Amt))|

---

## Value ISO20022.Seev010001.PriceFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfd|ISO20022.Seev010001.PriceValueType5FormatChoice||XmlElement()||
|+|Rate|ISO20022.Seev010001.PriceRate1||XmlElement()||
|+|Amt|ISO20022.Seev010001.AmountPrice1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfd),validElement(Rate),validElement(Amt),validChoice(NotSpcfd,Rate,Amt))|

---

## Value ISO20022.Seev010001.PriceFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|ISO20022.Seev010001.PriceRate1||XmlElement()||
|+|Amt|ISO20022.Seev010001.AmountPrice1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rate),validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Seev010001.PriceFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|NotSpcfd|ISO20022.Seev010001.PriceValueType5FormatChoice||XmlElement()||
|+|Rate|ISO20022.Seev010001.PriceRate1||XmlElement()||
|+|Amt|ISO20022.Seev010001.AmountPrice1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfd),validElement(Rate),validElement(Amt),validChoice(IndxPts,NotSpcfd,Rate,Amt))|

---

## Value ISO20022.Seev010001.PriceRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev010001.PriceRateType3FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev010001.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Value ISO20022.Seev010001.PriceRateType3FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.PriceValueType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev010001.PriceValueType5FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.PriceValueType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TBSP|Int32||XmlEnum("""TBSP""")|1|
||UNSP|Int32||XmlEnum("""UNSP""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|
||UKWN|Int32||XmlEnum("""UKWN""")|4|

---

## Value ISO20022.Seev010001.PriceValueType6FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.Quantity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QALL|Int32||XmlEnum("""QALL""")|1|

---

## Value ISO20022.Seev010001.QuantityToQuantityRatio1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty2|Decimal||XmlElement()||
|+|Qty1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev010001.RateAndAmountFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateType12FormatChoice||XmlElement()||
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(Amt),validChoice(NotSpcfdRate,Amt,Rate))|

---

## Value ISO20022.Seev010001.RateFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateType12FormatChoice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validChoice(NotSpcfdRate,Rate))|

---

## Enum ISO20022.Seev010001.RateType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|

---

## Value ISO20022.Seev010001.RateType12FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.RateValueType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|
||UKWN|Int32||XmlEnum("""UKWN""")|3|

---

## Value ISO20022.Seev010001.RateValueType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.RateValueType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev010001.RateValueType6FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.RatioFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateType12FormatChoice||XmlElement()||
|+|AmtToAmt|ISO20022.Seev010001.AmountToAmountRatio1||XmlElement()||
|+|QtyToQty|ISO20022.Seev010001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(AmtToAmt),validElement(QtyToQty),validChoice(NotSpcfdRate,AmtToAmt,QtyToQty))|

---

## Value ISO20022.Seev010001.RatioFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Seev010001.RateType12FormatChoice||XmlElement()||
|+|QtyToAmt|ISO20022.Seev010001.AmountAndQuantityRatio1||XmlElement()||
|+|AmtToQty|ISO20022.Seev010001.AmountAndQuantityRatio1||XmlElement()||
|+|AmtToAmt|ISO20022.Seev010001.AmountToAmountRatio1||XmlElement()||
|+|QtyToQty|ISO20022.Seev010001.QuantityToQuantityRatio1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(QtyToAmt),validElement(AmtToQty),validElement(AmtToAmt),validElement(QtyToQty),validChoice(NotSpcfdRate,QtyToAmt,AmtToQty,AmtToAmt,QtyToQty))|

---

## Value ISO20022.Seev010001.RelatedTaxType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxTp|ISO20022.Seev010001.TaxType3FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(TaxTp))|

---

## Enum ISO20022.Seev010001.RenounceableStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RENO|Int32||XmlEnum("""RENO""")|1|
||NREN|Int32||XmlEnum("""NREN""")|2|

---

## Value ISO20022.Seev010001.RenounceableStatus1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev010001.SecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|ISO20022.Seev010001.AlternateSecurityIdentification3||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(Desc,OthrId,ISIN))|

---

## Value ISO20022.Seev010001.SecurityOption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrctnDspstn|ISO20022.Seev010001.FractionDispositionType1FormatChoice||XmlElement()||
|+|TempFinInstrmInd|String||XmlElement()||
|+|AddtlQtyForExstgScties|ISO20022.Seev010001.QuantityToQuantityRatio1||XmlElement()||
|+|TradgPrd|ISO20022.Seev010001.Period1||XmlElement()||
|+|PricDtls|ISO20022.Seev010001.CorporateActionPrice4||XmlElement()||
|+|DtDtls|ISO20022.Seev010001.CorporateActionDate3||XmlElement()||
|+|AddtlQtyForSbcbdRsltntScties|ISO20022.Seev010001.QuantityToQuantityRatio1||XmlElement()||
|+|ShrRnkg|ISO20022.Seev010001.ShareRanking1FormatChoice||XmlElement()||
|+|NewBrdLotSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|NewDnmtnSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|MinExrcblMltplSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|MinExrcblSctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|SctiesQty|ISO20022.Seev010001.UnitOrFaceAmount1Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|SctyId|ISO20022.Seev010001.FinancialInstrumentDescription3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrctnDspstn),validElement(AddtlQtyForExstgScties),validElement(TradgPrd),validElement(PricDtls),validElement(DtDtls),validElement(AddtlQtyForSbcbdRsltntScties),validElement(ShrRnkg),validElement(NewBrdLotSctiesQty),validElement(NewDnmtnSctiesQty),validElement(MinExrcblMltplSctiesQty),validElement(MinExrcblSctiesQty),validElement(SctiesQty),validElement(SctyId))|

---

## Enum ISO20022.Seev010001.ShareRanking1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARI|Int32||XmlEnum("""PARI""")|1|
||DIVI|Int32||XmlEnum("""DIVI""")|2|

---

## Value ISO20022.Seev010001.ShareRanking1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.TaxType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WITL|Int32||XmlEnum("""WITL""")|1|
||WITF|Int32||XmlEnum("""WITF""")|2|
||LIDT|Int32||XmlEnum("""LIDT""")|3|

---

## Value ISO20022.Seev010001.TaxType3FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev010001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev010001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Value ISO20022.Seev010001.UnitOrFaceAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaceAmt),validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Seev010001.UnitOrFaceAmountOrCode1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|FaceAmt|ISO20022.Seev010001.ActiveCurrencyAndAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaceAmt),validChoice(Cd,FaceAmt,Unit))|

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

