# reda.015.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda015001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda015001.DateAndDateTimeSearch4Choice {
        + Dt  : ISO20022.Reda015001.DatePeriodSearch1Choice
        + DtTm  : ISO20022.Reda015001.DateTimeSearch2Choice
    }
    ISO20022.Reda015001.DateAndDateTimeSearch4Choice *-- ISO20022.Reda015001.DatePeriodSearch1Choice
    ISO20022.Reda015001.DateAndDateTimeSearch4Choice *-- ISO20022.Reda015001.DateTimeSearch2Choice
    class ISO20022.Reda015001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Reda015001.DatePeriodSearch1Choice {
        + NEQDt  : DateTime
        + EQDt  : DateTime
        + FrToDt  : ISO20022.Reda015001.DatePeriod2
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    ISO20022.Reda015001.DatePeriodSearch1Choice *-- ISO20022.Reda015001.DatePeriod2
    class ISO20022.Reda015001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Reda015001.DateTimeSearch2Choice {
        + NEQDtTm  : DateTime
        + EQDtTm  : DateTime
        + FrToDtTm  : ISO20022.Reda015001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Reda015001.DateTimeSearch2Choice *-- ISO20022.Reda015001.DateTimePeriod1
    class ISO20022.Reda015001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda015001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda015001.LockStatus1Code {
        ULCK = 1
        LOCK = 2
    }
    class ISO20022.Reda015001.MessageHeader2 {
        + ReqTp  : ISO20022.Reda015001.RequestType2Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Reda015001.MessageHeader2 *-- ISO20022.Reda015001.RequestType2Choice
    class ISO20022.Reda015001.NameAndAddress5 {
        + Adr  : ISO20022.Reda015001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda015001.NameAndAddress5 *-- ISO20022.Reda015001.PostalAddress1
    class ISO20022.Reda015001.PartyDataReturnCriteria2 {
        + MktSpcfcAttr  : String
        + LckSts  : String
        + ResTp  : String
        + CtctDtls  : String
        + TechAdr  : String
        + Adr  : String
        + ShrtNm  : String
        + Nm  : String
        + RstrctdOnDt  : String
        + RstrctnId  : String
        + RspnsblPtyId  : String
        + PtyId  : String
        + Tp  : String
        + ClsgDt  : String
        + OpngDt  : String
    }
    class ISO20022.Reda015001.PartyDataSearchCriteria2 {
        + LckSts  : ISO20022.Reda015001.PartyLockStatus1
        + ResTp  : String
        + RstrctnIsseDt  : ISO20022.Reda015001.DateAndDateTimeSearch4Choice
        + RstrctnId  : String
        + PtyId  : ISO20022.Reda015001.PartyIdentification136
        + RspnsblPtyId  : ISO20022.Reda015001.PartyIdentification136
        + Tp  : ISO20022.Reda015001.SystemPartyType1Choice
        + ClsgDt  : ISO20022.Reda015001.DatePeriodSearch1Choice
        + OpngDt  : ISO20022.Reda015001.DatePeriodSearch1Choice
    }
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.PartyLockStatus1
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.DateAndDateTimeSearch4Choice
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.PartyIdentification136
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.PartyIdentification136
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.SystemPartyType1Choice
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.DatePeriodSearch1Choice
    ISO20022.Reda015001.PartyDataSearchCriteria2 *-- ISO20022.Reda015001.DatePeriodSearch1Choice
    class ISO20022.Reda015001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Reda015001.NameAndAddress5
        + PrtryId  : ISO20022.Reda015001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Reda015001.PartyIdentification120Choice *-- ISO20022.Reda015001.NameAndAddress5
    ISO20022.Reda015001.PartyIdentification120Choice *-- ISO20022.Reda015001.GenericIdentification36
    class ISO20022.Reda015001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Reda015001.PartyIdentification120Choice
    }
    ISO20022.Reda015001.PartyIdentification136 *-- ISO20022.Reda015001.PartyIdentification120Choice
    class ISO20022.Reda015001.PartyLockStatus1 {
        + LckRsn  : global::System.Collections.Generic.List~String~
        + Sts  : String
        + VldFr  : DateTime
    }
    class ISO20022.Reda015001.PartyQueryV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda015001.SupplementaryData1~
        + RtrCrit  : ISO20022.Reda015001.PartyDataReturnCriteria2
        + SchCrit  : ISO20022.Reda015001.PartyDataSearchCriteria2
        + MsgHdr  : ISO20022.Reda015001.MessageHeader2
    }
    ISO20022.Reda015001.PartyQueryV01 *-- ISO20022.Reda015001.SupplementaryData1
    ISO20022.Reda015001.PartyQueryV01 *-- ISO20022.Reda015001.PartyDataReturnCriteria2
    ISO20022.Reda015001.PartyQueryV01 *-- ISO20022.Reda015001.PartyDataSearchCriteria2
    ISO20022.Reda015001.PartyQueryV01 *-- ISO20022.Reda015001.MessageHeader2
    class ISO20022.Reda015001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda015001.RequestType1Code {
        RT05 = 1
        RT04 = 2
        RT03 = 3
        RT02 = 4
        RT01 = 5
    }
    class ISO20022.Reda015001.RequestType2Choice {
        + Prtry  : ISO20022.Reda015001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Reda015001.RequestType2Choice *-- ISO20022.Reda015001.GenericIdentification1
    class ISO20022.Reda015001.RequestType2Code {
        RT15 = 1
        RT14 = 2
        RT13 = 3
        RT12 = 4
        RT11 = 5
    }
    class ISO20022.Reda015001.ResidenceType1Code {
        MXED = 1
        FRGN = 2
        DMST = 3
    }
    class ISO20022.Reda015001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda015001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda015001.SupplementaryData1 *-- ISO20022.Reda015001.SupplementaryDataEnvelope1
    class ISO20022.Reda015001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda015001.SystemPartyType1Choice {
        + Prtry  : String
        + Cd  : String
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

## Enum ISO20022.Reda015001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Reda015001.DateAndDateTimeSearch4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|ISO20022.Reda015001.DatePeriodSearch1Choice||XmlElement()||
|+|DtTm|ISO20022.Reda015001.DateTimeSearch2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validElement(DtTm),validChoice(Dt,DtTm))|

---

## Value ISO20022.Reda015001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda015001.DatePeriodSearch1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDt|DateTime||XmlElement()||
|+|EQDt|DateTime||XmlElement()||
|+|FrToDt|ISO20022.Reda015001.DatePeriod2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt),validChoice(NEQDt,EQDt,FrToDt,ToDt,FrDt))|

---

## Value ISO20022.Reda015001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda015001.DateTimeSearch2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDtTm|DateTime||XmlElement()||
|+|EQDtTm|DateTime||XmlElement()||
|+|FrToDtTm|ISO20022.Reda015001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDtTm),validChoice(NEQDtTm,EQDtTm,FrToDtTm,ToDtTm,FrDtTm))|

---

## Type ISO20022.Reda015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyQry|ISO20022.Reda015001.PartyQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyQry))|

---

## Value ISO20022.Reda015001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda015001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda015001.LockStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ULCK|Int32||XmlEnum("""ULCK""")|1|
||LOCK|Int32||XmlEnum("""LOCK""")|2|

---

## Value ISO20022.Reda015001.MessageHeader2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Reda015001.RequestType2Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Value ISO20022.Reda015001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda015001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda015001.PartyDataReturnCriteria2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktSpcfcAttr|String||XmlElement()||
|+|LckSts|String||XmlElement()||
|+|ResTp|String||XmlElement()||
|+|CtctDtls|String||XmlElement()||
|+|TechAdr|String||XmlElement()||
|+|Adr|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|RstrctdOnDt|String||XmlElement()||
|+|RstrctnId|String||XmlElement()||
|+|RspnsblPtyId|String||XmlElement()||
|+|PtyId|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|ClsgDt|String||XmlElement()||
|+|OpngDt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda015001.PartyDataSearchCriteria2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LckSts|ISO20022.Reda015001.PartyLockStatus1||XmlElement()||
|+|ResTp|String||XmlElement()||
|+|RstrctnIsseDt|ISO20022.Reda015001.DateAndDateTimeSearch4Choice||XmlElement()||
|+|RstrctnId|String||XmlElement()||
|+|PtyId|ISO20022.Reda015001.PartyIdentification136||XmlElement()||
|+|RspnsblPtyId|ISO20022.Reda015001.PartyIdentification136||XmlElement()||
|+|Tp|ISO20022.Reda015001.SystemPartyType1Choice||XmlElement()||
|+|ClsgDt|ISO20022.Reda015001.DatePeriodSearch1Choice||XmlElement()||
|+|OpngDt|ISO20022.Reda015001.DatePeriodSearch1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LckSts),validElement(RstrctnIsseDt),validElement(PtyId),validElement(RspnsblPtyId),validElement(Tp),validElement(ClsgDt),validElement(OpngDt))|

---

## Value ISO20022.Reda015001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda015001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda015001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda015001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Reda015001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda015001.PartyLockStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LckRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Sts|String||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Reda015001.PartyQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda015001.SupplementaryData1>||XmlElement()||
|+|RtrCrit|ISO20022.Reda015001.PartyDataReturnCriteria2||XmlElement()||
|+|SchCrit|ISO20022.Reda015001.PartyDataSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Reda015001.MessageHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RtrCrit),validElement(SchCrit),validElement(MsgHdr))|

---

## Value ISO20022.Reda015001.PostalAddress1


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

## Enum ISO20022.Reda015001.RequestType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT05|Int32||XmlEnum("""RT05""")|1|
||RT04|Int32||XmlEnum("""RT04""")|2|
||RT03|Int32||XmlEnum("""RT03""")|3|
||RT02|Int32||XmlEnum("""RT02""")|4|
||RT01|Int32||XmlEnum("""RT01""")|5|

---

## Value ISO20022.Reda015001.RequestType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda015001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Enum ISO20022.Reda015001.RequestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT15|Int32||XmlEnum("""RT15""")|1|
||RT14|Int32||XmlEnum("""RT14""")|2|
||RT13|Int32||XmlEnum("""RT13""")|3|
||RT12|Int32||XmlEnum("""RT12""")|4|
||RT11|Int32||XmlEnum("""RT11""")|5|

---

## Enum ISO20022.Reda015001.ResidenceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MXED|Int32||XmlEnum("""MXED""")|1|
||FRGN|Int32||XmlEnum("""FRGN""")|2|
||DMST|Int32||XmlEnum("""DMST""")|3|

---

## Value ISO20022.Reda015001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda015001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda015001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda015001.SystemPartyType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

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

