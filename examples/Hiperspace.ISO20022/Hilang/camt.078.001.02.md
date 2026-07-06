# camt.078.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt078001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt078001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt078001.AccountIdentification4Choice *-- ISO20022.Camt078001.GenericAccountIdentification1
    class ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice {
        + NCTTxt  : String
        + CTTxt  : String
        + EQ  : ISO20022.Camt078001.AccountIdentification4Choice
    }
    ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice *-- ISO20022.Camt078001.AccountIdentification4Choice
    class ISO20022.Camt078001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt078001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt078001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt078001.AddressType3Choice {
        + Prtry  : ISO20022.Camt078001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt078001.AddressType3Choice *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.AmountAndDirection5 {
        + CdtDbt  : String
        + Amt  : ISO20022.Camt078001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt078001.AmountAndDirection5 *-- ISO20022.Camt078001.ActiveCurrencyAndAmount
    class ISO20022.Camt078001.AmountAndQuantityBreakdown1 {
        + CshSubBalTp  : ISO20022.Camt078001.GenericIdentification30
        + LotQty  : ISO20022.Camt078001.FinancialInstrumentQuantity1Choice
        + LotAmt  : ISO20022.Camt078001.AmountAndDirection5
        + LotNb  : ISO20022.Camt078001.GenericIdentification37
    }
    ISO20022.Camt078001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt078001.GenericIdentification30
    ISO20022.Camt078001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt078001.FinancialInstrumentQuantity1Choice
    ISO20022.Camt078001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt078001.AmountAndDirection5
    ISO20022.Camt078001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt078001.GenericIdentification37
    class ISO20022.Camt078001.AmountRangeBoundary1 {
        + Incl  : String
        + BdryAmt  : Decimal
    }
    class ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt078001.BranchData5
        + FinInstnId  : ISO20022.Camt078001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt078001.BranchData5
    ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt078001.FinancialInstitutionIdentification23
    class ISO20022.Camt078001.BranchData5 {
        + PstlAdr  : ISO20022.Camt078001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt078001.BranchData5 *-- ISO20022.Camt078001.PostalAddress27
    class ISO20022.Camt078001.CashBalanceType3Choice {
        + Prtry  : ISO20022.Camt078001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt078001.CashBalanceType3Choice *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Camt078001.AmountAndQuantityBreakdown1~
        + Tp  : ISO20022.Camt078001.CashBalanceType3Choice
    }
    ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt078001.AmountAndQuantityBreakdown1
    ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt078001.CashBalanceType3Choice
    class ISO20022.Camt078001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt078001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt078001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt078001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt078001.ClearingSystemIdentification2Choice
    class ISO20022.Camt078001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Camt078001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt078001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt078001.DateAndDateTimeSearch5Choice {
        + DtTm  : ISO20022.Camt078001.DateTimeSearch2Choice
        + Dt  : ISO20022.Camt078001.DatePeriodSearch1Choice
    }
    ISO20022.Camt078001.DateAndDateTimeSearch5Choice *-- ISO20022.Camt078001.DateTimeSearch2Choice
    ISO20022.Camt078001.DateAndDateTimeSearch5Choice *-- ISO20022.Camt078001.DatePeriodSearch1Choice
    class ISO20022.Camt078001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt078001.DatePeriodSearch1Choice {
        + NEQDt  : DateTime
        + EQDt  : DateTime
        + FrToDt  : ISO20022.Camt078001.DatePeriod2
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    ISO20022.Camt078001.DatePeriodSearch1Choice *-- ISO20022.Camt078001.DatePeriod2
    class ISO20022.Camt078001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt078001.DateTimeSearch2Choice {
        + NEQDtTm  : DateTime
        + EQDtTm  : DateTime
        + FrToDtTm  : ISO20022.Camt078001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Camt078001.DateTimeSearch2Choice *-- ISO20022.Camt078001.DateTimePeriod1
    class ISO20022.Camt078001.DocumentIdentification51 {
        + MsgRcpt  : ISO20022.Camt078001.PartyIdentification136
        + MsgOrgtr  : ISO20022.Camt078001.PartyIdentification136
        + CpyDplct  : String
        + CreDtTm  : ISO20022.Camt078001.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Camt078001.DocumentIdentification51 *-- ISO20022.Camt078001.PartyIdentification136
    ISO20022.Camt078001.DocumentIdentification51 *-- ISO20022.Camt078001.PartyIdentification136
    ISO20022.Camt078001.DocumentIdentification51 *-- ISO20022.Camt078001.DateAndDateTime2Choice
    class ISO20022.Camt078001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt078001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt078001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt078001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt078001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt078001.FinancialInstitutionIdentification23 *-- ISO20022.Camt078001.GenericFinancialIdentification1
    ISO20022.Camt078001.FinancialInstitutionIdentification23 *-- ISO20022.Camt078001.PostalAddress27
    ISO20022.Camt078001.FinancialInstitutionIdentification23 *-- ISO20022.Camt078001.ClearingSystemMemberIdentification2
    class ISO20022.Camt078001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Camt078001.FromToAmountRange1 {
        + ToAmt  : ISO20022.Camt078001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt078001.AmountRangeBoundary1
    }
    ISO20022.Camt078001.FromToAmountRange1 *-- ISO20022.Camt078001.AmountRangeBoundary1
    ISO20022.Camt078001.FromToAmountRange1 *-- ISO20022.Camt078001.AmountRangeBoundary1
    class ISO20022.Camt078001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt078001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt078001.GenericAccountIdentification1 *-- ISO20022.Camt078001.AccountSchemeName1Choice
    class ISO20022.Camt078001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt078001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt078001.GenericFinancialIdentification1 *-- ISO20022.Camt078001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt078001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt078001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt078001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice {
        + NEQAmt  : Decimal
        + EQAmt  : Decimal
        + FrToAmt  : ISO20022.Camt078001.FromToAmountRange1
        + ToAmt  : ISO20022.Camt078001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt078001.AmountRangeBoundary1
    }
    ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt078001.FromToAmountRange1
    ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt078001.AmountRangeBoundary1
    ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt078001.AmountRangeBoundary1
    class ISO20022.Camt078001.IntraBalanceMovementQueryV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt078001.SupplementaryData1~
        + QryDef  : ISO20022.Camt078001.IntraBalanceQueryDefinition11
        + Id  : ISO20022.Camt078001.DocumentIdentification51
    }
    ISO20022.Camt078001.IntraBalanceMovementQueryV02 *-- ISO20022.Camt078001.SupplementaryData1
    ISO20022.Camt078001.IntraBalanceMovementQueryV02 *-- ISO20022.Camt078001.IntraBalanceQueryDefinition11
    ISO20022.Camt078001.IntraBalanceMovementQueryV02 *-- ISO20022.Camt078001.DocumentIdentification51
    class ISO20022.Camt078001.IntraBalanceQueryCriteria11 {
        + CreDtTm  : ISO20022.Camt078001.DateAndDateTimeSearch5Choice
        + MsgOrgtr  : global::System.Collections.Generic.List~ISO20022.Camt078001.SystemPartyIdentification8~
        + Prty  : global::System.Collections.Generic.List~ISO20022.Camt078001.PriorityNumeric4Choice~
        + FctvSttlmDt  : ISO20022.Camt078001.DateAndDateTimeSearch5Choice
        + IntnddSttlmDt  : ISO20022.Camt078001.DateAndDateTimeSearch5Choice
        + SttlmCcy  : global::System.Collections.Generic.List~String~
        + SttldAmt  : ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice
        + SttlmAmt  : ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice
        + CshSubBalId  : global::System.Collections.Generic.List~ISO20022.Camt078001.GenericIdentification37~
        + BalTp  : global::System.Collections.Generic.List~ISO20022.Camt078001.IntraBalanceType3~
        + CshAcctSvcr  : ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8
        + CshAcctOwnr  : global::System.Collections.Generic.List~ISO20022.Camt078001.SystemPartyIdentification8~
        + CshAcct  : global::System.Collections.Generic.List~ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice~
        + Sts  : ISO20022.Camt078001.IntraBalanceQueryStatus3
        + Refs  : global::System.Collections.Generic.List~ISO20022.Camt078001.References36Choice~
    }
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.DateAndDateTimeSearch5Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.SystemPartyIdentification8
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.PriorityNumeric4Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.DateAndDateTimeSearch5Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.DateAndDateTimeSearch5Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.GenericIdentification37
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.IntraBalanceType3
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.SystemPartyIdentification8
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.IntraBalanceQueryStatus3
    ISO20022.Camt078001.IntraBalanceQueryCriteria11 *-- ISO20022.Camt078001.References36Choice
    class ISO20022.Camt078001.IntraBalanceQueryDefinition11 {
        + SchCrit  : ISO20022.Camt078001.IntraBalanceQueryCriteria11
        + QryTp  : String
    }
    ISO20022.Camt078001.IntraBalanceQueryDefinition11 *-- ISO20022.Camt078001.IntraBalanceQueryCriteria11
    class ISO20022.Camt078001.IntraBalanceQueryStatus3 {
        + DtPrd  : ISO20022.Camt078001.DateAndDateTimeSearch5Choice
        + Tp  : ISO20022.Camt078001.IntraBalanceStatusType2
    }
    ISO20022.Camt078001.IntraBalanceQueryStatus3 *-- ISO20022.Camt078001.DateAndDateTimeSearch5Choice
    ISO20022.Camt078001.IntraBalanceQueryStatus3 *-- ISO20022.Camt078001.IntraBalanceStatusType2
    class ISO20022.Camt078001.IntraBalanceStatusType2 {
        + Sttld  : ISO20022.Camt078001.ProprietaryReason4
        + SttlmSts  : global::System.Collections.Generic.List~ISO20022.Camt078001.SettlementStatus26Choice~
        + PrcgSts  : global::System.Collections.Generic.List~ISO20022.Camt078001.ProcessingStatus68Choice~
    }
    ISO20022.Camt078001.IntraBalanceStatusType2 *-- ISO20022.Camt078001.ProprietaryReason4
    ISO20022.Camt078001.IntraBalanceStatusType2 *-- ISO20022.Camt078001.SettlementStatus26Choice
    ISO20022.Camt078001.IntraBalanceStatusType2 *-- ISO20022.Camt078001.ProcessingStatus68Choice
    class ISO20022.Camt078001.IntraBalanceType3 {
        + BalTo  : ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3
        + BalFr  : ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3
    }
    ISO20022.Camt078001.IntraBalanceType3 *-- ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3
    ISO20022.Camt078001.IntraBalanceType3 *-- ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3
    class ISO20022.Camt078001.MovementResponseType1Code {
        STTS = 1
        FULL = 2
    }
    class ISO20022.Camt078001.NameAndAddress5 {
        + Adr  : ISO20022.Camt078001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt078001.NameAndAddress5 *-- ISO20022.Camt078001.PostalAddress1
    class ISO20022.Camt078001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Camt078001.NameAndAddress5
        + PrtryId  : ISO20022.Camt078001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt078001.PartyIdentification120Choice *-- ISO20022.Camt078001.NameAndAddress5
    ISO20022.Camt078001.PartyIdentification120Choice *-- ISO20022.Camt078001.GenericIdentification36
    class ISO20022.Camt078001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Camt078001.PartyIdentification120Choice
    }
    ISO20022.Camt078001.PartyIdentification136 *-- ISO20022.Camt078001.PartyIdentification120Choice
    class ISO20022.Camt078001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt078001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt078001.AddressType3Choice
    }
    ISO20022.Camt078001.PostalAddress27 *-- ISO20022.Camt078001.AddressType3Choice
    class ISO20022.Camt078001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Camt078001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Camt078001.PriorityNumeric4Choice *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.ProcessingStatus68Choice {
        + Prtry  : ISO20022.Camt078001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt078001.ProcessingStatus68Choice *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Camt078001.GenericIdentification30
    }
    ISO20022.Camt078001.ProprietaryReason4 *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.References36Choice {
        + CorpActnEvtId  : String
        + PoolId  : String
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Camt078001.SecuritiesSettlementStatus1Code {
        PENF = 1
        PEND = 2
    }
    class ISO20022.Camt078001.SettlementStatus26Choice {
        + Prtry  : ISO20022.Camt078001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt078001.SettlementStatus26Choice *-- ISO20022.Camt078001.GenericIdentification30
    class ISO20022.Camt078001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt078001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt078001.SupplementaryData1 *-- ISO20022.Camt078001.SupplementaryDataEnvelope1
    class ISO20022.Camt078001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt078001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Camt078001.PartyIdentification136
        + Id  : ISO20022.Camt078001.PartyIdentification136
    }
    ISO20022.Camt078001.SystemPartyIdentification8 *-- ISO20022.Camt078001.PartyIdentification136
    ISO20022.Camt078001.SystemPartyIdentification8 *-- ISO20022.Camt078001.PartyIdentification136
    class ISO20022.Camt078001.TransactionProcessingStatus3Code {
        REPR = 1
        REJT = 2
        PACK = 3
        CAND = 4
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

## Value ISO20022.Camt078001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt078001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NCTTxt|String||XmlElement()||
|+|CTTxt|String||XmlElement()||
|+|EQ|ISO20022.Camt078001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EQ),validChoice(NCTTxt,CTTxt,EQ))|

---

## Value ISO20022.Camt078001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt078001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt078001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.AmountAndDirection5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Camt078001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt078001.AmountAndQuantityBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|LotQty|ISO20022.Camt078001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotAmt|ISO20022.Camt078001.AmountAndDirection5||XmlElement()||
|+|LotNb|ISO20022.Camt078001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(LotQty),validElement(LotAmt),validElement(LotNb))|

---

## Value ISO20022.Camt078001.AmountRangeBoundary1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incl|String||XmlElement()||
|+|BdryAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt078001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt078001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt078001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt078001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt078001.CashBalanceType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Camt078001.AmountAndQuantityBreakdown1>||XmlElement()||
|+|Tp|ISO20022.Camt078001.CashBalanceType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Value ISO20022.Camt078001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt078001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt078001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Enum ISO20022.Camt078001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt078001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt078001.DateAndDateTimeSearch5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|ISO20022.Camt078001.DateTimeSearch2Choice||XmlElement()||
|+|Dt|ISO20022.Camt078001.DatePeriodSearch1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTm),validElement(Dt),validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt078001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.DatePeriodSearch1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDt|DateTime||XmlElement()||
|+|EQDt|DateTime||XmlElement()||
|+|FrToDt|ISO20022.Camt078001.DatePeriod2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt),validChoice(NEQDt,EQDt,FrToDt,ToDt,FrDt))|

---

## Value ISO20022.Camt078001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.DateTimeSearch2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDtTm|DateTime||XmlElement()||
|+|EQDtTm|DateTime||XmlElement()||
|+|FrToDtTm|ISO20022.Camt078001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDtTm),validChoice(NEQDtTm,EQDtTm,FrToDtTm,ToDtTm,FrDtTm))|

---

## Type ISO20022.Camt078001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraBalMvmntQry|ISO20022.Camt078001.IntraBalanceMovementQueryV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraBalMvmntQry))|

---

## Value ISO20022.Camt078001.DocumentIdentification51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgRcpt|ISO20022.Camt078001.PartyIdentification136||XmlElement()||
|+|MsgOrgtr|ISO20022.Camt078001.PartyIdentification136||XmlElement()||
|+|CpyDplct|String||XmlElement()||
|+|CreDtTm|ISO20022.Camt078001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgRcpt),validElement(MsgOrgtr),validElement(CreDtTm))|

---

## Value ISO20022.Camt078001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt078001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt078001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt078001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt078001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Camt078001.FromToAmountRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToAmt|ISO20022.Camt078001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt078001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ToAmt),validElement(FrAmt))|

---

## Value ISO20022.Camt078001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt078001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt078001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt078001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt078001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt078001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQAmt|Decimal||XmlElement()||
|+|EQAmt|Decimal||XmlElement()||
|+|FrToAmt|ISO20022.Camt078001.FromToAmountRange1||XmlElement()||
|+|ToAmt|ISO20022.Camt078001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt078001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToAmt),validElement(ToAmt),validElement(FrAmt),validChoice(NEQAmt,EQAmt,FrToAmt,ToAmt,FrAmt))|

---

## Aspect ISO20022.Camt078001.IntraBalanceMovementQueryV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt078001.SupplementaryData1>||XmlElement()||
|+|QryDef|ISO20022.Camt078001.IntraBalanceQueryDefinition11||XmlElement()||
|+|Id|ISO20022.Camt078001.DocumentIdentification51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(QryDef),validElement(Id))|

---

## Value ISO20022.Camt078001.IntraBalanceQueryCriteria11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|ISO20022.Camt078001.DateAndDateTimeSearch5Choice||XmlElement()||
|+|MsgOrgtr|global::System.Collections.Generic.List<ISO20022.Camt078001.SystemPartyIdentification8>||XmlElement()||
|+|Prty|global::System.Collections.Generic.List<ISO20022.Camt078001.PriorityNumeric4Choice>||XmlElement()||
|+|FctvSttlmDt|ISO20022.Camt078001.DateAndDateTimeSearch5Choice||XmlElement()||
|+|IntnddSttlmDt|ISO20022.Camt078001.DateAndDateTimeSearch5Choice||XmlElement()||
|+|SttlmCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SttldAmt|ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Camt078001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
|+|CshSubBalId|global::System.Collections.Generic.List<ISO20022.Camt078001.GenericIdentification37>||XmlElement()||
|+|BalTp|global::System.Collections.Generic.List<ISO20022.Camt078001.IntraBalanceType3>||XmlElement()||
|+|CshAcctSvcr|ISO20022.Camt078001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcctOwnr|global::System.Collections.Generic.List<ISO20022.Camt078001.SystemPartyIdentification8>||XmlElement()||
|+|CshAcct|global::System.Collections.Generic.List<ISO20022.Camt078001.AccountIdentificationSearchCriteria2Choice>||XmlElement()||
|+|Sts|ISO20022.Camt078001.IntraBalanceQueryStatus3||XmlElement()||
|+|Refs|global::System.Collections.Generic.List<ISO20022.Camt078001.References36Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CreDtTm),validList("""MsgOrgtr""",MsgOrgtr),validElement(MsgOrgtr),validList("""Prty""",Prty),validElement(Prty),validElement(FctvSttlmDt),validElement(IntnddSttlmDt),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validElement(SttldAmt),validElement(SttlmAmt),validList("""CshSubBalId""",CshSubBalId),validElement(CshSubBalId),validList("""BalTp""",BalTp),validElement(BalTp),validElement(CshAcctSvcr),validList("""CshAcctOwnr""",CshAcctOwnr),validElement(CshAcctOwnr),validList("""CshAcct""",CshAcct),validElement(CshAcct),validElement(Sts),validList("""Refs""",Refs),validElement(Refs))|

---

## Value ISO20022.Camt078001.IntraBalanceQueryDefinition11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchCrit|ISO20022.Camt078001.IntraBalanceQueryCriteria11||XmlElement()||
|+|QryTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchCrit))|

---

## Value ISO20022.Camt078001.IntraBalanceQueryStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtPrd|ISO20022.Camt078001.DateAndDateTimeSearch5Choice||XmlElement()||
|+|Tp|ISO20022.Camt078001.IntraBalanceStatusType2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtPrd),validElement(Tp))|

---

## Value ISO20022.Camt078001.IntraBalanceStatusType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sttld|ISO20022.Camt078001.ProprietaryReason4||XmlElement()||
|+|SttlmSts|global::System.Collections.Generic.List<ISO20022.Camt078001.SettlementStatus26Choice>||XmlElement()||
|+|PrcgSts|global::System.Collections.Generic.List<ISO20022.Camt078001.ProcessingStatus68Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sttld),validList("""SttlmSts""",SttlmSts),validElement(SttlmSts),validList("""PrcgSts""",PrcgSts),validElement(PrcgSts))|

---

## Value ISO20022.Camt078001.IntraBalanceType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalTo|ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|BalFr|ISO20022.Camt078001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BalTo),validElement(BalFr))|

---

## Enum ISO20022.Camt078001.MovementResponseType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STTS|Int32||XmlEnum("""STTS""")|1|
||FULL|Int32||XmlEnum("""FULL""")|2|

---

## Value ISO20022.Camt078001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt078001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Camt078001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt078001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt078001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Camt078001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Camt078001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Camt078001.PostalAddress1


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

## Value ISO20022.Camt078001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt078001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt078001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Camt078001.ProcessingStatus68Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Camt078001.References36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnEvtId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(CorpActnEvtId,PoolId,PrcrTxId,MktInfrstrctrTxId,AcctSvcrTxId,AcctOwnrTxId))|

---

## Enum ISO20022.Camt078001.SecuritiesSettlementStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PENF|Int32||XmlEnum("""PENF""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|

---

## Value ISO20022.Camt078001.SettlementStatus26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt078001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt078001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt078001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt078001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt078001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Camt078001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Camt078001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Enum ISO20022.Camt078001.TransactionProcessingStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPR|Int32||XmlEnum("""REPR""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|
||PACK|Int32||XmlEnum("""PACK""")|3|
||CAND|Int32||XmlEnum("""CAND""")|4|

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

