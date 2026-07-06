# auth.013.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth013001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth013001.BrokeredDeal1Code {
        BROK = 1
        BILA = 2
    }
    class ISO20022.Auth013001.CounterpartyIdentification3Choice {
        + NmAndLctn  : ISO20022.Auth013001.NameAndLocation1
        + SctrAndLctn  : ISO20022.Auth013001.SectorAndLocation1
        + LEI  : String
    }
    ISO20022.Auth013001.CounterpartyIdentification3Choice *-- ISO20022.Auth013001.NameAndLocation1
    ISO20022.Auth013001.CounterpartyIdentification3Choice *-- ISO20022.Auth013001.SectorAndLocation1
    class ISO20022.Auth013001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth013001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Auth013001.FinancialInstrumentProductType1Code {
        DPST = 1
        CACM = 2
        FRNT = 3
        ABCP = 4
        OTHR = 5
        COPR = 6
        CEOD = 7
    }
    class ISO20022.Auth013001.FloatingRateNote2 {
        + BsisPtSprd  : Decimal
        + RefRateIndx  : String
    }
    class ISO20022.Auth013001.InterestRateType1Code {
        VARI = 1
        FIXE = 2
    }
    class ISO20022.Auth013001.MoneyMarketReportHeader1 {
        + RefPrd  : ISO20022.Auth013001.DateTimePeriod1
        + RptgAgt  : String
    }
    ISO20022.Auth013001.MoneyMarketReportHeader1 *-- ISO20022.Auth013001.DateTimePeriod1
    class ISO20022.Auth013001.MoneyMarketTransactionType1Code {
        LEND = 1
        BORR = 2
    }
    class ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth013001.SupplementaryData1~
        + UscrdMktRpt  : ISO20022.Auth013001.UnsecuredMarketReport4Choice
        + RptHdr  : ISO20022.Auth013001.MoneyMarketReportHeader1
    }
    ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02 *-- ISO20022.Auth013001.SupplementaryData1
    ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02 *-- ISO20022.Auth013001.UnsecuredMarketReport4Choice
    ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02 *-- ISO20022.Auth013001.MoneyMarketReportHeader1
    class ISO20022.Auth013001.NameAndLocation1 {
        + Lctn  : String
        + Nm  : String
    }
    class ISO20022.Auth013001.NovationStatus1Code {
        NOVA = 1
        NONO = 2
    }
    class ISO20022.Auth013001.Option12 {
        + DtOrPrd  : ISO20022.Auth013001.OptionDateOrPeriod1Choice
        + Tp  : String
    }
    ISO20022.Auth013001.Option12 *-- ISO20022.Auth013001.OptionDateOrPeriod1Choice
    class ISO20022.Auth013001.OptionDateOrPeriod1Choice {
        + NtcePrd  : Decimal
        + EarlstExrcDt  : DateTime
    }
    class ISO20022.Auth013001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Auth013001.ReportPeriodActivity3Code {
        NORA = 1
        NOTX = 2
    }
    class ISO20022.Auth013001.SectorAndLocation1 {
        + Lctn  : String
        + Sctr  : String
    }
    class ISO20022.Auth013001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth013001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth013001.SupplementaryData1 *-- ISO20022.Auth013001.SupplementaryDataEnvelope1
    class ISO20022.Auth013001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth013001.TransactionOperationType1Code {
        NEWT = 1
        CORR = 2
        CANC = 3
        AMND = 4
    }
    class ISO20022.Auth013001.UnsecuredMarketReport4Choice {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Auth013001.UnsecuredMarketTransaction4~
        + DataSetActn  : String
    }
    ISO20022.Auth013001.UnsecuredMarketReport4Choice *-- ISO20022.Auth013001.UnsecuredMarketTransaction4
    class ISO20022.Auth013001.UnsecuredMarketTransaction4 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth013001.SupplementaryData1~
        + CallPutOptn  : global::System.Collections.Generic.List~ISO20022.Auth013001.Option12~
        + BrkrdDeal  : String
        + FltgRateNote  : ISO20022.Auth013001.FloatingRateNote2
        + DealRate  : Decimal
        + RateTp  : String
        + DealPric  : Decimal
        + TxNmnlAmt  : ISO20022.Auth013001.ActiveCurrencyAndAmount
        + InstrmTp  : String
        + TxTp  : String
        + MtrtyDt  : DateTime
        + SttlmDt  : DateTime
        + TradDt  : ISO20022.Auth013001.DateAndDateTimeChoice
        + CtrPtyId  : ISO20022.Auth013001.CounterpartyIdentification3Choice
        + CtrPtyPrtryTxId  : String
        + RltdPrtryTxId  : String
        + PrtryTxId  : String
        + UnqTxIdr  : String
        + BrnchId  : String
        + NvtnSts  : String
        + RptdTxSts  : String
    }
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.SupplementaryData1
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.Option12
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.FloatingRateNote2
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.ActiveCurrencyAndAmount
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.DateAndDateTimeChoice
    ISO20022.Auth013001.UnsecuredMarketTransaction4 *-- ISO20022.Auth013001.CounterpartyIdentification3Choice
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

## Value ISO20022.Auth013001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Auth013001.BrokeredDeal1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BROK|Int32||XmlEnum("""BROK""")|1|
||BILA|Int32||XmlEnum("""BILA""")|2|

---

## Value ISO20022.Auth013001.CounterpartyIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndLctn|ISO20022.Auth013001.NameAndLocation1||XmlElement()||
|+|SctrAndLctn|ISO20022.Auth013001.SectorAndLocation1||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndLctn),validElement(SctrAndLctn),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(NmAndLctn,SctrAndLctn,LEI))|

---

## Value ISO20022.Auth013001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Auth013001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Auth013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MnyMktUscrdMktSttstclRpt|ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MnyMktUscrdMktSttstclRpt))|

---

## Enum ISO20022.Auth013001.FinancialInstrumentProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DPST|Int32||XmlEnum("""DPST""")|1|
||CACM|Int32||XmlEnum("""CACM""")|2|
||FRNT|Int32||XmlEnum("""FRNT""")|3|
||ABCP|Int32||XmlEnum("""ABCP""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||COPR|Int32||XmlEnum("""COPR""")|6|
||CEOD|Int32||XmlEnum("""CEOD""")|7|

---

## Value ISO20022.Auth013001.FloatingRateNote2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|RefRateIndx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RefRateIndx""",RefRateIndx,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Auth013001.InterestRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FIXE|Int32||XmlEnum("""FIXE""")|2|

---

## Value ISO20022.Auth013001.MoneyMarketReportHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefPrd|ISO20022.Auth013001.DateTimePeriod1||XmlElement()||
|+|RptgAgt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefPrd),validPattern("""RptgAgt""",RptgAgt,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Auth013001.MoneyMarketTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LEND|Int32||XmlEnum("""LEND""")|1|
||BORR|Int32||XmlEnum("""BORR""")|2|

---

## Aspect ISO20022.Auth013001.MoneyMarketUnsecuredMarketStatisticalReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth013001.SupplementaryData1>||XmlElement()||
|+|UscrdMktRpt|ISO20022.Auth013001.UnsecuredMarketReport4Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth013001.MoneyMarketReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(UscrdMktRpt),validElement(RptHdr))|

---

## Value ISO20022.Auth013001.NameAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Auth013001.NovationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOVA|Int32||XmlEnum("""NOVA""")|1|
||NONO|Int32||XmlEnum("""NONO""")|2|

---

## Value ISO20022.Auth013001.Option12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtOrPrd|ISO20022.Auth013001.OptionDateOrPeriod1Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtOrPrd))|

---

## Value ISO20022.Auth013001.OptionDateOrPeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtcePrd|Decimal||XmlElement()||
|+|EarlstExrcDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NtcePrd,EarlstExrcDt))|

---

## Enum ISO20022.Auth013001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Enum ISO20022.Auth013001.ReportPeriodActivity3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORA|Int32||XmlEnum("""NORA""")|1|
||NOTX|Int32||XmlEnum("""NOTX""")|2|

---

## Value ISO20022.Auth013001.SectorAndLocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|String||XmlElement()||
|+|Sctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lctn""",Lctn,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth013001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth013001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth013001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth013001.TransactionOperationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEWT|Int32||XmlEnum("""NEWT""")|1|
||CORR|Int32||XmlEnum("""CORR""")|2|
||CANC|Int32||XmlEnum("""CANC""")|3|
||AMND|Int32||XmlEnum("""AMND""")|4|

---

## Value ISO20022.Auth013001.UnsecuredMarketReport4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Auth013001.UnsecuredMarketTransaction4>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validChoice(Tx,DataSetActn))|

---

## Value ISO20022.Auth013001.UnsecuredMarketTransaction4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth013001.SupplementaryData1>||XmlElement()||
|+|CallPutOptn|global::System.Collections.Generic.List<ISO20022.Auth013001.Option12>||XmlElement()||
|+|BrkrdDeal|String||XmlElement()||
|+|FltgRateNote|ISO20022.Auth013001.FloatingRateNote2||XmlElement()||
|+|DealRate|Decimal||XmlElement()||
|+|RateTp|String||XmlElement()||
|+|DealPric|Decimal||XmlElement()||
|+|TxNmnlAmt|ISO20022.Auth013001.ActiveCurrencyAndAmount||XmlElement()||
|+|InstrmTp|String||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
|+|TradDt|ISO20022.Auth013001.DateAndDateTimeChoice||XmlElement()||
|+|CtrPtyId|ISO20022.Auth013001.CounterpartyIdentification3Choice||XmlElement()||
|+|CtrPtyPrtryTxId|String||XmlElement()||
|+|RltdPrtryTxId|String||XmlElement()||
|+|PrtryTxId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|BrnchId|String||XmlElement()||
|+|NvtnSts|String||XmlElement()||
|+|RptdTxSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""CallPutOptn""",CallPutOptn),validListMax("""CallPutOptn""",CallPutOptn,2),validElement(CallPutOptn),validElement(FltgRateNote),validElement(TxNmnlAmt),validElement(TradDt),validElement(CtrPtyId),validPattern("""BrnchId""",BrnchId,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

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

