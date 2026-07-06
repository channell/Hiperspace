# reda.019.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda019001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda019001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Reda019001.DatePeriodSearch1Choice {
        + NEQDt  : DateTime
        + EQDt  : DateTime
        + FrToDt  : ISO20022.Reda019001.DatePeriod2
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    ISO20022.Reda019001.DatePeriodSearch1Choice *-- ISO20022.Reda019001.DatePeriod2
    class ISO20022.Reda019001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda019001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda019001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda019001.MessageHeader2 {
        + ReqTp  : ISO20022.Reda019001.RequestType2Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Reda019001.MessageHeader2 *-- ISO20022.Reda019001.RequestType2Choice
    class ISO20022.Reda019001.NameAndAddress5 {
        + Adr  : ISO20022.Reda019001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda019001.NameAndAddress5 *-- ISO20022.Reda019001.PostalAddress1
    class ISO20022.Reda019001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Reda019001.NameAndAddress5
        + PrtryId  : ISO20022.Reda019001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Reda019001.PartyIdentification120Choice *-- ISO20022.Reda019001.NameAndAddress5
    ISO20022.Reda019001.PartyIdentification120Choice *-- ISO20022.Reda019001.GenericIdentification36
    class ISO20022.Reda019001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Reda019001.PartyIdentification120Choice
    }
    ISO20022.Reda019001.PartyIdentification136 *-- ISO20022.Reda019001.PartyIdentification120Choice
    class ISO20022.Reda019001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda019001.RequestType1Code {
        RT05 = 1
        RT04 = 2
        RT03 = 3
        RT02 = 4
        RT01 = 5
    }
    class ISO20022.Reda019001.RequestType2Choice {
        + Prtry  : ISO20022.Reda019001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Reda019001.RequestType2Choice *-- ISO20022.Reda019001.GenericIdentification1
    class ISO20022.Reda019001.RequestType2Code {
        RT15 = 1
        RT14 = 2
        RT13 = 3
        RT12 = 4
        RT11 = 5
    }
    class ISO20022.Reda019001.SecuritiesAccountQueryV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda019001.SupplementaryData1~
        + RtrCrit  : ISO20022.Reda019001.SecuritiesAccountReturnCriteria1
        + SchCrit  : ISO20022.Reda019001.SecuritiesAccountSearchCriteria2
        + MsgHdr  : ISO20022.Reda019001.MessageHeader2
    }
    ISO20022.Reda019001.SecuritiesAccountQueryV01 *-- ISO20022.Reda019001.SupplementaryData1
    ISO20022.Reda019001.SecuritiesAccountQueryV01 *-- ISO20022.Reda019001.SecuritiesAccountReturnCriteria1
    ISO20022.Reda019001.SecuritiesAccountQueryV01 *-- ISO20022.Reda019001.SecuritiesAccountSearchCriteria2
    ISO20022.Reda019001.SecuritiesAccountQueryV01 *-- ISO20022.Reda019001.MessageHeader2
    class ISO20022.Reda019001.SecuritiesAccountReturnCriteria1 {
        + PricgSchme  : String
        + EndInvstrFlg  : String
        + ClsgDt  : String
        + OpngDt  : String
        + AcctTp  : String
        + AcctSvcr  : String
        + PtyTp  : String
        + PtyId  : String
        + AcctId  : String
    }
    class ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 {
        + PricgSchme  : String
        + EndInvstrFlg  : String
        + AcctTp  : ISO20022.Reda019001.SystemSecuritiesAccountType1Choice
        + ClsgDt  : ISO20022.Reda019001.DatePeriodSearch1Choice
        + OpngDt  : ISO20022.Reda019001.DatePeriodSearch1Choice
        + PtyTp  : ISO20022.Reda019001.SystemPartyType1Choice
        + AcctOwnr  : ISO20022.Reda019001.SystemPartyIdentification8
        + AcctSvcr  : ISO20022.Reda019001.PartyIdentification136
        + AcctId  : String
    }
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.SystemSecuritiesAccountType1Choice
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.DatePeriodSearch1Choice
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.DatePeriodSearch1Choice
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.SystemPartyType1Choice
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.SystemPartyIdentification8
    ISO20022.Reda019001.SecuritiesAccountSearchCriteria2 *-- ISO20022.Reda019001.PartyIdentification136
    class ISO20022.Reda019001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda019001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda019001.SupplementaryData1 *-- ISO20022.Reda019001.SupplementaryDataEnvelope1
    class ISO20022.Reda019001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda019001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Reda019001.PartyIdentification136
        + Id  : ISO20022.Reda019001.PartyIdentification136
    }
    ISO20022.Reda019001.SystemPartyIdentification8 *-- ISO20022.Reda019001.PartyIdentification136
    ISO20022.Reda019001.SystemPartyIdentification8 *-- ISO20022.Reda019001.PartyIdentification136
    class ISO20022.Reda019001.SystemPartyType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda019001.SystemSecuritiesAccountType1Choice {
        + Prtry  : ISO20022.Reda019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda019001.SystemSecuritiesAccountType1Choice *-- ISO20022.Reda019001.GenericIdentification30
    class ISO20022.Reda019001.SystemSecuritiesAccountType1Code {
        ISSA = 1
        CSDO = 2
        TOFF = 3
        ICSA = 4
        CSDM = 5
        CSDP = 6
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

## Enum ISO20022.Reda019001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Reda019001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda019001.DatePeriodSearch1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDt|DateTime||XmlElement()||
|+|EQDt|DateTime||XmlElement()||
|+|FrToDt|ISO20022.Reda019001.DatePeriod2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt),validChoice(NEQDt,EQDt,FrToDt,ToDt,FrDt))|

---

## Type ISO20022.Reda019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctQry|ISO20022.Reda019001.SecuritiesAccountQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctQry))|

---

## Value ISO20022.Reda019001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda019001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda019001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda019001.MessageHeader2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Reda019001.RequestType2Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Value ISO20022.Reda019001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda019001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda019001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda019001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda019001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda019001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Reda019001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda019001.PostalAddress1


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

## Enum ISO20022.Reda019001.RequestType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT05|Int32||XmlEnum("""RT05""")|1|
||RT04|Int32||XmlEnum("""RT04""")|2|
||RT03|Int32||XmlEnum("""RT03""")|3|
||RT02|Int32||XmlEnum("""RT02""")|4|
||RT01|Int32||XmlEnum("""RT01""")|5|

---

## Value ISO20022.Reda019001.RequestType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda019001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Enum ISO20022.Reda019001.RequestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT15|Int32||XmlEnum("""RT15""")|1|
||RT14|Int32||XmlEnum("""RT14""")|2|
||RT13|Int32||XmlEnum("""RT13""")|3|
||RT12|Int32||XmlEnum("""RT12""")|4|
||RT11|Int32||XmlEnum("""RT11""")|5|

---

## Aspect ISO20022.Reda019001.SecuritiesAccountQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda019001.SupplementaryData1>||XmlElement()||
|+|RtrCrit|ISO20022.Reda019001.SecuritiesAccountReturnCriteria1||XmlElement()||
|+|SchCrit|ISO20022.Reda019001.SecuritiesAccountSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Reda019001.MessageHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RtrCrit),validElement(SchCrit),validElement(MsgHdr))|

---

## Value ISO20022.Reda019001.SecuritiesAccountReturnCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgSchme|String||XmlElement()||
|+|EndInvstrFlg|String||XmlElement()||
|+|ClsgDt|String||XmlElement()||
|+|OpngDt|String||XmlElement()||
|+|AcctTp|String||XmlElement()||
|+|AcctSvcr|String||XmlElement()||
|+|PtyTp|String||XmlElement()||
|+|PtyId|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda019001.SecuritiesAccountSearchCriteria2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgSchme|String||XmlElement()||
|+|EndInvstrFlg|String||XmlElement()||
|+|AcctTp|ISO20022.Reda019001.SystemSecuritiesAccountType1Choice||XmlElement()||
|+|ClsgDt|ISO20022.Reda019001.DatePeriodSearch1Choice||XmlElement()||
|+|OpngDt|ISO20022.Reda019001.DatePeriodSearch1Choice||XmlElement()||
|+|PtyTp|ISO20022.Reda019001.SystemPartyType1Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Reda019001.SystemPartyIdentification8||XmlElement()||
|+|AcctSvcr|ISO20022.Reda019001.PartyIdentification136||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PricgSchme""",PricgSchme,"""[a-zA-Z0-9]{4}"""),validPattern("""EndInvstrFlg""",EndInvstrFlg,"""[a-zA-Z0-9]{4}"""),validElement(AcctTp),validElement(ClsgDt),validElement(OpngDt),validElement(PtyTp),validElement(AcctOwnr),validElement(AcctSvcr))|

---

## Value ISO20022.Reda019001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda019001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda019001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda019001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Reda019001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Reda019001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Reda019001.SystemPartyType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda019001.SystemSecuritiesAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda019001.SystemSecuritiesAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISSA|Int32||XmlEnum("""ISSA""")|1|
||CSDO|Int32||XmlEnum("""CSDO""")|2|
||TOFF|Int32||XmlEnum("""TOFF""")|3|
||ICSA|Int32||XmlEnum("""ICSA""")|4|
||CSDM|Int32||XmlEnum("""CSDM""")|5|
||CSDP|Int32||XmlEnum("""CSDP""")|6|

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

