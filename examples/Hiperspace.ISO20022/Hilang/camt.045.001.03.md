# camt.045.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt045001.AccountIdentification1 {
        + Prtry  : ISO20022.Camt045001.SimpleIdentificationInformation
    }
    ISO20022.Camt045001.AccountIdentification1 *-- ISO20022.Camt045001.SimpleIdentificationInformation
    class ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt045001.AdditionalParameters1 {
        + GeoArea  : String
        + Ccy  : String
        + Ctry  : String
    }
    class ISO20022.Camt045001.AdditionalReference3 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Camt045001.PartyIdentification2Choice
        + Ref  : String
    }
    ISO20022.Camt045001.AdditionalReference3 *-- ISO20022.Camt045001.PartyIdentification2Choice
    class ISO20022.Camt045001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt045001.AlternateSecurityIdentification1 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Camt045001.AmountOrRate3Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Camt045001.AmountOrRate3Choice *-- ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Camt045001.BreakdownByCountry2 {
        + NetCshFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.NetCashForecast4~
        + CshOutFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashOutForecast5~
        + CshInFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashInForecast5~
        + Ctry  : String
    }
    ISO20022.Camt045001.BreakdownByCountry2 *-- ISO20022.Camt045001.NetCashForecast4
    ISO20022.Camt045001.BreakdownByCountry2 *-- ISO20022.Camt045001.CashOutForecast5
    ISO20022.Camt045001.BreakdownByCountry2 *-- ISO20022.Camt045001.CashInForecast5
    class ISO20022.Camt045001.BreakdownByCurrency2 {
        + NetCshFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.NetCashForecast4~
        + CshInFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashInForecast5~
        + CshOutFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashOutForecast5~
        + Ccy  : String
    }
    ISO20022.Camt045001.BreakdownByCurrency2 *-- ISO20022.Camt045001.NetCashForecast4
    ISO20022.Camt045001.BreakdownByCurrency2 *-- ISO20022.Camt045001.CashInForecast5
    ISO20022.Camt045001.BreakdownByCurrency2 *-- ISO20022.Camt045001.CashOutForecast5
    class ISO20022.Camt045001.BreakdownByParty3 {
        + NetCshFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.NetCashForecast4~
        + CshOutFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashOutForecast5~
        + CshInFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashInForecast5~
        + AddtlParams  : ISO20022.Camt045001.AdditionalParameters1
        + Pty  : ISO20022.Camt045001.InvestmentAccount42
    }
    ISO20022.Camt045001.BreakdownByParty3 *-- ISO20022.Camt045001.NetCashForecast4
    ISO20022.Camt045001.BreakdownByParty3 *-- ISO20022.Camt045001.CashOutForecast5
    ISO20022.Camt045001.BreakdownByParty3 *-- ISO20022.Camt045001.CashInForecast5
    ISO20022.Camt045001.BreakdownByParty3 *-- ISO20022.Camt045001.AdditionalParameters1
    ISO20022.Camt045001.BreakdownByParty3 *-- ISO20022.Camt045001.InvestmentAccount42
    class ISO20022.Camt045001.BreakdownByUserDefinedParameter3 {
        + NetCshFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.NetCashForecast4~
        + CshOutFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashOutForecast5~
        + CshInFcst  : global::System.Collections.Generic.List~ISO20022.Camt045001.CashInForecast5~
        + UsrDfnd  : ISO20022.Camt045001.DataFormat2Choice
        + Ccy  : String
        + Ctry  : String
        + Pty  : ISO20022.Camt045001.InvestmentAccount42
    }
    ISO20022.Camt045001.BreakdownByUserDefinedParameter3 *-- ISO20022.Camt045001.NetCashForecast4
    ISO20022.Camt045001.BreakdownByUserDefinedParameter3 *-- ISO20022.Camt045001.CashOutForecast5
    ISO20022.Camt045001.BreakdownByUserDefinedParameter3 *-- ISO20022.Camt045001.CashInForecast5
    ISO20022.Camt045001.BreakdownByUserDefinedParameter3 *-- ISO20022.Camt045001.DataFormat2Choice
    ISO20022.Camt045001.BreakdownByUserDefinedParameter3 *-- ISO20022.Camt045001.InvestmentAccount42
    class ISO20022.Camt045001.CashInForecast5 {
        + AddtlBal  : ISO20022.Camt045001.FundBalance1
        + CshInBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.FundCashInBreakdown3~
        + XcptnlCshFlowInd  : String
        + SubTtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + SubTtlAmt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + CshSttlmDt  : DateTime
    }
    ISO20022.Camt045001.CashInForecast5 *-- ISO20022.Camt045001.FundBalance1
    ISO20022.Camt045001.CashInForecast5 *-- ISO20022.Camt045001.FundCashInBreakdown3
    ISO20022.Camt045001.CashInForecast5 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.CashInForecast5 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.CashOutForecast5 {
        + AddtlBal  : ISO20022.Camt045001.FundBalance1
        + CshOutBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.FundCashOutBreakdown3~
        + XcptnlCshFlowInd  : String
        + SubTtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + SubTtlAmt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + CshSttlmDt  : DateTime
    }
    ISO20022.Camt045001.CashOutForecast5 *-- ISO20022.Camt045001.FundBalance1
    ISO20022.Camt045001.CashOutForecast5 *-- ISO20022.Camt045001.FundCashOutBreakdown3
    ISO20022.Camt045001.CashOutForecast5 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.CashOutForecast5 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.Charge26 {
        + ChrgApld  : ISO20022.Camt045001.AmountOrRate3Choice
        + Tp  : ISO20022.Camt045001.ChargeType4Choice
    }
    ISO20022.Camt045001.Charge26 *-- ISO20022.Camt045001.AmountOrRate3Choice
    ISO20022.Camt045001.Charge26 *-- ISO20022.Camt045001.ChargeType4Choice
    class ISO20022.Camt045001.ChargeType12Code {
        TRAN = 1
        SPCN = 2
        SHIP = 3
        REGF = 4
        POST = 5
        FEND = 6
        DISC = 7
        BEND = 8
    }
    class ISO20022.Camt045001.ChargeType4Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.ChargeType4Choice *-- ISO20022.Camt045001.GenericIdentification47
    class ISO20022.Camt045001.Commission21 {
        + ComssnApld  : ISO20022.Camt045001.AmountOrRate3Choice
        + ComssnTp  : ISO20022.Camt045001.CommissionType5Choice
    }
    ISO20022.Camt045001.Commission21 *-- ISO20022.Camt045001.AmountOrRate3Choice
    ISO20022.Camt045001.Commission21 *-- ISO20022.Camt045001.CommissionType5Choice
    class ISO20022.Camt045001.CommissionType5Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.CommissionType5Choice *-- ISO20022.Camt045001.GenericIdentification47
    class ISO20022.Camt045001.CommissionType6Code {
        CDPL = 1
        BEND = 2
        FEND = 3
    }
    class ISO20022.Camt045001.CurrencyDesignation1 {
        + AddtlInf  : String
        + Lctn  : String
        + CcyDsgnt  : String
    }
    class ISO20022.Camt045001.CurrencyDesignation1Code {
        OFFS = 1
        ONSH = 2
    }
    class ISO20022.Camt045001.DataFormat2Choice {
        + Ustrd  : String
        + Strd  : ISO20022.Camt045001.GenericIdentification1
    }
    ISO20022.Camt045001.DataFormat2Choice *-- ISO20022.Camt045001.GenericIdentification1
    class ISO20022.Camt045001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt045001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Camt045001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Camt045001.FinancialInstrument9 {
        + DualFndInd  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + ReqdNAVCcy  : String
        + SplmtryId  : String
        + Nm  : String
        + Id  : ISO20022.Camt045001.SecurityIdentification3Choice
    }
    ISO20022.Camt045001.FinancialInstrument9 *-- ISO20022.Camt045001.SecurityIdentification3Choice
    class ISO20022.Camt045001.FinancialInstrumentQuantity1 {
        + Unit  : Decimal
    }
    class ISO20022.Camt045001.FlowDirectionType1Code {
        OUTG = 1
        INCG = 2
    }
    class ISO20022.Camt045001.ForeignExchangeTerms19 {
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    class ISO20022.Camt045001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Camt045001.Fund4 {
        + PctgOfFndTtlNAV  : Decimal
        + PrvsTtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + TtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + PrvsTtlNAV  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + TtlNAV  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + Ccy  : String
        + Id  : ISO20022.Camt045001.OtherIdentification4
        + LglNttyIdr  : String
        + Nm  : String
    }
    ISO20022.Camt045001.Fund4 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.Fund4 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.Fund4 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.Fund4 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.Fund4 *-- ISO20022.Camt045001.OtherIdentification4
    class ISO20022.Camt045001.FundBalance1 {
        + TtlCshFrCshOrdrs  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + TtlCshFrUnitOrdrs  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + TtlUnitsFrCshOrdrs  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + TtlUnitsFrUnitOrdrs  : ISO20022.Camt045001.FinancialInstrumentQuantity1
    }
    ISO20022.Camt045001.FundBalance1 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.FundBalance1 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.FundBalance1 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.FundBalance1 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    class ISO20022.Camt045001.FundCashForecast6 {
        + NetCshFcstDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.NetCashForecast4~
        + BrkdwnByUsrDfndParam  : global::System.Collections.Generic.List~ISO20022.Camt045001.BreakdownByUserDefinedParameter3~
        + BrkdwnByCcy  : global::System.Collections.Generic.List~ISO20022.Camt045001.BreakdownByCurrency2~
        + BrkdwnByCtry  : global::System.Collections.Generic.List~ISO20022.Camt045001.BreakdownByCountry2~
        + BrkdwnByPty  : global::System.Collections.Generic.List~ISO20022.Camt045001.BreakdownByParty3~
        + PctgOfShrClssTtlNAV  : Decimal
        + FXRate  : ISO20022.Camt045001.ForeignExchangeTerms19
        + Pric  : ISO20022.Camt045001.UnitPrice19
        + XcptnlNetCshFlowInd  : String
        + CcySts  : ISO20022.Camt045001.CurrencyDesignation1
        + InvstmtCcy  : global::System.Collections.Generic.List~String~
        + TtlNAVChngRate  : Decimal
        + PrvsTtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + TtlUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + PrvsTtlNAV  : global::System.Collections.Generic.List~ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount~
        + TtlNAV  : global::System.Collections.Generic.List~ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount~
        + FinInstrmDtls  : ISO20022.Camt045001.FinancialInstrument9
        + PrvsTradDtTm  : ISO20022.Camt045001.DateAndDateTimeChoice
        + TradDtTm  : ISO20022.Camt045001.DateAndDateTimeChoice
        + Id  : String
    }
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.NetCashForecast4
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.BreakdownByUserDefinedParameter3
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.BreakdownByCurrency2
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.BreakdownByCountry2
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.BreakdownByParty3
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.ForeignExchangeTerms19
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.UnitPrice19
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.CurrencyDesignation1
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.FinancialInstrument9
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.DateAndDateTimeChoice
    ISO20022.Camt045001.FundCashForecast6 *-- ISO20022.Camt045001.DateAndDateTimeChoice
    class ISO20022.Camt045001.FundCashInBreakdown3 {
        + SttlmCcy  : String
        + ComssnDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.Commission21~
        + ChrgDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.Charge26~
        + OrgnlOrdrQtyTp  : ISO20022.Camt045001.QuantityType1Choice
        + InvstmtFndTxInTp  : ISO20022.Camt045001.InvestmentFundTransactionInType1Choice
        + NewAmtInd  : String
        + UnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + Amt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.Commission21
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.Charge26
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.QuantityType1Choice
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.InvestmentFundTransactionInType1Choice
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.FundCashInBreakdown3 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.FundCashOutBreakdown3 {
        + SttlmCcy  : String
        + ComssnDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.Commission21~
        + ChrgDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.Charge26~
        + OrgnlOrdrQtyTp  : ISO20022.Camt045001.QuantityType1Choice
        + InvstmtFndTxOutTp  : ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice
        + NewAmtInd  : String
        + UnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + Amt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.Commission21
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.Charge26
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.QuantityType1Choice
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.FundCashOutBreakdown3 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Camt045001.Extension1~
        + CnsltdNetCshFcst  : ISO20022.Camt045001.NetCashForecast3
        + FndCshFcstDtls  : global::System.Collections.Generic.List~ISO20022.Camt045001.FundCashForecast6~
        + FndOrSubFndDtls  : ISO20022.Camt045001.Fund4
    }
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3 *-- ISO20022.Camt045001.Extension1
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3 *-- ISO20022.Camt045001.NetCashForecast3
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3 *-- ISO20022.Camt045001.FundCashForecast6
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3 *-- ISO20022.Camt045001.Fund4
    class ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 {
        + CshFcstRptToBeCanc  : ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3
        + MsgPgntn  : ISO20022.Camt045001.Pagination
        + RltdRef  : global::System.Collections.Generic.List~ISO20022.Camt045001.AdditionalReference3~
        + PrvsRef  : ISO20022.Camt045001.AdditionalReference3
        + PoolRef  : ISO20022.Camt045001.AdditionalReference3
        + MsgId  : ISO20022.Camt045001.MessageIdentification1
    }
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.Pagination
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.AdditionalReference3
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.AdditionalReference3
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.AdditionalReference3
    ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03 *-- ISO20022.Camt045001.MessageIdentification1
    class ISO20022.Camt045001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt045001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt045001.IdentificationSource5Choice {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
    }
    class ISO20022.Camt045001.InvestmentAccount42 {
        + AcctSvcr  : ISO20022.Camt045001.PartyIdentification2Choice
        + OwnrId  : ISO20022.Camt045001.PartyIdentification2Choice
        + AcctId  : ISO20022.Camt045001.AccountIdentification1
    }
    ISO20022.Camt045001.InvestmentAccount42 *-- ISO20022.Camt045001.PartyIdentification2Choice
    ISO20022.Camt045001.InvestmentAccount42 *-- ISO20022.Camt045001.PartyIdentification2Choice
    ISO20022.Camt045001.InvestmentAccount42 *-- ISO20022.Camt045001.AccountIdentification1
    class ISO20022.Camt045001.InvestmentFundTransactionInType1Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.InvestmentFundTransactionInType1Choice *-- ISO20022.Camt045001.GenericIdentification47
    class ISO20022.Camt045001.InvestmentFundTransactionInType1Code {
        RDIV = 1
        CROI = 2
        INSP = 3
        SWII = 4
        SUBS = 5
    }
    class ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice *-- ISO20022.Camt045001.GenericIdentification47
    class ISO20022.Camt045001.InvestmentFundTransactionOutType1Code {
        CROO = 1
        INSP = 2
        SWIO = 3
        REDM = 4
    }
    class ISO20022.Camt045001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Camt045001.NameAndAddress5 {
        + Adr  : ISO20022.Camt045001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt045001.NameAndAddress5 *-- ISO20022.Camt045001.PostalAddress1
    class ISO20022.Camt045001.NetCashForecast3 {
        + FlowDrctn  : String
        + NetUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + NetAmt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt045001.NetCashForecast3 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.NetCashForecast3 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.NetCashForecast4 {
        + AddtlBal  : ISO20022.Camt045001.FundBalance1
        + FlowDrctn  : String
        + NetUnitsNb  : ISO20022.Camt045001.FinancialInstrumentQuantity1
        + NetAmt  : ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
        + CshSttlmDt  : DateTime
    }
    ISO20022.Camt045001.NetCashForecast4 *-- ISO20022.Camt045001.FundBalance1
    ISO20022.Camt045001.NetCashForecast4 *-- ISO20022.Camt045001.FinancialInstrumentQuantity1
    ISO20022.Camt045001.NetCashForecast4 *-- ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt045001.OrderQuantityType2Code {
        CASH = 1
        UNIT = 2
    }
    class ISO20022.Camt045001.OtherIdentification4 {
        + Tp  : ISO20022.Camt045001.IdentificationSource5Choice
        + Id  : String
    }
    ISO20022.Camt045001.OtherIdentification4 *-- ISO20022.Camt045001.IdentificationSource5Choice
    class ISO20022.Camt045001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Camt045001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Camt045001.NameAndAddress5
        + PrtryId  : ISO20022.Camt045001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Camt045001.PartyIdentification2Choice *-- ISO20022.Camt045001.NameAndAddress5
    ISO20022.Camt045001.PartyIdentification2Choice *-- ISO20022.Camt045001.GenericIdentification1
    class ISO20022.Camt045001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt045001.PriceValue1 {
        + Amt  : ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Camt045001.PriceValue1 *-- ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Camt045001.QuantityType1Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.QuantityType1Choice *-- ISO20022.Camt045001.GenericIdentification47
    class ISO20022.Camt045001.SecurityIdentification3Choice {
        + OthrPrtryId  : ISO20022.Camt045001.AlternateSecurityIdentification1
        + Cmon  : String
        + Belgn  : String
        + SCVM  : String
        + Vlrn  : String
        + Dtch  : String
        + Wrtppr  : String
        + QUICK  : String
        + CTA  : String
        + Blmbrg  : String
        + TckrSymb  : String
        + RIC  : String
        + CUSIP  : String
        + SEDOL  : String
        + ISIN  : String
    }
    ISO20022.Camt045001.SecurityIdentification3Choice *-- ISO20022.Camt045001.AlternateSecurityIdentification1
    class ISO20022.Camt045001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Camt045001.TypeOfPrice10Code {
        ACTU = 1
        DDVR = 2
        SWIC = 3
        RINV = 4
        MIDD = 5
        SWNG = 6
        INTE = 7
        CANC = 8
        CREA = 9
        NAVL = 10
        OFFR = 11
        BIDE = 12
    }
    class ISO20022.Camt045001.UnitPrice19 {
        + Val  : ISO20022.Camt045001.PriceValue1
        + PricTp  : ISO20022.Camt045001.UnitPriceType2Choice
    }
    ISO20022.Camt045001.UnitPrice19 *-- ISO20022.Camt045001.PriceValue1
    ISO20022.Camt045001.UnitPrice19 *-- ISO20022.Camt045001.UnitPriceType2Choice
    class ISO20022.Camt045001.UnitPriceType2Choice {
        + Prtry  : ISO20022.Camt045001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Camt045001.UnitPriceType2Choice *-- ISO20022.Camt045001.GenericIdentification47
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

## Value ISO20022.Camt045001.AccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.SimpleIdentificationInformation||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt045001.AdditionalParameters1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GeoArea|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt045001.AdditionalReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Camt045001.PartyIdentification2Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Camt045001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt045001.AlternateSecurityIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Camt045001.AmountOrRate3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Camt045001.BreakdownByCountry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetCshFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.NetCashForecast4>||XmlElement()||
|+|CshOutFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashOutForecast5>||XmlElement()||
|+|CshInFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashInForecast5>||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NetCshFcst""",NetCshFcst),validElement(NetCshFcst),validList("""CshOutFcst""",CshOutFcst),validElement(CshOutFcst),validList("""CshInFcst""",CshInFcst),validElement(CshInFcst),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt045001.BreakdownByCurrency2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetCshFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.NetCashForecast4>||XmlElement()||
|+|CshInFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashInForecast5>||XmlElement()||
|+|CshOutFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashOutForecast5>||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NetCshFcst""",NetCshFcst),validElement(NetCshFcst),validList("""CshInFcst""",CshInFcst),validElement(CshInFcst),validList("""CshOutFcst""",CshOutFcst),validElement(CshOutFcst),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt045001.BreakdownByParty3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetCshFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.NetCashForecast4>||XmlElement()||
|+|CshOutFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashOutForecast5>||XmlElement()||
|+|CshInFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashInForecast5>||XmlElement()||
|+|AddtlParams|ISO20022.Camt045001.AdditionalParameters1||XmlElement()||
|+|Pty|ISO20022.Camt045001.InvestmentAccount42||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NetCshFcst""",NetCshFcst),validElement(NetCshFcst),validList("""CshOutFcst""",CshOutFcst),validElement(CshOutFcst),validList("""CshInFcst""",CshInFcst),validElement(CshInFcst),validElement(AddtlParams),validElement(Pty))|

---

## Value ISO20022.Camt045001.BreakdownByUserDefinedParameter3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetCshFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.NetCashForecast4>||XmlElement()||
|+|CshOutFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashOutForecast5>||XmlElement()||
|+|CshInFcst|global::System.Collections.Generic.List<ISO20022.Camt045001.CashInForecast5>||XmlElement()||
|+|UsrDfnd|ISO20022.Camt045001.DataFormat2Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Pty|ISO20022.Camt045001.InvestmentAccount42||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NetCshFcst""",NetCshFcst),validElement(NetCshFcst),validList("""CshOutFcst""",CshOutFcst),validElement(CshOutFcst),validList("""CshInFcst""",CshInFcst),validElement(CshInFcst),validElement(UsrDfnd),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Camt045001.CashInForecast5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBal|ISO20022.Camt045001.FundBalance1||XmlElement()||
|+|CshInBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.FundCashInBreakdown3>||XmlElement()||
|+|XcptnlCshFlowInd|String||XmlElement()||
|+|SubTtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|SubTtlAmt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlBal),validList("""CshInBrkdwnDtls""",CshInBrkdwnDtls),validElement(CshInBrkdwnDtls),validElement(SubTtlUnitsNb),validElement(SubTtlAmt))|

---

## Value ISO20022.Camt045001.CashOutForecast5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBal|ISO20022.Camt045001.FundBalance1||XmlElement()||
|+|CshOutBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.FundCashOutBreakdown3>||XmlElement()||
|+|XcptnlCshFlowInd|String||XmlElement()||
|+|SubTtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|SubTtlAmt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlBal),validList("""CshOutBrkdwnDtls""",CshOutBrkdwnDtls),validElement(CshOutBrkdwnDtls),validElement(SubTtlUnitsNb),validElement(SubTtlAmt))|

---

## Value ISO20022.Camt045001.Charge26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChrgApld|ISO20022.Camt045001.AmountOrRate3Choice||XmlElement()||
|+|Tp|ISO20022.Camt045001.ChargeType4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgApld),validElement(Tp))|

---

## Enum ISO20022.Camt045001.ChargeType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||SPCN|Int32||XmlEnum("""SPCN""")|2|
||SHIP|Int32||XmlEnum("""SHIP""")|3|
||REGF|Int32||XmlEnum("""REGF""")|4|
||POST|Int32||XmlEnum("""POST""")|5|
||FEND|Int32||XmlEnum("""FEND""")|6|
||DISC|Int32||XmlEnum("""DISC""")|7|
||BEND|Int32||XmlEnum("""BEND""")|8|

---

## Value ISO20022.Camt045001.ChargeType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt045001.Commission21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ComssnApld|ISO20022.Camt045001.AmountOrRate3Choice||XmlElement()||
|+|ComssnTp|ISO20022.Camt045001.CommissionType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ComssnApld),validElement(ComssnTp))|

---

## Value ISO20022.Camt045001.CommissionType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt045001.CommissionType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDPL|Int32||XmlEnum("""CDPL""")|1|
||BEND|Int32||XmlEnum("""BEND""")|2|
||FEND|Int32||XmlEnum("""FEND""")|3|

---

## Value ISO20022.Camt045001.CurrencyDesignation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Lctn|String||XmlElement()||
|+|CcyDsgnt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Camt045001.CurrencyDesignation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OFFS|Int32||XmlEnum("""OFFS""")|1|
||ONSH|Int32||XmlEnum("""ONSH""")|2|

---

## Value ISO20022.Camt045001.DataFormat2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ustrd|String||XmlElement()||
|+|Strd|ISO20022.Camt045001.GenericIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Strd),validChoice(Ustrd,Strd))|

---

## Value ISO20022.Camt045001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Camt045001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Camt045001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FndDtldConfdCshFcstRptCxl|ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FndDtldConfdCshFcstRptCxl))|

---

## Value ISO20022.Camt045001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt045001.FinancialInstrument9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DualFndInd|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Camt045001.SecurityIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validElement(Id))|

---

## Value ISO20022.Camt045001.FinancialInstrumentQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt045001.FlowDirectionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OUTG|Int32||XmlEnum("""OUTG""")|1|
||INCG|Int32||XmlEnum("""INCG""")|2|

---

## Value ISO20022.Camt045001.ForeignExchangeTerms19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt045001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Camt045001.Fund4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PctgOfFndTtlNAV|Decimal||XmlElement()||
|+|PrvsTtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|TtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|PrvsTtlNAV|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlNAV|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Id|ISO20022.Camt045001.OtherIdentification4||XmlElement()||
|+|LglNttyIdr|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvsTtlUnitsNb),validElement(TtlUnitsNb),validElement(PrvsTtlNAV),validElement(TtlNAV),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Id),validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt045001.FundBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlCshFrCshOrdrs|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlCshFrUnitOrdrs|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlUnitsFrCshOrdrs|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|TtlUnitsFrUnitOrdrs|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlCshFrCshOrdrs),validElement(TtlCshFrUnitOrdrs),validElement(TtlUnitsFrCshOrdrs),validElement(TtlUnitsFrUnitOrdrs))|

---

## Value ISO20022.Camt045001.FundCashForecast6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetCshFcstDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.NetCashForecast4>||XmlElement()||
|+|BrkdwnByUsrDfndParam|global::System.Collections.Generic.List<ISO20022.Camt045001.BreakdownByUserDefinedParameter3>||XmlElement()||
|+|BrkdwnByCcy|global::System.Collections.Generic.List<ISO20022.Camt045001.BreakdownByCurrency2>||XmlElement()||
|+|BrkdwnByCtry|global::System.Collections.Generic.List<ISO20022.Camt045001.BreakdownByCountry2>||XmlElement()||
|+|BrkdwnByPty|global::System.Collections.Generic.List<ISO20022.Camt045001.BreakdownByParty3>||XmlElement()||
|+|PctgOfShrClssTtlNAV|Decimal||XmlElement()||
|+|FXRate|ISO20022.Camt045001.ForeignExchangeTerms19||XmlElement()||
|+|Pric|ISO20022.Camt045001.UnitPrice19||XmlElement()||
|+|XcptnlNetCshFlowInd|String||XmlElement()||
|+|CcySts|ISO20022.Camt045001.CurrencyDesignation1||XmlElement()||
|+|InvstmtCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TtlNAVChngRate|Decimal||XmlElement()||
|+|PrvsTtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|TtlUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|PrvsTtlNAV|global::System.Collections.Generic.List<ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|TtlNAV|global::System.Collections.Generic.List<ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|FinInstrmDtls|ISO20022.Camt045001.FinancialInstrument9||XmlElement()||
|+|PrvsTradDtTm|ISO20022.Camt045001.DateAndDateTimeChoice||XmlElement()||
|+|TradDtTm|ISO20022.Camt045001.DateAndDateTimeChoice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NetCshFcstDtls""",NetCshFcstDtls),validElement(NetCshFcstDtls),validList("""BrkdwnByUsrDfndParam""",BrkdwnByUsrDfndParam),validElement(BrkdwnByUsrDfndParam),validList("""BrkdwnByCcy""",BrkdwnByCcy),validElement(BrkdwnByCcy),validList("""BrkdwnByCtry""",BrkdwnByCtry),validElement(BrkdwnByCtry),validList("""BrkdwnByPty""",BrkdwnByPty),validElement(BrkdwnByPty),validElement(FXRate),validElement(Pric),validElement(CcySts),validPattern("""InvstmtCcy""",InvstmtCcy,"""[A-Z]{3,3}"""),validElement(PrvsTtlUnitsNb),validElement(TtlUnitsNb),validList("""PrvsTtlNAV""",PrvsTtlNAV),validElement(PrvsTtlNAV),validList("""TtlNAV""",TtlNAV),validElement(TtlNAV),validElement(FinInstrmDtls),validElement(PrvsTradDtTm),validElement(TradDtTm))|

---

## Value ISO20022.Camt045001.FundCashInBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmCcy|String||XmlElement()||
|+|ComssnDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.Commission21>||XmlElement()||
|+|ChrgDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.Charge26>||XmlElement()||
|+|OrgnlOrdrQtyTp|ISO20022.Camt045001.QuantityType1Choice||XmlElement()||
|+|InvstmtFndTxInTp|ISO20022.Camt045001.InvestmentFundTransactionInType1Choice||XmlElement()||
|+|NewAmtInd|String||XmlElement()||
|+|UnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|Amt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validList("""ComssnDtls""",ComssnDtls),validElement(ComssnDtls),validList("""ChrgDtls""",ChrgDtls),validElement(ChrgDtls),validElement(OrgnlOrdrQtyTp),validElement(InvstmtFndTxInTp),validElement(UnitsNb),validElement(Amt))|

---

## Value ISO20022.Camt045001.FundCashOutBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmCcy|String||XmlElement()||
|+|ComssnDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.Commission21>||XmlElement()||
|+|ChrgDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.Charge26>||XmlElement()||
|+|OrgnlOrdrQtyTp|ISO20022.Camt045001.QuantityType1Choice||XmlElement()||
|+|InvstmtFndTxOutTp|ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice||XmlElement()||
|+|NewAmtInd|String||XmlElement()||
|+|UnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|Amt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validList("""ComssnDtls""",ComssnDtls),validElement(ComssnDtls),validList("""ChrgDtls""",ChrgDtls),validElement(ChrgDtls),validElement(OrgnlOrdrQtyTp),validElement(InvstmtFndTxOutTp),validElement(UnitsNb),validElement(Amt))|

---

## Value ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Camt045001.Extension1>||XmlElement()||
|+|CnsltdNetCshFcst|ISO20022.Camt045001.NetCashForecast3||XmlElement()||
|+|FndCshFcstDtls|global::System.Collections.Generic.List<ISO20022.Camt045001.FundCashForecast6>||XmlElement()||
|+|FndOrSubFndDtls|ISO20022.Camt045001.Fund4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CnsltdNetCshFcst),validRequired("""FndCshFcstDtls""",FndCshFcstDtls),validList("""FndCshFcstDtls""",FndCshFcstDtls),validElement(FndCshFcstDtls),validElement(FndOrSubFndDtls))|

---

## Aspect ISO20022.Camt045001.FundDetailedConfirmedCashForecastReportCancellationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshFcstRptToBeCanc|ISO20022.Camt045001.FundDetailedConfirmedCashForecastReport3||XmlElement()||
|+|MsgPgntn|ISO20022.Camt045001.Pagination||XmlElement()||
|+|RltdRef|global::System.Collections.Generic.List<ISO20022.Camt045001.AdditionalReference3>||XmlElement()||
|+|PrvsRef|ISO20022.Camt045001.AdditionalReference3||XmlElement()||
|+|PoolRef|ISO20022.Camt045001.AdditionalReference3||XmlElement()||
|+|MsgId|ISO20022.Camt045001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshFcstRptToBeCanc),validElement(MsgPgntn),validList("""RltdRef""",RltdRef),validElement(RltdRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

---

## Value ISO20022.Camt045001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt045001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt045001.IdentificationSource5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc))|

---

## Value ISO20022.Camt045001.InvestmentAccount42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Camt045001.PartyIdentification2Choice||XmlElement()||
|+|OwnrId|ISO20022.Camt045001.PartyIdentification2Choice||XmlElement()||
|+|AcctId|ISO20022.Camt045001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(OwnrId),validElement(AcctId))|

---

## Value ISO20022.Camt045001.InvestmentFundTransactionInType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt045001.InvestmentFundTransactionInType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDIV|Int32||XmlEnum("""RDIV""")|1|
||CROI|Int32||XmlEnum("""CROI""")|2|
||INSP|Int32||XmlEnum("""INSP""")|3|
||SWII|Int32||XmlEnum("""SWII""")|4|
||SUBS|Int32||XmlEnum("""SUBS""")|5|

---

## Value ISO20022.Camt045001.InvestmentFundTransactionOutType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt045001.InvestmentFundTransactionOutType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CROO|Int32||XmlEnum("""CROO""")|1|
||INSP|Int32||XmlEnum("""INSP""")|2|
||SWIO|Int32||XmlEnum("""SWIO""")|3|
||REDM|Int32||XmlEnum("""REDM""")|4|

---

## Value ISO20022.Camt045001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt045001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt045001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Camt045001.NetCashForecast3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FlowDrctn|String||XmlElement()||
|+|NetUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|NetAmt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NetUnitsNb),validElement(NetAmt))|

---

## Value ISO20022.Camt045001.NetCashForecast4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBal|ISO20022.Camt045001.FundBalance1||XmlElement()||
|+|FlowDrctn|String||XmlElement()||
|+|NetUnitsNb|ISO20022.Camt045001.FinancialInstrumentQuantity1||XmlElement()||
|+|NetAmt|ISO20022.Camt045001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlBal),validElement(NetUnitsNb),validElement(NetAmt))|

---

## Enum ISO20022.Camt045001.OrderQuantityType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||UNIT|Int32||XmlEnum("""UNIT""")|2|

---

## Value ISO20022.Camt045001.OtherIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Camt045001.IdentificationSource5Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt045001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Camt045001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt045001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt045001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Camt045001.PostalAddress1


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

## Value ISO20022.Camt045001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt045001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt045001.QuantityType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt045001.SecurityIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Camt045001.AlternateSecurityIdentification1||XmlElement()||
|+|Cmon|String||XmlElement()||
|+|Belgn|String||XmlElement()||
|+|SCVM|String||XmlElement()||
|+|Vlrn|String||XmlElement()||
|+|Dtch|String||XmlElement()||
|+|Wrtppr|String||XmlElement()||
|+|QUICK|String||XmlElement()||
|+|CTA|String||XmlElement()||
|+|Blmbrg|String||XmlElement()||
|+|TckrSymb|String||XmlElement()||
|+|RIC|String||XmlElement()||
|+|CUSIP|String||XmlElement()||
|+|SEDOL|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPrtryId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN))|

---

## Value ISO20022.Camt045001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt045001.TypeOfPrice10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||DDVR|Int32||XmlEnum("""DDVR""")|2|
||SWIC|Int32||XmlEnum("""SWIC""")|3|
||RINV|Int32||XmlEnum("""RINV""")|4|
||MIDD|Int32||XmlEnum("""MIDD""")|5|
||SWNG|Int32||XmlEnum("""SWNG""")|6|
||INTE|Int32||XmlEnum("""INTE""")|7|
||CANC|Int32||XmlEnum("""CANC""")|8|
||CREA|Int32||XmlEnum("""CREA""")|9|
||NAVL|Int32||XmlEnum("""NAVL""")|10|
||OFFR|Int32||XmlEnum("""OFFR""")|11|
||BIDE|Int32||XmlEnum("""BIDE""")|12|

---

## Value ISO20022.Camt045001.UnitPrice19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Camt045001.PriceValue1||XmlElement()||
|+|PricTp|ISO20022.Camt045001.UnitPriceType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(PricTp))|

---

## Value ISO20022.Camt045001.UnitPriceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt045001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

