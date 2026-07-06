# reda.018.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda018001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda018001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda018001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda018001.MarketSpecificAttribute1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Reda018001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Reda018001.NameAndAddress5 {
        + Adr  : ISO20022.Reda018001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda018001.NameAndAddress5 *-- ISO20022.Reda018001.PostalAddress1
    class ISO20022.Reda018001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Reda018001.NameAndAddress5
        + PrtryId  : ISO20022.Reda018001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Reda018001.PartyIdentification120Choice *-- ISO20022.Reda018001.NameAndAddress5
    ISO20022.Reda018001.PartyIdentification120Choice *-- ISO20022.Reda018001.GenericIdentification36
    class ISO20022.Reda018001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Reda018001.PartyIdentification120Choice
    }
    ISO20022.Reda018001.PartyIdentification136 *-- ISO20022.Reda018001.PartyIdentification120Choice
    class ISO20022.Reda018001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda018001.SecuritiesAccountCreationRequestV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda018001.SupplementaryData1~
        + SctiesAcct  : ISO20022.Reda018001.SystemSecuritiesAccount7
        + MsgHdr  : ISO20022.Reda018001.MessageHeader1
    }
    ISO20022.Reda018001.SecuritiesAccountCreationRequestV01 *-- ISO20022.Reda018001.SupplementaryData1
    ISO20022.Reda018001.SecuritiesAccountCreationRequestV01 *-- ISO20022.Reda018001.SystemSecuritiesAccount7
    ISO20022.Reda018001.SecuritiesAccountCreationRequestV01 *-- ISO20022.Reda018001.MessageHeader1
    class ISO20022.Reda018001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda018001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda018001.SupplementaryData1 *-- ISO20022.Reda018001.SupplementaryDataEnvelope1
    class ISO20022.Reda018001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda018001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Reda018001.PartyIdentification136
        + Id  : ISO20022.Reda018001.PartyIdentification136
    }
    ISO20022.Reda018001.SystemPartyIdentification8 *-- ISO20022.Reda018001.PartyIdentification136
    ISO20022.Reda018001.SystemPartyIdentification8 *-- ISO20022.Reda018001.PartyIdentification136
    class ISO20022.Reda018001.SystemRestriction1 {
        + Tp  : String
        + VldTo  : DateTime
        + VldFr  : DateTime
    }
    class ISO20022.Reda018001.SystemSecuritiesAccount7 {
        + PricgSchme  : String
        + EndInvstrFlg  : String
        + Rstrctn  : global::System.Collections.Generic.List~ISO20022.Reda018001.SystemRestriction1~
        + MktSpcfcAttr  : global::System.Collections.Generic.List~ISO20022.Reda018001.MarketSpecificAttribute1~
        + NegPos  : String
        + HldInd  : String
        + ClsgDt  : DateTime
        + OpngDt  : DateTime
        + Tp  : ISO20022.Reda018001.SystemSecuritiesAccountType1Choice
        + Id  : String
        + AcctOwnr  : ISO20022.Reda018001.SystemPartyIdentification8
    }
    ISO20022.Reda018001.SystemSecuritiesAccount7 *-- ISO20022.Reda018001.SystemRestriction1
    ISO20022.Reda018001.SystemSecuritiesAccount7 *-- ISO20022.Reda018001.MarketSpecificAttribute1
    ISO20022.Reda018001.SystemSecuritiesAccount7 *-- ISO20022.Reda018001.SystemSecuritiesAccountType1Choice
    ISO20022.Reda018001.SystemSecuritiesAccount7 *-- ISO20022.Reda018001.SystemPartyIdentification8
    class ISO20022.Reda018001.SystemSecuritiesAccountType1Choice {
        + Prtry  : ISO20022.Reda018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda018001.SystemSecuritiesAccountType1Choice *-- ISO20022.Reda018001.GenericIdentification30
    class ISO20022.Reda018001.SystemSecuritiesAccountType1Code {
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

## Enum ISO20022.Reda018001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Type ISO20022.Reda018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctCreReq|ISO20022.Reda018001.SecuritiesAccountCreationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctCreReq))|

---

## Value ISO20022.Reda018001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda018001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda018001.MarketSpecificAttribute1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda018001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda018001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda018001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda018001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda018001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda018001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda018001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Reda018001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda018001.PostalAddress1


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

## Aspect ISO20022.Reda018001.SecuritiesAccountCreationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda018001.SupplementaryData1>||XmlElement()||
|+|SctiesAcct|ISO20022.Reda018001.SystemSecuritiesAccount7||XmlElement()||
|+|MsgHdr|ISO20022.Reda018001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctiesAcct),validElement(MsgHdr))|

---

## Value ISO20022.Reda018001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda018001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda018001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda018001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Reda018001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Reda018001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Reda018001.SystemRestriction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|VldTo|DateTime||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda018001.SystemSecuritiesAccount7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgSchme|String||XmlElement()||
|+|EndInvstrFlg|String||XmlElement()||
|+|Rstrctn|global::System.Collections.Generic.List<ISO20022.Reda018001.SystemRestriction1>||XmlElement()||
|+|MktSpcfcAttr|global::System.Collections.Generic.List<ISO20022.Reda018001.MarketSpecificAttribute1>||XmlElement()||
|+|NegPos|String||XmlElement()||
|+|HldInd|String||XmlElement()||
|+|ClsgDt|DateTime||XmlElement()||
|+|OpngDt|DateTime||XmlElement()||
|+|Tp|ISO20022.Reda018001.SystemSecuritiesAccountType1Choice||XmlElement()||
|+|Id|String||XmlElement()||
|+|AcctOwnr|ISO20022.Reda018001.SystemPartyIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PricgSchme""",PricgSchme,"""[a-zA-Z0-9]{4}"""),validPattern("""EndInvstrFlg""",EndInvstrFlg,"""[a-zA-Z0-9]{4}"""),validList("""Rstrctn""",Rstrctn),validElement(Rstrctn),validList("""MktSpcfcAttr""",MktSpcfcAttr),validElement(MktSpcfcAttr),validElement(Tp),validElement(AcctOwnr))|

---

## Value ISO20022.Reda018001.SystemSecuritiesAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda018001.SystemSecuritiesAccountType1Code


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

