# auth.014.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth014001.CounterpartyIdentification3Choice {
        + NmAndLctn  : ISO20022.Auth014001.NameAndLocation1
        + SctrAndLctn  : ISO20022.Auth014001.SectorAndLocation1
        + LEI  : String
    }
    ISO20022.Auth014001.CounterpartyIdentification3Choice *-- ISO20022.Auth014001.NameAndLocation1
    ISO20022.Auth014001.CounterpartyIdentification3Choice *-- ISO20022.Auth014001.SectorAndLocation1
    class ISO20022.Auth014001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth014001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Auth014001.ForeignExchange1 {
        + XchgFwdPt  : Decimal
        + XchgSpotRate  : Decimal
        + FrgnCcy  : String
    }
    class ISO20022.Auth014001.ForeignExchangeSwap3Choice {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Auth014001.ForeignExchangeSwapTransaction3~
        + DataSetActn  : String
    }
    ISO20022.Auth014001.ForeignExchangeSwap3Choice *-- ISO20022.Auth014001.ForeignExchangeSwapTransaction3
    class ISO20022.Auth014001.ForeignExchangeSwapTransaction3 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth014001.SupplementaryData1~
        + FX  : ISO20022.Auth014001.ForeignExchange1
        + TxNmnlAmt  : ISO20022.Auth014001.ActiveCurrencyAndAmount
        + TxTp  : String
        + MtrtyDt  : DateTime
        + SpotValDt  : DateTime
        + TradDt  : ISO20022.Auth014001.DateAndDateTimeChoice
        + CtrPtyId  : ISO20022.Auth014001.CounterpartyIdentification3Choice
        + CtrPtyPrtryTxId  : String
        + RltdPrtryTxId  : String
        + PrtryTxId  : String
        + UnqTxIdr  : String
        + BrnchId  : String
        + NvtnSts  : String
        + RptdTxSts  : String
    }
    ISO20022.Auth014001.ForeignExchangeSwapTransaction3 *-- ISO20022.Auth014001.SupplementaryData1
    ISO20022.Auth014001.ForeignExchangeSwapTransaction3 *-- ISO20022.Auth014001.ForeignExchange1
    ISO20022.Auth014001.ForeignExchangeSwapTransaction3 *-- ISO20022.Auth014001.ActiveCurrencyAndAmount
    ISO20022.Auth014001.ForeignExchangeSwapTransaction3 *-- ISO20022.Auth014001.DateAndDateTimeChoice
    ISO20022.Auth014001.ForeignExchangeSwapTransaction3 *-- ISO20022.Auth014001.CounterpartyIdentification3Choice
    class ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth014001.SupplementaryData1~
        + FXSwpsRpt  : ISO20022.Auth014001.ForeignExchangeSwap3Choice
        + RptHdr  : ISO20022.Auth014001.MoneyMarketReportHeader1
    }
    ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02 *-- ISO20022.Auth014001.SupplementaryData1
    ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02 *-- ISO20022.Auth014001.ForeignExchangeSwap3Choice
    ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02 *-- ISO20022.Auth014001.MoneyMarketReportHeader1
    class ISO20022.Auth014001.MoneyMarketReportHeader1 {
        + RefPrd  : ISO20022.Auth014001.DateTimePeriod1
        + RptgAgt  : String
    }
    ISO20022.Auth014001.MoneyMarketReportHeader1 *-- ISO20022.Auth014001.DateTimePeriod1
    class ISO20022.Auth014001.NameAndLocation1 {
        + Lctn  : String
        + Nm  : String
    }
    class ISO20022.Auth014001.NovationStatus1Code {
        NOVA = 1
        NONO = 2
    }
    class ISO20022.Auth014001.ReportPeriodActivity3Code {
        NORA = 1
        NOTX = 2
    }
    class ISO20022.Auth014001.SectorAndLocation1 {
        + Lctn  : String
        + Sctr  : String
    }
    class ISO20022.Auth014001.SecuritiesTransactionType15Code {
        SELL = 1
        BUYI = 2
    }
    class ISO20022.Auth014001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth014001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth014001.SupplementaryData1 *-- ISO20022.Auth014001.SupplementaryDataEnvelope1
    class ISO20022.Auth014001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth014001.TransactionOperationType1Code {
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

## Value ISO20022.Auth014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth014001.CounterpartyIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndLctn|ISO20022.Auth014001.NameAndLocation1||XmlElement()||
|+|SctrAndLctn|ISO20022.Auth014001.SectorAndLocation1||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndLctn),validElement(SctrAndLctn),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(NmAndLctn,SctrAndLctn,LEI))|

---

## Value ISO20022.Auth014001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Auth014001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Auth014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MnyMktFXSwpsSttstclRpt|ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MnyMktFXSwpsSttstclRpt))|

---

## Value ISO20022.Auth014001.ForeignExchange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgFwdPt|Decimal||XmlElement()||
|+|XchgSpotRate|Decimal||XmlElement()||
|+|FrgnCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FrgnCcy""",FrgnCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth014001.ForeignExchangeSwap3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Auth014001.ForeignExchangeSwapTransaction3>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validChoice(Tx,DataSetActn))|

---

## Value ISO20022.Auth014001.ForeignExchangeSwapTransaction3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth014001.SupplementaryData1>||XmlElement()||
|+|FX|ISO20022.Auth014001.ForeignExchange1||XmlElement()||
|+|TxNmnlAmt|ISO20022.Auth014001.ActiveCurrencyAndAmount||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|SpotValDt|DateTime||XmlElement()||
|+|TradDt|ISO20022.Auth014001.DateAndDateTimeChoice||XmlElement()||
|+|CtrPtyId|ISO20022.Auth014001.CounterpartyIdentification3Choice||XmlElement()||
|+|CtrPtyPrtryTxId|String||XmlElement()||
|+|RltdPrtryTxId|String||XmlElement()||
|+|PrtryTxId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|BrnchId|String||XmlElement()||
|+|NvtnSts|String||XmlElement()||
|+|RptdTxSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FX),validElement(TxNmnlAmt),validElement(TradDt),validElement(CtrPtyId),validPattern("""BrnchId""",BrnchId,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Aspect ISO20022.Auth014001.MoneyMarketForeignExchangeSwapsStatisticalReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth014001.SupplementaryData1>||XmlElement()||
|+|FXSwpsRpt|ISO20022.Auth014001.ForeignExchangeSwap3Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth014001.MoneyMarketReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FXSwpsRpt),validElement(RptHdr))|

---

## Value ISO20022.Auth014001.MoneyMarketReportHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefPrd|ISO20022.Auth014001.DateTimePeriod1||XmlElement()||
|+|RptgAgt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefPrd),validPattern("""RptgAgt""",RptgAgt,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth014001.NameAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Auth014001.NovationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOVA|Int32||XmlEnum("""NOVA""")|1|
||NONO|Int32||XmlEnum("""NONO""")|2|

---

## Enum ISO20022.Auth014001.ReportPeriodActivity3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORA|Int32||XmlEnum("""NORA""")|1|
||NOTX|Int32||XmlEnum("""NOTX""")|2|

---

## Value ISO20022.Auth014001.SectorAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Sctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Auth014001.SecuritiesTransactionType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SELL|Int32||XmlEnum("""SELL""")|1|
||BUYI|Int32||XmlEnum("""BUYI""")|2|

---

## Value ISO20022.Auth014001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth014001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth014001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth014001.TransactionOperationType1Code


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

