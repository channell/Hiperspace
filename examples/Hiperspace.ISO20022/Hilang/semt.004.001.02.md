# semt.004.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt004001.Account7 {
        + AcctSvcr  : ISO20022.Semt004001.PartyIdentification2Choice
        + Id  : ISO20022.Semt004001.AccountIdentification1
    }
    ISO20022.Semt004001.Account7 *-- ISO20022.Semt004001.PartyIdentification2Choice
    ISO20022.Semt004001.Account7 *-- ISO20022.Semt004001.AccountIdentification1
    class ISO20022.Semt004001.AccountIdentification1 {
        + Prtry  : ISO20022.Semt004001.SimpleIdentificationInformation
    }
    ISO20022.Semt004001.AccountIdentification1 *-- ISO20022.Semt004001.SimpleIdentificationInformation
    class ISO20022.Semt004001.AccountIdentification3 {
        + Inf  : String
        + Issr  : String
        + Id  : ISO20022.Semt004001.AccountIdentification1
    }
    ISO20022.Semt004001.AccountIdentification3 *-- ISO20022.Semt004001.AccountIdentification1
    class ISO20022.Semt004001.AccountIdentificationAndPurpose {
        + Purp  : String
        + Id  : ISO20022.Semt004001.AccountIdentification1
    }
    ISO20022.Semt004001.AccountIdentificationAndPurpose *-- ISO20022.Semt004001.AccountIdentification1
    class ISO20022.Semt004001.AccountIdentificationFormatChoice {
        + IdAsDSS  : ISO20022.Semt004001.AccountIdentification3
        + IdAndPurp  : ISO20022.Semt004001.AccountIdentificationAndPurpose
        + SmplId  : ISO20022.Semt004001.AccountIdentification1
    }
    ISO20022.Semt004001.AccountIdentificationFormatChoice *-- ISO20022.Semt004001.AccountIdentification3
    ISO20022.Semt004001.AccountIdentificationFormatChoice *-- ISO20022.Semt004001.AccountIdentificationAndPurpose
    ISO20022.Semt004001.AccountIdentificationFormatChoice *-- ISO20022.Semt004001.AccountIdentification1
    class ISO20022.Semt004001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt004001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt004001.AdditionalBalanceInformation2 {
        + XtndedSubBalTp  : String
        + SubBalTp  : String
        + Qty  : ISO20022.Semt004001.SubBalanceQuantity1Choice
    }
    ISO20022.Semt004001.AdditionalBalanceInformation2 *-- ISO20022.Semt004001.SubBalanceQuantity1Choice
    class ISO20022.Semt004001.AdditionalReference2 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Semt004001.PartyIdentification1Choice
        + Ref  : String
    }
    ISO20022.Semt004001.AdditionalReference2 *-- ISO20022.Semt004001.PartyIdentification1Choice
    class ISO20022.Semt004001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt004001.AggregateBalanceInformation4 {
        + BalAtSfkpgPlc  : global::System.Collections.Generic.List~ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3~
        + AddtlBalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.AdditionalBalanceInformation2~
        + BalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.SubBalanceInformation2~
        + FXDtls  : ISO20022.Semt004001.ForeignExchangeTerms6
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.PriceInformation2~
        + FinInstrmDtls  : ISO20022.Semt004001.FinancialInstrument13
        + SfkpgPlc  : ISO20022.Semt004001.SafekeepingPlaceFormatChoice
        + BookVal  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + AcrdIntrstAmtSgn  : String
        + AcrdIntrstAmt  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + PrvsHldgVal  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + HldgVal  : global::System.Collections.Generic.List~ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount~
        + DaysAcrd  : Decimal
        + NotAvlblQty  : ISO20022.Semt004001.BalanceQuantity1Choice
        + AvlblQty  : ISO20022.Semt004001.BalanceQuantity1Choice
        + AggtQty  : ISO20022.Semt004001.BalanceQuantity1Choice
    }
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.AdditionalBalanceInformation2
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.SubBalanceInformation2
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.ForeignExchangeTerms6
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.PriceInformation2
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.FinancialInstrument13
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.SafekeepingPlaceFormatChoice
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    ISO20022.Semt004001.AggregateBalanceInformation4 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    class ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 {
        + AddtlBalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.AdditionalBalanceInformation2~
        + BalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.SubBalanceInformation2~
        + FXDtls  : ISO20022.Semt004001.ForeignExchangeTerms6
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.PriceInformation2~
        + SfkpgPlc  : ISO20022.Semt004001.SafekeepingPlaceFormatChoice
        + BookVal  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + AcrdIntrstAmtSgn  : String
        + AcrdIntrstAmt  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + PrvsHldgVal  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
        + HldgVal  : global::System.Collections.Generic.List~ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount~
        + DaysAcrd  : Decimal
        + NotAvlblQty  : ISO20022.Semt004001.BalanceQuantity1Choice
        + AvlblQty  : ISO20022.Semt004001.BalanceQuantity1Choice
        + AggtQty  : ISO20022.Semt004001.BalanceQuantity1Choice
    }
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.AdditionalBalanceInformation2
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.SubBalanceInformation2
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.ForeignExchangeTerms6
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.PriceInformation2
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.SafekeepingPlaceFormatChoice
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3 *-- ISO20022.Semt004001.BalanceQuantity1Choice
    class ISO20022.Semt004001.AlternateSecurityIdentification1 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Semt004001.BalanceQuantity1Choice {
        + QtyAsDSS  : ISO20022.Semt004001.GenericIdentification6
        + Qty  : ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    }
    ISO20022.Semt004001.BalanceQuantity1Choice *-- ISO20022.Semt004001.GenericIdentification6
    ISO20022.Semt004001.BalanceQuantity1Choice *-- ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    class ISO20022.Semt004001.CustodyStatementOfHoldings2 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Semt004001.Extension1~
        + TtlVals  : ISO20022.Semt004001.TotalValueInPageAndStatement
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.SubAccountIdentification5~
        + BalForAcct  : global::System.Collections.Generic.List~ISO20022.Semt004001.AggregateBalanceInformation4~
        + AcctDtls  : ISO20022.Semt004001.SafekeepingAccount2
        + StmtGnlDtls  : ISO20022.Semt004001.Statement7
    }
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.Extension1
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.TotalValueInPageAndStatement
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.SubAccountIdentification5
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.AggregateBalanceInformation4
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.SafekeepingAccount2
    ISO20022.Semt004001.CustodyStatementOfHoldings2 *-- ISO20022.Semt004001.Statement7
    class ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 {
        + StmtToBeCanc  : ISO20022.Semt004001.CustodyStatementOfHoldings2
        + MsgPgntn  : ISO20022.Semt004001.Pagination
        + RltdRef  : ISO20022.Semt004001.AdditionalReference2
        + PrvsRef  : ISO20022.Semt004001.AdditionalReference2
        + MsgId  : ISO20022.Semt004001.MessageIdentification1
    }
    ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 *-- ISO20022.Semt004001.CustodyStatementOfHoldings2
    ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 *-- ISO20022.Semt004001.Pagination
    ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 *-- ISO20022.Semt004001.AdditionalReference2
    ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 *-- ISO20022.Semt004001.AdditionalReference2
    ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02 *-- ISO20022.Semt004001.MessageIdentification1
    class ISO20022.Semt004001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt004001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt004001.EventFrequency1Code {
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
    class ISO20022.Semt004001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Semt004001.FinancialInstrument13 {
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + Nm  : String
        + Id  : ISO20022.Semt004001.SecurityIdentification3Choice
    }
    ISO20022.Semt004001.FinancialInstrument13 *-- ISO20022.Semt004001.SecurityIdentification3Choice
    class ISO20022.Semt004001.FinancialInstrumentQuantityChoice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt004001.ForeignExchangeTerms6 {
        + QtgInstn  : ISO20022.Semt004001.PartyIdentification2Choice
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Semt004001.ForeignExchangeTerms6 *-- ISO20022.Semt004001.PartyIdentification2Choice
    class ISO20022.Semt004001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice {
        + FrqcyAsDSS  : ISO20022.Semt004001.GenericIdentification7
        + FrqcyAsCd  : String
    }
    ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice *-- ISO20022.Semt004001.GenericIdentification7
    class ISO20022.Semt004001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt004001.GenericIdentification5 {
        + Nrrtv  : String
        + Inf  : String
        + Issr  : String
    }
    class ISO20022.Semt004001.GenericIdentification6 {
        + Bal  : Decimal
        + Inf  : String
        + Issr  : String
    }
    class ISO20022.Semt004001.GenericIdentification7 {
        + Inf  : String
        + Issr  : String
    }
    class ISO20022.Semt004001.Intermediary11 {
        + XtndedRole  : String
        + Role  : String
        + Acct  : ISO20022.Semt004001.Account7
        + Id  : ISO20022.Semt004001.PartyIdentification2Choice
    }
    ISO20022.Semt004001.Intermediary11 *-- ISO20022.Semt004001.Account7
    ISO20022.Semt004001.Intermediary11 *-- ISO20022.Semt004001.PartyIdentification2Choice
    class ISO20022.Semt004001.InvestmentFundRole2Code {
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
    class ISO20022.Semt004001.LongPostalAddress1Choice {
        + Strd  : ISO20022.Semt004001.StructuredLongPostalAddress1
        + Ustrd  : String
    }
    ISO20022.Semt004001.LongPostalAddress1Choice *-- ISO20022.Semt004001.StructuredLongPostalAddress1
    class ISO20022.Semt004001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Semt004001.NameAndAddress2 {
        + Adr  : ISO20022.Semt004001.LongPostalAddress1Choice
        + Nm  : String
    }
    ISO20022.Semt004001.NameAndAddress2 *-- ISO20022.Semt004001.LongPostalAddress1Choice
    class ISO20022.Semt004001.NameAndAddress5 {
        + Adr  : ISO20022.Semt004001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt004001.NameAndAddress5 *-- ISO20022.Semt004001.PostalAddress1
    class ISO20022.Semt004001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt004001.PartyIdentification1Choice {
        + NmAndAdr  : ISO20022.Semt004001.NameAndAddress2
        + PrtryId  : ISO20022.Semt004001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Semt004001.PartyIdentification1Choice *-- ISO20022.Semt004001.NameAndAddress2
    ISO20022.Semt004001.PartyIdentification1Choice *-- ISO20022.Semt004001.GenericIdentification1
    class ISO20022.Semt004001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Semt004001.NameAndAddress5
        + PrtryId  : ISO20022.Semt004001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Semt004001.PartyIdentification2Choice *-- ISO20022.Semt004001.NameAndAddress5
    ISO20022.Semt004001.PartyIdentification2Choice *-- ISO20022.Semt004001.GenericIdentification1
    class ISO20022.Semt004001.PartyIdentification3 {
        + BICOrBEI  : String
    }
    class ISO20022.Semt004001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt004001.PriceInformation2 {
        + Yldd  : String
        + QtnDt  : ISO20022.Semt004001.DateAndDateTimeChoice
        + SrcOfPric  : ISO20022.Semt004001.PriceSourceFormatChoice
        + XtndedTp  : String
        + Tp  : String
        + ValTp  : String
        + Val  : ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice
    }
    ISO20022.Semt004001.PriceInformation2 *-- ISO20022.Semt004001.DateAndDateTimeChoice
    ISO20022.Semt004001.PriceInformation2 *-- ISO20022.Semt004001.PriceSourceFormatChoice
    ISO20022.Semt004001.PriceInformation2 *-- ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice
    class ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice {
        + UknwnInd  : String
        + Amt  : ISO20022.Semt004001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice *-- ISO20022.Semt004001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt004001.PriceSource {
        + Nrrtv  : String
        + PricSrc  : String
    }
    class ISO20022.Semt004001.PriceSource1Code {
        VEND = 1
        THEO = 2
        FUND = 3
    }
    class ISO20022.Semt004001.PriceSourceFormatChoice {
        + PlcAsDSS  : ISO20022.Semt004001.GenericIdentification5
        + NonLclMktPlc  : ISO20022.Semt004001.PriceSource
        + LclMktPlc  : String
    }
    ISO20022.Semt004001.PriceSourceFormatChoice *-- ISO20022.Semt004001.GenericIdentification5
    ISO20022.Semt004001.PriceSourceFormatChoice *-- ISO20022.Semt004001.PriceSource
    class ISO20022.Semt004001.PriceValueType2Code {
        PREM = 1
        DISC = 2
    }
    class ISO20022.Semt004001.QuantityAndAvailability {
        + AvlbtyInd  : String
        + Qty  : ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    }
    ISO20022.Semt004001.QuantityAndAvailability *-- ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    class ISO20022.Semt004001.SafekeepingAccount2 {
        + AcctSvcr  : ISO20022.Semt004001.PartyIdentification2Choice
        + AcctOwnr  : ISO20022.Semt004001.PartyIdentification2Choice
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt004001.Intermediary11~
        + Dsgnt  : String
        + Nm  : String
        + FngbInd  : String
        + Id  : ISO20022.Semt004001.AccountIdentificationFormatChoice
    }
    ISO20022.Semt004001.SafekeepingAccount2 *-- ISO20022.Semt004001.PartyIdentification2Choice
    ISO20022.Semt004001.SafekeepingAccount2 *-- ISO20022.Semt004001.PartyIdentification2Choice
    ISO20022.Semt004001.SafekeepingAccount2 *-- ISO20022.Semt004001.Intermediary11
    ISO20022.Semt004001.SafekeepingAccount2 *-- ISO20022.Semt004001.AccountIdentificationFormatChoice
    class ISO20022.Semt004001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification {
        + Pty  : ISO20022.Semt004001.PartyIdentification3
        + Nrrtv  : String
        + PlcSfkpg  : String
    }
    ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification *-- ISO20022.Semt004001.PartyIdentification3
    class ISO20022.Semt004001.SafekeepingPlaceFormatChoice {
        + IdAsCtry  : String
        + IdAsDSS  : ISO20022.Semt004001.GenericIdentification5
        + Id  : ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification
    }
    ISO20022.Semt004001.SafekeepingPlaceFormatChoice *-- ISO20022.Semt004001.GenericIdentification5
    ISO20022.Semt004001.SafekeepingPlaceFormatChoice *-- ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification
    class ISO20022.Semt004001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt004001.SecuritiesBalanceType1Code {
        BTRA = 1
        WDOC = 2
        DRAW = 3
        TRAN = 4
        OTHR = 5
        RSTR = 6
        REGO = 7
        PDUM = 8
        PLED = 9
        PENR = 10
        PEND = 11
        PECA = 12
        PRUM = 13
        PRMT = 14
        PDMT = 15
        MARG = 16
        LOAN = 17
        COLO = 18
        COLI = 19
        BORR = 20
        BLOK = 21
    }
    class ISO20022.Semt004001.SecuritiesBalanceType2Code {
        UNRG = 1
        SPOS = 2
        OTHR = 3
        NOMI = 4
        DIRT = 5
        CLEN = 6
    }
    class ISO20022.Semt004001.SecurityIdentification3Choice {
        + OthrPrtryId  : ISO20022.Semt004001.AlternateSecurityIdentification1
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
    ISO20022.Semt004001.SecurityIdentification3Choice *-- ISO20022.Semt004001.AlternateSecurityIdentification1
    class ISO20022.Semt004001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Semt004001.Statement7 {
        + RptNb  : String
        + StmtBsis  : ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice
        + Frqcy  : ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice
        + CreDtTm  : ISO20022.Semt004001.DateAndDateTimeChoice
        + StmtDtTm  : ISO20022.Semt004001.DateAndDateTimeChoice
        + Ref  : String
    }
    ISO20022.Semt004001.Statement7 *-- ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice
    ISO20022.Semt004001.Statement7 *-- ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice
    ISO20022.Semt004001.Statement7 *-- ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice
    ISO20022.Semt004001.Statement7 *-- ISO20022.Semt004001.DateAndDateTimeChoice
    ISO20022.Semt004001.Statement7 *-- ISO20022.Semt004001.DateAndDateTimeChoice
    class ISO20022.Semt004001.StatementBasis1Code {
        TRAD = 1
        SETT = 2
        CONT = 3
    }
    class ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice {
        + StmtBsisAsDSS  : ISO20022.Semt004001.GenericIdentification7
        + StmtBsisAsCd  : String
    }
    ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice *-- ISO20022.Semt004001.GenericIdentification7
    class ISO20022.Semt004001.StatementUpdateTypeCode {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice {
        + StmtUpdTpAsDSS  : ISO20022.Semt004001.GenericIdentification7
        + StmtUpdTpAsCd  : String
    }
    ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice *-- ISO20022.Semt004001.GenericIdentification7
    class ISO20022.Semt004001.StructuredLongPostalAddress1 {
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
    class ISO20022.Semt004001.SubAccountIdentification5 {
        + BalForSubAcct  : global::System.Collections.Generic.List~ISO20022.Semt004001.AggregateBalanceInformation4~
        + ActvtyInd  : String
        + FngbInd  : String
        + Id  : ISO20022.Semt004001.AccountIdentificationFormatChoice
    }
    ISO20022.Semt004001.SubAccountIdentification5 *-- ISO20022.Semt004001.AggregateBalanceInformation4
    ISO20022.Semt004001.SubAccountIdentification5 *-- ISO20022.Semt004001.AccountIdentificationFormatChoice
    class ISO20022.Semt004001.SubBalanceInformation2 {
        + AddtlBalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt004001.AdditionalBalanceInformation2~
        + XtndedSubBalTp  : String
        + SubBalTp  : String
        + Qty  : ISO20022.Semt004001.SubBalanceQuantity1Choice
    }
    ISO20022.Semt004001.SubBalanceInformation2 *-- ISO20022.Semt004001.AdditionalBalanceInformation2
    ISO20022.Semt004001.SubBalanceInformation2 *-- ISO20022.Semt004001.SubBalanceQuantity1Choice
    class ISO20022.Semt004001.SubBalanceQuantity1Choice {
        + QtyAndAvlbty  : ISO20022.Semt004001.QuantityAndAvailability
        + QtyAsDSS  : ISO20022.Semt004001.GenericIdentification6
        + Qty  : ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    }
    ISO20022.Semt004001.SubBalanceQuantity1Choice *-- ISO20022.Semt004001.QuantityAndAvailability
    ISO20022.Semt004001.SubBalanceQuantity1Choice *-- ISO20022.Semt004001.GenericIdentification6
    ISO20022.Semt004001.SubBalanceQuantity1Choice *-- ISO20022.Semt004001.FinancialInstrumentQuantityChoice
    class ISO20022.Semt004001.TotalValueInPageAndStatement {
        + TtlHldgsValOfStmt  : ISO20022.Semt004001.ActiveCurrencyAndAmount
        + TtlHldgsValOfPg  : ISO20022.Semt004001.ActiveCurrencyAndAmount
    }
    ISO20022.Semt004001.TotalValueInPageAndStatement *-- ISO20022.Semt004001.ActiveCurrencyAndAmount
    ISO20022.Semt004001.TotalValueInPageAndStatement *-- ISO20022.Semt004001.ActiveCurrencyAndAmount
    class ISO20022.Semt004001.TypeOfPrice11Code {
        INDC = 1
        MRKT = 2
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

## Value ISO20022.Semt004001.Account7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt004001.PartyIdentification2Choice||XmlElement()||
|+|Id|ISO20022.Semt004001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt004001.AccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt004001.SimpleIdentificationInformation||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt004001.AccountIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|ISO20022.Semt004001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Inf""",Inf,"""[a-zA-Z0-9]{4}"""),validElement(Id))|

---

## Value ISO20022.Semt004001.AccountIdentificationAndPurpose


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|String||XmlElement()||
|+|Id|ISO20022.Semt004001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Semt004001.AccountIdentificationFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdAsDSS|ISO20022.Semt004001.AccountIdentification3||XmlElement()||
|+|IdAndPurp|ISO20022.Semt004001.AccountIdentificationAndPurpose||XmlElement()||
|+|SmplId|ISO20022.Semt004001.AccountIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdAsDSS),validElement(IdAndPurp),validElement(SmplId),validChoice(IdAsDSS,IdAndPurp,SmplId))|

---

## Value ISO20022.Semt004001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt004001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt004001.AdditionalBalanceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedSubBalTp|String||XmlElement()||
|+|SubBalTp|String||XmlElement()||
|+|Qty|ISO20022.Semt004001.SubBalanceQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validChoice(XtndedSubBalTp,SubBalTp,Qty))|

---

## Value ISO20022.Semt004001.AdditionalReference2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Semt004001.PartyIdentification1Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Semt004001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt004001.AggregateBalanceInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalAtSfkpgPlc|global::System.Collections.Generic.List<ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3>||XmlElement()||
|+|AddtlBalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.AdditionalBalanceInformation2>||XmlElement()||
|+|BalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.SubBalanceInformation2>||XmlElement()||
|+|FXDtls|ISO20022.Semt004001.ForeignExchangeTerms6||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.PriceInformation2>||XmlElement()||
|+|FinInstrmDtls|ISO20022.Semt004001.FinancialInstrument13||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt004001.SafekeepingPlaceFormatChoice||XmlElement()||
|+|BookVal|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmtSgn|String||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrvsHldgVal|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|HldgVal|global::System.Collections.Generic.List<ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|NotAvlblQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
|+|AvlblQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
|+|AggtQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BalAtSfkpgPlc""",BalAtSfkpgPlc),validElement(BalAtSfkpgPlc),validList("""AddtlBalBrkdwnDtls""",AddtlBalBrkdwnDtls),validElement(AddtlBalBrkdwnDtls),validList("""BalBrkdwnDtls""",BalBrkdwnDtls),validElement(BalBrkdwnDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(FinInstrmDtls),validElement(SfkpgPlc),validElement(BookVal),validElement(AcrdIntrstAmt),validElement(PrvsHldgVal),validList("""HldgVal""",HldgVal),validElement(HldgVal),validElement(NotAvlblQty),validElement(AvlblQty),validElement(AggtQty))|

---

## Value ISO20022.Semt004001.AggregateBalancePerSafekeepingPlace3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.AdditionalBalanceInformation2>||XmlElement()||
|+|BalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.SubBalanceInformation2>||XmlElement()||
|+|FXDtls|ISO20022.Semt004001.ForeignExchangeTerms6||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.PriceInformation2>||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt004001.SafekeepingPlaceFormatChoice||XmlElement()||
|+|BookVal|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmtSgn|String||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrvsHldgVal|ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|HldgVal|global::System.Collections.Generic.List<ISO20022.Semt004001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|NotAvlblQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
|+|AvlblQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
|+|AggtQty|ISO20022.Semt004001.BalanceQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlBalBrkdwnDtls""",AddtlBalBrkdwnDtls),validElement(AddtlBalBrkdwnDtls),validList("""BalBrkdwnDtls""",BalBrkdwnDtls),validElement(BalBrkdwnDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(SfkpgPlc),validElement(BookVal),validElement(AcrdIntrstAmt),validElement(PrvsHldgVal),validList("""HldgVal""",HldgVal),validElement(HldgVal),validElement(NotAvlblQty),validElement(AvlblQty),validElement(AggtQty))|

---

## Value ISO20022.Semt004001.AlternateSecurityIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Semt004001.BalanceQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAsDSS|ISO20022.Semt004001.GenericIdentification6||XmlElement()||
|+|Qty|ISO20022.Semt004001.FinancialInstrumentQuantityChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyAsDSS),validElement(Qty),validChoice(QtyAsDSS,Qty))|

---

## Value ISO20022.Semt004001.CustodyStatementOfHoldings2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Semt004001.Extension1>||XmlElement()||
|+|TtlVals|ISO20022.Semt004001.TotalValueInPageAndStatement||XmlElement()||
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.SubAccountIdentification5>||XmlElement()||
|+|BalForAcct|global::System.Collections.Generic.List<ISO20022.Semt004001.AggregateBalanceInformation4>||XmlElement()||
|+|AcctDtls|ISO20022.Semt004001.SafekeepingAccount2||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt004001.Statement7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(TtlVals),validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""BalForAcct""",BalForAcct),validElement(BalForAcct),validElement(AcctDtls),validElement(StmtGnlDtls))|

---

## Aspect ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtToBeCanc|ISO20022.Semt004001.CustodyStatementOfHoldings2||XmlElement()||
|+|MsgPgntn|ISO20022.Semt004001.Pagination||XmlElement()||
|+|RltdRef|ISO20022.Semt004001.AdditionalReference2||XmlElement()||
|+|PrvsRef|ISO20022.Semt004001.AdditionalReference2||XmlElement()||
|+|MsgId|ISO20022.Semt004001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtToBeCanc),validElement(MsgPgntn),validElement(RltdRef),validElement(PrvsRef),validElement(MsgId))|

---

## Value ISO20022.Semt004001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Semt004001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtdyStmtOfHldgsCxlV02|ISO20022.Semt004001.CustodyStatementOfHoldingsCancellationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtdyStmtOfHldgsCxlV02))|

---

## Enum ISO20022.Semt004001.EventFrequency1Code


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

## Value ISO20022.Semt004001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt004001.FinancialInstrument13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Semt004001.SecurityIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Semt004001.FinancialInstrumentQuantityChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt004001.ForeignExchangeTerms6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Semt004001.PartyIdentification2Choice||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt004001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrqcyAsDSS|ISO20022.Semt004001.GenericIdentification7||XmlElement()||
|+|FrqcyAsCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrqcyAsDSS),validChoice(FrqcyAsDSS,FrqcyAsCd))|

---

## Value ISO20022.Semt004001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt004001.GenericIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Inf""",Inf,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt004001.GenericIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Inf""",Inf,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt004001.GenericIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt004001.Intermediary11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedRole|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|Acct|ISO20022.Semt004001.Account7||XmlElement()||
|+|Id|ISO20022.Semt004001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(Id),validChoice(XtndedRole,Role,Acct,Id))|

---

## Enum ISO20022.Semt004001.InvestmentFundRole2Code


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

## Value ISO20022.Semt004001.LongPostalAddress1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|ISO20022.Semt004001.StructuredLongPostalAddress1||XmlElement()||
|+|Ustrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Strd),validChoice(Strd,Ustrd))|

---

## Value ISO20022.Semt004001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt004001.NameAndAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt004001.LongPostalAddress1Choice||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt004001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt004001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt004001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt004001.PartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt004001.NameAndAddress2||XmlElement()||
|+|PrtryId|ISO20022.Semt004001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Semt004001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt004001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt004001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Semt004001.PartyIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt004001.PostalAddress1


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

## Value ISO20022.Semt004001.PriceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Yldd|String||XmlElement()||
|+|QtnDt|ISO20022.Semt004001.DateAndDateTimeChoice||XmlElement()||
|+|SrcOfPric|ISO20022.Semt004001.PriceSourceFormatChoice||XmlElement()||
|+|XtndedTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|ValTp|String||XmlElement()||
|+|Val|ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtnDt),validElement(SrcOfPric),validElement(Val),validChoice(Yldd,QtnDt,SrcOfPric,XtndedTp,Tp,ValTp,Val))|

---

## Value ISO20022.Semt004001.PriceRateOrAmountOrUnknownChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|ISO20022.Semt004001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(UknwnInd,Amt,Rate))|

---

## Value ISO20022.Semt004001.PriceSource


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|PricSrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt004001.PriceSource1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||THEO|Int32||XmlEnum("""THEO""")|2|
||FUND|Int32||XmlEnum("""FUND""")|3|

---

## Value ISO20022.Semt004001.PriceSourceFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcAsDSS|ISO20022.Semt004001.GenericIdentification5||XmlElement()||
|+|NonLclMktPlc|ISO20022.Semt004001.PriceSource||XmlElement()||
|+|LclMktPlc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PlcAsDSS),validElement(NonLclMktPlc),validPattern("""LclMktPlc""",LclMktPlc,"""[A-Z0-9]{4,4}"""),validChoice(PlcAsDSS,NonLclMktPlc,LclMktPlc))|

---

## Enum ISO20022.Semt004001.PriceValueType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||DISC|Int32||XmlEnum("""DISC""")|2|

---

## Value ISO20022.Semt004001.QuantityAndAvailability


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlbtyInd|String||XmlElement()||
|+|Qty|ISO20022.Semt004001.FinancialInstrumentQuantityChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt004001.SafekeepingAccount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt004001.PartyIdentification2Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Semt004001.PartyIdentification2Choice||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt004001.Intermediary11>||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|FngbInd|String||XmlElement()||
|+|Id|ISO20022.Semt004001.AccountIdentificationFormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(AcctOwnr),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(Id))|

---

## Enum ISO20022.Semt004001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Value ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|ISO20022.Semt004001.PartyIdentification3||XmlElement()||
|+|Nrrtv|String||XmlElement()||
|+|PlcSfkpg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty))|

---

## Value ISO20022.Semt004001.SafekeepingPlaceFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdAsCtry|String||XmlElement()||
|+|IdAsDSS|ISO20022.Semt004001.GenericIdentification5||XmlElement()||
|+|Id|ISO20022.Semt004001.SafekeepingPlaceAsCodeAndPartyIdentification||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IdAsCtry""",IdAsCtry,"""[A-Z]{2,2}"""),validElement(IdAsDSS),validElement(Id),validChoice(IdAsCtry,IdAsDSS,Id))|

---

## Enum ISO20022.Semt004001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Enum ISO20022.Semt004001.SecuritiesBalanceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BTRA|Int32||XmlEnum("""BTRA""")|1|
||WDOC|Int32||XmlEnum("""WDOC""")|2|
||DRAW|Int32||XmlEnum("""DRAW""")|3|
||TRAN|Int32||XmlEnum("""TRAN""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||RSTR|Int32||XmlEnum("""RSTR""")|6|
||REGO|Int32||XmlEnum("""REGO""")|7|
||PDUM|Int32||XmlEnum("""PDUM""")|8|
||PLED|Int32||XmlEnum("""PLED""")|9|
||PENR|Int32||XmlEnum("""PENR""")|10|
||PEND|Int32||XmlEnum("""PEND""")|11|
||PECA|Int32||XmlEnum("""PECA""")|12|
||PRUM|Int32||XmlEnum("""PRUM""")|13|
||PRMT|Int32||XmlEnum("""PRMT""")|14|
||PDMT|Int32||XmlEnum("""PDMT""")|15|
||MARG|Int32||XmlEnum("""MARG""")|16|
||LOAN|Int32||XmlEnum("""LOAN""")|17|
||COLO|Int32||XmlEnum("""COLO""")|18|
||COLI|Int32||XmlEnum("""COLI""")|19|
||BORR|Int32||XmlEnum("""BORR""")|20|
||BLOK|Int32||XmlEnum("""BLOK""")|21|

---

## Enum ISO20022.Semt004001.SecuritiesBalanceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNRG|Int32||XmlEnum("""UNRG""")|1|
||SPOS|Int32||XmlEnum("""SPOS""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||NOMI|Int32||XmlEnum("""NOMI""")|4|
||DIRT|Int32||XmlEnum("""DIRT""")|5|
||CLEN|Int32||XmlEnum("""CLEN""")|6|

---

## Value ISO20022.Semt004001.SecurityIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Semt004001.AlternateSecurityIdentification1||XmlElement()||
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

## Value ISO20022.Semt004001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt004001.Statement7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptNb|String||XmlElement()||
|+|StmtBsis|ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice||XmlElement()||
|+|Frqcy|ISO20022.Semt004001.FrequencyCodeAndDSSCode1Choice||XmlElement()||
|+|CreDtTm|ISO20022.Semt004001.DateAndDateTimeChoice||XmlElement()||
|+|StmtDtTm|ISO20022.Semt004001.DateAndDateTimeChoice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RptNb""",RptNb,"""[0-9]{1,5}"""),validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(CreDtTm),validElement(StmtDtTm))|

---

## Enum ISO20022.Semt004001.StatementBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|
||CONT|Int32||XmlEnum("""CONT""")|3|

---

## Value ISO20022.Semt004001.StatementBasisCodeAndDSSCodeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtBsisAsDSS|ISO20022.Semt004001.GenericIdentification7||XmlElement()||
|+|StmtBsisAsCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsisAsDSS),validChoice(StmtBsisAsDSS,StmtBsisAsCd))|

---

## Enum ISO20022.Semt004001.StatementUpdateTypeCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt004001.StatementUpdateTypeCodeAndDSSCodeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtUpdTpAsDSS|ISO20022.Semt004001.GenericIdentification7||XmlElement()||
|+|StmtUpdTpAsCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtUpdTpAsDSS),validChoice(StmtUpdTpAsDSS,StmtUpdTpAsCd))|

---

## Value ISO20022.Semt004001.StructuredLongPostalAddress1


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

## Value ISO20022.Semt004001.SubAccountIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalForSubAcct|global::System.Collections.Generic.List<ISO20022.Semt004001.AggregateBalanceInformation4>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|FngbInd|String||XmlElement()||
|+|Id|ISO20022.Semt004001.AccountIdentificationFormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BalForSubAcct""",BalForSubAcct),validElement(BalForSubAcct),validElement(Id))|

---

## Value ISO20022.Semt004001.SubBalanceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt004001.AdditionalBalanceInformation2>||XmlElement()||
|+|XtndedSubBalTp|String||XmlElement()||
|+|SubBalTp|String||XmlElement()||
|+|Qty|ISO20022.Semt004001.SubBalanceQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlBalBrkdwnDtls""",AddtlBalBrkdwnDtls),validElement(AddtlBalBrkdwnDtls),validElement(Qty),validChoice(AddtlBalBrkdwnDtls,XtndedSubBalTp,SubBalTp,Qty))|

---

## Value ISO20022.Semt004001.SubBalanceQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAndAvlbty|ISO20022.Semt004001.QuantityAndAvailability||XmlElement()||
|+|QtyAsDSS|ISO20022.Semt004001.GenericIdentification6||XmlElement()||
|+|Qty|ISO20022.Semt004001.FinancialInstrumentQuantityChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyAndAvlbty),validElement(QtyAsDSS),validElement(Qty),validChoice(QtyAndAvlbty,QtyAsDSS,Qty))|

---

## Value ISO20022.Semt004001.TotalValueInPageAndStatement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlHldgsValOfStmt|ISO20022.Semt004001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlHldgsValOfPg|ISO20022.Semt004001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlHldgsValOfStmt),validElement(TtlHldgsValOfPg))|

---

## Enum ISO20022.Semt004001.TypeOfPrice11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDC|Int32||XmlEnum("""INDC""")|1|
||MRKT|Int32||XmlEnum("""MRKT""")|2|
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

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

