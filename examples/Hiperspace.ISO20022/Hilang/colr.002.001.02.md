# colr.002.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr002001.AccountIdentification4Choice {
        + Othr  : ISO20022.Colr002001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Colr002001.AccountIdentification4Choice *-- ISO20022.Colr002001.GenericAccountIdentification1
    class ISO20022.Colr002001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr002001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Colr002001.AddressType3Choice {
        + Prtry  : ISO20022.Colr002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr002001.AddressType3Choice *-- ISO20022.Colr002001.GenericIdentification30
    class ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9 {
        + PricFxgDt  : DateTime
        + FinInstrmQty  : ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
        + PricVal  : ISO20022.Colr002001.PriceRateOrAmount3Choice
        + AmtPricTp  : ISO20022.Colr002001.YieldedOrValueType1Choice
    }
    ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9 *-- ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
    ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9 *-- ISO20022.Colr002001.PriceRateOrAmount3Choice
    ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9 *-- ISO20022.Colr002001.YieldedOrValueType1Choice
    class ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Colr002001.BranchData5
        + FinInstnId  : ISO20022.Colr002001.FinancialInstitutionIdentification23
    }
    ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Colr002001.BranchData5
    ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Colr002001.FinancialInstitutionIdentification23
    class ISO20022.Colr002001.BranchData5 {
        + PstlAdr  : ISO20022.Colr002001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Colr002001.BranchData5 *-- ISO20022.Colr002001.PostalAddress27
    class ISO20022.Colr002001.CashAccount40 {
        + Prxy  : ISO20022.Colr002001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Colr002001.CashAccountType2Choice
        + Id  : ISO20022.Colr002001.AccountIdentification4Choice
    }
    ISO20022.Colr002001.CashAccount40 *-- ISO20022.Colr002001.ProxyAccountIdentification1
    ISO20022.Colr002001.CashAccount40 *-- ISO20022.Colr002001.CashAccountType2Choice
    ISO20022.Colr002001.CashAccount40 *-- ISO20022.Colr002001.AccountIdentification4Choice
    class ISO20022.Colr002001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Colr002001.ClearingSystemIdentification2Choice
    }
    ISO20022.Colr002001.ClearingSystemMemberIdentification2 *-- ISO20022.Colr002001.ClearingSystemIdentification2Choice
    class ISO20022.Colr002001.CollateralValuePosition3 {
        + Scties  : global::System.Collections.Generic.List~ISO20022.Colr002001.SecurityCharacteristics3~
        + SctiesAcct  : ISO20022.Colr002001.SecuritiesAccount19
        + TtlCollValtn  : ISO20022.Colr002001.ActiveCurrencyAndAmount
        + DataAccsTm  : DateTime
    }
    ISO20022.Colr002001.CollateralValuePosition3 *-- ISO20022.Colr002001.SecurityCharacteristics3
    ISO20022.Colr002001.CollateralValuePosition3 *-- ISO20022.Colr002001.SecuritiesAccount19
    ISO20022.Colr002001.CollateralValuePosition3 *-- ISO20022.Colr002001.ActiveCurrencyAndAmount
    class ISO20022.Colr002001.CollateralValueReport4 {
        + CollValRpt  : global::System.Collections.Generic.List~ISO20022.Colr002001.CollateralValueReportOrError6Choice~
        + SctiesAcctSvcr  : ISO20022.Colr002001.PartyIdentification136
        + SctiesAcctOwnr  : ISO20022.Colr002001.SystemPartyIdentification8
        + CshAcctSvcr  : ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8
        + CshAcctOwnr  : ISO20022.Colr002001.SystemPartyIdentification11
        + CshAcct  : ISO20022.Colr002001.CashAccount40
    }
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.CollateralValueReportOrError6Choice
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.PartyIdentification136
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.SystemPartyIdentification8
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.SystemPartyIdentification11
    ISO20022.Colr002001.CollateralValueReport4 *-- ISO20022.Colr002001.CashAccount40
    class ISO20022.Colr002001.CollateralValueReportOrError6Choice {
        + CollVal  : ISO20022.Colr002001.CollateralValuePosition3
        + BizErr  : ISO20022.Colr002001.ErrorHandling5
    }
    ISO20022.Colr002001.CollateralValueReportOrError6Choice *-- ISO20022.Colr002001.CollateralValuePosition3
    ISO20022.Colr002001.CollateralValueReportOrError6Choice *-- ISO20022.Colr002001.ErrorHandling5
    class ISO20022.Colr002001.CollateralValueReportOrError7Choice {
        + OprlErr  : global::System.Collections.Generic.List~ISO20022.Colr002001.ErrorHandling5~
        + BizRpt  : global::System.Collections.Generic.List~ISO20022.Colr002001.CollateralValueReport4~
    }
    ISO20022.Colr002001.CollateralValueReportOrError7Choice *-- ISO20022.Colr002001.ErrorHandling5
    ISO20022.Colr002001.CollateralValueReportOrError7Choice *-- ISO20022.Colr002001.CollateralValueReport4
    class ISO20022.Colr002001.CollateralValueReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr002001.SupplementaryData1~
        + RptOrErr  : ISO20022.Colr002001.CollateralValueReportOrError7Choice
        + MsgHdr  : ISO20022.Colr002001.MessageHeader3
    }
    ISO20022.Colr002001.CollateralValueReportV02 *-- ISO20022.Colr002001.SupplementaryData1
    ISO20022.Colr002001.CollateralValueReportV02 *-- ISO20022.Colr002001.CollateralValueReportOrError7Choice
    ISO20022.Colr002001.CollateralValueReportV02 *-- ISO20022.Colr002001.MessageHeader3
    class ISO20022.Colr002001.ErrorHandling3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.ErrorHandling5 {
        + Desc  : String
        + Err  : ISO20022.Colr002001.ErrorHandling3Choice
    }
    ISO20022.Colr002001.ErrorHandling5 *-- ISO20022.Colr002001.ErrorHandling3Choice
    class ISO20022.Colr002001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Colr002001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Colr002001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Colr002001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Colr002001.FinancialInstitutionIdentification23 *-- ISO20022.Colr002001.GenericFinancialIdentification1
    ISO20022.Colr002001.FinancialInstitutionIdentification23 *-- ISO20022.Colr002001.PostalAddress27
    ISO20022.Colr002001.FinancialInstitutionIdentification23 *-- ISO20022.Colr002001.ClearingSystemMemberIdentification2
    class ISO20022.Colr002001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr002001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Colr002001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Colr002001.GenericAccountIdentification1 *-- ISO20022.Colr002001.AccountSchemeName1Choice
    class ISO20022.Colr002001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Colr002001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Colr002001.GenericFinancialIdentification1 *-- ISO20022.Colr002001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Colr002001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Colr002001.GenericIdentification15 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr002001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr002001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr002001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.MessageHeader3 {
        + QryNm  : String
        + OrgnlBizQry  : ISO20022.Colr002001.OriginalBusinessQuery1
        + ReqTp  : ISO20022.Colr002001.RequestType2Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Colr002001.MessageHeader3 *-- ISO20022.Colr002001.OriginalBusinessQuery1
    ISO20022.Colr002001.MessageHeader3 *-- ISO20022.Colr002001.RequestType2Choice
    class ISO20022.Colr002001.NameAndAddress5 {
        + Adr  : ISO20022.Colr002001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Colr002001.NameAndAddress5 *-- ISO20022.Colr002001.PostalAddress1
    class ISO20022.Colr002001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Colr002001.OtherIdentification1 {
        + Tp  : ISO20022.Colr002001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr002001.OtherIdentification1 *-- ISO20022.Colr002001.IdentificationSource3Choice
    class ISO20022.Colr002001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Colr002001.NameAndAddress5
        + PrtryId  : ISO20022.Colr002001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr002001.PartyIdentification120Choice *-- ISO20022.Colr002001.NameAndAddress5
    ISO20022.Colr002001.PartyIdentification120Choice *-- ISO20022.Colr002001.GenericIdentification36
    class ISO20022.Colr002001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Colr002001.PartyIdentification120Choice
    }
    ISO20022.Colr002001.PartyIdentification136 *-- ISO20022.Colr002001.PartyIdentification120Choice
    class ISO20022.Colr002001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr002001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Colr002001.AddressType3Choice
    }
    ISO20022.Colr002001.PostalAddress27 *-- ISO20022.Colr002001.AddressType3Choice
    class ISO20022.Colr002001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Colr002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Colr002001.PriceRateOrAmount3Choice *-- ISO20022.Colr002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Colr002001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Colr002001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Colr002001.ProxyAccountType1Choice
    }
    ISO20022.Colr002001.ProxyAccountIdentification1 *-- ISO20022.Colr002001.ProxyAccountType1Choice
    class ISO20022.Colr002001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr002001.QuantityAndAvailability1 {
        + AvlbtyInd  : String
        + Qty  : ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Colr002001.QuantityAndAvailability1 *-- ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
    class ISO20022.Colr002001.RequestType1Code {
        RT05 = 1
        RT04 = 2
        RT03 = 3
        RT02 = 4
        RT01 = 5
    }
    class ISO20022.Colr002001.RequestType2Choice {
        + Prtry  : ISO20022.Colr002001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Colr002001.RequestType2Choice *-- ISO20022.Colr002001.GenericIdentification1
    class ISO20022.Colr002001.RequestType2Code {
        RT15 = 1
        RT14 = 2
        RT13 = 3
        RT12 = 4
        RT11 = 5
    }
    class ISO20022.Colr002001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr002001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr002001.SecuritiesAccount19 *-- ISO20022.Colr002001.GenericIdentification30
    class ISO20022.Colr002001.SecuritiesPosition1 {
        + Qty  : ISO20022.Colr002001.SubBalanceQuantity2Choice
        + Tp  : String
    }
    ISO20022.Colr002001.SecuritiesPosition1 *-- ISO20022.Colr002001.SubBalanceQuantity2Choice
    class ISO20022.Colr002001.SecurityCharacteristics3 {
        + CollVal  : ISO20022.Colr002001.ActiveCurrencyAndAmount
        + ValtnPric  : ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9
        + Pos  : global::System.Collections.Generic.List~ISO20022.Colr002001.SecuritiesPosition1~
        + Id  : global::System.Collections.Generic.List~ISO20022.Colr002001.SecurityIdentification19~
    }
    ISO20022.Colr002001.SecurityCharacteristics3 *-- ISO20022.Colr002001.ActiveCurrencyAndAmount
    ISO20022.Colr002001.SecurityCharacteristics3 *-- ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9
    ISO20022.Colr002001.SecurityCharacteristics3 *-- ISO20022.Colr002001.SecuritiesPosition1
    ISO20022.Colr002001.SecurityCharacteristics3 *-- ISO20022.Colr002001.SecurityIdentification19
    class ISO20022.Colr002001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr002001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr002001.SecurityIdentification19 *-- ISO20022.Colr002001.OtherIdentification1
    class ISO20022.Colr002001.SubBalanceQuantity2Choice {
        + QtyAndAvlbty  : ISO20022.Colr002001.QuantityAndAvailability1
        + Prtry  : ISO20022.Colr002001.GenericIdentification15
        + Qty  : ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Colr002001.SubBalanceQuantity2Choice *-- ISO20022.Colr002001.QuantityAndAvailability1
    ISO20022.Colr002001.SubBalanceQuantity2Choice *-- ISO20022.Colr002001.GenericIdentification15
    ISO20022.Colr002001.SubBalanceQuantity2Choice *-- ISO20022.Colr002001.FinancialInstrumentQuantity1Choice
    class ISO20022.Colr002001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr002001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr002001.SupplementaryData1 *-- ISO20022.Colr002001.SupplementaryDataEnvelope1
    class ISO20022.Colr002001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr002001.SystemPartyIdentification11 {
        + RspnsblPtyId  : ISO20022.Colr002001.PartyIdentification136
        + Id  : ISO20022.Colr002001.PartyIdentification136
        + Nm  : String
    }
    ISO20022.Colr002001.SystemPartyIdentification11 *-- ISO20022.Colr002001.PartyIdentification136
    ISO20022.Colr002001.SystemPartyIdentification11 *-- ISO20022.Colr002001.PartyIdentification136
    class ISO20022.Colr002001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Colr002001.PartyIdentification136
        + Id  : ISO20022.Colr002001.PartyIdentification136
    }
    ISO20022.Colr002001.SystemPartyIdentification8 *-- ISO20022.Colr002001.PartyIdentification136
    ISO20022.Colr002001.SystemPartyIdentification8 *-- ISO20022.Colr002001.PartyIdentification136
    class ISO20022.Colr002001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
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

## Value ISO20022.Colr002001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Colr002001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Colr002001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr002001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Colr002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Colr002001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricFxgDt|DateTime||XmlElement()||
|+|FinInstrmQty|ISO20022.Colr002001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|PricVal|ISO20022.Colr002001.PriceRateOrAmount3Choice||XmlElement()||
|+|AmtPricTp|ISO20022.Colr002001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal),validElement(AmtPricTp))|

---

## Value ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Colr002001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Colr002001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Colr002001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Colr002001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Colr002001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Colr002001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Colr002001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Colr002001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Colr002001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Colr002001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Colr002001.CollateralValuePosition3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Scties|global::System.Collections.Generic.List<ISO20022.Colr002001.SecurityCharacteristics3>||XmlElement()||
|+|SctiesAcct|ISO20022.Colr002001.SecuritiesAccount19||XmlElement()||
|+|TtlCollValtn|ISO20022.Colr002001.ActiveCurrencyAndAmount||XmlElement()||
|+|DataAccsTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Scties""",Scties),validElement(Scties),validElement(SctiesAcct),validElement(TtlCollValtn))|

---

## Value ISO20022.Colr002001.CollateralValueReport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollValRpt|global::System.Collections.Generic.List<ISO20022.Colr002001.CollateralValueReportOrError6Choice>||XmlElement()||
|+|SctiesAcctSvcr|ISO20022.Colr002001.PartyIdentification136||XmlElement()||
|+|SctiesAcctOwnr|ISO20022.Colr002001.SystemPartyIdentification8||XmlElement()||
|+|CshAcctSvcr|ISO20022.Colr002001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcctOwnr|ISO20022.Colr002001.SystemPartyIdentification11||XmlElement()||
|+|CshAcct|ISO20022.Colr002001.CashAccount40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CollValRpt""",CollValRpt),validElement(CollValRpt),validElement(SctiesAcctSvcr),validElement(SctiesAcctOwnr),validElement(CshAcctSvcr),validElement(CshAcctOwnr),validElement(CshAcct))|

---

## Value ISO20022.Colr002001.CollateralValueReportOrError6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollVal|ISO20022.Colr002001.CollateralValuePosition3||XmlElement()||
|+|BizErr|ISO20022.Colr002001.ErrorHandling5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(BizErr),validChoice(CollVal,BizErr))|

---

## Value ISO20022.Colr002001.CollateralValueReportOrError7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprlErr|global::System.Collections.Generic.List<ISO20022.Colr002001.ErrorHandling5>||XmlElement()||
|+|BizRpt|global::System.Collections.Generic.List<ISO20022.Colr002001.CollateralValueReport4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OprlErr""",OprlErr),validList("""OprlErr""",OprlErr),validElement(OprlErr),validRequired("""BizRpt""",BizRpt),validList("""BizRpt""",BizRpt),validElement(BizRpt),validChoice(OprlErr,BizRpt))|

---

## Aspect ISO20022.Colr002001.CollateralValueReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr002001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Colr002001.CollateralValueReportOrError7Choice||XmlElement()||
|+|MsgHdr|ISO20022.Colr002001.MessageHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

---

## Type ISO20022.Colr002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollValRpt|ISO20022.Colr002001.CollateralValueReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollValRpt))|

---

## Value ISO20022.Colr002001.ErrorHandling3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.ErrorHandling5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Err|ISO20022.Colr002001.ErrorHandling3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Err))|

---

## Value ISO20022.Colr002001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Colr002001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Colr002001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Colr002001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Colr002001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr002001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Colr002001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Colr002001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Colr002001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Colr002001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr002001.GenericIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Colr002001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr002001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr002001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.MessageHeader3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QryNm|String||XmlElement()||
|+|OrgnlBizQry|ISO20022.Colr002001.OriginalBusinessQuery1||XmlElement()||
|+|ReqTp|ISO20022.Colr002001.RequestType2Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlBizQry),validElement(ReqTp))|

---

## Value ISO20022.Colr002001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr002001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr002001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr002001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr002001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr002001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr002001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Colr002001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr002001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr002001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr002001.PostalAddress1


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

## Value ISO20022.Colr002001.PostalAddress27


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
|+|AdrTp|ISO20022.Colr002001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Colr002001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Colr002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Colr002001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Colr002001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Colr002001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr002001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr002001.QuantityAndAvailability1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlbtyInd|String||XmlElement()||
|+|Qty|ISO20022.Colr002001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Enum ISO20022.Colr002001.RequestType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT05|Int32||XmlEnum("""RT05""")|1|
||RT04|Int32||XmlEnum("""RT04""")|2|
||RT03|Int32||XmlEnum("""RT03""")|3|
||RT02|Int32||XmlEnum("""RT02""")|4|
||RT01|Int32||XmlEnum("""RT01""")|5|

---

## Value ISO20022.Colr002001.RequestType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr002001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Enum ISO20022.Colr002001.RequestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RT15|Int32||XmlEnum("""RT15""")|1|
||RT14|Int32||XmlEnum("""RT14""")|2|
||RT13|Int32||XmlEnum("""RT13""")|3|
||RT12|Int32||XmlEnum("""RT12""")|4|
||RT11|Int32||XmlEnum("""RT11""")|5|

---

## Value ISO20022.Colr002001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr002001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr002001.SecuritiesPosition1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Colr002001.SubBalanceQuantity2Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validPattern("""Tp""",Tp,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Colr002001.SecurityCharacteristics3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollVal|ISO20022.Colr002001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValtnPric|ISO20022.Colr002001.AmountPricePerFinancialInstrumentQuantity9||XmlElement()||
|+|Pos|global::System.Collections.Generic.List<ISO20022.Colr002001.SecuritiesPosition1>||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Colr002001.SecurityIdentification19>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(ValtnPric),validList("""Pos""",Pos),validElement(Pos),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Colr002001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr002001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Colr002001.SubBalanceQuantity2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAndAvlbty|ISO20022.Colr002001.QuantityAndAvailability1||XmlElement()||
|+|Prtry|ISO20022.Colr002001.GenericIdentification15||XmlElement()||
|+|Qty|ISO20022.Colr002001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyAndAvlbty),validElement(Prtry),validElement(Qty),validChoice(QtyAndAvlbty,Prtry,Qty))|

---

## Value ISO20022.Colr002001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr002001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr002001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr002001.SystemPartyIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Colr002001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Colr002001.PartyIdentification136||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Colr002001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Colr002001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Colr002001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Colr002001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

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

