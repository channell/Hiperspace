# auth.029.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth029001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Auth029001.AnyMIC1Code {
        ANYM = 1
    }
    class ISO20022.Auth029001.BasketQuery1 {
        + ISIN  : String
        + Idr  : String
        + Strr  : String
    }
    class ISO20022.Auth029001.CorporateSectorCriteria6 {
        + NotRptd  : String
        + NFISctr  : global::System.Collections.Generic.List~String~
        + FISctr  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.DateOrBlankQuery2Choice {
        + NotRptd  : String
        + Rg  : ISO20022.Auth029001.DatePeriod1
    }
    ISO20022.Auth029001.DateOrBlankQuery2Choice *-- ISO20022.Auth029001.DatePeriod1
    class ISO20022.Auth029001.DatePeriod1 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Auth029001.DateTimeOrBlankQuery1Choice {
        + NotRptd  : String
        + Rg  : ISO20022.Auth029001.DateTimePeriod1
    }
    ISO20022.Auth029001.DateTimeOrBlankQuery1Choice *-- ISO20022.Auth029001.DateTimePeriod1
    class ISO20022.Auth029001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Auth029001.DerivativeEventType3Code {
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
    class ISO20022.Auth029001.DerivativesTradeReportQueryV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth029001.SupplementaryData1~
        + TradQryData  : ISO20022.Auth029001.TradeReportQuery18Choice
        + RqstngAuthrty  : ISO20022.Auth029001.PartyIdentification121Choice
    }
    ISO20022.Auth029001.DerivativesTradeReportQueryV05 *-- ISO20022.Auth029001.SupplementaryData1
    ISO20022.Auth029001.DerivativesTradeReportQueryV05 *-- ISO20022.Auth029001.TradeReportQuery18Choice
    ISO20022.Auth029001.DerivativesTradeReportQueryV05 *-- ISO20022.Auth029001.PartyIdentification121Choice
    class ISO20022.Auth029001.FinancialInstrumentContractType2Code {
        OTHR = 1
        SWPT = 2
        SWAP = 3
        SPDB = 4
        OPTN = 5
        FORW = 6
        FUTR = 7
        FRAS = 8
        CFDS = 9
    }
    class ISO20022.Auth029001.FinancialPartySectorType2Code {
        UCIT = 1
        REIN = 2
        INVF = 3
        ORPI = 4
        INUN = 5
        CDTI = 6
        CCPS = 7
        CSDS = 8
        AIFD = 9
    }
    class ISO20022.Auth029001.Frequency14Code {
        ADHO = 1
        MNTH = 2
        WEEK = 3
        DAIL = 4
    }
    class ISO20022.Auth029001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth029001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth029001.ISINQueryCriteria1 {
        + NotRptd  : String
        + Idr  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth029001.OrganisationIdentification15Choice
    }
    ISO20022.Auth029001.LegalPersonIdentification1 *-- ISO20022.Auth029001.OrganisationIdentification15Choice
    class ISO20022.Auth029001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth029001.NameAndAddress5 {
        + Adr  : ISO20022.Auth029001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Auth029001.NameAndAddress5 *-- ISO20022.Auth029001.PostalAddress1
    class ISO20022.Auth029001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth029001.GenericIdentification175
    }
    ISO20022.Auth029001.NaturalPersonIdentification2 *-- ISO20022.Auth029001.GenericIdentification175
    class ISO20022.Auth029001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth029001.NaturalPersonIdentification2
    }
    ISO20022.Auth029001.NaturalPersonIdentification3 *-- ISO20022.Auth029001.NaturalPersonIdentification2
    class ISO20022.Auth029001.NonFinancialPartySector1Code {
        AEOB = 1
        AHAE = 2
        ASSA = 3
        TRAS = 4
        RESA = 5
        PADS = 6
        PSTA = 7
        OTSA = 8
        WRRM = 9
        INCO = 10
        HHSW = 11
        FINA = 12
        AEAR = 13
        EDUC = 14
        ACAF = 15
        AGRI = 16
        CSTR = 17
        SPLY = 18
        MAFG = 19
        MING = 20
        WTER = 21
    }
    class ISO20022.Auth029001.NotAvailable1Code {
        NTAV = 1
    }
    class ISO20022.Auth029001.NotReported1Code {
        NORP = 1
    }
    class ISO20022.Auth029001.Operation3Code {
        ORRR = 1
        ANDD = 2
    }
    class ISO20022.Auth029001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth029001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth029001.OrganisationIdentification15Choice *-- ISO20022.Auth029001.OrganisationIdentification38
    class ISO20022.Auth029001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth029001.GenericIdentification175
    }
    ISO20022.Auth029001.OrganisationIdentification38 *-- ISO20022.Auth029001.GenericIdentification175
    class ISO20022.Auth029001.PartyIdentification121Choice {
        + PrtryId  : ISO20022.Auth029001.GenericIdentification1
        + NmAndAdr  : ISO20022.Auth029001.NameAndAddress5
        + LglNttyIdr  : String
        + AnyBIC  : String
    }
    ISO20022.Auth029001.PartyIdentification121Choice *-- ISO20022.Auth029001.GenericIdentification1
    ISO20022.Auth029001.PartyIdentification121Choice *-- ISO20022.Auth029001.NameAndAddress5
    class ISO20022.Auth029001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth029001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth029001.LegalPersonIdentification1
    }
    ISO20022.Auth029001.PartyIdentification248Choice *-- ISO20022.Auth029001.NaturalPersonIdentification3
    ISO20022.Auth029001.PartyIdentification248Choice *-- ISO20022.Auth029001.LegalPersonIdentification1
    class ISO20022.Auth029001.PartyNatureType1Code {
        CCPS = 1
        FIIN = 2
        NFIN = 3
        OTHR = 4
    }
    class ISO20022.Auth029001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Auth029001.ProductClassificationCriteria1 {
        + UnqPdctIdr  : global::System.Collections.Generic.List~String~
        + ClssfctnFinInstrm  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.ProductType4Code {
        OTHR = 1
        COMM = 2
        INTR = 3
        EQUI = 4
        CURR = 5
        CRDT = 6
    }
    class ISO20022.Auth029001.SecuritiesTradeVenueCriteria1Choice {
        + AnyMIC  : String
        + MIC  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.SecurityIdentification20Choice {
        + Nm  : String
        + ISIN  : String
    }
    class ISO20022.Auth029001.SecurityIdentificationQuery4Choice {
        + NotRptd  : String
        + Bskt  : global::System.Collections.Generic.List~ISO20022.Auth029001.BasketQuery1~
        + Indx  : global::System.Collections.Generic.List~ISO20022.Auth029001.SecurityIdentification20Choice~
        + UnqPdctIdr  : global::System.Collections.Generic.List~String~
        + NotAvlbl  : String
        + AltrntvInstrmId  : global::System.Collections.Generic.List~String~
        + ISIN  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Auth029001.SecurityIdentificationQuery4Choice *-- ISO20022.Auth029001.BasketQuery1
    ISO20022.Auth029001.SecurityIdentificationQuery4Choice *-- ISO20022.Auth029001.SecurityIdentification20Choice
    class ISO20022.Auth029001.SecurityIdentificationQueryCriteria1 {
        + AltrntvInstrmId  : global::System.Collections.Generic.List~String~
        + ISIN  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth029001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth029001.SupplementaryData1 *-- ISO20022.Auth029001.SupplementaryDataEnvelope1
    class ISO20022.Auth029001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth029001.TradeAdditionalQueryCriteria9 {
        + EvtTp  : global::System.Collections.Generic.List~String~
        + Lvl  : String
        + PdctClssfctn  : ISO20022.Auth029001.ProductClassificationCriteria1
        + AsstClss  : global::System.Collections.Generic.List~String~
        + CorpSctr  : ISO20022.Auth029001.CorporateSectorCriteria6
        + NtrOfCtrPty  : String
        + ExctnVn  : ISO20022.Auth029001.SecuritiesTradeVenueCriteria1Choice
        + ActnTp  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Auth029001.TradeAdditionalQueryCriteria9 *-- ISO20022.Auth029001.ProductClassificationCriteria1
    ISO20022.Auth029001.TradeAdditionalQueryCriteria9 *-- ISO20022.Auth029001.CorporateSectorCriteria6
    ISO20022.Auth029001.TradeAdditionalQueryCriteria9 *-- ISO20022.Auth029001.SecuritiesTradeVenueCriteria1Choice
    class ISO20022.Auth029001.TradeDateTimeQueryCriteria6 {
        + HstrclAsOfDt  : DateTime
        + CollTmStmp  : ISO20022.Auth029001.DateTimeOrBlankQuery1Choice
        + EarlyTermntnDt  : ISO20022.Auth029001.DatePeriod1
        + XprtnDt  : ISO20022.Auth029001.DateOrBlankQuery2Choice
        + ValtnDtTm  : ISO20022.Auth029001.DateTimePeriod1
        + FctvDt  : ISO20022.Auth029001.DatePeriod1
        + MtrtyDt  : ISO20022.Auth029001.DateOrBlankQuery2Choice
        + ExctnDtTm  : ISO20022.Auth029001.DateTimePeriod1
        + RptgDtTm  : ISO20022.Auth029001.DateTimePeriod1
    }
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateTimeOrBlankQuery1Choice
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DatePeriod1
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateOrBlankQuery2Choice
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateTimePeriod1
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DatePeriod1
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateOrBlankQuery2Choice
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateTimePeriod1
    ISO20022.Auth029001.TradeDateTimeQueryCriteria6 *-- ISO20022.Auth029001.DateTimePeriod1
    class ISO20022.Auth029001.TradePartyIdentificationQuery10Choice {
        + NotRptd  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Auth029001.PartyIdentification248Choice~
    }
    ISO20022.Auth029001.TradePartyIdentificationQuery10Choice *-- ISO20022.Auth029001.PartyIdentification248Choice
    class ISO20022.Auth029001.TradePartyIdentificationQuery11Choice {
        + NotRptd  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Auth029001.OrganisationIdentification15Choice~
    }
    ISO20022.Auth029001.TradePartyIdentificationQuery11Choice *-- ISO20022.Auth029001.OrganisationIdentification15Choice
    class ISO20022.Auth029001.TradePartyQueryCriteria7 {
        + ClrMmb  : ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
        + CCP  : ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
        + Brkr  : ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
        + SubmitgAgt  : ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
        + NttyRspnsblForRpt  : ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
        + Bnfcry  : ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
        + OthrCtrPty  : ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
        + RptgCtrPty  : ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
        + Oprtr  : String
    }
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery11Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
    ISO20022.Auth029001.TradePartyQueryCriteria7 *-- ISO20022.Auth029001.TradePartyIdentificationQuery10Choice
    class ISO20022.Auth029001.TradeQueryCriteria14 {
        + OthrCrit  : ISO20022.Auth029001.TradeAdditionalQueryCriteria9
        + TmCrit  : ISO20022.Auth029001.TradeDateTimeQueryCriteria6
        + FinInstrmCrit  : ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3
        + TradPtyCrit  : ISO20022.Auth029001.TradePartyQueryCriteria7
        + OutsdngTradInd  : String
        + MrgnLifeCyclHstry  : String
        + TradLifeCyclHstry  : String
    }
    ISO20022.Auth029001.TradeQueryCriteria14 *-- ISO20022.Auth029001.TradeAdditionalQueryCriteria9
    ISO20022.Auth029001.TradeQueryCriteria14 *-- ISO20022.Auth029001.TradeDateTimeQueryCriteria6
    ISO20022.Auth029001.TradeQueryCriteria14 *-- ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3
    ISO20022.Auth029001.TradeQueryCriteria14 *-- ISO20022.Auth029001.TradePartyQueryCriteria7
    class ISO20022.Auth029001.TradeQueryExecutionFrequency3 {
        + DayOfMnth  : global::System.Collections.Generic.List~Decimal~
        + DlvryDay  : global::System.Collections.Generic.List~String~
        + FrqcyTp  : String
    }
    class ISO20022.Auth029001.TradeRecurrentQuery7 {
        + VldUntil  : DateTime
        + Frqcy  : global::System.Collections.Generic.List~ISO20022.Auth029001.TradeQueryExecutionFrequency3~
        + QryTp  : String
    }
    ISO20022.Auth029001.TradeRecurrentQuery7 *-- ISO20022.Auth029001.TradeQueryExecutionFrequency3
    class ISO20022.Auth029001.TradeReportQuery18Choice {
        + RcrntQry  : ISO20022.Auth029001.TradeRecurrentQuery7
        + AdHocQry  : ISO20022.Auth029001.TradeQueryCriteria14
    }
    ISO20022.Auth029001.TradeReportQuery18Choice *-- ISO20022.Auth029001.TradeRecurrentQuery7
    ISO20022.Auth029001.TradeReportQuery18Choice *-- ISO20022.Auth029001.TradeQueryCriteria14
    class ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3 {
        + UndrlygInstrmId  : global::System.Collections.Generic.List~ISO20022.Auth029001.SecurityIdentificationQuery4Choice~
        + UnqPdctIdr  : global::System.Collections.Generic.List~ISO20022.Auth029001.UPIQueryCriteria1~
        + ISIN  : global::System.Collections.Generic.List~ISO20022.Auth029001.ISINQueryCriteria1~
        + CtrctTp  : global::System.Collections.Generic.List~String~
        + Id  : global::System.Collections.Generic.List~ISO20022.Auth029001.SecurityIdentificationQueryCriteria1~
        + Oprtr  : String
    }
    ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3 *-- ISO20022.Auth029001.SecurityIdentificationQuery4Choice
    ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3 *-- ISO20022.Auth029001.UPIQueryCriteria1
    ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3 *-- ISO20022.Auth029001.ISINQueryCriteria1
    ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3 *-- ISO20022.Auth029001.SecurityIdentificationQueryCriteria1
    class ISO20022.Auth029001.TransactionOperationType8Code {
        MARU = 1
        VALU = 2
        TERM = 3
        REVI = 4
        POSC = 5
        OTHR = 6
        NEWT = 7
        MODI = 8
        EROR = 9
        CORR = 10
        COMP = 11
    }
    class ISO20022.Auth029001.UPIQueryCriteria1 {
        + NotRptd  : String
        + Idr  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth029001.WeekDay3Code {
        WEND = 1
        WDAY = 2
        WEDD = 3
        TUED = 4
        THUD = 5
        SUND = 6
        SATD = 7
        MOND = 8
        FRID = 9
        IBHL = 10
        XBHL = 11
        ALLD = 12
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

## Enum ISO20022.Auth029001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Auth029001.AnyMIC1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANYM|Int32||XmlEnum("""ANYM""")|1|

---

## Value ISO20022.Auth029001.BasketQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ISIN|String||XmlElement()||
|+|Idr|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth029001.CorporateSectorCriteria6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|NFISctr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FISctr|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.DateOrBlankQuery2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Rg|ISO20022.Auth029001.DatePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rg),validChoice(NotRptd,Rg))|

---

## Value ISO20022.Auth029001.DatePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.DateTimeOrBlankQuery1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Rg|ISO20022.Auth029001.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rg),validChoice(NotRptd,Rg))|

---

## Value ISO20022.Auth029001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth029001.DerivativeEventType3Code


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

## Aspect ISO20022.Auth029001.DerivativesTradeReportQueryV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth029001.SupplementaryData1>||XmlElement()||
|+|TradQryData|ISO20022.Auth029001.TradeReportQuery18Choice||XmlElement()||
|+|RqstngAuthrty|ISO20022.Auth029001.PartyIdentification121Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradQryData),validElement(RqstngAuthrty))|

---

## Type ISO20022.Auth029001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradRptQry|ISO20022.Auth029001.DerivativesTradeReportQueryV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradRptQry))|

---

## Enum ISO20022.Auth029001.FinancialInstrumentContractType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SWPT|Int32||XmlEnum("""SWPT""")|2|
||SWAP|Int32||XmlEnum("""SWAP""")|3|
||SPDB|Int32||XmlEnum("""SPDB""")|4|
||OPTN|Int32||XmlEnum("""OPTN""")|5|
||FORW|Int32||XmlEnum("""FORW""")|6|
||FUTR|Int32||XmlEnum("""FUTR""")|7|
||FRAS|Int32||XmlEnum("""FRAS""")|8|
||CFDS|Int32||XmlEnum("""CFDS""")|9|

---

## Enum ISO20022.Auth029001.FinancialPartySectorType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCIT|Int32||XmlEnum("""UCIT""")|1|
||REIN|Int32||XmlEnum("""REIN""")|2|
||INVF|Int32||XmlEnum("""INVF""")|3|
||ORPI|Int32||XmlEnum("""ORPI""")|4|
||INUN|Int32||XmlEnum("""INUN""")|5|
||CDTI|Int32||XmlEnum("""CDTI""")|6|
||CCPS|Int32||XmlEnum("""CCPS""")|7|
||CSDS|Int32||XmlEnum("""CSDS""")|8|
||AIFD|Int32||XmlEnum("""AIFD""")|9|

---

## Enum ISO20022.Auth029001.Frequency14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADHO|Int32||XmlEnum("""ADHO""")|1|
||MNTH|Int32||XmlEnum("""MNTH""")|2|
||WEEK|Int32||XmlEnum("""WEEK""")|3|
||DAIL|Int32||XmlEnum("""DAIL""")|4|

---

## Value ISO20022.Auth029001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.ISINQueryCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Idr|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Idr""",Idr,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth029001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth029001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth029001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth029001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Auth029001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Auth029001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth029001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth029001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth029001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth029001.NonFinancialPartySector1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AEOB|Int32||XmlEnum("""AEOB""")|1|
||AHAE|Int32||XmlEnum("""AHAE""")|2|
||ASSA|Int32||XmlEnum("""ASSA""")|3|
||TRAS|Int32||XmlEnum("""TRAS""")|4|
||RESA|Int32||XmlEnum("""RESA""")|5|
||PADS|Int32||XmlEnum("""PADS""")|6|
||PSTA|Int32||XmlEnum("""PSTA""")|7|
||OTSA|Int32||XmlEnum("""OTSA""")|8|
||WRRM|Int32||XmlEnum("""WRRM""")|9|
||INCO|Int32||XmlEnum("""INCO""")|10|
||HHSW|Int32||XmlEnum("""HHSW""")|11|
||FINA|Int32||XmlEnum("""FINA""")|12|
||AEAR|Int32||XmlEnum("""AEAR""")|13|
||EDUC|Int32||XmlEnum("""EDUC""")|14|
||ACAF|Int32||XmlEnum("""ACAF""")|15|
||AGRI|Int32||XmlEnum("""AGRI""")|16|
||CSTR|Int32||XmlEnum("""CSTR""")|17|
||SPLY|Int32||XmlEnum("""SPLY""")|18|
||MAFG|Int32||XmlEnum("""MAFG""")|19|
||MING|Int32||XmlEnum("""MING""")|20|
||WTER|Int32||XmlEnum("""WTER""")|21|

---

## Enum ISO20022.Auth029001.NotAvailable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTAV|Int32||XmlEnum("""NTAV""")|1|

---

## Enum ISO20022.Auth029001.NotReported1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORP|Int32||XmlEnum("""NORP""")|1|

---

## Enum ISO20022.Auth029001.Operation3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ORRR|Int32||XmlEnum("""ORRR""")|1|
||ANDD|Int32||XmlEnum("""ANDD""")|2|

---

## Value ISO20022.Auth029001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth029001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth029001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth029001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth029001.PartyIdentification121Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Auth029001.GenericIdentification1||XmlElement()||
|+|NmAndAdr|ISO20022.Auth029001.NameAndAddress5||XmlElement()||
|+|LglNttyIdr|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,LglNttyIdr,AnyBIC))|

---

## Value ISO20022.Auth029001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth029001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth029001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Enum ISO20022.Auth029001.PartyNatureType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPS|Int32||XmlEnum("""CCPS""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||NFIN|Int32||XmlEnum("""NFIN""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|

---

## Value ISO20022.Auth029001.PostalAddress1


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

## Value ISO20022.Auth029001.ProductClassificationCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnqPdctIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ClssfctnFinInstrm|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""))|

---

## Enum ISO20022.Auth029001.ProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|
||INTR|Int32||XmlEnum("""INTR""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CURR|Int32||XmlEnum("""CURR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Value ISO20022.Auth029001.SecuritiesTradeVenueCriteria1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyMIC|String||XmlElement()||
|+|MIC|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""MIC""",MIC),validPattern("""MIC""",MIC,"""[A-Z0-9]{4,4}"""),validChoice(AnyMIC,MIC))|

---

## Value ISO20022.Auth029001.SecurityIdentification20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Nm,ISIN))|

---

## Value ISO20022.Auth029001.SecurityIdentificationQuery4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Bskt|global::System.Collections.Generic.List<ISO20022.Auth029001.BasketQuery1>||XmlElement()||
|+|Indx|global::System.Collections.Generic.List<ISO20022.Auth029001.SecurityIdentification20Choice>||XmlElement()||
|+|UnqPdctIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NotAvlbl|String||XmlElement()||
|+|AltrntvInstrmId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ISIN|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Bskt""",Bskt),validList("""Bskt""",Bskt),validElement(Bskt),validRequired("""Indx""",Indx),validList("""Indx""",Indx),validElement(Indx),validRequired("""UnqPdctIdr""",UnqPdctIdr),validRequired("""AltrntvInstrmId""",AltrntvInstrmId),validRequired("""ISIN""",ISIN),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(NotRptd,Bskt,Indx,UnqPdctIdr,NotAvlbl,AltrntvInstrmId,ISIN))|

---

## Value ISO20022.Auth029001.SecurityIdentificationQueryCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvInstrmId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ISIN|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth029001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth029001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth029001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.TradeAdditionalQueryCriteria9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Lvl|String||XmlElement()||
|+|PdctClssfctn|ISO20022.Auth029001.ProductClassificationCriteria1||XmlElement()||
|+|AsstClss|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CorpSctr|ISO20022.Auth029001.CorporateSectorCriteria6||XmlElement()||
|+|NtrOfCtrPty|String||XmlElement()||
|+|ExctnVn|ISO20022.Auth029001.SecuritiesTradeVenueCriteria1Choice||XmlElement()||
|+|ActnTp|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdctClssfctn),validElement(CorpSctr),validElement(ExctnVn))|

---

## Value ISO20022.Auth029001.TradeDateTimeQueryCriteria6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstrclAsOfDt|DateTime||XmlElement()||
|+|CollTmStmp|ISO20022.Auth029001.DateTimeOrBlankQuery1Choice||XmlElement()||
|+|EarlyTermntnDt|ISO20022.Auth029001.DatePeriod1||XmlElement()||
|+|XprtnDt|ISO20022.Auth029001.DateOrBlankQuery2Choice||XmlElement()||
|+|ValtnDtTm|ISO20022.Auth029001.DateTimePeriod1||XmlElement()||
|+|FctvDt|ISO20022.Auth029001.DatePeriod1||XmlElement()||
|+|MtrtyDt|ISO20022.Auth029001.DateOrBlankQuery2Choice||XmlElement()||
|+|ExctnDtTm|ISO20022.Auth029001.DateTimePeriod1||XmlElement()||
|+|RptgDtTm|ISO20022.Auth029001.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollTmStmp),validElement(EarlyTermntnDt),validElement(XprtnDt),validElement(ValtnDtTm),validElement(FctvDt),validElement(MtrtyDt),validElement(ExctnDtTm),validElement(RptgDtTm))|

---

## Value ISO20022.Auth029001.TradePartyIdentificationQuery10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Auth029001.PartyIdentification248Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id),validChoice(NotRptd,Id))|

---

## Value ISO20022.Auth029001.TradePartyIdentificationQuery11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Auth029001.OrganisationIdentification15Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id),validChoice(NotRptd,Id))|

---

## Value ISO20022.Auth029001.TradePartyQueryCriteria7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrMmb|ISO20022.Auth029001.TradePartyIdentificationQuery10Choice||XmlElement()||
|+|CCP|ISO20022.Auth029001.TradePartyIdentificationQuery11Choice||XmlElement()||
|+|Brkr|ISO20022.Auth029001.TradePartyIdentificationQuery11Choice||XmlElement()||
|+|SubmitgAgt|ISO20022.Auth029001.TradePartyIdentificationQuery11Choice||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth029001.TradePartyIdentificationQuery11Choice||XmlElement()||
|+|Bnfcry|ISO20022.Auth029001.TradePartyIdentificationQuery10Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth029001.TradePartyIdentificationQuery10Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth029001.TradePartyIdentificationQuery10Choice||XmlElement()||
|+|Oprtr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrMmb),validElement(CCP),validElement(Brkr),validElement(SubmitgAgt),validElement(NttyRspnsblForRpt),validElement(Bnfcry),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth029001.TradeQueryCriteria14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCrit|ISO20022.Auth029001.TradeAdditionalQueryCriteria9||XmlElement()||
|+|TmCrit|ISO20022.Auth029001.TradeDateTimeQueryCriteria6||XmlElement()||
|+|FinInstrmCrit|ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3||XmlElement()||
|+|TradPtyCrit|ISO20022.Auth029001.TradePartyQueryCriteria7||XmlElement()||
|+|OutsdngTradInd|String||XmlElement()||
|+|MrgnLifeCyclHstry|String||XmlElement()||
|+|TradLifeCyclHstry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrCrit),validElement(TmCrit),validElement(FinInstrmCrit),validElement(TradPtyCrit))|

---

## Value ISO20022.Auth029001.TradeQueryExecutionFrequency3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DayOfMnth|global::System.Collections.Generic.List<Decimal>||XmlElement()||
|+|DlvryDay|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FrqcyTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth029001.TradeRecurrentQuery7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldUntil|DateTime||XmlElement()||
|+|Frqcy|global::System.Collections.Generic.List<ISO20022.Auth029001.TradeQueryExecutionFrequency3>||XmlElement()||
|+|QryTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Frqcy""",Frqcy),validList("""Frqcy""",Frqcy),validElement(Frqcy))|

---

## Value ISO20022.Auth029001.TradeReportQuery18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcrntQry|ISO20022.Auth029001.TradeRecurrentQuery7||XmlElement()||
|+|AdHocQry|ISO20022.Auth029001.TradeQueryCriteria14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcrntQry),validElement(AdHocQry),validChoice(RcrntQry,AdHocQry))|

---

## Value ISO20022.Auth029001.TradeSecurityIdentificationQueryCriteria3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygInstrmId|global::System.Collections.Generic.List<ISO20022.Auth029001.SecurityIdentificationQuery4Choice>||XmlElement()||
|+|UnqPdctIdr|global::System.Collections.Generic.List<ISO20022.Auth029001.UPIQueryCriteria1>||XmlElement()||
|+|ISIN|global::System.Collections.Generic.List<ISO20022.Auth029001.ISINQueryCriteria1>||XmlElement()||
|+|CtrctTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Auth029001.SecurityIdentificationQueryCriteria1>||XmlElement()||
|+|Oprtr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygInstrmId""",UndrlygInstrmId),validElement(UndrlygInstrmId),validList("""UnqPdctIdr""",UnqPdctIdr),validElement(UnqPdctIdr),validList("""ISIN""",ISIN),validElement(ISIN),validList("""Id""",Id),validElement(Id))|

---

## Enum ISO20022.Auth029001.TransactionOperationType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MARU|Int32||XmlEnum("""MARU""")|1|
||VALU|Int32||XmlEnum("""VALU""")|2|
||TERM|Int32||XmlEnum("""TERM""")|3|
||REVI|Int32||XmlEnum("""REVI""")|4|
||POSC|Int32||XmlEnum("""POSC""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||NEWT|Int32||XmlEnum("""NEWT""")|7|
||MODI|Int32||XmlEnum("""MODI""")|8|
||EROR|Int32||XmlEnum("""EROR""")|9|
||CORR|Int32||XmlEnum("""CORR""")|10|
||COMP|Int32||XmlEnum("""COMP""")|11|

---

## Value ISO20022.Auth029001.UPIQueryCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotRptd|String||XmlElement()||
|+|Idr|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth029001.WeekDay3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEND|Int32||XmlEnum("""WEND""")|1|
||WDAY|Int32||XmlEnum("""WDAY""")|2|
||WEDD|Int32||XmlEnum("""WEDD""")|3|
||TUED|Int32||XmlEnum("""TUED""")|4|
||THUD|Int32||XmlEnum("""THUD""")|5|
||SUND|Int32||XmlEnum("""SUND""")|6|
||SATD|Int32||XmlEnum("""SATD""")|7|
||MOND|Int32||XmlEnum("""MOND""")|8|
||FRID|Int32||XmlEnum("""FRID""")|9|
||IBHL|Int32||XmlEnum("""IBHL""")|10|
||XBHL|Int32||XmlEnum("""XBHL""")|11|
||ALLD|Int32||XmlEnum("""ALLD""")|12|

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

