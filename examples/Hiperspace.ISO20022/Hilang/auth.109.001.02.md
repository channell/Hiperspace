# auth.109.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth109001.CollateralPortfolioCode6Choice {
        + MrgnPrtflCd  : ISO20022.Auth109001.MarginPortfolio4
        + Prtfl  : ISO20022.Auth109001.PortfolioCode3Choice
    }
    ISO20022.Auth109001.CollateralPortfolioCode6Choice *-- ISO20022.Auth109001.MarginPortfolio4
    ISO20022.Auth109001.CollateralPortfolioCode6Choice *-- ISO20022.Auth109001.PortfolioCode3Choice
    class ISO20022.Auth109001.CollateralisationType3Code {
        UNCL = 1
        PRC2 = 2
        PRC1 = 3
        PRCL = 4
        OWP2 = 5
        OWP1 = 6
        OWC2 = 7
        OWC1 = 8
        OWCL = 9
        FLCL = 10
    }
    class ISO20022.Auth109001.ContractModification8 {
        + ActnTp  : String
    }
    class ISO20022.Auth109001.Counterparty45 {
        + RptgXmptn  : ISO20022.Auth109001.ReportingExemption1
        + BookgLctn  : String
        + TradrLctn  : String
        + DrctnOrSd  : ISO20022.Auth109001.Direction4Choice
        + TradgCpcty  : String
        + Ntr  : ISO20022.Auth109001.CounterpartyTradeNature15Choice
        + Id  : ISO20022.Auth109001.PartyIdentification248Choice
    }
    ISO20022.Auth109001.Counterparty45 *-- ISO20022.Auth109001.ReportingExemption1
    ISO20022.Auth109001.Counterparty45 *-- ISO20022.Auth109001.Direction4Choice
    ISO20022.Auth109001.Counterparty45 *-- ISO20022.Auth109001.CounterpartyTradeNature15Choice
    ISO20022.Auth109001.Counterparty45 *-- ISO20022.Auth109001.PartyIdentification248Choice
    class ISO20022.Auth109001.Counterparty46 {
        + RptgOblgtn  : String
        + Ntr  : ISO20022.Auth109001.CounterpartyTradeNature15Choice
        + IdTp  : ISO20022.Auth109001.PartyIdentification248Choice
    }
    ISO20022.Auth109001.Counterparty46 *-- ISO20022.Auth109001.CounterpartyTradeNature15Choice
    ISO20022.Auth109001.Counterparty46 *-- ISO20022.Auth109001.PartyIdentification248Choice
    class ISO20022.Auth109001.CounterpartyTradeNature15Choice {
        + Othr  : String
        + CntrlCntrPty  : String
        + NFI  : ISO20022.Auth109001.NonFinancialInstitutionSector10
        + FI  : ISO20022.Auth109001.FinancialInstitutionSector1
    }
    ISO20022.Auth109001.CounterpartyTradeNature15Choice *-- ISO20022.Auth109001.NonFinancialInstitutionSector10
    ISO20022.Auth109001.CounterpartyTradeNature15Choice *-- ISO20022.Auth109001.FinancialInstitutionSector1
    class ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth109001.SupplementaryData1~
        + TradData  : ISO20022.Auth109001.TradeData62Choice
        + RptHdr  : ISO20022.Auth109001.TradeReportHeader4
    }
    ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02 *-- ISO20022.Auth109001.SupplementaryData1
    ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02 *-- ISO20022.Auth109001.TradeData62Choice
    ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02 *-- ISO20022.Auth109001.TradeReportHeader4
    class ISO20022.Auth109001.Direction2 {
        + DrctnOfTheScndLeg  : String
        + DrctnOfTheFrstLeg  : String
    }
    class ISO20022.Auth109001.Direction4Choice {
        + CtrPtySd  : String
        + Drctn  : ISO20022.Auth109001.Direction2
    }
    ISO20022.Auth109001.Direction4Choice *-- ISO20022.Auth109001.Direction2
    class ISO20022.Auth109001.FinancialInstitutionSector1 {
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth109001.FinancialPartyClassification2Choice~
    }
    ISO20022.Auth109001.FinancialInstitutionSector1 *-- ISO20022.Auth109001.FinancialPartyClassification2Choice
    class ISO20022.Auth109001.FinancialPartyClassification2Choice {
        + Prtry  : ISO20022.Auth109001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth109001.FinancialPartyClassification2Choice *-- ISO20022.Auth109001.GenericIdentification175
    class ISO20022.Auth109001.FinancialPartySectorType3Code {
        OTHR = 1
        ASSU = 2
        UCIT = 3
        REIN = 4
        INVF = 5
        ORPI = 6
        INUN = 7
        CDTI = 8
        CCPS = 9
        CSDS = 10
        AIFD = 11
    }
    class ISO20022.Auth109001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth109001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth109001.OrganisationIdentification15Choice
    }
    ISO20022.Auth109001.LegalPersonIdentification1 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    class ISO20022.Auth109001.MarginCollateralReport5 {
        + TmStmp  : DateTime
        + CollstnCtgy  : String
        + CollPrtflCd  : ISO20022.Auth109001.CollateralPortfolioCode6Choice
    }
    ISO20022.Auth109001.MarginCollateralReport5 *-- ISO20022.Auth109001.CollateralPortfolioCode6Choice
    class ISO20022.Auth109001.MarginPortfolio4 {
        + VartnMrgnPrtflCd  : ISO20022.Auth109001.PortfolioCode5Choice
        + InitlMrgnPrtflCd  : ISO20022.Auth109001.PortfolioCode5Choice
    }
    ISO20022.Auth109001.MarginPortfolio4 *-- ISO20022.Auth109001.PortfolioCode5Choice
    ISO20022.Auth109001.MarginPortfolio4 *-- ISO20022.Auth109001.PortfolioCode5Choice
    class ISO20022.Auth109001.MarginReportData10 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth109001.SupplementaryData1~
        + TechAttrbts  : ISO20022.Auth109001.TechnicalAttributes6
        + CtrctMod  : ISO20022.Auth109001.ContractModification8
        + CtrPtyRatgThrshldInd  : String
        + CtrPtyRatgTrggrInd  : String
        + RcvdMrgnOrColl  : ISO20022.Auth109001.ReceivedMarginOrCollateral6
        + PstdMrgnOrColl  : ISO20022.Auth109001.PostedMarginOrCollateral6
        + Coll  : ISO20022.Auth109001.MarginCollateralReport5
        + TxId  : ISO20022.Auth109001.UniqueTransactionIdentifier2Choice
        + EvtDt  : DateTime
        + CtrPtyId  : ISO20022.Auth109001.TradeCounterpartyReport20
        + RptgTmStmp  : DateTime
    }
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.SupplementaryData1
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.TechnicalAttributes6
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.ContractModification8
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.ReceivedMarginOrCollateral6
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.PostedMarginOrCollateral6
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.MarginCollateralReport5
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth109001.MarginReportData10 *-- ISO20022.Auth109001.TradeCounterpartyReport20
    class ISO20022.Auth109001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth109001.GenericIdentification175
    }
    ISO20022.Auth109001.NaturalPersonIdentification2 *-- ISO20022.Auth109001.GenericIdentification175
    class ISO20022.Auth109001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth109001.NaturalPersonIdentification2
    }
    ISO20022.Auth109001.NaturalPersonIdentification3 *-- ISO20022.Auth109001.NaturalPersonIdentification2
    class ISO20022.Auth109001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth109001.NonFinancialInstitutionSector10 {
        + FdrlInstn  : String
        + DrctlyLkdActvty  : String
        + ClrThrshld  : String
        + Sctr  : global::System.Collections.Generic.List~ISO20022.Auth109001.GenericIdentification175~
    }
    ISO20022.Auth109001.NonFinancialInstitutionSector10 *-- ISO20022.Auth109001.GenericIdentification175
    class ISO20022.Auth109001.NotApplicable1Code {
        NOAP = 1
    }
    class ISO20022.Auth109001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Auth109001.OptionParty3Code {
        TAKE = 1
        MAKE = 2
    }
    class ISO20022.Auth109001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth109001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth109001.OrganisationIdentification15Choice *-- ISO20022.Auth109001.OrganisationIdentification38
    class ISO20022.Auth109001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth109001.GenericIdentification175
    }
    ISO20022.Auth109001.OrganisationIdentification38 *-- ISO20022.Auth109001.GenericIdentification175
    class ISO20022.Auth109001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Auth109001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth109001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth109001.LegalPersonIdentification1
    }
    ISO20022.Auth109001.PartyIdentification248Choice *-- ISO20022.Auth109001.NaturalPersonIdentification3
    ISO20022.Auth109001.PartyIdentification248Choice *-- ISO20022.Auth109001.LegalPersonIdentification1
    class ISO20022.Auth109001.PortfolioCode3Choice {
        + NoPrtfl  : String
        + Cd  : String
    }
    class ISO20022.Auth109001.PortfolioCode5Choice {
        + NoPrtfl  : String
        + Prtfl  : ISO20022.Auth109001.PortfolioIdentification3
    }
    ISO20022.Auth109001.PortfolioCode5Choice *-- ISO20022.Auth109001.PortfolioIdentification3
    class ISO20022.Auth109001.PortfolioIdentification3 {
        + PrtflTxXmptn  : String
        + Cd  : String
    }
    class ISO20022.Auth109001.PostedMarginOrCollateral6 {
        + XcssCollPstd  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnPstdPstHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnPstdPreHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnPstdPstHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnPstdPreHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth109001.PostedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.PostedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.PostedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.PostedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.PostedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth109001.ReceivedMarginOrCollateral6 {
        + XcssCollRcvd  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnRcvdPstHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + VartnMrgnRcvdPreHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnRcvdPstHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
        + InitlMrgnRcvdPreHrcut  : ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth109001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    ISO20022.Auth109001.ReceivedMarginOrCollateral6 *-- ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth109001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth109001.ReportingExemption1 {
        + Desc  : String
        + Rsn  : String
    }
    class ISO20022.Auth109001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth109001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth109001.SupplementaryData1 *-- ISO20022.Auth109001.SupplementaryDataEnvelope1
    class ISO20022.Auth109001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth109001.TechnicalAttributes6 {
        + RptRctTmStmp  : DateTime
        + TechRcrdId  : String
    }
    class ISO20022.Auth109001.TradeCounterpartyRelationship1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1 {
        + Desc  : String
        + RltshTp  : ISO20022.Auth109001.TradeCounterpartyRelationship1Choice
        + EndRltshPty  : String
        + StartRltshPty  : String
    }
    ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1 *-- ISO20022.Auth109001.TradeCounterpartyRelationship1Choice
    class ISO20022.Auth109001.TradeCounterpartyReport20 {
        + RltshRcrd  : global::System.Collections.Generic.List~ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1~
        + ExctnAgt  : global::System.Collections.Generic.List~ISO20022.Auth109001.OrganisationIdentification15Choice~
        + NttyRspnsblForRpt  : ISO20022.Auth109001.OrganisationIdentification15Choice
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Auth109001.PartyIdentification248Choice~
        + ClrMmb  : ISO20022.Auth109001.PartyIdentification248Choice
        + SubmitgAgt  : ISO20022.Auth109001.OrganisationIdentification15Choice
        + Brkr  : ISO20022.Auth109001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth109001.Counterparty46
        + RptgCtrPty  : ISO20022.Auth109001.Counterparty45
    }
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.PartyIdentification248Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.PartyIdentification248Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.Counterparty46
    ISO20022.Auth109001.TradeCounterpartyReport20 *-- ISO20022.Auth109001.Counterparty45
    class ISO20022.Auth109001.TradeCounterpartyType1Code {
        ERFR = 1
        SBMA = 2
        REPC = 3
        OTHC = 4
        EXEA = 5
        CLEM = 6
        BROK = 7
        BENE = 8
    }
    class ISO20022.Auth109001.TradeData62Choice {
        + Stat  : global::System.Collections.Generic.List~ISO20022.Auth109001.MarginReportData10~
        + DataSetActn  : String
    }
    ISO20022.Auth109001.TradeData62Choice *-- ISO20022.Auth109001.MarginReportData10
    class ISO20022.Auth109001.TradeReportHeader4 {
        + RptgPurp  : global::System.Collections.Generic.List~String~
        + NewTradRpstryIdr  : ISO20022.Auth109001.OrganisationIdentification15Choice
        + CmptntAuthrty  : global::System.Collections.Generic.List~String~
        + NbRcrds  : Decimal
        + MsgPgntn  : ISO20022.Auth109001.Pagination1
        + RptExctnDt  : DateTime
    }
    ISO20022.Auth109001.TradeReportHeader4 *-- ISO20022.Auth109001.OrganisationIdentification15Choice
    ISO20022.Auth109001.TradeReportHeader4 *-- ISO20022.Auth109001.Pagination1
    class ISO20022.Auth109001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Auth109001.TransactionOperationType11Code {
        EROR = 1
        NEWT = 2
        MARU = 3
        CORR = 4
    }
    class ISO20022.Auth109001.UniqueTransactionIdentifier2Choice {
        + Prtry  : ISO20022.Auth109001.GenericIdentification175
        + UnqTxIdr  : String
    }
    ISO20022.Auth109001.UniqueTransactionIdentifier2Choice *-- ISO20022.Auth109001.GenericIdentification175
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

## Value ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth109001.CollateralPortfolioCode6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnPrtflCd|ISO20022.Auth109001.MarginPortfolio4||XmlElement()||
|+|Prtfl|ISO20022.Auth109001.PortfolioCode3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnPrtflCd),validElement(Prtfl),validChoice(MrgnPrtflCd,Prtfl))|

---

## Enum ISO20022.Auth109001.CollateralisationType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNCL|Int32||XmlEnum("""UNCL""")|1|
||PRC2|Int32||XmlEnum("""PRC2""")|2|
||PRC1|Int32||XmlEnum("""PRC1""")|3|
||PRCL|Int32||XmlEnum("""PRCL""")|4|
||OWP2|Int32||XmlEnum("""OWP2""")|5|
||OWP1|Int32||XmlEnum("""OWP1""")|6|
||OWC2|Int32||XmlEnum("""OWC2""")|7|
||OWC1|Int32||XmlEnum("""OWC1""")|8|
||OWCL|Int32||XmlEnum("""OWCL""")|9|
||FLCL|Int32||XmlEnum("""FLCL""")|10|

---

## Value ISO20022.Auth109001.ContractModification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.Counterparty45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgXmptn|ISO20022.Auth109001.ReportingExemption1||XmlElement()||
|+|BookgLctn|String||XmlElement()||
|+|TradrLctn|String||XmlElement()||
|+|DrctnOrSd|ISO20022.Auth109001.Direction4Choice||XmlElement()||
|+|TradgCpcty|String||XmlElement()||
|+|Ntr|ISO20022.Auth109001.CounterpartyTradeNature15Choice||XmlElement()||
|+|Id|ISO20022.Auth109001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptgXmptn),validPattern("""BookgLctn""",BookgLctn,"""[A-Z]{2,2}"""),validPattern("""TradrLctn""",TradrLctn,"""[A-Z]{2,2}"""),validElement(DrctnOrSd),validElement(Ntr),validElement(Id))|

---

## Value ISO20022.Auth109001.Counterparty46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgOblgtn|String||XmlElement()||
|+|Ntr|ISO20022.Auth109001.CounterpartyTradeNature15Choice||XmlElement()||
|+|IdTp|ISO20022.Auth109001.PartyIdentification248Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntr),validElement(IdTp))|

---

## Value ISO20022.Auth109001.CounterpartyTradeNature15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|CntrlCntrPty|String||XmlElement()||
|+|NFI|ISO20022.Auth109001.NonFinancialInstitutionSector10||XmlElement()||
|+|FI|ISO20022.Auth109001.FinancialInstitutionSector1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NFI),validElement(FI),validChoice(Othr,CntrlCntrPty,NFI,FI))|

---

## Aspect ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth109001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth109001.TradeData62Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth109001.TradeReportHeader4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData),validElement(RptHdr))|

---

## Value ISO20022.Auth109001.Direction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctnOfTheScndLeg|String||XmlElement()||
|+|DrctnOfTheFrstLeg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.Direction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySd|String||XmlElement()||
|+|Drctn|ISO20022.Auth109001.Direction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Drctn),validChoice(CtrPtySd,Drctn))|

---

## Type ISO20022.Auth109001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradMrgnDataTxStatRpt|ISO20022.Auth109001.DerivativesTradeMarginDataTransactionStateReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradMrgnDataTxStatRpt))|

---

## Value ISO20022.Auth109001.FinancialInstitutionSector1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth109001.FinancialPartyClassification2Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Value ISO20022.Auth109001.FinancialPartyClassification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth109001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth109001.FinancialPartySectorType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||ASSU|Int32||XmlEnum("""ASSU""")|2|
||UCIT|Int32||XmlEnum("""UCIT""")|3|
||REIN|Int32||XmlEnum("""REIN""")|4|
||INVF|Int32||XmlEnum("""INVF""")|5|
||ORPI|Int32||XmlEnum("""ORPI""")|6|
||INUN|Int32||XmlEnum("""INUN""")|7|
||CDTI|Int32||XmlEnum("""CDTI""")|8|
||CCPS|Int32||XmlEnum("""CCPS""")|9|
||CSDS|Int32||XmlEnum("""CSDS""")|10|
||AIFD|Int32||XmlEnum("""AIFD""")|11|

---

## Value ISO20022.Auth109001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth109001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth109001.MarginCollateralReport5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmStmp|DateTime||XmlElement()||
|+|CollstnCtgy|String||XmlElement()||
|+|CollPrtflCd|ISO20022.Auth109001.CollateralPortfolioCode6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollPrtflCd))|

---

## Value ISO20022.Auth109001.MarginPortfolio4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VartnMrgnPrtflCd|ISO20022.Auth109001.PortfolioCode5Choice||XmlElement()||
|+|InitlMrgnPrtflCd|ISO20022.Auth109001.PortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VartnMrgnPrtflCd),validElement(InitlMrgnPrtflCd))|

---

## Value ISO20022.Auth109001.MarginReportData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth109001.SupplementaryData1>||XmlElement()||
|+|TechAttrbts|ISO20022.Auth109001.TechnicalAttributes6||XmlElement()||
|+|CtrctMod|ISO20022.Auth109001.ContractModification8||XmlElement()||
|+|CtrPtyRatgThrshldInd|String||XmlElement()||
|+|CtrPtyRatgTrggrInd|String||XmlElement()||
|+|RcvdMrgnOrColl|ISO20022.Auth109001.ReceivedMarginOrCollateral6||XmlElement()||
|+|PstdMrgnOrColl|ISO20022.Auth109001.PostedMarginOrCollateral6||XmlElement()||
|+|Coll|ISO20022.Auth109001.MarginCollateralReport5||XmlElement()||
|+|TxId|ISO20022.Auth109001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|CtrPtyId|ISO20022.Auth109001.TradeCounterpartyReport20||XmlElement()||
|+|RptgTmStmp|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TechAttrbts),validElement(CtrctMod),validElement(RcvdMrgnOrColl),validElement(PstdMrgnOrColl),validElement(Coll),validElement(TxId),validElement(CtrPtyId))|

---

## Value ISO20022.Auth109001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth109001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth109001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth109001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth109001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Auth109001.NonFinancialInstitutionSector10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FdrlInstn|String||XmlElement()||
|+|DrctlyLkdActvty|String||XmlElement()||
|+|ClrThrshld|String||XmlElement()||
|+|Sctr|global::System.Collections.Generic.List<ISO20022.Auth109001.GenericIdentification175>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Sctr""",Sctr),validList("""Sctr""",Sctr),validElement(Sctr))|

---

## Enum ISO20022.Auth109001.NotApplicable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|

---

## Enum ISO20022.Auth109001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Enum ISO20022.Auth109001.OptionParty3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|

---

## Value ISO20022.Auth109001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth109001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth109001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth109001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth109001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Auth109001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth109001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth109001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth109001.PortfolioCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NoPrtfl,Cd))|

---

## Value ISO20022.Auth109001.PortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Prtfl|ISO20022.Auth109001.PortfolioIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtfl),validChoice(NoPrtfl,Prtfl))|

---

## Value ISO20022.Auth109001.PortfolioIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTxXmptn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.PostedMarginOrCollateral6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollPstd|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnPstdPstHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnPstdPreHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnPstdPstHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnPstdPreHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollPstd),validElement(VartnMrgnPstdPstHrcut),validElement(VartnMrgnPstdPreHrcut),validElement(InitlMrgnPstdPstHrcut),validElement(InitlMrgnPstdPreHrcut))|

---

## Value ISO20022.Auth109001.ReceivedMarginOrCollateral6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollRcvd|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnRcvdPstHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|VartnMrgnRcvdPreHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnRcvdPstHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
|+|InitlMrgnRcvdPreHrcut|ISO20022.Auth109001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollRcvd),validElement(VartnMrgnRcvdPstHrcut),validElement(VartnMrgnRcvdPreHrcut),validElement(InitlMrgnRcvdPstHrcut),validElement(InitlMrgnRcvdPreHrcut))|

---

## Enum ISO20022.Auth109001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth109001.ReportingExemption1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth109001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth109001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.TechnicalAttributes6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptRctTmStmp|DateTime||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth109001.TradeCounterpartyRelationship1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|RltshTp|ISO20022.Auth109001.TradeCounterpartyRelationship1Choice||XmlElement()||
|+|EndRltshPty|String||XmlElement()||
|+|StartRltshPty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltshTp))|

---

## Value ISO20022.Auth109001.TradeCounterpartyReport20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltshRcrd|global::System.Collections.Generic.List<ISO20022.Auth109001.TradeCounterpartyRelationshipRecord1>||XmlElement()||
|+|ExctnAgt|global::System.Collections.Generic.List<ISO20022.Auth109001.OrganisationIdentification15Choice>||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth109001.OrganisationIdentification15Choice||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Auth109001.PartyIdentification248Choice>||XmlElement()||
|+|ClrMmb|ISO20022.Auth109001.PartyIdentification248Choice||XmlElement()||
|+|SubmitgAgt|ISO20022.Auth109001.OrganisationIdentification15Choice||XmlElement()||
|+|Brkr|ISO20022.Auth109001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth109001.Counterparty46||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth109001.Counterparty45||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RltshRcrd""",RltshRcrd),validElement(RltshRcrd),validList("""ExctnAgt""",ExctnAgt),validListMax("""ExctnAgt""",ExctnAgt,2),validElement(ExctnAgt),validElement(NttyRspnsblForRpt),validList("""Bnfcry""",Bnfcry),validListMax("""Bnfcry""",Bnfcry,2),validElement(Bnfcry),validElement(ClrMmb),validElement(SubmitgAgt),validElement(Brkr),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Enum ISO20022.Auth109001.TradeCounterpartyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ERFR|Int32||XmlEnum("""ERFR""")|1|
||SBMA|Int32||XmlEnum("""SBMA""")|2|
||REPC|Int32||XmlEnum("""REPC""")|3|
||OTHC|Int32||XmlEnum("""OTHC""")|4|
||EXEA|Int32||XmlEnum("""EXEA""")|5|
||CLEM|Int32||XmlEnum("""CLEM""")|6|
||BROK|Int32||XmlEnum("""BROK""")|7|
||BENE|Int32||XmlEnum("""BENE""")|8|

---

## Value ISO20022.Auth109001.TradeData62Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Stat|global::System.Collections.Generic.List<ISO20022.Auth109001.MarginReportData10>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Stat""",Stat),validList("""Stat""",Stat),validElement(Stat),validChoice(Stat,DataSetActn))|

---

## Value ISO20022.Auth109001.TradeReportHeader4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgPurp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NewTradRpstryIdr|ISO20022.Auth109001.OrganisationIdentification15Choice||XmlElement()||
|+|CmptntAuthrty|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NbRcrds|Decimal||XmlElement()||
|+|MsgPgntn|ISO20022.Auth109001.Pagination1||XmlElement()||
|+|RptExctnDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewTradRpstryIdr),validElement(MsgPgntn))|

---

## Enum ISO20022.Auth109001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Enum ISO20022.Auth109001.TransactionOperationType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EROR|Int32||XmlEnum("""EROR""")|1|
||NEWT|Int32||XmlEnum("""NEWT""")|2|
||MARU|Int32||XmlEnum("""MARU""")|3|
||CORR|Int32||XmlEnum("""CORR""")|4|

---

## Value ISO20022.Auth109001.UniqueTransactionIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth109001.GenericIdentification175||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

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

