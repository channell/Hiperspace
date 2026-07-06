# setr.016.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Setr016001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr016001.AdditionalAmount1Choice {
        + RsltgCshOut  : ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
        + AddtlCshIn  : ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Setr016001.AdditionalAmount1Choice *-- ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr016001.AdditionalAmount1Choice *-- ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr016001.AdditionalReference8 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Setr016001.PartyIdentification113
        + Ref  : String
    }
    ISO20022.Setr016001.AdditionalReference8 *-- ISO20022.Setr016001.PartyIdentification113
    class ISO20022.Setr016001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Setr016001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Setr016001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Setr016001.AlternateSecurityIdentification7 *-- ISO20022.Setr016001.IdentificationSource1Choice
    class ISO20022.Setr016001.CancelledReason12Choice {
        + NoSpcfdRsn  : String
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.CancelledReason12Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.CancelledStatusReason16 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.CancelledReason12Choice
    }
    ISO20022.Setr016001.CancelledStatusReason16 *-- ISO20022.Setr016001.CancelledReason12Choice
    class ISO20022.Setr016001.CancelledStatusReason2Code {
        CANO = 1
        CXLR = 2
        CANP = 3
        CANH = 4
    }
    class ISO20022.Setr016001.ChargeType5Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr016001.ChargeType5Choice *-- ISO20022.Setr016001.GenericIdentification47
    class ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice {
        + RsnDtls  : global::System.Collections.Generic.List~ISO20022.Setr016001.ConditionallyAcceptedStatusReason3~
        + NoSpcfdRsn  : String
    }
    ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice *-- ISO20022.Setr016001.ConditionallyAcceptedStatusReason3
    class ISO20022.Setr016001.ConditionallyAcceptedStatusReason2Code {
        CRED = 1
        DUPL = 2
        AWSM = 3
        AWRM = 4
        DOCC = 5
    }
    class ISO20022.Setr016001.ConditionallyAcceptedStatusReason3 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice
    }
    ISO20022.Setr016001.ConditionallyAcceptedStatusReason3 *-- ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice
    class ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr016001.DateFormat42Choice {
        + YrMnthDay  : DateTime
        + YrMnth  : String
    }
    class ISO20022.Setr016001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Setr016001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Setr016001.ExpectedExecutionDetails2 {
        + XpctdCshSttlmDt  : DateTime
        + XpctdTradDtTm  : ISO20022.Setr016001.DateAndDateTimeChoice
    }
    ISO20022.Setr016001.ExpectedExecutionDetails2 *-- ISO20022.Setr016001.DateAndDateTimeChoice
    class ISO20022.Setr016001.ExpectedExecutionDetails4 {
        + XpctdCshSttlmDt  : DateTime
        + XpctdTradDtTm  : ISO20022.Setr016001.DateAndDateTimeChoice
    }
    ISO20022.Setr016001.ExpectedExecutionDetails4 *-- ISO20022.Setr016001.DateAndDateTimeChoice
    class ISO20022.Setr016001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Setr016001.Fee3 {
        + NewComrclAgrmtRefInd  : String
        + ComrclAgrmtRef  : String
        + RprdReqdRate  : Decimal
        + RprdReqdAmt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
        + RprdDscntRate  : Decimal
        + RprdDscntAmt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
        + RprdStdRate  : Decimal
        + RprdStdAmt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Setr016001.ChargeType5Choice
    }
    ISO20022.Setr016001.Fee3 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    ISO20022.Setr016001.Fee3 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    ISO20022.Setr016001.Fee3 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    ISO20022.Setr016001.Fee3 *-- ISO20022.Setr016001.ChargeType5Choice
    class ISO20022.Setr016001.FinancialInstrument57 {
        + SrsId  : ISO20022.Setr016001.Series1
        + PdctGrp  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Setr016001.SecurityIdentification25Choice
    }
    ISO20022.Setr016001.FinancialInstrument57 *-- ISO20022.Setr016001.Series1
    ISO20022.Setr016001.FinancialInstrument57 *-- ISO20022.Setr016001.SecurityIdentification25Choice
    class ISO20022.Setr016001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Setr016001.FundOrderData5 {
        + QtdCcy  : String
        + UnitCcy  : String
        + SttlmAmt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
        + HldgsRedRate  : Decimal
        + GrssAmt  : ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
        + NetAmt  : ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
        + UnitsNb  : Decimal
        + FinInstrmDtls  : ISO20022.Setr016001.FinancialInstrument57
        + InvstmtAcctDtls  : ISO20022.Setr016001.InvestmentAccount58
    }
    ISO20022.Setr016001.FundOrderData5 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    ISO20022.Setr016001.FundOrderData5 *-- ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr016001.FundOrderData5 *-- ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr016001.FundOrderData5 *-- ISO20022.Setr016001.FinancialInstrument57
    ISO20022.Setr016001.FundOrderData5 *-- ISO20022.Setr016001.InvestmentAccount58
    class ISO20022.Setr016001.FundOrderData6 {
        + QtdCcy  : String
        + UnitCcy  : String
        + AddtlAmt  : ISO20022.Setr016001.AdditionalAmount1Choice
        + SttlmMtd  : String
        + SttlmAmt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr016001.FundOrderData6 *-- ISO20022.Setr016001.AdditionalAmount1Choice
    ISO20022.Setr016001.FundOrderData6 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    class ISO20022.Setr016001.GateHoldBack1Code {
        HOLD = 1
        GATE = 2
    }
    class ISO20022.Setr016001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Setr016001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr016001.HoldBackInformation3 {
        + RedCmpltn  : String
        + FinInstrmNm  : String
        + FinInstrmId  : ISO20022.Setr016001.SecurityIdentification25Choice
        + XpctdRlsDt  : DateTime
        + Amt  : ISO20022.Setr016001.ActiveCurrencyAndAmount
        + Tp  : String
    }
    ISO20022.Setr016001.HoldBackInformation3 *-- ISO20022.Setr016001.SecurityIdentification25Choice
    ISO20022.Setr016001.HoldBackInformation3 *-- ISO20022.Setr016001.ActiveCurrencyAndAmount
    class ISO20022.Setr016001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Setr016001.InRepairStatusReason1Code {
        COMA = 1
    }
    class ISO20022.Setr016001.InRepairStatusReason4 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.InRepairStatusReason5Choice
    }
    ISO20022.Setr016001.InRepairStatusReason4 *-- ISO20022.Setr016001.InRepairStatusReason5Choice
    class ISO20022.Setr016001.InRepairStatusReason4Choice {
        + RsnDtls  : global::System.Collections.Generic.List~ISO20022.Setr016001.InRepairStatusReason4~
        + NoSpcfdRsn  : String
    }
    ISO20022.Setr016001.InRepairStatusReason4Choice *-- ISO20022.Setr016001.InRepairStatusReason4
    class ISO20022.Setr016001.InRepairStatusReason5Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.InRepairStatusReason5Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.IndividualOrderStatusAndReason7 {
        + GtgOrHldBckDtls  : ISO20022.Setr016001.HoldBackInformation3
        + NewDtls  : ISO20022.Setr016001.ExpectedExecutionDetails4
        + OrdrData  : ISO20022.Setr016001.FundOrderData5
        + StsInitr  : ISO20022.Setr016001.PartyIdentification113
        + RprdFee  : global::System.Collections.Generic.List~ISO20022.Setr016001.Fee3~
        + OrdrSts  : ISO20022.Setr016001.OrderStatus5Choice
        + CxlRef  : String
        + DealRef  : String
        + ClntRef  : String
        + OrdrRef  : String
        + MstrRef  : String
    }
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.HoldBackInformation3
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.ExpectedExecutionDetails4
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.FundOrderData5
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.PartyIdentification113
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.Fee3
    ISO20022.Setr016001.IndividualOrderStatusAndReason7 *-- ISO20022.Setr016001.OrderStatus5Choice
    class ISO20022.Setr016001.InvestmentAccount58 {
        + SubAcctDtls  : ISO20022.Setr016001.SubAccount6
        + OrdrOrgtrElgblty  : String
        + AcctSvcr  : ISO20022.Setr016001.PartyIdentification113
        + OwnrId  : global::System.Collections.Generic.List~ISO20022.Setr016001.PartyIdentification113~
        + AcctDsgnt  : String
        + AcctNm  : String
        + AcctId  : String
    }
    ISO20022.Setr016001.InvestmentAccount58 *-- ISO20022.Setr016001.SubAccount6
    ISO20022.Setr016001.InvestmentAccount58 *-- ISO20022.Setr016001.PartyIdentification113
    ISO20022.Setr016001.InvestmentAccount58 *-- ISO20022.Setr016001.PartyIdentification113
    class ISO20022.Setr016001.InvestmentFundFee1Code {
        PENA = 1
        REGF = 2
        UCIC = 3
        SWIT = 4
        SHIP = 5
        CHAR = 6
        PREM = 7
        POST = 8
        ADDF = 9
        INIT = 10
        FEND = 11
        DLEV = 12
        CBCH = 13
        CDSC = 14
        CDPL = 15
        COMM = 16
        BRKF = 17
        BEND = 18
    }
    class ISO20022.Setr016001.LegIdentification1Choice {
        + SbcptLegId  : String
        + RedLegId  : String
    }
    class ISO20022.Setr016001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Setr016001.NameAndAddress5 {
        + Adr  : ISO20022.Setr016001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr016001.NameAndAddress5 *-- ISO20022.Setr016001.PostalAddress1
    class ISO20022.Setr016001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Setr016001.OrderInstructionStatusReportV04 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Setr016001.Extension1~
        + StsRpt  : ISO20022.Setr016001.Status24Choice
        + Ref  : ISO20022.Setr016001.References61Choice
        + MsgId  : ISO20022.Setr016001.MessageIdentification1
    }
    ISO20022.Setr016001.OrderInstructionStatusReportV04 *-- ISO20022.Setr016001.Extension1
    ISO20022.Setr016001.OrderInstructionStatusReportV04 *-- ISO20022.Setr016001.Status24Choice
    ISO20022.Setr016001.OrderInstructionStatusReportV04 *-- ISO20022.Setr016001.References61Choice
    ISO20022.Setr016001.OrderInstructionStatusReportV04 *-- ISO20022.Setr016001.MessageIdentification1
    class ISO20022.Setr016001.OrderOriginatorEligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Setr016001.OrderStatus3Choice {
        + PrtlySttld  : ISO20022.Setr016001.PartiallySettledStatus10
        + Sspd  : ISO20022.Setr016001.SuspendedStatusReason4Choice
        + Rjctd  : global::System.Collections.Generic.List~ISO20022.Setr016001.RejectedStatus9~
        + CondlyAccptd  : ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
        + Canc  : ISO20022.Setr016001.CancelledStatusReason16
        + Sts  : String
    }
    ISO20022.Setr016001.OrderStatus3Choice *-- ISO20022.Setr016001.PartiallySettledStatus10
    ISO20022.Setr016001.OrderStatus3Choice *-- ISO20022.Setr016001.SuspendedStatusReason4Choice
    ISO20022.Setr016001.OrderStatus3Choice *-- ISO20022.Setr016001.RejectedStatus9
    ISO20022.Setr016001.OrderStatus3Choice *-- ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
    ISO20022.Setr016001.OrderStatus3Choice *-- ISO20022.Setr016001.CancelledStatusReason16
    class ISO20022.Setr016001.OrderStatus4Choice {
        + PrtlySttld  : ISO20022.Setr016001.PartiallySettledStatus10
        + InRpr  : ISO20022.Setr016001.InRepairStatusReason4Choice
        + Sspd  : ISO20022.Setr016001.SuspendedStatusReason4Choice
        + Rjctd  : global::System.Collections.Generic.List~ISO20022.Setr016001.RejectedStatus9~
        + CondlyAccptd  : ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
        + Canc  : ISO20022.Setr016001.CancelledStatusReason16
        + Sts  : String
    }
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.PartiallySettledStatus10
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.InRepairStatusReason4Choice
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.SuspendedStatusReason4Choice
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.RejectedStatus9
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
    ISO20022.Setr016001.OrderStatus4Choice *-- ISO20022.Setr016001.CancelledStatusReason16
    class ISO20022.Setr016001.OrderStatus4Code {
        IACO = 1
        OPOD = 2
        DONF = 3
        DONE = 4
        CNFC = 5
        CPNP = 6
        SETT = 7
        RECE = 8
        STNP = 9
        COSE = 10
        PACK = 11
    }
    class ISO20022.Setr016001.OrderStatus5Choice {
        + PrtlySttld  : ISO20022.Setr016001.PartiallySettledStatus10
        + InRpr  : ISO20022.Setr016001.InRepairStatusReason4Choice
        + Sspd  : ISO20022.Setr016001.SuspendedStatusReason4Choice
        + Rjctd  : global::System.Collections.Generic.List~ISO20022.Setr016001.RejectedStatus9~
        + CondlyAccptd  : ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
        + Canc  : ISO20022.Setr016001.CancelledStatusReason16
        + Sts  : String
    }
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.PartiallySettledStatus10
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.InRepairStatusReason4Choice
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.SuspendedStatusReason4Choice
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.RejectedStatus9
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice
    ISO20022.Setr016001.OrderStatus5Choice *-- ISO20022.Setr016001.CancelledStatusReason16
    class ISO20022.Setr016001.OrderStatusAndReason10 {
        + StsInitr  : ISO20022.Setr016001.PartyIdentification113
        + OrdrSts  : ISO20022.Setr016001.OrderStatus3Choice
        + MstrRef  : String
    }
    ISO20022.Setr016001.OrderStatusAndReason10 *-- ISO20022.Setr016001.PartyIdentification113
    ISO20022.Setr016001.OrderStatusAndReason10 *-- ISO20022.Setr016001.OrderStatus3Choice
    class ISO20022.Setr016001.PartiallySettled21Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.PartiallySettled21Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.PartiallySettledStatus10 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.PartiallySettled21Choice
    }
    ISO20022.Setr016001.PartiallySettledStatus10 *-- ISO20022.Setr016001.PartiallySettled21Choice
    class ISO20022.Setr016001.PartyIdentification113 {
        + LEI  : String
        + Pty  : ISO20022.Setr016001.PartyIdentification90Choice
    }
    ISO20022.Setr016001.PartyIdentification113 *-- ISO20022.Setr016001.PartyIdentification90Choice
    class ISO20022.Setr016001.PartyIdentification90Choice {
        + NmAndAdr  : ISO20022.Setr016001.NameAndAddress5
        + PrtryId  : ISO20022.Setr016001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Setr016001.PartyIdentification90Choice *-- ISO20022.Setr016001.NameAndAddress5
    ISO20022.Setr016001.PartyIdentification90Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr016001.RedemptionCompletion1Code {
        RED1 = 1
        RED0 = 2
    }
    class ISO20022.Setr016001.References61Choice {
        + OthrRef  : global::System.Collections.Generic.List~ISO20022.Setr016001.AdditionalReference8~
        + RltdRef  : global::System.Collections.Generic.List~ISO20022.Setr016001.AdditionalReference8~
    }
    ISO20022.Setr016001.References61Choice *-- ISO20022.Setr016001.AdditionalReference8
    ISO20022.Setr016001.References61Choice *-- ISO20022.Setr016001.AdditionalReference8
    class ISO20022.Setr016001.RejectedReason20Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.RejectedReason20Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.RejectedStatus9 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.RejectedReason20Choice
    }
    ISO20022.Setr016001.RejectedStatus9 *-- ISO20022.Setr016001.RejectedReason20Choice
    class ISO20022.Setr016001.RejectedStatusReason11Code {
        POIN = 1
        UNSC = 2
        ULNK = 3
        URSC = 4
        UPAY = 5
        UNAV = 6
        UDCY = 7
        UWAI = 8
        DTRD = 9
        SLOW = 10
        LATE = 11
        SHIG = 12
        IEXE = 13
        SETR = 14
        DEPT = 15
        DDAT = 16
        NCRR = 17
        ISAF = 18
        RTGS = 19
        IVAG = 20
        PLCE = 21
        PHYS = 22
        DLVY = 23
        PRCT = 24
        IPAY = 25
        SECU = 26
        MONY = 27
        NSLA = 28
        NRGM = 29
        LOCK = 30
        SAFE = 31
        DMON = 32
        DFOR = 33
        IOTP = 34
        ICTR = 35
        CASH = 36
        INTE = 37
        INSU = 38
        IPAC = 39
        CLOS = 40
        DQUA = 41
        IDNA = 42
        DSEC = 43
        FEEE = 44
        ORRF = 45
        IDDB = 46
        ICAG = 47
        CUTO = 48
        BMRV = 49
        BMRA = 50
        BMIN = 51
        ILLI = 52
        ADEA = 53
        DOCC = 54
        BLTR = 55
        BLCA = 56
    }
    class ISO20022.Setr016001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Setr016001.AlternateSecurityIdentification7
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
    ISO20022.Setr016001.SecurityIdentification25Choice *-- ISO20022.Setr016001.AlternateSecurityIdentification7
    class ISO20022.Setr016001.Series1 {
        + SrsNm  : String
        + SrsDt  : ISO20022.Setr016001.DateFormat42Choice
    }
    ISO20022.Setr016001.Series1 *-- ISO20022.Setr016001.DateFormat42Choice
    class ISO20022.Setr016001.SettledStatusReason2Code {
        UPST = 1
        UCPS = 2
        GAT1 = 3
        GATM = 4
        CPST = 5
    }
    class ISO20022.Setr016001.Status24Choice {
        + SwtchOrdrDtlsRpt  : global::System.Collections.Generic.List~ISO20022.Setr016001.SwitchOrderStatusAndReason2~
        + IndvOrdrDtlsRpt  : global::System.Collections.Generic.List~ISO20022.Setr016001.IndividualOrderStatusAndReason7~
        + OrdrDtlsRpt  : ISO20022.Setr016001.OrderStatusAndReason10
    }
    ISO20022.Setr016001.Status24Choice *-- ISO20022.Setr016001.SwitchOrderStatusAndReason2
    ISO20022.Setr016001.Status24Choice *-- ISO20022.Setr016001.IndividualOrderStatusAndReason7
    ISO20022.Setr016001.Status24Choice *-- ISO20022.Setr016001.OrderStatusAndReason10
    class ISO20022.Setr016001.SubAccount6 {
        + AcctDsgnt  : String
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Setr016001.SuspendedStatusReason3Code {
        FLOW = 1
        PRIC = 2
    }
    class ISO20022.Setr016001.SuspendedStatusReason4 {
        + AddtlInf  : String
        + Rsn  : ISO20022.Setr016001.SuspendedStatusReason5Choice
    }
    ISO20022.Setr016001.SuspendedStatusReason4 *-- ISO20022.Setr016001.SuspendedStatusReason5Choice
    class ISO20022.Setr016001.SuspendedStatusReason4Choice {
        + RsnDtls  : global::System.Collections.Generic.List~ISO20022.Setr016001.SuspendedStatusReason4~
        + NoSpcfdRsn  : String
    }
    ISO20022.Setr016001.SuspendedStatusReason4Choice *-- ISO20022.Setr016001.SuspendedStatusReason4
    class ISO20022.Setr016001.SuspendedStatusReason5Choice {
        + Prtry  : ISO20022.Setr016001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Setr016001.SuspendedStatusReason5Choice *-- ISO20022.Setr016001.GenericIdentification1
    class ISO20022.Setr016001.SwitchLegReferences2 {
        + FinInstrmDtls  : ISO20022.Setr016001.FinancialInstrument57
        + InvstmtAcctDtls  : ISO20022.Setr016001.InvestmentAccount58
        + RprdFee  : global::System.Collections.Generic.List~ISO20022.Setr016001.Fee3~
        + LegRjctnRsn  : String
        + LegId  : ISO20022.Setr016001.LegIdentification1Choice
    }
    ISO20022.Setr016001.SwitchLegReferences2 *-- ISO20022.Setr016001.FinancialInstrument57
    ISO20022.Setr016001.SwitchLegReferences2 *-- ISO20022.Setr016001.InvestmentAccount58
    ISO20022.Setr016001.SwitchLegReferences2 *-- ISO20022.Setr016001.Fee3
    ISO20022.Setr016001.SwitchLegReferences2 *-- ISO20022.Setr016001.LegIdentification1Choice
    class ISO20022.Setr016001.SwitchOrderStatusAndReason2 {
        + NewDtls  : ISO20022.Setr016001.ExpectedExecutionDetails2
        + OrdrData  : ISO20022.Setr016001.FundOrderData6
        + StsInitr  : ISO20022.Setr016001.PartyIdentification113
        + LegInf  : global::System.Collections.Generic.List~ISO20022.Setr016001.SwitchLegReferences2~
        + OrdrSts  : ISO20022.Setr016001.OrderStatus4Choice
        + CxlRef  : String
        + DealRef  : String
        + ClntRef  : String
        + OrdrRef  : String
        + MstrRef  : String
    }
    ISO20022.Setr016001.SwitchOrderStatusAndReason2 *-- ISO20022.Setr016001.ExpectedExecutionDetails2
    ISO20022.Setr016001.SwitchOrderStatusAndReason2 *-- ISO20022.Setr016001.FundOrderData6
    ISO20022.Setr016001.SwitchOrderStatusAndReason2 *-- ISO20022.Setr016001.PartyIdentification113
    ISO20022.Setr016001.SwitchOrderStatusAndReason2 *-- ISO20022.Setr016001.SwitchLegReferences2
    ISO20022.Setr016001.SwitchOrderStatusAndReason2 *-- ISO20022.Setr016001.OrderStatus4Choice
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

## Value ISO20022.Setr016001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr016001.AdditionalAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgCshOut|ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AddtlCshIn|ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgCshOut),validElement(AddtlCshIn),validChoice(RsltgCshOut,AddtlCshIn))|

---

## Value ISO20022.Setr016001.AdditionalReference8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Setr016001.PartyIdentification113||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Setr016001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Setr016001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Setr016001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Setr016001.CancelledReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(NoSpcfdRsn,Prtry,Cd))|

---

## Value ISO20022.Setr016001.CancelledStatusReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.CancelledReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Enum ISO20022.Setr016001.CancelledStatusReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANO|Int32||XmlEnum("""CANO""")|1|
||CXLR|Int32||XmlEnum("""CXLR""")|2|
||CANP|Int32||XmlEnum("""CANP""")|3|
||CANH|Int32||XmlEnum("""CANH""")|4|

---

## Value ISO20022.Setr016001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsnDtls|global::System.Collections.Generic.List<ISO20022.Setr016001.ConditionallyAcceptedStatusReason3>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RsnDtls""",RsnDtls),validList("""RsnDtls""",RsnDtls),validListMax("""RsnDtls""",RsnDtls,5),validElement(RsnDtls),validChoice(RsnDtls,NoSpcfdRsn))|

---

## Enum ISO20022.Setr016001.ConditionallyAcceptedStatusReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRED|Int32||XmlEnum("""CRED""")|1|
||DUPL|Int32||XmlEnum("""DUPL""")|2|
||AWSM|Int32||XmlEnum("""AWSM""")|3|
||AWRM|Int32||XmlEnum("""AWRM""")|4|
||DOCC|Int32||XmlEnum("""DOCC""")|5|

---

## Value ISO20022.Setr016001.ConditionallyAcceptedStatusReason3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Setr016001.ConditionallyAcceptedStatusReason3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr016001.DateFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|YrMnthDay|DateTime||XmlElement()||
|+|YrMnth|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(YrMnthDay,YrMnth))|

---

## Enum ISO20022.Setr016001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Setr016001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Setr016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrdrInstrStsRpt|ISO20022.Setr016001.OrderInstructionStatusReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrdrInstrStsRpt))|

---

## Value ISO20022.Setr016001.ExpectedExecutionDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XpctdCshSttlmDt|DateTime||XmlElement()||
|+|XpctdTradDtTm|ISO20022.Setr016001.DateAndDateTimeChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XpctdTradDtTm))|

---

## Value ISO20022.Setr016001.ExpectedExecutionDetails4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XpctdCshSttlmDt|DateTime||XmlElement()||
|+|XpctdTradDtTm|ISO20022.Setr016001.DateAndDateTimeChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XpctdTradDtTm))|

---

## Value ISO20022.Setr016001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr016001.Fee3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NewComrclAgrmtRefInd|String||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
|+|RprdReqdRate|Decimal||XmlElement()||
|+|RprdReqdAmt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|RprdDscntRate|Decimal||XmlElement()||
|+|RprdDscntAmt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|RprdStdRate|Decimal||XmlElement()||
|+|RprdStdAmt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Setr016001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RprdReqdAmt),validElement(RprdDscntAmt),validElement(RprdStdAmt),validElement(Tp))|

---

## Value ISO20022.Setr016001.FinancialInstrument57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsId|ISO20022.Setr016001.Series1||XmlElement()||
|+|PdctGrp|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Setr016001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsId),validElement(Id))|

---

## Enum ISO20022.Setr016001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Setr016001.FundOrderData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|SttlmAmt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|HldgsRedRate|Decimal||XmlElement()||
|+|GrssAmt|ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Setr016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
|+|FinInstrmDtls|ISO20022.Setr016001.FinancialInstrument57||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr016001.InvestmentAccount58||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validElement(SttlmAmt),validElement(GrssAmt),validElement(NetAmt),validElement(FinInstrmDtls),validElement(InvstmtAcctDtls))|

---

## Value ISO20022.Setr016001.FundOrderData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|AddtlAmt|ISO20022.Setr016001.AdditionalAmount1Choice||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
|+|SttlmAmt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validElement(AddtlAmt),validElement(SttlmAmt))|

---

## Enum ISO20022.Setr016001.GateHoldBack1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HOLD|Int32||XmlEnum("""HOLD""")|1|
||GATE|Int32||XmlEnum("""GATE""")|2|

---

## Value ISO20022.Setr016001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr016001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr016001.HoldBackInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RedCmpltn|String||XmlElement()||
|+|FinInstrmNm|String||XmlElement()||
|+|FinInstrmId|ISO20022.Setr016001.SecurityIdentification25Choice||XmlElement()||
|+|XpctdRlsDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Setr016001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmId),validElement(Amt))|

---

## Value ISO20022.Setr016001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Enum ISO20022.Setr016001.InRepairStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COMA|Int32||XmlEnum("""COMA""")|1|

---

## Value ISO20022.Setr016001.InRepairStatusReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.InRepairStatusReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Setr016001.InRepairStatusReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsnDtls|global::System.Collections.Generic.List<ISO20022.Setr016001.InRepairStatusReason4>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RsnDtls""",RsnDtls),validList("""RsnDtls""",RsnDtls),validListMax("""RsnDtls""",RsnDtls,5),validElement(RsnDtls),validChoice(RsnDtls,NoSpcfdRsn))|

---

## Value ISO20022.Setr016001.InRepairStatusReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.IndividualOrderStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GtgOrHldBckDtls|ISO20022.Setr016001.HoldBackInformation3||XmlElement()||
|+|NewDtls|ISO20022.Setr016001.ExpectedExecutionDetails4||XmlElement()||
|+|OrdrData|ISO20022.Setr016001.FundOrderData5||XmlElement()||
|+|StsInitr|ISO20022.Setr016001.PartyIdentification113||XmlElement()||
|+|RprdFee|global::System.Collections.Generic.List<ISO20022.Setr016001.Fee3>||XmlElement()||
|+|OrdrSts|ISO20022.Setr016001.OrderStatus5Choice||XmlElement()||
|+|CxlRef|String||XmlElement()||
|+|DealRef|String||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GtgOrHldBckDtls),validElement(NewDtls),validElement(OrdrData),validElement(StsInitr),validList("""RprdFee""",RprdFee),validListMax("""RprdFee""",RprdFee,10),validElement(RprdFee),validElement(OrdrSts))|

---

## Value ISO20022.Setr016001.InvestmentAccount58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Setr016001.SubAccount6||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|AcctSvcr|ISO20022.Setr016001.PartyIdentification113||XmlElement()||
|+|OwnrId|global::System.Collections.Generic.List<ISO20022.Setr016001.PartyIdentification113>||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(AcctSvcr),validList("""OwnrId""",OwnrId),validElement(OwnrId))|

---

## Enum ISO20022.Setr016001.InvestmentFundFee1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PENA|Int32||XmlEnum("""PENA""")|1|
||REGF|Int32||XmlEnum("""REGF""")|2|
||UCIC|Int32||XmlEnum("""UCIC""")|3|
||SWIT|Int32||XmlEnum("""SWIT""")|4|
||SHIP|Int32||XmlEnum("""SHIP""")|5|
||CHAR|Int32||XmlEnum("""CHAR""")|6|
||PREM|Int32||XmlEnum("""PREM""")|7|
||POST|Int32||XmlEnum("""POST""")|8|
||ADDF|Int32||XmlEnum("""ADDF""")|9|
||INIT|Int32||XmlEnum("""INIT""")|10|
||FEND|Int32||XmlEnum("""FEND""")|11|
||DLEV|Int32||XmlEnum("""DLEV""")|12|
||CBCH|Int32||XmlEnum("""CBCH""")|13|
||CDSC|Int32||XmlEnum("""CDSC""")|14|
||CDPL|Int32||XmlEnum("""CDPL""")|15|
||COMM|Int32||XmlEnum("""COMM""")|16|
||BRKF|Int32||XmlEnum("""BRKF""")|17|
||BEND|Int32||XmlEnum("""BEND""")|18|

---

## Value ISO20022.Setr016001.LegIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbcptLegId|String||XmlElement()||
|+|RedLegId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(SbcptLegId,RedLegId))|

---

## Value ISO20022.Setr016001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr016001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr016001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr016001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Aspect ISO20022.Setr016001.OrderInstructionStatusReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Setr016001.Extension1>||XmlElement()||
|+|StsRpt|ISO20022.Setr016001.Status24Choice||XmlElement()||
|+|Ref|ISO20022.Setr016001.References61Choice||XmlElement()||
|+|MsgId|ISO20022.Setr016001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(StsRpt),validElement(Ref),validElement(MsgId))|

---

## Enum ISO20022.Setr016001.OrderOriginatorEligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Setr016001.OrderStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlySttld|ISO20022.Setr016001.PartiallySettledStatus10||XmlElement()||
|+|Sspd|ISO20022.Setr016001.SuspendedStatusReason4Choice||XmlElement()||
|+|Rjctd|global::System.Collections.Generic.List<ISO20022.Setr016001.RejectedStatus9>||XmlElement()||
|+|CondlyAccptd|ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice||XmlElement()||
|+|Canc|ISO20022.Setr016001.CancelledStatusReason16||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtlySttld),validElement(Sspd),validRequired("""Rjctd""",Rjctd),validList("""Rjctd""",Rjctd),validListMax("""Rjctd""",Rjctd,10),validElement(Rjctd),validElement(CondlyAccptd),validElement(Canc),validChoice(PrtlySttld,Sspd,Rjctd,CondlyAccptd,Canc,Sts))|

---

## Value ISO20022.Setr016001.OrderStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlySttld|ISO20022.Setr016001.PartiallySettledStatus10||XmlElement()||
|+|InRpr|ISO20022.Setr016001.InRepairStatusReason4Choice||XmlElement()||
|+|Sspd|ISO20022.Setr016001.SuspendedStatusReason4Choice||XmlElement()||
|+|Rjctd|global::System.Collections.Generic.List<ISO20022.Setr016001.RejectedStatus9>||XmlElement()||
|+|CondlyAccptd|ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice||XmlElement()||
|+|Canc|ISO20022.Setr016001.CancelledStatusReason16||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtlySttld),validElement(InRpr),validElement(Sspd),validRequired("""Rjctd""",Rjctd),validList("""Rjctd""",Rjctd),validListMax("""Rjctd""",Rjctd,10),validElement(Rjctd),validElement(CondlyAccptd),validElement(Canc),validChoice(PrtlySttld,InRpr,Sspd,Rjctd,CondlyAccptd,Canc,Sts))|

---

## Enum ISO20022.Setr016001.OrderStatus4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IACO|Int32||XmlEnum("""IACO""")|1|
||OPOD|Int32||XmlEnum("""OPOD""")|2|
||DONF|Int32||XmlEnum("""DONF""")|3|
||DONE|Int32||XmlEnum("""DONE""")|4|
||CNFC|Int32||XmlEnum("""CNFC""")|5|
||CPNP|Int32||XmlEnum("""CPNP""")|6|
||SETT|Int32||XmlEnum("""SETT""")|7|
||RECE|Int32||XmlEnum("""RECE""")|8|
||STNP|Int32||XmlEnum("""STNP""")|9|
||COSE|Int32||XmlEnum("""COSE""")|10|
||PACK|Int32||XmlEnum("""PACK""")|11|

---

## Value ISO20022.Setr016001.OrderStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlySttld|ISO20022.Setr016001.PartiallySettledStatus10||XmlElement()||
|+|InRpr|ISO20022.Setr016001.InRepairStatusReason4Choice||XmlElement()||
|+|Sspd|ISO20022.Setr016001.SuspendedStatusReason4Choice||XmlElement()||
|+|Rjctd|global::System.Collections.Generic.List<ISO20022.Setr016001.RejectedStatus9>||XmlElement()||
|+|CondlyAccptd|ISO20022.Setr016001.ConditionallyAcceptedStatus3Choice||XmlElement()||
|+|Canc|ISO20022.Setr016001.CancelledStatusReason16||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtlySttld),validElement(InRpr),validElement(Sspd),validRequired("""Rjctd""",Rjctd),validList("""Rjctd""",Rjctd),validListMax("""Rjctd""",Rjctd,10),validElement(Rjctd),validElement(CondlyAccptd),validElement(Canc),validChoice(PrtlySttld,InRpr,Sspd,Rjctd,CondlyAccptd,Canc,Sts))|

---

## Value ISO20022.Setr016001.OrderStatusAndReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsInitr|ISO20022.Setr016001.PartyIdentification113||XmlElement()||
|+|OrdrSts|ISO20022.Setr016001.OrderStatus3Choice||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsInitr),validElement(OrdrSts))|

---

## Value ISO20022.Setr016001.PartiallySettled21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.PartiallySettledStatus10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.PartiallySettled21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Setr016001.PartyIdentification113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Setr016001.PartyIdentification90Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Setr016001.PartyIdentification90Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr016001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Setr016001.PostalAddress1


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

## Enum ISO20022.Setr016001.RedemptionCompletion1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RED1|Int32||XmlEnum("""RED1""")|1|
||RED0|Int32||XmlEnum("""RED0""")|2|

---

## Value ISO20022.Setr016001.References61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRef|global::System.Collections.Generic.List<ISO20022.Setr016001.AdditionalReference8>||XmlElement()||
|+|RltdRef|global::System.Collections.Generic.List<ISO20022.Setr016001.AdditionalReference8>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OthrRef""",OthrRef),validList("""OthrRef""",OthrRef),validListMax("""OthrRef""",OthrRef,2),validElement(OthrRef),validRequired("""RltdRef""",RltdRef),validList("""RltdRef""",RltdRef),validListMax("""RltdRef""",RltdRef,2),validElement(RltdRef),validChoice(OthrRef,RltdRef))|

---

## Value ISO20022.Setr016001.RejectedReason20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.RejectedStatus9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.RejectedReason20Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Enum ISO20022.Setr016001.RejectedStatusReason11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POIN|Int32||XmlEnum("""POIN""")|1|
||UNSC|Int32||XmlEnum("""UNSC""")|2|
||ULNK|Int32||XmlEnum("""ULNK""")|3|
||URSC|Int32||XmlEnum("""URSC""")|4|
||UPAY|Int32||XmlEnum("""UPAY""")|5|
||UNAV|Int32||XmlEnum("""UNAV""")|6|
||UDCY|Int32||XmlEnum("""UDCY""")|7|
||UWAI|Int32||XmlEnum("""UWAI""")|8|
||DTRD|Int32||XmlEnum("""DTRD""")|9|
||SLOW|Int32||XmlEnum("""SLOW""")|10|
||LATE|Int32||XmlEnum("""LATE""")|11|
||SHIG|Int32||XmlEnum("""SHIG""")|12|
||IEXE|Int32||XmlEnum("""IEXE""")|13|
||SETR|Int32||XmlEnum("""SETR""")|14|
||DEPT|Int32||XmlEnum("""DEPT""")|15|
||DDAT|Int32||XmlEnum("""DDAT""")|16|
||NCRR|Int32||XmlEnum("""NCRR""")|17|
||ISAF|Int32||XmlEnum("""ISAF""")|18|
||RTGS|Int32||XmlEnum("""RTGS""")|19|
||IVAG|Int32||XmlEnum("""IVAG""")|20|
||PLCE|Int32||XmlEnum("""PLCE""")|21|
||PHYS|Int32||XmlEnum("""PHYS""")|22|
||DLVY|Int32||XmlEnum("""DLVY""")|23|
||PRCT|Int32||XmlEnum("""PRCT""")|24|
||IPAY|Int32||XmlEnum("""IPAY""")|25|
||SECU|Int32||XmlEnum("""SECU""")|26|
||MONY|Int32||XmlEnum("""MONY""")|27|
||NSLA|Int32||XmlEnum("""NSLA""")|28|
||NRGM|Int32||XmlEnum("""NRGM""")|29|
||LOCK|Int32||XmlEnum("""LOCK""")|30|
||SAFE|Int32||XmlEnum("""SAFE""")|31|
||DMON|Int32||XmlEnum("""DMON""")|32|
||DFOR|Int32||XmlEnum("""DFOR""")|33|
||IOTP|Int32||XmlEnum("""IOTP""")|34|
||ICTR|Int32||XmlEnum("""ICTR""")|35|
||CASH|Int32||XmlEnum("""CASH""")|36|
||INTE|Int32||XmlEnum("""INTE""")|37|
||INSU|Int32||XmlEnum("""INSU""")|38|
||IPAC|Int32||XmlEnum("""IPAC""")|39|
||CLOS|Int32||XmlEnum("""CLOS""")|40|
||DQUA|Int32||XmlEnum("""DQUA""")|41|
||IDNA|Int32||XmlEnum("""IDNA""")|42|
||DSEC|Int32||XmlEnum("""DSEC""")|43|
||FEEE|Int32||XmlEnum("""FEEE""")|44|
||ORRF|Int32||XmlEnum("""ORRF""")|45|
||IDDB|Int32||XmlEnum("""IDDB""")|46|
||ICAG|Int32||XmlEnum("""ICAG""")|47|
||CUTO|Int32||XmlEnum("""CUTO""")|48|
||BMRV|Int32||XmlEnum("""BMRV""")|49|
||BMRA|Int32||XmlEnum("""BMRA""")|50|
||BMIN|Int32||XmlEnum("""BMIN""")|51|
||ILLI|Int32||XmlEnum("""ILLI""")|52|
||ADEA|Int32||XmlEnum("""ADEA""")|53|
||DOCC|Int32||XmlEnum("""DOCC""")|54|
||BLTR|Int32||XmlEnum("""BLTR""")|55|
||BLCA|Int32||XmlEnum("""BLCA""")|56|

---

## Value ISO20022.Setr016001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Setr016001.AlternateSecurityIdentification7||XmlElement()||
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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPrtryId),validPattern("""Blmbrg""",Blmbrg,"""(BBG)[BCDFGHJKLMNPQRSTVWXYZ\d]{8}\d"""),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN))|

---

## Value ISO20022.Setr016001.Series1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsNm|String||XmlElement()||
|+|SrsDt|ISO20022.Setr016001.DateFormat42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsDt))|

---

## Enum ISO20022.Setr016001.SettledStatusReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPST|Int32||XmlEnum("""UPST""")|1|
||UCPS|Int32||XmlEnum("""UCPS""")|2|
||GAT1|Int32||XmlEnum("""GAT1""")|3|
||GATM|Int32||XmlEnum("""GATM""")|4|
||CPST|Int32||XmlEnum("""CPST""")|5|

---

## Value ISO20022.Setr016001.Status24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SwtchOrdrDtlsRpt|global::System.Collections.Generic.List<ISO20022.Setr016001.SwitchOrderStatusAndReason2>||XmlElement()||
|+|IndvOrdrDtlsRpt|global::System.Collections.Generic.List<ISO20022.Setr016001.IndividualOrderStatusAndReason7>||XmlElement()||
|+|OrdrDtlsRpt|ISO20022.Setr016001.OrderStatusAndReason10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SwtchOrdrDtlsRpt""",SwtchOrdrDtlsRpt),validList("""SwtchOrdrDtlsRpt""",SwtchOrdrDtlsRpt),validElement(SwtchOrdrDtlsRpt),validRequired("""IndvOrdrDtlsRpt""",IndvOrdrDtlsRpt),validList("""IndvOrdrDtlsRpt""",IndvOrdrDtlsRpt),validElement(IndvOrdrDtlsRpt),validElement(OrdrDtlsRpt),validChoice(SwtchOrdrDtlsRpt,IndvOrdrDtlsRpt,OrdrDtlsRpt))|

---

## Value ISO20022.Setr016001.SubAccount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctDsgnt|String||XmlElement()||
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Setr016001.SuspendedStatusReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLOW|Int32||XmlEnum("""FLOW""")|1|
||PRIC|Int32||XmlEnum("""PRIC""")|2|

---

## Value ISO20022.Setr016001.SuspendedStatusReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr016001.SuspendedStatusReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Setr016001.SuspendedStatusReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsnDtls|global::System.Collections.Generic.List<ISO20022.Setr016001.SuspendedStatusReason4>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RsnDtls""",RsnDtls),validList("""RsnDtls""",RsnDtls),validListMax("""RsnDtls""",RsnDtls,5),validElement(RsnDtls),validChoice(RsnDtls,NoSpcfdRsn))|

---

## Value ISO20022.Setr016001.SuspendedStatusReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr016001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr016001.SwitchLegReferences2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmDtls|ISO20022.Setr016001.FinancialInstrument57||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr016001.InvestmentAccount58||XmlElement()||
|+|RprdFee|global::System.Collections.Generic.List<ISO20022.Setr016001.Fee3>||XmlElement()||
|+|LegRjctnRsn|String||XmlElement()||
|+|LegId|ISO20022.Setr016001.LegIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmDtls),validElement(InvstmtAcctDtls),validList("""RprdFee""",RprdFee),validListMax("""RprdFee""",RprdFee,10),validElement(RprdFee),validElement(LegId))|

---

## Value ISO20022.Setr016001.SwitchOrderStatusAndReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NewDtls|ISO20022.Setr016001.ExpectedExecutionDetails2||XmlElement()||
|+|OrdrData|ISO20022.Setr016001.FundOrderData6||XmlElement()||
|+|StsInitr|ISO20022.Setr016001.PartyIdentification113||XmlElement()||
|+|LegInf|global::System.Collections.Generic.List<ISO20022.Setr016001.SwitchLegReferences2>||XmlElement()||
|+|OrdrSts|ISO20022.Setr016001.OrderStatus4Choice||XmlElement()||
|+|CxlRef|String||XmlElement()||
|+|DealRef|String||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewDtls),validElement(OrdrData),validElement(StsInitr),validList("""LegInf""",LegInf),validElement(LegInf),validElement(OrdrSts))|

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

