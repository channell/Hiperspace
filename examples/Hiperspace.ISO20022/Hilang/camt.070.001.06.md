# camt.070.001.06
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt070001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt070001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt070001.AccountIdentification4Choice *-- ISO20022.Camt070001.GenericAccountIdentification1
    class ISO20022.Camt070001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt070001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt070001.AddressType3Choice {
        + Prtry  : ISO20022.Camt070001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt070001.AddressType3Choice *-- ISO20022.Camt070001.GenericIdentification30
    class ISO20022.Camt070001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt070001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt070001.Amount2Choice *-- ISO20022.Camt070001.ActiveCurrencyAndAmount
    class ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt070001.BranchData5
        + FinInstnId  : ISO20022.Camt070001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt070001.BranchData5
    ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt070001.FinancialInstitutionIdentification23
    class ISO20022.Camt070001.BranchData5 {
        + PstlAdr  : ISO20022.Camt070001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt070001.BranchData5 *-- ISO20022.Camt070001.PostalAddress27
    class ISO20022.Camt070001.CashAccount40 {
        + Prxy  : ISO20022.Camt070001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt070001.CashAccountType2Choice
        + Id  : ISO20022.Camt070001.AccountIdentification4Choice
    }
    ISO20022.Camt070001.CashAccount40 *-- ISO20022.Camt070001.ProxyAccountIdentification1
    ISO20022.Camt070001.CashAccount40 *-- ISO20022.Camt070001.CashAccountType2Choice
    ISO20022.Camt070001.CashAccount40 *-- ISO20022.Camt070001.AccountIdentification4Choice
    class ISO20022.Camt070001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt070001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt070001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt070001.ClearingSystemIdentification2Choice
    class ISO20022.Camt070001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt070001.DatePeriod3 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt070001.ErrorHandling3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.ErrorHandling5 {
        + Desc  : String
        + Err  : ISO20022.Camt070001.ErrorHandling3Choice
    }
    ISO20022.Camt070001.ErrorHandling5 *-- ISO20022.Camt070001.ErrorHandling3Choice
    class ISO20022.Camt070001.EventType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.ExecutionType1Choice {
        + Evt  : ISO20022.Camt070001.EventType1Choice
        + Tm  : DateTime
    }
    ISO20022.Camt070001.ExecutionType1Choice *-- ISO20022.Camt070001.EventType1Choice
    class ISO20022.Camt070001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt070001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt070001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt070001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt070001.FinancialInstitutionIdentification23 *-- ISO20022.Camt070001.GenericFinancialIdentification1
    ISO20022.Camt070001.FinancialInstitutionIdentification23 *-- ISO20022.Camt070001.PostalAddress27
    ISO20022.Camt070001.FinancialInstitutionIdentification23 *-- ISO20022.Camt070001.ClearingSystemMemberIdentification2
    class ISO20022.Camt070001.Frequency2Code {
        OVNG = 1
        INDA = 2
        ADHO = 3
        DAIL = 4
        WEEK = 5
        MIAN = 6
        QURT = 7
        MNTH = 8
        YEAR = 9
    }
    class ISO20022.Camt070001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt070001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt070001.GenericAccountIdentification1 *-- ISO20022.Camt070001.AccountSchemeName1Choice
    class ISO20022.Camt070001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt070001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt070001.GenericFinancialIdentification1 *-- ISO20022.Camt070001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt070001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt070001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt070001.MessageHeader6 {
        + ReqTp  : ISO20022.Camt070001.RequestType3Choice
        + QryNm  : String
        + OrgnlBizQry  : ISO20022.Camt070001.OriginalBusinessQuery1
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt070001.MessageHeader6 *-- ISO20022.Camt070001.RequestType3Choice
    ISO20022.Camt070001.MessageHeader6 *-- ISO20022.Camt070001.OriginalBusinessQuery1
    class ISO20022.Camt070001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Camt070001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt070001.AddressType3Choice
    }
    ISO20022.Camt070001.PostalAddress27 *-- ISO20022.Camt070001.AddressType3Choice
    class ISO20022.Camt070001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt070001.ProxyAccountType1Choice
    }
    ISO20022.Camt070001.ProxyAccountIdentification1 *-- ISO20022.Camt070001.ProxyAccountType1Choice
    class ISO20022.Camt070001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt070001.RequestType3Choice {
        + Prtry  : ISO20022.Camt070001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Camt070001.RequestType3Choice *-- ISO20022.Camt070001.GenericIdentification1
    class ISO20022.Camt070001.ReturnStandingOrderV06 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt070001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt070001.StandingOrderOrError9Choice
        + MsgHdr  : ISO20022.Camt070001.MessageHeader6
    }
    ISO20022.Camt070001.ReturnStandingOrderV06 *-- ISO20022.Camt070001.SupplementaryData1
    ISO20022.Camt070001.ReturnStandingOrderV06 *-- ISO20022.Camt070001.StandingOrderOrError9Choice
    ISO20022.Camt070001.ReturnStandingOrderV06 *-- ISO20022.Camt070001.MessageHeader6
    class ISO20022.Camt070001.StandingOrder11 {
        + ZeroSweepInd  : String
        + TtlsPerStgOrdr  : ISO20022.Camt070001.StandingOrderTotalAmount1
        + DbtrAcct  : ISO20022.Camt070001.CashAccount40
        + Dbtr  : ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
        + CdtrAcct  : ISO20022.Camt070001.CashAccount40
        + Cdtr  : ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
        + ExctnTp  : ISO20022.Camt070001.ExecutionType1Choice
        + LkSetOrdrSeq  : Decimal
        + LkSetOrdrId  : String
        + LkSetId  : String
        + RspnsblPty  : ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
        + SysMmb  : ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
        + VldtyPrd  : ISO20022.Camt070001.DatePeriod3
        + Frqcy  : String
        + Ref  : String
        + AssoctdPoolAcct  : ISO20022.Camt070001.AccountIdentification4Choice
        + Tp  : ISO20022.Camt070001.StandingOrderType1Choice
        + Ccy  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt070001.Amount2Choice
    }
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.StandingOrderTotalAmount1
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.CashAccount40
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.CashAccount40
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.ExecutionType1Choice
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.DatePeriod3
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.AccountIdentification4Choice
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.StandingOrderType1Choice
    ISO20022.Camt070001.StandingOrder11 *-- ISO20022.Camt070001.Amount2Choice
    class ISO20022.Camt070001.StandingOrderIdentification8 {
        + AcctOwnr  : ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
        + Acct  : ISO20022.Camt070001.CashAccount40
        + Id  : String
    }
    ISO20022.Camt070001.StandingOrderIdentification8 *-- ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt070001.StandingOrderIdentification8 *-- ISO20022.Camt070001.CashAccount40
    class ISO20022.Camt070001.StandingOrderOrError10Choice {
        + BizErr  : global::System.Collections.Generic.List~ISO20022.Camt070001.ErrorHandling5~
        + StgOrdr  : ISO20022.Camt070001.StandingOrder11
    }
    ISO20022.Camt070001.StandingOrderOrError10Choice *-- ISO20022.Camt070001.ErrorHandling5
    ISO20022.Camt070001.StandingOrderOrError10Choice *-- ISO20022.Camt070001.StandingOrder11
    class ISO20022.Camt070001.StandingOrderOrError9Choice {
        + OprlErr  : global::System.Collections.Generic.List~ISO20022.Camt070001.ErrorHandling5~
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Camt070001.StandingOrderReport3~
    }
    ISO20022.Camt070001.StandingOrderOrError9Choice *-- ISO20022.Camt070001.ErrorHandling5
    ISO20022.Camt070001.StandingOrderOrError9Choice *-- ISO20022.Camt070001.StandingOrderReport3
    class ISO20022.Camt070001.StandingOrderQueryType1Code {
        SWLS = 1
        SLSL = 2
        TAPS = 3
        SDTL = 4
        SLST = 5
    }
    class ISO20022.Camt070001.StandingOrderReport3 {
        + StgOrdrOrErr  : ISO20022.Camt070001.StandingOrderOrError10Choice
        + StgOrdrId  : ISO20022.Camt070001.StandingOrderIdentification8
    }
    ISO20022.Camt070001.StandingOrderReport3 *-- ISO20022.Camt070001.StandingOrderOrError10Choice
    ISO20022.Camt070001.StandingOrderReport3 *-- ISO20022.Camt070001.StandingOrderIdentification8
    class ISO20022.Camt070001.StandingOrderTotalAmount1 {
        + PdgStgOrdr  : ISO20022.Camt070001.TotalAmountAndCurrency1
        + SetStgOrdr  : ISO20022.Camt070001.TotalAmountAndCurrency1
        + PdgPrdfndOrdr  : ISO20022.Camt070001.TotalAmountAndCurrency1
        + SetPrdfndOrdr  : ISO20022.Camt070001.TotalAmountAndCurrency1
    }
    ISO20022.Camt070001.StandingOrderTotalAmount1 *-- ISO20022.Camt070001.TotalAmountAndCurrency1
    ISO20022.Camt070001.StandingOrderTotalAmount1 *-- ISO20022.Camt070001.TotalAmountAndCurrency1
    ISO20022.Camt070001.StandingOrderTotalAmount1 *-- ISO20022.Camt070001.TotalAmountAndCurrency1
    ISO20022.Camt070001.StandingOrderTotalAmount1 *-- ISO20022.Camt070001.TotalAmountAndCurrency1
    class ISO20022.Camt070001.StandingOrderType1Choice {
        + Prtry  : ISO20022.Camt070001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Camt070001.StandingOrderType1Choice *-- ISO20022.Camt070001.GenericIdentification1
    class ISO20022.Camt070001.StandingOrderType1Code {
        PSTO = 1
        USTO = 2
    }
    class ISO20022.Camt070001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt070001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt070001.SupplementaryData1 *-- ISO20022.Camt070001.SupplementaryDataEnvelope1
    class ISO20022.Camt070001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt070001.TotalAmountAndCurrency1 {
        + Ccy  : String
        + CdtDbtInd  : String
        + TtlAmt  : Decimal
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

## Value ISO20022.Camt070001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt070001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt070001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt070001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt070001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt070001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt070001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt070001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt070001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt070001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt070001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt070001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt070001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt070001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt070001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt070001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt070001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt070001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt070001.DatePeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Camt070001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrStgOrdr|ISO20022.Camt070001.ReturnStandingOrderV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrStgOrdr))|

---

## Value ISO20022.Camt070001.ErrorHandling3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.ErrorHandling5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Err|ISO20022.Camt070001.ErrorHandling3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Err))|

---

## Value ISO20022.Camt070001.EventType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.ExecutionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Evt|ISO20022.Camt070001.EventType1Choice||XmlElement()||
|+|Tm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Evt),validChoice(Evt,Tm))|

---

## Value ISO20022.Camt070001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt070001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt070001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt070001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Enum ISO20022.Camt070001.Frequency2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OVNG|Int32||XmlEnum("""OVNG""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||ADHO|Int32||XmlEnum("""ADHO""")|3|
||DAIL|Int32||XmlEnum("""DAIL""")|4|
||WEEK|Int32||XmlEnum("""WEEK""")|5|
||MIAN|Int32||XmlEnum("""MIAN""")|6|
||QURT|Int32||XmlEnum("""QURT""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Camt070001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt070001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt070001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt070001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt070001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt070001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt070001.MessageHeader6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Camt070001.RequestType3Choice||XmlElement()||
|+|QryNm|String||XmlElement()||
|+|OrgnlBizQry|ISO20022.Camt070001.OriginalBusinessQuery1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp),validElement(OrgnlBizQry))|

---

## Value ISO20022.Camt070001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt070001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt070001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt070001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt070001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt070001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt070001.RequestType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt070001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Aspect ISO20022.Camt070001.ReturnStandingOrderV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt070001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt070001.StandingOrderOrError9Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt070001.MessageHeader6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

---

## Value ISO20022.Camt070001.StandingOrder11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ZeroSweepInd|String||XmlElement()||
|+|TtlsPerStgOrdr|ISO20022.Camt070001.StandingOrderTotalAmount1||XmlElement()||
|+|DbtrAcct|ISO20022.Camt070001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CdtrAcct|ISO20022.Camt070001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|ExctnTp|ISO20022.Camt070001.ExecutionType1Choice||XmlElement()||
|+|LkSetOrdrSeq|Decimal||XmlElement()||
|+|LkSetOrdrId|String||XmlElement()||
|+|LkSetId|String||XmlElement()||
|+|RspnsblPty|ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|SysMmb|ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|VldtyPrd|ISO20022.Camt070001.DatePeriod3||XmlElement()||
|+|Frqcy|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|AssoctdPoolAcct|ISO20022.Camt070001.AccountIdentification4Choice||XmlElement()||
|+|Tp|ISO20022.Camt070001.StandingOrderType1Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt070001.Amount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlsPerStgOrdr),validElement(DbtrAcct),validElement(Dbtr),validElement(CdtrAcct),validElement(Cdtr),validElement(ExctnTp),validElement(RspnsblPty),validElement(SysMmb),validElement(VldtyPrd),validElement(AssoctdPoolAcct),validElement(Tp),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Camt070001.StandingOrderIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnr|ISO20022.Camt070001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Acct|ISO20022.Camt070001.CashAccount40||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOwnr),validElement(Acct))|

---

## Value ISO20022.Camt070001.StandingOrderOrError10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BizErr|global::System.Collections.Generic.List<ISO20022.Camt070001.ErrorHandling5>||XmlElement()||
|+|StgOrdr|ISO20022.Camt070001.StandingOrder11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BizErr""",BizErr),validList("""BizErr""",BizErr),validElement(BizErr),validElement(StgOrdr),validChoice(BizErr,StgOrdr))|

---

## Value ISO20022.Camt070001.StandingOrderOrError9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprlErr|global::System.Collections.Generic.List<ISO20022.Camt070001.ErrorHandling5>||XmlElement()||
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Camt070001.StandingOrderReport3>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OprlErr""",OprlErr),validList("""OprlErr""",OprlErr),validElement(OprlErr),validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validChoice(OprlErr,Rpt))|

---

## Enum ISO20022.Camt070001.StandingOrderQueryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SWLS|Int32||XmlEnum("""SWLS""")|1|
||SLSL|Int32||XmlEnum("""SLSL""")|2|
||TAPS|Int32||XmlEnum("""TAPS""")|3|
||SDTL|Int32||XmlEnum("""SDTL""")|4|
||SLST|Int32||XmlEnum("""SLST""")|5|

---

## Value ISO20022.Camt070001.StandingOrderReport3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgOrdrOrErr|ISO20022.Camt070001.StandingOrderOrError10Choice||XmlElement()||
|+|StgOrdrId|ISO20022.Camt070001.StandingOrderIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StgOrdrOrErr),validElement(StgOrdrId))|

---

## Value ISO20022.Camt070001.StandingOrderTotalAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgStgOrdr|ISO20022.Camt070001.TotalAmountAndCurrency1||XmlElement()||
|+|SetStgOrdr|ISO20022.Camt070001.TotalAmountAndCurrency1||XmlElement()||
|+|PdgPrdfndOrdr|ISO20022.Camt070001.TotalAmountAndCurrency1||XmlElement()||
|+|SetPrdfndOrdr|ISO20022.Camt070001.TotalAmountAndCurrency1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdgStgOrdr),validElement(SetStgOrdr),validElement(PdgPrdfndOrdr),validElement(SetPrdfndOrdr))|

---

## Value ISO20022.Camt070001.StandingOrderType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt070001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt070001.StandingOrderType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTO|Int32||XmlEnum("""PSTO""")|1|
||USTO|Int32||XmlEnum("""USTO""")|2|

---

## Value ISO20022.Camt070001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt070001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt070001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt070001.TotalAmountAndCurrency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

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

