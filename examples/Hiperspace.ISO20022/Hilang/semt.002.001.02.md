# semt.002.001.02
```mermaid
classDiagram
    class Semt002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class Semt002001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class Semt002001.EventFrequency1Code {
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
    class Semt002001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class Semt002001.InvestmentFundRole2Code {
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
    class Semt002001.PriceSource1Code {
        VEND = 1
        THEO = 2
        FUND = 3
    }
    class Semt002001.PriceValueType2Code {
        PREM = 1
        DISC = 2
    }
    class Semt002001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class Semt002001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class Semt002001.SecuritiesBalanceType1Code {
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
    class Semt002001.SecuritiesBalanceType2Code {
        UNRG = 1
        SPOS = 2
        OTHR = 3
        NOMI = 4
        DIRT = 5
        CLEN = 6
    }
    class Semt002001.StatementBasis1Code {
        TRAD = 1
        SETT = 2
        CONT = 3
    }
    class Semt002001.StatementUpdateTypeCode {
        DELT = 1
        COMP = 2
    }
    class Semt002001.TypeOfPrice11Code {
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
    class Semt002001.Account7 {
        + AcctSvcr  : Semt002001.PartyIdentification2Choice
        + Id  : Semt002001.AccountIdentification1
        + ValidElement_AcctSvcr () = validElement(AcctSvcr)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_AcctSvcr,ValidElement_Id)
    }
    class Semt002001.AccountIdentification1 {
        + Prtry  : Semt002001.SimpleIdentificationInformation
        + ValidElement_Prtry () = validElement(Prtry)
        + Validation () = validation(ValidElement_Prtry)
    }
    class Semt002001.AccountIdentification3 {
        + Inf  : String
        + Issr  : String
        + Id  : Semt002001.AccountIdentification1
        + ValidPattern_Inf () = validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidPattern_Inf,ValidElement_Id)
    }
    class Semt002001.AccountIdentificationAndPurpose {
        + Purp  : String
        + Id  : Semt002001.AccountIdentification1
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_Id)
    }
    class Semt002001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
        + ValidRequired_Value () = validRequired("Value",Value)
        + ValidRequired_Ccy () = validRequired("Ccy",Ccy)
        + ValidPattern_Ccy () = validPattern("Ccy",Ccy,"[A-Z]{3,3}")
        + Validation () = validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)
    }
    class Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
        + ValidRequired_Value () = validRequired("Value",Value)
        + ValidRequired_Ccy () = validRequired("Ccy",Ccy)
        + ValidPattern_Ccy () = validPattern("Ccy",Ccy,"[A-Z]{3,3}")
        + Validation () = validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)
    }
    class Semt002001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
        + ValidRequired_Value () = validRequired("Value",Value)
        + ValidRequired_Ccy () = validRequired("Ccy",Ccy)
        + ValidPattern_Ccy () = validPattern("Ccy",Ccy,"[A-Z]{3,3}")
        + Validation () = validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)
    }
    class Semt002001.AdditionalReference2 {
        + MsgNm  : String
        + RefIssr  : Semt002001.PartyIdentification1Choice
        + Ref  : String
        + ValidElement_RefIssr () = validElement(RefIssr)
        + Validation () = validation(ValidElement_RefIssr)
    }
    class Semt002001.AggregateBalanceInformation4 {
        + BalAtSfkpgPlc  : List~Semt002001.AggregateBalancePerSafekeepingPlace3~
        + AddtlBalBrkdwnDtls  : List~Semt002001.AdditionalBalanceInformation2~
        + BalBrkdwnDtls  : List~Semt002001.SubBalanceInformation2~
        + FXDtls  : Semt002001.ForeignExchangeTerms6
        + PricDtls  : List~Semt002001.PriceInformation2~
        + FinInstrmDtls  : Semt002001.FinancialInstrument13
        + SfkpgPlc  : Semt002001.SafekeepingPlaceFormatChoice
        + BookVal  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + AcrdIntrstAmtSgn  : String
        + AcrdIntrstAmt  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + PrvsHldgVal  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + HldgVal  : List~Semt002001.ActiveOrHistoricCurrencyAndAmount~
        + DaysAcrd  : Decimal
        + NotAvlblQty  : Semt002001.BalanceQuantity1Choice
        + AvlblQty  : Semt002001.BalanceQuantity1Choice
        + AggtQty  : Semt002001.BalanceQuantity1Choice
        + ValidList_BalAtSfkpgPlc () = validList("BalAtSfkpgPlc",BalAtSfkpgPlc)
        + ValidElement_BalAtSfkpgPlc () = validElement(BalAtSfkpgPlc)
        + ValidList_AddtlBalBrkdwnDtls () = validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)
        + ValidElement_AddtlBalBrkdwnDtls () = validElement(AddtlBalBrkdwnDtls)
        + ValidList_BalBrkdwnDtls () = validList("BalBrkdwnDtls",BalBrkdwnDtls)
        + ValidElement_BalBrkdwnDtls () = validElement(BalBrkdwnDtls)
        + ValidElement_FXDtls () = validElement(FXDtls)
        + ValidList_PricDtls () = validList("PricDtls",PricDtls)
        + ValidElement_PricDtls () = validElement(PricDtls)
        + ValidElement_FinInstrmDtls () = validElement(FinInstrmDtls)
        + ValidElement_SfkpgPlc () = validElement(SfkpgPlc)
        + ValidElement_BookVal () = validElement(BookVal)
        + ValidElement_AcrdIntrstAmt () = validElement(AcrdIntrstAmt)
        + ValidElement_PrvsHldgVal () = validElement(PrvsHldgVal)
        + ValidList_HldgVal () = validList("HldgVal",HldgVal)
        + ValidElement_HldgVal () = validElement(HldgVal)
        + ValidElement_NotAvlblQty () = validElement(NotAvlblQty)
        + ValidElement_AvlblQty () = validElement(AvlblQty)
        + ValidElement_AggtQty () = validElement(AggtQty)
        + Validation () = validation(ValidList_BalAtSfkpgPlc,ValidElement_BalAtSfkpgPlc,ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidList_BalBrkdwnDtls,ValidElement_BalBrkdwnDtls,ValidElement_FXDtls,ValidList_PricDtls,ValidElement_PricDtls,ValidElement_FinInstrmDtls,ValidElement_SfkpgPlc,ValidElement_BookVal,ValidElement_AcrdIntrstAmt,ValidElement_PrvsHldgVal,ValidList_HldgVal,ValidElement_HldgVal,ValidElement_NotAvlblQty,ValidElement_AvlblQty,ValidElement_AggtQty)
    }
    class Semt002001.AggregateBalancePerSafekeepingPlace3 {
        + AddtlBalBrkdwnDtls  : List~Semt002001.AdditionalBalanceInformation2~
        + BalBrkdwnDtls  : List~Semt002001.SubBalanceInformation2~
        + FXDtls  : Semt002001.ForeignExchangeTerms6
        + PricDtls  : List~Semt002001.PriceInformation2~
        + SfkpgPlc  : Semt002001.SafekeepingPlaceFormatChoice
        + BookVal  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + AcrdIntrstAmtSgn  : String
        + AcrdIntrstAmt  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + PrvsHldgVal  : Semt002001.ActiveOrHistoricCurrencyAndAmount
        + HldgVal  : List~Semt002001.ActiveOrHistoricCurrencyAndAmount~
        + DaysAcrd  : Decimal
        + NotAvlblQty  : Semt002001.BalanceQuantity1Choice
        + AvlblQty  : Semt002001.BalanceQuantity1Choice
        + AggtQty  : Semt002001.BalanceQuantity1Choice
        + ValidList_AddtlBalBrkdwnDtls () = validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)
        + ValidElement_AddtlBalBrkdwnDtls () = validElement(AddtlBalBrkdwnDtls)
        + ValidList_BalBrkdwnDtls () = validList("BalBrkdwnDtls",BalBrkdwnDtls)
        + ValidElement_BalBrkdwnDtls () = validElement(BalBrkdwnDtls)
        + ValidElement_FXDtls () = validElement(FXDtls)
        + ValidList_PricDtls () = validList("PricDtls",PricDtls)
        + ValidElement_PricDtls () = validElement(PricDtls)
        + ValidElement_SfkpgPlc () = validElement(SfkpgPlc)
        + ValidElement_BookVal () = validElement(BookVal)
        + ValidElement_AcrdIntrstAmt () = validElement(AcrdIntrstAmt)
        + ValidElement_PrvsHldgVal () = validElement(PrvsHldgVal)
        + ValidList_HldgVal () = validList("HldgVal",HldgVal)
        + ValidElement_HldgVal () = validElement(HldgVal)
        + ValidElement_NotAvlblQty () = validElement(NotAvlblQty)
        + ValidElement_AvlblQty () = validElement(AvlblQty)
        + ValidElement_AggtQty () = validElement(AggtQty)
        + Validation () = validation(ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidList_BalBrkdwnDtls,ValidElement_BalBrkdwnDtls,ValidElement_FXDtls,ValidList_PricDtls,ValidElement_PricDtls,ValidElement_SfkpgPlc,ValidElement_BookVal,ValidElement_AcrdIntrstAmt,ValidElement_PrvsHldgVal,ValidList_HldgVal,ValidElement_HldgVal,ValidElement_NotAvlblQty,ValidElement_AvlblQty,ValidElement_AggtQty)
    }
    class Semt002001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
        + Validation () = ""
    }
    class Semt002001.FinancialInstrument13 {
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + Nm  : String
        + Id  : Semt002001.SecurityIdentification3Choice
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_Id)
    }
    class Semt002001.ForeignExchangeTerms6 {
        + QtgInstn  : Semt002001.PartyIdentification2Choice
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
        + ValidElement_QtgInstn () = validElement(QtgInstn)
        + ValidPattern_QtdCcy () = validPattern("QtdCcy",QtdCcy,"[A-Z]{3,3}")
        + ValidPattern_UnitCcy () = validPattern("UnitCcy",UnitCcy,"[A-Z]{3,3}")
        + Validation () = validation(ValidElement_QtgInstn,ValidPattern_QtdCcy,ValidPattern_UnitCcy)
    }
    class Semt002001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
        + Validation () = ""
    }
    class Semt002001.GenericIdentification5 {
        + Nrrtv  : String
        + Inf  : String
        + Issr  : String
        + ValidPattern_Inf () = validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")
        + Validation () = validation(ValidPattern_Inf)
    }
    class Semt002001.GenericIdentification6 {
        + Bal  : Decimal
        + Inf  : String
        + Issr  : String
        + ValidPattern_Inf () = validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")
        + Validation () = validation(ValidPattern_Inf)
    }
    class Semt002001.GenericIdentification7 {
        + Inf  : String
        + Issr  : String
        + Validation () = ""
    }
    class Semt002001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
        + Validation () = ""
    }
    class Semt002001.NameAndAddress2 {
        + Adr  : Semt002001.LongPostalAddress1Choice
        + Nm  : String
        + ValidElement_Adr () = validElement(Adr)
        + Validation () = validation(ValidElement_Adr)
    }
    class Semt002001.NameAndAddress5 {
        + Adr  : Semt002001.PostalAddress1
        + Nm  : String
        + ValidElement_Adr () = validElement(Adr)
        + Validation () = validation(ValidElement_Adr)
    }
    class Semt002001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
        + ValidPattern_PgNb () = validPattern("PgNb",PgNb,"[0-9]{1,5}")
        + Validation () = validation(ValidPattern_PgNb)
    }
    class Semt002001.PartyIdentification3 {
        + BICOrBEI  : String
        + ValidPattern_BICOrBEI () = validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidPattern_BICOrBEI)
    }
    class Semt002001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : List~String~
        + AdrTp  : String
        + ValidPattern_Ctry () = validPattern("Ctry",Ctry,"[A-Z]{2,2}")
        + ValidListMax_AdrLine () = validListMax("AdrLine",AdrLine,5)
        + Validation () = validation(ValidPattern_Ctry,ValidListMax_AdrLine)
    }
    class Semt002001.PriceSource {
        + Nrrtv  : String
        + PricSrc  : String
        + Validation () = ""
    }
    class Semt002001.QuantityAndAvailability {
        + AvlbtyInd  : String
        + Qty  : Semt002001.FinancialInstrumentQuantityChoice
        + ValidElement_Qty () = validElement(Qty)
        + Validation () = validation(ValidElement_Qty)
    }
    class Semt002001.SafekeepingAccount2 {
        + AcctSvcr  : Semt002001.PartyIdentification2Choice
        + AcctOwnr  : Semt002001.PartyIdentification2Choice
        + IntrmyInf  : List~Semt002001.Intermediary11~
        + Dsgnt  : String
        + Nm  : String
        + FngbInd  : String
        + Id  : Semt002001.AccountIdentificationFormatChoice
        + ValidElement_AcctSvcr () = validElement(AcctSvcr)
        + ValidElement_AcctOwnr () = validElement(AcctOwnr)
        + ValidList_IntrmyInf () = validList("IntrmyInf",IntrmyInf)
        + ValidListMax_IntrmyInf () = validListMax("IntrmyInf",IntrmyInf,10)
        + ValidElement_IntrmyInf () = validElement(IntrmyInf)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_AcctSvcr,ValidElement_AcctOwnr,ValidList_IntrmyInf,ValidListMax_IntrmyInf,ValidElement_IntrmyInf,ValidElement_Id)
    }
    class Semt002001.SafekeepingPlaceAsCodeAndPartyIdentification {
        + Pty  : Semt002001.PartyIdentification3
        + Nrrtv  : String
        + PlcSfkpg  : String
        + ValidElement_Pty () = validElement(Pty)
        + Validation () = validation(ValidElement_Pty)
    }
    class Semt002001.SimpleIdentificationInformation {
        + Id  : String
        + Validation () = ""
    }
    class Semt002001.Statement7 {
        + RptNb  : String
        + StmtBsis  : Semt002001.StatementBasisCodeAndDSSCodeChoice
        + ActvtyInd  : String
        + UpdTp  : Semt002001.StatementUpdateTypeCodeAndDSSCodeChoice
        + Frqcy  : Semt002001.FrequencyCodeAndDSSCode1Choice
        + CreDtTm  : Semt002001.DateAndDateTimeChoice
        + StmtDtTm  : Semt002001.DateAndDateTimeChoice
        + Ref  : String
        + ValidPattern_RptNb () = validPattern("RptNb",RptNb,"[0-9]{1,5}")
        + ValidElement_StmtBsis () = validElement(StmtBsis)
        + ValidElement_UpdTp () = validElement(UpdTp)
        + ValidElement_Frqcy () = validElement(Frqcy)
        + ValidElement_CreDtTm () = validElement(CreDtTm)
        + ValidElement_StmtDtTm () = validElement(StmtDtTm)
        + Validation () = validation(ValidPattern_RptNb,ValidElement_StmtBsis,ValidElement_UpdTp,ValidElement_Frqcy,ValidElement_CreDtTm,ValidElement_StmtDtTm)
    }
    class Semt002001.StructuredLongPostalAddress1 {
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
        + ValidPattern_Ctry () = validPattern("Ctry",Ctry,"[A-Z]{2,2}")
        + Validation () = validation(ValidPattern_Ctry)
    }
    class Semt002001.SubAccountIdentification5 {
        + BalForSubAcct  : List~Semt002001.AggregateBalanceInformation4~
        + ActvtyInd  : String
        + FngbInd  : String
        + Id  : Semt002001.AccountIdentificationFormatChoice
        + ValidList_BalForSubAcct () = validList("BalForSubAcct",BalForSubAcct)
        + ValidElement_BalForSubAcct () = validElement(BalForSubAcct)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidList_BalForSubAcct,ValidElement_BalForSubAcct,ValidElement_Id)
    }
    class Semt002001.TotalValueInPageAndStatement {
        + TtlHldgsValOfStmt  : Semt002001.ActiveCurrencyAndAmount
        + TtlHldgsValOfPg  : Semt002001.ActiveCurrencyAndAmount
        + ValidElement_TtlHldgsValOfStmt () = validElement(TtlHldgsValOfStmt)
        + ValidElement_TtlHldgsValOfPg () = validElement(TtlHldgsValOfPg)
        + Validation () = validation(ValidElement_TtlHldgsValOfStmt,ValidElement_TtlHldgsValOfPg)
    }
    class Semt002001.Document {
        # Uri  : String
        + CtdyStmtOfHldgsV02 () : Semt002001.CustodyStatementOfHoldingsV02
        + ValidElement_CtdyStmtOfHldgsV02 () = validElement(CtdyStmtOfHldgsV02)
        + Validation () = validation(ValidElement_CtdyStmtOfHldgsV02)
    }
    class Semt002001.CustodyStatementOfHoldingsV02 {
        + Xtnsn  : List~Semt002001.Extension1~
        + TtlVals  : Semt002001.TotalValueInPageAndStatement
        + SubAcctDtls  : List~Semt002001.SubAccountIdentification5~
        + BalForAcct  : List~Semt002001.AggregateBalanceInformation4~
        + AcctDtls  : Semt002001.SafekeepingAccount2
        + StmtGnlDtls  : Semt002001.Statement7
        + MsgPgntn  : Semt002001.Pagination
        + RltdRef  : List~Semt002001.AdditionalReference2~
        + PrvsRef  : List~Semt002001.AdditionalReference2~
        + MsgId  : Semt002001.MessageIdentification1
        + ValidList_Xtnsn () = validList("Xtnsn",Xtnsn)
        + ValidElement_Xtnsn () = validElement(Xtnsn)
        + ValidElement_TtlVals () = validElement(TtlVals)
        + ValidList_SubAcctDtls () = validList("SubAcctDtls",SubAcctDtls)
        + ValidElement_SubAcctDtls () = validElement(SubAcctDtls)
        + ValidList_BalForAcct () = validList("BalForAcct",BalForAcct)
        + ValidElement_BalForAcct () = validElement(BalForAcct)
        + ValidElement_AcctDtls () = validElement(AcctDtls)
        + ValidElement_StmtGnlDtls () = validElement(StmtGnlDtls)
        + ValidElement_MsgPgntn () = validElement(MsgPgntn)
        + ValidList_RltdRef () = validList("RltdRef",RltdRef)
        + ValidElement_RltdRef () = validElement(RltdRef)
        + ValidList_PrvsRef () = validList("PrvsRef",PrvsRef)
        + ValidElement_PrvsRef () = validElement(PrvsRef)
        + ValidElement_MsgId () = validElement(MsgId)
        + Validation () = validation(ValidList_Xtnsn,ValidElement_Xtnsn,ValidElement_TtlVals,ValidList_SubAcctDtls,ValidElement_SubAcctDtls,ValidList_BalForAcct,ValidElement_BalForAcct,ValidElement_AcctDtls,ValidElement_StmtGnlDtls,ValidElement_MsgPgntn,ValidList_RltdRef,ValidElement_RltdRef,ValidList_PrvsRef,ValidElement_PrvsRef,ValidElement_MsgId)
    }
    class Semt002001.AccountIdentificationFormatChoice {
        + IdAsDSS  : Semt002001.AccountIdentification3
        + IdAndPurp  : Semt002001.AccountIdentificationAndPurpose
        + SmplId  : Semt002001.AccountIdentification1
        + ValidChoice () = validChoice(IdAsDSS,IdAndPurp,SmplId)
        + ValidElement_IdAsDSS () = validElement(IdAsDSS)
        + ValidElement_IdAndPurp () = validElement(IdAndPurp)
        + ValidElement_SmplId () = validElement(SmplId)
        + Validation () = validation(ValidElement_IdAsDSS,ValidElement_IdAndPurp,ValidElement_SmplId,ValidChoice)
    }
    class Semt002001.AdditionalBalanceInformation2 {
        + XtndedSubBalTp  : String
        + SubBalTp  : String
        + Qty  : Semt002001.SubBalanceQuantity1Choice
        + ValidChoice () = validChoice(XtndedSubBalTp,SubBalTp,Qty)
        + ValidElement_Qty () = validElement(Qty)
        + Validation () = validation(ValidElement_Qty,ValidChoice)
    }
    class Semt002001.AlternateSecurityIdentification1 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
        + ValidChoice () = validChoice(PrtryIdSrc,DmstIdSrc,Id)
        + ValidPattern_DmstIdSrc () = validPattern("DmstIdSrc",DmstIdSrc,"[A-Z]{2,2}")
        + Validation () = validation(ValidPattern_DmstIdSrc,ValidChoice)
    }
    class Semt002001.BalanceQuantity1Choice {
        + QtyAsDSS  : Semt002001.GenericIdentification6
        + Qty  : Semt002001.FinancialInstrumentQuantityChoice
        + ValidChoice () = validChoice(QtyAsDSS,Qty)
        + ValidElement_QtyAsDSS () = validElement(QtyAsDSS)
        + ValidElement_Qty () = validElement(Qty)
        + Validation () = validation(ValidElement_QtyAsDSS,ValidElement_Qty,ValidChoice)
    }
    class Semt002001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
        + ValidChoice () = validChoice(DtTm,Dt)
        + Validation () = validation(ValidChoice)
    }
    class Semt002001.FinancialInstrumentQuantityChoice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
        + ValidChoice () = validChoice(AmtsdVal,FaceAmt,Unit)
        + Validation () = validation(ValidChoice)
    }
    class Semt002001.FrequencyCodeAndDSSCode1Choice {
        + FrqcyAsDSS  : Semt002001.GenericIdentification7
        + FrqcyAsCd  : String
        + ValidChoice () = validChoice(FrqcyAsDSS,FrqcyAsCd)
        + ValidElement_FrqcyAsDSS () = validElement(FrqcyAsDSS)
        + Validation () = validation(ValidElement_FrqcyAsDSS,ValidChoice)
    }
    class Semt002001.Intermediary11 {
        + XtndedRole  : String
        + Role  : String
        + Acct  : Semt002001.Account7
        + Id  : Semt002001.PartyIdentification2Choice
        + ValidChoice () = validChoice(XtndedRole,Role,Acct,Id)
        + ValidElement_Acct () = validElement(Acct)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_Acct,ValidElement_Id,ValidChoice)
    }
    class Semt002001.LongPostalAddress1Choice {
        + Strd  : Semt002001.StructuredLongPostalAddress1
        + Ustrd  : String
        + ValidChoice () = validChoice(Strd,Ustrd)
        + ValidElement_Strd () = validElement(Strd)
        + Validation () = validation(ValidElement_Strd,ValidChoice)
    }
    class Semt002001.PartyIdentification1Choice {
        + NmAndAdr  : Semt002001.NameAndAddress2
        + PrtryId  : Semt002001.GenericIdentification1
        + BICOrBEI  : String
        + ValidChoice () = validChoice(NmAndAdr,PrtryId,BICOrBEI)
        + ValidElement_NmAndAdr () = validElement(NmAndAdr)
        + ValidElement_PrtryId () = validElement(PrtryId)
        + ValidPattern_BICOrBEI () = validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)
    }
    class Semt002001.PartyIdentification2Choice {
        + NmAndAdr  : Semt002001.NameAndAddress5
        + PrtryId  : Semt002001.GenericIdentification1
        + BICOrBEI  : String
        + ValidChoice () = validChoice(NmAndAdr,PrtryId,BICOrBEI)
        + ValidElement_NmAndAdr () = validElement(NmAndAdr)
        + ValidElement_PrtryId () = validElement(PrtryId)
        + ValidPattern_BICOrBEI () = validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)
    }
    class Semt002001.PriceInformation2 {
        + Yldd  : String
        + QtnDt  : Semt002001.DateAndDateTimeChoice
        + SrcOfPric  : Semt002001.PriceSourceFormatChoice
        + XtndedTp  : String
        + Tp  : String
        + ValTp  : String
        + Val  : Semt002001.PriceRateOrAmountOrUnknownChoice
        + ValidChoice () = validChoice(Yldd,QtnDt,SrcOfPric,XtndedTp,Tp,ValTp,Val)
        + ValidElement_QtnDt () = validElement(QtnDt)
        + ValidElement_SrcOfPric () = validElement(SrcOfPric)
        + ValidElement_Val () = validElement(Val)
        + Validation () = validation(ValidElement_QtnDt,ValidElement_SrcOfPric,ValidElement_Val,ValidChoice)
    }
    class Semt002001.PriceRateOrAmountOrUnknownChoice {
        + UknwnInd  : String
        + Amt  : Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
        + ValidChoice () = validChoice(UknwnInd,Amt,Rate)
        + ValidElement_Amt () = validElement(Amt)
        + Validation () = validation(ValidElement_Amt,ValidChoice)
    }
    class Semt002001.PriceSourceFormatChoice {
        + PlcAsDSS  : Semt002001.GenericIdentification5
        + NonLclMktPlc  : Semt002001.PriceSource
        + LclMktPlc  : String
        + ValidChoice () = validChoice(PlcAsDSS,NonLclMktPlc,LclMktPlc)
        + ValidElement_PlcAsDSS () = validElement(PlcAsDSS)
        + ValidElement_NonLclMktPlc () = validElement(NonLclMktPlc)
        + ValidPattern_LclMktPlc () = validPattern("LclMktPlc",LclMktPlc,"[A-Z0-9]{4,4}")
        + Validation () = validation(ValidElement_PlcAsDSS,ValidElement_NonLclMktPlc,ValidPattern_LclMktPlc,ValidChoice)
    }
    class Semt002001.SafekeepingPlaceFormatChoice {
        + IdAsCtry  : String
        + IdAsDSS  : Semt002001.GenericIdentification5
        + Id  : Semt002001.SafekeepingPlaceAsCodeAndPartyIdentification
        + ValidChoice () = validChoice(IdAsCtry,IdAsDSS,Id)
        + ValidPattern_IdAsCtry () = validPattern("IdAsCtry",IdAsCtry,"[A-Z]{2,2}")
        + ValidElement_IdAsDSS () = validElement(IdAsDSS)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidPattern_IdAsCtry,ValidElement_IdAsDSS,ValidElement_Id,ValidChoice)
    }
    class Semt002001.SecurityIdentification3Choice {
        + OthrPrtryId  : Semt002001.AlternateSecurityIdentification1
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
        + ValidChoice () = validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN)
        + ValidElement_OthrPrtryId () = validElement(OthrPrtryId)
        + ValidPattern_ISIN () = validPattern("ISIN",ISIN,"[A-Z0-9]{12,12}")
        + Validation () = validation(ValidElement_OthrPrtryId,ValidPattern_ISIN,ValidChoice)
    }
    class Semt002001.StatementBasisCodeAndDSSCodeChoice {
        + StmtBsisAsDSS  : Semt002001.GenericIdentification7
        + StmtBsisAsCd  : String
        + ValidChoice () = validChoice(StmtBsisAsDSS,StmtBsisAsCd)
        + ValidElement_StmtBsisAsDSS () = validElement(StmtBsisAsDSS)
        + Validation () = validation(ValidElement_StmtBsisAsDSS,ValidChoice)
    }
    class Semt002001.StatementUpdateTypeCodeAndDSSCodeChoice {
        + StmtUpdTpAsDSS  : Semt002001.GenericIdentification7
        + StmtUpdTpAsCd  : String
        + ValidChoice () = validChoice(StmtUpdTpAsDSS,StmtUpdTpAsCd)
        + ValidElement_StmtUpdTpAsDSS () = validElement(StmtUpdTpAsDSS)
        + Validation () = validation(ValidElement_StmtUpdTpAsDSS,ValidChoice)
    }
    class Semt002001.SubBalanceInformation2 {
        + AddtlBalBrkdwnDtls  : List~Semt002001.AdditionalBalanceInformation2~
        + XtndedSubBalTp  : String
        + SubBalTp  : String
        + Qty  : Semt002001.SubBalanceQuantity1Choice
        + ValidChoice () = validChoice(AddtlBalBrkdwnDtls,XtndedSubBalTp,SubBalTp,Qty)
        + ValidList_AddtlBalBrkdwnDtls () = validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)
        + ValidElement_AddtlBalBrkdwnDtls () = validElement(AddtlBalBrkdwnDtls)
        + ValidElement_Qty () = validElement(Qty)
        + Validation () = validation(ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidElement_Qty,ValidChoice)
    }
    class Semt002001.SubBalanceQuantity1Choice {
        + QtyAndAvlbty  : Semt002001.QuantityAndAvailability
        + QtyAsDSS  : Semt002001.GenericIdentification6
        + Qty  : Semt002001.FinancialInstrumentQuantityChoice
        + ValidChoice () = validChoice(QtyAndAvlbty,QtyAsDSS,Qty)
        + ValidElement_QtyAndAvlbty () = validElement(QtyAndAvlbty)
        + ValidElement_QtyAsDSS () = validElement(QtyAsDSS)
        + ValidElement_Qty () = validElement(Qty)
        + Validation () = validation(ValidElement_QtyAndAvlbty,ValidElement_QtyAsDSS,ValidElement_Qty,ValidChoice)
    }
    class Edge {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Edge
        + Tos (To = this) : Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## Enum Semt002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32|||1|
||MLTO|Int32|||2|
||BIZZ|Int32|||3|
||HOME|Int32|||4|
||PBOX|Int32|||5|
||ADDR|Int32|||6|

---

## Enum Semt002001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32|||1|
||DIST|Int32|||2|

---

## Enum Semt002001.EventFrequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32|||1|
||OVNG|Int32|||2|
||INDA|Int32|||3|
||ADHO|Int32|||4|
||DAIL|Int32|||5|
||WEEK|Int32|||6|
||TOWK|Int32|||7|
||TWMN|Int32|||8|
||MNTH|Int32|||9|
||TOMN|Int32|||10|
||QUTR|Int32|||11|
||SEMI|Int32|||12|
||YEAR|Int32|||13|

---

## Enum Semt002001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32|||1|
||BEAR|Int32|||2|

---

## Enum Semt002001.InvestmentFundRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32|||1|
||UCL2|Int32|||2|
||UCL1|Int32|||3|
||CONC|Int32|||4|
||DIST|Int32|||5|
||INTR|Int32|||6|
||TRAG|Int32|||7|
||REGI|Int32|||8|
||FMCO|Int32|||9|

---

## Enum Semt002001.PriceSource1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32|||1|
||THEO|Int32|||2|
||FUND|Int32|||3|

---

## Enum Semt002001.PriceValueType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32|||1|
||DISC|Int32|||2|

---

## Enum Semt002001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32|||1|
||NCSD|Int32|||2|
||ICSD|Int32|||3|
||CUST|Int32|||4|

---

## Enum Semt002001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32|||1|
||DVPA|Int32|||2|
||CEND|Int32|||3|
||ABRD|Int32|||4|
||SHOR|Int32|||5|
||MARG|Int32|||6|

---

## Enum Semt002001.SecuritiesBalanceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BTRA|Int32|||1|
||WDOC|Int32|||2|
||DRAW|Int32|||3|
||TRAN|Int32|||4|
||OTHR|Int32|||5|
||RSTR|Int32|||6|
||REGO|Int32|||7|
||PDUM|Int32|||8|
||PLED|Int32|||9|
||PENR|Int32|||10|
||PEND|Int32|||11|
||PECA|Int32|||12|
||PRUM|Int32|||13|
||PRMT|Int32|||14|
||PDMT|Int32|||15|
||MARG|Int32|||16|
||LOAN|Int32|||17|
||COLO|Int32|||18|
||COLI|Int32|||19|
||BORR|Int32|||20|
||BLOK|Int32|||21|

---

## Enum Semt002001.SecuritiesBalanceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNRG|Int32|||1|
||SPOS|Int32|||2|
||OTHR|Int32|||3|
||NOMI|Int32|||4|
||DIRT|Int32|||5|
||CLEN|Int32|||6|

---

## Enum Semt002001.StatementBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32|||1|
||SETT|Int32|||2|
||CONT|Int32|||3|

---

## Enum Semt002001.StatementUpdateTypeCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32|||1|
||COMP|Int32|||2|

---

## Enum Semt002001.TypeOfPrice11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDC|Int32|||1|
||MRKT|Int32|||2|
||SWIC|Int32|||3|
||RINV|Int32|||4|
||MIDD|Int32|||5|
||SWNG|Int32|||6|
||INTE|Int32|||7|
||CANC|Int32|||8|
||CREA|Int32|||9|
||NAVL|Int32|||10|
||OFFR|Int32|||11|
||BIDE|Int32|||12|

---

## Value Semt002001.Account7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|Semt002001.PartyIdentification2Choice||XmlElement()||
|+|Id|Semt002001.AccountIdentification1||XmlElement()||
||ValidElement_AcctSvcr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcctSvcr)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_AcctSvcr,ValidElement_Id)|

---

## Value Semt002001.AccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|Semt002001.SimpleIdentificationInformation||XmlElement()||
||ValidElement_Prtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Prtry)|

---

## Value Semt002001.AccountIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|Semt002001.AccountIdentification1||XmlElement()||
||ValidPattern_Inf|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Inf,ValidElement_Id)|

---

## Value Semt002001.AccountIdentificationAndPurpose


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|String||XmlElement()||
|+|Id|Semt002001.AccountIdentification1||XmlElement()||
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Id)|

---

## Value Semt002001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||ValidRequired_Value|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Value",Value)|
||ValidRequired_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Ccy",Ccy)|
||ValidPattern_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ccy",Ccy,"[A-Z]{3,3}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)|

---

## Value Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||ValidRequired_Value|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Value",Value)|
||ValidRequired_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Ccy",Ccy)|
||ValidPattern_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ccy",Ccy,"[A-Z]{3,3}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)|

---

## Value Semt002001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||ValidRequired_Value|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Value",Value)|
||ValidRequired_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Ccy",Ccy)|
||ValidPattern_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ccy",Ccy,"[A-Z]{3,3}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)|

---

## Value Semt002001.AdditionalReference2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|Semt002001.PartyIdentification1Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||ValidElement_RefIssr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RefIssr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RefIssr)|

---

## Value Semt002001.AggregateBalanceInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalAtSfkpgPlc|List<Semt002001.AggregateBalancePerSafekeepingPlace3>||XmlElement()||
|+|AddtlBalBrkdwnDtls|List<Semt002001.AdditionalBalanceInformation2>||XmlElement()||
|+|BalBrkdwnDtls|List<Semt002001.SubBalanceInformation2>||XmlElement()||
|+|FXDtls|Semt002001.ForeignExchangeTerms6||XmlElement()||
|+|PricDtls|List<Semt002001.PriceInformation2>||XmlElement()||
|+|FinInstrmDtls|Semt002001.FinancialInstrument13||XmlElement()||
|+|SfkpgPlc|Semt002001.SafekeepingPlaceFormatChoice||XmlElement()||
|+|BookVal|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmtSgn|String||XmlElement()||
|+|AcrdIntrstAmt|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrvsHldgVal|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|HldgVal|List<Semt002001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|NotAvlblQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
|+|AvlblQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
|+|AggtQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
||ValidList_BalAtSfkpgPlc|Some(String)||XmlIgnore(), JsonIgnore()|validList("BalAtSfkpgPlc",BalAtSfkpgPlc)|
||ValidElement_BalAtSfkpgPlc|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BalAtSfkpgPlc)|
||ValidList_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)|
||ValidElement_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AddtlBalBrkdwnDtls)|
||ValidList_BalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("BalBrkdwnDtls",BalBrkdwnDtls)|
||ValidElement_BalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BalBrkdwnDtls)|
||ValidElement_FXDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FXDtls)|
||ValidList_PricDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("PricDtls",PricDtls)|
||ValidElement_PricDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PricDtls)|
||ValidElement_FinInstrmDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FinInstrmDtls)|
||ValidElement_SfkpgPlc|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SfkpgPlc)|
||ValidElement_BookVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BookVal)|
||ValidElement_AcrdIntrstAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcrdIntrstAmt)|
||ValidElement_PrvsHldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrvsHldgVal)|
||ValidList_HldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validList("HldgVal",HldgVal)|
||ValidElement_HldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(HldgVal)|
||ValidElement_NotAvlblQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NotAvlblQty)|
||ValidElement_AvlblQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AvlblQty)|
||ValidElement_AggtQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AggtQty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_BalAtSfkpgPlc,ValidElement_BalAtSfkpgPlc,ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidList_BalBrkdwnDtls,ValidElement_BalBrkdwnDtls,ValidElement_FXDtls,ValidList_PricDtls,ValidElement_PricDtls,ValidElement_FinInstrmDtls,ValidElement_SfkpgPlc,ValidElement_BookVal,ValidElement_AcrdIntrstAmt,ValidElement_PrvsHldgVal,ValidList_HldgVal,ValidElement_HldgVal,ValidElement_NotAvlblQty,ValidElement_AvlblQty,ValidElement_AggtQty)|

---

## Value Semt002001.AggregateBalancePerSafekeepingPlace3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|List<Semt002001.AdditionalBalanceInformation2>||XmlElement()||
|+|BalBrkdwnDtls|List<Semt002001.SubBalanceInformation2>||XmlElement()||
|+|FXDtls|Semt002001.ForeignExchangeTerms6||XmlElement()||
|+|PricDtls|List<Semt002001.PriceInformation2>||XmlElement()||
|+|SfkpgPlc|Semt002001.SafekeepingPlaceFormatChoice||XmlElement()||
|+|BookVal|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AcrdIntrstAmtSgn|String||XmlElement()||
|+|AcrdIntrstAmt|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PrvsHldgVal|Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|HldgVal|List<Semt002001.ActiveOrHistoricCurrencyAndAmount>||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|NotAvlblQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
|+|AvlblQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
|+|AggtQty|Semt002001.BalanceQuantity1Choice||XmlElement()||
||ValidList_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)|
||ValidElement_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AddtlBalBrkdwnDtls)|
||ValidList_BalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("BalBrkdwnDtls",BalBrkdwnDtls)|
||ValidElement_BalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BalBrkdwnDtls)|
||ValidElement_FXDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FXDtls)|
||ValidList_PricDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("PricDtls",PricDtls)|
||ValidElement_PricDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PricDtls)|
||ValidElement_SfkpgPlc|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SfkpgPlc)|
||ValidElement_BookVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BookVal)|
||ValidElement_AcrdIntrstAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcrdIntrstAmt)|
||ValidElement_PrvsHldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrvsHldgVal)|
||ValidList_HldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validList("HldgVal",HldgVal)|
||ValidElement_HldgVal|Some(String)||XmlIgnore(), JsonIgnore()|validElement(HldgVal)|
||ValidElement_NotAvlblQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NotAvlblQty)|
||ValidElement_AvlblQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AvlblQty)|
||ValidElement_AggtQty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AggtQty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidList_BalBrkdwnDtls,ValidElement_BalBrkdwnDtls,ValidElement_FXDtls,ValidList_PricDtls,ValidElement_PricDtls,ValidElement_SfkpgPlc,ValidElement_BookVal,ValidElement_AcrdIntrstAmt,ValidElement_PrvsHldgVal,ValidList_HldgVal,ValidElement_HldgVal,ValidElement_NotAvlblQty,ValidElement_AvlblQty,ValidElement_AggtQty)|

---

## Value Semt002001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.FinancialInstrument13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|Semt002001.SecurityIdentification3Choice||XmlElement()||
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Id)|

---

## Value Semt002001.ForeignExchangeTerms6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|Semt002001.PartyIdentification2Choice||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||ValidElement_QtgInstn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(QtgInstn)|
||ValidPattern_QtdCcy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("QtdCcy",QtdCcy,"[A-Z]{3,3}")|
||ValidPattern_UnitCcy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("UnitCcy",UnitCcy,"[A-Z]{3,3}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_QtgInstn,ValidPattern_QtdCcy,ValidPattern_UnitCcy)|

---

## Value Semt002001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.GenericIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||ValidPattern_Inf|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Inf)|

---

## Value Semt002001.GenericIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||ValidPattern_Inf|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Inf",Inf,"[a-zA-Z0-9]{4}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Inf)|

---

## Value Semt002001.GenericIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.NameAndAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|Semt002001.LongPostalAddress1Choice||XmlElement()||
|+|Nm|String||XmlElement()||
||ValidElement_Adr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Adr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Adr)|

---

## Value Semt002001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|Semt002001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||ValidElement_Adr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Adr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Adr)|

---

## Value Semt002001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||ValidPattern_PgNb|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("PgNb",PgNb,"[0-9]{1,5}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_PgNb)|

---

## Value Semt002001.PartyIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BICOrBEI|String||XmlElement()||
||ValidPattern_BICOrBEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_BICOrBEI)|

---

## Value Semt002001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||ValidPattern_Ctry|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ctry",Ctry,"[A-Z]{2,2}")|
||ValidListMax_AdrLine|Some(String)||XmlIgnore(), JsonIgnore()|validListMax("AdrLine",AdrLine,5)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Ctry,ValidListMax_AdrLine)|

---

## Value Semt002001.PriceSource


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|PricSrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.QuantityAndAvailability


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlbtyInd|String||XmlElement()||
|+|Qty|Semt002001.FinancialInstrumentQuantityChoice||XmlElement()||
||ValidElement_Qty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Qty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Qty)|

---

## Value Semt002001.SafekeepingAccount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|Semt002001.PartyIdentification2Choice||XmlElement()||
|+|AcctOwnr|Semt002001.PartyIdentification2Choice||XmlElement()||
|+|IntrmyInf|List<Semt002001.Intermediary11>||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|FngbInd|String||XmlElement()||
|+|Id|Semt002001.AccountIdentificationFormatChoice||XmlElement()||
||ValidElement_AcctSvcr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcctSvcr)|
||ValidElement_AcctOwnr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcctOwnr)|
||ValidList_IntrmyInf|Some(String)||XmlIgnore(), JsonIgnore()|validList("IntrmyInf",IntrmyInf)|
||ValidListMax_IntrmyInf|Some(String)||XmlIgnore(), JsonIgnore()|validListMax("IntrmyInf",IntrmyInf,10)|
||ValidElement_IntrmyInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(IntrmyInf)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_AcctSvcr,ValidElement_AcctOwnr,ValidList_IntrmyInf,ValidListMax_IntrmyInf,ValidElement_IntrmyInf,ValidElement_Id)|

---

## Value Semt002001.SafekeepingPlaceAsCodeAndPartyIdentification


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|Semt002001.PartyIdentification3||XmlElement()||
|+|Nrrtv|String||XmlElement()||
|+|PlcSfkpg|String||XmlElement()||
||ValidElement_Pty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Pty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Pty)|

---

## Value Semt002001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Semt002001.Statement7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptNb|String||XmlElement()||
|+|StmtBsis|Semt002001.StatementBasisCodeAndDSSCodeChoice||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|Semt002001.StatementUpdateTypeCodeAndDSSCodeChoice||XmlElement()||
|+|Frqcy|Semt002001.FrequencyCodeAndDSSCode1Choice||XmlElement()||
|+|CreDtTm|Semt002001.DateAndDateTimeChoice||XmlElement()||
|+|StmtDtTm|Semt002001.DateAndDateTimeChoice||XmlElement()||
|+|Ref|String||XmlElement()||
||ValidPattern_RptNb|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("RptNb",RptNb,"[0-9]{1,5}")|
||ValidElement_StmtBsis|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StmtBsis)|
||ValidElement_UpdTp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(UpdTp)|
||ValidElement_Frqcy|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Frqcy)|
||ValidElement_CreDtTm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CreDtTm)|
||ValidElement_StmtDtTm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StmtDtTm)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_RptNb,ValidElement_StmtBsis,ValidElement_UpdTp,ValidElement_Frqcy,ValidElement_CreDtTm,ValidElement_StmtDtTm)|

---

## Value Semt002001.StructuredLongPostalAddress1


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
||ValidPattern_Ctry|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ctry",Ctry,"[A-Z]{2,2}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Ctry)|

---

## Value Semt002001.SubAccountIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalForSubAcct|List<Semt002001.AggregateBalanceInformation4>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|FngbInd|String||XmlElement()||
|+|Id|Semt002001.AccountIdentificationFormatChoice||XmlElement()||
||ValidList_BalForSubAcct|Some(String)||XmlIgnore(), JsonIgnore()|validList("BalForSubAcct",BalForSubAcct)|
||ValidElement_BalForSubAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BalForSubAcct)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_BalForSubAcct,ValidElement_BalForSubAcct,ValidElement_Id)|

---

## Value Semt002001.TotalValueInPageAndStatement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlHldgsValOfStmt|Semt002001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlHldgsValOfPg|Semt002001.ActiveCurrencyAndAmount||XmlElement()||
||ValidElement_TtlHldgsValOfStmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlHldgsValOfStmt)|
||ValidElement_TtlHldgsValOfPg|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlHldgsValOfPg)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_TtlHldgsValOfStmt,ValidElement_TtlHldgsValOfPg)|

---

## Entity Semt002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CtdyStmtOfHldgsV02|Semt002001.CustodyStatementOfHoldingsV02||XmlElement()||
||ValidElement_CtdyStmtOfHldgsV02|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CtdyStmtOfHldgsV02)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CtdyStmtOfHldgsV02)|

---

## Aspect Semt002001.CustodyStatementOfHoldingsV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|List<Semt002001.Extension1>||XmlElement()||
|+|TtlVals|Semt002001.TotalValueInPageAndStatement||XmlElement()||
|+|SubAcctDtls|List<Semt002001.SubAccountIdentification5>||XmlElement()||
|+|BalForAcct|List<Semt002001.AggregateBalanceInformation4>||XmlElement()||
|+|AcctDtls|Semt002001.SafekeepingAccount2||XmlElement()||
|+|StmtGnlDtls|Semt002001.Statement7||XmlElement()||
|+|MsgPgntn|Semt002001.Pagination||XmlElement()||
|+|RltdRef|List<Semt002001.AdditionalReference2>||XmlElement()||
|+|PrvsRef|List<Semt002001.AdditionalReference2>||XmlElement()||
|+|MsgId|Semt002001.MessageIdentification1||XmlElement()||
||ValidList_Xtnsn|Some(String)||XmlIgnore(), JsonIgnore()|validList("Xtnsn",Xtnsn)|
||ValidElement_Xtnsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Xtnsn)|
||ValidElement_TtlVals|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlVals)|
||ValidList_SubAcctDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("SubAcctDtls",SubAcctDtls)|
||ValidElement_SubAcctDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SubAcctDtls)|
||ValidList_BalForAcct|Some(String)||XmlIgnore(), JsonIgnore()|validList("BalForAcct",BalForAcct)|
||ValidElement_BalForAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BalForAcct)|
||ValidElement_AcctDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AcctDtls)|
||ValidElement_StmtGnlDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StmtGnlDtls)|
||ValidElement_MsgPgntn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(MsgPgntn)|
||ValidList_RltdRef|Some(String)||XmlIgnore(), JsonIgnore()|validList("RltdRef",RltdRef)|
||ValidElement_RltdRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RltdRef)|
||ValidList_PrvsRef|Some(String)||XmlIgnore(), JsonIgnore()|validList("PrvsRef",PrvsRef)|
||ValidElement_PrvsRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrvsRef)|
||ValidElement_MsgId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(MsgId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Xtnsn,ValidElement_Xtnsn,ValidElement_TtlVals,ValidList_SubAcctDtls,ValidElement_SubAcctDtls,ValidList_BalForAcct,ValidElement_BalForAcct,ValidElement_AcctDtls,ValidElement_StmtGnlDtls,ValidElement_MsgPgntn,ValidList_RltdRef,ValidElement_RltdRef,ValidList_PrvsRef,ValidElement_PrvsRef,ValidElement_MsgId)|

---

## Value Semt002001.AccountIdentificationFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdAsDSS|Semt002001.AccountIdentification3||XmlElement()||
|+|IdAndPurp|Semt002001.AccountIdentificationAndPurpose||XmlElement()||
|+|SmplId|Semt002001.AccountIdentification1||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(IdAsDSS,IdAndPurp,SmplId)|
||ValidElement_IdAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(IdAsDSS)|
||ValidElement_IdAndPurp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(IdAndPurp)|
||ValidElement_SmplId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SmplId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_IdAsDSS,ValidElement_IdAndPurp,ValidElement_SmplId,ValidChoice)|

---

## Value Semt002001.AdditionalBalanceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedSubBalTp|String||XmlElement()||
|+|SubBalTp|String||XmlElement()||
|+|Qty|Semt002001.SubBalanceQuantity1Choice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(XtndedSubBalTp,SubBalTp,Qty)|
||ValidElement_Qty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Qty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Qty,ValidChoice)|

---

## Value Semt002001.AlternateSecurityIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(PrtryIdSrc,DmstIdSrc,Id)|
||ValidPattern_DmstIdSrc|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("DmstIdSrc",DmstIdSrc,"[A-Z]{2,2}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_DmstIdSrc,ValidChoice)|

---

## Value Semt002001.BalanceQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAsDSS|Semt002001.GenericIdentification6||XmlElement()||
|+|Qty|Semt002001.FinancialInstrumentQuantityChoice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(QtyAsDSS,Qty)|
||ValidElement_QtyAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(QtyAsDSS)|
||ValidElement_Qty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Qty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_QtyAsDSS,ValidElement_Qty,ValidChoice)|

---

## Value Semt002001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(DtTm,Dt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Semt002001.FinancialInstrumentQuantityChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(AmtsdVal,FaceAmt,Unit)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Semt002001.FrequencyCodeAndDSSCode1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrqcyAsDSS|Semt002001.GenericIdentification7||XmlElement()||
|+|FrqcyAsCd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(FrqcyAsDSS,FrqcyAsCd)|
||ValidElement_FrqcyAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FrqcyAsDSS)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_FrqcyAsDSS,ValidChoice)|

---

## Value Semt002001.Intermediary11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedRole|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|Acct|Semt002001.Account7||XmlElement()||
|+|Id|Semt002001.PartyIdentification2Choice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(XtndedRole,Role,Acct,Id)|
||ValidElement_Acct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Acct)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Acct,ValidElement_Id,ValidChoice)|

---

## Value Semt002001.LongPostalAddress1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|Semt002001.StructuredLongPostalAddress1||XmlElement()||
|+|Ustrd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Strd,Ustrd)|
||ValidElement_Strd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Strd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Strd,ValidChoice)|

---

## Value Semt002001.PartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|Semt002001.NameAndAddress2||XmlElement()||
|+|PrtryId|Semt002001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(NmAndAdr,PrtryId,BICOrBEI)|
||ValidElement_NmAndAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NmAndAdr)|
||ValidElement_PrtryId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrtryId)|
||ValidPattern_BICOrBEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)|

---

## Value Semt002001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|Semt002001.NameAndAddress5||XmlElement()||
|+|PrtryId|Semt002001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(NmAndAdr,PrtryId,BICOrBEI)|
||ValidElement_NmAndAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NmAndAdr)|
||ValidElement_PrtryId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrtryId)|
||ValidPattern_BICOrBEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("BICOrBEI",BICOrBEI,"[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_NmAndAdr,ValidElement_PrtryId,ValidPattern_BICOrBEI,ValidChoice)|

---

## Value Semt002001.PriceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Yldd|String||XmlElement()||
|+|QtnDt|Semt002001.DateAndDateTimeChoice||XmlElement()||
|+|SrcOfPric|Semt002001.PriceSourceFormatChoice||XmlElement()||
|+|XtndedTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|ValTp|String||XmlElement()||
|+|Val|Semt002001.PriceRateOrAmountOrUnknownChoice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Yldd,QtnDt,SrcOfPric,XtndedTp,Tp,ValTp,Val)|
||ValidElement_QtnDt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(QtnDt)|
||ValidElement_SrcOfPric|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SrcOfPric)|
||ValidElement_Val|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Val)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_QtnDt,ValidElement_SrcOfPric,ValidElement_Val,ValidChoice)|

---

## Value Semt002001.PriceRateOrAmountOrUnknownChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(UknwnInd,Amt,Rate)|
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt,ValidChoice)|

---

## Value Semt002001.PriceSourceFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcAsDSS|Semt002001.GenericIdentification5||XmlElement()||
|+|NonLclMktPlc|Semt002001.PriceSource||XmlElement()||
|+|LclMktPlc|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(PlcAsDSS,NonLclMktPlc,LclMktPlc)|
||ValidElement_PlcAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PlcAsDSS)|
||ValidElement_NonLclMktPlc|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NonLclMktPlc)|
||ValidPattern_LclMktPlc|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("LclMktPlc",LclMktPlc,"[A-Z0-9]{4,4}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_PlcAsDSS,ValidElement_NonLclMktPlc,ValidPattern_LclMktPlc,ValidChoice)|

---

## Value Semt002001.SafekeepingPlaceFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdAsCtry|String||XmlElement()||
|+|IdAsDSS|Semt002001.GenericIdentification5||XmlElement()||
|+|Id|Semt002001.SafekeepingPlaceAsCodeAndPartyIdentification||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(IdAsCtry,IdAsDSS,Id)|
||ValidPattern_IdAsCtry|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("IdAsCtry",IdAsCtry,"[A-Z]{2,2}")|
||ValidElement_IdAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(IdAsDSS)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_IdAsCtry,ValidElement_IdAsDSS,ValidElement_Id,ValidChoice)|

---

## Value Semt002001.SecurityIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|Semt002001.AlternateSecurityIdentification1||XmlElement()||
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
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN)|
||ValidElement_OthrPrtryId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OthrPrtryId)|
||ValidPattern_ISIN|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("ISIN",ISIN,"[A-Z0-9]{12,12}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_OthrPrtryId,ValidPattern_ISIN,ValidChoice)|

---

## Value Semt002001.StatementBasisCodeAndDSSCodeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtBsisAsDSS|Semt002001.GenericIdentification7||XmlElement()||
|+|StmtBsisAsCd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(StmtBsisAsDSS,StmtBsisAsCd)|
||ValidElement_StmtBsisAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StmtBsisAsDSS)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_StmtBsisAsDSS,ValidChoice)|

---

## Value Semt002001.StatementUpdateTypeCodeAndDSSCodeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtUpdTpAsDSS|Semt002001.GenericIdentification7||XmlElement()||
|+|StmtUpdTpAsCd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(StmtUpdTpAsDSS,StmtUpdTpAsCd)|
||ValidElement_StmtUpdTpAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StmtUpdTpAsDSS)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_StmtUpdTpAsDSS,ValidChoice)|

---

## Value Semt002001.SubBalanceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|List<Semt002001.AdditionalBalanceInformation2>||XmlElement()||
|+|XtndedSubBalTp|String||XmlElement()||
|+|SubBalTp|String||XmlElement()||
|+|Qty|Semt002001.SubBalanceQuantity1Choice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(AddtlBalBrkdwnDtls,XtndedSubBalTp,SubBalTp,Qty)|
||ValidList_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("AddtlBalBrkdwnDtls",AddtlBalBrkdwnDtls)|
||ValidElement_AddtlBalBrkdwnDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AddtlBalBrkdwnDtls)|
||ValidElement_Qty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Qty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_AddtlBalBrkdwnDtls,ValidElement_AddtlBalBrkdwnDtls,ValidElement_Qty,ValidChoice)|

---

## Value Semt002001.SubBalanceQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAndAvlbty|Semt002001.QuantityAndAvailability||XmlElement()||
|+|QtyAsDSS|Semt002001.GenericIdentification6||XmlElement()||
|+|Qty|Semt002001.FinancialInstrumentQuantityChoice||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(QtyAndAvlbty,QtyAsDSS,Qty)|
||ValidElement_QtyAndAvlbty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(QtyAndAvlbty)|
||ValidElement_QtyAsDSS|Some(String)||XmlIgnore(), JsonIgnore()|validElement(QtyAsDSS)|
||ValidElement_Qty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Qty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_QtyAndAvlbty,ValidElement_QtyAsDSS,ValidElement_Qty,ValidChoice)|

---

## View Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Edge|||From = this|
||Tos|Edge|||To = this|

