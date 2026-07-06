# semt.007.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt007001.Account7 {
        + AcctSvcr  : ISO20022.Semt007001.PartyIdentification2Choice
        + Id  : ISO20022.Semt007001.AccountIdentification1
    }
    ISO20022.Semt007001.Account7 *-- ISO20022.Semt007001.PartyIdentification2Choice
    ISO20022.Semt007001.Account7 *-- ISO20022.Semt007001.AccountIdentification1
    class ISO20022.Semt007001.AccountIdentification1 {
        + Prtry  : ISO20022.Semt007001.SimpleIdentificationInformation
    }
    ISO20022.Semt007001.AccountIdentification1 *-- ISO20022.Semt007001.SimpleIdentificationInformation
    class ISO20022.Semt007001.AccountIdentification3 {
        + Inf  : String
        + Issr  : String
        + Id  : ISO20022.Semt007001.AccountIdentification1
    }
    ISO20022.Semt007001.AccountIdentification3 *-- ISO20022.Semt007001.AccountIdentification1
    class ISO20022.Semt007001.AccountIdentificationAndPurpose {
        + Purp  : String
        + Id  : ISO20022.Semt007001.AccountIdentification1
    }
    ISO20022.Semt007001.AccountIdentificationAndPurpose *-- ISO20022.Semt007001.AccountIdentification1
    class ISO20022.Semt007001.AccountIdentificationFormatChoice {
        + IdAsDSS  : ISO20022.Semt007001.AccountIdentification3
        + IdAndPurp  : ISO20022.Semt007001.AccountIdentificationAndPurpose
        + SmplId  : ISO20022.Semt007001.AccountIdentification1
    }
    ISO20022.Semt007001.AccountIdentificationFormatChoice *-- ISO20022.Semt007001.AccountIdentification3
    ISO20022.Semt007001.AccountIdentificationFormatChoice *-- ISO20022.Semt007001.AccountIdentificationAndPurpose
    ISO20022.Semt007001.AccountIdentificationFormatChoice *-- ISO20022.Semt007001.AccountIdentification1
    class ISO20022.Semt007001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt007001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt007001.AdditionalReference2 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Semt007001.PartyIdentification1Choice
        + Ref  : String
    }
    ISO20022.Semt007001.AdditionalReference2 *-- ISO20022.Semt007001.PartyIdentification1Choice
    class ISO20022.Semt007001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt007001.AlternateSecurityIdentification1 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Semt007001.ClosingBalance3Choice {
        + IntrmyClsgBal  : ISO20022.Semt007001.FinancialInstrumentQuantity1
        + FnlClsgBal  : ISO20022.Semt007001.FinancialInstrumentQuantity1
    }
    ISO20022.Semt007001.ClosingBalance3Choice *-- ISO20022.Semt007001.FinancialInstrumentQuantity1
    ISO20022.Semt007001.ClosingBalance3Choice *-- ISO20022.Semt007001.FinancialInstrumentQuantity1
    class ISO20022.Semt007001.CorporateAction1Choice {
        + Prtry  : ISO20022.Semt007001.GenericIdentification47
        + Tp  : String
    }
    ISO20022.Semt007001.CorporateAction1Choice *-- ISO20022.Semt007001.GenericIdentification47
    class ISO20022.Semt007001.CorporateActionEventType1Code {
        DECR = 1
        EXOF = 2
        EXOP = 3
        REDO = 4
        CHAN = 5
        EXRI = 6
        RHDI = 7
        BONU = 8
        TEND = 9
        SPLR = 10
        SPLF = 11
        SOFF = 12
        NAME = 13
        MRGR = 14
        LIQU = 15
        DVSE = 16
        DVOP = 17
        DVCA = 18
        CAPG = 19
        DRIP = 20
    }
    class ISO20022.Semt007001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt007001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt007001.DatePeriodDetails {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt007001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt007001.EventFrequency1Code {
        ONDE = 1
        OVNG = 2
        INDA = 3
        ADHO = 4
        DAIL = 5
        WEEK = 6
        TOWK = 7
        TWMN = 8
        MNTH = 9
        TOMN = 10
        QUTR = 11
        SEMI = 12
        YEAR = 13
    }
    class ISO20022.Semt007001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Semt007001.FinancialInstrumentQuantity1 {
        + Unit  : Decimal
    }
    class ISO20022.Semt007001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt007001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt007001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt007001.Intermediary27 {
        + Role  : ISO20022.Semt007001.Role4Choice
        + Acct  : ISO20022.Semt007001.Account7
        + Id  : ISO20022.Semt007001.PartyIdentification2Choice
    }
    ISO20022.Semt007001.Intermediary27 *-- ISO20022.Semt007001.Role4Choice
    ISO20022.Semt007001.Intermediary27 *-- ISO20022.Semt007001.Account7
    ISO20022.Semt007001.Intermediary27 *-- ISO20022.Semt007001.PartyIdentification2Choice
    class ISO20022.Semt007001.InvestmentAccount43 {
        + AcctSvcr  : ISO20022.Semt007001.PartyIdentification2Choice
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt007001.Intermediary27~
        + Dsgnt  : String
        + Nm  : String
        + Id  : ISO20022.Semt007001.AccountIdentification1
    }
    ISO20022.Semt007001.InvestmentAccount43 *-- ISO20022.Semt007001.PartyIdentification2Choice
    ISO20022.Semt007001.InvestmentAccount43 *-- ISO20022.Semt007001.Intermediary27
    ISO20022.Semt007001.InvestmentAccount43 *-- ISO20022.Semt007001.AccountIdentification1
    class ISO20022.Semt007001.InvestmentFundRole2Code {
        TRAN = 1
        UCL2 = 2
        UCL1 = 3
        CONC = 4
        DIST = 5
        INTR = 6
        TRAG = 7
        REGI = 8
        FMCO = 9
    }
    class ISO20022.Semt007001.InvestmentFundTransaction4 {
        + PricDtls  : ISO20022.Semt007001.UnitPrice20
        + PrtlyExctdInd  : String
        + CumDvddInd  : String
        + TradDtTm  : ISO20022.Semt007001.DateAndDateTimeChoice
        + SttlmDt  : DateTime
        + SttlmAmt  : ISO20022.Semt007001.ActiveCurrencyAndAmount
        + Rvsl  : String
        + CdtDbt  : String
        + UnitsQty  : ISO20022.Semt007001.FinancialInstrumentQuantity1
        + RegdTxInd  : String
        + SttldTxInd  : String
        + OrdrDtTm  : DateTime
        + LegExctnId  : String
        + LegId  : String
        + DealRef  : String
        + ClntRef  : String
        + OrdrRef  : String
        + MstrRef  : String
        + BookgSts  : String
        + EvtTp  : ISO20022.Semt007001.TransactionType1Choice
    }
    ISO20022.Semt007001.InvestmentFundTransaction4 *-- ISO20022.Semt007001.UnitPrice20
    ISO20022.Semt007001.InvestmentFundTransaction4 *-- ISO20022.Semt007001.DateAndDateTimeChoice
    ISO20022.Semt007001.InvestmentFundTransaction4 *-- ISO20022.Semt007001.ActiveCurrencyAndAmount
    ISO20022.Semt007001.InvestmentFundTransaction4 *-- ISO20022.Semt007001.FinancialInstrumentQuantity1
    ISO20022.Semt007001.InvestmentFundTransaction4 *-- ISO20022.Semt007001.TransactionType1Choice
    class ISO20022.Semt007001.InvestmentFundTransactionsByFund3 {
        + BalByPg  : ISO20022.Semt007001.PaginationBalance2
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Semt007001.InvestmentFundTransaction4~
        + DstrbtnPlcy  : String
        + ClssTp  : String
        + SctiesForm  : String
        + SplmtryId  : String
        + Nm  : String
        + Id  : ISO20022.Semt007001.SecurityIdentification3Choice
    }
    ISO20022.Semt007001.InvestmentFundTransactionsByFund3 *-- ISO20022.Semt007001.PaginationBalance2
    ISO20022.Semt007001.InvestmentFundTransactionsByFund3 *-- ISO20022.Semt007001.InvestmentFundTransaction4
    ISO20022.Semt007001.InvestmentFundTransactionsByFund3 *-- ISO20022.Semt007001.SecurityIdentification3Choice
    class ISO20022.Semt007001.LongPostalAddress1Choice {
        + Strd  : ISO20022.Semt007001.StructuredLongPostalAddress1
        + Ustrd  : String
    }
    ISO20022.Semt007001.LongPostalAddress1Choice *-- ISO20022.Semt007001.StructuredLongPostalAddress1
    class ISO20022.Semt007001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Semt007001.NameAndAddress2 {
        + Adr  : ISO20022.Semt007001.LongPostalAddress1Choice
        + Nm  : String
    }
    ISO20022.Semt007001.NameAndAddress2 *-- ISO20022.Semt007001.LongPostalAddress1Choice
    class ISO20022.Semt007001.NameAndAddress5 {
        + Adr  : ISO20022.Semt007001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt007001.NameAndAddress5 *-- ISO20022.Semt007001.PostalAddress1
    class ISO20022.Semt007001.OpeningBalance3Choice {
        + IntrmyOpngBal  : ISO20022.Semt007001.FinancialInstrumentQuantity1
        + FrstOpngBal  : ISO20022.Semt007001.FinancialInstrumentQuantity1
    }
    ISO20022.Semt007001.OpeningBalance3Choice *-- ISO20022.Semt007001.FinancialInstrumentQuantity1
    ISO20022.Semt007001.OpeningBalance3Choice *-- ISO20022.Semt007001.FinancialInstrumentQuantity1
    class ISO20022.Semt007001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt007001.PaginationBalance2 {
        + ClsgBal  : ISO20022.Semt007001.ClosingBalance3Choice
        + OpngBal  : ISO20022.Semt007001.OpeningBalance3Choice
    }
    ISO20022.Semt007001.PaginationBalance2 *-- ISO20022.Semt007001.ClosingBalance3Choice
    ISO20022.Semt007001.PaginationBalance2 *-- ISO20022.Semt007001.OpeningBalance3Choice
    class ISO20022.Semt007001.PartyIdentification1Choice {
        + NmAndAdr  : ISO20022.Semt007001.NameAndAddress2
        + PrtryId  : ISO20022.Semt007001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Semt007001.PartyIdentification1Choice *-- ISO20022.Semt007001.NameAndAddress2
    ISO20022.Semt007001.PartyIdentification1Choice *-- ISO20022.Semt007001.GenericIdentification1
    class ISO20022.Semt007001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Semt007001.NameAndAddress5
        + PrtryId  : ISO20022.Semt007001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Semt007001.PartyIdentification2Choice *-- ISO20022.Semt007001.NameAndAddress5
    ISO20022.Semt007001.PartyIdentification2Choice *-- ISO20022.Semt007001.GenericIdentification1
    class ISO20022.Semt007001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt007001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Semt007001.PriceValue1 {
        + Amt  : ISO20022.Semt007001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Semt007001.PriceValue1 *-- ISO20022.Semt007001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Semt007001.ReversalCode {
        RVDB = 1
        RVCD = 2
    }
    class ISO20022.Semt007001.Role4Choice {
        + Prtry  : ISO20022.Semt007001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt007001.Role4Choice *-- ISO20022.Semt007001.GenericIdentification47
    class ISO20022.Semt007001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt007001.SecurityIdentification3Choice {
        + OthrPrtryId  : ISO20022.Semt007001.AlternateSecurityIdentification1
        + Cmon  : String
        + Belgn  : String
        + SCVM  : String
        + Vlrn  : String
        + Dtch  : String
        + Wrtppr  : String
        + QUICK  : String
        + CTA  : String
        + Blmbrg  : String
        + TckrSymb  : String
        + RIC  : String
        + CUSIP  : String
        + SEDOL  : String
        + ISIN  : String
    }
    ISO20022.Semt007001.SecurityIdentification3Choice *-- ISO20022.Semt007001.AlternateSecurityIdentification1
    class ISO20022.Semt007001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Semt007001.Statement8 {
        + RptNb  : String
        + ActvtyInd  : String
        + UpdTp  : String
        + Frqcy  : String
        + CreDtTm  : ISO20022.Semt007001.DateAndDateTimeChoice
        + StmtPrd  : ISO20022.Semt007001.DatePeriodDetails
        + Ref  : String
    }
    ISO20022.Semt007001.Statement8 *-- ISO20022.Semt007001.DateAndDateTimeChoice
    ISO20022.Semt007001.Statement8 *-- ISO20022.Semt007001.DatePeriodDetails
    class ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Semt007001.Extension1~
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt007001.SubAccountIdentification36~
        + TxOnAcct  : global::System.Collections.Generic.List~ISO20022.Semt007001.InvestmentFundTransactionsByFund3~
        + InvstmtAcctDtls  : ISO20022.Semt007001.InvestmentAccount43
        + StmtGnlDtls  : ISO20022.Semt007001.Statement8
    }
    ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 *-- ISO20022.Semt007001.Extension1
    ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 *-- ISO20022.Semt007001.SubAccountIdentification36
    ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 *-- ISO20022.Semt007001.InvestmentFundTransactionsByFund3
    ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 *-- ISO20022.Semt007001.InvestmentAccount43
    ISO20022.Semt007001.StatementOfInvestmentFundTransactions3 *-- ISO20022.Semt007001.Statement8
    class ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 {
        + StmtToBeCanc  : ISO20022.Semt007001.StatementOfInvestmentFundTransactions3
        + MsgPgntn  : ISO20022.Semt007001.Pagination
        + RltdRef  : ISO20022.Semt007001.AdditionalReference2
        + PrvsRef  : ISO20022.Semt007001.AdditionalReference2
        + MsgId  : ISO20022.Semt007001.MessageIdentification1
    }
    ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 *-- ISO20022.Semt007001.StatementOfInvestmentFundTransactions3
    ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 *-- ISO20022.Semt007001.Pagination
    ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 *-- ISO20022.Semt007001.AdditionalReference2
    ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 *-- ISO20022.Semt007001.AdditionalReference2
    ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03 *-- ISO20022.Semt007001.MessageIdentification1
    class ISO20022.Semt007001.StatementUpdateTypeCode {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt007001.StructuredLongPostalAddress1 {
        + POB  : String
        + PstCdId  : String
        + Ctry  : String
        + CtyId  : String
        + Stat  : String
        + RgnId  : String
        + DstrctNm  : String
        + TwnNm  : String
        + Flr  : String
        + StrtBldgId  : String
        + StrtNm  : String
        + BldgNm  : String
    }
    class ISO20022.Semt007001.SubAccountIdentification36 {
        + TxOnSubAcct  : global::System.Collections.Generic.List~ISO20022.Semt007001.InvestmentFundTransactionsByFund3~
        + ActvtyInd  : String
        + Id  : ISO20022.Semt007001.AccountIdentificationFormatChoice
    }
    ISO20022.Semt007001.SubAccountIdentification36 *-- ISO20022.Semt007001.InvestmentFundTransactionsByFund3
    ISO20022.Semt007001.SubAccountIdentification36 *-- ISO20022.Semt007001.AccountIdentificationFormatChoice
    class ISO20022.Semt007001.TransactionStatus1Code {
        CANC = 1
        REBO = 2
        RVSL = 3
    }
    class ISO20022.Semt007001.TransactionType1Choice {
        + CorpActnTp  : ISO20022.Semt007001.CorporateAction1Choice
        + TxTp  : ISO20022.Semt007001.TransactionType2Choice
    }
    ISO20022.Semt007001.TransactionType1Choice *-- ISO20022.Semt007001.CorporateAction1Choice
    ISO20022.Semt007001.TransactionType1Choice *-- ISO20022.Semt007001.TransactionType2Choice
    class ISO20022.Semt007001.TransactionType2Choice {
        + Prtry  : ISO20022.Semt007001.GenericIdentification47
        + Tp  : String
    }
    ISO20022.Semt007001.TransactionType2Choice *-- ISO20022.Semt007001.GenericIdentification47
    class ISO20022.Semt007001.TransactionType2Code {
        REAA = 1
        SUAA = 2
        SWIO = 3
        SWII = 4
        TOUT = 5
        TRIN = 6
        RWPL = 7
        SSPL = 8
        SUBS = 9
        REDM = 10
    }
    class ISO20022.Semt007001.TypeOfPrice10Code {
        ACTU = 1
        DDVR = 2
        SWIC = 3
        RINV = 4
        MIDD = 5
        SWNG = 6
        INTE = 7
        CANC = 8
        CREA = 9
        NAVL = 10
        OFFR = 11
        BIDE = 12
    }
    class ISO20022.Semt007001.UnitPrice20 {
        + PricMtd  : String
        + Val  : ISO20022.Semt007001.PriceValue1
        + PricTp  : ISO20022.Semt007001.UnitPriceType2Choice
    }
    ISO20022.Semt007001.UnitPrice20 *-- ISO20022.Semt007001.PriceValue1
    ISO20022.Semt007001.UnitPrice20 *-- ISO20022.Semt007001.UnitPriceType2Choice
    class ISO20022.Semt007001.UnitPriceType2Choice {
        + Prtry  : ISO20022.Semt007001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt007001.UnitPriceType2Choice *-- ISO20022.Semt007001.GenericIdentification47
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

## Value ISO20022.Semt007001.Account7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt007001.PartyIdentification2Choice||XmlElement()||
|+|Id|ISO20022.Semt007001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt007001.AccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt007001.SimpleIdentificationInformation||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt007001.AccountIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|ISO20022.Semt007001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Inf""",Inf,"""[a-zA-Z0-9]{4}"""),validElement(Id))|

---

## Value ISO20022.Semt007001.AccountIdentificationAndPurpose


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|String||XmlElement()||
|+|Id|ISO20022.Semt007001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Semt007001.AccountIdentificationFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdAsDSS|ISO20022.Semt007001.AccountIdentification3||XmlElement()||
|+|IdAndPurp|ISO20022.Semt007001.AccountIdentificationAndPurpose||XmlElement()||
|+|SmplId|ISO20022.Semt007001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdAsDSS),validElement(IdAndPurp),validElement(SmplId),validChoice(IdAsDSS,IdAndPurp,SmplId))|

---

## Value ISO20022.Semt007001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt007001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt007001.AdditionalReference2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Semt007001.PartyIdentification1Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Semt007001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt007001.AlternateSecurityIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Semt007001.ClosingBalance3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrmyClsgBal|ISO20022.Semt007001.FinancialInstrumentQuantity1||XmlElement()||
|+|FnlClsgBal|ISO20022.Semt007001.FinancialInstrumentQuantity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrmyClsgBal),validElement(FnlClsgBal),validChoice(IntrmyClsgBal,FnlClsgBal))|

---

## Value ISO20022.Semt007001.CorporateAction1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt007001.GenericIdentification47||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Enum ISO20022.Semt007001.CorporateActionEventType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DECR|Int32||XmlEnum("""DECR""")|1|
||EXOF|Int32||XmlEnum("""EXOF""")|2|
||EXOP|Int32||XmlEnum("""EXOP""")|3|
||REDO|Int32||XmlEnum("""REDO""")|4|
||CHAN|Int32||XmlEnum("""CHAN""")|5|
||EXRI|Int32||XmlEnum("""EXRI""")|6|
||RHDI|Int32||XmlEnum("""RHDI""")|7|
||BONU|Int32||XmlEnum("""BONU""")|8|
||TEND|Int32||XmlEnum("""TEND""")|9|
||SPLR|Int32||XmlEnum("""SPLR""")|10|
||SPLF|Int32||XmlEnum("""SPLF""")|11|
||SOFF|Int32||XmlEnum("""SOFF""")|12|
||NAME|Int32||XmlEnum("""NAME""")|13|
||MRGR|Int32||XmlEnum("""MRGR""")|14|
||LIQU|Int32||XmlEnum("""LIQU""")|15|
||DVSE|Int32||XmlEnum("""DVSE""")|16|
||DVOP|Int32||XmlEnum("""DVOP""")|17|
||DVCA|Int32||XmlEnum("""DVCA""")|18|
||CAPG|Int32||XmlEnum("""CAPG""")|19|
||DRIP|Int32||XmlEnum("""DRIP""")|20|

---

## Enum ISO20022.Semt007001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt007001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt007001.DatePeriodDetails


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt007001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtOfInvstmtFndTxsCxl|ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtOfInvstmtFndTxsCxl))|

---

## Enum ISO20022.Semt007001.EventFrequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||INDA|Int32||XmlEnum("""INDA""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||DAIL|Int32||XmlEnum("""DAIL""")|5|
||WEEK|Int32||XmlEnum("""WEEK""")|6|
||TOWK|Int32||XmlEnum("""TOWK""")|7|
||TWMN|Int32||XmlEnum("""TWMN""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||TOMN|Int32||XmlEnum("""TOMN""")|10|
||QUTR|Int32||XmlEnum("""QUTR""")|11|
||SEMI|Int32||XmlEnum("""SEMI""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Value ISO20022.Semt007001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt007001.FinancialInstrumentQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt007001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt007001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt007001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt007001.Intermediary27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Role|ISO20022.Semt007001.Role4Choice||XmlElement()||
|+|Acct|ISO20022.Semt007001.Account7||XmlElement()||
|+|Id|ISO20022.Semt007001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Role),validElement(Acct),validElement(Id))|

---

## Value ISO20022.Semt007001.InvestmentAccount43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt007001.PartyIdentification2Choice||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt007001.Intermediary27>||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Semt007001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(Id))|

---

## Enum ISO20022.Semt007001.InvestmentFundRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||UCL2|Int32||XmlEnum("""UCL2""")|2|
||UCL1|Int32||XmlEnum("""UCL1""")|3|
||CONC|Int32||XmlEnum("""CONC""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|
||INTR|Int32||XmlEnum("""INTR""")|6|
||TRAG|Int32||XmlEnum("""TRAG""")|7|
||REGI|Int32||XmlEnum("""REGI""")|8|
||FMCO|Int32||XmlEnum("""FMCO""")|9|

---

## Value ISO20022.Semt007001.InvestmentFundTransaction4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDtls|ISO20022.Semt007001.UnitPrice20||XmlElement()||
|+|PrtlyExctdInd|String||XmlElement()||
|+|CumDvddInd|String||XmlElement()||
|+|TradDtTm|ISO20022.Semt007001.DateAndDateTimeChoice||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
|+|SttlmAmt|ISO20022.Semt007001.ActiveCurrencyAndAmount||XmlElement()||
|+|Rvsl|String||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|UnitsQty|ISO20022.Semt007001.FinancialInstrumentQuantity1||XmlElement()||
|+|RegdTxInd|String||XmlElement()||
|+|SttldTxInd|String||XmlElement()||
|+|OrdrDtTm|DateTime||XmlElement()||
|+|LegExctnId|String||XmlElement()||
|+|LegId|String||XmlElement()||
|+|DealRef|String||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|BookgSts|String||XmlElement()||
|+|EvtTp|ISO20022.Semt007001.TransactionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricDtls),validElement(TradDtTm),validElement(SttlmAmt),validElement(UnitsQty),validElement(EvtTp))|

---

## Value ISO20022.Semt007001.InvestmentFundTransactionsByFund3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalByPg|ISO20022.Semt007001.PaginationBalance2||XmlElement()||
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Semt007001.InvestmentFundTransaction4>||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Semt007001.SecurityIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BalByPg),validRequired("""TxDtls""",TxDtls),validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(Id))|

---

## Value ISO20022.Semt007001.LongPostalAddress1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|ISO20022.Semt007001.StructuredLongPostalAddress1||XmlElement()||
|+|Ustrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Strd),validChoice(Strd,Ustrd))|

---

## Value ISO20022.Semt007001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt007001.NameAndAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt007001.LongPostalAddress1Choice||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt007001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt007001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt007001.OpeningBalance3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrmyOpngBal|ISO20022.Semt007001.FinancialInstrumentQuantity1||XmlElement()||
|+|FrstOpngBal|ISO20022.Semt007001.FinancialInstrumentQuantity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrmyOpngBal),validElement(FrstOpngBal),validChoice(IntrmyOpngBal,FrstOpngBal))|

---

## Value ISO20022.Semt007001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt007001.PaginationBalance2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClsgBal|ISO20022.Semt007001.ClosingBalance3Choice||XmlElement()||
|+|OpngBal|ISO20022.Semt007001.OpeningBalance3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClsgBal),validElement(OpngBal))|

---

## Value ISO20022.Semt007001.PartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt007001.NameAndAddress2||XmlElement()||
|+|PrtryId|ISO20022.Semt007001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Semt007001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt007001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt007001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Semt007001.PostalAddress1


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

## Enum ISO20022.Semt007001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Semt007001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt007001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Semt007001.ReversalCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RVDB|Int32||XmlEnum("""RVDB""")|1|
||RVCD|Int32||XmlEnum("""RVCD""")|2|

---

## Value ISO20022.Semt007001.Role4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt007001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt007001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Value ISO20022.Semt007001.SecurityIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Semt007001.AlternateSecurityIdentification1||XmlElement()||
|+|Cmon|String||XmlElement()||
|+|Belgn|String||XmlElement()||
|+|SCVM|String||XmlElement()||
|+|Vlrn|String||XmlElement()||
|+|Dtch|String||XmlElement()||
|+|Wrtppr|String||XmlElement()||
|+|QUICK|String||XmlElement()||
|+|CTA|String||XmlElement()||
|+|Blmbrg|String||XmlElement()||
|+|TckrSymb|String||XmlElement()||
|+|RIC|String||XmlElement()||
|+|CUSIP|String||XmlElement()||
|+|SEDOL|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPrtryId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN))|

---

## Value ISO20022.Semt007001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt007001.Statement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptNb|String||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|String||XmlElement()||
|+|Frqcy|String||XmlElement()||
|+|CreDtTm|ISO20022.Semt007001.DateAndDateTimeChoice||XmlElement()||
|+|StmtPrd|ISO20022.Semt007001.DatePeriodDetails||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RptNb""",RptNb,"""[0-9]{1,5}"""),validElement(CreDtTm),validElement(StmtPrd))|

---

## Value ISO20022.Semt007001.StatementOfInvestmentFundTransactions3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Semt007001.Extension1>||XmlElement()||
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt007001.SubAccountIdentification36>||XmlElement()||
|+|TxOnAcct|global::System.Collections.Generic.List<ISO20022.Semt007001.InvestmentFundTransactionsByFund3>||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Semt007001.InvestmentAccount43||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt007001.Statement8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""TxOnAcct""",TxOnAcct),validElement(TxOnAcct),validElement(InvstmtAcctDtls),validElement(StmtGnlDtls))|

---

## Aspect ISO20022.Semt007001.StatementOfInvestmentFundTransactionsCancellationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtToBeCanc|ISO20022.Semt007001.StatementOfInvestmentFundTransactions3||XmlElement()||
|+|MsgPgntn|ISO20022.Semt007001.Pagination||XmlElement()||
|+|RltdRef|ISO20022.Semt007001.AdditionalReference2||XmlElement()||
|+|PrvsRef|ISO20022.Semt007001.AdditionalReference2||XmlElement()||
|+|MsgId|ISO20022.Semt007001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtToBeCanc),validElement(MsgPgntn),validElement(RltdRef),validElement(PrvsRef),validElement(MsgId))|

---

## Enum ISO20022.Semt007001.StatementUpdateTypeCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt007001.StructuredLongPostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|POB|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtyId|String||XmlElement()||
|+|Stat|String||XmlElement()||
|+|RgnId|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|StrtBldgId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Semt007001.SubAccountIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxOnSubAcct|global::System.Collections.Generic.List<ISO20022.Semt007001.InvestmentFundTransactionsByFund3>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|Id|ISO20022.Semt007001.AccountIdentificationFormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxOnSubAcct""",TxOnSubAcct),validElement(TxOnSubAcct),validElement(Id))|

---

## Enum ISO20022.Semt007001.TransactionStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANC|Int32||XmlEnum("""CANC""")|1|
||REBO|Int32||XmlEnum("""REBO""")|2|
||RVSL|Int32||XmlEnum("""RVSL""")|3|

---

## Value ISO20022.Semt007001.TransactionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnTp|ISO20022.Semt007001.CorporateAction1Choice||XmlElement()||
|+|TxTp|ISO20022.Semt007001.TransactionType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnTp),validElement(TxTp),validChoice(CorpActnTp,TxTp))|

---

## Value ISO20022.Semt007001.TransactionType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt007001.GenericIdentification47||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Enum ISO20022.Semt007001.TransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REAA|Int32||XmlEnum("""REAA""")|1|
||SUAA|Int32||XmlEnum("""SUAA""")|2|
||SWIO|Int32||XmlEnum("""SWIO""")|3|
||SWII|Int32||XmlEnum("""SWII""")|4|
||TOUT|Int32||XmlEnum("""TOUT""")|5|
||TRIN|Int32||XmlEnum("""TRIN""")|6|
||RWPL|Int32||XmlEnum("""RWPL""")|7|
||SSPL|Int32||XmlEnum("""SSPL""")|8|
||SUBS|Int32||XmlEnum("""SUBS""")|9|
||REDM|Int32||XmlEnum("""REDM""")|10|

---

## Enum ISO20022.Semt007001.TypeOfPrice10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||DDVR|Int32||XmlEnum("""DDVR""")|2|
||SWIC|Int32||XmlEnum("""SWIC""")|3|
||RINV|Int32||XmlEnum("""RINV""")|4|
||MIDD|Int32||XmlEnum("""MIDD""")|5|
||SWNG|Int32||XmlEnum("""SWNG""")|6|
||INTE|Int32||XmlEnum("""INTE""")|7|
||CANC|Int32||XmlEnum("""CANC""")|8|
||CREA|Int32||XmlEnum("""CREA""")|9|
||NAVL|Int32||XmlEnum("""NAVL""")|10|
||OFFR|Int32||XmlEnum("""OFFR""")|11|
||BIDE|Int32||XmlEnum("""BIDE""")|12|

---

## Value ISO20022.Semt007001.UnitPrice20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricMtd|String||XmlElement()||
|+|Val|ISO20022.Semt007001.PriceValue1||XmlElement()||
|+|PricTp|ISO20022.Semt007001.UnitPriceType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(PricTp))|

---

## Value ISO20022.Semt007001.UnitPriceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt007001.GenericIdentification47||XmlElement()||
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

