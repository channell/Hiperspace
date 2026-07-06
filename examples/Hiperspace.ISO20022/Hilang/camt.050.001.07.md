# camt.050.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt050001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt050001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt050001.AccountIdentification4Choice *-- ISO20022.Camt050001.GenericAccountIdentification1
    class ISO20022.Camt050001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt050001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt050001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt050001.AddressType3Choice {
        + Prtry  : ISO20022.Camt050001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt050001.AddressType3Choice *-- ISO20022.Camt050001.GenericIdentification30
    class ISO20022.Camt050001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt050001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt050001.Amount2Choice *-- ISO20022.Camt050001.ActiveCurrencyAndAmount
    class ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt050001.BranchData5
        + FinInstnId  : ISO20022.Camt050001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt050001.BranchData5
    ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt050001.FinancialInstitutionIdentification23
    class ISO20022.Camt050001.BranchData5 {
        + PstlAdr  : ISO20022.Camt050001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt050001.BranchData5 *-- ISO20022.Camt050001.PostalAddress27
    class ISO20022.Camt050001.CashAccount40 {
        + Prxy  : ISO20022.Camt050001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt050001.CashAccountType2Choice
        + Id  : ISO20022.Camt050001.AccountIdentification4Choice
    }
    ISO20022.Camt050001.CashAccount40 *-- ISO20022.Camt050001.ProxyAccountIdentification1
    ISO20022.Camt050001.CashAccount40 *-- ISO20022.Camt050001.CashAccountType2Choice
    ISO20022.Camt050001.CashAccount40 *-- ISO20022.Camt050001.AccountIdentification4Choice
    class ISO20022.Camt050001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt050001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt050001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt050001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt050001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt050001.ClearingSystemIdentification2Choice
    class ISO20022.Camt050001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt050001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt050001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt050001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt050001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt050001.FinancialInstitutionIdentification23 *-- ISO20022.Camt050001.GenericFinancialIdentification1
    ISO20022.Camt050001.FinancialInstitutionIdentification23 *-- ISO20022.Camt050001.PostalAddress27
    ISO20022.Camt050001.FinancialInstitutionIdentification23 *-- ISO20022.Camt050001.ClearingSystemMemberIdentification2
    class ISO20022.Camt050001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt050001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt050001.GenericAccountIdentification1 *-- ISO20022.Camt050001.AccountSchemeName1Choice
    class ISO20022.Camt050001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt050001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt050001.GenericFinancialIdentification1 *-- ISO20022.Camt050001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt050001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt050001.LiquidityCreditTransfer4 {
        + SttlmDt  : DateTime
        + DbtrAcct  : ISO20022.Camt050001.CashAccount40
        + Dbtr  : ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8
        + TrfdAmt  : ISO20022.Camt050001.Amount2Choice
        + CdtrAcct  : ISO20022.Camt050001.CashAccount40
        + Cdtr  : ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8
        + LqdtyTrfId  : ISO20022.Camt050001.PaymentIdentification8
    }
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.CashAccount40
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.Amount2Choice
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.CashAccount40
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt050001.LiquidityCreditTransfer4 *-- ISO20022.Camt050001.PaymentIdentification8
    class ISO20022.Camt050001.LiquidityCreditTransferV07 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt050001.SupplementaryData1~
        + LqdtyCdtTrf  : ISO20022.Camt050001.LiquidityCreditTransfer4
        + MsgHdr  : ISO20022.Camt050001.MessageHeader1
    }
    ISO20022.Camt050001.LiquidityCreditTransferV07 *-- ISO20022.Camt050001.SupplementaryData1
    ISO20022.Camt050001.LiquidityCreditTransferV07 *-- ISO20022.Camt050001.LiquidityCreditTransfer4
    ISO20022.Camt050001.LiquidityCreditTransferV07 *-- ISO20022.Camt050001.MessageHeader1
    class ISO20022.Camt050001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Camt050001.PaymentIdentification8 {
        + UETR  : String
        + TxId  : String
        + EndToEndId  : String
        + InstrId  : String
    }
    class ISO20022.Camt050001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt050001.AddressType3Choice
    }
    ISO20022.Camt050001.PostalAddress27 *-- ISO20022.Camt050001.AddressType3Choice
    class ISO20022.Camt050001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt050001.ProxyAccountType1Choice
    }
    ISO20022.Camt050001.ProxyAccountIdentification1 *-- ISO20022.Camt050001.ProxyAccountType1Choice
    class ISO20022.Camt050001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt050001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt050001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt050001.SupplementaryData1 *-- ISO20022.Camt050001.SupplementaryDataEnvelope1
    class ISO20022.Camt050001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Camt050001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt050001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt050001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt050001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt050001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt050001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt050001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt050001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt050001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt050001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt050001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt050001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt050001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt050001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt050001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt050001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt050001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Type ISO20022.Camt050001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LqdtyCdtTrf|ISO20022.Camt050001.LiquidityCreditTransferV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LqdtyCdtTrf))|

---

## Value ISO20022.Camt050001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt050001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt050001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt050001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt050001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt050001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt050001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt050001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt050001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt050001.LiquidityCreditTransfer4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmDt|DateTime||XmlElement()||
|+|DbtrAcct|ISO20022.Camt050001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|TrfdAmt|ISO20022.Camt050001.Amount2Choice||XmlElement()||
|+|CdtrAcct|ISO20022.Camt050001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt050001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|LqdtyTrfId|ISO20022.Camt050001.PaymentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DbtrAcct),validElement(Dbtr),validElement(TrfdAmt),validElement(CdtrAcct),validElement(Cdtr),validElement(LqdtyTrfId))|

---

## Aspect ISO20022.Camt050001.LiquidityCreditTransferV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt050001.SupplementaryData1>||XmlElement()||
|+|LqdtyCdtTrf|ISO20022.Camt050001.LiquidityCreditTransfer4||XmlElement()||
|+|MsgHdr|ISO20022.Camt050001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LqdtyCdtTrf),validElement(MsgHdr))|

---

## Value ISO20022.Camt050001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt050001.PaymentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt050001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt050001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt050001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt050001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt050001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt050001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt050001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt050001.SupplementaryDataEnvelope1


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

