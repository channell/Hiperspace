# auth.085.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth085001.CollateralMarginNew10 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth085001.SupplementaryData1~
        + CtrctMod  : ISO20022.Auth085001.ContractModification3
        + RcncltnFlg  : ISO20022.Auth085001.ReconciliationFlag2
        + RcvdMrgnOrColl  : ISO20022.Auth085001.ReceivedMarginOrCollateral4
        + PstdMrgnOrColl  : ISO20022.Auth085001.PostedMarginOrCollateral4
        + CollPrtflId  : String
        + CtrPty  : ISO20022.Auth085001.Counterparty39
        + EvtDt  : DateTime
        + RptgDtTm  : DateTime
        + TechRcrdId  : String
    }
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.SupplementaryData1
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.ContractModification3
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.ReconciliationFlag2
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.ReceivedMarginOrCollateral4
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.PostedMarginOrCollateral4
    ISO20022.Auth085001.CollateralMarginNew10 *-- ISO20022.Auth085001.Counterparty39
    class ISO20022.Auth085001.ContractModification3 {
        + Lvl  : String
        + ActnTp  : String
    }
    class ISO20022.Auth085001.Counterparty39 {
        + RptSubmitgNtty  : ISO20022.Auth085001.OrganisationIdentification15Choice
        + NttyRspnsblForRpt  : ISO20022.Auth085001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth085001.PartyIdentification236Choice
        + RptgCtrPty  : ISO20022.Auth085001.OrganisationIdentification15Choice
    }
    ISO20022.Auth085001.Counterparty39 *-- ISO20022.Auth085001.OrganisationIdentification15Choice
    ISO20022.Auth085001.Counterparty39 *-- ISO20022.Auth085001.OrganisationIdentification15Choice
    ISO20022.Auth085001.Counterparty39 *-- ISO20022.Auth085001.PartyIdentification236Choice
    ISO20022.Auth085001.Counterparty39 *-- ISO20022.Auth085001.OrganisationIdentification15Choice
    class ISO20022.Auth085001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth085001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth085001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth085001.GenericIdentification175
    }
    ISO20022.Auth085001.NaturalPersonIdentification2 *-- ISO20022.Auth085001.GenericIdentification175
    class ISO20022.Auth085001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth085001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth085001.OrganisationIdentification15Choice *-- ISO20022.Auth085001.OrganisationIdentification38
    class ISO20022.Auth085001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth085001.GenericIdentification175
    }
    ISO20022.Auth085001.OrganisationIdentification38 *-- ISO20022.Auth085001.GenericIdentification175
    class ISO20022.Auth085001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth085001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth085001.OrganisationIdentification15Choice
    }
    ISO20022.Auth085001.PartyIdentification236Choice *-- ISO20022.Auth085001.NaturalPersonIdentification2
    ISO20022.Auth085001.PartyIdentification236Choice *-- ISO20022.Auth085001.OrganisationIdentification15Choice
    class ISO20022.Auth085001.PostedMarginOrCollateral4 {
        + XcssCollPstd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
        + VartnMrgnPstd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
        + InitlMrgnPstd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth085001.PostedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth085001.PostedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth085001.PostedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth085001.ReceivedMarginOrCollateral4 {
        + XcssCollRcvd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
        + VartnMrgnRcvd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
        + InitlMrgnRcvd  : ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth085001.ReceivedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth085001.ReceivedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth085001.ReceivedMarginOrCollateral4 *-- ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth085001.ReconciliationFlag2 {
        + ModSts  : String
        + CollRcncltnSts  : String
        + LnRcncltnSts  : String
        + PairdSts  : String
        + BothCtrPtiesRptg  : String
        + RptTp  : String
    }
    class ISO20022.Auth085001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth085001.SecuritiesFinancingReportingMarginDataTransactionStateReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth085001.SupplementaryData1~
        + TradData  : ISO20022.Auth085001.TradeData38Choice
    }
    ISO20022.Auth085001.SecuritiesFinancingReportingMarginDataTransactionStateReportV02 *-- ISO20022.Auth085001.SupplementaryData1
    ISO20022.Auth085001.SecuritiesFinancingReportingMarginDataTransactionStateReportV02 *-- ISO20022.Auth085001.TradeData38Choice
    class ISO20022.Auth085001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth085001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth085001.SupplementaryData1 *-- ISO20022.Auth085001.SupplementaryDataEnvelope1
    class ISO20022.Auth085001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth085001.TradeData38Choice {
        + Stat  : global::System.Collections.Generic.List~ISO20022.Auth085001.CollateralMarginNew10~
        + DataSetActn  : String
    }
    ISO20022.Auth085001.TradeData38Choice *-- ISO20022.Auth085001.CollateralMarginNew10
    class ISO20022.Auth085001.TradeRepositoryReportingType1Code {
        TWOS = 1
        SWOS = 2
    }
    class ISO20022.Auth085001.TransactionOperationType6Code {
        EROR = 1
        MARU = 2
        MODI = 3
        NEWT = 4
        POSC = 5
        VALU = 6
        ETRM = 7
        CORR = 8
        COLU = 9
        REUU = 10
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

## Value ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth085001.CollateralMarginNew10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth085001.SupplementaryData1>||XmlElement()||
|+|CtrctMod|ISO20022.Auth085001.ContractModification3||XmlElement()||
|+|RcncltnFlg|ISO20022.Auth085001.ReconciliationFlag2||XmlElement()||
|+|RcvdMrgnOrColl|ISO20022.Auth085001.ReceivedMarginOrCollateral4||XmlElement()||
|+|PstdMrgnOrColl|ISO20022.Auth085001.PostedMarginOrCollateral4||XmlElement()||
|+|CollPrtflId|String||XmlElement()||
|+|CtrPty|ISO20022.Auth085001.Counterparty39||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|RptgDtTm|DateTime||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CtrctMod),validElement(RcncltnFlg),validElement(RcvdMrgnOrColl),validElement(PstdMrgnOrColl),validElement(CtrPty))|

---

## Value ISO20022.Auth085001.ContractModification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lvl|String||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth085001.Counterparty39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptSubmitgNtty|ISO20022.Auth085001.OrganisationIdentification15Choice||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth085001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth085001.PartyIdentification236Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth085001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptSubmitgNtty),validElement(NttyRspnsblForRpt),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Type ISO20022.Auth085001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgRptgMrgnDataTxStatRpt|ISO20022.Auth085001.SecuritiesFinancingReportingMarginDataTransactionStateReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgRptgMrgnDataTxStatRpt))|

---

## Value ISO20022.Auth085001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth085001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth085001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth085001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth085001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth085001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth085001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth085001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth085001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth085001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth085001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth085001.PostedMarginOrCollateral4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollPstd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|VartnMrgnPstd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|InitlMrgnPstd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollPstd),validElement(VartnMrgnPstd),validElement(InitlMrgnPstd))|

---

## Value ISO20022.Auth085001.ReceivedMarginOrCollateral4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcssCollRcvd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|VartnMrgnRcvd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|InitlMrgnRcvd|ISO20022.Auth085001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XcssCollRcvd),validElement(VartnMrgnRcvd),validElement(InitlMrgnRcvd))|

---

## Value ISO20022.Auth085001.ReconciliationFlag2


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

## Enum ISO20022.Auth085001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Aspect ISO20022.Auth085001.SecuritiesFinancingReportingMarginDataTransactionStateReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth085001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth085001.TradeData38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData))|

---

## Value ISO20022.Auth085001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth085001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth085001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth085001.TradeData38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Stat|global::System.Collections.Generic.List<ISO20022.Auth085001.CollateralMarginNew10>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Stat""",Stat),validList("""Stat""",Stat),validElement(Stat),validChoice(Stat,DataSetActn))|

---

## Enum ISO20022.Auth085001.TradeRepositoryReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TWOS|Int32||XmlEnum("""TWOS""")|1|
||SWOS|Int32||XmlEnum("""SWOS""")|2|

---

## Enum ISO20022.Auth085001.TransactionOperationType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EROR|Int32||XmlEnum("""EROR""")|1|
||MARU|Int32||XmlEnum("""MARU""")|2|
||MODI|Int32||XmlEnum("""MODI""")|3|
||NEWT|Int32||XmlEnum("""NEWT""")|4|
||POSC|Int32||XmlEnum("""POSC""")|5|
||VALU|Int32||XmlEnum("""VALU""")|6|
||ETRM|Int32||XmlEnum("""ETRM""")|7|
||CORR|Int32||XmlEnum("""CORR""")|8|
||COLU|Int32||XmlEnum("""COLU""")|9|
||REUU|Int32||XmlEnum("""REUU""")|10|

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

