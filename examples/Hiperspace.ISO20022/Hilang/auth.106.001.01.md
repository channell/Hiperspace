# auth.106.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth106001.AbnormalValuesData4 {
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Auth106001.AbnormalValuesTransactionData2~
        + NbOfDerivsRptdWthOtlrs  : Decimal
        + NbOfDerivsRptd  : Decimal
        + CtrPtyId  : ISO20022.Auth106001.CounterpartyData92
    }
    ISO20022.Auth106001.AbnormalValuesData4 *-- ISO20022.Auth106001.AbnormalValuesTransactionData2
    ISO20022.Auth106001.AbnormalValuesData4 *-- ISO20022.Auth106001.CounterpartyData92
    class ISO20022.Auth106001.AbnormalValuesTransactionData2 {
        + NtnlQty  : ISO20022.Auth106001.NotionalQuantityLegs5
        + NtnlAmt  : ISO20022.Auth106001.NotionalAmountLegs5
        + TxId  : ISO20022.Auth106001.TradeTransactionIdentification24
    }
    ISO20022.Auth106001.AbnormalValuesTransactionData2 *-- ISO20022.Auth106001.NotionalQuantityLegs5
    ISO20022.Auth106001.AbnormalValuesTransactionData2 *-- ISO20022.Auth106001.NotionalAmountLegs5
    ISO20022.Auth106001.AbnormalValuesTransactionData2 *-- ISO20022.Auth106001.TradeTransactionIdentification24
    class ISO20022.Auth106001.ActiveOrHistoricCurrencyAnd19DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth106001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth106001.AmountAndDirection106 {
        + Sgn  : String
        + Amt  : ISO20022.Auth106001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth106001.AmountAndDirection106 *-- ISO20022.Auth106001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth106001.CollateralPortfolioCode5Choice {
        + MrgnPrtflCd  : ISO20022.Auth106001.MarginPortfolio3
        + Prtfl  : ISO20022.Auth106001.PortfolioCode3Choice
    }
    ISO20022.Auth106001.CollateralPortfolioCode5Choice *-- ISO20022.Auth106001.MarginPortfolio3
    ISO20022.Auth106001.CollateralPortfolioCode5Choice *-- ISO20022.Auth106001.PortfolioCode3Choice
    class ISO20022.Auth106001.CounterpartyData92 {
        + NttyRspnsblForRpt  : ISO20022.Auth106001.OrganisationIdentification15Choice
        + RptSubmitgNtty  : ISO20022.Auth106001.OrganisationIdentification15Choice
        + RptgCtrPty  : ISO20022.Auth106001.OrganisationIdentification15Choice
    }
    ISO20022.Auth106001.CounterpartyData92 *-- ISO20022.Auth106001.OrganisationIdentification15Choice
    ISO20022.Auth106001.CounterpartyData92 *-- ISO20022.Auth106001.OrganisationIdentification15Choice
    ISO20022.Auth106001.CounterpartyData92 *-- ISO20022.Auth106001.OrganisationIdentification15Choice
    class ISO20022.Auth106001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth106001.DerivativeEventType3Code {
        UPDT = 1
        TRAD = 2
        PTNG = 3
        NOVA = 4
        INCP = 5
        EXER = 6
        ETRM = 7
        CREV = 8
        CORP = 9
        COMP = 10
        CLAL = 11
        CLRG = 12
        ALOC = 13
    }
    class ISO20022.Auth106001.DerivativesTradeWarningsReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth106001.SupplementaryData1~
        + WrnngsSttstcs  : ISO20022.Auth106001.StatisticsPerCounterparty16Choice
    }
    ISO20022.Auth106001.DerivativesTradeWarningsReportV01 *-- ISO20022.Auth106001.SupplementaryData1
    ISO20022.Auth106001.DerivativesTradeWarningsReportV01 *-- ISO20022.Auth106001.StatisticsPerCounterparty16Choice
    class ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice {
        + Rpt  : ISO20022.Auth106001.DetailedTransactionStatistics28
        + DataSetActn  : String
    }
    ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice *-- ISO20022.Auth106001.DetailedTransactionStatistics28
    class ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice {
        + Rpt  : ISO20022.Auth106001.DetailedTransactionStatistics26
        + DataSetActn  : String
    }
    ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice *-- ISO20022.Auth106001.DetailedTransactionStatistics26
    class ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice {
        + Rpt  : ISO20022.Auth106001.DetailedTransactionStatistics27
        + DataSetActn  : String
    }
    ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice *-- ISO20022.Auth106001.DetailedTransactionStatistics27
    class ISO20022.Auth106001.DetailedStatisticsPerCounterparty17 {
        + AbnrmlVals  : ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice
        + MssngMrgnInf  : ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice
        + MssngValtn  : ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice
        + RefDt  : DateTime
    }
    ISO20022.Auth106001.DetailedStatisticsPerCounterparty17 *-- ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice
    ISO20022.Auth106001.DetailedStatisticsPerCounterparty17 *-- ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice
    ISO20022.Auth106001.DetailedStatisticsPerCounterparty17 *-- ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice
    class ISO20022.Auth106001.DetailedTransactionStatistics26 {
        + Wrnngs  : global::System.Collections.Generic.List~ISO20022.Auth106001.MissingMarginData2~
        + NbOfOutsdngDerivsWthOutdtdMrgnInf  : Decimal
        + NbOfOutsdngDerivsWthNoMrgnInf  : Decimal
        + NbOfOutsdngDerivs  : Decimal
    }
    ISO20022.Auth106001.DetailedTransactionStatistics26 *-- ISO20022.Auth106001.MissingMarginData2
    class ISO20022.Auth106001.DetailedTransactionStatistics27 {
        + Wrnngs  : global::System.Collections.Generic.List~ISO20022.Auth106001.MissingValuationsData2~
        + NbOfOutsdngDerivsWthOutdtdValtn  : Decimal
        + NbOfOutsdngDerivsWthNoValtn  : Decimal
        + NbOfOutsdngDerivs  : Decimal
    }
    ISO20022.Auth106001.DetailedTransactionStatistics27 *-- ISO20022.Auth106001.MissingValuationsData2
    class ISO20022.Auth106001.DetailedTransactionStatistics28 {
        + Wrnngs  : global::System.Collections.Generic.List~ISO20022.Auth106001.AbnormalValuesData4~
        + NbOfDerivsRptdWthOtlrs  : Decimal
        + NbOfDerivsRptd  : Decimal
    }
    ISO20022.Auth106001.DetailedTransactionStatistics28 *-- ISO20022.Auth106001.AbnormalValuesData4
    class ISO20022.Auth106001.Frequency19Code {
        ODMD = 1
        HOUL = 2
        QURT = 3
        MIAN = 4
        EXPI = 5
        ADHO = 6
        YEAR = 7
        MNTH = 8
        WEEK = 9
        DAIL = 10
    }
    class ISO20022.Auth106001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth106001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth106001.OrganisationIdentification15Choice
    }
    ISO20022.Auth106001.LegalPersonIdentification1 *-- ISO20022.Auth106001.OrganisationIdentification15Choice
    class ISO20022.Auth106001.MarginPortfolio3 {
        + VartnMrgnPrtflCd  : ISO20022.Auth106001.PortfolioCode5Choice
        + InitlMrgnPrtflCd  : ISO20022.Auth106001.PortfolioCode5Choice
    }
    ISO20022.Auth106001.MarginPortfolio3 *-- ISO20022.Auth106001.PortfolioCode5Choice
    ISO20022.Auth106001.MarginPortfolio3 *-- ISO20022.Auth106001.PortfolioCode5Choice
    class ISO20022.Auth106001.MasterAgreement8 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth106001.AgreementType2Choice
    }
    ISO20022.Auth106001.MasterAgreement8 *-- ISO20022.Auth106001.AgreementType2Choice
    class ISO20022.Auth106001.MissingMarginData2 {
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Auth106001.MissingMarginTransactionData2~
        + NbOfOutsdngDerivsWthOutdtdMrgnInf  : Decimal
        + NbOfOutsdngDerivsWthNoMrgnInf  : Decimal
        + NbOfOutsdngDerivs  : Decimal
        + CtrPtyId  : ISO20022.Auth106001.CounterpartyData92
    }
    ISO20022.Auth106001.MissingMarginData2 *-- ISO20022.Auth106001.MissingMarginTransactionData2
    ISO20022.Auth106001.MissingMarginData2 *-- ISO20022.Auth106001.CounterpartyData92
    class ISO20022.Auth106001.MissingMarginTransactionData2 {
        + CollTmStmp  : DateTime
        + TxId  : ISO20022.Auth106001.TradeTransactionIdentification24
    }
    ISO20022.Auth106001.MissingMarginTransactionData2 *-- ISO20022.Auth106001.TradeTransactionIdentification24
    class ISO20022.Auth106001.MissingValuationsData2 {
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Auth106001.MissingValuationsTransactionData2~
        + NbOfOutsdngDerivsWthOutdtdValtn  : Decimal
        + NbOfOutsdngDerivsWthNoValtn  : Decimal
        + NbOfOutsdngDerivs  : Decimal
        + CtrPtyId  : ISO20022.Auth106001.CounterpartyData92
    }
    ISO20022.Auth106001.MissingValuationsData2 *-- ISO20022.Auth106001.MissingValuationsTransactionData2
    ISO20022.Auth106001.MissingValuationsData2 *-- ISO20022.Auth106001.CounterpartyData92
    class ISO20022.Auth106001.MissingValuationsTransactionData2 {
        + ValtnTmStmp  : ISO20022.Auth106001.DateAndDateTime2Choice
        + ValtnAmt  : ISO20022.Auth106001.AmountAndDirection106
        + TxId  : ISO20022.Auth106001.TradeTransactionIdentification24
    }
    ISO20022.Auth106001.MissingValuationsTransactionData2 *-- ISO20022.Auth106001.DateAndDateTime2Choice
    ISO20022.Auth106001.MissingValuationsTransactionData2 *-- ISO20022.Auth106001.AmountAndDirection106
    ISO20022.Auth106001.MissingValuationsTransactionData2 *-- ISO20022.Auth106001.TradeTransactionIdentification24
    class ISO20022.Auth106001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth106001.GenericIdentification175
    }
    ISO20022.Auth106001.NaturalPersonIdentification2 *-- ISO20022.Auth106001.GenericIdentification175
    class ISO20022.Auth106001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth106001.NaturalPersonIdentification2
    }
    ISO20022.Auth106001.NaturalPersonIdentification3 *-- ISO20022.Auth106001.NaturalPersonIdentification2
    class ISO20022.Auth106001.NotApplicable1Code {
        NOAP = 1
    }
    class ISO20022.Auth106001.NotionalAmount5 {
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth106001.Schedule11~
        + Amt  : ISO20022.Auth106001.AmountAndDirection106
    }
    ISO20022.Auth106001.NotionalAmount5 *-- ISO20022.Auth106001.Schedule11
    ISO20022.Auth106001.NotionalAmount5 *-- ISO20022.Auth106001.AmountAndDirection106
    class ISO20022.Auth106001.NotionalAmount6 {
        + Ccy  : String
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth106001.Schedule11~
        + Amt  : ISO20022.Auth106001.AmountAndDirection106
    }
    ISO20022.Auth106001.NotionalAmount6 *-- ISO20022.Auth106001.Schedule11
    ISO20022.Auth106001.NotionalAmount6 *-- ISO20022.Auth106001.AmountAndDirection106
    class ISO20022.Auth106001.NotionalAmountLegs5 {
        + ScndLeg  : ISO20022.Auth106001.NotionalAmount6
        + FrstLeg  : ISO20022.Auth106001.NotionalAmount5
    }
    ISO20022.Auth106001.NotionalAmountLegs5 *-- ISO20022.Auth106001.NotionalAmount6
    ISO20022.Auth106001.NotionalAmountLegs5 *-- ISO20022.Auth106001.NotionalAmount5
    class ISO20022.Auth106001.NotionalQuantity9 {
        + Dtls  : ISO20022.Auth106001.QuantityOrTerm1Choice
        + UnitOfMeasr  : ISO20022.Auth106001.UnitOfMeasure8Choice
        + TtlQty  : Decimal
    }
    ISO20022.Auth106001.NotionalQuantity9 *-- ISO20022.Auth106001.QuantityOrTerm1Choice
    ISO20022.Auth106001.NotionalQuantity9 *-- ISO20022.Auth106001.UnitOfMeasure8Choice
    class ISO20022.Auth106001.NotionalQuantityLegs5 {
        + ScndLeg  : ISO20022.Auth106001.NotionalQuantity9
        + FrstLeg  : ISO20022.Auth106001.NotionalQuantity9
    }
    ISO20022.Auth106001.NotionalQuantityLegs5 *-- ISO20022.Auth106001.NotionalQuantity9
    ISO20022.Auth106001.NotionalQuantityLegs5 *-- ISO20022.Auth106001.NotionalQuantity9
    class ISO20022.Auth106001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth106001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth106001.OrganisationIdentification15Choice *-- ISO20022.Auth106001.OrganisationIdentification38
    class ISO20022.Auth106001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth106001.GenericIdentification175
    }
    ISO20022.Auth106001.OrganisationIdentification38 *-- ISO20022.Auth106001.GenericIdentification175
    class ISO20022.Auth106001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth106001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth106001.LegalPersonIdentification1
    }
    ISO20022.Auth106001.PartyIdentification248Choice *-- ISO20022.Auth106001.NaturalPersonIdentification3
    ISO20022.Auth106001.PartyIdentification248Choice *-- ISO20022.Auth106001.LegalPersonIdentification1
    class ISO20022.Auth106001.PortfolioCode3Choice {
        + NoPrtfl  : String
        + Cd  : String
    }
    class ISO20022.Auth106001.PortfolioCode5Choice {
        + NoPrtfl  : String
        + Prtfl  : ISO20022.Auth106001.PortfolioIdentification3
    }
    ISO20022.Auth106001.PortfolioCode5Choice *-- ISO20022.Auth106001.PortfolioIdentification3
    class ISO20022.Auth106001.PortfolioIdentification3 {
        + PrtflTxXmptn  : String
        + Cd  : String
    }
    class ISO20022.Auth106001.QuantityOrTerm1Choice {
        + Term  : ISO20022.Auth106001.QuantityTerm1
        + SchdlPrd  : global::System.Collections.Generic.List~ISO20022.Auth106001.Schedule10~
    }
    ISO20022.Auth106001.QuantityOrTerm1Choice *-- ISO20022.Auth106001.QuantityTerm1
    ISO20022.Auth106001.QuantityOrTerm1Choice *-- ISO20022.Auth106001.Schedule10
    class ISO20022.Auth106001.QuantityTerm1 {
        + TmUnit  : String
        + Val  : Decimal
        + UnitOfMeasr  : ISO20022.Auth106001.UnitOfMeasure8Choice
        + Qty  : Decimal
    }
    ISO20022.Auth106001.QuantityTerm1 *-- ISO20022.Auth106001.UnitOfMeasure8Choice
    class ISO20022.Auth106001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth106001.Schedule10 {
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
        + UnitOfMeasr  : ISO20022.Auth106001.UnitOfMeasure8Choice
        + Qty  : Decimal
    }
    ISO20022.Auth106001.Schedule10 *-- ISO20022.Auth106001.UnitOfMeasure8Choice
    class ISO20022.Auth106001.Schedule11 {
        + Amt  : ISO20022.Auth106001.AmountAndDirection106
        + UadjstdEndDt  : DateTime
        + UadjstdFctvDt  : DateTime
    }
    ISO20022.Auth106001.Schedule11 *-- ISO20022.Auth106001.AmountAndDirection106
    class ISO20022.Auth106001.StatisticsPerCounterparty16Choice {
        + Rpt  : ISO20022.Auth106001.DetailedStatisticsPerCounterparty17
        + DataSetActn  : String
    }
    ISO20022.Auth106001.StatisticsPerCounterparty16Choice *-- ISO20022.Auth106001.DetailedStatisticsPerCounterparty17
    class ISO20022.Auth106001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth106001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth106001.SupplementaryData1 *-- ISO20022.Auth106001.SupplementaryDataEnvelope1
    class ISO20022.Auth106001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth106001.TradeTransactionIdentification24 {
        + CollPrtflCd  : ISO20022.Auth106001.CollateralPortfolioCode5Choice
        + MstrAgrmt  : ISO20022.Auth106001.MasterAgreement8
        + UnqIdr  : ISO20022.Auth106001.UniqueTransactionIdentifier2Choice
        + OthrCtrPty  : ISO20022.Auth106001.PartyIdentification248Choice
        + DerivEvtTmStmp  : ISO20022.Auth106001.DateAndDateTime2Choice
        + DerivEvtTp  : String
        + RptgTmStmp  : DateTime
        + ActnTp  : String
        + TechRcrdId  : String
    }
    ISO20022.Auth106001.TradeTransactionIdentification24 *-- ISO20022.Auth106001.CollateralPortfolioCode5Choice
    ISO20022.Auth106001.TradeTransactionIdentification24 *-- ISO20022.Auth106001.MasterAgreement8
    ISO20022.Auth106001.TradeTransactionIdentification24 *-- ISO20022.Auth106001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth106001.TradeTransactionIdentification24 *-- ISO20022.Auth106001.PartyIdentification248Choice
    ISO20022.Auth106001.TradeTransactionIdentification24 *-- ISO20022.Auth106001.DateAndDateTime2Choice
    class ISO20022.Auth106001.TransactionOperationType10Code {
        PRTO = 1
        MARU = 2
        VALU = 3
        TERM = 4
        REVI = 5
        POSC = 6
        OTHR = 7
        NEWT = 8
        MODI = 9
        EROR = 10
        CORR = 11
        COMP = 12
    }
    class ISO20022.Auth106001.UniqueTransactionIdentifier2Choice {
        + Prtry  : ISO20022.Auth106001.GenericIdentification175
        + UnqTxIdr  : String
    }
    ISO20022.Auth106001.UniqueTransactionIdentifier2Choice *-- ISO20022.Auth106001.GenericIdentification175
    class ISO20022.Auth106001.UnitOfMeasure8Choice {
        + Prtry  : ISO20022.Auth106001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth106001.UnitOfMeasure8Choice *-- ISO20022.Auth106001.GenericIdentification175
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

## Value ISO20022.Auth106001.AbnormalValuesData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Auth106001.AbnormalValuesTransactionData2>||XmlElement()||
|+|NbOfDerivsRptdWthOtlrs|Decimal||XmlElement()||
|+|NbOfDerivsRptd|Decimal||XmlElement()||
|+|CtrPtyId|ISO20022.Auth106001.CounterpartyData92||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(CtrPtyId))|

---

## Value ISO20022.Auth106001.AbnormalValuesTransactionData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtnlQty|ISO20022.Auth106001.NotionalQuantityLegs5||XmlElement()||
|+|NtnlAmt|ISO20022.Auth106001.NotionalAmountLegs5||XmlElement()||
|+|TxId|ISO20022.Auth106001.TradeTransactionIdentification24||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtnlQty),validElement(NtnlAmt),validElement(TxId))|

---

## Value ISO20022.Auth106001.ActiveOrHistoricCurrencyAnd19DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth106001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth106001.AmountAndDirection106


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth106001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth106001.CollateralPortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnPrtflCd|ISO20022.Auth106001.MarginPortfolio3||XmlElement()||
|+|Prtfl|ISO20022.Auth106001.PortfolioCode3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnPrtflCd),validElement(Prtfl),validChoice(MrgnPrtflCd,Prtfl))|

---

## Value ISO20022.Auth106001.CounterpartyData92


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NttyRspnsblForRpt|ISO20022.Auth106001.OrganisationIdentification15Choice||XmlElement()||
|+|RptSubmitgNtty|ISO20022.Auth106001.OrganisationIdentification15Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth106001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NttyRspnsblForRpt),validElement(RptSubmitgNtty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth106001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Auth106001.DerivativeEventType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDT|Int32||XmlEnum("""UPDT""")|1|
||TRAD|Int32||XmlEnum("""TRAD""")|2|
||PTNG|Int32||XmlEnum("""PTNG""")|3|
||NOVA|Int32||XmlEnum("""NOVA""")|4|
||INCP|Int32||XmlEnum("""INCP""")|5|
||EXER|Int32||XmlEnum("""EXER""")|6|
||ETRM|Int32||XmlEnum("""ETRM""")|7|
||CREV|Int32||XmlEnum("""CREV""")|8|
||CORP|Int32||XmlEnum("""CORP""")|9|
||COMP|Int32||XmlEnum("""COMP""")|10|
||CLAL|Int32||XmlEnum("""CLAL""")|11|
||CLRG|Int32||XmlEnum("""CLRG""")|12|
||ALOC|Int32||XmlEnum("""ALOC""")|13|

---

## Aspect ISO20022.Auth106001.DerivativesTradeWarningsReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth106001.SupplementaryData1>||XmlElement()||
|+|WrnngsSttstcs|ISO20022.Auth106001.StatisticsPerCounterparty16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(WrnngsSttstcs))|

---

## Value ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth106001.DetailedTransactionStatistics28||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth106001.DetailedTransactionStatistics26||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth106001.DetailedTransactionStatistics27||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth106001.DetailedStatisticsPerCounterparty17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AbnrmlVals|ISO20022.Auth106001.DetailedAbnormalValuesStatistics4Choice||XmlElement()||
|+|MssngMrgnInf|ISO20022.Auth106001.DetailedMissingMarginInformationStatistics4Choice||XmlElement()||
|+|MssngValtn|ISO20022.Auth106001.DetailedMissingValuationsStatistics4Choice||XmlElement()||
|+|RefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AbnrmlVals),validElement(MssngMrgnInf),validElement(MssngValtn))|

---

## Value ISO20022.Auth106001.DetailedTransactionStatistics26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Wrnngs|global::System.Collections.Generic.List<ISO20022.Auth106001.MissingMarginData2>||XmlElement()||
|+|NbOfOutsdngDerivsWthOutdtdMrgnInf|Decimal||XmlElement()||
|+|NbOfOutsdngDerivsWthNoMrgnInf|Decimal||XmlElement()||
|+|NbOfOutsdngDerivs|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Wrnngs""",Wrnngs),validList("""Wrnngs""",Wrnngs),validElement(Wrnngs))|

---

## Value ISO20022.Auth106001.DetailedTransactionStatistics27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Wrnngs|global::System.Collections.Generic.List<ISO20022.Auth106001.MissingValuationsData2>||XmlElement()||
|+|NbOfOutsdngDerivsWthOutdtdValtn|Decimal||XmlElement()||
|+|NbOfOutsdngDerivsWthNoValtn|Decimal||XmlElement()||
|+|NbOfOutsdngDerivs|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Wrnngs""",Wrnngs),validList("""Wrnngs""",Wrnngs),validElement(Wrnngs))|

---

## Value ISO20022.Auth106001.DetailedTransactionStatistics28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Wrnngs|global::System.Collections.Generic.List<ISO20022.Auth106001.AbnormalValuesData4>||XmlElement()||
|+|NbOfDerivsRptdWthOtlrs|Decimal||XmlElement()||
|+|NbOfDerivsRptd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Wrnngs""",Wrnngs),validList("""Wrnngs""",Wrnngs),validElement(Wrnngs))|

---

## Type ISO20022.Auth106001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradWrnngsRpt|ISO20022.Auth106001.DerivativesTradeWarningsReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradWrnngsRpt))|

---

## Enum ISO20022.Auth106001.Frequency19Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ODMD|Int32||XmlEnum("""ODMD""")|1|
||HOUL|Int32||XmlEnum("""HOUL""")|2|
||QURT|Int32||XmlEnum("""QURT""")|3|
||MIAN|Int32||XmlEnum("""MIAN""")|4|
||EXPI|Int32||XmlEnum("""EXPI""")|5|
||ADHO|Int32||XmlEnum("""ADHO""")|6|
||YEAR|Int32||XmlEnum("""YEAR""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||WEEK|Int32||XmlEnum("""WEEK""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|

---

## Value ISO20022.Auth106001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth106001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth106001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth106001.MarginPortfolio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VartnMrgnPrtflCd|ISO20022.Auth106001.PortfolioCode5Choice||XmlElement()||
|+|InitlMrgnPrtflCd|ISO20022.Auth106001.PortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VartnMrgnPrtflCd),validElement(InitlMrgnPrtflCd))|

---

## Value ISO20022.Auth106001.MasterAgreement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth106001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth106001.MissingMarginData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Auth106001.MissingMarginTransactionData2>||XmlElement()||
|+|NbOfOutsdngDerivsWthOutdtdMrgnInf|Decimal||XmlElement()||
|+|NbOfOutsdngDerivsWthNoMrgnInf|Decimal||XmlElement()||
|+|NbOfOutsdngDerivs|Decimal||XmlElement()||
|+|CtrPtyId|ISO20022.Auth106001.CounterpartyData92||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(CtrPtyId))|

---

## Value ISO20022.Auth106001.MissingMarginTransactionData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollTmStmp|DateTime||XmlElement()||
|+|TxId|ISO20022.Auth106001.TradeTransactionIdentification24||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxId))|

---

## Value ISO20022.Auth106001.MissingValuationsData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Auth106001.MissingValuationsTransactionData2>||XmlElement()||
|+|NbOfOutsdngDerivsWthOutdtdValtn|Decimal||XmlElement()||
|+|NbOfOutsdngDerivsWthNoValtn|Decimal||XmlElement()||
|+|NbOfOutsdngDerivs|Decimal||XmlElement()||
|+|CtrPtyId|ISO20022.Auth106001.CounterpartyData92||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(CtrPtyId))|

---

## Value ISO20022.Auth106001.MissingValuationsTransactionData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValtnTmStmp|ISO20022.Auth106001.DateAndDateTime2Choice||XmlElement()||
|+|ValtnAmt|ISO20022.Auth106001.AmountAndDirection106||XmlElement()||
|+|TxId|ISO20022.Auth106001.TradeTransactionIdentification24||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnTmStmp),validElement(ValtnAmt),validElement(TxId))|

---

## Value ISO20022.Auth106001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth106001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth106001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth106001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth106001.NotApplicable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|

---

## Value ISO20022.Auth106001.NotionalAmount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth106001.Schedule11>||XmlElement()||
|+|Amt|ISO20022.Auth106001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validElement(Amt))|

---

## Value ISO20022.Auth106001.NotionalAmount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth106001.Schedule11>||XmlElement()||
|+|Amt|ISO20022.Auth106001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validElement(Amt))|

---

## Value ISO20022.Auth106001.NotionalAmountLegs5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth106001.NotionalAmount6||XmlElement()||
|+|FrstLeg|ISO20022.Auth106001.NotionalAmount5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Value ISO20022.Auth106001.NotionalQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth106001.QuantityOrTerm1Choice||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth106001.UnitOfMeasure8Choice||XmlElement()||
|+|TtlQty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validElement(UnitOfMeasr))|

---

## Value ISO20022.Auth106001.NotionalQuantityLegs5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLeg|ISO20022.Auth106001.NotionalQuantity9||XmlElement()||
|+|FrstLeg|ISO20022.Auth106001.NotionalQuantity9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndLeg),validElement(FrstLeg))|

---

## Value ISO20022.Auth106001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth106001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth106001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth106001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth106001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth106001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth106001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth106001.PortfolioCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NoPrtfl,Cd))|

---

## Value ISO20022.Auth106001.PortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Prtfl|ISO20022.Auth106001.PortfolioIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtfl),validChoice(NoPrtfl,Prtfl))|

---

## Value ISO20022.Auth106001.PortfolioIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTxXmptn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth106001.QuantityOrTerm1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|ISO20022.Auth106001.QuantityTerm1||XmlElement()||
|+|SchdlPrd|global::System.Collections.Generic.List<ISO20022.Auth106001.Schedule10>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validRequired("""SchdlPrd""",SchdlPrd),validList("""SchdlPrd""",SchdlPrd),validElement(SchdlPrd),validChoice(Term,SchdlPrd))|

---

## Value ISO20022.Auth106001.QuantityTerm1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmUnit|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth106001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr))|

---

## Enum ISO20022.Auth106001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth106001.Schedule10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
|+|UnitOfMeasr|ISO20022.Auth106001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr))|

---

## Value ISO20022.Auth106001.Schedule11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Auth106001.AmountAndDirection106||XmlElement()||
|+|UadjstdEndDt|DateTime||XmlElement()||
|+|UadjstdFctvDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth106001.StatisticsPerCounterparty16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|ISO20022.Auth106001.DetailedStatisticsPerCounterparty17||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth106001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth106001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth106001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth106001.TradeTransactionIdentification24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollPrtflCd|ISO20022.Auth106001.CollateralPortfolioCode5Choice||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth106001.MasterAgreement8||XmlElement()||
|+|UnqIdr|ISO20022.Auth106001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth106001.PartyIdentification248Choice||XmlElement()||
|+|DerivEvtTmStmp|ISO20022.Auth106001.DateAndDateTime2Choice||XmlElement()||
|+|DerivEvtTp|String||XmlElement()||
|+|RptgTmStmp|DateTime||XmlElement()||
|+|ActnTp|String||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollPrtflCd),validElement(MstrAgrmt),validElement(UnqIdr),validElement(OthrCtrPty),validElement(DerivEvtTmStmp))|

---

## Enum ISO20022.Auth106001.TransactionOperationType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRTO|Int32||XmlEnum("""PRTO""")|1|
||MARU|Int32||XmlEnum("""MARU""")|2|
||VALU|Int32||XmlEnum("""VALU""")|3|
||TERM|Int32||XmlEnum("""TERM""")|4|
||REVI|Int32||XmlEnum("""REVI""")|5|
||POSC|Int32||XmlEnum("""POSC""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||NEWT|Int32||XmlEnum("""NEWT""")|8|
||MODI|Int32||XmlEnum("""MODI""")|9|
||EROR|Int32||XmlEnum("""EROR""")|10|
||CORR|Int32||XmlEnum("""CORR""")|11|
||COMP|Int32||XmlEnum("""COMP""")|12|

---

## Value ISO20022.Auth106001.UniqueTransactionIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth106001.GenericIdentification175||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth106001.UnitOfMeasure8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth106001.GenericIdentification175||XmlElement()||
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

