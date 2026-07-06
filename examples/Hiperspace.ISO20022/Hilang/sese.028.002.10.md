# sese.028.002.10
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese028002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese028002.IdentificationType44Choice
    }
    ISO20022.Sese028002.AlternatePartyIdentification9 *-- ISO20022.Sese028002.IdentificationType44Choice
    class ISO20022.Sese028002.AmountAndDirection59 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese028002.AmountAndDirection59 *-- ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese028002.AmountAndDirection72 {
        + FXDtls  : ISO20022.Sese028002.ForeignExchangeTerms27
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese028002.AmountAndDirection72 *-- ISO20022.Sese028002.ForeignExchangeTerms27
    ISO20022.Sese028002.AmountAndDirection72 *-- ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese028002.AmountAndDirection92 {
        + ValDt  : ISO20022.Sese028002.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese028002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese028002.AmountAndDirection92 *-- ISO20022.Sese028002.DateAndDateTime2Choice
    ISO20022.Sese028002.AmountAndDirection92 *-- ISO20022.Sese028002.ForeignExchangeTerms27
    ISO20022.Sese028002.AmountAndDirection92 *-- ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese028002.AmountAndDirection92 *-- ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese028002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese028002.BeneficialOwnership5Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese028002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese028002.BlockChainAddressWallet7 *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese028002.CashParties40 {
        + CdtrAgt  : ISO20022.Sese028002.PartyIdentificationAndAccount178
        + Cdtr  : ISO20022.Sese028002.PartyIdentificationAndAccount177
        + DbtrAgt  : ISO20022.Sese028002.PartyIdentificationAndAccount178
        + Dbtr  : ISO20022.Sese028002.PartyIdentificationAndAccount177
    }
    ISO20022.Sese028002.CashParties40 *-- ISO20022.Sese028002.PartyIdentificationAndAccount178
    ISO20022.Sese028002.CashParties40 *-- ISO20022.Sese028002.PartyIdentificationAndAccount177
    ISO20022.Sese028002.CashParties40 *-- ISO20022.Sese028002.PartyIdentificationAndAccount178
    ISO20022.Sese028002.CashParties40 *-- ISO20022.Sese028002.PartyIdentificationAndAccount177
    class ISO20022.Sese028002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese028002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.CashSettlementSystem5Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Sese028002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese028002.ClassificationType33Choice *-- ISO20022.Sese028002.GenericIdentification86
    class ISO20022.Sese028002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese028002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese028002.DateCode32Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.DateCode32Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese028002.DateType5Code {
        OPEN = 1
    }
    class ISO20022.Sese028002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese028002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese028002.FinancialInstrumentAttributes122 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese028002.SecurityIdentification20~
        + CtrctSz  : ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Sese028002.Price3
        + ConvsPric  : ISO20022.Sese028002.Price3
        + SbcptPric  : ISO20022.Sese028002.Price3
        + ExrcPric  : ISO20022.Sese028002.Price3
        + MktOrIndctvPric  : ISO20022.Sese028002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese028002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Sese028002.Number23Choice
        + IndxRateBsis  : Decimal
        + NxtIntrstRate  : Decimal
        + YldToMtrtyRate  : Decimal
        + IntrstRate  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + PrvsFctr  : Decimal
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + CpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnTp  : ISO20022.Sese028002.OptionType7Choice
        + OptnStyle  : ISO20022.Sese028002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Sese028002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Sese028002.Frequency27Choice
        + PmtSts  : ISO20022.Sese028002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Sese028002.Frequency27Choice
        + RegnForm  : ISO20022.Sese028002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Sese028002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Sese028002.MarketIdentification4Choice
    }
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.SecurityIdentification20
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.PriceType5Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.GenericIdentification39
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Number23Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.OptionType7Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.OptionStyle9Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.ClassificationType33Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Frequency27Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.SecuritiesPaymentStatus6Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.Frequency27Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.FormOfSecurity7Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.InterestComputationMethodFormat5Choice
    ISO20022.Sese028002.FinancialInstrumentAttributes122 *-- ISO20022.Sese028002.MarketIdentification4Choice
    class ISO20022.Sese028002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese028002.ForeignExchangeTerms27 {
        + RsltgAmt  : ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese028002.ForeignExchangeTerms27 *-- ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese028002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese028002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.FormOfSecurity7Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.Frequency27Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.Frequency27Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese028002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese028002.GenericIdentification47
    }
    ISO20022.Sese028002.GenericIdentification85 *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese028002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.IdentificationType44Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.InterestComputationMethod2Code {
        NARR = 1
        A014 = 2
        A013 = 3
        A012 = 4
        A011 = 5
        A010 = 6
        A009 = 7
        A008 = 8
        A007 = 9
        A006 = 10
        A005 = 11
        A004 = 12
        A003 = 13
        A002 = 14
        A001 = 15
    }
    class ISO20022.Sese028002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.InterestComputationMethodFormat5Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.LegalFramework1Code {
        FRAN = 1
    }
    class ISO20022.Sese028002.LegalFramework4Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.LegalFramework4Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese028002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.MarketClientSide7Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese028002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese028002.MarketIdentification90 {
        + Tp  : ISO20022.Sese028002.MarketType16Choice
        + Id  : ISO20022.Sese028002.MarketIdentification2Choice
    }
    ISO20022.Sese028002.MarketIdentification90 *-- ISO20022.Sese028002.MarketType16Choice
    ISO20022.Sese028002.MarketIdentification90 *-- ISO20022.Sese028002.MarketIdentification2Choice
    class ISO20022.Sese028002.MarketType16Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.MarketType16Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese028002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese028002.Number23Choice {
        + Lng  : ISO20022.Sese028002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Sese028002.Number23Choice *-- ISO20022.Sese028002.GenericIdentification18
    class ISO20022.Sese028002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese028002.OptionStyle9Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.OptionStyle9Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese028002.OptionType7Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.OptionType7Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.OtherAmounts36 {
        + CsmptnTax  : ISO20022.Sese028002.AmountAndDirection72
        + WhldgTax  : ISO20022.Sese028002.AmountAndDirection72
        + TxTax  : ISO20022.Sese028002.AmountAndDirection72
        + StmpDty  : ISO20022.Sese028002.AmountAndDirection72
        + Othr  : ISO20022.Sese028002.AmountAndDirection72
        + LclBrkrComssn  : ISO20022.Sese028002.AmountAndDirection72
        + LclTax  : ISO20022.Sese028002.AmountAndDirection72
        + ExctgBrkrAmt  : ISO20022.Sese028002.AmountAndDirection72
        + TradAmt  : ISO20022.Sese028002.AmountAndDirection72
        + ChrgsFees  : ISO20022.Sese028002.AmountAndDirection72
        + AcrdIntrstAmt  : ISO20022.Sese028002.AmountAndDirection72
    }
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    ISO20022.Sese028002.OtherAmounts36 *-- ISO20022.Sese028002.AmountAndDirection72
    class ISO20022.Sese028002.OtherIdentification2 {
        + Tp  : ISO20022.Sese028002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese028002.OtherIdentification2 *-- ISO20022.Sese028002.IdentificationSource4Choice
    class ISO20022.Sese028002.OtherParties37 {
        + TrptyAgt  : ISO20022.Sese028002.PartyIdentification157
        + TradRgltr  : ISO20022.Sese028002.PartyIdentification157
        + StockXchg  : ISO20022.Sese028002.PartyIdentification157
        + QlfdFrgnIntrmy  : ISO20022.Sese028002.PartyIdentification157
        + Invstr  : ISO20022.Sese028002.PartyIdentification170
    }
    ISO20022.Sese028002.OtherParties37 *-- ISO20022.Sese028002.PartyIdentification157
    ISO20022.Sese028002.OtherParties37 *-- ISO20022.Sese028002.PartyIdentification157
    ISO20022.Sese028002.OtherParties37 *-- ISO20022.Sese028002.PartyIdentification157
    ISO20022.Sese028002.OtherParties37 *-- ISO20022.Sese028002.PartyIdentification157
    ISO20022.Sese028002.OtherParties37 *-- ISO20022.Sese028002.PartyIdentification170
    class ISO20022.Sese028002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese028002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese028002.PartyIdentification136Choice *-- ISO20022.Sese028002.GenericIdentification84
    class ISO20022.Sese028002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese028002.NameAndAddress12
        + PrtryId  : ISO20022.Sese028002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese028002.PartyIdentification137Choice *-- ISO20022.Sese028002.NameAndAddress12
    ISO20022.Sese028002.PartyIdentification137Choice *-- ISO20022.Sese028002.GenericIdentification84
    class ISO20022.Sese028002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese028002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese028002.PartyIdentification145Choice *-- ISO20022.Sese028002.NameAndAddress12
    class ISO20022.Sese028002.PartyIdentification147Choice {
        + PrtryId  : ISO20022.Sese028002.GenericIdentification84
        + NmAndAdr  : ISO20022.Sese028002.NameAndAddress12
        + BICFI  : String
    }
    ISO20022.Sese028002.PartyIdentification147Choice *-- ISO20022.Sese028002.GenericIdentification84
    ISO20022.Sese028002.PartyIdentification147Choice *-- ISO20022.Sese028002.NameAndAddress12
    class ISO20022.Sese028002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification136Choice
    }
    ISO20022.Sese028002.PartyIdentification156 *-- ISO20022.Sese028002.PartyIdentification136Choice
    class ISO20022.Sese028002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification137Choice
    }
    ISO20022.Sese028002.PartyIdentification157 *-- ISO20022.Sese028002.PartyIdentification137Choice
    class ISO20022.Sese028002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese028002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese028002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese028002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification145Choice
    }
    ISO20022.Sese028002.PartyIdentification162 *-- ISO20022.Sese028002.PartyTextInformation3
    ISO20022.Sese028002.PartyIdentification162 *-- ISO20022.Sese028002.DateAndDateTime2Choice
    ISO20022.Sese028002.PartyIdentification162 *-- ISO20022.Sese028002.AlternatePartyIdentification9
    ISO20022.Sese028002.PartyIdentification162 *-- ISO20022.Sese028002.PartyIdentification145Choice
    class ISO20022.Sese028002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification176Choice
    }
    ISO20022.Sese028002.PartyIdentification170 *-- ISO20022.Sese028002.PartyIdentification176Choice
    class ISO20022.Sese028002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese028002.NameAndAddress12
        + PrtryId  : ISO20022.Sese028002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese028002.PartyIdentification176Choice *-- ISO20022.Sese028002.NameAndAddress12
    ISO20022.Sese028002.PartyIdentification176Choice *-- ISO20022.Sese028002.GenericIdentification84
    class ISO20022.Sese028002.PartyIdentificationAndAccount177 {
        + AddtlInf  : ISO20022.Sese028002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese028002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification137Choice
    }
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.PartyTextInformation4
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.AlternatePartyIdentification9
    ISO20022.Sese028002.PartyIdentificationAndAccount177 *-- ISO20022.Sese028002.PartyIdentification137Choice
    class ISO20022.Sese028002.PartyIdentificationAndAccount178 {
        + AddtlInf  : ISO20022.Sese028002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese028002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification147Choice
    }
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.PartyTextInformation4
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.AlternatePartyIdentification9
    ISO20022.Sese028002.PartyIdentificationAndAccount178 *-- ISO20022.Sese028002.PartyIdentification147Choice
    class ISO20022.Sese028002.PartyIdentificationAndAccount206 {
        + AddtlInf  : ISO20022.Sese028002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese028002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese028002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese028002.SecuritiesAccount30
        + AltrnId  : ISO20022.Sese028002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese028002.PartyIdentification137Choice
    }
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.PartyTextInformation3
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.DateAndDateTime2Choice
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.BlockChainAddressWallet7
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.SecuritiesAccount30
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.AlternatePartyIdentification9
    ISO20022.Sese028002.PartyIdentificationAndAccount206 *-- ISO20022.Sese028002.PartyIdentification137Choice
    class ISO20022.Sese028002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese028002.PartyTextInformation4 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese028002.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese028002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese028002.MarketIdentification90
    }
    ISO20022.Sese028002.PlaceOfTradeIdentification2 *-- ISO20022.Sese028002.MarketIdentification90
    class ISO20022.Sese028002.Price11 {
        + Val  : ISO20022.Sese028002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese028002.YieldedOrValueType2Choice
    }
    ISO20022.Sese028002.Price11 *-- ISO20022.Sese028002.PriceRateOrAmount1Choice
    ISO20022.Sese028002.Price11 *-- ISO20022.Sese028002.YieldedOrValueType2Choice
    class ISO20022.Sese028002.Price3 {
        + Val  : ISO20022.Sese028002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese028002.YieldedOrValueType1Choice
    }
    ISO20022.Sese028002.Price3 *-- ISO20022.Sese028002.PriceRateOrAmount1Choice
    ISO20022.Sese028002.Price3 *-- ISO20022.Sese028002.YieldedOrValueType1Choice
    class ISO20022.Sese028002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese028002.PriceRateOrAmount1Choice *-- ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese028002.PriceType5Choice {
        + Indctv  : ISO20022.Sese028002.Price3
        + Mkt  : ISO20022.Sese028002.Price3
    }
    ISO20022.Sese028002.PriceType5Choice *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.PriceType5Choice *-- ISO20022.Sese028002.Price3
    class ISO20022.Sese028002.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese028002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese028002.QuantityAndAccount106 {
        + SfkpgPlc  : ISO20022.Sese028002.SafeKeepingPlace4
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese028002.QuantityBreakdown69~
        + CshAcct  : ISO20022.Sese028002.CashAccountIdentification6Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese028002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese028002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese028002.PartyIdentification156
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.SafeKeepingPlace4
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.QuantityBreakdown69
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.CashAccountIdentification6Choice
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.BlockChainAddressWallet7
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.SecuritiesAccount30
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.PartyIdentification156
    ISO20022.Sese028002.QuantityAndAccount106 *-- ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese028002.QuantityBreakdown69 {
        + TpOfPric  : ISO20022.Sese028002.TypeOfPrice32Choice
        + LotPric  : ISO20022.Sese028002.Price3
        + LotDtTm  : ISO20022.Sese028002.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Sese028002.GenericIdentification39
    }
    ISO20022.Sese028002.QuantityBreakdown69 *-- ISO20022.Sese028002.TypeOfPrice32Choice
    ISO20022.Sese028002.QuantityBreakdown69 *-- ISO20022.Sese028002.Price3
    ISO20022.Sese028002.QuantityBreakdown69 *-- ISO20022.Sese028002.DateAndDateTime2Choice
    ISO20022.Sese028002.QuantityBreakdown69 *-- ISO20022.Sese028002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese028002.QuantityBreakdown69 *-- ISO20022.Sese028002.GenericIdentification39
    class ISO20022.Sese028002.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Sese028002.RateName2 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Sese028002.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Sese028002.RateType67Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.RateType67Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese028002.Registration11Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.Registration11Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese028002.RepurchaseType17Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.RepurchaseType17Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.RepurchaseType6Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
    }
    class ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese028002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese028002.SafeKeepingPlace4 *-- ISO20022.Sese028002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese028002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese028002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese028002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification85
        + TpAndId  : ISO20022.Sese028002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese028002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese028002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese028002.GenericIdentification85
    ISO20022.Sese028002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese028002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese028002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese028002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese028002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese028002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese028002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese028002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese028002.SecuritiesAccount30 *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 {
        + ScndLegNrrtv  : String
        + TermntnTxAmt  : ISO20022.Sese028002.AmountAndDirection59
        + AcrdIntrstAmt  : ISO20022.Sese028002.AmountAndDirection59
        + TxCallDely  : String
        + RpRate  : ISO20022.Sese028002.Rate2
        + VarblRateSpprt  : ISO20022.Sese028002.RateName2
        + IntrstPmt  : String
        + MtrtyDtMod  : String
        + LglFrmwk  : ISO20022.Sese028002.LegalFramework4Choice
        + RateTp  : ISO20022.Sese028002.RateType67Choice
        + TermntnDt  : ISO20022.Sese028002.TerminationDate7Choice
        + ClsgLegId  : String
        + SctiesFincgTradId  : String
    }
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.AmountAndDirection59
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.AmountAndDirection59
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.Rate2
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.RateName2
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.LegalFramework4Choice
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.RateType67Choice
    ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50 *-- ISO20022.Sese028002.TerminationDate7Choice
    class ISO20022.Sese028002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese028002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.SecuritiesPaymentStatus6Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese028002.SecuritiesRTGS5Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese028002.SupplementaryData1~
        + OthrBizPties  : ISO20022.Sese028002.OtherParties37
        + OthrAmts  : ISO20022.Sese028002.OtherAmounts36
        + SttlmAmt  : ISO20022.Sese028002.AmountAndDirection92
        + CshPties  : ISO20022.Sese028002.CashParties40
        + RcvgSttlmPties  : ISO20022.Sese028002.SettlementParties105
        + DlvrgSttlmPties  : ISO20022.Sese028002.SettlementParties105
        + SttlmParams  : ISO20022.Sese028002.SettlementDetails191
        + SctiesFincgDtls  : ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50
        + QtyAndAcctDtls  : ISO20022.Sese028002.QuantityAndAccount106
        + FinInstrmAttrbts  : ISO20022.Sese028002.FinancialInstrumentAttributes122
        + FinInstrmId  : ISO20022.Sese028002.SecurityIdentification20
        + TradDtls  : ISO20022.Sese028002.SecuritiesTradeDetails126
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + SttlmTpAndAddtlParams  : ISO20022.Sese028002.SettlementTypeAndAdditionalParameters15
        + TxId  : String
    }
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SupplementaryData1
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.OtherParties37
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.OtherAmounts36
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.AmountAndDirection92
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.CashParties40
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SettlementParties105
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SettlementParties105
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SettlementDetails191
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.QuantityAndAccount106
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.FinancialInstrumentAttributes122
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SecurityIdentification20
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SecuritiesTradeDetails126
    ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10 *-- ISO20022.Sese028002.SettlementTypeAndAdditionalParameters15
    class ISO20022.Sese028002.SecuritiesTradeDetails126 {
        + TpOfPric  : ISO20022.Sese028002.TypeOfPrice32Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese028002.TradeTransactionCondition6Choice~
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese028002.Price11
        + SttlmDt  : ISO20022.Sese028002.SettlementDate20Choice
        + TradDt  : ISO20022.Sese028002.TradeDate9Choice
        + PlcOfClr  : ISO20022.Sese028002.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese028002.PlaceOfTradeIdentification2
        + PrcrTxId  : String
        + AcctOwnrTxId  : global::System.Collections.Generic.List~String~
        + CollTxId  : global::System.Collections.Generic.List~String~
        + TradId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.TypeOfPrice32Choice
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.TradeTransactionCondition6Choice
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.Price11
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.SettlementDate20Choice
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.TradeDate9Choice
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.PlaceOfClearingIdentification2
    ISO20022.Sese028002.SecuritiesTradeDetails126 *-- ISO20022.Sese028002.PlaceOfTradeIdentification2
    class ISO20022.Sese028002.SecuritiesTransactionType24Code {
        REDI = 1
        TURN = 2
        TRVO = 3
        TRPO = 4
        TRAD = 5
        SYND = 6
        SWIT = 7
        SWIF = 8
        SUBS = 9
        SBBK = 10
        SECL = 11
        SECB = 12
        RVPO = 13
        REPU = 14
        REDM = 15
        REAL = 16
        PORT = 17
        PLAC = 18
        PAIR = 19
        NSYN = 20
        NETT = 21
        MKUP = 22
        CLAI = 23
        MKDW = 24
        ISSU = 25
        OWNI = 26
        OWNE = 27
        ETFT = 28
        RELE = 29
        CONV = 30
        CORP = 31
        COLO = 32
        COLI = 33
        CNCB = 34
        BSBK = 35
        BYIY = 36
        AUTO = 37
    }
    class ISO20022.Sese028002.SecuritiesTransactionType49Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.SecuritiesTransactionType49Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese028002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese028002.SecurityIdentification20 *-- ISO20022.Sese028002.OtherIdentification2
    class ISO20022.Sese028002.SettlementDate20Choice {
        + DtCd  : ISO20022.Sese028002.SettlementDateCode9Choice
        + Dt  : ISO20022.Sese028002.DateAndDateTime2Choice
    }
    ISO20022.Sese028002.SettlementDate20Choice *-- ISO20022.Sese028002.SettlementDateCode9Choice
    ISO20022.Sese028002.SettlementDate20Choice *-- ISO20022.Sese028002.DateAndDateTime2Choice
    class ISO20022.Sese028002.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese028002.SettlementDateCode9Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.SettlementDateCode9Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SettlementDetails191 {
        + StmpDtyTaxBsis  : ISO20022.Sese028002.GenericIdentification47
        + SctiesRTGS  : ISO20022.Sese028002.SecuritiesRTGS5Choice
        + RpTp  : ISO20022.Sese028002.RepurchaseType17Choice
        + Regn  : ISO20022.Sese028002.Registration11Choice
        + MktClntSd  : ISO20022.Sese028002.MarketClientSide7Choice
        + CshClrSys  : ISO20022.Sese028002.CashSettlementSystem5Choice
        + BnfclOwnrsh  : ISO20022.Sese028002.BeneficialOwnership5Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese028002.SettlementTransactionCondition36Choice~
        + SctiesTxTp  : ISO20022.Sese028002.SecuritiesTransactionType49Choice
        + HldInd  : String
    }
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.GenericIdentification47
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.SecuritiesRTGS5Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.RepurchaseType17Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.Registration11Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.MarketClientSide7Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.CashSettlementSystem5Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.BeneficialOwnership5Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.SettlementTransactionCondition36Choice
    ISO20022.Sese028002.SettlementDetails191 *-- ISO20022.Sese028002.SecuritiesTransactionType49Choice
    class ISO20022.Sese028002.SettlementParties105 {
        + Pty5  : ISO20022.Sese028002.PartyIdentificationAndAccount206
        + Pty4  : ISO20022.Sese028002.PartyIdentificationAndAccount206
        + Pty3  : ISO20022.Sese028002.PartyIdentificationAndAccount206
        + Pty2  : ISO20022.Sese028002.PartyIdentificationAndAccount206
        + Pty1  : ISO20022.Sese028002.PartyIdentificationAndAccount206
        + Dpstry  : ISO20022.Sese028002.PartyIdentification162
    }
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentificationAndAccount206
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentificationAndAccount206
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentificationAndAccount206
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentificationAndAccount206
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentificationAndAccount206
    ISO20022.Sese028002.SettlementParties105 *-- ISO20022.Sese028002.PartyIdentification162
    class ISO20022.Sese028002.SettlementTransactionCondition13Code {
        BPSS = 1
        NOMC = 2
        SPST = 3
        SPDL = 4
        PHYS = 5
        DLWM = 6
        DIRT = 7
        CLEN = 8
    }
    class ISO20022.Sese028002.SettlementTransactionCondition36Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.SettlementTransactionCondition36Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese028002.SettlementTypeAndAdditionalParameters15 {
        + CmonId  : String
        + Pmt  : String
        + SctiesMvmntTp  : String
    }
    class ISO20022.Sese028002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese028002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese028002.SupplementaryData1 *-- ISO20022.Sese028002.SupplementaryDataEnvelope1
    class ISO20022.Sese028002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese028002.TerminationDate7Choice {
        + Cd  : ISO20022.Sese028002.DateCode32Choice
        + Dt  : ISO20022.Sese028002.DateAndDateTime2Choice
    }
    ISO20022.Sese028002.TerminationDate7Choice *-- ISO20022.Sese028002.DateCode32Choice
    ISO20022.Sese028002.TerminationDate7Choice *-- ISO20022.Sese028002.DateAndDateTime2Choice
    class ISO20022.Sese028002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese028002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese028002.DateAndDateTime2Choice
    }
    ISO20022.Sese028002.TradeDate9Choice *-- ISO20022.Sese028002.TradeDateCode4Choice
    ISO20022.Sese028002.TradeDate9Choice *-- ISO20022.Sese028002.DateAndDateTime2Choice
    class ISO20022.Sese028002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.TradeDateCode4Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.TradeTransactionCondition4Code {
        BCPD = 1
        NMPR = 2
        NEGO = 3
        MAPR = 4
        BCBN = 5
        BCBL = 6
        BCFD = 7
        BCRP = 8
        BCRO = 9
        GTDL = 10
        SPEX = 11
        SPCU = 12
        XWAR = 13
        CWAR = 14
        XRTS = 15
        CRTS = 16
        XDIV = 17
        CDIV = 18
        XCPN = 19
        CCPN = 20
        XBNS = 21
        CBNS = 22
    }
    class ISO20022.Sese028002.TradeTransactionCondition6Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.TradeTransactionCondition6Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese028002.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese028002.TypeOfPrice32Choice {
        + Prtry  : ISO20022.Sese028002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese028002.TypeOfPrice32Choice *-- ISO20022.Sese028002.GenericIdentification47
    class ISO20022.Sese028002.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese028002.YieldedOrValueType2Choice {
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

## Value ISO20022.Sese028002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese028002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese028002.AmountAndDirection59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese028002.AmountAndDirection72


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese028002.ForeignExchangeTerms27||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(Amt))|

---

## Value ISO20022.Sese028002.AmountAndDirection92


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese028002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese028002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese028002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese028002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese028002.CashParties40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAgt|ISO20022.Sese028002.PartyIdentificationAndAccount178||XmlElement()||
|+|Cdtr|ISO20022.Sese028002.PartyIdentificationAndAccount177||XmlElement()||
|+|DbtrAgt|ISO20022.Sese028002.PartyIdentificationAndAccount178||XmlElement()||
|+|Dbtr|ISO20022.Sese028002.PartyIdentificationAndAccount177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese028002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese028002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese028002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese028002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese028002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese028002.DateCode32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese028002.DateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Sese028002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese028002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxAllgmtNtfctn|ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxAllgmtNtfctn))|

---

## Enum ISO20022.Sese028002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Sese028002.FinancialInstrumentAttributes122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese028002.SecurityIdentification20>||XmlElement()||
|+|CtrctSz|ISO20022.Sese028002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese028002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese028002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Sese028002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Sese028002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Sese028002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese028002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese028002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese028002.Number23Choice||XmlElement()||
|+|IndxRateBsis|Decimal||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|YldToMtrtyRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|CpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnTp|ISO20022.Sese028002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese028002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese028002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese028002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese028002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese028002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese028002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese028002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese028002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese028002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese028002.ForeignExchangeTerms27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese028002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese028002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Sese028002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese028002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese028002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.InterestComputationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NARR|Int32||XmlEnum("""NARR""")|1|
||A014|Int32||XmlEnum("""A014""")|2|
||A013|Int32||XmlEnum("""A013""")|3|
||A012|Int32||XmlEnum("""A012""")|4|
||A011|Int32||XmlEnum("""A011""")|5|
||A010|Int32||XmlEnum("""A010""")|6|
||A009|Int32||XmlEnum("""A009""")|7|
||A008|Int32||XmlEnum("""A008""")|8|
||A007|Int32||XmlEnum("""A007""")|9|
||A006|Int32||XmlEnum("""A006""")|10|
||A005|Int32||XmlEnum("""A005""")|11|
||A004|Int32||XmlEnum("""A004""")|12|
||A003|Int32||XmlEnum("""A003""")|13|
||A002|Int32||XmlEnum("""A002""")|14|
||A001|Int32||XmlEnum("""A001""")|15|

---

## Value ISO20022.Sese028002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.LegalFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAN|Int32||XmlEnum("""FRAN""")|1|

---

## Value ISO20022.Sese028002.LegalFramework4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese028002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese028002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese028002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese028002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Sese028002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese028002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese028002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese028002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese028002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese028002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese028002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese028002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.OtherAmounts36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CsmptnTax|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|WhldgTax|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|TxTax|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|StmpDty|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|Othr|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|LclTax|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|TradAmt|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|ChrgsFees|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese028002.AmountAndDirection72||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CsmptnTax),validElement(WhldgTax),validElement(TxTax),validElement(StmpDty),validElement(Othr),validElement(LclBrkrComssn),validElement(LclTax),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese028002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese028002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese028002.OtherParties37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgt|ISO20022.Sese028002.PartyIdentification157||XmlElement()||
|+|TradRgltr|ISO20022.Sese028002.PartyIdentification157||XmlElement()||
|+|StockXchg|ISO20022.Sese028002.PartyIdentification157||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese028002.PartyIdentification157||XmlElement()||
|+|Invstr|ISO20022.Sese028002.PartyIdentification170||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validElement(Invstr))|

---

## Value ISO20022.Sese028002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese028002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese028002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese028002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese028002.PartyIdentification147Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese028002.GenericIdentification84||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028002.NameAndAddress12||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese028002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese028002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028002.PartyIdentificationAndAccount177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentificationAndAccount178


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification147Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyIdentificationAndAccount206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese028002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese028002.SecuritiesAccount30||XmlElement()||
|+|AltrnId|ISO20022.Sese028002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese028002.PartyTextInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese028002.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese028002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese028002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese028002.Price11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese028002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese028002.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese028002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese028002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese028002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese028002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese028002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese028002.Price3||XmlElement()||
|+|Mkt|ISO20022.Sese028002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese028002.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese028002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese028002.QuantityAndAccount106


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Sese028002.SafeKeepingPlace4||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese028002.QuantityBreakdown69>||XmlElement()||
|+|CshAcct|ISO20022.Sese028002.CashAccountIdentification6Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese028002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese028002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese028002.PartyIdentification156||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese028002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""DnmtnChc""",DnmtnChc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(SttlmQty))|

---

## Value ISO20022.Sese028002.QuantityBreakdown69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese028002.TypeOfPrice32Choice||XmlElement()||
|+|LotPric|ISO20022.Sese028002.Price3||XmlElement()||
|+|LotDtTm|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese028002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Sese028002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Sese028002.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028002.RateName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RateNm""",RateNm,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Issr""",Issr,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,8}"""))|

---

## Enum ISO20022.Sese028002.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Sese028002.RateType67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese028002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese028002.RepurchaseType17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.RepurchaseType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|

---

## Value ISO20022.Sese028002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese028002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese028002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese028002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese028002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese028002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese028002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese028002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese028002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese028002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese028002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLegNrrtv|String||XmlElement()||
|+|TermntnTxAmt|ISO20022.Sese028002.AmountAndDirection59||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese028002.AmountAndDirection59||XmlElement()||
|+|TxCallDely|String||XmlElement()||
|+|RpRate|ISO20022.Sese028002.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Sese028002.RateName2||XmlElement()||
|+|IntrstPmt|String||XmlElement()||
|+|MtrtyDtMod|String||XmlElement()||
|+|LglFrmwk|ISO20022.Sese028002.LegalFramework4Choice||XmlElement()||
|+|RateTp|ISO20022.Sese028002.RateType67Choice||XmlElement()||
|+|TermntnDt|ISO20022.Sese028002.TerminationDate7Choice||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|SctiesFincgTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ScndLegNrrtv""",ScndLegNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validElement(TermntnTxAmt),validElement(AcrdIntrstAmt),validPattern("""TxCallDely""",TxCallDely,"""[0-9]{3}"""),validElement(RpRate),validElement(VarblRateSpprt),validElement(LglFrmwk),validElement(RateTp),validElement(TermntnDt),validPattern("""ClsgLegId""",ClsgLegId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""SctiesFincgTradId""",SctiesFincgTradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese028002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese028002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese028002.SecuritiesSettlementTransactionAllegementNotification002V10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese028002.SupplementaryData1>||XmlElement()||
|+|OthrBizPties|ISO20022.Sese028002.OtherParties37||XmlElement()||
|+|OthrAmts|ISO20022.Sese028002.OtherAmounts36||XmlElement()||
|+|SttlmAmt|ISO20022.Sese028002.AmountAndDirection92||XmlElement()||
|+|CshPties|ISO20022.Sese028002.CashParties40||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese028002.SettlementParties105||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese028002.SettlementParties105||XmlElement()||
|+|SttlmParams|ISO20022.Sese028002.SettlementDetails191||XmlElement()||
|+|SctiesFincgDtls|ISO20022.Sese028002.SecuritiesFinancingTransactionDetails50||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese028002.QuantityAndAccount106||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese028002.FinancialInstrumentAttributes122||XmlElement()||
|+|FinInstrmId|ISO20022.Sese028002.SecurityIdentification20||XmlElement()||
|+|TradDtls|ISO20022.Sese028002.SecuritiesTradeDetails126||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|SttlmTpAndAddtlParams|ISO20022.Sese028002.SettlementTypeAndAdditionalParameters15||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(SctiesFincgDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(SttlmTpAndAddtlParams),validPattern("""TxId""",TxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.SecuritiesTradeDetails126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese028002.TypeOfPrice32Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese028002.TradeTransactionCondition6Choice>||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese028002.Price11||XmlElement()||
|+|SttlmDt|ISO20022.Sese028002.SettlementDate20Choice||XmlElement()||
|+|TradDt|ISO20022.Sese028002.TradeDate9Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese028002.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese028002.PlaceOfTradeIdentification2||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TradId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(DealPric),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CollTxId""",CollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TradId""",TradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese028002.SecuritiesTransactionType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REDI|Int32||XmlEnum("""REDI""")|1|
||TURN|Int32||XmlEnum("""TURN""")|2|
||TRVO|Int32||XmlEnum("""TRVO""")|3|
||TRPO|Int32||XmlEnum("""TRPO""")|4|
||TRAD|Int32||XmlEnum("""TRAD""")|5|
||SYND|Int32||XmlEnum("""SYND""")|6|
||SWIT|Int32||XmlEnum("""SWIT""")|7|
||SWIF|Int32||XmlEnum("""SWIF""")|8|
||SUBS|Int32||XmlEnum("""SUBS""")|9|
||SBBK|Int32||XmlEnum("""SBBK""")|10|
||SECL|Int32||XmlEnum("""SECL""")|11|
||SECB|Int32||XmlEnum("""SECB""")|12|
||RVPO|Int32||XmlEnum("""RVPO""")|13|
||REPU|Int32||XmlEnum("""REPU""")|14|
||REDM|Int32||XmlEnum("""REDM""")|15|
||REAL|Int32||XmlEnum("""REAL""")|16|
||PORT|Int32||XmlEnum("""PORT""")|17|
||PLAC|Int32||XmlEnum("""PLAC""")|18|
||PAIR|Int32||XmlEnum("""PAIR""")|19|
||NSYN|Int32||XmlEnum("""NSYN""")|20|
||NETT|Int32||XmlEnum("""NETT""")|21|
||MKUP|Int32||XmlEnum("""MKUP""")|22|
||CLAI|Int32||XmlEnum("""CLAI""")|23|
||MKDW|Int32||XmlEnum("""MKDW""")|24|
||ISSU|Int32||XmlEnum("""ISSU""")|25|
||OWNI|Int32||XmlEnum("""OWNI""")|26|
||OWNE|Int32||XmlEnum("""OWNE""")|27|
||ETFT|Int32||XmlEnum("""ETFT""")|28|
||RELE|Int32||XmlEnum("""RELE""")|29|
||CONV|Int32||XmlEnum("""CONV""")|30|
||CORP|Int32||XmlEnum("""CORP""")|31|
||COLO|Int32||XmlEnum("""COLO""")|32|
||COLI|Int32||XmlEnum("""COLI""")|33|
||CNCB|Int32||XmlEnum("""CNCB""")|34|
||BSBK|Int32||XmlEnum("""BSBK""")|35|
||BYIY|Int32||XmlEnum("""BYIY""")|36|
||AUTO|Int32||XmlEnum("""AUTO""")|37|

---

## Value ISO20022.Sese028002.SecuritiesTransactionType49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese028002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese028002.SettlementDate20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese028002.SettlementDateCode9Choice||XmlElement()||
|+|Dt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese028002.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese028002.SettlementDateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.SettlementDetails191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmpDtyTaxBsis|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese028002.SecuritiesRTGS5Choice||XmlElement()||
|+|RpTp|ISO20022.Sese028002.RepurchaseType17Choice||XmlElement()||
|+|Regn|ISO20022.Sese028002.Registration11Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese028002.MarketClientSide7Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese028002.CashSettlementSystem5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese028002.BeneficialOwnership5Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese028002.SettlementTransactionCondition36Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese028002.SecuritiesTransactionType49Choice||XmlElement()||
|+|HldInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmpDtyTaxBsis),validElement(SctiesRTGS),validElement(RpTp),validElement(Regn),validElement(MktClntSd),validElement(CshClrSys),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp))|

---

## Value ISO20022.Sese028002.SettlementParties105


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese028002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty4|ISO20022.Sese028002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty3|ISO20022.Sese028002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty2|ISO20022.Sese028002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty1|ISO20022.Sese028002.PartyIdentificationAndAccount206||XmlElement()||
|+|Dpstry|ISO20022.Sese028002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese028002.SettlementTransactionCondition13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BPSS|Int32||XmlEnum("""BPSS""")|1|
||NOMC|Int32||XmlEnum("""NOMC""")|2|
||SPST|Int32||XmlEnum("""SPST""")|3|
||SPDL|Int32||XmlEnum("""SPDL""")|4|
||PHYS|Int32||XmlEnum("""PHYS""")|5|
||DLWM|Int32||XmlEnum("""DLWM""")|6|
||DIRT|Int32||XmlEnum("""DIRT""")|7|
||CLEN|Int32||XmlEnum("""CLEN""")|8|

---

## Value ISO20022.Sese028002.SettlementTransactionCondition36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Value ISO20022.Sese028002.SettlementTypeAndAdditionalParameters15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmonId|String||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese028002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese028002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese028002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028002.TerminationDate7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Sese028002.DateCode32Choice||XmlElement()||
|+|Dt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Sese028002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese028002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese028002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese028002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.TradeTransactionCondition4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BCPD|Int32||XmlEnum("""BCPD""")|1|
||NMPR|Int32||XmlEnum("""NMPR""")|2|
||NEGO|Int32||XmlEnum("""NEGO""")|3|
||MAPR|Int32||XmlEnum("""MAPR""")|4|
||BCBN|Int32||XmlEnum("""BCBN""")|5|
||BCBL|Int32||XmlEnum("""BCBL""")|6|
||BCFD|Int32||XmlEnum("""BCFD""")|7|
||BCRP|Int32||XmlEnum("""BCRP""")|8|
||BCRO|Int32||XmlEnum("""BCRO""")|9|
||GTDL|Int32||XmlEnum("""GTDL""")|10|
||SPEX|Int32||XmlEnum("""SPEX""")|11|
||SPCU|Int32||XmlEnum("""SPCU""")|12|
||XWAR|Int32||XmlEnum("""XWAR""")|13|
||CWAR|Int32||XmlEnum("""CWAR""")|14|
||XRTS|Int32||XmlEnum("""XRTS""")|15|
||CRTS|Int32||XmlEnum("""CRTS""")|16|
||XDIV|Int32||XmlEnum("""XDIV""")|17|
||CDIV|Int32||XmlEnum("""CDIV""")|18|
||XCPN|Int32||XmlEnum("""XCPN""")|19|
||CCPN|Int32||XmlEnum("""CCPN""")|20|
||XBNS|Int32||XmlEnum("""XBNS""")|21|
||CBNS|Int32||XmlEnum("""CBNS""")|22|

---

## Value ISO20022.Sese028002.TradeTransactionCondition6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028002.TypeOfIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||DRLC|Int32||XmlEnum("""DRLC""")|3|
||CORP|Int32||XmlEnum("""CORP""")|4|
||CHTY|Int32||XmlEnum("""CHTY""")|5|
||CCPT|Int32||XmlEnum("""CCPT""")|6|
||ARNU|Int32||XmlEnum("""ARNU""")|7|

---

## Enum ISO20022.Sese028002.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese028002.TypeOfPrice32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028002.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese028002.YieldedOrValueType2Choice


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

