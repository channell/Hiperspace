# auth.016.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth016001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth016001.AmountAndDirection53 {
        + Sgn  : String
        + Amt  : ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth016001.AmountAndDirection53 *-- ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth016001.AmountAndDirection61 {
        + Sgn  : String
        + Amt  : ISO20022.Auth016001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Auth016001.AmountAndDirection61 *-- ISO20022.Auth016001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Auth016001.AssetClassAttributes1 {
        + FX  : ISO20022.Auth016001.DerivativeForeignExchange2
        + Intrst  : ISO20022.Auth016001.DerivativeInterest2
    }
    ISO20022.Auth016001.AssetClassAttributes1 *-- ISO20022.Auth016001.DerivativeForeignExchange2
    ISO20022.Auth016001.AssetClassAttributes1 *-- ISO20022.Auth016001.DerivativeInterest2
    class ISO20022.Auth016001.AssetClassAttributes1Choice {
        + Both  : ISO20022.Auth016001.AssetClassAttributes1
        + FX  : ISO20022.Auth016001.DerivativeForeignExchange2
        + Intrst  : ISO20022.Auth016001.DerivativeInterest2
    }
    ISO20022.Auth016001.AssetClassAttributes1Choice *-- ISO20022.Auth016001.AssetClassAttributes1
    ISO20022.Auth016001.AssetClassAttributes1Choice *-- ISO20022.Auth016001.DerivativeForeignExchange2
    ISO20022.Auth016001.AssetClassAttributes1Choice *-- ISO20022.Auth016001.DerivativeInterest2
    class ISO20022.Auth016001.BasketDescription3 {
        + Indx  : global::System.Collections.Generic.List~ISO20022.Auth016001.FinancialInstrument58~
        + ISIN  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Auth016001.BasketDescription3 *-- ISO20022.Auth016001.FinancialInstrument58
    class ISO20022.Auth016001.BenchmarkCurveName2Code {
        BBSW = 1
        BUBO = 2
        CDOR = 3
        CIBO = 4
        EONA = 5
        EONS = 6
        EURI = 7
        EUUS = 8
        EUCH = 9
        FUSW = 10
        GCFR = 11
        ISDA = 12
        JIBA = 13
        LIBI = 14
        LIBO = 15
        MOSP = 16
        MAAA = 17
        NIBO = 18
        PFAN = 19
        PRBO = 20
        STBO = 21
        SWAP = 22
        TLBO = 23
        TIBO = 24
        TREA = 25
        WIBO = 26
    }
    class ISO20022.Auth016001.BenchmarkCurveName5Choice {
        + Nm  : String
        + Indx  : String
    }
    class ISO20022.Auth016001.CancelledStatusReason15Code {
        CSUB = 1
        CANI = 2
    }
    class ISO20022.Auth016001.DebtInstrument4 {
        + MtrtyDt  : DateTime
    }
    class ISO20022.Auth016001.DerivativeForeignExchange2 {
        + OthrNtnlCcy  : String
    }
    class ISO20022.Auth016001.DerivativeInstrument6 {
        + AsstClssSpcfcAttrbts  : ISO20022.Auth016001.AssetClassAttributes1Choice
        + DlvryTp  : String
        + OptnExrcStyle  : String
        + StrkPric  : ISO20022.Auth016001.SecuritiesTransactionPrice4Choice
        + OptnTp  : String
        + UndrlygInstrm  : ISO20022.Auth016001.UnderlyingIdentification2Choice
        + PricMltplr  : Decimal
        + XpryDt  : DateTime
    }
    ISO20022.Auth016001.DerivativeInstrument6 *-- ISO20022.Auth016001.AssetClassAttributes1Choice
    ISO20022.Auth016001.DerivativeInstrument6 *-- ISO20022.Auth016001.SecuritiesTransactionPrice4Choice
    ISO20022.Auth016001.DerivativeInstrument6 *-- ISO20022.Auth016001.UnderlyingIdentification2Choice
    class ISO20022.Auth016001.DerivativeInterest2 {
        + OthrNtnlCcy  : String
    }
    class ISO20022.Auth016001.DigitalTokenAmount2 {
        + Desc  : String
        + Unit  : Decimal
        + Idr  : String
    }
    class ISO20022.Auth016001.ExecutingParty1Choice {
        + Clnt  : String
        + Algo  : String
        + Prsn  : ISO20022.Auth016001.PersonIdentification12
    }
    ISO20022.Auth016001.ExecutingParty1Choice *-- ISO20022.Auth016001.PersonIdentification12
    class ISO20022.Auth016001.FinancialInstrument58 {
        + Nm  : ISO20022.Auth016001.FloatingInterestRate8
        + ISIN  : String
    }
    ISO20022.Auth016001.FinancialInstrument58 *-- ISO20022.Auth016001.FloatingInterestRate8
    class ISO20022.Auth016001.FinancialInstrumentAttributes5Choice {
        + Othr  : ISO20022.Auth016001.SecurityInstrumentDescription22
        + AltrnId  : ISO20022.Auth016001.SecurityIdentification19
        + Id  : String
    }
    ISO20022.Auth016001.FinancialInstrumentAttributes5Choice *-- ISO20022.Auth016001.SecurityInstrumentDescription22
    ISO20022.Auth016001.FinancialInstrumentAttributes5Choice *-- ISO20022.Auth016001.SecurityIdentification19
    class ISO20022.Auth016001.FinancialInstrumentIdentification6Choice {
        + Indx  : ISO20022.Auth016001.FinancialInstrument58
        + ISIN  : String
    }
    ISO20022.Auth016001.FinancialInstrumentIdentification6Choice *-- ISO20022.Auth016001.FinancialInstrument58
    class ISO20022.Auth016001.FinancialInstrumentIdentification7Choice {
        + Bskt  : ISO20022.Auth016001.BasketDescription3
        + Sngl  : ISO20022.Auth016001.FinancialInstrumentIdentification6Choice
    }
    ISO20022.Auth016001.FinancialInstrumentIdentification7Choice *-- ISO20022.Auth016001.BasketDescription3
    ISO20022.Auth016001.FinancialInstrumentIdentification7Choice *-- ISO20022.Auth016001.FinancialInstrumentIdentification6Choice
    class ISO20022.Auth016001.FinancialInstrumentQuantity25Choice {
        + MntryVal  : ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
        + NmnlVal  : ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
        + Unit  : Decimal
    }
    ISO20022.Auth016001.FinancialInstrumentQuantity25Choice *-- ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth016001.FinancialInstrumentQuantity25Choice *-- ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth016001.FinancialInstrumentReportingTransactionReportV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth016001.SupplementaryData1~
        + Tx  : global::System.Collections.Generic.List~ISO20022.Auth016001.ReportingTransactionType3Choice~
    }
    ISO20022.Auth016001.FinancialInstrumentReportingTransactionReportV03 *-- ISO20022.Auth016001.SupplementaryData1
    ISO20022.Auth016001.FinancialInstrumentReportingTransactionReportV03 *-- ISO20022.Auth016001.ReportingTransactionType3Choice
    class ISO20022.Auth016001.FloatingInterestRate8 {
        + Term  : ISO20022.Auth016001.InterestRateContractTerm2
        + RefRate  : ISO20022.Auth016001.BenchmarkCurveName5Choice
    }
    ISO20022.Auth016001.FloatingInterestRate8 *-- ISO20022.Auth016001.InterestRateContractTerm2
    ISO20022.Auth016001.FloatingInterestRate8 *-- ISO20022.Auth016001.BenchmarkCurveName5Choice
    class ISO20022.Auth016001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Auth016001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Auth016001.GenericPersonIdentification1 *-- ISO20022.Auth016001.PersonIdentificationSchemeName1Choice
    class ISO20022.Auth016001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth016001.InterestRateContractTerm2 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth016001.InternalPartyRole1Code {
        INTC = 1
    }
    class ISO20022.Auth016001.InvestmentParty1Choice {
        + Algo  : String
        + Prsn  : ISO20022.Auth016001.PersonIdentification12
    }
    ISO20022.Auth016001.InvestmentParty1Choice *-- ISO20022.Auth016001.PersonIdentification12
    class ISO20022.Auth016001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth016001.OptionStyle7Code {
        OTHR = 1
        EURO = 2
        BERM = 3
        ASIA = 4
        AMER = 5
    }
    class ISO20022.Auth016001.OptionType2Code {
        OTHR = 1
        PUTO = 2
        CALL = 3
    }
    class ISO20022.Auth016001.OtherIdentification1 {
        + Tp  : ISO20022.Auth016001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Auth016001.OtherIdentification1 *-- ISO20022.Auth016001.IdentificationSource3Choice
    class ISO20022.Auth016001.PartyIdentification76 {
        + CtryOfBrnch  : String
        + Id  : ISO20022.Auth016001.PersonOrOrganisation1Choice
    }
    ISO20022.Auth016001.PartyIdentification76 *-- ISO20022.Auth016001.PersonOrOrganisation1Choice
    class ISO20022.Auth016001.PartyIdentification79 {
        + DcsnMakr  : global::System.Collections.Generic.List~ISO20022.Auth016001.PersonOrOrganisation2Choice~
        + AcctOwnr  : global::System.Collections.Generic.List~ISO20022.Auth016001.PartyIdentification76~
    }
    ISO20022.Auth016001.PartyIdentification79 *-- ISO20022.Auth016001.PersonOrOrganisation2Choice
    ISO20022.Auth016001.PartyIdentification79 *-- ISO20022.Auth016001.PartyIdentification76
    class ISO20022.Auth016001.PersonIdentification10 {
        + Othr  : ISO20022.Auth016001.GenericPersonIdentification1
        + BirthDt  : DateTime
        + Nm  : String
        + FrstNm  : String
    }
    ISO20022.Auth016001.PersonIdentification10 *-- ISO20022.Auth016001.GenericPersonIdentification1
    class ISO20022.Auth016001.PersonIdentification12 {
        + Othr  : ISO20022.Auth016001.GenericPersonIdentification1
        + CtryOfBrnch  : String
    }
    ISO20022.Auth016001.PersonIdentification12 *-- ISO20022.Auth016001.GenericPersonIdentification1
    class ISO20022.Auth016001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth016001.PersonOrOrganisation1Choice {
        + Intl  : String
        + Prsn  : ISO20022.Auth016001.PersonIdentification10
        + MIC  : String
        + LEI  : String
    }
    ISO20022.Auth016001.PersonOrOrganisation1Choice *-- ISO20022.Auth016001.PersonIdentification10
    class ISO20022.Auth016001.PersonOrOrganisation2Choice {
        + Prsn  : ISO20022.Auth016001.PersonIdentification10
        + LEI  : String
    }
    ISO20022.Auth016001.PersonOrOrganisation2Choice *-- ISO20022.Auth016001.PersonIdentification10
    class ISO20022.Auth016001.PhysicalTransferType4Code {
        CASH = 1
        OPTL = 2
        PHYS = 3
    }
    class ISO20022.Auth016001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth016001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth016001.RecordTechnicalData2 {
        + CxlRsn  : String
        + RctDtTm  : DateTime
    }
    class ISO20022.Auth016001.RecordTechnicalData5 {
        + XchgRsn  : global::System.Collections.Generic.List~String~
        + RctDtTm  : DateTime
    }
    class ISO20022.Auth016001.RegulatoryTradingCapacity1Code {
        AOTC = 1
        DEAL = 2
        MTCH = 3
    }
    class ISO20022.Auth016001.ReportingTransactionType3Choice {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth016001.SupplementaryData1~
        + Cxl  : ISO20022.Auth016001.SecuritiesTransactionReport2
        + New  : ISO20022.Auth016001.SecuritiesTransactionReport7
    }
    ISO20022.Auth016001.ReportingTransactionType3Choice *-- ISO20022.Auth016001.SupplementaryData1
    ISO20022.Auth016001.ReportingTransactionType3Choice *-- ISO20022.Auth016001.SecuritiesTransactionReport2
    ISO20022.Auth016001.ReportingTransactionType3Choice *-- ISO20022.Auth016001.SecuritiesTransactionReport7
    class ISO20022.Auth016001.ReportingWaiverType1Code {
        SIZE = 1
        RFPT = 2
        ILQD = 3
        PRIC = 4
        NLIQ = 5
        OILQ = 6
    }
    class ISO20022.Auth016001.ReportingWaiverType3Code {
        XFPH = 1
        TPAC = 2
        TNCP = 3
        LRGS = 4
        DUPL = 5
        RPRI = 6
        SDIV = 7
        AMND = 8
        CANC = 9
        SIZE = 10
        ILQD = 11
        ACTX = 12
        BENC = 13
    }
    class ISO20022.Auth016001.SecuritiesTransaction3 {
        + CmplxTradCmpntId  : String
        + TradPlcMtchgId  : String
        + UpFrntPmt  : ISO20022.Auth016001.AmountAndDirection53
        + CtryOfBrnch  : String
        + TradVn  : String
        + NetAmt  : Decimal
        + Pric  : ISO20022.Auth016001.SecuritiesTransactionPrice22Choice
        + DerivNtnlChng  : String
        + DgtlTknQty  : global::System.Collections.Generic.List~ISO20022.Auth016001.DigitalTokenAmount2~
        + Qty  : ISO20022.Auth016001.FinancialInstrumentQuantity25Choice
        + TradgCpcty  : String
        + TradDt  : DateTime
    }
    ISO20022.Auth016001.SecuritiesTransaction3 *-- ISO20022.Auth016001.AmountAndDirection53
    ISO20022.Auth016001.SecuritiesTransaction3 *-- ISO20022.Auth016001.SecuritiesTransactionPrice22Choice
    ISO20022.Auth016001.SecuritiesTransaction3 *-- ISO20022.Auth016001.DigitalTokenAmount2
    ISO20022.Auth016001.SecuritiesTransaction3 *-- ISO20022.Auth016001.FinancialInstrumentQuantity25Choice
    class ISO20022.Auth016001.SecuritiesTransactionIndicator2 {
        + SctiesFincgTxInd  : String
        + RskRdcgTx  : String
        + OTCPstTradInd  : global::System.Collections.Generic.List~String~
        + ShrtSellgInd  : String
        + WvrInd  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth016001.SecuritiesTransactionPrice1 {
        + Ccy  : String
        + Pdg  : String
    }
    class ISO20022.Auth016001.SecuritiesTransactionPrice22Choice {
        + NoPric  : ISO20022.Auth016001.SecuritiesTransactionPrice6
        + DgtlTknPric  : ISO20022.Auth016001.SecuritiesTransactionPrice7
        + Pric  : ISO20022.Auth016001.SecuritiesTransactionPrice2Choice
    }
    ISO20022.Auth016001.SecuritiesTransactionPrice22Choice *-- ISO20022.Auth016001.SecuritiesTransactionPrice6
    ISO20022.Auth016001.SecuritiesTransactionPrice22Choice *-- ISO20022.Auth016001.SecuritiesTransactionPrice7
    ISO20022.Auth016001.SecuritiesTransactionPrice22Choice *-- ISO20022.Auth016001.SecuritiesTransactionPrice2Choice
    class ISO20022.Auth016001.SecuritiesTransactionPrice2Choice {
        + BsisPts  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth016001.AmountAndDirection61
    }
    ISO20022.Auth016001.SecuritiesTransactionPrice2Choice *-- ISO20022.Auth016001.AmountAndDirection61
    class ISO20022.Auth016001.SecuritiesTransactionPrice4Choice {
        + NoPric  : ISO20022.Auth016001.SecuritiesTransactionPrice1
        + Pric  : ISO20022.Auth016001.SecuritiesTransactionPrice2Choice
    }
    ISO20022.Auth016001.SecuritiesTransactionPrice4Choice *-- ISO20022.Auth016001.SecuritiesTransactionPrice1
    ISO20022.Auth016001.SecuritiesTransactionPrice4Choice *-- ISO20022.Auth016001.SecuritiesTransactionPrice2Choice
    class ISO20022.Auth016001.SecuritiesTransactionPrice6 {
        + DgtlTkn  : global::System.Collections.Generic.List~ISO20022.Auth016001.DigitalTokenAmount2~
        + Ccy  : String
        + Pdg  : String
    }
    ISO20022.Auth016001.SecuritiesTransactionPrice6 *-- ISO20022.Auth016001.DigitalTokenAmount2
    class ISO20022.Auth016001.SecuritiesTransactionPrice7 {
        + DgtlTknQty  : ISO20022.Auth016001.DigitalTokenAmount2
        + MntryVal  : ISO20022.Auth016001.AmountAndDirection61
    }
    ISO20022.Auth016001.SecuritiesTransactionPrice7 *-- ISO20022.Auth016001.DigitalTokenAmount2
    ISO20022.Auth016001.SecuritiesTransactionPrice7 *-- ISO20022.Auth016001.AmountAndDirection61
    class ISO20022.Auth016001.SecuritiesTransactionReport2 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth016001.SupplementaryData1~
        + TechAttrbts  : ISO20022.Auth016001.RecordTechnicalData2
        + SubmitgPty  : String
        + ExctgPty  : String
        + TxId  : String
    }
    ISO20022.Auth016001.SecuritiesTransactionReport2 *-- ISO20022.Auth016001.SupplementaryData1
    ISO20022.Auth016001.SecuritiesTransactionReport2 *-- ISO20022.Auth016001.RecordTechnicalData2
    class ISO20022.Auth016001.SecuritiesTransactionReport7 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth016001.SupplementaryData1~
        + TechAttrbts  : ISO20022.Auth016001.RecordTechnicalData5
        + AddtlAttrbts  : ISO20022.Auth016001.SecuritiesTransactionIndicator2
        + ExctgPrsn  : ISO20022.Auth016001.ExecutingParty1Choice
        + InvstmtDcsnPrsn  : ISO20022.Auth016001.InvestmentParty1Choice
        + FinInstrm  : ISO20022.Auth016001.FinancialInstrumentAttributes5Choice
        + Tx  : ISO20022.Auth016001.SecuritiesTransaction3
        + OrdrTrnsmssn  : ISO20022.Auth016001.SecuritiesTransactionTransmission2
        + Sellr  : ISO20022.Auth016001.PartyIdentification79
        + Buyr  : ISO20022.Auth016001.PartyIdentification79
        + SubmitgPty  : String
        + InvstmtPtyInd  : String
        + ExctgPty  : String
        + TxId  : String
    }
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.SupplementaryData1
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.RecordTechnicalData5
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.SecuritiesTransactionIndicator2
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.ExecutingParty1Choice
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.InvestmentParty1Choice
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.FinancialInstrumentAttributes5Choice
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.SecuritiesTransaction3
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.SecuritiesTransactionTransmission2
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.PartyIdentification79
    ISO20022.Auth016001.SecuritiesTransactionReport7 *-- ISO20022.Auth016001.PartyIdentification79
    class ISO20022.Auth016001.SecuritiesTransactionTransmission2 {
        + TrnsmttgSellr  : String
        + TrnsmttgBuyr  : String
        + TrnsmssnInd  : String
    }
    class ISO20022.Auth016001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Auth016001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Auth016001.SecurityIdentification19 *-- ISO20022.Auth016001.OtherIdentification1
    class ISO20022.Auth016001.SecurityInstrumentDescription22 {
        + DerivInstrmAttrbts  : ISO20022.Auth016001.DerivativeInstrument6
        + DebtInstrmAttrbts  : ISO20022.Auth016001.DebtInstrument4
        + FinInstrmGnlAttrbts  : ISO20022.Auth016001.SecurityInstrumentDescription23
    }
    ISO20022.Auth016001.SecurityInstrumentDescription22 *-- ISO20022.Auth016001.DerivativeInstrument6
    ISO20022.Auth016001.SecurityInstrumentDescription22 *-- ISO20022.Auth016001.DebtInstrument4
    ISO20022.Auth016001.SecurityInstrumentDescription22 *-- ISO20022.Auth016001.SecurityInstrumentDescription23
    class ISO20022.Auth016001.SecurityInstrumentDescription23 {
        + NtnlCcy  : String
        + ClssfctnTp  : String
        + FullNm  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Auth016001.OtherIdentification1~
        + Id  : String
    }
    ISO20022.Auth016001.SecurityInstrumentDescription23 *-- ISO20022.Auth016001.OtherIdentification1
    class ISO20022.Auth016001.Side5Code {
        UNDI = 1
        SSEX = 2
        SELL = 3
        SESH = 4
    }
    class ISO20022.Auth016001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth016001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth016001.SupplementaryData1 *-- ISO20022.Auth016001.SupplementaryDataEnvelope1
    class ISO20022.Auth016001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth016001.SwapLegIdentification2 {
        + SwpOut  : ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
        + SwpIn  : ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
    }
    ISO20022.Auth016001.SwapLegIdentification2 *-- ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
    ISO20022.Auth016001.SwapLegIdentification2 *-- ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
    class ISO20022.Auth016001.UnderlyingIdentification2Choice {
        + Othr  : ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
        + Swp  : ISO20022.Auth016001.SwapLegIdentification2
    }
    ISO20022.Auth016001.UnderlyingIdentification2Choice *-- ISO20022.Auth016001.FinancialInstrumentIdentification7Choice
    ISO20022.Auth016001.UnderlyingIdentification2Choice *-- ISO20022.Auth016001.SwapLegIdentification2
    class ISO20022.Auth016001.VariationType1Code {
        INCR = 1
        DECR = 2
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

## Value ISO20022.Auth016001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.AmountAndDirection53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth016001.AmountAndDirection61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth016001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth016001.AssetClassAttributes1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FX|ISO20022.Auth016001.DerivativeForeignExchange2||XmlElement()||
|+|Intrst|ISO20022.Auth016001.DerivativeInterest2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FX),validElement(Intrst))|

---

## Value ISO20022.Auth016001.AssetClassAttributes1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Both|ISO20022.Auth016001.AssetClassAttributes1||XmlElement()||
|+|FX|ISO20022.Auth016001.DerivativeForeignExchange2||XmlElement()||
|+|Intrst|ISO20022.Auth016001.DerivativeInterest2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Both),validElement(FX),validElement(Intrst),validChoice(Both,FX,Intrst))|

---

## Value ISO20022.Auth016001.BasketDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|global::System.Collections.Generic.List<ISO20022.Auth016001.FinancialInstrument58>||XmlElement()||
|+|ISIN|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Indx""",Indx),validElement(Indx),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Auth016001.BenchmarkCurveName2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BBSW|Int32||XmlEnum("""BBSW""")|1|
||BUBO|Int32||XmlEnum("""BUBO""")|2|
||CDOR|Int32||XmlEnum("""CDOR""")|3|
||CIBO|Int32||XmlEnum("""CIBO""")|4|
||EONA|Int32||XmlEnum("""EONA""")|5|
||EONS|Int32||XmlEnum("""EONS""")|6|
||EURI|Int32||XmlEnum("""EURI""")|7|
||EUUS|Int32||XmlEnum("""EUUS""")|8|
||EUCH|Int32||XmlEnum("""EUCH""")|9|
||FUSW|Int32||XmlEnum("""FUSW""")|10|
||GCFR|Int32||XmlEnum("""GCFR""")|11|
||ISDA|Int32||XmlEnum("""ISDA""")|12|
||JIBA|Int32||XmlEnum("""JIBA""")|13|
||LIBI|Int32||XmlEnum("""LIBI""")|14|
||LIBO|Int32||XmlEnum("""LIBO""")|15|
||MOSP|Int32||XmlEnum("""MOSP""")|16|
||MAAA|Int32||XmlEnum("""MAAA""")|17|
||NIBO|Int32||XmlEnum("""NIBO""")|18|
||PFAN|Int32||XmlEnum("""PFAN""")|19|
||PRBO|Int32||XmlEnum("""PRBO""")|20|
||STBO|Int32||XmlEnum("""STBO""")|21|
||SWAP|Int32||XmlEnum("""SWAP""")|22|
||TLBO|Int32||XmlEnum("""TLBO""")|23|
||TIBO|Int32||XmlEnum("""TIBO""")|24|
||TREA|Int32||XmlEnum("""TREA""")|25|
||WIBO|Int32||XmlEnum("""WIBO""")|26|

---

## Value ISO20022.Auth016001.BenchmarkCurveName5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Nm,Indx))|

---

## Enum ISO20022.Auth016001.CancelledStatusReason15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSUB|Int32||XmlEnum("""CSUB""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Value ISO20022.Auth016001.DebtInstrument4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtrtyDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth016001.DerivativeForeignExchange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrNtnlCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrNtnlCcy""",OthrNtnlCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.DerivativeInstrument6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AsstClssSpcfcAttrbts|ISO20022.Auth016001.AssetClassAttributes1Choice||XmlElement()||
|+|DlvryTp|String||XmlElement()||
|+|OptnExrcStyle|String||XmlElement()||
|+|StrkPric|ISO20022.Auth016001.SecuritiesTransactionPrice4Choice||XmlElement()||
|+|OptnTp|String||XmlElement()||
|+|UndrlygInstrm|ISO20022.Auth016001.UnderlyingIdentification2Choice||XmlElement()||
|+|PricMltplr|Decimal||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AsstClssSpcfcAttrbts),validElement(StrkPric),validElement(UndrlygInstrm))|

---

## Value ISO20022.Auth016001.DerivativeInterest2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrNtnlCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrNtnlCcy""",OthrNtnlCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.DigitalTokenAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|Idr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Idr""",Idr,"""[1-9B-DF-HJ-NP-XZ][0-9B-DF-HJ-NP-XZ]{8,8}"""))|

---

## Type ISO20022.Auth016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmRptgTxRpt|ISO20022.Auth016001.FinancialInstrumentReportingTransactionReportV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmRptgTxRpt))|

---

## Value ISO20022.Auth016001.ExecutingParty1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clnt|String||XmlElement()||
|+|Algo|String||XmlElement()||
|+|Prsn|ISO20022.Auth016001.PersonIdentification12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prsn),validChoice(Clnt,Algo,Prsn))|

---

## Value ISO20022.Auth016001.FinancialInstrument58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|ISO20022.Auth016001.FloatingInterestRate8||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Nm),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth016001.FinancialInstrumentAttributes5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth016001.SecurityInstrumentDescription22||XmlElement()||
|+|AltrnId|ISO20022.Auth016001.SecurityIdentification19||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(AltrnId),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Othr,AltrnId,Id))|

---

## Value ISO20022.Auth016001.FinancialInstrumentIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|ISO20022.Auth016001.FinancialInstrument58||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indx),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Indx,ISIN))|

---

## Value ISO20022.Auth016001.FinancialInstrumentIdentification7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bskt|ISO20022.Auth016001.BasketDescription3||XmlElement()||
|+|Sngl|ISO20022.Auth016001.FinancialInstrumentIdentification6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bskt),validElement(Sngl),validChoice(Bskt,Sngl))|

---

## Value ISO20022.Auth016001.FinancialInstrumentQuantity25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MntryVal|ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NmnlVal|ISO20022.Auth016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validElement(NmnlVal),validChoice(MntryVal,NmnlVal,Unit))|

---

## Aspect ISO20022.Auth016001.FinancialInstrumentReportingTransactionReportV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth016001.SupplementaryData1>||XmlElement()||
|+|Tx|global::System.Collections.Generic.List<ISO20022.Auth016001.ReportingTransactionType3Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx))|

---

## Value ISO20022.Auth016001.FloatingInterestRate8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|ISO20022.Auth016001.InterestRateContractTerm2||XmlElement()||
|+|RefRate|ISO20022.Auth016001.BenchmarkCurveName5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validElement(RefRate))|

---

## Value ISO20022.Auth016001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Auth016001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Auth016001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth016001.InterestRateContractTerm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth016001.InternalPartyRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INTC|Int32||XmlEnum("""INTC""")|1|

---

## Value ISO20022.Auth016001.InvestmentParty1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
|+|Prsn|ISO20022.Auth016001.PersonIdentification12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prsn),validChoice(Algo,Prsn))|

---

## Enum ISO20022.Auth016001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Enum ISO20022.Auth016001.OptionStyle7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EURO|Int32||XmlEnum("""EURO""")|2|
||BERM|Int32||XmlEnum("""BERM""")|3|
||ASIA|Int32||XmlEnum("""ASIA""")|4|
||AMER|Int32||XmlEnum("""AMER""")|5|

---

## Enum ISO20022.Auth016001.OptionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||PUTO|Int32||XmlEnum("""PUTO""")|2|
||CALL|Int32||XmlEnum("""CALL""")|3|

---

## Value ISO20022.Auth016001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Auth016001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth016001.PartyIdentification76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBrnch|String||XmlElement()||
|+|Id|ISO20022.Auth016001.PersonOrOrganisation1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBrnch""",CtryOfBrnch,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth016001.PartyIdentification79


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DcsnMakr|global::System.Collections.Generic.List<ISO20022.Auth016001.PersonOrOrganisation2Choice>||XmlElement()||
|+|AcctOwnr|global::System.Collections.Generic.List<ISO20022.Auth016001.PartyIdentification76>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DcsnMakr""",DcsnMakr),validElement(DcsnMakr),validRequired("""AcctOwnr""",AcctOwnr),validList("""AcctOwnr""",AcctOwnr),validElement(AcctOwnr))|

---

## Value ISO20022.Auth016001.PersonIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth016001.GenericPersonIdentification1||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
|+|Nm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr))|

---

## Value ISO20022.Auth016001.PersonIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth016001.GenericPersonIdentification1||XmlElement()||
|+|CtryOfBrnch|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""CtryOfBrnch""",CtryOfBrnch,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth016001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth016001.PersonOrOrganisation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intl|String||XmlElement()||
|+|Prsn|ISO20022.Auth016001.PersonIdentification10||XmlElement()||
|+|MIC|String||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prsn),validPattern("""MIC""",MIC,"""[A-Z0-9]{4,4}"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(Intl,Prsn,MIC,LEI))|

---

## Value ISO20022.Auth016001.PersonOrOrganisation2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prsn|ISO20022.Auth016001.PersonIdentification10||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prsn),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(Prsn,LEI))|

---

## Enum ISO20022.Auth016001.PhysicalTransferType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||OPTL|Int32||XmlEnum("""OPTL""")|2|
||PHYS|Int32||XmlEnum("""PHYS""")|3|

---

## Enum ISO20022.Auth016001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Enum ISO20022.Auth016001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth016001.RecordTechnicalData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlRsn|String||XmlElement()||
|+|RctDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth016001.RecordTechnicalData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RctDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""XchgRsn""",XchgRsn))|

---

## Enum ISO20022.Auth016001.RegulatoryTradingCapacity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AOTC|Int32||XmlEnum("""AOTC""")|1|
||DEAL|Int32||XmlEnum("""DEAL""")|2|
||MTCH|Int32||XmlEnum("""MTCH""")|3|

---

## Value ISO20022.Auth016001.ReportingTransactionType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth016001.SupplementaryData1>||XmlElement()||
|+|Cxl|ISO20022.Auth016001.SecuritiesTransactionReport2||XmlElement()||
|+|New|ISO20022.Auth016001.SecuritiesTransactionReport7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Cxl),validElement(New),validChoice(SplmtryData,Cxl,New))|

---

## Enum ISO20022.Auth016001.ReportingWaiverType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SIZE|Int32||XmlEnum("""SIZE""")|1|
||RFPT|Int32||XmlEnum("""RFPT""")|2|
||ILQD|Int32||XmlEnum("""ILQD""")|3|
||PRIC|Int32||XmlEnum("""PRIC""")|4|
||NLIQ|Int32||XmlEnum("""NLIQ""")|5|
||OILQ|Int32||XmlEnum("""OILQ""")|6|

---

## Enum ISO20022.Auth016001.ReportingWaiverType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||XFPH|Int32||XmlEnum("""XFPH""")|1|
||TPAC|Int32||XmlEnum("""TPAC""")|2|
||TNCP|Int32||XmlEnum("""TNCP""")|3|
||LRGS|Int32||XmlEnum("""LRGS""")|4|
||DUPL|Int32||XmlEnum("""DUPL""")|5|
||RPRI|Int32||XmlEnum("""RPRI""")|6|
||SDIV|Int32||XmlEnum("""SDIV""")|7|
||AMND|Int32||XmlEnum("""AMND""")|8|
||CANC|Int32||XmlEnum("""CANC""")|9|
||SIZE|Int32||XmlEnum("""SIZE""")|10|
||ILQD|Int32||XmlEnum("""ILQD""")|11|
||ACTX|Int32||XmlEnum("""ACTX""")|12|
||BENC|Int32||XmlEnum("""BENC""")|13|

---

## Value ISO20022.Auth016001.SecuritiesTransaction3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmplxTradCmpntId|String||XmlElement()||
|+|TradPlcMtchgId|String||XmlElement()||
|+|UpFrntPmt|ISO20022.Auth016001.AmountAndDirection53||XmlElement()||
|+|CtryOfBrnch|String||XmlElement()||
|+|TradVn|String||XmlElement()||
|+|NetAmt|Decimal||XmlElement()||
|+|Pric|ISO20022.Auth016001.SecuritiesTransactionPrice22Choice||XmlElement()||
|+|DerivNtnlChng|String||XmlElement()||
|+|DgtlTknQty|global::System.Collections.Generic.List<ISO20022.Auth016001.DigitalTokenAmount2>||XmlElement()||
|+|Qty|ISO20022.Auth016001.FinancialInstrumentQuantity25Choice||XmlElement()||
|+|TradgCpcty|String||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpFrntPmt),validPattern("""CtryOfBrnch""",CtryOfBrnch,"""[A-Z]{2,2}"""),validPattern("""TradVn""",TradVn,"""[A-Z0-9]{4,4}"""),validElement(Pric),validList("""DgtlTknQty""",DgtlTknQty),validElement(DgtlTknQty),validElement(Qty))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionIndicator2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgTxInd|String||XmlElement()||
|+|RskRdcgTx|String||XmlElement()||
|+|OTCPstTradInd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ShrtSellgInd|String||XmlElement()||
|+|WvrInd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Pdg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPric|ISO20022.Auth016001.SecuritiesTransactionPrice6||XmlElement()||
|+|DgtlTknPric|ISO20022.Auth016001.SecuritiesTransactionPrice7||XmlElement()||
|+|Pric|ISO20022.Auth016001.SecuritiesTransactionPrice2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NoPric),validElement(DgtlTknPric),validElement(Pric),validChoice(NoPric,DgtlTknPric,Pric))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPts|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth016001.AmountAndDirection61||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPts,Yld,Pctg,MntryVal))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPric|ISO20022.Auth016001.SecuritiesTransactionPrice1||XmlElement()||
|+|Pric|ISO20022.Auth016001.SecuritiesTransactionPrice2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NoPric),validElement(Pric),validChoice(NoPric,Pric))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTkn|global::System.Collections.Generic.List<ISO20022.Auth016001.DigitalTokenAmount2>||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Pdg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DgtlTkn""",DgtlTkn),validElement(DgtlTkn),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionPrice7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknQty|ISO20022.Auth016001.DigitalTokenAmount2||XmlElement()||
|+|MntryVal|ISO20022.Auth016001.AmountAndDirection61||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlTknQty),validElement(MntryVal))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionReport2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth016001.SupplementaryData1>||XmlElement()||
|+|TechAttrbts|ISO20022.Auth016001.RecordTechnicalData2||XmlElement()||
|+|SubmitgPty|String||XmlElement()||
|+|ExctgPty|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TechAttrbts),validPattern("""SubmitgPty""",SubmitgPty,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""ExctgPty""",ExctgPty,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionReport7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth016001.SupplementaryData1>||XmlElement()||
|+|TechAttrbts|ISO20022.Auth016001.RecordTechnicalData5||XmlElement()||
|+|AddtlAttrbts|ISO20022.Auth016001.SecuritiesTransactionIndicator2||XmlElement()||
|+|ExctgPrsn|ISO20022.Auth016001.ExecutingParty1Choice||XmlElement()||
|+|InvstmtDcsnPrsn|ISO20022.Auth016001.InvestmentParty1Choice||XmlElement()||
|+|FinInstrm|ISO20022.Auth016001.FinancialInstrumentAttributes5Choice||XmlElement()||
|+|Tx|ISO20022.Auth016001.SecuritiesTransaction3||XmlElement()||
|+|OrdrTrnsmssn|ISO20022.Auth016001.SecuritiesTransactionTransmission2||XmlElement()||
|+|Sellr|ISO20022.Auth016001.PartyIdentification79||XmlElement()||
|+|Buyr|ISO20022.Auth016001.PartyIdentification79||XmlElement()||
|+|SubmitgPty|String||XmlElement()||
|+|InvstmtPtyInd|String||XmlElement()||
|+|ExctgPty|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TechAttrbts),validElement(AddtlAttrbts),validElement(ExctgPrsn),validElement(InvstmtDcsnPrsn),validElement(FinInstrm),validElement(Tx),validElement(OrdrTrnsmssn),validElement(Sellr),validElement(Buyr),validPattern("""SubmitgPty""",SubmitgPty,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""ExctgPty""",ExctgPty,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth016001.SecuritiesTransactionTransmission2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrnsmttgSellr|String||XmlElement()||
|+|TrnsmttgBuyr|String||XmlElement()||
|+|TrnsmssnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TrnsmttgSellr""",TrnsmttgSellr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""TrnsmttgBuyr""",TrnsmttgBuyr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth016001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Auth016001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth016001.SecurityInstrumentDescription22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivInstrmAttrbts|ISO20022.Auth016001.DerivativeInstrument6||XmlElement()||
|+|DebtInstrmAttrbts|ISO20022.Auth016001.DebtInstrument4||XmlElement()||
|+|FinInstrmGnlAttrbts|ISO20022.Auth016001.SecurityInstrumentDescription23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivInstrmAttrbts),validElement(DebtInstrmAttrbts),validElement(FinInstrmGnlAttrbts))|

---

## Value ISO20022.Auth016001.SecurityInstrumentDescription23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtnlCcy|String||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|FullNm|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Auth016001.OtherIdentification1>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NtnlCcy""",NtnlCcy,"""[A-Z]{3,3}"""),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Auth016001.Side5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNDI|Int32||XmlEnum("""UNDI""")|1|
||SSEX|Int32||XmlEnum("""SSEX""")|2|
||SELL|Int32||XmlEnum("""SELL""")|3|
||SESH|Int32||XmlEnum("""SESH""")|4|

---

## Value ISO20022.Auth016001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth016001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth016001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth016001.SwapLegIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SwpOut|ISO20022.Auth016001.FinancialInstrumentIdentification7Choice||XmlElement()||
|+|SwpIn|ISO20022.Auth016001.FinancialInstrumentIdentification7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SwpOut),validElement(SwpIn))|

---

## Value ISO20022.Auth016001.UnderlyingIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth016001.FinancialInstrumentIdentification7Choice||XmlElement()||
|+|Swp|ISO20022.Auth016001.SwapLegIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Swp),validChoice(Othr,Swp))|

---

## Enum ISO20022.Auth016001.VariationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCR|Int32||XmlEnum("""INCR""")|1|
||DECR|Int32||XmlEnum("""DECR""")|2|

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

