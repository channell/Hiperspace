# camt.064.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt064001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt064001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt064001.AccountIdentification4Choice *-- ISO20022.Camt064001.GenericAccountIdentification1
    class ISO20022.Camt064001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt064001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt064001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt064001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt064001.GenericAccountIdentification1 *-- ISO20022.Camt064001.AccountSchemeName1Choice
    class ISO20022.Camt064001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt064001.LimitType4Code {
        ACOL = 1
        UCDT = 2
        EXGT = 3
    }
    class ISO20022.Camt064001.LimitUtilisationJournalQueryV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt064001.SupplementaryData1~
        + SchCrit  : ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2
        + MsgHdr  : ISO20022.Camt064001.MessageHeader1
    }
    ISO20022.Camt064001.LimitUtilisationJournalQueryV01 *-- ISO20022.Camt064001.SupplementaryData1
    ISO20022.Camt064001.LimitUtilisationJournalQueryV01 *-- ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2
    ISO20022.Camt064001.LimitUtilisationJournalQueryV01 *-- ISO20022.Camt064001.MessageHeader1
    class ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2 {
        + BilLmtCtrPtyId  : ISO20022.Camt064001.SystemPartyIdentification8
        + AcctOwnr  : ISO20022.Camt064001.PartyIdentification136
        + LmtCcy  : String
        + AcctId  : ISO20022.Camt064001.AccountIdentification4Choice
        + JrnlActvtyDt  : DateTime
        + LmtTp  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2 *-- ISO20022.Camt064001.SystemPartyIdentification8
    ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2 *-- ISO20022.Camt064001.PartyIdentification136
    ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2 *-- ISO20022.Camt064001.AccountIdentification4Choice
    class ISO20022.Camt064001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Camt064001.NameAndAddress5 {
        + Adr  : ISO20022.Camt064001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt064001.NameAndAddress5 *-- ISO20022.Camt064001.PostalAddress1
    class ISO20022.Camt064001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Camt064001.NameAndAddress5
        + PrtryId  : ISO20022.Camt064001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt064001.PartyIdentification120Choice *-- ISO20022.Camt064001.NameAndAddress5
    ISO20022.Camt064001.PartyIdentification120Choice *-- ISO20022.Camt064001.GenericIdentification36
    class ISO20022.Camt064001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Camt064001.PartyIdentification120Choice
    }
    ISO20022.Camt064001.PartyIdentification136 *-- ISO20022.Camt064001.PartyIdentification120Choice
    class ISO20022.Camt064001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt064001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt064001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt064001.SupplementaryData1 *-- ISO20022.Camt064001.SupplementaryDataEnvelope1
    class ISO20022.Camt064001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt064001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Camt064001.PartyIdentification136
        + Id  : ISO20022.Camt064001.PartyIdentification136
    }
    ISO20022.Camt064001.SystemPartyIdentification8 *-- ISO20022.Camt064001.PartyIdentification136
    ISO20022.Camt064001.SystemPartyIdentification8 *-- ISO20022.Camt064001.PartyIdentification136
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

## Value ISO20022.Camt064001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt064001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt064001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt064001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Type ISO20022.Camt064001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LmtUtlstnJrnlQry|ISO20022.Camt064001.LimitUtilisationJournalQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LmtUtlstnJrnlQry))|

---

## Value ISO20022.Camt064001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt064001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt064001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt064001.LimitType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACOL|Int32||XmlEnum("""ACOL""")|1|
||UCDT|Int32||XmlEnum("""UCDT""")|2|
||EXGT|Int32||XmlEnum("""EXGT""")|3|

---

## Aspect ISO20022.Camt064001.LimitUtilisationJournalQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt064001.SupplementaryData1>||XmlElement()||
|+|SchCrit|ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Camt064001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))|

---

## Value ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BilLmtCtrPtyId|ISO20022.Camt064001.SystemPartyIdentification8||XmlElement()||
|+|AcctOwnr|ISO20022.Camt064001.PartyIdentification136||XmlElement()||
|+|LmtCcy|String||XmlElement()||
|+|AcctId|ISO20022.Camt064001.AccountIdentification4Choice||XmlElement()||
|+|JrnlActvtyDt|DateTime||XmlElement()||
|+|LmtTp|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BilLmtCtrPtyId),validElement(AcctOwnr),validPattern("""LmtCcy""",LmtCcy,"""[A-Z]{3,3}"""),validElement(AcctId))|

---

## Value ISO20022.Camt064001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt064001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt064001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Camt064001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt064001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt064001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Camt064001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Camt064001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Camt064001.PostalAddress1


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

## Value ISO20022.Camt064001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt064001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt064001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt064001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Camt064001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Camt064001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

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

