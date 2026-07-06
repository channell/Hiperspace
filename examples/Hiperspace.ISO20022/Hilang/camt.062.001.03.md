# camt.062.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt062001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt062001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt062001.AgreedRate2 {
        + QtdCcy  : String
        + UnitCcy  : String
        + XchgRate  : Decimal
    }
    class ISO20022.Camt062001.BalanceStatus2 {
        + Bal  : ISO20022.Camt062001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt062001.BalanceStatus2 *-- ISO20022.Camt062001.ActiveCurrencyAndAmount
    class ISO20022.Camt062001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt062001.CurrencyFactors1 {
        + Rate  : ISO20022.Camt062001.AgreedRate2
        + VoltlyMrgn  : Decimal
        + MinPayInAmt  : Decimal
        + ShrtPosLmt  : Decimal
        + Ccy  : String
    }
    ISO20022.Camt062001.CurrencyFactors1 *-- ISO20022.Camt062001.AgreedRate2
    class ISO20022.Camt062001.Entry2Code {
        REQU = 1
        OFFI = 2
        TRIA = 3
    }
    class ISO20022.Camt062001.NameAndAddress8 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + Adr  : ISO20022.Camt062001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt062001.NameAndAddress8 *-- ISO20022.Camt062001.PostalAddress1
    class ISO20022.Camt062001.PartyIdentification44 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + AnyBIC  : String
    }
    class ISO20022.Camt062001.PartyIdentification59 {
        + LglNttyIdr  : String
        + ClrSysId  : ISO20022.Camt062001.ClearingSystemIdentification2Choice
        + Adr  : String
        + AcctNb  : String
        + AnyBIC  : ISO20022.Camt062001.PartyIdentification44
        + PtyNm  : String
    }
    ISO20022.Camt062001.PartyIdentification59 *-- ISO20022.Camt062001.ClearingSystemIdentification2Choice
    ISO20022.Camt062001.PartyIdentification59 *-- ISO20022.Camt062001.PartyIdentification44
    class ISO20022.Camt062001.PartyIdentification73Choice {
        + PtyId  : ISO20022.Camt062001.PartyIdentification59
        + AnyBIC  : ISO20022.Camt062001.PartyIdentification44
        + NmAndAdr  : ISO20022.Camt062001.NameAndAddress8
    }
    ISO20022.Camt062001.PartyIdentification73Choice *-- ISO20022.Camt062001.PartyIdentification59
    ISO20022.Camt062001.PartyIdentification73Choice *-- ISO20022.Camt062001.PartyIdentification44
    ISO20022.Camt062001.PartyIdentification73Choice *-- ISO20022.Camt062001.NameAndAddress8
    class ISO20022.Camt062001.PayInFactors1 {
        + CcyFctrs  : global::System.Collections.Generic.List~ISO20022.Camt062001.CurrencyFactors1~
        + AggtShrtPosLmt  : ISO20022.Camt062001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt062001.PayInFactors1 *-- ISO20022.Camt062001.CurrencyFactors1
    ISO20022.Camt062001.PayInFactors1 *-- ISO20022.Camt062001.ActiveCurrencyAndAmount
    class ISO20022.Camt062001.PayInScheduleItems1 {
        + Ddln  : DateTime
        + Amt  : ISO20022.Camt062001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt062001.PayInScheduleItems1 *-- ISO20022.Camt062001.ActiveCurrencyAndAmount
    class ISO20022.Camt062001.PayInScheduleV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt062001.SupplementaryData1~
        + PayInFctrs  : ISO20022.Camt062001.PayInFactors1
        + PayInSchdlItm  : global::System.Collections.Generic.List~ISO20022.Camt062001.PayInScheduleItems1~
        + PayInSchdlLngBal  : global::System.Collections.Generic.List~ISO20022.Camt062001.BalanceStatus2~
        + RptData  : ISO20022.Camt062001.ReportData4
        + PtyId  : ISO20022.Camt062001.PartyIdentification73Choice
    }
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.SupplementaryData1
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.PayInFactors1
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.PayInScheduleItems1
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.BalanceStatus2
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.ReportData4
    ISO20022.Camt062001.PayInScheduleV03 *-- ISO20022.Camt062001.PartyIdentification73Choice
    class ISO20022.Camt062001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt062001.ReportData4 {
        + SttlmSsnIdr  : String
        + SchdlTp  : String
        + Tp  : String
        + DtAndTmStmp  : DateTime
        + ValDt  : DateTime
        + MsgId  : String
    }
    class ISO20022.Camt062001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt062001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt062001.SupplementaryData1 *-- ISO20022.Camt062001.SupplementaryDataEnvelope1
    class ISO20022.Camt062001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Camt062001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt062001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt062001.AgreedRate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt062001.BalanceStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Camt062001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal))|

---

## Value ISO20022.Camt062001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt062001.CurrencyFactors1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|ISO20022.Camt062001.AgreedRate2||XmlElement()||
|+|VoltlyMrgn|Decimal||XmlElement()||
|+|MinPayInAmt|Decimal||XmlElement()||
|+|ShrtPosLmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rate),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Type ISO20022.Camt062001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PayInSchdl|ISO20022.Camt062001.PayInScheduleV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PayInSchdl))|

---

## Enum ISO20022.Camt062001.Entry2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REQU|Int32||XmlEnum("""REQU""")|1|
||OFFI|Int32||XmlEnum("""OFFI""")|2|
||TRIA|Int32||XmlEnum("""TRIA""")|3|

---

## Value ISO20022.Camt062001.NameAndAddress8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Adr|ISO20022.Camt062001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validElement(Adr))|

---

## Value ISO20022.Camt062001.PartyIdentification44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt062001.PartyIdentification59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglNttyIdr|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt062001.ClearingSystemIdentification2Choice||XmlElement()||
|+|Adr|String||XmlElement()||
|+|AcctNb|String||XmlElement()||
|+|AnyBIC|ISO20022.Camt062001.PartyIdentification44||XmlElement()||
|+|PtyNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysId),validElement(AnyBIC))|

---

## Value ISO20022.Camt062001.PartyIdentification73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyId|ISO20022.Camt062001.PartyIdentification59||XmlElement()||
|+|AnyBIC|ISO20022.Camt062001.PartyIdentification44||XmlElement()||
|+|NmAndAdr|ISO20022.Camt062001.NameAndAddress8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyId),validElement(AnyBIC),validElement(NmAndAdr),validChoice(PtyId,AnyBIC,NmAndAdr))|

---

## Value ISO20022.Camt062001.PayInFactors1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyFctrs|global::System.Collections.Generic.List<ISO20022.Camt062001.CurrencyFactors1>||XmlElement()||
|+|AggtShrtPosLmt|ISO20022.Camt062001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""CcyFctrs""",CcyFctrs),validList("""CcyFctrs""",CcyFctrs),validElement(CcyFctrs),validElement(AggtShrtPosLmt))|

---

## Value ISO20022.Camt062001.PayInScheduleItems1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ddln|DateTime||XmlElement()||
|+|Amt|ISO20022.Camt062001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Aspect ISO20022.Camt062001.PayInScheduleV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt062001.SupplementaryData1>||XmlElement()||
|+|PayInFctrs|ISO20022.Camt062001.PayInFactors1||XmlElement()||
|+|PayInSchdlItm|global::System.Collections.Generic.List<ISO20022.Camt062001.PayInScheduleItems1>||XmlElement()||
|+|PayInSchdlLngBal|global::System.Collections.Generic.List<ISO20022.Camt062001.BalanceStatus2>||XmlElement()||
|+|RptData|ISO20022.Camt062001.ReportData4||XmlElement()||
|+|PtyId|ISO20022.Camt062001.PartyIdentification73Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PayInFctrs),validList("""PayInSchdlItm""",PayInSchdlItm),validElement(PayInSchdlItm),validList("""PayInSchdlLngBal""",PayInSchdlLngBal),validElement(PayInSchdlLngBal),validElement(RptData),validElement(PtyId))|

---

## Value ISO20022.Camt062001.PostalAddress1


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

## Value ISO20022.Camt062001.ReportData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmSsnIdr|String||XmlElement()||
|+|SchdlTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|DtAndTmStmp|DateTime||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""),validPattern("""SchdlTp""",SchdlTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt062001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt062001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt062001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

