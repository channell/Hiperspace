# reda.002.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda002001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda002001.AdditionalReference3 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Reda002001.PartyIdentification2Choice
        + Ref  : String
    }
    ISO20022.Reda002001.AdditionalReference3 *-- ISO20022.Reda002001.PartyIdentification2Choice
    class ISO20022.Reda002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda002001.AlternateSecurityIdentification1 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Reda002001.CalculationBasis2Code {
        YEAR = 1
        MNTH = 2
        DAIL = 3
        AVER = 4
    }
    class ISO20022.Reda002001.Charge15 {
        + XtndedClctnBsis  : String
        + ClctnBsis  : String
        + Rate  : Decimal
        + Amt  : ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount
        + XtndedTp  : String
        + Tp  : String
    }
    ISO20022.Reda002001.Charge15 *-- ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.ChargeType9Code {
        PENA = 1
        EQUL = 2
        ACCT = 3
        PUBL = 4
        CUST = 5
        ADVI = 6
        FEND = 7
        BEND = 8
        MANF = 9
    }
    class ISO20022.Reda002001.DateAndDateTime1Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Reda002001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Reda002001.DateOrDateTimePeriodChoice {
        + DtTm  : ISO20022.Reda002001.DateTimePeriodDetails
        + Dt  : ISO20022.Reda002001.DatePeriodDetails
    }
    ISO20022.Reda002001.DateOrDateTimePeriodChoice *-- ISO20022.Reda002001.DateTimePeriodDetails
    ISO20022.Reda002001.DateOrDateTimePeriodChoice *-- ISO20022.Reda002001.DatePeriodDetails
    class ISO20022.Reda002001.DatePeriodDetails {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Reda002001.DateTimePeriodDetails {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Reda002001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Reda002001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Reda002001.EUDividendStatus1Code {
        UKWN = 1
        DIVO = 2
        DIVI = 3
    }
    class ISO20022.Reda002001.EventFrequency1Code {
        ONDE = 1
        OVNG = 2
        INDA = 3
        ADHO = 4
        DAIL = 5
        WEEK = 6
        TOWK = 7
        TWMN = 8
        MNTH = 9
        TOMN = 10
        QUTR = 11
        SEMI = 12
        YEAR = 13
    }
    class ISO20022.Reda002001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Reda002001.FinancialInstrument8 {
        + DualFndInd  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + DnmtnCcy  : String
        + SplmtryId  : String
        + Nm  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Reda002001.SecurityIdentification3Choice~
    }
    ISO20022.Reda002001.FinancialInstrument8 *-- ISO20022.Reda002001.SecurityIdentification3Choice
    class ISO20022.Reda002001.FinancialInstrumentQuantity1 {
        + Unit  : Decimal
    }
    class ISO20022.Reda002001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Reda002001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda002001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Reda002001.NameAndAddress5 {
        + Adr  : ISO20022.Reda002001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda002001.NameAndAddress5 *-- ISO20022.Reda002001.PostalAddress1
    class ISO20022.Reda002001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Reda002001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Reda002001.NameAndAddress5
        + PrtryId  : ISO20022.Reda002001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Reda002001.PartyIdentification2Choice *-- ISO20022.Reda002001.NameAndAddress5
    ISO20022.Reda002001.PartyIdentification2Choice *-- ISO20022.Reda002001.GenericIdentification1
    class ISO20022.Reda002001.PerformanceFactors1 {
        + NrmlPrfrmnc  : Decimal
        + AcmltnPrd  : ISO20022.Reda002001.DatePeriodDetails
        + CmltvCorpActnFctr  : Decimal
        + CorpActnFctr  : Decimal
    }
    ISO20022.Reda002001.PerformanceFactors1 *-- ISO20022.Reda002001.DatePeriodDetails
    class ISO20022.Reda002001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda002001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Reda002001.PriceReport3 {
        + PricValtnDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.PriceValuation4~
    }
    ISO20022.Reda002001.PriceReport3 *-- ISO20022.Reda002001.PriceValuation4
    class ISO20022.Reda002001.PriceReportCancellationV04 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Reda002001.Extension1~
        + CancPricValtnDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.PriceReport3~
        + CmpltPricCxl  : String
        + XpctdPricCrrctnDt  : ISO20022.Reda002001.DateAndDateTime1Choice
        + CxlRsn  : String
        + CxlId  : String
        + PricRptId  : String
        + MsgPgntn  : ISO20022.Reda002001.Pagination
        + PrvsRef  : ISO20022.Reda002001.AdditionalReference3
        + PoolRef  : ISO20022.Reda002001.AdditionalReference3
        + MsgId  : ISO20022.Reda002001.MessageIdentification1
    }
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.Extension1
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.PriceReport3
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.DateAndDateTime1Choice
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.Pagination
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.AdditionalReference3
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.AdditionalReference3
    ISO20022.Reda002001.PriceReportCancellationV04 *-- ISO20022.Reda002001.MessageIdentification1
    class ISO20022.Reda002001.PriceType2 {
        + AddtlInf  : String
        + Strd  : String
    }
    class ISO20022.Reda002001.PriceValuation4 {
        + PrfrmncDtls  : ISO20022.Reda002001.PerformanceFactors1
        + ValtnSttstcs  : global::System.Collections.Generic.List~ISO20022.Reda002001.ValuationStatistics3~
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.UnitPrice15~
        + SspdInd  : String
        + OffclValtnInd  : String
        + ValtnFrqcy  : String
        + ValtnTp  : String
        + PrvsValtnDtTm  : ISO20022.Reda002001.DateAndDateTimeChoice
        + NxtValtnDtTm  : ISO20022.Reda002001.DateAndDateTimeChoice
        + TtlUnitsNb  : ISO20022.Reda002001.FinancialInstrumentQuantity1
        + TtlNAV  : global::System.Collections.Generic.List~ISO20022.Reda002001.ActiveOrHistoricCurrencyAndAmount~
        + FndMgmtCpny  : ISO20022.Reda002001.PartyIdentification2Choice
        + FinInstrmDtls  : ISO20022.Reda002001.FinancialInstrument8
        + NAVDtTm  : ISO20022.Reda002001.DateAndDateTimeChoice
        + ValtnDtTm  : ISO20022.Reda002001.DateAndDateTimeChoice
        + Id  : String
    }
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.PerformanceFactors1
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.ValuationStatistics3
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.UnitPrice15
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.DateAndDateTimeChoice
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.DateAndDateTimeChoice
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.FinancialInstrumentQuantity1
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.PartyIdentification2Choice
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.FinancialInstrument8
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.DateAndDateTimeChoice
    ISO20022.Reda002001.PriceValuation4 *-- ISO20022.Reda002001.DateAndDateTimeChoice
    class ISO20022.Reda002001.PriceValue1 {
        + Amt  : ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Reda002001.PriceValue1 *-- ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.PriceValue5 {
        + Amt  : ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    }
    ISO20022.Reda002001.PriceValue5 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.PriceValueChange1 {
        + Rate  : Decimal
        + AmtSgn  : String
        + Amt  : ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    }
    ISO20022.Reda002001.PriceValueChange1 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.SecurityIdentification3Choice {
        + OthrPrtryId  : ISO20022.Reda002001.AlternateSecurityIdentification1
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
    ISO20022.Reda002001.SecurityIdentification3Choice *-- ISO20022.Reda002001.AlternateSecurityIdentification1
    class ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 {
        + FiveYrPricChng  : ISO20022.Reda002001.PriceValueChange1
        + ThreeYrPricChng  : ISO20022.Reda002001.PriceValueChange1
        + OneYrPricChng  : ISO20022.Reda002001.PriceValueChange1
        + LwstPricVal12Mnths  : ISO20022.Reda002001.PriceValue5
        + HghstPricVal12Mnths  : ISO20022.Reda002001.PriceValue5
    }
    ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 *-- ISO20022.Reda002001.PriceValueChange1
    ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 *-- ISO20022.Reda002001.PriceValueChange1
    ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 *-- ISO20022.Reda002001.PriceValueChange1
    ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 *-- ISO20022.Reda002001.PriceValue5
    ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2 *-- ISO20022.Reda002001.PriceValue5
    class ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2 {
        + Yld  : Decimal
        + PricChng  : ISO20022.Reda002001.PriceValueChange1
        + LwstPricVal  : ISO20022.Reda002001.PriceValue5
        + HghstPricVal  : ISO20022.Reda002001.PriceValue5
        + Prd  : ISO20022.Reda002001.DateOrDateTimePeriodChoice
    }
    ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2 *-- ISO20022.Reda002001.PriceValueChange1
    ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2 *-- ISO20022.Reda002001.PriceValue5
    ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2 *-- ISO20022.Reda002001.PriceValue5
    ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2 *-- ISO20022.Reda002001.DateOrDateTimePeriodChoice
    class ISO20022.Reda002001.Tax17 {
        + TaxClctnDtls  : ISO20022.Reda002001.TaxCalculationInformation4
        + Ctry  : String
        + Rate  : Decimal
        + Amt  : global::System.Collections.Generic.List~ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount~
        + XtndedTp  : String
        + Tp  : String
    }
    ISO20022.Reda002001.Tax17 *-- ISO20022.Reda002001.TaxCalculationInformation4
    ISO20022.Reda002001.Tax17 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.TaxCalculationInformation4 {
        + XtndedEUDvddSts  : String
        + EUDvddSts  : String
        + TaxblIncmPerDvdd  : ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + PctgGrdfthdDebt  : Decimal
        + PctgOfDebtClm  : Decimal
        + XtndedEUCptlGn  : String
        + EUCptlGn  : String
    }
    ISO20022.Reda002001.TaxCalculationInformation4 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Reda002001.TaxType12Code {
        MIET = 1
        ZWIS = 2
        AKT2 = 3
        AKT1 = 4
        EUTR = 5
        INPO = 6
    }
    class ISO20022.Reda002001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Reda002001.TypeOfPrice6Code {
        NAUP = 1
        ACTU = 2
        DDVR = 3
        SWIC = 4
        RINV = 5
        MIDD = 6
        OTHR = 7
        SWNG = 8
        INTE = 9
        CANC = 10
        CREA = 11
        NAVL = 12
        OFFR = 13
        BIDE = 14
    }
    class ISO20022.Reda002001.TypeOfPrice9Code {
        ENAV = 1
        GUAR = 2
        NAUP = 3
        ACTU = 4
        DDVR = 5
        SWIC = 6
        RINV = 7
        MIDD = 8
        SWNG = 9
        INTE = 10
        CANC = 11
        CREA = 12
        NAVL = 13
        OFFR = 14
        BIDE = 15
    }
    class ISO20022.Reda002001.UnitPrice15 {
        + TaxRfndDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.Tax17~
        + TaxLbltyDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.Tax17~
        + ChrgDtls  : global::System.Collections.Generic.List~ISO20022.Reda002001.Charge15~
        + XtndedEUDvddSts  : String
        + EUDvddSts  : String
        + TaxblIncmPerDvdd  : ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + XtndedTaxblIncmPerShrClctd  : String
        + TaxblIncmPerShrClctd  : String
        + TaxblIncmPerShr  : ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + NbOfDaysAcrd  : Decimal
        + EstmtdPricInd  : String
        + ClctnBsis  : Decimal
        + CumDvddInd  : String
        + ForExctnInd  : String
        + ValInAltrntvCcy  : global::System.Collections.Generic.List~ISO20022.Reda002001.PriceValue1~
        + ValInInvstmtCcy  : global::System.Collections.Generic.List~ISO20022.Reda002001.PriceValue1~
        + PricMtd  : String
        + XtndedTp  : String
        + Tp  : String
    }
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.Tax17
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.Tax17
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.Charge15
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.PriceValue1
    ISO20022.Reda002001.UnitPrice15 *-- ISO20022.Reda002001.PriceValue1
    class ISO20022.Reda002001.ValuationStatistics3 {
        + ByUsrDfndTmPrd  : global::System.Collections.Generic.List~ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2~
        + ByPrdfndTmPrds  : ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2
        + Yld  : Decimal
        + PricChng  : ISO20022.Reda002001.PriceValueChange1
        + PricTpChngBsis  : ISO20022.Reda002001.PriceType2
        + Ccy  : String
    }
    ISO20022.Reda002001.ValuationStatistics3 *-- ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2
    ISO20022.Reda002001.ValuationStatistics3 *-- ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2
    ISO20022.Reda002001.ValuationStatistics3 *-- ISO20022.Reda002001.PriceValueChange1
    ISO20022.Reda002001.ValuationStatistics3 *-- ISO20022.Reda002001.PriceType2
    class ISO20022.Reda002001.ValuationTiming1Code {
        PATC = 1
        USUA = 2
        EXCP = 3
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

## Value ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda002001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda002001.AdditionalReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Reda002001.PartyIdentification2Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Reda002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Reda002001.AlternateSecurityIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Enum ISO20022.Reda002001.CalculationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||MNTH|Int32||XmlEnum("""MNTH""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||AVER|Int32||XmlEnum("""AVER""")|4|

---

## Value ISO20022.Reda002001.Charge15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedClctnBsis|String||XmlElement()||
|+|ClctnBsis|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|XtndedTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(XtndedClctnBsis,ClctnBsis,Rate,Amt,XtndedTp,Tp))|

---

## Enum ISO20022.Reda002001.ChargeType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PENA|Int32||XmlEnum("""PENA""")|1|
||EQUL|Int32||XmlEnum("""EQUL""")|2|
||ACCT|Int32||XmlEnum("""ACCT""")|3|
||PUBL|Int32||XmlEnum("""PUBL""")|4|
||CUST|Int32||XmlEnum("""CUST""")|5|
||ADVI|Int32||XmlEnum("""ADVI""")|6|
||FEND|Int32||XmlEnum("""FEND""")|7|
||BEND|Int32||XmlEnum("""BEND""")|8|
||MANF|Int32||XmlEnum("""MANF""")|9|

---

## Value ISO20022.Reda002001.DateAndDateTime1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Reda002001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Reda002001.DateOrDateTimePeriodChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|ISO20022.Reda002001.DateTimePeriodDetails||XmlElement()||
|+|Dt|ISO20022.Reda002001.DatePeriodDetails||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTm),validElement(Dt),validChoice(DtTm,Dt))|

---

## Value ISO20022.Reda002001.DatePeriodDetails


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda002001.DateTimePeriodDetails


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda002001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Reda002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricRptCxl|ISO20022.Reda002001.PriceReportCancellationV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricRptCxl))|

---

## Enum ISO20022.Reda002001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Enum ISO20022.Reda002001.EUDividendStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||DIVO|Int32||XmlEnum("""DIVO""")|2|
||DIVI|Int32||XmlEnum("""DIVI""")|3|

---

## Enum ISO20022.Reda002001.EventFrequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||INDA|Int32||XmlEnum("""INDA""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||DAIL|Int32||XmlEnum("""DAIL""")|5|
||WEEK|Int32||XmlEnum("""WEEK""")|6|
||TOWK|Int32||XmlEnum("""TOWK""")|7|
||TWMN|Int32||XmlEnum("""TWMN""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||TOMN|Int32||XmlEnum("""TOMN""")|10|
||QUTR|Int32||XmlEnum("""QUTR""")|11|
||SEMI|Int32||XmlEnum("""SEMI""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Value ISO20022.Reda002001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda002001.FinancialInstrument8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DualFndInd|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Reda002001.SecurityIdentification3Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validRequired("""Id""",Id),validList("""Id""",Id),validListMax("""Id""",Id,10),validElement(Id))|

---

## Value ISO20022.Reda002001.FinancialInstrumentQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda002001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Reda002001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda002001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda002001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda002001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda002001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Reda002001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda002001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda002001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Reda002001.PerformanceFactors1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NrmlPrfrmnc|Decimal||XmlElement()||
|+|AcmltnPrd|ISO20022.Reda002001.DatePeriodDetails||XmlElement()||
|+|CmltvCorpActnFctr|Decimal||XmlElement()||
|+|CorpActnFctr|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcmltnPrd))|

---

## Value ISO20022.Reda002001.PostalAddress1


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

## Enum ISO20022.Reda002001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Reda002001.PriceReport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricValtnDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.PriceValuation4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PricValtnDtls""",PricValtnDtls),validList("""PricValtnDtls""",PricValtnDtls),validElement(PricValtnDtls))|

---

## Aspect ISO20022.Reda002001.PriceReportCancellationV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Reda002001.Extension1>||XmlElement()||
|+|CancPricValtnDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.PriceReport3>||XmlElement()||
|+|CmpltPricCxl|String||XmlElement()||
|+|XpctdPricCrrctnDt|ISO20022.Reda002001.DateAndDateTime1Choice||XmlElement()||
|+|CxlRsn|String||XmlElement()||
|+|CxlId|String||XmlElement()||
|+|PricRptId|String||XmlElement()||
|+|MsgPgntn|ISO20022.Reda002001.Pagination||XmlElement()||
|+|PrvsRef|ISO20022.Reda002001.AdditionalReference3||XmlElement()||
|+|PoolRef|ISO20022.Reda002001.AdditionalReference3||XmlElement()||
|+|MsgId|ISO20022.Reda002001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validList("""CancPricValtnDtls""",CancPricValtnDtls),validElement(CancPricValtnDtls),validElement(XpctdPricCrrctnDt),validElement(MsgPgntn),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

---

## Value ISO20022.Reda002001.PriceType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Strd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda002001.PriceValuation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrfrmncDtls|ISO20022.Reda002001.PerformanceFactors1||XmlElement()||
|+|ValtnSttstcs|global::System.Collections.Generic.List<ISO20022.Reda002001.ValuationStatistics3>||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.UnitPrice15>||XmlElement()||
|+|SspdInd|String||XmlElement()||
|+|OffclValtnInd|String||XmlElement()||
|+|ValtnFrqcy|String||XmlElement()||
|+|ValtnTp|String||XmlElement()||
|+|PrvsValtnDtTm|ISO20022.Reda002001.DateAndDateTimeChoice||XmlElement()||
|+|NxtValtnDtTm|ISO20022.Reda002001.DateAndDateTimeChoice||XmlElement()||
|+|TtlUnitsNb|ISO20022.Reda002001.FinancialInstrumentQuantity1||XmlElement()||
|+|TtlNAV|global::System.Collections.Generic.List<ISO20022.Reda002001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|FndMgmtCpny|ISO20022.Reda002001.PartyIdentification2Choice||XmlElement()||
|+|FinInstrmDtls|ISO20022.Reda002001.FinancialInstrument8||XmlElement()||
|+|NAVDtTm|ISO20022.Reda002001.DateAndDateTimeChoice||XmlElement()||
|+|ValtnDtTm|ISO20022.Reda002001.DateAndDateTimeChoice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrfrmncDtls),validList("""ValtnSttstcs""",ValtnSttstcs),validElement(ValtnSttstcs),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(PrvsValtnDtTm),validElement(NxtValtnDtTm),validElement(TtlUnitsNb),validList("""TtlNAV""",TtlNAV),validElement(TtlNAV),validElement(FndMgmtCpny),validElement(FinInstrmDtls),validElement(NAVDtTm),validElement(ValtnDtTm))|

---

## Value ISO20022.Reda002001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Reda002001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Reda002001.PriceValue5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Reda002001.PriceValueChange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|AmtSgn|String||XmlElement()||
|+|Amt|ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Reda002001.SecurityIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Reda002001.AlternateSecurityIdentification1||XmlElement()||
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

## Value ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FiveYrPricChng|ISO20022.Reda002001.PriceValueChange1||XmlElement()||
|+|ThreeYrPricChng|ISO20022.Reda002001.PriceValueChange1||XmlElement()||
|+|OneYrPricChng|ISO20022.Reda002001.PriceValueChange1||XmlElement()||
|+|LwstPricVal12Mnths|ISO20022.Reda002001.PriceValue5||XmlElement()||
|+|HghstPricVal12Mnths|ISO20022.Reda002001.PriceValue5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FiveYrPricChng),validElement(ThreeYrPricChng),validElement(OneYrPricChng),validElement(LwstPricVal12Mnths),validElement(HghstPricVal12Mnths))|

---

## Value ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Yld|Decimal||XmlElement()||
|+|PricChng|ISO20022.Reda002001.PriceValueChange1||XmlElement()||
|+|LwstPricVal|ISO20022.Reda002001.PriceValue5||XmlElement()||
|+|HghstPricVal|ISO20022.Reda002001.PriceValue5||XmlElement()||
|+|Prd|ISO20022.Reda002001.DateOrDateTimePeriodChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricChng),validElement(LwstPricVal),validElement(HghstPricVal),validElement(Prd))|

---

## Value ISO20022.Reda002001.Tax17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Reda002001.TaxCalculationInformation4||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|global::System.Collections.Generic.List<ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount>||XmlElement()||
|+|XtndedTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validList("""Amt""",Amt),validListMax("""Amt""",Amt,7),validElement(Amt),validChoice(TaxClctnDtls,Ctry,Rate,Amt,XtndedTp,Tp))|

---

## Value ISO20022.Reda002001.TaxCalculationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedEUDvddSts|String||XmlElement()||
|+|EUDvddSts|String||XmlElement()||
|+|TaxblIncmPerDvdd|ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|PctgGrdfthdDebt|Decimal||XmlElement()||
|+|PctgOfDebtClm|Decimal||XmlElement()||
|+|XtndedEUCptlGn|String||XmlElement()||
|+|EUCptlGn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblIncmPerDvdd),validChoice(XtndedEUDvddSts,EUDvddSts,TaxblIncmPerDvdd,PctgGrdfthdDebt,PctgOfDebtClm,XtndedEUCptlGn,EUCptlGn))|

---

## Enum ISO20022.Reda002001.TaxType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIET|Int32||XmlEnum("""MIET""")|1|
||ZWIS|Int32||XmlEnum("""ZWIS""")|2|
||AKT2|Int32||XmlEnum("""AKT2""")|3|
||AKT1|Int32||XmlEnum("""AKT1""")|4|
||EUTR|Int32||XmlEnum("""EUTR""")|5|
||INPO|Int32||XmlEnum("""INPO""")|6|

---

## Enum ISO20022.Reda002001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Enum ISO20022.Reda002001.TypeOfPrice6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAUP|Int32||XmlEnum("""NAUP""")|1|
||ACTU|Int32||XmlEnum("""ACTU""")|2|
||DDVR|Int32||XmlEnum("""DDVR""")|3|
||SWIC|Int32||XmlEnum("""SWIC""")|4|
||RINV|Int32||XmlEnum("""RINV""")|5|
||MIDD|Int32||XmlEnum("""MIDD""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||SWNG|Int32||XmlEnum("""SWNG""")|8|
||INTE|Int32||XmlEnum("""INTE""")|9|
||CANC|Int32||XmlEnum("""CANC""")|10|
||CREA|Int32||XmlEnum("""CREA""")|11|
||NAVL|Int32||XmlEnum("""NAVL""")|12|
||OFFR|Int32||XmlEnum("""OFFR""")|13|
||BIDE|Int32||XmlEnum("""BIDE""")|14|

---

## Enum ISO20022.Reda002001.TypeOfPrice9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENAV|Int32||XmlEnum("""ENAV""")|1|
||GUAR|Int32||XmlEnum("""GUAR""")|2|
||NAUP|Int32||XmlEnum("""NAUP""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|
||DDVR|Int32||XmlEnum("""DDVR""")|5|
||SWIC|Int32||XmlEnum("""SWIC""")|6|
||RINV|Int32||XmlEnum("""RINV""")|7|
||MIDD|Int32||XmlEnum("""MIDD""")|8|
||SWNG|Int32||XmlEnum("""SWNG""")|9|
||INTE|Int32||XmlEnum("""INTE""")|10|
||CANC|Int32||XmlEnum("""CANC""")|11|
||CREA|Int32||XmlEnum("""CREA""")|12|
||NAVL|Int32||XmlEnum("""NAVL""")|13|
||OFFR|Int32||XmlEnum("""OFFR""")|14|
||BIDE|Int32||XmlEnum("""BIDE""")|15|

---

## Value ISO20022.Reda002001.UnitPrice15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxRfndDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.Tax17>||XmlElement()||
|+|TaxLbltyDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.Tax17>||XmlElement()||
|+|ChrgDtls|global::System.Collections.Generic.List<ISO20022.Reda002001.Charge15>||XmlElement()||
|+|XtndedEUDvddSts|String||XmlElement()||
|+|EUDvddSts|String||XmlElement()||
|+|TaxblIncmPerDvdd|ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|XtndedTaxblIncmPerShrClctd|String||XmlElement()||
|+|TaxblIncmPerShrClctd|String||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Reda002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|EstmtdPricInd|String||XmlElement()||
|+|ClctnBsis|Decimal||XmlElement()||
|+|CumDvddInd|String||XmlElement()||
|+|ForExctnInd|String||XmlElement()||
|+|ValInAltrntvCcy|global::System.Collections.Generic.List<ISO20022.Reda002001.PriceValue1>||XmlElement()||
|+|ValInInvstmtCcy|global::System.Collections.Generic.List<ISO20022.Reda002001.PriceValue1>||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|XtndedTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxRfndDtls""",TaxRfndDtls),validElement(TaxRfndDtls),validList("""TaxLbltyDtls""",TaxLbltyDtls),validElement(TaxLbltyDtls),validList("""ChrgDtls""",ChrgDtls),validElement(ChrgDtls),validElement(TaxblIncmPerDvdd),validElement(TaxblIncmPerShr),validList("""ValInAltrntvCcy""",ValInAltrntvCcy),validElement(ValInAltrntvCcy),validRequired("""ValInInvstmtCcy""",ValInInvstmtCcy),validList("""ValInInvstmtCcy""",ValInInvstmtCcy),validElement(ValInInvstmtCcy),validChoice(TaxRfndDtls,TaxLbltyDtls,ChrgDtls,XtndedEUDvddSts,EUDvddSts,TaxblIncmPerDvdd,XtndedTaxblIncmPerShrClctd,TaxblIncmPerShrClctd,TaxblIncmPerShr,NbOfDaysAcrd,EstmtdPricInd,ClctnBsis,CumDvddInd,ForExctnInd,ValInAltrntvCcy,ValInInvstmtCcy,PricMtd,XtndedTp,Tp))|

---

## Value ISO20022.Reda002001.ValuationStatistics3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ByUsrDfndTmPrd|global::System.Collections.Generic.List<ISO20022.Reda002001.StatisticsByUserDefinedTimePeriod2>||XmlElement()||
|+|ByPrdfndTmPrds|ISO20022.Reda002001.StatisticsByPredefinedTimePeriods2||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|PricChng|ISO20022.Reda002001.PriceValueChange1||XmlElement()||
|+|PricTpChngBsis|ISO20022.Reda002001.PriceType2||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ByUsrDfndTmPrd""",ByUsrDfndTmPrd),validElement(ByUsrDfndTmPrd),validElement(ByPrdfndTmPrds),validElement(PricChng),validElement(PricTpChngBsis),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Reda002001.ValuationTiming1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PATC|Int32||XmlEnum("""PATC""")|1|
||USUA|Int32||XmlEnum("""USUA""")|2|
||EXCP|Int32||XmlEnum("""EXCP""")|3|

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

