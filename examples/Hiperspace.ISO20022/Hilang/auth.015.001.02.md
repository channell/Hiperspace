# auth.015.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth015001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth015001.CounterpartyIdentification3Choice {
        + NmAndLctn  : ISO20022.Auth015001.NameAndLocation1
        + SctrAndLctn  : ISO20022.Auth015001.SectorAndLocation1
        + LEI  : String
    }
    ISO20022.Auth015001.CounterpartyIdentification3Choice *-- ISO20022.Auth015001.NameAndLocation1
    ISO20022.Auth015001.CounterpartyIdentification3Choice *-- ISO20022.Auth015001.SectorAndLocation1
    class ISO20022.Auth015001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth015001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth015001.SupplementaryData1~
        + OvrnghtIndxSwpsRpt  : ISO20022.Auth015001.OvernightIndexSwap4Choice
        + RptHdr  : ISO20022.Auth015001.MoneyMarketReportHeader1
    }
    ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02 *-- ISO20022.Auth015001.SupplementaryData1
    ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02 *-- ISO20022.Auth015001.OvernightIndexSwap4Choice
    ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02 *-- ISO20022.Auth015001.MoneyMarketReportHeader1
    class ISO20022.Auth015001.MoneyMarketReportHeader1 {
        + RefPrd  : ISO20022.Auth015001.DateTimePeriod1
        + RptgAgt  : String
    }
    ISO20022.Auth015001.MoneyMarketReportHeader1 *-- ISO20022.Auth015001.DateTimePeriod1
    class ISO20022.Auth015001.NameAndLocation1 {
        + Lctn  : String
        + Nm  : String
    }
    class ISO20022.Auth015001.NovationStatus1Code {
        NOVA = 1
        NONO = 2
    }
    class ISO20022.Auth015001.OvernightIndexSwap4Choice {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Auth015001.OvernightIndexSwapTransaction4~
        + DataSetActn  : String
    }
    ISO20022.Auth015001.OvernightIndexSwap4Choice *-- ISO20022.Auth015001.OvernightIndexSwapTransaction4
    class ISO20022.Auth015001.OvernightIndexSwapTransaction4 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth015001.SupplementaryData1~
        + TxNmnlAmt  : ISO20022.Auth015001.ActiveCurrencyAndAmount
        + TxTp  : String
        + FxdIntrstRate  : Decimal
        + MtrtyDt  : DateTime
        + StartDt  : DateTime
        + TradDt  : ISO20022.Auth015001.DateAndDateTimeChoice
        + CtrPtyId  : ISO20022.Auth015001.CounterpartyIdentification3Choice
        + CtrPtyPrtryTxId  : String
        + RltdPrtryTxId  : String
        + PrtryTxId  : String
        + UnqTxIdr  : String
        + BrnchId  : String
        + NvtnSts  : String
        + RptdTxSts  : String
    }
    ISO20022.Auth015001.OvernightIndexSwapTransaction4 *-- ISO20022.Auth015001.SupplementaryData1
    ISO20022.Auth015001.OvernightIndexSwapTransaction4 *-- ISO20022.Auth015001.ActiveCurrencyAndAmount
    ISO20022.Auth015001.OvernightIndexSwapTransaction4 *-- ISO20022.Auth015001.DateAndDateTimeChoice
    ISO20022.Auth015001.OvernightIndexSwapTransaction4 *-- ISO20022.Auth015001.CounterpartyIdentification3Choice
    class ISO20022.Auth015001.OvernightIndexSwapType1Code {
        RECE = 1
        PAID = 2
    }
    class ISO20022.Auth015001.ReportPeriodActivity3Code {
        NORA = 1
        NOTX = 2
    }
    class ISO20022.Auth015001.SectorAndLocation1 {
        + Lctn  : String
        + Sctr  : String
    }
    class ISO20022.Auth015001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth015001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth015001.SupplementaryData1 *-- ISO20022.Auth015001.SupplementaryDataEnvelope1
    class ISO20022.Auth015001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth015001.TransactionOperationType1Code {
        NEWT = 1
        CORR = 2
        CANC = 3
        AMND = 4
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

## Value ISO20022.Auth015001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth015001.CounterpartyIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndLctn|ISO20022.Auth015001.NameAndLocation1||XmlElement()||
|+|SctrAndLctn|ISO20022.Auth015001.SectorAndLocation1||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndLctn),validElement(SctrAndLctn),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(NmAndLctn,SctrAndLctn,LEI))|

---

## Value ISO20022.Auth015001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Auth015001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Auth015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MnyMktOvrnghtIndxSwpsSttstclRpt|ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MnyMktOvrnghtIndxSwpsSttstclRpt))|

---

## Aspect ISO20022.Auth015001.MoneyMarketOvernightIndexSwapsStatisticalReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth015001.SupplementaryData1>||XmlElement()||
|+|OvrnghtIndxSwpsRpt|ISO20022.Auth015001.OvernightIndexSwap4Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth015001.MoneyMarketReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OvrnghtIndxSwpsRpt),validElement(RptHdr))|

---

## Value ISO20022.Auth015001.MoneyMarketReportHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefPrd|ISO20022.Auth015001.DateTimePeriod1||XmlElement()||
|+|RptgAgt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefPrd),validPattern("""RptgAgt""",RptgAgt,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth015001.NameAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Auth015001.NovationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOVA|Int32||XmlEnum("""NOVA""")|1|
||NONO|Int32||XmlEnum("""NONO""")|2|

---

## Value ISO20022.Auth015001.OvernightIndexSwap4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Auth015001.OvernightIndexSwapTransaction4>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validChoice(Tx,DataSetActn))|

---

## Value ISO20022.Auth015001.OvernightIndexSwapTransaction4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth015001.SupplementaryData1>||XmlElement()||
|+|TxNmnlAmt|ISO20022.Auth015001.ActiveCurrencyAndAmount||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|FxdIntrstRate|Decimal||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|TradDt|ISO20022.Auth015001.DateAndDateTimeChoice||XmlElement()||
|+|CtrPtyId|ISO20022.Auth015001.CounterpartyIdentification3Choice||XmlElement()||
|+|CtrPtyPrtryTxId|String||XmlElement()||
|+|RltdPrtryTxId|String||XmlElement()||
|+|PrtryTxId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|BrnchId|String||XmlElement()||
|+|NvtnSts|String||XmlElement()||
|+|RptdTxSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxNmnlAmt),validElement(TradDt),validElement(CtrPtyId),validPattern("""BrnchId""",BrnchId,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Auth015001.OvernightIndexSwapType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||PAID|Int32||XmlEnum("""PAID""")|2|

---

## Enum ISO20022.Auth015001.ReportPeriodActivity3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORA|Int32||XmlEnum("""NORA""")|1|
||NOTX|Int32||XmlEnum("""NOTX""")|2|

---

## Value ISO20022.Auth015001.SectorAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Sctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth015001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth015001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth015001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth015001.TransactionOperationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEWT|Int32||XmlEnum("""NEWT""")|1|
||CORR|Int32||XmlEnum("""CORR""")|2|
||CANC|Int32||XmlEnum("""CANC""")|3|
||AMND|Int32||XmlEnum("""AMND""")|4|

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

