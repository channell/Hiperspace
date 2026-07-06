# fxtr.031.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Fxtr031001.AccountIdentification26 {
        + Prtry  : ISO20022.Fxtr031001.SimpleIdentificationInformation4
    }
    ISO20022.Fxtr031001.AccountIdentification26 *-- ISO20022.Fxtr031001.SimpleIdentificationInformation4
    class ISO20022.Fxtr031001.AccountIdentification30 {
        + Id  : ISO20022.Fxtr031001.AccountIdentification26
        + AcctTp  : String
    }
    ISO20022.Fxtr031001.AccountIdentification30 *-- ISO20022.Fxtr031001.AccountIdentification26
    class ISO20022.Fxtr031001.AccountInformationType1Code {
        SSCA = 1
        SOCA = 2
        SCIN = 3
        SCIC = 4
        SCAN = 5
        MSAN = 6
        MSBS = 7
        NOCC = 8
        OMSA = 9
        SCAA = 10
        SCAC = 11
        NODC = 12
        MCAD = 13
        MSBN = 14
        MSAA = 15
        MCIN = 16
        MCIC = 17
        MCAN = 18
        MCAA = 19
        IBNC = 20
        IBBD = 21
        IBBC = 22
        FCBN = 23
        FCAN = 24
        FCAA = 25
        DEAC = 26
        CUAC = 27
        CBDC = 28
        CBCC = 29
        CBND = 30
        CBNC = 31
        CBBD = 32
        CBBC = 33
        CMSA = 34
        BIDC = 35
        BICC = 36
        BIND = 37
        BINC = 38
        BIBD = 39
        BIBC = 40
        IBDC = 41
        IBCC = 42
        IBND = 43
    }
    class ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr031001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr031001.AdditionalReferences2 {
        + RefIssr  : String
        + MsgNm  : String
        + Ref  : String
    }
    class ISO20022.Fxtr031001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Fxtr031001.AgreedRate3 {
        + QtdCcy  : String
        + UnitCcy  : String
        + XchgRate  : Decimal
    }
    class ISO20022.Fxtr031001.AlternateIdentification1 {
        + IdSrc  : ISO20022.Fxtr031001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Fxtr031001.AlternateIdentification1 *-- ISO20022.Fxtr031001.IdentificationSource1Choice
    class ISO20022.Fxtr031001.AmountAndCurrency2 {
        + Amt  : Decimal
        + Ccy  : String
    }
    class ISO20022.Fxtr031001.AmountsAndValueDate4 {
        + FnlSttlmDt  : DateTime
        + OptnSttlmCcy  : String
        + PutAmt  : ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount
        + CallAmt  : ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Fxtr031001.AmountsAndValueDate4 *-- ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Fxtr031001.AmountsAndValueDate4 *-- ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Fxtr031001.ClearingMethod1Code {
        NENE = 1
        NEMA = 2
        GRNE = 3
    }
    class ISO20022.Fxtr031001.DataType1Code {
        TRDA = 1
        EXDA = 2
    }
    class ISO20022.Fxtr031001.DerivativeExerciseStatus1Code {
        VALI = 1
        EXPI = 2
        EXEC = 3
    }
    class ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Fxtr031001.SupplementaryData1~
        + LastRptReqd  : String
        + TtlNbTrds  : Decimal
        + QryRjctRsn  : String
        + ReqRjctd  : String
        + ReqRspndr  : String
        + Ref  : ISO20022.Fxtr031001.AdditionalReferences2
        + TradDtl  : ISO20022.Fxtr031001.Trade7
        + CtrPtySdId  : ISO20022.Fxtr031001.TradePartyIdentification9
        + TradgSdId  : ISO20022.Fxtr031001.TradePartyIdentification9
        + RptId  : ISO20022.Fxtr031001.MessageIdentification1
        + Hdr  : ISO20022.Fxtr031001.Header23
    }
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.SupplementaryData1
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.AdditionalReferences2
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.Trade7
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.TradePartyIdentification9
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.TradePartyIdentification9
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.MessageIdentification1
    ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02 *-- ISO20022.Fxtr031001.Header23
    class ISO20022.Fxtr031001.FundIdentification6 {
        + CtdnId  : ISO20022.Fxtr031001.PartyIdentification251Choice
        + AcctIdWthCtdn  : String
        + FndId  : String
    }
    ISO20022.Fxtr031001.FundIdentification6 *-- ISO20022.Fxtr031001.PartyIdentification251Choice
    class ISO20022.Fxtr031001.GenericIdentification32 {
        + ShrtNm  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Fxtr031001.Header23 {
        + CreDtTm  : DateTime
        + MsgSeqNb  : Decimal
        + RcptPty  : ISO20022.Fxtr031001.GenericIdentification32
        + InitgPty  : ISO20022.Fxtr031001.GenericIdentification32
        + XchgId  : String
        + FrmtVrsn  : String
    }
    ISO20022.Fxtr031001.Header23 *-- ISO20022.Fxtr031001.GenericIdentification32
    ISO20022.Fxtr031001.Header23 *-- ISO20022.Fxtr031001.GenericIdentification32
    class ISO20022.Fxtr031001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Fxtr031001.IdentificationType1Code {
        CFET = 1
        BICO = 2
        BASC = 3
    }
    class ISO20022.Fxtr031001.IdentificationType2Code {
        USDE = 1
        RICC = 2
        CFET = 3
        CDCO = 4
    }
    class ISO20022.Fxtr031001.InstrumentLeg7 {
        + LegSctyId  : ISO20022.Fxtr031001.SecurityIdentification18
        + LegSymb  : String
        + LegCcy  : String
        + LegValDt  : DateTime
        + LegValtnRate  : ISO20022.Fxtr031001.AgreedRate3
        + LegRskAmt  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + LegClctdCtrPtyCcyLastQty  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + LegFwdPts  : Decimal
        + LegOrdrQty  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + LegSttlmCcy  : String
        + LegLastPric  : ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount
        + LegSttlmDt  : DateTime
        + LegSttlmTp  : String
        + LegSd  : String
    }
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.SecurityIdentification18
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.AgreedRate3
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.InstrumentLeg7 *-- ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Fxtr031001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Fxtr031001.NameAndAddress8 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + Adr  : ISO20022.Fxtr031001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Fxtr031001.NameAndAddress8 *-- ISO20022.Fxtr031001.PostalAddress1
    class ISO20022.Fxtr031001.Option16 {
        + AddtlOptnInf  : String
        + SttlmAmtTp  : String
        + Prm  : ISO20022.Fxtr031001.PremiumAmount3
        + OptnAmts  : ISO20022.Fxtr031001.AmountsAndValueDate4
        + SttlmTp  : String
        + XpryLctn  : String
        + XpryDtAndTm  : DateTime
        + RskAmt  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + VoltlyMrgn  : Decimal
        + StrkPric  : ISO20022.Fxtr031001.AgreedRate3
        + ValtnRate  : ISO20022.Fxtr031001.AgreedRate3
        + OptnPyoutTp  : String
        + DerivOptnId  : String
        + OptnTp  : String
        + ExrcStyle  : String
        + ExrcSts  : String
        + Data  : String
    }
    ISO20022.Fxtr031001.Option16 *-- ISO20022.Fxtr031001.PremiumAmount3
    ISO20022.Fxtr031001.Option16 *-- ISO20022.Fxtr031001.AmountsAndValueDate4
    ISO20022.Fxtr031001.Option16 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.Option16 *-- ISO20022.Fxtr031001.AgreedRate3
    ISO20022.Fxtr031001.Option16 *-- ISO20022.Fxtr031001.AgreedRate3
    class ISO20022.Fxtr031001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Fxtr031001.OptionParty3Code {
        TAKE = 1
        MAKE = 2
    }
    class ISO20022.Fxtr031001.OptionPayoutType1Code {
        VANI = 1
        CAPP = 2
        BINA = 3
    }
    class ISO20022.Fxtr031001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Fxtr031001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Fxtr031001.OrderStatus8Code {
        CANP = 1
        RECE = 2
        STNP = 3
        EXPI = 4
        REJT = 5
        STOP = 6
        REPL = 7
        NEWW = 8
        CANC = 9
    }
    class ISO20022.Fxtr031001.PartyIdentification251Choice {
        + AnyBIC  : ISO20022.Fxtr031001.PartyIdentification265
        + NmAndAdr  : ISO20022.Fxtr031001.NameAndAddress8
    }
    ISO20022.Fxtr031001.PartyIdentification251Choice *-- ISO20022.Fxtr031001.PartyIdentification265
    ISO20022.Fxtr031001.PartyIdentification251Choice *-- ISO20022.Fxtr031001.NameAndAddress8
    class ISO20022.Fxtr031001.PartyIdentification265 {
        + AltrntvIdr  : global::System.Collections.Generic.List~String~
        + AnyBIC  : String
    }
    class ISO20022.Fxtr031001.PartyIdentification78 {
        + TradPtyId  : String
        + PtySrc  : String
    }
    class ISO20022.Fxtr031001.PartyIdentification90 {
        + Id  : String
        + IdTp  : String
    }
    class ISO20022.Fxtr031001.PartyIdentificationAndAccount119 {
        + AcctId  : global::System.Collections.Generic.List~ISO20022.Fxtr031001.AccountIdentification30~
        + PtyId  : global::System.Collections.Generic.List~ISO20022.Fxtr031001.PartyIdentification90~
    }
    ISO20022.Fxtr031001.PartyIdentificationAndAccount119 *-- ISO20022.Fxtr031001.AccountIdentification30
    ISO20022.Fxtr031001.PartyIdentificationAndAccount119 *-- ISO20022.Fxtr031001.PartyIdentification90
    class ISO20022.Fxtr031001.PartyIdentificationType1Code {
        FLNF = 1
        FLCN = 2
        FIID = 3
        FICO = 4
        EXVE = 5
        ELCO = 6
        DEPA = 7
        DECN = 8
        CMIN = 9
        CONU = 10
        CMOT = 11
        COIN = 12
        CMID = 13
        CLIN = 14
        BRID = 15
        AUIT = 16
        USNA = 17
        USIT = 18
        TANA = 19
        TRCO = 20
        TACN = 21
        SLNF = 22
        SLCN = 23
        RMID = 24
        POAD = 25
        PONU = 26
        PASS = 27
        OSCO = 28
        NOMM = 29
        METY = 30
        MEOC = 31
        MAMA = 32
        IGBT = 33
        IICS = 34
        INGN = 35
        FXSN = 36
        FXID = 37
    }
    class ISO20022.Fxtr031001.PartyType3Code {
        DLIS = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
        OPOI = 7
    }
    class ISO20022.Fxtr031001.PartyType4Code {
        TAXH = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
    }
    class ISO20022.Fxtr031001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Fxtr031001.PremiumAmount3 {
        + RcvrPtyRef  : String
        + PyerPtyRef  : String
        + PrmSttlmDt  : DateTime
        + DcmlPlcs  : Decimal
        + Amt  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + PrmCcy  : String
        + PrmQt  : ISO20022.Fxtr031001.PremiumQuote1Choice
    }
    ISO20022.Fxtr031001.PremiumAmount3 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.PremiumAmount3 *-- ISO20022.Fxtr031001.PremiumQuote1Choice
    class ISO20022.Fxtr031001.PremiumQuote1Choice {
        + PtsOfPutAmt  : Decimal
        + PtsOfCallAmt  : Decimal
        + PctgOfPutAmt  : Decimal
        + PctgOfCallAmt  : Decimal
    }
    class ISO20022.Fxtr031001.SecurityIdentification18 {
        + SctyId  : String
        + SctyIdSrc  : String
    }
    class ISO20022.Fxtr031001.SecurityIdentification38Choice {
        + Cmon  : String
        + CTA  : String
        + Blmbrg  : String
        + TckrSymb  : String
        + RIC  : String
        + AltrnId  : ISO20022.Fxtr031001.AlternateIdentification1
        + ISIN  : String
    }
    ISO20022.Fxtr031001.SecurityIdentification38Choice *-- ISO20022.Fxtr031001.AlternateIdentification1
    class ISO20022.Fxtr031001.SettlementDate8Code {
        WHID = 1
        WISS = 2
        WDIS = 3
        WHIF = 4
        TTWO = 5
        TTRE = 6
        TONE = 7
        TFOR = 8
        TFIV = 9
        TBAT = 10
        SELL = 11
        SAVE = 12
        REGU = 13
        PRVD = 14
        FUTU = 15
        MONT = 16
        CLEA = 17
        CASH = 18
        ENDC = 19
        ASAP = 20
    }
    class ISO20022.Fxtr031001.SettlementType1Code {
        NETO = 1
        PRIN = 2
    }
    class ISO20022.Fxtr031001.Side1Code {
        UNDI = 1
        OPPO = 2
        DEFI = 3
        CSHE = 4
        CRSH = 5
        CROS = 6
        SSEX = 7
        SESH = 8
        SEPL = 9
        BUMI = 10
        TWOS = 11
        SELL = 12
        BUYI = 13
    }
    class ISO20022.Fxtr031001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Fxtr031001.SupplementaryData1 {
        + Envlp  : ISO20022.Fxtr031001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Fxtr031001.SupplementaryData1 *-- ISO20022.Fxtr031001.SupplementaryDataEnvelope1
    class ISO20022.Fxtr031001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Fxtr031001.Trade10 {
        + AssoctdTradRef  : global::System.Collections.Generic.List~String~
        + DltaInd  : String
        + OptnInd  : String
        + FxgDt  : DateTime
        + FxgCcy  : String
        + SctyId  : ISO20022.Fxtr031001.SecurityIdentification18
        + RskAmt  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + ValDt  : DateTime
        + ClctdCtrPtyCcyLastQty  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + FwdPts  : Decimal
        + ValtnRate  : ISO20022.Fxtr031001.AgreedRate3
        + SttlmDt  : DateTime
        + SttlmTp  : String
        + LastQty  : ISO20022.Fxtr031001.ActiveCurrencyAndAmount
        + ExctnPric  : ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.SecurityIdentification18
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.AgreedRate3
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.ActiveCurrencyAndAmount
    ISO20022.Fxtr031001.Trade10 *-- ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Fxtr031001.Trade7 {
        + DtConfd  : DateTime
        + TrgtCcyOrAmt  : ISO20022.Fxtr031001.AmountAndCurrency2
        + BaseCcyOrAmt  : ISO20022.Fxtr031001.AmountAndCurrency2
        + CmbntnDealTcktId  : String
        + DealTcktId  : String
        + ContraCcy  : String
        + PdctId  : ISO20022.Fxtr031001.SecurityIdentification38Choice
        + Optn  : ISO20022.Fxtr031001.Option16
        + SwpLeg  : global::System.Collections.Generic.List~ISO20022.Fxtr031001.InstrumentLeg7~
        + FXDtls  : ISO20022.Fxtr031001.Trade10
        + TxTm  : DateTime
        + PlcOfConf  : String
        + Symb  : String
        + ExctnTp  : String
        + ClrMtd  : String
        + TradgMd  : String
        + TradgMtd  : String
        + SttlmCcy  : String
        + TradgCcy  : String
        + FXTradPdct  : String
        + DtAndTm  : DateTime
        + TradId  : String
    }
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.AmountAndCurrency2
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.AmountAndCurrency2
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.SecurityIdentification38Choice
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.Option16
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.InstrumentLeg7
    ISO20022.Fxtr031001.Trade7 *-- ISO20022.Fxtr031001.Trade10
    class ISO20022.Fxtr031001.TradePartyIdentification9 {
        + SubmitgPty  : ISO20022.Fxtr031001.PartyIdentificationAndAccount119
        + TradPtyId  : ISO20022.Fxtr031001.PartyIdentification78
        + InitrInd  : String
        + BuyrOrSellrInd  : String
        + FndInf  : ISO20022.Fxtr031001.FundIdentification6
    }
    ISO20022.Fxtr031001.TradePartyIdentification9 *-- ISO20022.Fxtr031001.PartyIdentificationAndAccount119
    ISO20022.Fxtr031001.TradePartyIdentification9 *-- ISO20022.Fxtr031001.PartyIdentification78
    ISO20022.Fxtr031001.TradePartyIdentification9 *-- ISO20022.Fxtr031001.FundIdentification6
    class ISO20022.Fxtr031001.TradingMethodType1Code {
        ANCL = 1
        TEAU = 2
        QUAU = 3
        ONCT = 4
        NETR = 5
        LIOR = 6
        CUMA = 7
        CERB = 8
        BITR = 9
    }
    class ISO20022.Fxtr031001.TradingModeType1Code {
        ANON = 1
        BILA = 2
        MARC = 3
        AUCT = 4
        NETR = 5
        ORDR = 6
        QUDR = 7
    }
    class ISO20022.Fxtr031001.UnderlyingProductIdentifier1Code {
        SWAP = 1
        SPOT = 2
        NDFO = 3
        FORW = 4
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

## Value ISO20022.Fxtr031001.AccountIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Fxtr031001.SimpleIdentificationInformation4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Fxtr031001.AccountIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Fxtr031001.AccountIdentification26||XmlElement()||
|+|AcctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Enum ISO20022.Fxtr031001.AccountInformationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SSCA|Int32||XmlEnum("""SSCA""")|1|
||SOCA|Int32||XmlEnum("""SOCA""")|2|
||SCIN|Int32||XmlEnum("""SCIN""")|3|
||SCIC|Int32||XmlEnum("""SCIC""")|4|
||SCAN|Int32||XmlEnum("""SCAN""")|5|
||MSAN|Int32||XmlEnum("""MSAN""")|6|
||MSBS|Int32||XmlEnum("""MSBS""")|7|
||NOCC|Int32||XmlEnum("""NOCC""")|8|
||OMSA|Int32||XmlEnum("""OMSA""")|9|
||SCAA|Int32||XmlEnum("""SCAA""")|10|
||SCAC|Int32||XmlEnum("""SCAC""")|11|
||NODC|Int32||XmlEnum("""NODC""")|12|
||MCAD|Int32||XmlEnum("""MCAD""")|13|
||MSBN|Int32||XmlEnum("""MSBN""")|14|
||MSAA|Int32||XmlEnum("""MSAA""")|15|
||MCIN|Int32||XmlEnum("""MCIN""")|16|
||MCIC|Int32||XmlEnum("""MCIC""")|17|
||MCAN|Int32||XmlEnum("""MCAN""")|18|
||MCAA|Int32||XmlEnum("""MCAA""")|19|
||IBNC|Int32||XmlEnum("""IBNC""")|20|
||IBBD|Int32||XmlEnum("""IBBD""")|21|
||IBBC|Int32||XmlEnum("""IBBC""")|22|
||FCBN|Int32||XmlEnum("""FCBN""")|23|
||FCAN|Int32||XmlEnum("""FCAN""")|24|
||FCAA|Int32||XmlEnum("""FCAA""")|25|
||DEAC|Int32||XmlEnum("""DEAC""")|26|
||CUAC|Int32||XmlEnum("""CUAC""")|27|
||CBDC|Int32||XmlEnum("""CBDC""")|28|
||CBCC|Int32||XmlEnum("""CBCC""")|29|
||CBND|Int32||XmlEnum("""CBND""")|30|
||CBNC|Int32||XmlEnum("""CBNC""")|31|
||CBBD|Int32||XmlEnum("""CBBD""")|32|
||CBBC|Int32||XmlEnum("""CBBC""")|33|
||CMSA|Int32||XmlEnum("""CMSA""")|34|
||BIDC|Int32||XmlEnum("""BIDC""")|35|
||BICC|Int32||XmlEnum("""BICC""")|36|
||BIND|Int32||XmlEnum("""BIND""")|37|
||BINC|Int32||XmlEnum("""BINC""")|38|
||BIBD|Int32||XmlEnum("""BIBD""")|39|
||BIBC|Int32||XmlEnum("""BIBC""")|40|
||IBDC|Int32||XmlEnum("""IBDC""")|41|
||IBCC|Int32||XmlEnum("""IBCC""")|42|
||IBND|Int32||XmlEnum("""IBND""")|43|

---

## Value ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.AdditionalReferences2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefIssr|String||XmlElement()||
|+|MsgNm|String||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Fxtr031001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Fxtr031001.AgreedRate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.AlternateIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Fxtr031001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Fxtr031001.AmountAndCurrency2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.AmountsAndValueDate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FnlSttlmDt|DateTime||XmlElement()||
|+|OptnSttlmCcy|String||XmlElement()||
|+|PutAmt|ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CallAmt|ISO20022.Fxtr031001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OptnSttlmCcy""",OptnSttlmCcy,"""[A-Z]{3,3}"""),validElement(PutAmt),validElement(CallAmt))|

---

## Enum ISO20022.Fxtr031001.ClearingMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NENE|Int32||XmlEnum("""NENE""")|1|
||NEMA|Int32||XmlEnum("""NEMA""")|2|
||GRNE|Int32||XmlEnum("""GRNE""")|3|

---

## Enum ISO20022.Fxtr031001.DataType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRDA|Int32||XmlEnum("""TRDA""")|1|
||EXDA|Int32||XmlEnum("""EXDA""")|2|

---

## Enum ISO20022.Fxtr031001.DerivativeExerciseStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VALI|Int32||XmlEnum("""VALI""")|1|
||EXPI|Int32||XmlEnum("""EXPI""")|2|
||EXEC|Int32||XmlEnum("""EXEC""")|3|

---

## Type ISO20022.Fxtr031001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXTradCaptrRpt|ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXTradCaptrRpt))|

---

## Aspect ISO20022.Fxtr031001.ForeignExchangeTradeCaptureReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Fxtr031001.SupplementaryData1>||XmlElement()||
|+|LastRptReqd|String||XmlElement()||
|+|TtlNbTrds|Decimal||XmlElement()||
|+|QryRjctRsn|String||XmlElement()||
|+|ReqRjctd|String||XmlElement()||
|+|ReqRspndr|String||XmlElement()||
|+|Ref|ISO20022.Fxtr031001.AdditionalReferences2||XmlElement()||
|+|TradDtl|ISO20022.Fxtr031001.Trade7||XmlElement()||
|+|CtrPtySdId|ISO20022.Fxtr031001.TradePartyIdentification9||XmlElement()||
|+|TradgSdId|ISO20022.Fxtr031001.TradePartyIdentification9||XmlElement()||
|+|RptId|ISO20022.Fxtr031001.MessageIdentification1||XmlElement()||
|+|Hdr|ISO20022.Fxtr031001.Header23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Ref),validElement(TradDtl),validElement(CtrPtySdId),validElement(TradgSdId),validElement(RptId),validElement(Hdr))|

---

## Value ISO20022.Fxtr031001.FundIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtdnId|ISO20022.Fxtr031001.PartyIdentification251Choice||XmlElement()||
|+|AcctIdWthCtdn|String||XmlElement()||
|+|FndId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtdnId))|

---

## Value ISO20022.Fxtr031001.GenericIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.Header23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgSeqNb|Decimal||XmlElement()||
|+|RcptPty|ISO20022.Fxtr031001.GenericIdentification32||XmlElement()||
|+|InitgPty|ISO20022.Fxtr031001.GenericIdentification32||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|FrmtVrsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptPty),validElement(InitgPty),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Fxtr031001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Enum ISO20022.Fxtr031001.IdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CFET|Int32||XmlEnum("""CFET""")|1|
||BICO|Int32||XmlEnum("""BICO""")|2|
||BASC|Int32||XmlEnum("""BASC""")|3|

---

## Enum ISO20022.Fxtr031001.IdentificationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USDE|Int32||XmlEnum("""USDE""")|1|
||RICC|Int32||XmlEnum("""RICC""")|2|
||CFET|Int32||XmlEnum("""CFET""")|3|
||CDCO|Int32||XmlEnum("""CDCO""")|4|

---

## Value ISO20022.Fxtr031001.InstrumentLeg7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LegSctyId|ISO20022.Fxtr031001.SecurityIdentification18||XmlElement()||
|+|LegSymb|String||XmlElement()||
|+|LegCcy|String||XmlElement()||
|+|LegValDt|DateTime||XmlElement()||
|+|LegValtnRate|ISO20022.Fxtr031001.AgreedRate3||XmlElement()||
|+|LegRskAmt|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|LegClctdCtrPtyCcyLastQty|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|LegFwdPts|Decimal||XmlElement()||
|+|LegOrdrQty|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|LegSttlmCcy|String||XmlElement()||
|+|LegLastPric|ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|LegSttlmDt|DateTime||XmlElement()||
|+|LegSttlmTp|String||XmlElement()||
|+|LegSd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LegSctyId),validPattern("""LegCcy""",LegCcy,"""[A-Z]{3,3}"""),validElement(LegValtnRate),validElement(LegRskAmt),validElement(LegClctdCtrPtyCcyLastQty),validElement(LegOrdrQty),validPattern("""LegSttlmCcy""",LegSttlmCcy,"""[A-Z]{3,3}"""),validElement(LegLastPric))|

---

## Value ISO20022.Fxtr031001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.NameAndAddress8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Adr|ISO20022.Fxtr031001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validElement(Adr))|

---

## Value ISO20022.Fxtr031001.Option16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlOptnInf|String||XmlElement()||
|+|SttlmAmtTp|String||XmlElement()||
|+|Prm|ISO20022.Fxtr031001.PremiumAmount3||XmlElement()||
|+|OptnAmts|ISO20022.Fxtr031001.AmountsAndValueDate4||XmlElement()||
|+|SttlmTp|String||XmlElement()||
|+|XpryLctn|String||XmlElement()||
|+|XpryDtAndTm|DateTime||XmlElement()||
|+|RskAmt|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|VoltlyMrgn|Decimal||XmlElement()||
|+|StrkPric|ISO20022.Fxtr031001.AgreedRate3||XmlElement()||
|+|ValtnRate|ISO20022.Fxtr031001.AgreedRate3||XmlElement()||
|+|OptnPyoutTp|String||XmlElement()||
|+|DerivOptnId|String||XmlElement()||
|+|OptnTp|String||XmlElement()||
|+|ExrcStyle|String||XmlElement()||
|+|ExrcSts|String||XmlElement()||
|+|Data|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prm),validElement(OptnAmts),validPattern("""XpryLctn""",XpryLctn,"""[a-zA-Z0-9]{1,4}"""),validElement(RskAmt),validElement(StrkPric),validElement(ValtnRate))|

---

## Enum ISO20022.Fxtr031001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Enum ISO20022.Fxtr031001.OptionParty3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|

---

## Enum ISO20022.Fxtr031001.OptionPayoutType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VANI|Int32||XmlEnum("""VANI""")|1|
||CAPP|Int32||XmlEnum("""CAPP""")|2|
||BINA|Int32||XmlEnum("""BINA""")|3|

---

## Enum ISO20022.Fxtr031001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Enum ISO20022.Fxtr031001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Enum ISO20022.Fxtr031001.OrderStatus8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANP|Int32||XmlEnum("""CANP""")|1|
||RECE|Int32||XmlEnum("""RECE""")|2|
||STNP|Int32||XmlEnum("""STNP""")|3|
||EXPI|Int32||XmlEnum("""EXPI""")|4|
||REJT|Int32||XmlEnum("""REJT""")|5|
||STOP|Int32||XmlEnum("""STOP""")|6|
||REPL|Int32||XmlEnum("""REPL""")|7|
||NEWW|Int32||XmlEnum("""NEWW""")|8|
||CANC|Int32||XmlEnum("""CANC""")|9|

---

## Value ISO20022.Fxtr031001.PartyIdentification251Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|ISO20022.Fxtr031001.PartyIdentification265||XmlElement()||
|+|NmAndAdr|ISO20022.Fxtr031001.NameAndAddress8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AnyBIC),validElement(NmAndAdr),validChoice(AnyBIC,NmAndAdr))|

---

## Value ISO20022.Fxtr031001.PartyIdentification265


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrntvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AltrntvIdr""",AltrntvIdr,10),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Fxtr031001.PartyIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradPtyId|String||XmlElement()||
|+|PtySrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.PartyIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|IdTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.PartyIdentificationAndAccount119


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|global::System.Collections.Generic.List<ISO20022.Fxtr031001.AccountIdentification30>||XmlElement()||
|+|PtyId|global::System.Collections.Generic.List<ISO20022.Fxtr031001.PartyIdentification90>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctId""",AcctId),validList("""AcctId""",AcctId),validElement(AcctId),validRequired("""PtyId""",PtyId),validList("""PtyId""",PtyId),validElement(PtyId))|

---

## Enum ISO20022.Fxtr031001.PartyIdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLNF|Int32||XmlEnum("""FLNF""")|1|
||FLCN|Int32||XmlEnum("""FLCN""")|2|
||FIID|Int32||XmlEnum("""FIID""")|3|
||FICO|Int32||XmlEnum("""FICO""")|4|
||EXVE|Int32||XmlEnum("""EXVE""")|5|
||ELCO|Int32||XmlEnum("""ELCO""")|6|
||DEPA|Int32||XmlEnum("""DEPA""")|7|
||DECN|Int32||XmlEnum("""DECN""")|8|
||CMIN|Int32||XmlEnum("""CMIN""")|9|
||CONU|Int32||XmlEnum("""CONU""")|10|
||CMOT|Int32||XmlEnum("""CMOT""")|11|
||COIN|Int32||XmlEnum("""COIN""")|12|
||CMID|Int32||XmlEnum("""CMID""")|13|
||CLIN|Int32||XmlEnum("""CLIN""")|14|
||BRID|Int32||XmlEnum("""BRID""")|15|
||AUIT|Int32||XmlEnum("""AUIT""")|16|
||USNA|Int32||XmlEnum("""USNA""")|17|
||USIT|Int32||XmlEnum("""USIT""")|18|
||TANA|Int32||XmlEnum("""TANA""")|19|
||TRCO|Int32||XmlEnum("""TRCO""")|20|
||TACN|Int32||XmlEnum("""TACN""")|21|
||SLNF|Int32||XmlEnum("""SLNF""")|22|
||SLCN|Int32||XmlEnum("""SLCN""")|23|
||RMID|Int32||XmlEnum("""RMID""")|24|
||POAD|Int32||XmlEnum("""POAD""")|25|
||PONU|Int32||XmlEnum("""PONU""")|26|
||PASS|Int32||XmlEnum("""PASS""")|27|
||OSCO|Int32||XmlEnum("""OSCO""")|28|
||NOMM|Int32||XmlEnum("""NOMM""")|29|
||METY|Int32||XmlEnum("""METY""")|30|
||MEOC|Int32||XmlEnum("""MEOC""")|31|
||MAMA|Int32||XmlEnum("""MAMA""")|32|
||IGBT|Int32||XmlEnum("""IGBT""")|33|
||IICS|Int32||XmlEnum("""IICS""")|34|
||INGN|Int32||XmlEnum("""INGN""")|35|
||FXSN|Int32||XmlEnum("""FXSN""")|36|
||FXID|Int32||XmlEnum("""FXID""")|37|

---

## Enum ISO20022.Fxtr031001.PartyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLIS|Int32||XmlEnum("""DLIS""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|
||OPOI|Int32||XmlEnum("""OPOI""")|7|

---

## Enum ISO20022.Fxtr031001.PartyType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAXH|Int32||XmlEnum("""TAXH""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|

---

## Value ISO20022.Fxtr031001.PostalAddress1


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

## Value ISO20022.Fxtr031001.PremiumAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvrPtyRef|String||XmlElement()||
|+|PyerPtyRef|String||XmlElement()||
|+|PrmSttlmDt|DateTime||XmlElement()||
|+|DcmlPlcs|Decimal||XmlElement()||
|+|Amt|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrmCcy|String||XmlElement()||
|+|PrmQt|ISO20022.Fxtr031001.PremiumQuote1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validPattern("""PrmCcy""",PrmCcy,"""[A-Z]{3,3}"""),validElement(PrmQt))|

---

## Value ISO20022.Fxtr031001.PremiumQuote1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtsOfPutAmt|Decimal||XmlElement()||
|+|PtsOfCallAmt|Decimal||XmlElement()||
|+|PctgOfPutAmt|Decimal||XmlElement()||
|+|PctgOfCallAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(PtsOfPutAmt,PtsOfCallAmt,PctgOfPutAmt,PctgOfCallAmt))|

---

## Value ISO20022.Fxtr031001.SecurityIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyId|String||XmlElement()||
|+|SctyIdSrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.SecurityIdentification38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmon|String||XmlElement()||
|+|CTA|String||XmlElement()||
|+|Blmbrg|String||XmlElement()||
|+|TckrSymb|String||XmlElement()||
|+|RIC|String||XmlElement()||
|+|AltrnId|ISO20022.Fxtr031001.AlternateIdentification1||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Blmbrg""",Blmbrg,"""(BBG)[BCDFGHJKLMNPQRSTVWXYZ\d]{8}\d"""),validElement(AltrnId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Cmon,CTA,Blmbrg,TckrSymb,RIC,AltrnId,ISIN))|

---

## Enum ISO20022.Fxtr031001.SettlementDate8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WHID|Int32||XmlEnum("""WHID""")|1|
||WISS|Int32||XmlEnum("""WISS""")|2|
||WDIS|Int32||XmlEnum("""WDIS""")|3|
||WHIF|Int32||XmlEnum("""WHIF""")|4|
||TTWO|Int32||XmlEnum("""TTWO""")|5|
||TTRE|Int32||XmlEnum("""TTRE""")|6|
||TONE|Int32||XmlEnum("""TONE""")|7|
||TFOR|Int32||XmlEnum("""TFOR""")|8|
||TFIV|Int32||XmlEnum("""TFIV""")|9|
||TBAT|Int32||XmlEnum("""TBAT""")|10|
||SELL|Int32||XmlEnum("""SELL""")|11|
||SAVE|Int32||XmlEnum("""SAVE""")|12|
||REGU|Int32||XmlEnum("""REGU""")|13|
||PRVD|Int32||XmlEnum("""PRVD""")|14|
||FUTU|Int32||XmlEnum("""FUTU""")|15|
||MONT|Int32||XmlEnum("""MONT""")|16|
||CLEA|Int32||XmlEnum("""CLEA""")|17|
||CASH|Int32||XmlEnum("""CASH""")|18|
||ENDC|Int32||XmlEnum("""ENDC""")|19|
||ASAP|Int32||XmlEnum("""ASAP""")|20|

---

## Enum ISO20022.Fxtr031001.SettlementType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETO|Int32||XmlEnum("""NETO""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Enum ISO20022.Fxtr031001.Side1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNDI|Int32||XmlEnum("""UNDI""")|1|
||OPPO|Int32||XmlEnum("""OPPO""")|2|
||DEFI|Int32||XmlEnum("""DEFI""")|3|
||CSHE|Int32||XmlEnum("""CSHE""")|4|
||CRSH|Int32||XmlEnum("""CRSH""")|5|
||CROS|Int32||XmlEnum("""CROS""")|6|
||SSEX|Int32||XmlEnum("""SSEX""")|7|
||SESH|Int32||XmlEnum("""SESH""")|8|
||SEPL|Int32||XmlEnum("""SEPL""")|9|
||BUMI|Int32||XmlEnum("""BUMI""")|10|
||TWOS|Int32||XmlEnum("""TWOS""")|11|
||SELL|Int32||XmlEnum("""SELL""")|12|
||BUYI|Int32||XmlEnum("""BUYI""")|13|

---

## Value ISO20022.Fxtr031001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Fxtr031001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Fxtr031001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr031001.Trade10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AssoctdTradRef|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DltaInd|String||XmlElement()||
|+|OptnInd|String||XmlElement()||
|+|FxgDt|DateTime||XmlElement()||
|+|FxgCcy|String||XmlElement()||
|+|SctyId|ISO20022.Fxtr031001.SecurityIdentification18||XmlElement()||
|+|RskAmt|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|ClctdCtrPtyCcyLastQty|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|FwdPts|Decimal||XmlElement()||
|+|ValtnRate|ISO20022.Fxtr031001.AgreedRate3||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
|+|SttlmTp|String||XmlElement()||
|+|LastQty|ISO20022.Fxtr031001.ActiveCurrencyAndAmount||XmlElement()||
|+|ExctnPric|ISO20022.Fxtr031001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FxgCcy""",FxgCcy,"""[A-Z]{3,3}"""),validElement(SctyId),validElement(RskAmt),validElement(ClctdCtrPtyCcyLastQty),validElement(ValtnRate),validElement(LastQty),validElement(ExctnPric))|

---

## Value ISO20022.Fxtr031001.Trade7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtConfd|DateTime||XmlElement()||
|+|TrgtCcyOrAmt|ISO20022.Fxtr031001.AmountAndCurrency2||XmlElement()||
|+|BaseCcyOrAmt|ISO20022.Fxtr031001.AmountAndCurrency2||XmlElement()||
|+|CmbntnDealTcktId|String||XmlElement()||
|+|DealTcktId|String||XmlElement()||
|+|ContraCcy|String||XmlElement()||
|+|PdctId|ISO20022.Fxtr031001.SecurityIdentification38Choice||XmlElement()||
|+|Optn|ISO20022.Fxtr031001.Option16||XmlElement()||
|+|SwpLeg|global::System.Collections.Generic.List<ISO20022.Fxtr031001.InstrumentLeg7>||XmlElement()||
|+|FXDtls|ISO20022.Fxtr031001.Trade10||XmlElement()||
|+|TxTm|DateTime||XmlElement()||
|+|PlcOfConf|String||XmlElement()||
|+|Symb|String||XmlElement()||
|+|ExctnTp|String||XmlElement()||
|+|ClrMtd|String||XmlElement()||
|+|TradgMd|String||XmlElement()||
|+|TradgMtd|String||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
|+|TradgCcy|String||XmlElement()||
|+|FXTradPdct|String||XmlElement()||
|+|DtAndTm|DateTime||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrgtCcyOrAmt),validElement(BaseCcyOrAmt),validPattern("""ContraCcy""",ContraCcy,"""[A-Z]{3,3}"""),validElement(PdctId),validElement(Optn),validList("""SwpLeg""",SwpLeg),validElement(SwpLeg),validElement(FXDtls),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validPattern("""TradgCcy""",TradgCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Fxtr031001.TradePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubmitgPty|ISO20022.Fxtr031001.PartyIdentificationAndAccount119||XmlElement()||
|+|TradPtyId|ISO20022.Fxtr031001.PartyIdentification78||XmlElement()||
|+|InitrInd|String||XmlElement()||
|+|BuyrOrSellrInd|String||XmlElement()||
|+|FndInf|ISO20022.Fxtr031001.FundIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubmitgPty),validElement(TradPtyId),validElement(FndInf))|

---

## Enum ISO20022.Fxtr031001.TradingMethodType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANCL|Int32||XmlEnum("""ANCL""")|1|
||TEAU|Int32||XmlEnum("""TEAU""")|2|
||QUAU|Int32||XmlEnum("""QUAU""")|3|
||ONCT|Int32||XmlEnum("""ONCT""")|4|
||NETR|Int32||XmlEnum("""NETR""")|5|
||LIOR|Int32||XmlEnum("""LIOR""")|6|
||CUMA|Int32||XmlEnum("""CUMA""")|7|
||CERB|Int32||XmlEnum("""CERB""")|8|
||BITR|Int32||XmlEnum("""BITR""")|9|

---

## Enum ISO20022.Fxtr031001.TradingModeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANON|Int32||XmlEnum("""ANON""")|1|
||BILA|Int32||XmlEnum("""BILA""")|2|
||MARC|Int32||XmlEnum("""MARC""")|3|
||AUCT|Int32||XmlEnum("""AUCT""")|4|
||NETR|Int32||XmlEnum("""NETR""")|5|
||ORDR|Int32||XmlEnum("""ORDR""")|6|
||QUDR|Int32||XmlEnum("""QUDR""")|7|

---

## Enum ISO20022.Fxtr031001.UnderlyingProductIdentifier1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SWAP|Int32||XmlEnum("""SWAP""")|1|
||SPOT|Int32||XmlEnum("""SPOT""")|2|
||NDFO|Int32||XmlEnum("""NDFO""")|3|
||FORW|Int32||XmlEnum("""FORW""")|4|

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

