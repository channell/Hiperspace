# auth.105.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth105001.ActiveOrHistoricCurrencyAnd20DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth105001.AmountAndDirection107 {
        + Sgn  : String
        + Amt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth105001.AmountAndDirection107 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth105001.AmountAndDirection53 {
        + Sgn  : String
        + Amt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth105001.AmountAndDirection53 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth105001.CollateralData33 {
        + RinvstdCsh  : ISO20022.Auth105001.ReinvestedCashTypeAndAmount2
        + RcncltnFlg  : ISO20022.Auth105001.ReconciliationFlag2
        + TradRpstry  : ISO20022.Auth105001.OrganisationIdentification15Choice
        + Tp  : ISO20022.Auth105001.SecuritiesLendingType3Choice
        + IssrJursdctn  : ISO20022.Auth105001.IssuerJurisdiction1Choice
        + Mtrty  : ISO20022.Auth105001.ContractTerm6Choice
        + Qlty  : String
        + PricCcy  : String
        + CshCollCcy  : String
        + CmpntTp  : String
        + NetXpsrCollstnInd  : String
    }
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.ReinvestedCashTypeAndAmount2
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.ReconciliationFlag2
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.SecuritiesLendingType3Choice
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.IssuerJurisdiction1Choice
    ISO20022.Auth105001.CollateralData33 *-- ISO20022.Auth105001.ContractTerm6Choice
    class ISO20022.Auth105001.CollateralQualityType1Code {
        NOAP = 1
        NOTR = 2
        NIVG = 3
        INVG = 4
    }
    class ISO20022.Auth105001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Auth105001.CollateralType6Code {
        STCF = 1
        SECU = 2
        PHYS = 3
        OTHR = 4
        LCRE = 5
        INSU = 6
        COMM = 7
        CASH = 8
        BOND = 9
        GBBK = 10
    }
    class ISO20022.Auth105001.ContractTerm6Choice {
        + Fxd  : ISO20022.Auth105001.TimeToMaturity2Choice
        + Opn  : String
    }
    ISO20022.Auth105001.ContractTerm6Choice *-- ISO20022.Auth105001.TimeToMaturity2Choice
    class ISO20022.Auth105001.CounterpartyData86 {
        + AgtLndr  : String
        + TrptyAgt  : String
        + OthrCtrPty  : ISO20022.Auth105001.OrganisationIdentification15Choice
        + RptgCtrPty  : ISO20022.Auth105001.CounterpartyIdentification10
    }
    ISO20022.Auth105001.CounterpartyData86 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    ISO20022.Auth105001.CounterpartyData86 *-- ISO20022.Auth105001.CounterpartyIdentification10
    class ISO20022.Auth105001.CounterpartyIdentification10 {
        + Sd  : String
        + Id  : ISO20022.Auth105001.OrganisationIdentification15Choice
    }
    ISO20022.Auth105001.CounterpartyIdentification10 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    class ISO20022.Auth105001.ExposureMetrics4 {
        + CollMktVal  : ISO20022.Auth105001.AmountAndDirection53
        + CshCollAmt  : ISO20022.Auth105001.AmountAndDirection53
        + MrgnLn  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + ShrtMktValAmt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + OutsdngMrgnLnAmt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + MktVal  : ISO20022.Auth105001.AmountAndDirection53
        + LnVal  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + PrncplAmt  : ISO20022.Auth105001.PrincipalAmount3
    }
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.AmountAndDirection53
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.AmountAndDirection53
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.AmountAndDirection53
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.ExposureMetrics4 *-- ISO20022.Auth105001.PrincipalAmount3
    class ISO20022.Auth105001.ExposureMetrics5 {
        + CollMktVal  : ISO20022.Auth105001.AmountAndDirection53
        + CshCollAmt  : ISO20022.Auth105001.AmountAndDirection53
    }
    ISO20022.Auth105001.ExposureMetrics5 *-- ISO20022.Auth105001.AmountAndDirection53
    ISO20022.Auth105001.ExposureMetrics5 *-- ISO20022.Auth105001.AmountAndDirection53
    class ISO20022.Auth105001.ExposureMetrics6 {
        + PstdMrgnOrColl  : ISO20022.Auth105001.PostedMarginOrCollateral4
    }
    ISO20022.Auth105001.ExposureMetrics6 *-- ISO20022.Auth105001.PostedMarginOrCollateral4
    class ISO20022.Auth105001.ExposureType10Code {
        REPO = 1
        SLEB = 2
        MGLD = 3
        SBSC = 4
    }
    class ISO20022.Auth105001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth105001.IssuerJurisdiction1Choice {
        + Othr  : String
        + CtryCd  : String
    }
    class ISO20022.Auth105001.LoanData134 {
        + OutsdngMrgnLnCcy  : String
        + Scty  : ISO20022.Auth105001.Security49
        + PricCcy  : String
        + PrncplAmtCcy  : String
        + Rates  : ISO20022.Auth105001.Rates1Choice
        + Term  : ISO20022.Auth105001.ContractTerm6Choice
        + GnlColl  : String
        + MtrtyDt  : DateTime
        + MstrAgrmtTp  : String
        + TradgVn  : ISO20022.Auth105001.TradingVenueType1Choice
        + PrtflCd  : String
        + Clrd  : String
        + CtrctTp  : String
    }
    ISO20022.Auth105001.LoanData134 *-- ISO20022.Auth105001.Security49
    ISO20022.Auth105001.LoanData134 *-- ISO20022.Auth105001.Rates1Choice
    ISO20022.Auth105001.LoanData134 *-- ISO20022.Auth105001.ContractTerm6Choice
    ISO20022.Auth105001.LoanData134 *-- ISO20022.Auth105001.TradingVenueType1Choice
    class ISO20022.Auth105001.MaturityTerm2 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth105001.NamedPosition3 {
        + Reuse  : global::System.Collections.Generic.List~ISO20022.Auth105001.PositionSet19~
        + Mrgn  : global::System.Collections.Generic.List~ISO20022.Auth105001.PositionSet20~
        + Coll  : global::System.Collections.Generic.List~ISO20022.Auth105001.PositionSet18~
        + Ln  : global::System.Collections.Generic.List~ISO20022.Auth105001.PositionSet17~
        + GnlInf  : global::System.Collections.Generic.List~ISO20022.Auth105001.PositionSet16~
        + RefDt  : DateTime
    }
    ISO20022.Auth105001.NamedPosition3 *-- ISO20022.Auth105001.PositionSet19
    ISO20022.Auth105001.NamedPosition3 *-- ISO20022.Auth105001.PositionSet20
    ISO20022.Auth105001.NamedPosition3 *-- ISO20022.Auth105001.PositionSet18
    ISO20022.Auth105001.NamedPosition3 *-- ISO20022.Auth105001.PositionSet17
    ISO20022.Auth105001.NamedPosition3 *-- ISO20022.Auth105001.PositionSet16
    class ISO20022.Auth105001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth105001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth105001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth105001.OrganisationIdentification15Choice *-- ISO20022.Auth105001.OrganisationIdentification38
    class ISO20022.Auth105001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth105001.GenericIdentification175
    }
    ISO20022.Auth105001.OrganisationIdentification38 *-- ISO20022.Auth105001.GenericIdentification175
    class ISO20022.Auth105001.PositionSet16 {
        + Mtrcs  : ISO20022.Auth105001.PositionSetMetrics7
        + Dmnsns  : ISO20022.Auth105001.PositionSetDimensions14
    }
    ISO20022.Auth105001.PositionSet16 *-- ISO20022.Auth105001.PositionSetMetrics7
    ISO20022.Auth105001.PositionSet16 *-- ISO20022.Auth105001.PositionSetDimensions14
    class ISO20022.Auth105001.PositionSet17 {
        + Mtrcs  : ISO20022.Auth105001.PositionSetMetrics13
        + Dmnsns  : ISO20022.Auth105001.PositionSetDimensions14
    }
    ISO20022.Auth105001.PositionSet17 *-- ISO20022.Auth105001.PositionSetMetrics13
    ISO20022.Auth105001.PositionSet17 *-- ISO20022.Auth105001.PositionSetDimensions14
    class ISO20022.Auth105001.PositionSet18 {
        + Mtrcs  : ISO20022.Auth105001.PositionSetMetrics12
        + Dmnsns  : ISO20022.Auth105001.PositionSetDimensions14
    }
    ISO20022.Auth105001.PositionSet18 *-- ISO20022.Auth105001.PositionSetMetrics12
    ISO20022.Auth105001.PositionSet18 *-- ISO20022.Auth105001.PositionSetDimensions14
    class ISO20022.Auth105001.PositionSet19 {
        + Mtrcs  : ISO20022.Auth105001.PositionSetMetrics11
        + Dmnsns  : ISO20022.Auth105001.PositionSetDimensions12
    }
    ISO20022.Auth105001.PositionSet19 *-- ISO20022.Auth105001.PositionSetMetrics11
    ISO20022.Auth105001.PositionSet19 *-- ISO20022.Auth105001.PositionSetDimensions12
    class ISO20022.Auth105001.PositionSet20 {
        + Mtrcs  : ISO20022.Auth105001.PositionSetMetrics10
        + Dmnsns  : ISO20022.Auth105001.PositionSetDimensions15
    }
    ISO20022.Auth105001.PositionSet20 *-- ISO20022.Auth105001.PositionSetMetrics10
    ISO20022.Auth105001.PositionSet20 *-- ISO20022.Auth105001.PositionSetDimensions15
    class ISO20022.Auth105001.PositionSetDimensions12 {
        + OtlrsIncl  : String
        + CollData  : ISO20022.Auth105001.CollateralData33
        + RptgCtrPty  : ISO20022.Auth105001.OrganisationIdentification15Choice
    }
    ISO20022.Auth105001.PositionSetDimensions12 *-- ISO20022.Auth105001.CollateralData33
    ISO20022.Auth105001.PositionSetDimensions12 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    class ISO20022.Auth105001.PositionSetDimensions14 {
        + OtlrsIncl  : String
        + CollData  : ISO20022.Auth105001.CollateralData33
        + LnData  : ISO20022.Auth105001.LoanData134
        + CtrPtyData  : ISO20022.Auth105001.CounterpartyData86
    }
    ISO20022.Auth105001.PositionSetDimensions14 *-- ISO20022.Auth105001.CollateralData33
    ISO20022.Auth105001.PositionSetDimensions14 *-- ISO20022.Auth105001.LoanData134
    ISO20022.Auth105001.PositionSetDimensions14 *-- ISO20022.Auth105001.CounterpartyData86
    class ISO20022.Auth105001.PositionSetDimensions15 {
        + OtlrsIncl  : String
        + CollPrtflId  : String
        + OthrCtrPty  : ISO20022.Auth105001.OrganisationIdentification15Choice
        + RptgCtrPty  : ISO20022.Auth105001.OrganisationIdentification15Choice
    }
    ISO20022.Auth105001.PositionSetDimensions15 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    ISO20022.Auth105001.PositionSetDimensions15 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    class ISO20022.Auth105001.PositionSetMetrics10 {
        + VolMtrcs  : ISO20022.Auth105001.ExposureMetrics6
    }
    ISO20022.Auth105001.PositionSetMetrics10 *-- ISO20022.Auth105001.ExposureMetrics6
    class ISO20022.Auth105001.PositionSetMetrics11 {
        + CshRinvstmtRate  : Decimal
        + VolMtrcs  : ISO20022.Auth105001.VolumeMetrics4
    }
    ISO20022.Auth105001.PositionSetMetrics11 *-- ISO20022.Auth105001.VolumeMetrics4
    class ISO20022.Auth105001.PositionSetMetrics12 {
        + QtyOrNmnlAmt  : ISO20022.Auth105001.QuantityNominalValue2Choice
        + HrcutOrMrgn  : Decimal
        + VolMtrcs  : ISO20022.Auth105001.VolumeMetrics6
    }
    ISO20022.Auth105001.PositionSetMetrics12 *-- ISO20022.Auth105001.QuantityNominalValue2Choice
    ISO20022.Auth105001.PositionSetMetrics12 *-- ISO20022.Auth105001.VolumeMetrics6
    class ISO20022.Auth105001.PositionSetMetrics13 {
        + PricMtrcs  : ISO20022.Auth105001.PriceMetrics3
        + VolMtrcs  : ISO20022.Auth105001.VolumeMetrics5
    }
    ISO20022.Auth105001.PositionSetMetrics13 *-- ISO20022.Auth105001.PriceMetrics3
    ISO20022.Auth105001.PositionSetMetrics13 *-- ISO20022.Auth105001.VolumeMetrics5
    class ISO20022.Auth105001.PositionSetMetrics7 {
        + VolMtrcs  : ISO20022.Auth105001.VolumeMetrics5
    }
    ISO20022.Auth105001.PositionSetMetrics7 *-- ISO20022.Auth105001.VolumeMetrics5
    class ISO20022.Auth105001.PositionSetReport3Choice {
        + Rpt  : ISO20022.Auth105001.NamedPosition3
        + DataSetActn  : String
    }
    ISO20022.Auth105001.PositionSetReport3Choice *-- ISO20022.Auth105001.NamedPosition3
    class ISO20022.Auth105001.PostedMarginOrCollateral4 {
        + XcssCollPstd  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + VartnMrgnPstd  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + InitlMrgnPstd  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth105001.PostedMarginOrCollateral4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.PostedMarginOrCollateral4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.PostedMarginOrCollateral4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth105001.PriceMetrics3 {
        + LndgFee  : Decimal
        + Rates  : ISO20022.Auth105001.Rates3
    }
    ISO20022.Auth105001.PriceMetrics3 *-- ISO20022.Auth105001.Rates3
    class ISO20022.Auth105001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth105001.PrincipalAmount3 {
        + MtrtyDtAmt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + ValDtAmt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth105001.PrincipalAmount3 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.PrincipalAmount3 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth105001.QuantityNominalValue2Choice {
        + NmnlVal  : ISO20022.Auth105001.AmountAndDirection53
        + Qty  : Decimal
    }
    ISO20022.Auth105001.QuantityNominalValue2Choice *-- ISO20022.Auth105001.AmountAndDirection53
    class ISO20022.Auth105001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth105001.Rates1Choice {
        + Fltg  : String
        + Fxd  : String
    }
    class ISO20022.Auth105001.Rates3 {
        + BuySellBck  : ISO20022.Auth105001.SecuritiesTransactionPrice18Choice
        + Fltg  : Decimal
        + Fxd  : Decimal
    }
    ISO20022.Auth105001.Rates3 *-- ISO20022.Auth105001.SecuritiesTransactionPrice18Choice
    class ISO20022.Auth105001.ReconciliationFlag2 {
        + ModSts  : String
        + CollRcncltnSts  : String
        + LnRcncltnSts  : String
        + PairdSts  : String
        + BothCtrPtiesRptg  : String
        + RptTp  : String
    }
    class ISO20022.Auth105001.ReinvestedCashTypeAndAmount2 {
        + RinvstdCshCcy  : String
        + Tp  : String
    }
    class ISO20022.Auth105001.ReinvestmentType1Code {
        SDPU = 1
        REPM = 2
        MMFT = 3
        OCMP = 4
        OTHR = 5
    }
    class ISO20022.Auth105001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth105001.ReuseValue1Choice {
        + Estmtd  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + Actl  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth105001.ReuseValue1Choice *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.ReuseValue1Choice *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth105001.SecuritiesFinancingReportingPositionSetReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth105001.SupplementaryData1~
        + AggtdPoss  : ISO20022.Auth105001.PositionSetReport3Choice
    }
    ISO20022.Auth105001.SecuritiesFinancingReportingPositionSetReportV01 *-- ISO20022.Auth105001.SupplementaryData1
    ISO20022.Auth105001.SecuritiesFinancingReportingPositionSetReportV01 *-- ISO20022.Auth105001.PositionSetReport3Choice
    class ISO20022.Auth105001.SecuritiesLendingType3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth105001.SecuritiesTransactionPrice18Choice {
        + BsisPts  : Decimal
        + Dcml  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth105001.AmountAndDirection107
    }
    ISO20022.Auth105001.SecuritiesTransactionPrice18Choice *-- ISO20022.Auth105001.AmountAndDirection107
    class ISO20022.Auth105001.SecuritiesTransactionPrice19Choice {
        + Othr  : ISO20022.Auth105001.SecuritiesTransactionPrice5
        + PdgPric  : String
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth105001.AmountAndDirection107
    }
    ISO20022.Auth105001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth105001.SecuritiesTransactionPrice5
    ISO20022.Auth105001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth105001.AmountAndDirection107
    class ISO20022.Auth105001.SecuritiesTransactionPrice5 {
        + Tp  : String
        + Val  : Decimal
    }
    class ISO20022.Auth105001.Security49 {
        + ExclsvArrgmnt  : String
        + Tp  : global::System.Collections.Generic.List~ISO20022.Auth105001.SecuritiesLendingType3Choice~
        + Issr  : ISO20022.Auth105001.SecurityIssuer4
        + Mtrty  : DateTime
        + Qlty  : String
        + MktVal  : ISO20022.Auth105001.AmountAndDirection53
        + UnitPric  : ISO20022.Auth105001.SecuritiesTransactionPrice19Choice
        + QtyOrNmnlVal  : ISO20022.Auth105001.QuantityNominalValue2Choice
        + ClssfctnTp  : String
        + Id  : String
    }
    ISO20022.Auth105001.Security49 *-- ISO20022.Auth105001.SecuritiesLendingType3Choice
    ISO20022.Auth105001.Security49 *-- ISO20022.Auth105001.SecurityIssuer4
    ISO20022.Auth105001.Security49 *-- ISO20022.Auth105001.AmountAndDirection53
    ISO20022.Auth105001.Security49 *-- ISO20022.Auth105001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth105001.Security49 *-- ISO20022.Auth105001.QuantityNominalValue2Choice
    class ISO20022.Auth105001.SecurityIssuer4 {
        + JursdctnCtry  : String
        + Id  : ISO20022.Auth105001.OrganisationIdentification15Choice
    }
    ISO20022.Auth105001.SecurityIssuer4 *-- ISO20022.Auth105001.OrganisationIdentification15Choice
    class ISO20022.Auth105001.SpecialCollateral1Code {
        SPEC = 1
        GENE = 2
    }
    class ISO20022.Auth105001.SpecialPurpose2Code {
        NTAV = 1
        BLNK = 2
    }
    class ISO20022.Auth105001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth105001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth105001.SupplementaryData1 *-- ISO20022.Auth105001.SupplementaryDataEnvelope1
    class ISO20022.Auth105001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth105001.TimeToMaturity2Choice {
        + Spcl  : String
        + Prd  : ISO20022.Auth105001.TimeToMaturityPeriod2
    }
    ISO20022.Auth105001.TimeToMaturity2Choice *-- ISO20022.Auth105001.TimeToMaturityPeriod2
    class ISO20022.Auth105001.TimeToMaturityPeriod2 {
        + End  : ISO20022.Auth105001.MaturityTerm2
        + Start  : ISO20022.Auth105001.MaturityTerm2
    }
    ISO20022.Auth105001.TimeToMaturityPeriod2 *-- ISO20022.Auth105001.MaturityTerm2
    ISO20022.Auth105001.TimeToMaturityPeriod2 *-- ISO20022.Auth105001.MaturityTerm2
    class ISO20022.Auth105001.TradeMarket2Code {
        FRGN = 1
        DMST = 2
    }
    class ISO20022.Auth105001.TradeRepositoryReportingType1Code {
        TWOS = 1
        SWOS = 2
    }
    class ISO20022.Auth105001.TradingVenueType1Choice {
        + OffVn  : String
        + OnVn  : String
    }
    class ISO20022.Auth105001.VolumeMetrics4 {
        + RinvstdCshAmt  : ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
        + ReuseVal  : ISO20022.Auth105001.ReuseValue1Choice
    }
    ISO20022.Auth105001.VolumeMetrics4 *-- ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth105001.VolumeMetrics4 *-- ISO20022.Auth105001.ReuseValue1Choice
    class ISO20022.Auth105001.VolumeMetrics5 {
        + Xpsr  : ISO20022.Auth105001.ExposureMetrics4
        + NbOfTxs  : String
    }
    ISO20022.Auth105001.VolumeMetrics5 *-- ISO20022.Auth105001.ExposureMetrics4
    class ISO20022.Auth105001.VolumeMetrics6 {
        + Neg  : ISO20022.Auth105001.ExposureMetrics5
        + Postv  : ISO20022.Auth105001.ExposureMetrics5
    }
    ISO20022.Auth105001.VolumeMetrics6 *-- ISO20022.Auth105001.ExposureMetrics5
    ISO20022.Auth105001.VolumeMetrics6 *-- ISO20022.Auth105001.ExposureMetrics5
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

## Value ISO20022.Auth105001.ActiveOrHistoricCurrencyAnd20DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth105001.AmountAndDirection107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth105001.AmountAndDirection53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth105001.CollateralData33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RinvstdCsh|ISO20022.Auth105001.ReinvestedCashTypeAndAmount2||XmlElement()||
|+|RcncltnFlg|ISO20022.Auth105001.ReconciliationFlag2||XmlElement()||
|+|TradRpstry|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
|+|Tp|ISO20022.Auth105001.SecuritiesLendingType3Choice||XmlElement()||
|+|IssrJursdctn|ISO20022.Auth105001.IssuerJurisdiction1Choice||XmlElement()||
|+|Mtrty|ISO20022.Auth105001.ContractTerm6Choice||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|PricCcy|String||XmlElement()||
|+|CshCollCcy|String||XmlElement()||
|+|CmpntTp|String||XmlElement()||
|+|NetXpsrCollstnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RinvstdCsh),validElement(RcncltnFlg),validElement(TradRpstry),validElement(Tp),validElement(IssrJursdctn),validElement(Mtrty),validPattern("""PricCcy""",PricCcy,"""[A-Z]{3,3}"""),validPattern("""CshCollCcy""",CshCollCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Auth105001.CollateralQualityType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||NOTR|Int32||XmlEnum("""NOTR""")|2|
||NIVG|Int32||XmlEnum("""NIVG""")|3|
||INVG|Int32||XmlEnum("""INVG""")|4|

---

## Enum ISO20022.Auth105001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Enum ISO20022.Auth105001.CollateralType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STCF|Int32||XmlEnum("""STCF""")|1|
||SECU|Int32||XmlEnum("""SECU""")|2|
||PHYS|Int32||XmlEnum("""PHYS""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||LCRE|Int32||XmlEnum("""LCRE""")|5|
||INSU|Int32||XmlEnum("""INSU""")|6|
||COMM|Int32||XmlEnum("""COMM""")|7|
||CASH|Int32||XmlEnum("""CASH""")|8|
||BOND|Int32||XmlEnum("""BOND""")|9|
||GBBK|Int32||XmlEnum("""GBBK""")|10|

---

## Value ISO20022.Auth105001.ContractTerm6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fxd|ISO20022.Auth105001.TimeToMaturity2Choice||XmlElement()||
|+|Opn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fxd),validChoice(Fxd,Opn))|

---

## Value ISO20022.Auth105001.CounterpartyData86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtLndr|String||XmlElement()||
|+|TrptyAgt|String||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth105001.CounterpartyIdentification10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth105001.CounterpartyIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sd|String||XmlElement()||
|+|Id|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Type ISO20022.Auth105001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgRptgPosSetRpt|ISO20022.Auth105001.SecuritiesFinancingReportingPositionSetReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgRptgPosSetRpt))|

---

## Value ISO20022.Auth105001.ExposureMetrics4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollMktVal|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|CshCollAmt|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|MrgnLn|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ShrtMktValAmt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OutsdngMrgnLnAmt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|MktVal|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|LnVal|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrncplAmt|ISO20022.Auth105001.PrincipalAmount3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollMktVal),validElement(CshCollAmt),validElement(MrgnLn),validElement(ShrtMktValAmt),validElement(OutsdngMrgnLnAmt),validElement(MktVal),validElement(LnVal),validElement(PrncplAmt))|

---

## Value ISO20022.Auth105001.ExposureMetrics5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollMktVal|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|CshCollAmt|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollMktVal),validElement(CshCollAmt))|

---

## Value ISO20022.Auth105001.ExposureMetrics6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstdMrgnOrColl|ISO20022.Auth105001.PostedMarginOrCollateral4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstdMrgnOrColl))|

---

## Enum ISO20022.Auth105001.ExposureType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPO|Int32||XmlEnum("""REPO""")|1|
||SLEB|Int32||XmlEnum("""SLEB""")|2|
||MGLD|Int32||XmlEnum("""MGLD""")|3|
||SBSC|Int32||XmlEnum("""SBSC""")|4|

---

## Value ISO20022.Auth105001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth105001.IssuerJurisdiction1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|CtryCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[A-Z]{2,2}"""),validChoice(Othr,CtryCd))|

---

## Value ISO20022.Auth105001.LoanData134


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OutsdngMrgnLnCcy|String||XmlElement()||
|+|Scty|ISO20022.Auth105001.Security49||XmlElement()||
|+|PricCcy|String||XmlElement()||
|+|PrncplAmtCcy|String||XmlElement()||
|+|Rates|ISO20022.Auth105001.Rates1Choice||XmlElement()||
|+|Term|ISO20022.Auth105001.ContractTerm6Choice||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|MstrAgrmtTp|String||XmlElement()||
|+|TradgVn|ISO20022.Auth105001.TradingVenueType1Choice||XmlElement()||
|+|PrtflCd|String||XmlElement()||
|+|Clrd|String||XmlElement()||
|+|CtrctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OutsdngMrgnLnCcy""",OutsdngMrgnLnCcy,"""[A-Z]{3,3}"""),validElement(Scty),validPattern("""PricCcy""",PricCcy,"""[A-Z]{3,3}"""),validPattern("""PrncplAmtCcy""",PrncplAmtCcy,"""[A-Z]{3,3}"""),validElement(Rates),validElement(Term),validElement(TradgVn))|

---

## Value ISO20022.Auth105001.MaturityTerm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth105001.NamedPosition3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Reuse|global::System.Collections.Generic.List<ISO20022.Auth105001.PositionSet19>||XmlElement()||
|+|Mrgn|global::System.Collections.Generic.List<ISO20022.Auth105001.PositionSet20>||XmlElement()||
|+|Coll|global::System.Collections.Generic.List<ISO20022.Auth105001.PositionSet18>||XmlElement()||
|+|Ln|global::System.Collections.Generic.List<ISO20022.Auth105001.PositionSet17>||XmlElement()||
|+|GnlInf|global::System.Collections.Generic.List<ISO20022.Auth105001.PositionSet16>||XmlElement()||
|+|RefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Reuse""",Reuse),validElement(Reuse),validList("""Mrgn""",Mrgn),validElement(Mrgn),validList("""Coll""",Coll),validElement(Coll),validList("""Ln""",Ln),validElement(Ln),validList("""GnlInf""",GnlInf),validElement(GnlInf))|

---

## Enum ISO20022.Auth105001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Auth105001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth105001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth105001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth105001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth105001.PositionSet16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth105001.PositionSetMetrics7||XmlElement()||
|+|Dmnsns|ISO20022.Auth105001.PositionSetDimensions14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth105001.PositionSet17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth105001.PositionSetMetrics13||XmlElement()||
|+|Dmnsns|ISO20022.Auth105001.PositionSetDimensions14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth105001.PositionSet18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth105001.PositionSetMetrics12||XmlElement()||
|+|Dmnsns|ISO20022.Auth105001.PositionSetDimensions14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth105001.PositionSet19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth105001.PositionSetMetrics11||XmlElement()||
|+|Dmnsns|ISO20022.Auth105001.PositionSetDimensions12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth105001.PositionSet20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mtrcs|ISO20022.Auth105001.PositionSetMetrics10||XmlElement()||
|+|Dmnsns|ISO20022.Auth105001.PositionSetDimensions15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mtrcs),validElement(Dmnsns))|

---

## Value ISO20022.Auth105001.PositionSetDimensions12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OtlrsIncl|String||XmlElement()||
|+|CollData|ISO20022.Auth105001.CollateralData33||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollData),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth105001.PositionSetDimensions14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OtlrsIncl|String||XmlElement()||
|+|CollData|ISO20022.Auth105001.CollateralData33||XmlElement()||
|+|LnData|ISO20022.Auth105001.LoanData134||XmlElement()||
|+|CtrPtyData|ISO20022.Auth105001.CounterpartyData86||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollData),validElement(LnData),validElement(CtrPtyData))|

---

## Value ISO20022.Auth105001.PositionSetDimensions15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OtlrsIncl|String||XmlElement()||
|+|CollPrtflId|String||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth105001.PositionSetMetrics10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VolMtrcs|ISO20022.Auth105001.ExposureMetrics6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VolMtrcs))|

---

## Value ISO20022.Auth105001.PositionSetMetrics11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshRinvstmtRate|Decimal||XmlElement()||
|+|VolMtrcs|ISO20022.Auth105001.VolumeMetrics4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VolMtrcs))|

---

## Value ISO20022.Auth105001.PositionSetMetrics12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyOrNmnlAmt|ISO20022.Auth105001.QuantityNominalValue2Choice||XmlElement()||
|+|HrcutOrMrgn|Decimal||XmlElement()||
|+|VolMtrcs|ISO20022.Auth105001.VolumeMetrics6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyOrNmnlAmt),validElement(VolMtrcs))|

---

## Value ISO20022.Auth105001.PositionSetMetrics13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricMtrcs|ISO20022.Auth105001.PriceMetrics3||XmlElement()||
|+|VolMtrcs|ISO20022.Auth105001.VolumeMetrics5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricMtrcs),validElement(VolMtrcs))|

---

## Value ISO20022.Auth105001.PositionSetMetrics7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VolMtrcs|ISO20022.Auth105001.VolumeMetrics5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VolMtrcs))|

---

## Value ISO20022.Auth105001.PositionSetReport3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth105001.NamedPosition3||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth105001.PostedMarginOrCollateral4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollPstd|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|VartnMrgnPstd|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|InitlMrgnPstd|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollPstd),validElement(VartnMrgnPstd),validElement(InitlMrgnPstd))|

---

## Value ISO20022.Auth105001.PriceMetrics3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LndgFee|Decimal||XmlElement()||
|+|Rates|ISO20022.Auth105001.Rates3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rates))|

---

## Enum ISO20022.Auth105001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Value ISO20022.Auth105001.PrincipalAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtrtyDtAmt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValDtAmt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtrtyDtAmt),validElement(ValDtAmt))|

---

## Value ISO20022.Auth105001.QuantityNominalValue2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmnlVal|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmnlVal),validChoice(NmnlVal,Qty))|

---

## Enum ISO20022.Auth105001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth105001.Rates1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|String||XmlElement()||
|+|Fxd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth105001.Rates3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BuySellBck|ISO20022.Auth105001.SecuritiesTransactionPrice18Choice||XmlElement()||
|+|Fltg|Decimal||XmlElement()||
|+|Fxd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BuySellBck))|

---

## Value ISO20022.Auth105001.ReconciliationFlag2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModSts|String||XmlElement()||
|+|CollRcncltnSts|String||XmlElement()||
|+|LnRcncltnSts|String||XmlElement()||
|+|PairdSts|String||XmlElement()||
|+|BothCtrPtiesRptg|String||XmlElement()||
|+|RptTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth105001.ReinvestedCashTypeAndAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RinvstdCshCcy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RinvstdCshCcy""",RinvstdCshCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Auth105001.ReinvestmentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SDPU|Int32||XmlEnum("""SDPU""")|1|
||REPM|Int32||XmlEnum("""REPM""")|2|
||MMFT|Int32||XmlEnum("""MMFT""")|3|
||OCMP|Int32||XmlEnum("""OCMP""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|

---

## Enum ISO20022.Auth105001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth105001.ReuseValue1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Estmtd|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Actl|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Estmtd),validElement(Actl),validChoice(Estmtd,Actl))|

---

## Aspect ISO20022.Auth105001.SecuritiesFinancingReportingPositionSetReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth105001.SupplementaryData1>||XmlElement()||
|+|AggtdPoss|ISO20022.Auth105001.PositionSetReport3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AggtdPoss))|

---

## Value ISO20022.Auth105001.SecuritiesLendingType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth105001.SecuritiesTransactionPrice18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPts|Decimal||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth105001.AmountAndDirection107||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPts,Dcml,Pctg,MntryVal))|

---

## Value ISO20022.Auth105001.SecuritiesTransactionPrice19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth105001.SecuritiesTransactionPrice5||XmlElement()||
|+|PdgPric|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth105001.AmountAndDirection107||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,PdgPric,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth105001.SecuritiesTransactionPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth105001.Security49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExclsvArrgmnt|String||XmlElement()||
|+|Tp|global::System.Collections.Generic.List<ISO20022.Auth105001.SecuritiesLendingType3Choice>||XmlElement()||
|+|Issr|ISO20022.Auth105001.SecurityIssuer4||XmlElement()||
|+|Mtrty|DateTime||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|MktVal|ISO20022.Auth105001.AmountAndDirection53||XmlElement()||
|+|UnitPric|ISO20022.Auth105001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|QtyOrNmnlVal|ISO20022.Auth105001.QuantityNominalValue2Choice||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tp""",Tp),validElement(Tp),validElement(Issr),validElement(MktVal),validElement(UnitPric),validElement(QtyOrNmnlVal),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth105001.SecurityIssuer4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|JursdctnCtry|String||XmlElement()||
|+|Id|ISO20022.Auth105001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""JursdctnCtry""",JursdctnCtry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth105001.SpecialCollateral1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPEC|Int32||XmlEnum("""SPEC""")|1|
||GENE|Int32||XmlEnum("""GENE""")|2|

---

## Enum ISO20022.Auth105001.SpecialPurpose2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTAV|Int32||XmlEnum("""NTAV""")|1|
||BLNK|Int32||XmlEnum("""BLNK""")|2|

---

## Value ISO20022.Auth105001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth105001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth105001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth105001.TimeToMaturity2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Spcl|String||XmlElement()||
|+|Prd|ISO20022.Auth105001.TimeToMaturityPeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validChoice(Spcl,Prd))|

---

## Value ISO20022.Auth105001.TimeToMaturityPeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|End|ISO20022.Auth105001.MaturityTerm2||XmlElement()||
|+|Start|ISO20022.Auth105001.MaturityTerm2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(End),validElement(Start))|

---

## Enum ISO20022.Auth105001.TradeMarket2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGN|Int32||XmlEnum("""FRGN""")|1|
||DMST|Int32||XmlEnum("""DMST""")|2|

---

## Enum ISO20022.Auth105001.TradeRepositoryReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TWOS|Int32||XmlEnum("""TWOS""")|1|
||SWOS|Int32||XmlEnum("""SWOS""")|2|

---

## Value ISO20022.Auth105001.TradingVenueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OffVn|String||XmlElement()||
|+|OnVn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OffVn,OnVn))|

---

## Value ISO20022.Auth105001.VolumeMetrics4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RinvstdCshAmt|ISO20022.Auth105001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ReuseVal|ISO20022.Auth105001.ReuseValue1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RinvstdCshAmt),validElement(ReuseVal))|

---

## Value ISO20022.Auth105001.VolumeMetrics5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xpsr|ISO20022.Auth105001.ExposureMetrics4||XmlElement()||
|+|NbOfTxs|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Xpsr),validPattern("""NbOfTxs""",NbOfTxs,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Auth105001.VolumeMetrics6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Neg|ISO20022.Auth105001.ExposureMetrics5||XmlElement()||
|+|Postv|ISO20022.Auth105001.ExposureMetrics5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Neg),validElement(Postv))|

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

