# auth.100.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth100001.Contact9 {
        + Fctn  : String
        + EmailAdr  : String
        + PhneNb  : String
        + Nm  : String
    }
    class ISO20022.Auth100001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Auth100001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth100001.OtherIdentification1 {
        + Tp  : ISO20022.Auth100001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Auth100001.OtherIdentification1 *-- ISO20022.Auth100001.IdentificationSource3Choice
    class ISO20022.Auth100001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2 {
        + RspnsblPty  : global::System.Collections.Generic.List~ISO20022.Auth100001.Contact9~
        + LEI  : String
        + CSDLglNm  : String
        + CtryOfJursdctn  : String
        + SysNm  : String
        + SysId  : String
    }
    ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2 *-- ISO20022.Auth100001.Contact9
    class ISO20022.Auth100001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Auth100001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Auth100001.SecurityIdentification19 *-- ISO20022.Auth100001.OtherIdentification1
    class ISO20022.Auth100001.SettlementDailyFailureReason1Choice {
        + Data  : ISO20022.Auth100001.SettlementDailyFailureReason3
        + DataSetActn  : String
    }
    ISO20022.Auth100001.SettlementDailyFailureReason1Choice *-- ISO20022.Auth100001.SettlementDailyFailureReason3
    class ISO20022.Auth100001.SettlementDailyFailureReason3 {
        + FaildCsh  : ISO20022.Auth100001.SettlementTotalData1Choice
        + FaildScties  : ISO20022.Auth100001.SettlementTotalData1Choice
    }
    ISO20022.Auth100001.SettlementDailyFailureReason3 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementDailyFailureReason3 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    class ISO20022.Auth100001.SettlementDataRate2 {
        + Val  : Decimal
        + Vol  : Decimal
    }
    class ISO20022.Auth100001.SettlementDataVolume2 {
        + Val  : Decimal
        + Vol  : Decimal
    }
    class ISO20022.Auth100001.SettlementFailsCurrency2 {
        + Data  : ISO20022.Auth100001.SettlementTotalData1
        + Ccy  : String
    }
    ISO20022.Auth100001.SettlementFailsCurrency2 *-- ISO20022.Auth100001.SettlementTotalData1
    class ISO20022.Auth100001.SettlementFailsDailyCSD1Choice {
        + Data  : ISO20022.Auth100001.SettlementFailsDailyCSD3
        + DataSetActn  : String
    }
    ISO20022.Auth100001.SettlementFailsDailyCSD1Choice *-- ISO20022.Auth100001.SettlementFailsDailyCSD3
    class ISO20022.Auth100001.SettlementFailsDailyCSD3 {
        + CrossCSD  : ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice
        + IntraCSD  : ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice
    }
    ISO20022.Auth100001.SettlementFailsDailyCSD3 *-- ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyCSD3 *-- ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice
    class ISO20022.Auth100001.SettlementFailsDailyData3 {
        + DalyRcrd  : ISO20022.Auth100001.SettlementFailsDailyInstrument3
        + RptgDt  : DateTime
    }
    ISO20022.Auth100001.SettlementFailsDailyData3 *-- ISO20022.Auth100001.SettlementFailsDailyInstrument3
    class ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice {
        + Data  : ISO20022.Auth100001.SettlementFailsDailyInstructionType3
        + DataSetActn  : String
    }
    ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice *-- ISO20022.Auth100001.SettlementFailsDailyInstructionType3
    class ISO20022.Auth100001.SettlementFailsDailyInstructionType3 {
        + FreeOfPmt  : ISO20022.Auth100001.SettlementDailyFailureReason1Choice
        + PmtFreeOfDlvry  : ISO20022.Auth100001.SettlementDailyFailureReason1Choice
        + DlvryWthPmt  : ISO20022.Auth100001.SettlementDailyFailureReason1Choice
        + DlvryVrssPmt  : ISO20022.Auth100001.SettlementDailyFailureReason1Choice
    }
    ISO20022.Auth100001.SettlementFailsDailyInstructionType3 *-- ISO20022.Auth100001.SettlementDailyFailureReason1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstructionType3 *-- ISO20022.Auth100001.SettlementDailyFailureReason1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstructionType3 *-- ISO20022.Auth100001.SettlementDailyFailureReason1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstructionType3 *-- ISO20022.Auth100001.SettlementDailyFailureReason1Choice
    class ISO20022.Auth100001.SettlementFailsDailyInstrument3 {
        + Othr  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + EmssnAllwnc  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + MnyMktInstrm  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + CllctvInvstmtUdrtkgs  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + XchgTraddFnds  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + OthrTrfblScties  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + Bd  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + SvrgnDebt  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
        + Eqty  : ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    }
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    ISO20022.Auth100001.SettlementFailsDailyInstrument3 *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice
    class ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice {
        + Data  : ISO20022.Auth100001.SettlementFailsDailyTransactionType3
        + DataSetActn  : String
    }
    ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice *-- ISO20022.Auth100001.SettlementFailsDailyTransactionType3
    class ISO20022.Auth100001.SettlementFailsDailyTransactionType3 {
        + Othr  : ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
        + RpAgrmt  : ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
        + SctiesLndgOrBrrwg  : ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
        + CollMgmtOpr  : ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
        + SctiesBuyOrSell  : ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    }
    ISO20022.Auth100001.SettlementFailsDailyTransactionType3 *-- ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    ISO20022.Auth100001.SettlementFailsDailyTransactionType3 *-- ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    ISO20022.Auth100001.SettlementFailsDailyTransactionType3 *-- ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    ISO20022.Auth100001.SettlementFailsDailyTransactionType3 *-- ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    ISO20022.Auth100001.SettlementFailsDailyTransactionType3 *-- ISO20022.Auth100001.SettlementFailsDailyCSD1Choice
    class ISO20022.Auth100001.SettlementFailsData3 {
        + FailrRsn  : ISO20022.Auth100001.SettlementFailureReason3
        + TtlSttlmPnlties  : ISO20022.Auth100001.SettlementDataVolume2
        + FlsPerTxTp  : ISO20022.Auth100001.SettlementFailsTransactionType2
        + SctiesInFail  : ISO20022.Auth100001.SettlementFailsSecuritiesRange1
        + FlsPerFinInstrmTp  : ISO20022.Auth100001.SettlementFailsInstrument2
        + FlsPerCcy  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsCurrency2~
        + PtcptInFail  : ISO20022.Auth100001.SettlementFailsParticipantRange1
        + Ttl  : ISO20022.Auth100001.SettlementTotalData1
    }
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailureReason3
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementDataVolume2
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailsTransactionType2
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailsSecuritiesRange1
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailsInstrument2
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailsCurrency2
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementFailsParticipantRange1
    ISO20022.Auth100001.SettlementFailsData3 *-- ISO20022.Auth100001.SettlementTotalData1
    class ISO20022.Auth100001.SettlementFailsInstrument2 {
        + Othr  : ISO20022.Auth100001.SettlementTotalData1Choice
        + EmssnAllwnc  : ISO20022.Auth100001.SettlementTotalData1Choice
        + MnyMktInstrm  : ISO20022.Auth100001.SettlementTotalData1Choice
        + CllctvInvstmtUdrtkgs  : ISO20022.Auth100001.SettlementTotalData1Choice
        + XchgTraddFnds  : ISO20022.Auth100001.SettlementTotalData1Choice
        + OthrTrfblScties  : ISO20022.Auth100001.SettlementTotalData1Choice
        + Bd  : ISO20022.Auth100001.SettlementTotalData1Choice
        + SvrgnDebt  : ISO20022.Auth100001.SettlementTotalData1Choice
        + Eqty  : ISO20022.Auth100001.SettlementTotalData1Choice
    }
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsInstrument2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    class ISO20022.Auth100001.SettlementFailsMonthlyReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth100001.SupplementaryData1~
        + DalyData  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsDailyData3~
        + MnthlyAggt  : ISO20022.Auth100001.SettlementFailsData3
        + RptHdr  : ISO20022.Auth100001.SettlementFailsReportHeader2
    }
    ISO20022.Auth100001.SettlementFailsMonthlyReportV01 *-- ISO20022.Auth100001.SupplementaryData1
    ISO20022.Auth100001.SettlementFailsMonthlyReportV01 *-- ISO20022.Auth100001.SettlementFailsDailyData3
    ISO20022.Auth100001.SettlementFailsMonthlyReportV01 *-- ISO20022.Auth100001.SettlementFailsData3
    ISO20022.Auth100001.SettlementFailsMonthlyReportV01 *-- ISO20022.Auth100001.SettlementFailsReportHeader2
    class ISO20022.Auth100001.SettlementFailsParticipant1 {
        + Aggt  : ISO20022.Auth100001.SettlementTotalData1
        + Rank  : String
        + LEI  : String
    }
    ISO20022.Auth100001.SettlementFailsParticipant1 *-- ISO20022.Auth100001.SettlementTotalData1
    class ISO20022.Auth100001.SettlementFailsParticipantRange1 {
        + HghstInVal  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsParticipant1~
        + HghstInVol  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsParticipant1~
    }
    ISO20022.Auth100001.SettlementFailsParticipantRange1 *-- ISO20022.Auth100001.SettlementFailsParticipant1
    ISO20022.Auth100001.SettlementFailsParticipantRange1 *-- ISO20022.Auth100001.SettlementFailsParticipant1
    class ISO20022.Auth100001.SettlementFailsReportHeader2 {
        + SctiesSttlmSys  : ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2
        + RptSts  : String
        + Ccy  : String
        + RptgPrd  : ISO20022.Auth100001.DatePeriod2
        + CreDtTm  : DateTime
    }
    ISO20022.Auth100001.SettlementFailsReportHeader2 *-- ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2
    ISO20022.Auth100001.SettlementFailsReportHeader2 *-- ISO20022.Auth100001.DatePeriod2
    class ISO20022.Auth100001.SettlementFailsSecurities1 {
        + Rank  : String
        + FinInstrmId  : ISO20022.Auth100001.SecurityIdentification19
    }
    ISO20022.Auth100001.SettlementFailsSecurities1 *-- ISO20022.Auth100001.SecurityIdentification19
    class ISO20022.Auth100001.SettlementFailsSecuritiesRange1 {
        + HghstInVal  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsSecurities1~
        + HghstInVol  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailsSecurities1~
    }
    ISO20022.Auth100001.SettlementFailsSecuritiesRange1 *-- ISO20022.Auth100001.SettlementFailsSecurities1
    ISO20022.Auth100001.SettlementFailsSecuritiesRange1 *-- ISO20022.Auth100001.SettlementFailsSecurities1
    class ISO20022.Auth100001.SettlementFailsTransactionType2 {
        + Othr  : ISO20022.Auth100001.SettlementTotalData1Choice
        + RpAgrmt  : ISO20022.Auth100001.SettlementTotalData1Choice
        + SctiesLndgOrBrrwg  : ISO20022.Auth100001.SettlementTotalData1Choice
        + CollMgmtOpr  : ISO20022.Auth100001.SettlementTotalData1Choice
        + SctiesBuyOrSell  : ISO20022.Auth100001.SettlementTotalData1Choice
    }
    ISO20022.Auth100001.SettlementFailsTransactionType2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsTransactionType2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsTransactionType2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsTransactionType2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    ISO20022.Auth100001.SettlementFailsTransactionType2 *-- ISO20022.Auth100001.SettlementTotalData1Choice
    class ISO20022.Auth100001.SettlementFailureReason2 {
        + EffcncyImprvmt  : String
        + MainRsns  : String
    }
    class ISO20022.Auth100001.SettlementFailureReason3 {
        + Desc  : global::System.Collections.Generic.List~ISO20022.Auth100001.SettlementFailureReason2~
        + AvrgDrtn  : Decimal
    }
    ISO20022.Auth100001.SettlementFailureReason3 *-- ISO20022.Auth100001.SettlementFailureReason2
    class ISO20022.Auth100001.SettlementTotalData1 {
        + FaildRate  : ISO20022.Auth100001.SettlementDataRate2
        + Ttl  : ISO20022.Auth100001.SettlementDataVolume2
        + Faild  : ISO20022.Auth100001.SettlementDataVolume2
        + Sttld  : ISO20022.Auth100001.SettlementDataVolume2
    }
    ISO20022.Auth100001.SettlementTotalData1 *-- ISO20022.Auth100001.SettlementDataRate2
    ISO20022.Auth100001.SettlementTotalData1 *-- ISO20022.Auth100001.SettlementDataVolume2
    ISO20022.Auth100001.SettlementTotalData1 *-- ISO20022.Auth100001.SettlementDataVolume2
    ISO20022.Auth100001.SettlementTotalData1 *-- ISO20022.Auth100001.SettlementDataVolume2
    class ISO20022.Auth100001.SettlementTotalData1Choice {
        + Data  : ISO20022.Auth100001.SettlementTotalData1
        + DataSetActn  : String
    }
    ISO20022.Auth100001.SettlementTotalData1Choice *-- ISO20022.Auth100001.SettlementTotalData1
    class ISO20022.Auth100001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth100001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth100001.SupplementaryData1 *-- ISO20022.Auth100001.SupplementaryDataEnvelope1
    class ISO20022.Auth100001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth100001.TransactionOperationType4Code {
        CANC = 1
        AMND = 2
        NEWT = 3
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

## Value ISO20022.Auth100001.Contact9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fctn|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Auth100001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Auth100001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmFlsMnthlyRpt|ISO20022.Auth100001.SettlementFailsMonthlyReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmFlsMnthlyRpt))|

---

## Value ISO20022.Auth100001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth100001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Auth100001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Auth100001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPty|global::System.Collections.Generic.List<ISO20022.Auth100001.Contact9>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|CSDLglNm|String||XmlElement()||
|+|CtryOfJursdctn|String||XmlElement()||
|+|SysNm|String||XmlElement()||
|+|SysId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RspnsblPty""",RspnsblPty),validElement(RspnsblPty),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""CtryOfJursdctn""",CtryOfJursdctn,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth100001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Auth100001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth100001.SettlementDailyFailureReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementDailyFailureReason3||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validChoice(Data,DataSetActn))|

---

## Value ISO20022.Auth100001.SettlementDailyFailureReason3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaildCsh|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|FaildScties|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaildCsh),validElement(FaildScties))|

---

## Value ISO20022.Auth100001.SettlementDataRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Vol|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth100001.SettlementDataVolume2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Vol|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth100001.SettlementFailsCurrency2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementTotalData1||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyCSD1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementFailsDailyCSD3||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validChoice(Data,DataSetActn))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyCSD3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrossCSD|ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice||XmlElement()||
|+|IntraCSD|ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CrossCSD),validElement(IntraCSD))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DalyRcrd|ISO20022.Auth100001.SettlementFailsDailyInstrument3||XmlElement()||
|+|RptgDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DalyRcrd))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyInstructionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementFailsDailyInstructionType3||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validChoice(Data,DataSetActn))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyInstructionType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FreeOfPmt|ISO20022.Auth100001.SettlementDailyFailureReason1Choice||XmlElement()||
|+|PmtFreeOfDlvry|ISO20022.Auth100001.SettlementDailyFailureReason1Choice||XmlElement()||
|+|DlvryWthPmt|ISO20022.Auth100001.SettlementDailyFailureReason1Choice||XmlElement()||
|+|DlvryVrssPmt|ISO20022.Auth100001.SettlementDailyFailureReason1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FreeOfPmt),validElement(PmtFreeOfDlvry),validElement(DlvryWthPmt),validElement(DlvryVrssPmt))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyInstrument3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|EmssnAllwnc|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|MnyMktInstrm|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|CllctvInvstmtUdrtkgs|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|XchgTraddFnds|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|OthrTrfblScties|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|Bd|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|SvrgnDebt|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
|+|Eqty|ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(EmssnAllwnc),validElement(MnyMktInstrm),validElement(CllctvInvstmtUdrtkgs),validElement(XchgTraddFnds),validElement(OthrTrfblScties),validElement(Bd),validElement(SvrgnDebt),validElement(Eqty))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyTransactionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementFailsDailyTransactionType3||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validChoice(Data,DataSetActn))|

---

## Value ISO20022.Auth100001.SettlementFailsDailyTransactionType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth100001.SettlementFailsDailyCSD1Choice||XmlElement()||
|+|RpAgrmt|ISO20022.Auth100001.SettlementFailsDailyCSD1Choice||XmlElement()||
|+|SctiesLndgOrBrrwg|ISO20022.Auth100001.SettlementFailsDailyCSD1Choice||XmlElement()||
|+|CollMgmtOpr|ISO20022.Auth100001.SettlementFailsDailyCSD1Choice||XmlElement()||
|+|SctiesBuyOrSell|ISO20022.Auth100001.SettlementFailsDailyCSD1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RpAgrmt),validElement(SctiesLndgOrBrrwg),validElement(CollMgmtOpr),validElement(SctiesBuyOrSell))|

---

## Value ISO20022.Auth100001.SettlementFailsData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FailrRsn|ISO20022.Auth100001.SettlementFailureReason3||XmlElement()||
|+|TtlSttlmPnlties|ISO20022.Auth100001.SettlementDataVolume2||XmlElement()||
|+|FlsPerTxTp|ISO20022.Auth100001.SettlementFailsTransactionType2||XmlElement()||
|+|SctiesInFail|ISO20022.Auth100001.SettlementFailsSecuritiesRange1||XmlElement()||
|+|FlsPerFinInstrmTp|ISO20022.Auth100001.SettlementFailsInstrument2||XmlElement()||
|+|FlsPerCcy|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsCurrency2>||XmlElement()||
|+|PtcptInFail|ISO20022.Auth100001.SettlementFailsParticipantRange1||XmlElement()||
|+|Ttl|ISO20022.Auth100001.SettlementTotalData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FailrRsn),validElement(TtlSttlmPnlties),validElement(FlsPerTxTp),validElement(SctiesInFail),validElement(FlsPerFinInstrmTp),validList("""FlsPerCcy""",FlsPerCcy),validElement(FlsPerCcy),validElement(PtcptInFail),validElement(Ttl))|

---

## Value ISO20022.Auth100001.SettlementFailsInstrument2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|EmssnAllwnc|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|MnyMktInstrm|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|CllctvInvstmtUdrtkgs|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|XchgTraddFnds|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|OthrTrfblScties|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|Bd|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|SvrgnDebt|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|Eqty|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(EmssnAllwnc),validElement(MnyMktInstrm),validElement(CllctvInvstmtUdrtkgs),validElement(XchgTraddFnds),validElement(OthrTrfblScties),validElement(Bd),validElement(SvrgnDebt),validElement(Eqty))|

---

## Aspect ISO20022.Auth100001.SettlementFailsMonthlyReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth100001.SupplementaryData1>||XmlElement()||
|+|DalyData|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsDailyData3>||XmlElement()||
|+|MnthlyAggt|ISO20022.Auth100001.SettlementFailsData3||XmlElement()||
|+|RptHdr|ISO20022.Auth100001.SettlementFailsReportHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""DalyData""",DalyData),validList("""DalyData""",DalyData),validElement(DalyData),validElement(MnthlyAggt),validElement(RptHdr))|

---

## Value ISO20022.Auth100001.SettlementFailsParticipant1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Aggt|ISO20022.Auth100001.SettlementTotalData1||XmlElement()||
|+|Rank|String||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Aggt),validPattern("""Rank""",Rank,"""[0-9]{1,2}"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth100001.SettlementFailsParticipantRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HghstInVal|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsParticipant1>||XmlElement()||
|+|HghstInVol|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsParticipant1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""HghstInVal""",HghstInVal),validList("""HghstInVal""",HghstInVal),validElement(HghstInVal),validRequired("""HghstInVol""",HghstInVol),validList("""HghstInVol""",HghstInVol),validElement(HghstInVol))|

---

## Value ISO20022.Auth100001.SettlementFailsReportHeader2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmSys|ISO20022.Auth100001.SecuritiesSettlementSystemIdentification2||XmlElement()||
|+|RptSts|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|RptgPrd|ISO20022.Auth100001.DatePeriod2||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmSys),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(RptgPrd))|

---

## Value ISO20022.Auth100001.SettlementFailsSecurities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rank|String||XmlElement()||
|+|FinInstrmId|ISO20022.Auth100001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Rank""",Rank,"""[0-9]{1,2}"""),validElement(FinInstrmId))|

---

## Value ISO20022.Auth100001.SettlementFailsSecuritiesRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HghstInVal|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsSecurities1>||XmlElement()||
|+|HghstInVol|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailsSecurities1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""HghstInVal""",HghstInVal),validList("""HghstInVal""",HghstInVal),validElement(HghstInVal),validRequired("""HghstInVol""",HghstInVol),validList("""HghstInVol""",HghstInVol),validElement(HghstInVol))|

---

## Value ISO20022.Auth100001.SettlementFailsTransactionType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|RpAgrmt|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|SctiesLndgOrBrrwg|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|CollMgmtOpr|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
|+|SctiesBuyOrSell|ISO20022.Auth100001.SettlementTotalData1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RpAgrmt),validElement(SctiesLndgOrBrrwg),validElement(CollMgmtOpr),validElement(SctiesBuyOrSell))|

---

## Value ISO20022.Auth100001.SettlementFailureReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EffcncyImprvmt|String||XmlElement()||
|+|MainRsns|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth100001.SettlementFailureReason3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|global::System.Collections.Generic.List<ISO20022.Auth100001.SettlementFailureReason2>||XmlElement()||
|+|AvrgDrtn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Desc""",Desc),validList("""Desc""",Desc),validElement(Desc))|

---

## Value ISO20022.Auth100001.SettlementTotalData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaildRate|ISO20022.Auth100001.SettlementDataRate2||XmlElement()||
|+|Ttl|ISO20022.Auth100001.SettlementDataVolume2||XmlElement()||
|+|Faild|ISO20022.Auth100001.SettlementDataVolume2||XmlElement()||
|+|Sttld|ISO20022.Auth100001.SettlementDataVolume2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaildRate),validElement(Ttl),validElement(Faild),validElement(Sttld))|

---

## Value ISO20022.Auth100001.SettlementTotalData1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|ISO20022.Auth100001.SettlementTotalData1||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Data),validChoice(Data,DataSetActn))|

---

## Value ISO20022.Auth100001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth100001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth100001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth100001.TransactionOperationType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||AMND|Int32||XmlEnum("""AMND""")|2|
||NEWT|Int32||XmlEnum("""NEWT""")|3|

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

