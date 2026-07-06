# fxtr.014.001.06
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Fxtr014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr014001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Fxtr014001.AgreedRate3 {
        + QtdCcy  : String
        + UnitCcy  : String
        + XchgRate  : Decimal
    }
    class ISO20022.Fxtr014001.AgreementConditions1 {
        + Vrsn  : String
        + Dt  : DateTime
        + AgrmtCd  : String
    }
    class ISO20022.Fxtr014001.AllocationIndicator1Code {
        UNAL = 1
        PREA = 2
        POST = 3
    }
    class ISO20022.Fxtr014001.AmountOrRate4Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Fxtr014001.ActiveCurrencyAndAmount
    }
    ISO20022.Fxtr014001.AmountOrRate4Choice *-- ISO20022.Fxtr014001.ActiveCurrencyAndAmount
    class ISO20022.Fxtr014001.AmountsAndValueDate8 {
        + SttlmDt  : DateTime
        + TradgSdSellAmt  : ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice
        + TradgSdBuyAmt  : ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice
    }
    ISO20022.Fxtr014001.AmountsAndValueDate8 *-- ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice
    ISO20022.Fxtr014001.AmountsAndValueDate8 *-- ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice
    class ISO20022.Fxtr014001.CalculationAgent1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Fxtr014001.ClearingBrokerIdentification1 {
        + ClrBrkrId  : String
        + SdInd  : String
    }
    class ISO20022.Fxtr014001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Fxtr014001.CollateralisationIndicator1Code {
        UNCO = 1
        PART = 2
        ONEW = 3
        FULL = 4
    }
    class ISO20022.Fxtr014001.ContactInformation1 {
        + EmailAdr  : String
        + TelNb  : String
        + FaxNb  : String
        + Nm  : String
    }
    class ISO20022.Fxtr014001.CorporateSectorIdentifier1Code {
        U = 1
        R = 2
        O = 3
        F = 4
        I = 5
        C = 6
        A = 7
        L = 8
    }
    class ISO20022.Fxtr014001.CounterpartySideTransactionReporting3 {
        + CtrPtySdUnqTxIdr  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.UniqueTransactionIdentifier3~
        + RptgPty  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + RptgJursdctn  : String
    }
    ISO20022.Fxtr014001.CounterpartySideTransactionReporting3 *-- ISO20022.Fxtr014001.UniqueTransactionIdentifier3
    ISO20022.Fxtr014001.CounterpartySideTransactionReporting3 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    class ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice {
        + DgtlTknAmt  : ISO20022.Fxtr014001.DigitalTokenAmount3
        + Amt  : ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice *-- ISO20022.Fxtr014001.DigitalTokenAmount3
    ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice *-- ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Fxtr014001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Fxtr014001.DigitalTokenAmount3 {
        + Desc  : String
        + Unit  : Decimal
        + Idr  : String
    }
    class ISO20022.Fxtr014001.FXAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Fxtr014001.FXAmountType1Code {
        RSCH = 1
        PRWI = 2
        REFD = 3
        PRDF = 4
        ACCA = 5
        SHIP = 6
        SETT = 7
        SAMG = 8
        RESU = 9
        REMU = 10
        REGF = 11
        OTMG = 12
        PRMA = 13
        OCMT = 14
        LEVY = 15
        ISDI = 16
        HDGE = 17
        DSCA = 18
        LADT = 19
        CBCH = 20
        CHAR = 21
        BAKL = 22
        ACRU = 23
        DEAL = 24
        TOTL = 25
        SUBS = 26
        SPCN = 27
        CREB = 28
        ANTO = 29
        MACO = 30
        MARG = 31
        ENTF = 32
        ERFE = 33
        AKTI = 34
        COAX = 35
        EQUL = 36
        EUTR = 37
        EXEC = 38
        LIDT = 39
        LOTE = 40
        LYDT = 41
        LOCO = 42
        LOCL = 43
        COUN = 44
        OTHR = 45
        STAM = 46
        STEX = 47
        TRAX = 48
        TRAN = 49
        VATA = 50
        WITH = 51
        ZWIS = 52
    }
    class ISO20022.Fxtr014001.FXCommissionOrFee1 {
        + Sgn  : String
        + AmtOrRate  : ISO20022.Fxtr014001.AmountOrRate4Choice
        + Tp  : ISO20022.Fxtr014001.FXAmountType1Choice
    }
    ISO20022.Fxtr014001.FXCommissionOrFee1 *-- ISO20022.Fxtr014001.AmountOrRate4Choice
    ISO20022.Fxtr014001.FXCommissionOrFee1 *-- ISO20022.Fxtr014001.FXAmountType1Choice
    class ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.SupplementaryData1~
        + PstTradEvt  : ISO20022.Fxtr014001.PostTradeEvent1
        + RgltryRptg  : ISO20022.Fxtr014001.RegulatoryReporting8
        + OptnlGnlInf  : ISO20022.Fxtr014001.GeneralInformation9
        + CtrPtySdSttlmInstrs  : ISO20022.Fxtr014001.SettlementParties120
        + TradgSdSttlmInstrs  : ISO20022.Fxtr014001.SettlementParties120
        + NDFConds  : ISO20022.Fxtr014001.NonDeliverableForwardConditions1
        + AgrdRate  : ISO20022.Fxtr014001.AgreedRate3
        + TradAmts  : ISO20022.Fxtr014001.AmountsAndValueDate8
        + CtrPtySdId  : ISO20022.Fxtr014001.TradePartyIdentification8
        + TradgSdId  : ISO20022.Fxtr014001.TradePartyIdentification8
        + TradInf  : ISO20022.Fxtr014001.TradeAgreement14
    }
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.SupplementaryData1
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.PostTradeEvent1
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.RegulatoryReporting8
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.GeneralInformation9
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.SettlementParties120
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.SettlementParties120
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.NonDeliverableForwardConditions1
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.AgreedRate3
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.AmountsAndValueDate8
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.TradePartyIdentification8
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.TradePartyIdentification8
    ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06 *-- ISO20022.Fxtr014001.TradeAgreement14
    class ISO20022.Fxtr014001.FundIdentification5 {
        + CtdnId  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + AcctIdWthCtdn  : String
        + FndId  : ISO20022.Fxtr014001.PartyIdentification60
    }
    ISO20022.Fxtr014001.FundIdentification5 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.FundIdentification5 *-- ISO20022.Fxtr014001.PartyIdentification60
    class ISO20022.Fxtr014001.GeneralInformation9 {
        + ClctnAgt  : ISO20022.Fxtr014001.CalculationAgent1Choice
        + PmtClrCentr  : String
        + BrkrsRef  : String
        + DefsYr  : Int32
        + AgrmtDtls  : ISO20022.Fxtr014001.AgreementConditions1
        + CtctInf  : ISO20022.Fxtr014001.ContactInformation1
        + DealgBrnchCtrPtySd  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + DealgBrnchTradgSd  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + SndrToRcvrInf  : String
        + BrkrsComssn  : ISO20022.Fxtr014001.ActiveCurrencyAndAmount
        + CtrPtyRef  : String
        + BrkrId  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + DealgMtd  : String
        + RltdTradRef  : String
        + BlckInd  : String
    }
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.CalculationAgent1Choice
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.AgreementConditions1
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.ContactInformation1
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.ActiveCurrencyAndAmount
    ISO20022.Fxtr014001.GeneralInformation9 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    class ISO20022.Fxtr014001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Fxtr014001.NDFOpeningFixing1Choice {
        + OpngConfRef  : String
        + OpngConds  : ISO20022.Fxtr014001.OpeningConditions1
    }
    ISO20022.Fxtr014001.NDFOpeningFixing1Choice *-- ISO20022.Fxtr014001.OpeningConditions1
    class ISO20022.Fxtr014001.NameAndAddress8 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + Adr  : ISO20022.Fxtr014001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Fxtr014001.NameAndAddress8 *-- ISO20022.Fxtr014001.PostalAddress1
    class ISO20022.Fxtr014001.NonDeliverableForwardConditions1 {
        + OpngFxgConds  : ISO20022.Fxtr014001.NDFOpeningFixing1Choice
        + OpngInd  : String
    }
    ISO20022.Fxtr014001.NonDeliverableForwardConditions1 *-- ISO20022.Fxtr014001.NDFOpeningFixing1Choice
    class ISO20022.Fxtr014001.OpeningConditions1 {
        + SttlmRateSrc  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.SettlementRateSource1~
        + ValtnDt  : DateTime
        + SttlmCcy  : String
    }
    ISO20022.Fxtr014001.OpeningConditions1 *-- ISO20022.Fxtr014001.SettlementRateSource1
    class ISO20022.Fxtr014001.OtherIdentification1 {
        + Tp  : ISO20022.Fxtr014001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Fxtr014001.OtherIdentification1 *-- ISO20022.Fxtr014001.IdentificationSource3Choice
    class ISO20022.Fxtr014001.PartyIdentification242Choice {
        + PtyId  : ISO20022.Fxtr014001.PartyIdentification266
        + AnyBIC  : ISO20022.Fxtr014001.PartyIdentification265
        + NmAndAdr  : ISO20022.Fxtr014001.NameAndAddress8
    }
    ISO20022.Fxtr014001.PartyIdentification242Choice *-- ISO20022.Fxtr014001.PartyIdentification266
    ISO20022.Fxtr014001.PartyIdentification242Choice *-- ISO20022.Fxtr014001.PartyIdentification265
    ISO20022.Fxtr014001.PartyIdentification242Choice *-- ISO20022.Fxtr014001.NameAndAddress8
    class ISO20022.Fxtr014001.PartyIdentification265 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + AnyBIC  : String
    }
    class ISO20022.Fxtr014001.PartyIdentification266 {
        + LglNttyIdr  : String
        + ClrSysId  : ISO20022.Fxtr014001.ClearingSystemIdentification2Choice
        + Adr  : String
        + AcctNb  : String
        + AnyBIC  : ISO20022.Fxtr014001.PartyIdentification265
        + PtyNm  : String
    }
    ISO20022.Fxtr014001.PartyIdentification266 *-- ISO20022.Fxtr014001.ClearingSystemIdentification2Choice
    ISO20022.Fxtr014001.PartyIdentification266 *-- ISO20022.Fxtr014001.PartyIdentification265
    class ISO20022.Fxtr014001.PartyIdentification60 {
        + LglNttyIdr  : String
        + NmAndAdr  : ISO20022.Fxtr014001.NameAndAddress8
        + FndId  : String
    }
    ISO20022.Fxtr014001.PartyIdentification60 *-- ISO20022.Fxtr014001.NameAndAddress8
    class ISO20022.Fxtr014001.PostTradeEvent1 {
        + OutsdngSttlmAmt  : ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount
        + PrftOrLoss  : ISO20022.Fxtr014001.ProfitAndLossAmount2
        + PrftOrLossSttlmDt  : DateTime
        + UndrlygLbltyRef  : String
        + OrgnlRef  : String
        + Tp  : ISO20022.Fxtr014001.PostTradeEventType2Choice
    }
    ISO20022.Fxtr014001.PostTradeEvent1 *-- ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Fxtr014001.PostTradeEvent1 *-- ISO20022.Fxtr014001.ProfitAndLossAmount2
    ISO20022.Fxtr014001.PostTradeEvent1 *-- ISO20022.Fxtr014001.PostTradeEventType2Choice
    class ISO20022.Fxtr014001.PostTradeEventType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Fxtr014001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Fxtr014001.ProductIdentifier3Choice {
        + UnqPdctIdr  : String
        + UndrlygPdctIdr  : String
    }
    class ISO20022.Fxtr014001.ProfitAndLossAmount2 {
        + Sgn  : String
        + Amt  : ISO20022.Fxtr014001.ActiveCurrencyAndAmount
    }
    ISO20022.Fxtr014001.ProfitAndLossAmount2 *-- ISO20022.Fxtr014001.ActiveCurrencyAndAmount
    class ISO20022.Fxtr014001.RegulatoryReporting8 {
        + AddtlRptgInf  : String
        + ComssnsAndFees  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.FXCommissionOrFee1~
        + ClrTmstmp  : DateTime
        + ConfDtAndTmstmp  : DateTime
        + FinInstrmId  : ISO20022.Fxtr014001.SecurityIdentification19
        + ComrclOrTrsrFincgInd  : String
        + NtrgrpTradInd  : String
        + TradWthNonEEACtrPtyInd  : String
        + CorpSctrInd  : String
        + PrtflCmprssnInd  : String
        + CollPrtflCd  : String
        + CollPrtflInd  : String
        + FinNtrOfTheCtrPtyInd  : String
        + LkSwpId  : String
        + NonStdFlg  : String
        + ExctnTmstmp  : ISO20022.Fxtr014001.DateAndDateTime2Choice
        + ExctnVn  : String
        + CollstnInd  : String
        + AllcnInd  : String
        + PdctIdr  : ISO20022.Fxtr014001.ProductIdentifier3Choice
        + ClrdPdctId  : String
        + ClrThrshldInd  : String
        + ClrBrkrId  : ISO20022.Fxtr014001.ClearingBrokerIdentification1
        + ClrXcptnPty  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + ClrBrkr  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + CntrlCtrPtyClrHs  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + CtrPtySdTxRptg  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.CounterpartySideTransactionReporting3~
        + TradgSdTxRptg  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.TradingSideTransactionReporting3~
    }
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.FXCommissionOrFee1
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.SecurityIdentification19
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.DateAndDateTime2Choice
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.ProductIdentifier3Choice
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.ClearingBrokerIdentification1
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.CounterpartySideTransactionReporting3
    ISO20022.Fxtr014001.RegulatoryReporting8 *-- ISO20022.Fxtr014001.TradingSideTransactionReporting3
    class ISO20022.Fxtr014001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Fxtr014001.SecurityIdentification19 *-- ISO20022.Fxtr014001.OtherIdentification1
    class ISO20022.Fxtr014001.SettlementParties120 {
        + BnfcryInstn  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + RcvgAgt  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + Intrmy  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + DlvryAgt  : ISO20022.Fxtr014001.PartyIdentification242Choice
    }
    ISO20022.Fxtr014001.SettlementParties120 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.SettlementParties120 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.SettlementParties120 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.SettlementParties120 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    class ISO20022.Fxtr014001.SettlementRateSource1 {
        + LctnCd  : String
        + CtryCd  : String
        + Tm  : String
        + RateSrc  : String
    }
    class ISO20022.Fxtr014001.SideIndicator1Code {
        CLNT = 1
        CCPL = 2
    }
    class ISO20022.Fxtr014001.SupplementaryData1 {
        + Envlp  : ISO20022.Fxtr014001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Fxtr014001.SupplementaryData1 *-- ISO20022.Fxtr014001.SupplementaryDataEnvelope1
    class ISO20022.Fxtr014001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Fxtr014001.TradeAgreement14 {
        + PmtVrssPmtInd  : String
        + SttlmSsnIdr  : String
        + PdctTp  : String
        + OprScp  : String
        + OprTp  : String
        + CmonRef  : String
        + OrgtrRef  : String
        + TradDt  : DateTime
    }
    class ISO20022.Fxtr014001.TradePartyIdentification8 {
        + FndId  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.FundIdentification5~
        + TradPty  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + SubmitgPty  : ISO20022.Fxtr014001.PartyIdentification242Choice
    }
    ISO20022.Fxtr014001.TradePartyIdentification8 *-- ISO20022.Fxtr014001.FundIdentification5
    ISO20022.Fxtr014001.TradePartyIdentification8 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    ISO20022.Fxtr014001.TradePartyIdentification8 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    class ISO20022.Fxtr014001.Trading1MethodCode {
        BROK = 1
        PHON = 2
        ELEC = 3
    }
    class ISO20022.Fxtr014001.TradingSideTransactionReporting3 {
        + TradgSdUnqTxIdr  : global::System.Collections.Generic.List~ISO20022.Fxtr014001.UniqueTransactionIdentifier3~
        + RptgPty  : ISO20022.Fxtr014001.PartyIdentification242Choice
        + RptgJursdctn  : String
    }
    ISO20022.Fxtr014001.TradingSideTransactionReporting3 *-- ISO20022.Fxtr014001.UniqueTransactionIdentifier3
    ISO20022.Fxtr014001.TradingSideTransactionReporting3 *-- ISO20022.Fxtr014001.PartyIdentification242Choice
    class ISO20022.Fxtr014001.UnderlyingProductIdentifier1Code {
        SWAP = 1
        SPOT = 2
        NDFO = 3
        FORW = 4
    }
    class ISO20022.Fxtr014001.UniqueTransactionIdentifier3 {
        + PrrUnqTxIdr  : global::System.Collections.Generic.List~String~
        + UnqTxIdr  : String
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

## Value ISO20022.Fxtr014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Fxtr014001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Fxtr014001.AgreedRate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr014001.AgreementConditions1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|AgrmtCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Vrsn""",Vrsn,"""[0-9]{4}"""),validPattern("""AgrmtCd""",AgrmtCd,"""[a-zA-Z]{1,6}"""))|

---

## Enum ISO20022.Fxtr014001.AllocationIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNAL|Int32||XmlEnum("""UNAL""")|1|
||PREA|Int32||XmlEnum("""PREA""")|2|
||POST|Int32||XmlEnum("""POST""")|3|

---

## Value ISO20022.Fxtr014001.AmountOrRate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Fxtr014001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Fxtr014001.AmountsAndValueDate8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmDt|DateTime||XmlElement()||
|+|TradgSdSellAmt|ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice||XmlElement()||
|+|TradgSdBuyAmt|ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradgSdSellAmt),validElement(TradgSdBuyAmt))|

---

## Value ISO20022.Fxtr014001.CalculationAgent1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Fxtr014001.ClearingBrokerIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrBrkrId|String||XmlElement()||
|+|SdInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr014001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Fxtr014001.CollateralisationIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNCO|Int32||XmlEnum("""UNCO""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||ONEW|Int32||XmlEnum("""ONEW""")|3|
||FULL|Int32||XmlEnum("""FULL""")|4|

---

## Value ISO20022.Fxtr014001.ContactInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|TelNb|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TelNb""",TelNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Fxtr014001.CorporateSectorIdentifier1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||U|Int32||XmlEnum("""U""")|1|
||R|Int32||XmlEnum("""R""")|2|
||O|Int32||XmlEnum("""O""")|3|
||F|Int32||XmlEnum("""F""")|4|
||I|Int32||XmlEnum("""I""")|5|
||C|Int32||XmlEnum("""C""")|6|
||A|Int32||XmlEnum("""A""")|7|
||L|Int32||XmlEnum("""L""")|8|

---

## Value ISO20022.Fxtr014001.CounterpartySideTransactionReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySdUnqTxIdr|global::System.Collections.Generic.List<ISO20022.Fxtr014001.UniqueTransactionIdentifier3>||XmlElement()||
|+|RptgPty|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|RptgJursdctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CtrPtySdUnqTxIdr""",CtrPtySdUnqTxIdr),validElement(CtrPtySdUnqTxIdr),validElement(RptgPty))|

---

## Value ISO20022.Fxtr014001.CurrencyOrDigitalTokenAmount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknAmt|ISO20022.Fxtr014001.DigitalTokenAmount3||XmlElement()||
|+|Amt|ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlTknAmt),validElement(Amt),validChoice(DgtlTknAmt,Amt))|

---

## Value ISO20022.Fxtr014001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Fxtr014001.DigitalTokenAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|Idr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Idr""",Idr,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""))|

---

## Type ISO20022.Fxtr014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXTradInstr|ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXTradInstr))|

---

## Value ISO20022.Fxtr014001.FXAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Fxtr014001.FXAmountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSCH|Int32||XmlEnum("""RSCH""")|1|
||PRWI|Int32||XmlEnum("""PRWI""")|2|
||REFD|Int32||XmlEnum("""REFD""")|3|
||PRDF|Int32||XmlEnum("""PRDF""")|4|
||ACCA|Int32||XmlEnum("""ACCA""")|5|
||SHIP|Int32||XmlEnum("""SHIP""")|6|
||SETT|Int32||XmlEnum("""SETT""")|7|
||SAMG|Int32||XmlEnum("""SAMG""")|8|
||RESU|Int32||XmlEnum("""RESU""")|9|
||REMU|Int32||XmlEnum("""REMU""")|10|
||REGF|Int32||XmlEnum("""REGF""")|11|
||OTMG|Int32||XmlEnum("""OTMG""")|12|
||PRMA|Int32||XmlEnum("""PRMA""")|13|
||OCMT|Int32||XmlEnum("""OCMT""")|14|
||LEVY|Int32||XmlEnum("""LEVY""")|15|
||ISDI|Int32||XmlEnum("""ISDI""")|16|
||HDGE|Int32||XmlEnum("""HDGE""")|17|
||DSCA|Int32||XmlEnum("""DSCA""")|18|
||LADT|Int32||XmlEnum("""LADT""")|19|
||CBCH|Int32||XmlEnum("""CBCH""")|20|
||CHAR|Int32||XmlEnum("""CHAR""")|21|
||BAKL|Int32||XmlEnum("""BAKL""")|22|
||ACRU|Int32||XmlEnum("""ACRU""")|23|
||DEAL|Int32||XmlEnum("""DEAL""")|24|
||TOTL|Int32||XmlEnum("""TOTL""")|25|
||SUBS|Int32||XmlEnum("""SUBS""")|26|
||SPCN|Int32||XmlEnum("""SPCN""")|27|
||CREB|Int32||XmlEnum("""CREB""")|28|
||ANTO|Int32||XmlEnum("""ANTO""")|29|
||MACO|Int32||XmlEnum("""MACO""")|30|
||MARG|Int32||XmlEnum("""MARG""")|31|
||ENTF|Int32||XmlEnum("""ENTF""")|32|
||ERFE|Int32||XmlEnum("""ERFE""")|33|
||AKTI|Int32||XmlEnum("""AKTI""")|34|
||COAX|Int32||XmlEnum("""COAX""")|35|
||EQUL|Int32||XmlEnum("""EQUL""")|36|
||EUTR|Int32||XmlEnum("""EUTR""")|37|
||EXEC|Int32||XmlEnum("""EXEC""")|38|
||LIDT|Int32||XmlEnum("""LIDT""")|39|
||LOTE|Int32||XmlEnum("""LOTE""")|40|
||LYDT|Int32||XmlEnum("""LYDT""")|41|
||LOCO|Int32||XmlEnum("""LOCO""")|42|
||LOCL|Int32||XmlEnum("""LOCL""")|43|
||COUN|Int32||XmlEnum("""COUN""")|44|
||OTHR|Int32||XmlEnum("""OTHR""")|45|
||STAM|Int32||XmlEnum("""STAM""")|46|
||STEX|Int32||XmlEnum("""STEX""")|47|
||TRAX|Int32||XmlEnum("""TRAX""")|48|
||TRAN|Int32||XmlEnum("""TRAN""")|49|
||VATA|Int32||XmlEnum("""VATA""")|50|
||WITH|Int32||XmlEnum("""WITH""")|51|
||ZWIS|Int32||XmlEnum("""ZWIS""")|52|

---

## Value ISO20022.Fxtr014001.FXCommissionOrFee1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|AmtOrRate|ISO20022.Fxtr014001.AmountOrRate4Choice||XmlElement()||
|+|Tp|ISO20022.Fxtr014001.FXAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtOrRate),validElement(Tp))|

---

## Aspect ISO20022.Fxtr014001.ForeignExchangeTradeInstructionV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Fxtr014001.SupplementaryData1>||XmlElement()||
|+|PstTradEvt|ISO20022.Fxtr014001.PostTradeEvent1||XmlElement()||
|+|RgltryRptg|ISO20022.Fxtr014001.RegulatoryReporting8||XmlElement()||
|+|OptnlGnlInf|ISO20022.Fxtr014001.GeneralInformation9||XmlElement()||
|+|CtrPtySdSttlmInstrs|ISO20022.Fxtr014001.SettlementParties120||XmlElement()||
|+|TradgSdSttlmInstrs|ISO20022.Fxtr014001.SettlementParties120||XmlElement()||
|+|NDFConds|ISO20022.Fxtr014001.NonDeliverableForwardConditions1||XmlElement()||
|+|AgrdRate|ISO20022.Fxtr014001.AgreedRate3||XmlElement()||
|+|TradAmts|ISO20022.Fxtr014001.AmountsAndValueDate8||XmlElement()||
|+|CtrPtySdId|ISO20022.Fxtr014001.TradePartyIdentification8||XmlElement()||
|+|TradgSdId|ISO20022.Fxtr014001.TradePartyIdentification8||XmlElement()||
|+|TradInf|ISO20022.Fxtr014001.TradeAgreement14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PstTradEvt),validElement(RgltryRptg),validElement(OptnlGnlInf),validElement(CtrPtySdSttlmInstrs),validElement(TradgSdSttlmInstrs),validElement(NDFConds),validElement(AgrdRate),validElement(TradAmts),validElement(CtrPtySdId),validElement(TradgSdId),validElement(TradInf))|

---

## Value ISO20022.Fxtr014001.FundIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtdnId|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|AcctIdWthCtdn|String||XmlElement()||
|+|FndId|ISO20022.Fxtr014001.PartyIdentification60||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtdnId),validElement(FndId))|

---

## Value ISO20022.Fxtr014001.GeneralInformation9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClctnAgt|ISO20022.Fxtr014001.CalculationAgent1Choice||XmlElement()||
|+|PmtClrCentr|String||XmlElement()||
|+|BrkrsRef|String||XmlElement()||
|+|DefsYr|Int32||XmlElement()||
|+|AgrmtDtls|ISO20022.Fxtr014001.AgreementConditions1||XmlElement()||
|+|CtctInf|ISO20022.Fxtr014001.ContactInformation1||XmlElement()||
|+|DealgBrnchCtrPtySd|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|DealgBrnchTradgSd|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|SndrToRcvrInf|String||XmlElement()||
|+|BrkrsComssn|ISO20022.Fxtr014001.ActiveCurrencyAndAmount||XmlElement()||
|+|CtrPtyRef|String||XmlElement()||
|+|BrkrId|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|DealgMtd|String||XmlElement()||
|+|RltdTradRef|String||XmlElement()||
|+|BlckInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClctnAgt),validPattern("""PmtClrCentr""",PmtClrCentr,"""[A-Z]{2,2}"""),validElement(AgrmtDtls),validElement(CtctInf),validElement(DealgBrnchCtrPtySd),validElement(DealgBrnchTradgSd),validElement(BrkrsComssn),validElement(BrkrId))|

---

## Value ISO20022.Fxtr014001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Fxtr014001.NDFOpeningFixing1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OpngConfRef|String||XmlElement()||
|+|OpngConds|ISO20022.Fxtr014001.OpeningConditions1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OpngConds),validChoice(OpngConfRef,OpngConds))|

---

## Value ISO20022.Fxtr014001.NameAndAddress8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Adr|ISO20022.Fxtr014001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validElement(Adr))|

---

## Value ISO20022.Fxtr014001.NonDeliverableForwardConditions1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OpngFxgConds|ISO20022.Fxtr014001.NDFOpeningFixing1Choice||XmlElement()||
|+|OpngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OpngFxgConds))|

---

## Value ISO20022.Fxtr014001.OpeningConditions1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmRateSrc|global::System.Collections.Generic.List<ISO20022.Fxtr014001.SettlementRateSource1>||XmlElement()||
|+|ValtnDt|DateTime||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SttlmRateSrc""",SttlmRateSrc),validList("""SttlmRateSrc""",SttlmRateSrc),validListMax("""SttlmRateSrc""",SttlmRateSrc,2),validElement(SttlmRateSrc),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr014001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Fxtr014001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Fxtr014001.PartyIdentification242Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyId|ISO20022.Fxtr014001.PartyIdentification266||XmlElement()||
|+|AnyBIC|ISO20022.Fxtr014001.PartyIdentification265||XmlElement()||
|+|NmAndAdr|ISO20022.Fxtr014001.NameAndAddress8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyId),validElement(AnyBIC),validElement(NmAndAdr),validChoice(PtyId,AnyBIC,NmAndAdr))|

---

## Value ISO20022.Fxtr014001.PartyIdentification265


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Fxtr014001.PartyIdentification266


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglNttyIdr|String||XmlElement()||
|+|ClrSysId|ISO20022.Fxtr014001.ClearingSystemIdentification2Choice||XmlElement()||
|+|Adr|String||XmlElement()||
|+|AcctNb|String||XmlElement()||
|+|AnyBIC|ISO20022.Fxtr014001.PartyIdentification265||XmlElement()||
|+|PtyNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysId),validElement(AnyBIC))|

---

## Value ISO20022.Fxtr014001.PartyIdentification60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglNttyIdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Fxtr014001.NameAndAddress8||XmlElement()||
|+|FndId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr))|

---

## Value ISO20022.Fxtr014001.PostTradeEvent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OutsdngSttlmAmt|ISO20022.Fxtr014001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrftOrLoss|ISO20022.Fxtr014001.ProfitAndLossAmount2||XmlElement()||
|+|PrftOrLossSttlmDt|DateTime||XmlElement()||
|+|UndrlygLbltyRef|String||XmlElement()||
|+|OrgnlRef|String||XmlElement()||
|+|Tp|ISO20022.Fxtr014001.PostTradeEventType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OutsdngSttlmAmt),validElement(PrftOrLoss),validElement(Tp))|

---

## Value ISO20022.Fxtr014001.PostTradeEventType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Fxtr014001.PostalAddress1


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

## Value ISO20022.Fxtr014001.ProductIdentifier3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnqPdctIdr|String||XmlElement()||
|+|UndrlygPdctIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(UnqPdctIdr,UndrlygPdctIdr))|

---

## Value ISO20022.Fxtr014001.ProfitAndLossAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Fxtr014001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Fxtr014001.RegulatoryReporting8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRptgInf|String||XmlElement()||
|+|ComssnsAndFees|global::System.Collections.Generic.List<ISO20022.Fxtr014001.FXCommissionOrFee1>||XmlElement()||
|+|ClrTmstmp|DateTime||XmlElement()||
|+|ConfDtAndTmstmp|DateTime||XmlElement()||
|+|FinInstrmId|ISO20022.Fxtr014001.SecurityIdentification19||XmlElement()||
|+|ComrclOrTrsrFincgInd|String||XmlElement()||
|+|NtrgrpTradInd|String||XmlElement()||
|+|TradWthNonEEACtrPtyInd|String||XmlElement()||
|+|CorpSctrInd|String||XmlElement()||
|+|PrtflCmprssnInd|String||XmlElement()||
|+|CollPrtflCd|String||XmlElement()||
|+|CollPrtflInd|String||XmlElement()||
|+|FinNtrOfTheCtrPtyInd|String||XmlElement()||
|+|LkSwpId|String||XmlElement()||
|+|NonStdFlg|String||XmlElement()||
|+|ExctnTmstmp|ISO20022.Fxtr014001.DateAndDateTime2Choice||XmlElement()||
|+|ExctnVn|String||XmlElement()||
|+|CollstnInd|String||XmlElement()||
|+|AllcnInd|String||XmlElement()||
|+|PdctIdr|ISO20022.Fxtr014001.ProductIdentifier3Choice||XmlElement()||
|+|ClrdPdctId|String||XmlElement()||
|+|ClrThrshldInd|String||XmlElement()||
|+|ClrBrkrId|ISO20022.Fxtr014001.ClearingBrokerIdentification1||XmlElement()||
|+|ClrXcptnPty|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|ClrBrkr|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|CntrlCtrPtyClrHs|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|CtrPtySdTxRptg|global::System.Collections.Generic.List<ISO20022.Fxtr014001.CounterpartySideTransactionReporting3>||XmlElement()||
|+|TradgSdTxRptg|global::System.Collections.Generic.List<ISO20022.Fxtr014001.TradingSideTransactionReporting3>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ComssnsAndFees""",ComssnsAndFees),validElement(ComssnsAndFees),validElement(FinInstrmId),validElement(ExctnTmstmp),validElement(PdctIdr),validElement(ClrBrkrId),validElement(ClrXcptnPty),validElement(ClrBrkr),validElement(CntrlCtrPtyClrHs),validList("""CtrPtySdTxRptg""",CtrPtySdTxRptg),validElement(CtrPtySdTxRptg),validList("""TradgSdTxRptg""",TradgSdTxRptg),validElement(TradgSdTxRptg))|

---

## Value ISO20022.Fxtr014001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Fxtr014001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Fxtr014001.SettlementParties120


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BnfcryInstn|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|RcvgAgt|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|Intrmy|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|DlvryAgt|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BnfcryInstn),validElement(RcvgAgt),validElement(Intrmy),validElement(DlvryAgt))|

---

## Value ISO20022.Fxtr014001.SettlementRateSource1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LctnCd|String||XmlElement()||
|+|CtryCd|String||XmlElement()||
|+|Tm|String||XmlElement()||
|+|RateSrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LctnCd""",LctnCd,"""[a-zA-Z0-9]{2}"""),validPattern("""CtryCd""",CtryCd,"""[A-Z]{2,2}"""),validPattern("""Tm""",Tm,"""[0-9]{4}"""),validPattern("""RateSrc""",RateSrc,"""[a-zA-Z]{3}[0-9]{1,2}"""))|

---

## Enum ISO20022.Fxtr014001.SideIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLNT|Int32||XmlEnum("""CLNT""")|1|
||CCPL|Int32||XmlEnum("""CCPL""")|2|

---

## Value ISO20022.Fxtr014001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Fxtr014001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Fxtr014001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr014001.TradeAgreement14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtVrssPmtInd|String||XmlElement()||
|+|SttlmSsnIdr|String||XmlElement()||
|+|PdctTp|String||XmlElement()||
|+|OprScp|String||XmlElement()||
|+|OprTp|String||XmlElement()||
|+|CmonRef|String||XmlElement()||
|+|OrgtrRef|String||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Fxtr014001.TradePartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FndId|global::System.Collections.Generic.List<ISO20022.Fxtr014001.FundIdentification5>||XmlElement()||
|+|TradPty|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|SubmitgPty|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FndId""",FndId),validElement(FndId),validElement(TradPty),validElement(SubmitgPty))|

---

## Enum ISO20022.Fxtr014001.Trading1MethodCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BROK|Int32||XmlEnum("""BROK""")|1|
||PHON|Int32||XmlEnum("""PHON""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|

---

## Value ISO20022.Fxtr014001.TradingSideTransactionReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgSdUnqTxIdr|global::System.Collections.Generic.List<ISO20022.Fxtr014001.UniqueTransactionIdentifier3>||XmlElement()||
|+|RptgPty|ISO20022.Fxtr014001.PartyIdentification242Choice||XmlElement()||
|+|RptgJursdctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TradgSdUnqTxIdr""",TradgSdUnqTxIdr),validElement(TradgSdUnqTxIdr),validElement(RptgPty))|

---

## Enum ISO20022.Fxtr014001.UnderlyingProductIdentifier1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SWAP|Int32||XmlEnum("""SWAP""")|1|
||SPOT|Int32||XmlEnum("""SPOT""")|2|
||NDFO|Int32||XmlEnum("""NDFO""")|3|
||FORW|Int32||XmlEnum("""FORW""")|4|

---

## Value ISO20022.Fxtr014001.UniqueTransactionIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrrUnqTxIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrrUnqTxIdr""",PrrUnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

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

