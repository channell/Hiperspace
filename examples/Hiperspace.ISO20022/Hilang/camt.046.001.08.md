# camt.046.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt046001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt046001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt046001.AccountIdentification4Choice *-- ISO20022.Camt046001.GenericAccountIdentification1
    class ISO20022.Camt046001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt046001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt046001.AddressType3Choice {
        + Prtry  : ISO20022.Camt046001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt046001.AddressType3Choice *-- ISO20022.Camt046001.GenericIdentification30
    class ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt046001.BranchData5
        + FinInstnId  : ISO20022.Camt046001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt046001.BranchData5
    ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt046001.FinancialInstitutionIdentification23
    class ISO20022.Camt046001.BranchData5 {
        + PstlAdr  : ISO20022.Camt046001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt046001.BranchData5 *-- ISO20022.Camt046001.PostalAddress27
    class ISO20022.Camt046001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt046001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt046001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt046001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt046001.ClearingSystemIdentification2Choice
    class ISO20022.Camt046001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt046001.DateTimeSearch2Choice {
        + NEQDtTm  : DateTime
        + EQDtTm  : DateTime
        + FrToDtTm  : ISO20022.Camt046001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Camt046001.DateTimeSearch2Choice *-- ISO20022.Camt046001.DateTimePeriod1
    class ISO20022.Camt046001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt046001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt046001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt046001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt046001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt046001.FinancialInstitutionIdentification23 *-- ISO20022.Camt046001.GenericFinancialIdentification1
    ISO20022.Camt046001.FinancialInstitutionIdentification23 *-- ISO20022.Camt046001.PostalAddress27
    ISO20022.Camt046001.FinancialInstitutionIdentification23 *-- ISO20022.Camt046001.ClearingSystemMemberIdentification2
    class ISO20022.Camt046001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt046001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt046001.GenericAccountIdentification1 *-- ISO20022.Camt046001.AccountSchemeName1Choice
    class ISO20022.Camt046001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt046001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt046001.GenericFinancialIdentification1 *-- ISO20022.Camt046001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt046001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt046001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt046001.GetReservationV08 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt046001.SupplementaryData1~
        + RsvatnQryDef  : ISO20022.Camt046001.ReservationQuery6
        + MsgHdr  : ISO20022.Camt046001.MessageHeader9
    }
    ISO20022.Camt046001.GetReservationV08 *-- ISO20022.Camt046001.SupplementaryData1
    ISO20022.Camt046001.GetReservationV08 *-- ISO20022.Camt046001.ReservationQuery6
    ISO20022.Camt046001.GetReservationV08 *-- ISO20022.Camt046001.MessageHeader9
    class ISO20022.Camt046001.MarketInfrastructureIdentification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt046001.MessageHeader9 {
        + ReqTp  : ISO20022.Camt046001.RequestType4Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt046001.MessageHeader9 *-- ISO20022.Camt046001.RequestType4Choice
    class ISO20022.Camt046001.PostalAddress27 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + UnitNb  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + CareOf  : String
        + AdrTp  : ISO20022.Camt046001.AddressType3Choice
    }
    ISO20022.Camt046001.PostalAddress27 *-- ISO20022.Camt046001.AddressType3Choice
    class ISO20022.Camt046001.QueryType2Code {
        DELD = 1
        MODF = 2
        CHNG = 3
        ALLL = 4
    }
    class ISO20022.Camt046001.RequestType4Choice {
        + Prtry  : ISO20022.Camt046001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Camt046001.RequestType4Choice *-- ISO20022.Camt046001.GenericIdentification1
    class ISO20022.Camt046001.ReservationCriteria6Choice {
        + NewCrit  : ISO20022.Camt046001.ReservationCriteria7
        + QryNm  : String
    }
    ISO20022.Camt046001.ReservationCriteria6Choice *-- ISO20022.Camt046001.ReservationCriteria7
    class ISO20022.Camt046001.ReservationCriteria7 {
        + RtrCrit  : ISO20022.Camt046001.ReservationReturnCriteria1
        + SchCrit  : global::System.Collections.Generic.List~ISO20022.Camt046001.ReservationSearchCriteria6~
        + NewQryNm  : String
    }
    ISO20022.Camt046001.ReservationCriteria7 *-- ISO20022.Camt046001.ReservationReturnCriteria1
    ISO20022.Camt046001.ReservationCriteria7 *-- ISO20022.Camt046001.ReservationSearchCriteria6
    class ISO20022.Camt046001.ReservationQuery6 {
        + RsvatnCrit  : ISO20022.Camt046001.ReservationCriteria6Choice
        + QryTp  : String
    }
    ISO20022.Camt046001.ReservationQuery6 *-- ISO20022.Camt046001.ReservationCriteria6Choice
    class ISO20022.Camt046001.ReservationReturnCriteria1 {
        + StsInd  : String
        + StartDtTmInd  : String
    }
    class ISO20022.Camt046001.ReservationSearchCriteria6 {
        + AcctId  : ISO20022.Camt046001.AccountIdentification4Choice
        + AcctOwnr  : ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8
        + CurRsvatnTp  : global::System.Collections.Generic.List~ISO20022.Camt046001.ReservationType2Choice~
        + DfltRsvatnTp  : global::System.Collections.Generic.List~ISO20022.Camt046001.ReservationType2Choice~
        + SysId  : ISO20022.Camt046001.SystemIdentification2Choice
        + DtTm  : ISO20022.Camt046001.DateTimeSearch2Choice
    }
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.AccountIdentification4Choice
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.ReservationType2Choice
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.ReservationType2Choice
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.SystemIdentification2Choice
    ISO20022.Camt046001.ReservationSearchCriteria6 *-- ISO20022.Camt046001.DateTimeSearch2Choice
    class ISO20022.Camt046001.ReservationType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt046001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt046001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt046001.SupplementaryData1 *-- ISO20022.Camt046001.SupplementaryDataEnvelope1
    class ISO20022.Camt046001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt046001.SystemIdentification2Choice {
        + Ctry  : String
        + MktInfrstrctrId  : ISO20022.Camt046001.MarketInfrastructureIdentification1Choice
    }
    ISO20022.Camt046001.SystemIdentification2Choice *-- ISO20022.Camt046001.MarketInfrastructureIdentification1Choice
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

## Value ISO20022.Camt046001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt046001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt046001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt046001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt046001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt046001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt046001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt046001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt046001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt046001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt046001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt046001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt046001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt046001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt046001.DateTimeSearch2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDtTm|DateTime||XmlElement()||
|+|EQDtTm|DateTime||XmlElement()||
|+|FrToDtTm|ISO20022.Camt046001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDtTm),validChoice(NEQDtTm,EQDtTm,FrToDtTm,ToDtTm,FrDtTm))|

---

## Type ISO20022.Camt046001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GetRsvatn|ISO20022.Camt046001.GetReservationV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetRsvatn))|

---

## Value ISO20022.Camt046001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt046001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt046001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt046001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt046001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt046001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt046001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt046001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt046001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt046001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt046001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Aspect ISO20022.Camt046001.GetReservationV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt046001.SupplementaryData1>||XmlElement()||
|+|RsvatnQryDef|ISO20022.Camt046001.ReservationQuery6||XmlElement()||
|+|MsgHdr|ISO20022.Camt046001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RsvatnQryDef),validElement(MsgHdr))|

---

## Value ISO20022.Camt046001.MarketInfrastructureIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt046001.MessageHeader9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Camt046001.RequestType4Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Value ISO20022.Camt046001.PostalAddress27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|AdrTp|ISO20022.Camt046001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt046001.QueryType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELD|Int32||XmlEnum("""DELD""")|1|
||MODF|Int32||XmlEnum("""MODF""")|2|
||CHNG|Int32||XmlEnum("""CHNG""")|3|
||ALLL|Int32||XmlEnum("""ALLL""")|4|

---

## Value ISO20022.Camt046001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt046001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Value ISO20022.Camt046001.ReservationCriteria6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NewCrit|ISO20022.Camt046001.ReservationCriteria7||XmlElement()||
|+|QryNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewCrit),validChoice(NewCrit,QryNm))|

---

## Value ISO20022.Camt046001.ReservationCriteria7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrCrit|ISO20022.Camt046001.ReservationReturnCriteria1||XmlElement()||
|+|SchCrit|global::System.Collections.Generic.List<ISO20022.Camt046001.ReservationSearchCriteria6>||XmlElement()||
|+|NewQryNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrCrit),validList("""SchCrit""",SchCrit),validElement(SchCrit))|

---

## Value ISO20022.Camt046001.ReservationQuery6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsvatnCrit|ISO20022.Camt046001.ReservationCriteria6Choice||XmlElement()||
|+|QryTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsvatnCrit))|

---

## Value ISO20022.Camt046001.ReservationReturnCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsInd|String||XmlElement()||
|+|StartDtTmInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt046001.ReservationSearchCriteria6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|ISO20022.Camt046001.AccountIdentification4Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Camt046001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CurRsvatnTp|global::System.Collections.Generic.List<ISO20022.Camt046001.ReservationType2Choice>||XmlElement()||
|+|DfltRsvatnTp|global::System.Collections.Generic.List<ISO20022.Camt046001.ReservationType2Choice>||XmlElement()||
|+|SysId|ISO20022.Camt046001.SystemIdentification2Choice||XmlElement()||
|+|DtTm|ISO20022.Camt046001.DateTimeSearch2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctId),validElement(AcctOwnr),validList("""CurRsvatnTp""",CurRsvatnTp),validElement(CurRsvatnTp),validList("""DfltRsvatnTp""",DfltRsvatnTp),validElement(DfltRsvatnTp),validElement(SysId),validElement(DtTm))|

---

## Value ISO20022.Camt046001.ReservationType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt046001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt046001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt046001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt046001.SystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|MktInfrstrctrId|ISO20022.Camt046001.MarketInfrastructureIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(MktInfrstrctrId),validChoice(Ctry,MktInfrstrctrId))|

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

