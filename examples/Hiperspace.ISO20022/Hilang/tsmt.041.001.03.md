# tsmt.041.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt041001.Action2Code {
        CINR = 1
        ARRO = 2
        ARBA = 3
        SBDS = 4
        UPDT = 5
        WAIT = 6
        ARES = 7
        ARCS = 8
        ARDM = 9
        RSBS = 10
        RSTW = 11
        SBTW = 12
    }
    class ISO20022.Tsmt041001.BICIdentification1 {
        + BIC  : String
    }
    class ISO20022.Tsmt041001.BaselineStatus3Code {
        DARQ = 1
        SERQ = 2
        SCRQ = 3
        CLRQ = 4
        RARQ = 5
        AMRQ = 6
        COMP = 7
        ACTV = 8
        ESTD = 9
        PMTC = 10
        CLSD = 11
        PROP = 12
    }
    class ISO20022.Tsmt041001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt041001.DocumentIdentification3 {
        + Vrsn  : Decimal
        + Id  : String
    }
    class ISO20022.Tsmt041001.DocumentIdentification5 {
        + IdIssr  : ISO20022.Tsmt041001.BICIdentification1
        + Id  : String
    }
    ISO20022.Tsmt041001.DocumentIdentification5 *-- ISO20022.Tsmt041001.BICIdentification1
    class ISO20022.Tsmt041001.DocumentIdentification7 {
        + DtOfIsse  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt041001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Tsmt041001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt041001.PartyIdentification26 {
        + PstlAdr  : ISO20022.Tsmt041001.PostalAddress5
        + PrtryId  : ISO20022.Tsmt041001.GenericIdentification4
        + Nm  : String
    }
    ISO20022.Tsmt041001.PartyIdentification26 *-- ISO20022.Tsmt041001.PostalAddress5
    ISO20022.Tsmt041001.PartyIdentification26 *-- ISO20022.Tsmt041001.GenericIdentification4
    class ISO20022.Tsmt041001.PendingActivity2 {
        + Desc  : String
        + Tp  : String
    }
    class ISO20022.Tsmt041001.PostalAddress5 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Tsmt041001.TransactionReportItems3 {
        + PdgReqForActn  : global::System.Collections.Generic.List~ISO20022.Tsmt041001.PendingActivity2~
        + TtlNetAmt  : ISO20022.Tsmt041001.CurrencyAndAmount
        + OutsdngAmt  : ISO20022.Tsmt041001.CurrencyAndAmount
        + SubmitgBk  : global::System.Collections.Generic.List~ISO20022.Tsmt041001.BICIdentification1~
        + OblgrBk  : global::System.Collections.Generic.List~ISO20022.Tsmt041001.BICIdentification1~
        + SellrBkCtry  : String
        + SellrBk  : ISO20022.Tsmt041001.BICIdentification1
        + BuyrBkCtry  : String
        + BuyrBk  : ISO20022.Tsmt041001.BICIdentification1
        + Sellr  : ISO20022.Tsmt041001.PartyIdentification26
        + Buyr  : ISO20022.Tsmt041001.PartyIdentification26
        + PurchsOrdrRef  : ISO20022.Tsmt041001.DocumentIdentification7
        + UsrTxRef  : global::System.Collections.Generic.List~ISO20022.Tsmt041001.DocumentIdentification5~
        + TxSts  : ISO20022.Tsmt041001.TransactionStatus4
        + EstblishdBaselnId  : ISO20022.Tsmt041001.DocumentIdentification3
        + TxId  : String
    }
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.PendingActivity2
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.CurrencyAndAmount
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.CurrencyAndAmount
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.BICIdentification1
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.BICIdentification1
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.BICIdentification1
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.BICIdentification1
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.PartyIdentification26
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.PartyIdentification26
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.DocumentIdentification7
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.DocumentIdentification5
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.TransactionStatus4
    ISO20022.Tsmt041001.TransactionReportItems3 *-- ISO20022.Tsmt041001.DocumentIdentification3
    class ISO20022.Tsmt041001.TransactionReportV03 {
        + RptdItms  : global::System.Collections.Generic.List~ISO20022.Tsmt041001.TransactionReportItems3~
        + RltdMsgRef  : ISO20022.Tsmt041001.MessageIdentification1
        + RptId  : ISO20022.Tsmt041001.MessageIdentification1
    }
    ISO20022.Tsmt041001.TransactionReportV03 *-- ISO20022.Tsmt041001.TransactionReportItems3
    ISO20022.Tsmt041001.TransactionReportV03 *-- ISO20022.Tsmt041001.MessageIdentification1
    ISO20022.Tsmt041001.TransactionReportV03 *-- ISO20022.Tsmt041001.MessageIdentification1
    class ISO20022.Tsmt041001.TransactionStatus4 {
        + Sts  : String
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

## Enum ISO20022.Tsmt041001.Action2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CINR|Int32||XmlEnum("""CINR""")|1|
||ARRO|Int32||XmlEnum("""ARRO""")|2|
||ARBA|Int32||XmlEnum("""ARBA""")|3|
||SBDS|Int32||XmlEnum("""SBDS""")|4|
||UPDT|Int32||XmlEnum("""UPDT""")|5|
||WAIT|Int32||XmlEnum("""WAIT""")|6|
||ARES|Int32||XmlEnum("""ARES""")|7|
||ARCS|Int32||XmlEnum("""ARCS""")|8|
||ARDM|Int32||XmlEnum("""ARDM""")|9|
||RSBS|Int32||XmlEnum("""RSBS""")|10|
||RSTW|Int32||XmlEnum("""RSTW""")|11|
||SBTW|Int32||XmlEnum("""SBTW""")|12|

---

## Value ISO20022.Tsmt041001.BICIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Enum ISO20022.Tsmt041001.BaselineStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DARQ|Int32||XmlEnum("""DARQ""")|1|
||SERQ|Int32||XmlEnum("""SERQ""")|2|
||SCRQ|Int32||XmlEnum("""SCRQ""")|3|
||CLRQ|Int32||XmlEnum("""CLRQ""")|4|
||RARQ|Int32||XmlEnum("""RARQ""")|5|
||AMRQ|Int32||XmlEnum("""AMRQ""")|6|
||COMP|Int32||XmlEnum("""COMP""")|7|
||ACTV|Int32||XmlEnum("""ACTV""")|8|
||ESTD|Int32||XmlEnum("""ESTD""")|9|
||PMTC|Int32||XmlEnum("""PMTC""")|10|
||CLSD|Int32||XmlEnum("""CLSD""")|11|
||PROP|Int32||XmlEnum("""PROP""")|12|

---

## Value ISO20022.Tsmt041001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Type ISO20022.Tsmt041001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRpt|ISO20022.Tsmt041001.TransactionReportV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxRpt))|

---

## Value ISO20022.Tsmt041001.DocumentIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt041001.DocumentIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdIssr|ISO20022.Tsmt041001.BICIdentification1||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdIssr))|

---

## Value ISO20022.Tsmt041001.DocumentIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtOfIsse|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt041001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt041001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt041001.PartyIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Tsmt041001.PostalAddress5||XmlElement()||
|+|PrtryId|ISO20022.Tsmt041001.GenericIdentification4||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validElement(PrtryId))|

---

## Value ISO20022.Tsmt041001.PendingActivity2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt041001.PostalAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt041001.TransactionReportItems3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgReqForActn|global::System.Collections.Generic.List<ISO20022.Tsmt041001.PendingActivity2>||XmlElement()||
|+|TtlNetAmt|ISO20022.Tsmt041001.CurrencyAndAmount||XmlElement()||
|+|OutsdngAmt|ISO20022.Tsmt041001.CurrencyAndAmount||XmlElement()||
|+|SubmitgBk|global::System.Collections.Generic.List<ISO20022.Tsmt041001.BICIdentification1>||XmlElement()||
|+|OblgrBk|global::System.Collections.Generic.List<ISO20022.Tsmt041001.BICIdentification1>||XmlElement()||
|+|SellrBkCtry|String||XmlElement()||
|+|SellrBk|ISO20022.Tsmt041001.BICIdentification1||XmlElement()||
|+|BuyrBkCtry|String||XmlElement()||
|+|BuyrBk|ISO20022.Tsmt041001.BICIdentification1||XmlElement()||
|+|Sellr|ISO20022.Tsmt041001.PartyIdentification26||XmlElement()||
|+|Buyr|ISO20022.Tsmt041001.PartyIdentification26||XmlElement()||
|+|PurchsOrdrRef|ISO20022.Tsmt041001.DocumentIdentification7||XmlElement()||
|+|UsrTxRef|global::System.Collections.Generic.List<ISO20022.Tsmt041001.DocumentIdentification5>||XmlElement()||
|+|TxSts|ISO20022.Tsmt041001.TransactionStatus4||XmlElement()||
|+|EstblishdBaselnId|ISO20022.Tsmt041001.DocumentIdentification3||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PdgReqForActn""",PdgReqForActn),validElement(PdgReqForActn),validElement(TtlNetAmt),validElement(OutsdngAmt),validList("""SubmitgBk""",SubmitgBk),validElement(SubmitgBk),validList("""OblgrBk""",OblgrBk),validElement(OblgrBk),validPattern("""SellrBkCtry""",SellrBkCtry,"""[A-Z]{2,2}"""),validElement(SellrBk),validPattern("""BuyrBkCtry""",BuyrBkCtry,"""[A-Z]{2,2}"""),validElement(BuyrBk),validElement(Sellr),validElement(Buyr),validElement(PurchsOrdrRef),validList("""UsrTxRef""",UsrTxRef),validListMax("""UsrTxRef""",UsrTxRef,2),validElement(UsrTxRef),validElement(TxSts),validElement(EstblishdBaselnId))|

---

## Aspect ISO20022.Tsmt041001.TransactionReportV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptdItms|global::System.Collections.Generic.List<ISO20022.Tsmt041001.TransactionReportItems3>||XmlElement()||
|+|RltdMsgRef|ISO20022.Tsmt041001.MessageIdentification1||XmlElement()||
|+|RptId|ISO20022.Tsmt041001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RptdItms""",RptdItms),validElement(RptdItms),validElement(RltdMsgRef),validElement(RptId))|

---

## Value ISO20022.Tsmt041001.TransactionStatus4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

