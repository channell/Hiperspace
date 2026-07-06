# camt.084.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt084001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt084001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt084001.AccountIdentification4Choice *-- ISO20022.Camt084001.GenericAccountIdentification1
    class ISO20022.Camt084001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt084001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt084001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt084001.AddressType3Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt084001.AddressType3Choice *-- ISO20022.Camt084001.GenericIdentification30
    class ISO20022.Camt084001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt084001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt084001.Amount2Choice *-- ISO20022.Camt084001.ActiveCurrencyAndAmount
    class ISO20022.Camt084001.AmountAndDirection5 {
        + CdtDbt  : String
        + Amt  : ISO20022.Camt084001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt084001.AmountAndDirection5 *-- ISO20022.Camt084001.ActiveCurrencyAndAmount
    class ISO20022.Camt084001.AmountAndQuantityBreakdown1 {
        + CshSubBalTp  : ISO20022.Camt084001.GenericIdentification30
        + LotQty  : ISO20022.Camt084001.FinancialInstrumentQuantity1Choice
        + LotAmt  : ISO20022.Camt084001.AmountAndDirection5
        + LotNb  : ISO20022.Camt084001.GenericIdentification37
    }
    ISO20022.Camt084001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt084001.GenericIdentification30
    ISO20022.Camt084001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt084001.FinancialInstrumentQuantity1Choice
    ISO20022.Camt084001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt084001.AmountAndDirection5
    ISO20022.Camt084001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt084001.GenericIdentification37
    class ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt084001.BranchData5
        + FinInstnId  : ISO20022.Camt084001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt084001.BranchData5
    ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt084001.FinancialInstitutionIdentification23
    class ISO20022.Camt084001.BranchData5 {
        + PstlAdr  : ISO20022.Camt084001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt084001.BranchData5 *-- ISO20022.Camt084001.PostalAddress27
    class ISO20022.Camt084001.CashAccount40 {
        + Prxy  : ISO20022.Camt084001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt084001.CashAccountType2Choice
        + Id  : ISO20022.Camt084001.AccountIdentification4Choice
    }
    ISO20022.Camt084001.CashAccount40 *-- ISO20022.Camt084001.ProxyAccountIdentification1
    ISO20022.Camt084001.CashAccount40 *-- ISO20022.Camt084001.CashAccountType2Choice
    ISO20022.Camt084001.CashAccount40 *-- ISO20022.Camt084001.AccountIdentification4Choice
    class ISO20022.Camt084001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt084001.CashBalanceType3Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt084001.CashBalanceType3Choice *-- ISO20022.Camt084001.GenericIdentification30
    class ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Camt084001.AmountAndQuantityBreakdown1~
        + Tp  : ISO20022.Camt084001.CashBalanceType3Choice
    }
    ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt084001.AmountAndQuantityBreakdown1
    ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt084001.CashBalanceType3Choice
    class ISO20022.Camt084001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt084001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt084001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt084001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt084001.ClearingSystemIdentification2Choice
    class ISO20022.Camt084001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Camt084001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt084001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt084001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt084001.DocumentIdentification51 {
        + MsgRcpt  : ISO20022.Camt084001.PartyIdentification136
        + MsgOrgtr  : ISO20022.Camt084001.PartyIdentification136
        + CpyDplct  : String
        + CreDtTm  : ISO20022.Camt084001.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Camt084001.DocumentIdentification51 *-- ISO20022.Camt084001.PartyIdentification136
    ISO20022.Camt084001.DocumentIdentification51 *-- ISO20022.Camt084001.PartyIdentification136
    ISO20022.Camt084001.DocumentIdentification51 *-- ISO20022.Camt084001.DateAndDateTime2Choice
    class ISO20022.Camt084001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Camt084001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Camt084001.DocumentNumber5Choice *-- ISO20022.Camt084001.GenericIdentification36
    class ISO20022.Camt084001.EventFrequency7Code {
        ONDE = 1
        OVNG = 2
        TWMN = 3
        TOWK = 4
        TOMN = 5
        QUTR = 6
        SEMI = 7
        WEEK = 8
        INDA = 9
        DAIL = 10
        MNTH = 11
        ADHO = 12
        YEAR = 13
    }
    class ISO20022.Camt084001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt084001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt084001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt084001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt084001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt084001.FinancialInstitutionIdentification23 *-- ISO20022.Camt084001.GenericFinancialIdentification1
    ISO20022.Camt084001.FinancialInstitutionIdentification23 *-- ISO20022.Camt084001.PostalAddress27
    ISO20022.Camt084001.FinancialInstitutionIdentification23 *-- ISO20022.Camt084001.ClearingSystemMemberIdentification2
    class ISO20022.Camt084001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Camt084001.Frequency22Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt084001.Frequency22Choice *-- ISO20022.Camt084001.GenericIdentification30
    class ISO20022.Camt084001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt084001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt084001.GenericAccountIdentification1 *-- ISO20022.Camt084001.AccountSchemeName1Choice
    class ISO20022.Camt084001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt084001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt084001.GenericFinancialIdentification1 *-- ISO20022.Camt084001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt084001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt084001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt084001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 {
        + SubBal  : global::System.Collections.Generic.List~ISO20022.Camt084001.IntraBalancePosting5~
        + CshAcctSvcr  : ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8
        + CshAcctOwnr  : ISO20022.Camt084001.SystemPartyIdentification8
        + CshAcct  : ISO20022.Camt084001.CashAccount40
        + RptGnlDtls  : ISO20022.Camt084001.IntraBalanceReport6
        + Pgntn  : ISO20022.Camt084001.Pagination1
        + Id  : ISO20022.Camt084001.DocumentIdentification51
    }
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.IntraBalancePosting5
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.SystemPartyIdentification8
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.CashAccount40
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.IntraBalanceReport6
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.Pagination1
    ISO20022.Camt084001.IntraBalanceMovementPostingReportV02 *-- ISO20022.Camt084001.DocumentIdentification51
    class ISO20022.Camt084001.IntraBalancePosting5 {
        + Mvmnt  : global::System.Collections.Generic.List~ISO20022.Camt084001.IntraBalancePosting6~
        + BalFr  : ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3
    }
    ISO20022.Camt084001.IntraBalancePosting5 *-- ISO20022.Camt084001.IntraBalancePosting6
    ISO20022.Camt084001.IntraBalancePosting5 *-- ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3
    class ISO20022.Camt084001.IntraBalancePosting6 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt084001.SupplementaryData1~
        + InstrPrcgAddtlDtls  : String
        + CreDtTm  : DateTime
        + MsgOrgtr  : ISO20022.Camt084001.SystemPartyIdentification8
        + Prty  : ISO20022.Camt084001.PriorityNumeric4Choice
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Camt084001.Linkages57~
        + CshSubBalId  : ISO20022.Camt084001.GenericIdentification37
        + StsDt  : DateTime
        + FctvSttlmDt  : ISO20022.Camt084001.DateAndDateTime2Choice
        + RmngSttlmAmt  : ISO20022.Camt084001.Amount2Choice
        + PrevslySttldAmt  : ISO20022.Camt084001.Amount2Choice
        + SttldAmt  : ISO20022.Camt084001.Amount2Choice
        + BalTo  : ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3
        + CorpActnEvtId  : String
        + PoolId  : String
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.SupplementaryData1
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.SystemPartyIdentification8
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.PriorityNumeric4Choice
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.Linkages57
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.GenericIdentification37
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.DateAndDateTime2Choice
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.Amount2Choice
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.Amount2Choice
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.Amount2Choice
    ISO20022.Camt084001.IntraBalancePosting6 *-- ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3
    class ISO20022.Camt084001.IntraBalanceReport6 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Camt084001.UpdateType15Choice
        + Frqcy  : ISO20022.Camt084001.Frequency22Choice
        + RptPrd  : ISO20022.Camt084001.Period7Choice
        + RptDtTm  : ISO20022.Camt084001.DateAndDateTime2Choice
        + RptId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Camt084001.Number3Choice
    }
    ISO20022.Camt084001.IntraBalanceReport6 *-- ISO20022.Camt084001.UpdateType15Choice
    ISO20022.Camt084001.IntraBalanceReport6 *-- ISO20022.Camt084001.Frequency22Choice
    ISO20022.Camt084001.IntraBalanceReport6 *-- ISO20022.Camt084001.Period7Choice
    ISO20022.Camt084001.IntraBalanceReport6 *-- ISO20022.Camt084001.DateAndDateTime2Choice
    ISO20022.Camt084001.IntraBalanceReport6 *-- ISO20022.Camt084001.Number3Choice
    class ISO20022.Camt084001.Linkages57 {
        + RefOwnr  : ISO20022.Camt084001.PartyIdentification127Choice
        + Ref  : ISO20022.Camt084001.References34Choice
        + MsgNb  : ISO20022.Camt084001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Camt084001.ProcessingPosition7Choice
    }
    ISO20022.Camt084001.Linkages57 *-- ISO20022.Camt084001.PartyIdentification127Choice
    ISO20022.Camt084001.Linkages57 *-- ISO20022.Camt084001.References34Choice
    ISO20022.Camt084001.Linkages57 *-- ISO20022.Camt084001.DocumentNumber5Choice
    ISO20022.Camt084001.Linkages57 *-- ISO20022.Camt084001.ProcessingPosition7Choice
    class ISO20022.Camt084001.NameAndAddress5 {
        + Adr  : ISO20022.Camt084001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt084001.NameAndAddress5 *-- ISO20022.Camt084001.PostalAddress1
    class ISO20022.Camt084001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Camt084001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Camt084001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Camt084001.NameAndAddress5
        + PrtryId  : ISO20022.Camt084001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt084001.PartyIdentification120Choice *-- ISO20022.Camt084001.NameAndAddress5
    ISO20022.Camt084001.PartyIdentification120Choice *-- ISO20022.Camt084001.GenericIdentification36
    class ISO20022.Camt084001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Camt084001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt084001.PartyIdentification127Choice *-- ISO20022.Camt084001.GenericIdentification36
    class ISO20022.Camt084001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Camt084001.PartyIdentification120Choice
    }
    ISO20022.Camt084001.PartyIdentification136 *-- ISO20022.Camt084001.PartyIdentification120Choice
    class ISO20022.Camt084001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt084001.Period7Choice {
        + FrDtToDt  : ISO20022.Camt084001.Period2
        + FrDtTmToDtTm  : ISO20022.Camt084001.DateTimePeriod1
    }
    ISO20022.Camt084001.Period7Choice *-- ISO20022.Camt084001.Period2
    ISO20022.Camt084001.Period7Choice *-- ISO20022.Camt084001.DateTimePeriod1
    class ISO20022.Camt084001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt084001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt084001.AddressType3Choice
    }
    ISO20022.Camt084001.PostalAddress27 *-- ISO20022.Camt084001.AddressType3Choice
    class ISO20022.Camt084001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Camt084001.PriorityNumeric4Choice *-- ISO20022.Camt084001.GenericIdentification30
    class ISO20022.Camt084001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Camt084001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt084001.ProcessingPosition7Choice *-- ISO20022.Camt084001.GenericIdentification30
    class ISO20022.Camt084001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt084001.ProxyAccountType1Choice
    }
    ISO20022.Camt084001.ProxyAccountIdentification1 *-- ISO20022.Camt084001.ProxyAccountType1Choice
    class ISO20022.Camt084001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt084001.References34Choice {
        + OthrTxId  : String
        + PoolId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Camt084001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Camt084001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt084001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt084001.SupplementaryData1 *-- ISO20022.Camt084001.SupplementaryDataEnvelope1
    class ISO20022.Camt084001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt084001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Camt084001.PartyIdentification136
        + Id  : ISO20022.Camt084001.PartyIdentification136
    }
    ISO20022.Camt084001.SystemPartyIdentification8 *-- ISO20022.Camt084001.PartyIdentification136
    ISO20022.Camt084001.SystemPartyIdentification8 *-- ISO20022.Camt084001.PartyIdentification136
    class ISO20022.Camt084001.UpdateType15Choice {
        + Prtry  : ISO20022.Camt084001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt084001.UpdateType15Choice *-- ISO20022.Camt084001.GenericIdentification30
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

## Value ISO20022.Camt084001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt084001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt084001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt084001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt084001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt084001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt084001.AmountAndDirection5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Camt084001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt084001.AmountAndQuantityBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|LotQty|ISO20022.Camt084001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotAmt|ISO20022.Camt084001.AmountAndDirection5||XmlElement()||
|+|LotNb|ISO20022.Camt084001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(LotQty),validElement(LotAmt),validElement(LotNb))|

---

## Value ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt084001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt084001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt084001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt084001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt084001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt084001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt084001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt084001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt084001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.CashBalanceType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Camt084001.AmountAndQuantityBreakdown1>||XmlElement()||
|+|Tp|ISO20022.Camt084001.CashBalanceType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Value ISO20022.Camt084001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt084001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt084001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Enum ISO20022.Camt084001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt084001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt084001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Camt084001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraBalMvmntPstngRpt|ISO20022.Camt084001.IntraBalanceMovementPostingReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraBalMvmntPstngRpt))|

---

## Value ISO20022.Camt084001.DocumentIdentification51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgRcpt|ISO20022.Camt084001.PartyIdentification136||XmlElement()||
|+|MsgOrgtr|ISO20022.Camt084001.PartyIdentification136||XmlElement()||
|+|CpyDplct|String||XmlElement()||
|+|CreDtTm|ISO20022.Camt084001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgRcpt),validElement(MsgOrgtr),validElement(CreDtTm))|

---

## Value ISO20022.Camt084001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Camt084001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Camt084001.EventFrequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||TWMN|Int32||XmlEnum("""TWMN""")|3|
||TOWK|Int32||XmlEnum("""TOWK""")|4|
||TOMN|Int32||XmlEnum("""TOMN""")|5|
||QUTR|Int32||XmlEnum("""QUTR""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||INDA|Int32||XmlEnum("""INDA""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|
||MNTH|Int32||XmlEnum("""MNTH""")|11|
||ADHO|Int32||XmlEnum("""ADHO""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Value ISO20022.Camt084001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt084001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt084001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt084001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt084001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Camt084001.Frequency22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt084001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt084001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt084001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt084001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt084001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt084001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Camt084001.IntraBalanceMovementPostingReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubBal|global::System.Collections.Generic.List<ISO20022.Camt084001.IntraBalancePosting5>||XmlElement()||
|+|CshAcctSvcr|ISO20022.Camt084001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcctOwnr|ISO20022.Camt084001.SystemPartyIdentification8||XmlElement()||
|+|CshAcct|ISO20022.Camt084001.CashAccount40||XmlElement()||
|+|RptGnlDtls|ISO20022.Camt084001.IntraBalanceReport6||XmlElement()||
|+|Pgntn|ISO20022.Camt084001.Pagination1||XmlElement()||
|+|Id|ISO20022.Camt084001.DocumentIdentification51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SubBal""",SubBal),validElement(SubBal),validElement(CshAcctSvcr),validElement(CshAcctOwnr),validElement(CshAcct),validElement(RptGnlDtls),validElement(Pgntn),validElement(Id))|

---

## Value ISO20022.Camt084001.IntraBalancePosting5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mvmnt|global::System.Collections.Generic.List<ISO20022.Camt084001.IntraBalancePosting6>||XmlElement()||
|+|BalFr|ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Mvmnt""",Mvmnt),validList("""Mvmnt""",Mvmnt),validElement(Mvmnt),validElement(BalFr))|

---

## Value ISO20022.Camt084001.IntraBalancePosting6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt084001.SupplementaryData1>||XmlElement()||
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgOrgtr|ISO20022.Camt084001.SystemPartyIdentification8||XmlElement()||
|+|Prty|ISO20022.Camt084001.PriorityNumeric4Choice||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Camt084001.Linkages57>||XmlElement()||
|+|CshSubBalId|ISO20022.Camt084001.GenericIdentification37||XmlElement()||
|+|StsDt|DateTime||XmlElement()||
|+|FctvSttlmDt|ISO20022.Camt084001.DateAndDateTime2Choice||XmlElement()||
|+|RmngSttlmAmt|ISO20022.Camt084001.Amount2Choice||XmlElement()||
|+|PrevslySttldAmt|ISO20022.Camt084001.Amount2Choice||XmlElement()||
|+|SttldAmt|ISO20022.Camt084001.Amount2Choice||XmlElement()||
|+|BalTo|ISO20022.Camt084001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(MsgOrgtr),validElement(Prty),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(CshSubBalId),validElement(FctvSttlmDt),validElement(RmngSttlmAmt),validElement(PrevslySttldAmt),validElement(SttldAmt),validElement(BalTo))|

---

## Value ISO20022.Camt084001.IntraBalanceReport6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Camt084001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Camt084001.Frequency22Choice||XmlElement()||
|+|RptPrd|ISO20022.Camt084001.Period7Choice||XmlElement()||
|+|RptDtTm|ISO20022.Camt084001.DateAndDateTime2Choice||XmlElement()||
|+|RptId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Camt084001.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(Frqcy),validElement(RptPrd),validElement(RptDtTm),validElement(RptNb))|

---

## Value ISO20022.Camt084001.Linkages57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Camt084001.PartyIdentification127Choice||XmlElement()||
|+|Ref|ISO20022.Camt084001.References34Choice||XmlElement()||
|+|MsgNb|ISO20022.Camt084001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Camt084001.ProcessingPosition7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Value ISO20022.Camt084001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt084001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Camt084001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Camt084001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Camt084001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt084001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt084001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Camt084001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Camt084001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Camt084001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Camt084001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Camt084001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt084001.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Camt084001.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Camt084001.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Camt084001.PostalAddress1


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

## Value ISO20022.Camt084001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt084001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt084001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Enum ISO20022.Camt084001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Camt084001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt084001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt084001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt084001.References34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,PoolId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Enum ISO20022.Camt084001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Camt084001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt084001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt084001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt084001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Camt084001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Camt084001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Camt084001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt084001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

