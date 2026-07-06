# sese.028.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese028001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese028001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese028001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese028001.IdentificationType42Choice
    }
    ISO20022.Sese028001.AlternatePartyIdentification7 *-- ISO20022.Sese028001.IdentificationType42Choice
    class ISO20022.Sese028001.AmountAndDirection21 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese028001.AmountAndDirection21 *-- ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese028001.AmountAndDirection47 {
        + FXDtls  : ISO20022.Sese028001.ForeignExchangeTerms23
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese028001.AmountAndDirection47 *-- ISO20022.Sese028001.ForeignExchangeTerms23
    ISO20022.Sese028001.AmountAndDirection47 *-- ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese028001.AmountAndDirection88 {
        + ValDt  : ISO20022.Sese028001.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese028001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese028001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese028001.AmountAndDirection88 *-- ISO20022.Sese028001.DateAndDateTime2Choice
    ISO20022.Sese028001.AmountAndDirection88 *-- ISO20022.Sese028001.ForeignExchangeTerms23
    ISO20022.Sese028001.AmountAndDirection88 *-- ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese028001.AmountAndDirection88 *-- ISO20022.Sese028001.ActiveCurrencyAndAmount
    class ISO20022.Sese028001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese028001.BeneficialOwnership4Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese028001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese028001.BlockChainAddressWallet3 *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese028001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Sese028001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Sese028001.CashAccountIdentification9Choice *-- ISO20022.Sese028001.BlockChainAddressWallet3
    class ISO20022.Sese028001.CashParties42 {
        + CdtrAgt  : ISO20022.Sese028001.PartyIdentificationAndAccount224
        + Cdtr  : ISO20022.Sese028001.PartyIdentificationAndAccount223
        + DbtrAgt  : ISO20022.Sese028001.PartyIdentificationAndAccount224
        + Dbtr  : ISO20022.Sese028001.PartyIdentificationAndAccount223
    }
    ISO20022.Sese028001.CashParties42 *-- ISO20022.Sese028001.PartyIdentificationAndAccount224
    ISO20022.Sese028001.CashParties42 *-- ISO20022.Sese028001.PartyIdentificationAndAccount223
    ISO20022.Sese028001.CashParties42 *-- ISO20022.Sese028001.PartyIdentificationAndAccount224
    ISO20022.Sese028001.CashParties42 *-- ISO20022.Sese028001.PartyIdentificationAndAccount223
    class ISO20022.Sese028001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese028001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.CashSettlementSystem4Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese028001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese028001.ClassificationType32Choice *-- ISO20022.Sese028001.GenericIdentification36
    class ISO20022.Sese028001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese028001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese028001.DateCode18Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.DateCode18Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese028001.DateType5Code {
        OPEN = 1
    }
    class ISO20022.Sese028001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese028001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese028001.FinancialInstrumentAttributes111 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese028001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Sese028001.Price7
        + ConvsPric  : ISO20022.Sese028001.Price7
        + SbcptPric  : ISO20022.Sese028001.Price7
        + ExrcPric  : ISO20022.Sese028001.Price7
        + MktOrIndctvPric  : ISO20022.Sese028001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese028001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Sese028001.Number22Choice
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
        + OptnTp  : ISO20022.Sese028001.OptionType6Choice
        + OptnStyle  : ISO20022.Sese028001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Sese028001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Sese028001.Frequency23Choice
        + PmtSts  : ISO20022.Sese028001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Sese028001.Frequency23Choice
        + RegnForm  : ISO20022.Sese028001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Sese028001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Sese028001.MarketIdentification3Choice
    }
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.SecurityIdentification19
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.PriceType4Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.GenericIdentification37
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Number22Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.OptionType6Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.OptionStyle8Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.ClassificationType32Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Frequency23Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.SecuritiesPaymentStatus5Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.Frequency23Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.FormOfSecurity6Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.InterestComputationMethodFormat4Choice
    ISO20022.Sese028001.FinancialInstrumentAttributes111 *-- ISO20022.Sese028001.MarketIdentification3Choice
    class ISO20022.Sese028001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese028001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese028001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese028001.ForeignExchangeTerms23 *-- ISO20022.Sese028001.ActiveCurrencyAndAmount
    class ISO20022.Sese028001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese028001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.FormOfSecurity6Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.Frequency23Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.Frequency23Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese028001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese028001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese028001.GenericIdentification30
    }
    ISO20022.Sese028001.GenericIdentification78 *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese028001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.IdentificationType42Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.InterestComputationMethod2Code {
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
    class ISO20022.Sese028001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.InterestComputationMethodFormat4Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.LegalFramework1Code {
        FRAN = 1
    }
    class ISO20022.Sese028001.LegalFramework3Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.LegalFramework3Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese028001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.MarketClientSide6Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese028001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese028001.MarketIdentification84 {
        + Tp  : ISO20022.Sese028001.MarketType8Choice
        + Id  : ISO20022.Sese028001.MarketIdentification1Choice
    }
    ISO20022.Sese028001.MarketIdentification84 *-- ISO20022.Sese028001.MarketType8Choice
    ISO20022.Sese028001.MarketIdentification84 *-- ISO20022.Sese028001.MarketIdentification1Choice
    class ISO20022.Sese028001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese028001.MarketType8Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.MarketType8Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.NameAndAddress5 {
        + Adr  : ISO20022.Sese028001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese028001.NameAndAddress5 *-- ISO20022.Sese028001.PostalAddress1
    class ISO20022.Sese028001.Number22Choice {
        + Lng  : ISO20022.Sese028001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Sese028001.Number22Choice *-- ISO20022.Sese028001.GenericIdentification1
    class ISO20022.Sese028001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese028001.OptionStyle8Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.OptionStyle8Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese028001.OptionType6Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.OptionType6Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.OtherAmounts32 {
        + CsmptnTax  : ISO20022.Sese028001.AmountAndDirection47
        + WhldgTax  : ISO20022.Sese028001.AmountAndDirection47
        + TxTax  : ISO20022.Sese028001.AmountAndDirection47
        + StmpDty  : ISO20022.Sese028001.AmountAndDirection47
        + Othr  : ISO20022.Sese028001.AmountAndDirection47
        + LclBrkrComssn  : ISO20022.Sese028001.AmountAndDirection47
        + LclTax  : ISO20022.Sese028001.AmountAndDirection47
        + ExctgBrkrAmt  : ISO20022.Sese028001.AmountAndDirection47
        + TradAmt  : ISO20022.Sese028001.AmountAndDirection47
        + ChrgsFees  : ISO20022.Sese028001.AmountAndDirection47
        + AcrdIntrstAmt  : ISO20022.Sese028001.AmountAndDirection47
    }
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    ISO20022.Sese028001.OtherAmounts32 *-- ISO20022.Sese028001.AmountAndDirection47
    class ISO20022.Sese028001.OtherIdentification1 {
        + Tp  : ISO20022.Sese028001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese028001.OtherIdentification1 *-- ISO20022.Sese028001.IdentificationSource3Choice
    class ISO20022.Sese028001.OtherParties34 {
        + TrptyAgt  : ISO20022.Sese028001.PartyIdentification136
        + TradRgltr  : ISO20022.Sese028001.PartyIdentification136
        + StockXchg  : ISO20022.Sese028001.PartyIdentification136
        + QlfdFrgnIntrmy  : ISO20022.Sese028001.PartyIdentification136
        + Invstr  : ISO20022.Sese028001.PartyIdentification149
    }
    ISO20022.Sese028001.OtherParties34 *-- ISO20022.Sese028001.PartyIdentification136
    ISO20022.Sese028001.OtherParties34 *-- ISO20022.Sese028001.PartyIdentification136
    ISO20022.Sese028001.OtherParties34 *-- ISO20022.Sese028001.PartyIdentification136
    ISO20022.Sese028001.OtherParties34 *-- ISO20022.Sese028001.PartyIdentification136
    ISO20022.Sese028001.OtherParties34 *-- ISO20022.Sese028001.PartyIdentification149
    class ISO20022.Sese028001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese028001.NameAndAddress5
        + PrtryId  : ISO20022.Sese028001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese028001.PartyIdentification120Choice *-- ISO20022.Sese028001.NameAndAddress5
    ISO20022.Sese028001.PartyIdentification120Choice *-- ISO20022.Sese028001.GenericIdentification36
    class ISO20022.Sese028001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese028001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese028001.PartyIdentification127Choice *-- ISO20022.Sese028001.GenericIdentification36
    class ISO20022.Sese028001.PartyIdentification133Choice {
        + PrtryId  : ISO20022.Sese028001.GenericIdentification36
        + NmAndAdr  : ISO20022.Sese028001.NameAndAddress5
        + BICFI  : String
    }
    ISO20022.Sese028001.PartyIdentification133Choice *-- ISO20022.Sese028001.GenericIdentification36
    ISO20022.Sese028001.PartyIdentification133Choice *-- ISO20022.Sese028001.NameAndAddress5
    class ISO20022.Sese028001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese028001.NameAndAddress5
        + PrtryId  : ISO20022.Sese028001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese028001.PartyIdentification134Choice *-- ISO20022.Sese028001.NameAndAddress5
    ISO20022.Sese028001.PartyIdentification134Choice *-- ISO20022.Sese028001.GenericIdentification36
    class ISO20022.Sese028001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification120Choice
    }
    ISO20022.Sese028001.PartyIdentification136 *-- ISO20022.Sese028001.PartyIdentification120Choice
    class ISO20022.Sese028001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification127Choice
    }
    ISO20022.Sese028001.PartyIdentification144 *-- ISO20022.Sese028001.PartyIdentification127Choice
    class ISO20022.Sese028001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification134Choice
    }
    ISO20022.Sese028001.PartyIdentification149 *-- ISO20022.Sese028001.PartyIdentification134Choice
    class ISO20022.Sese028001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese028001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese028001.PartyIdentification257Choice *-- ISO20022.Sese028001.NameAndAddress5
    class ISO20022.Sese028001.PartyIdentification315 {
        + AddtlInf  : ISO20022.Sese028001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese028001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese028001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification257Choice
    }
    ISO20022.Sese028001.PartyIdentification315 *-- ISO20022.Sese028001.PartyTextInformation1
    ISO20022.Sese028001.PartyIdentification315 *-- ISO20022.Sese028001.DateAndDateTime2Choice
    ISO20022.Sese028001.PartyIdentification315 *-- ISO20022.Sese028001.AlternatePartyIdentification7
    ISO20022.Sese028001.PartyIdentification315 *-- ISO20022.Sese028001.PartyIdentification257Choice
    class ISO20022.Sese028001.PartyIdentificationAndAccount196 {
        + AddtlInf  : ISO20022.Sese028001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese028001.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese028001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese028001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese028001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification120Choice
    }
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.PartyTextInformation1
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.DateAndDateTime2Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.BlockChainAddressWallet3
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.SecuritiesAccount19
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.AlternatePartyIdentification7
    ISO20022.Sese028001.PartyIdentificationAndAccount196 *-- ISO20022.Sese028001.PartyIdentification120Choice
    class ISO20022.Sese028001.PartyIdentificationAndAccount223 {
        + AddtlInf  : ISO20022.Sese028001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese028001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese028001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification120Choice
    }
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.PartyTextInformation2
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.CashAccountIdentification9Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.AlternatePartyIdentification7
    ISO20022.Sese028001.PartyIdentificationAndAccount223 *-- ISO20022.Sese028001.PartyIdentification120Choice
    class ISO20022.Sese028001.PartyIdentificationAndAccount224 {
        + AddtlInf  : ISO20022.Sese028001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese028001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese028001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese028001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese028001.PartyIdentification133Choice
    }
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.PartyTextInformation2
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.CashAccountIdentification5Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.CashAccountIdentification9Choice
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.AlternatePartyIdentification7
    ISO20022.Sese028001.PartyIdentificationAndAccount224 *-- ISO20022.Sese028001.PartyIdentification133Choice
    class ISO20022.Sese028001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese028001.PartyTextInformation2 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese028001.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese028001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese028001.MarketIdentification84
    }
    ISO20022.Sese028001.PlaceOfTradeIdentification1 *-- ISO20022.Sese028001.MarketIdentification84
    class ISO20022.Sese028001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese028001.Price10 {
        + Val  : ISO20022.Sese028001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese028001.YieldedOrValueType2Choice
    }
    ISO20022.Sese028001.Price10 *-- ISO20022.Sese028001.PriceRateOrAmount3Choice
    ISO20022.Sese028001.Price10 *-- ISO20022.Sese028001.YieldedOrValueType2Choice
    class ISO20022.Sese028001.Price7 {
        + Val  : ISO20022.Sese028001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese028001.YieldedOrValueType1Choice
    }
    ISO20022.Sese028001.Price7 *-- ISO20022.Sese028001.PriceRateOrAmount3Choice
    ISO20022.Sese028001.Price7 *-- ISO20022.Sese028001.YieldedOrValueType1Choice
    class ISO20022.Sese028001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Sese028001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese028001.PriceRateOrAmount3Choice *-- ISO20022.Sese028001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese028001.PriceType4Choice {
        + Indctv  : ISO20022.Sese028001.Price7
        + Mkt  : ISO20022.Sese028001.Price7
    }
    ISO20022.Sese028001.PriceType4Choice *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.PriceType4Choice *-- ISO20022.Sese028001.Price7
    class ISO20022.Sese028001.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese028001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese028001.QuantityAndAccount116 {
        + SfkpgPlc  : ISO20022.Sese028001.SafeKeepingPlace5
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese028001.QuantityBreakdown62~
        + CshAcct  : ISO20022.Sese028001.CashAccountIdentification9Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese028001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese028001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese028001.PartyIdentification144
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.SafeKeepingPlace5
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.QuantityBreakdown62
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.CashAccountIdentification9Choice
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.BlockChainAddressWallet3
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.SecuritiesAccount19
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.PartyIdentification144
    ISO20022.Sese028001.QuantityAndAccount116 *-- ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese028001.QuantityBreakdown62 {
        + TpOfPric  : ISO20022.Sese028001.TypeOfPrice29Choice
        + LotPric  : ISO20022.Sese028001.Price7
        + LotDtTm  : ISO20022.Sese028001.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Sese028001.GenericIdentification37
    }
    ISO20022.Sese028001.QuantityBreakdown62 *-- ISO20022.Sese028001.TypeOfPrice29Choice
    ISO20022.Sese028001.QuantityBreakdown62 *-- ISO20022.Sese028001.Price7
    ISO20022.Sese028001.QuantityBreakdown62 *-- ISO20022.Sese028001.DateAndDateTime2Choice
    ISO20022.Sese028001.QuantityBreakdown62 *-- ISO20022.Sese028001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese028001.QuantityBreakdown62 *-- ISO20022.Sese028001.GenericIdentification37
    class ISO20022.Sese028001.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Sese028001.RateName1 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Sese028001.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Sese028001.RateType35Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.RateType35Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese028001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese028001.Registration9Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.Registration9Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.RepurchaseType13Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.RepurchaseType13Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.RepurchaseType6Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
    }
    class ISO20022.Sese028001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese028001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Sese028001.SafeKeepingPlace5 *-- ISO20022.Sese028001.SafekeepingPlaceFormat41Choice
    class ISO20022.Sese028001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese028001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese028001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification78
        + TpAndId  : ISO20022.Sese028001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Sese028001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Sese028001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese028001.GenericIdentification78
    ISO20022.Sese028001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese028001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese028001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese028001.SafekeepingPlaceTypeAndText8
    class ISO20022.Sese028001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese028001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese028001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese028001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese028001.SecuritiesAccount19 *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 {
        + ScndLegNrrtv  : String
        + TermntnTxAmt  : ISO20022.Sese028001.AmountAndDirection21
        + AcrdIntrstAmt  : ISO20022.Sese028001.AmountAndDirection21
        + TxCallDely  : String
        + RpRate  : ISO20022.Sese028001.Rate2
        + VarblRateSpprt  : ISO20022.Sese028001.RateName1
        + IntrstPmt  : String
        + MtrtyDtMod  : String
        + LglFrmwk  : ISO20022.Sese028001.LegalFramework3Choice
        + RateTp  : ISO20022.Sese028001.RateType35Choice
        + TermntnDt  : ISO20022.Sese028001.TerminationDate6Choice
        + ClsgLegId  : String
        + SctiesFincgUnqTxIdr  : String
        + SctiesFincgTradId  : String
    }
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.AmountAndDirection21
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.AmountAndDirection21
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.Rate2
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.RateName1
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.LegalFramework3Choice
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.RateType35Choice
    ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55 *-- ISO20022.Sese028001.TerminationDate6Choice
    class ISO20022.Sese028001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese028001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.SecuritiesPaymentStatus5Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese028001.SecuritiesRTGS4Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese028001.SupplementaryData1~
        + OthrBizPties  : ISO20022.Sese028001.OtherParties34
        + OthrAmts  : ISO20022.Sese028001.OtherAmounts32
        + SttlmAmt  : ISO20022.Sese028001.AmountAndDirection88
        + CshPties  : ISO20022.Sese028001.CashParties42
        + RcvgSttlmPties  : ISO20022.Sese028001.SettlementParties126
        + DlvrgSttlmPties  : ISO20022.Sese028001.SettlementParties126
        + SttlmParams  : ISO20022.Sese028001.SettlementDetails187
        + SctiesFincgDtls  : ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55
        + QtyAndAcctDtls  : ISO20022.Sese028001.QuantityAndAccount116
        + FinInstrmAttrbts  : ISO20022.Sese028001.FinancialInstrumentAttributes111
        + FinInstrmId  : ISO20022.Sese028001.SecurityIdentification19
        + TradDtls  : ISO20022.Sese028001.SecuritiesTradeDetails144
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + SttlmTpAndAddtlParams  : ISO20022.Sese028001.SettlementTypeAndAdditionalParameters12
        + TxId  : String
    }
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SupplementaryData1
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.OtherParties34
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.OtherAmounts32
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.AmountAndDirection88
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.CashParties42
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SettlementParties126
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SettlementParties126
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SettlementDetails187
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.QuantityAndAccount116
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.FinancialInstrumentAttributes111
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SecurityIdentification19
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SecuritiesTradeDetails144
    ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11 *-- ISO20022.Sese028001.SettlementTypeAndAdditionalParameters12
    class ISO20022.Sese028001.SecuritiesTradeDetails144 {
        + TpOfPric  : ISO20022.Sese028001.TypeOfPrice29Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese028001.TradeTransactionCondition5Choice~
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese028001.Price10
        + SttlmDt  : ISO20022.Sese028001.SettlementDate17Choice
        + TradDt  : ISO20022.Sese028001.TradeDate8Choice
        + PlcOfClr  : ISO20022.Sese028001.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese028001.PlaceOfTradeIdentification1
        + PrcrTxId  : String
        + AcctOwnrTxId  : global::System.Collections.Generic.List~String~
        + CollTxId  : global::System.Collections.Generic.List~String~
        + UnqTxIdr  : String
        + TradId  : String
    }
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.TypeOfPrice29Choice
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.TradeTransactionCondition5Choice
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.Price10
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.SettlementDate17Choice
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.TradeDate8Choice
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.PlaceOfClearingIdentification2
    ISO20022.Sese028001.SecuritiesTradeDetails144 *-- ISO20022.Sese028001.PlaceOfTradeIdentification1
    class ISO20022.Sese028001.SecuritiesTransactionType24Code {
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
    class ISO20022.Sese028001.SecuritiesTransactionType45Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.SecuritiesTransactionType45Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese028001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese028001.SecurityIdentification19 *-- ISO20022.Sese028001.OtherIdentification1
    class ISO20022.Sese028001.SettlementDate17Choice {
        + DtCd  : ISO20022.Sese028001.SettlementDateCode7Choice
        + Dt  : ISO20022.Sese028001.DateAndDateTime2Choice
    }
    ISO20022.Sese028001.SettlementDate17Choice *-- ISO20022.Sese028001.SettlementDateCode7Choice
    ISO20022.Sese028001.SettlementDate17Choice *-- ISO20022.Sese028001.DateAndDateTime2Choice
    class ISO20022.Sese028001.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese028001.SettlementDateCode7Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.SettlementDateCode7Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SettlementDetails187 {
        + StmpDtyTaxBsis  : ISO20022.Sese028001.GenericIdentification30
        + SctiesRTGS  : ISO20022.Sese028001.SecuritiesRTGS4Choice
        + RpTp  : ISO20022.Sese028001.RepurchaseType13Choice
        + Regn  : ISO20022.Sese028001.Registration9Choice
        + MktClntSd  : ISO20022.Sese028001.MarketClientSide6Choice
        + CshClrSys  : ISO20022.Sese028001.CashSettlementSystem4Choice
        + BnfclOwnrsh  : ISO20022.Sese028001.BeneficialOwnership4Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese028001.SettlementTransactionCondition35Choice~
        + SctiesTxTp  : ISO20022.Sese028001.SecuritiesTransactionType45Choice
        + HldInd  : String
    }
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.GenericIdentification30
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.SecuritiesRTGS4Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.RepurchaseType13Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.Registration9Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.MarketClientSide6Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.CashSettlementSystem4Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.BeneficialOwnership4Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.SettlementTransactionCondition35Choice
    ISO20022.Sese028001.SettlementDetails187 *-- ISO20022.Sese028001.SecuritiesTransactionType45Choice
    class ISO20022.Sese028001.SettlementParties126 {
        + Pty5  : ISO20022.Sese028001.PartyIdentificationAndAccount196
        + Pty4  : ISO20022.Sese028001.PartyIdentificationAndAccount196
        + Pty3  : ISO20022.Sese028001.PartyIdentificationAndAccount196
        + Pty2  : ISO20022.Sese028001.PartyIdentificationAndAccount196
        + Pty1  : ISO20022.Sese028001.PartyIdentificationAndAccount196
        + Dpstry  : ISO20022.Sese028001.PartyIdentification315
    }
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentificationAndAccount196
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentificationAndAccount196
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentificationAndAccount196
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentificationAndAccount196
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentificationAndAccount196
    ISO20022.Sese028001.SettlementParties126 *-- ISO20022.Sese028001.PartyIdentification315
    class ISO20022.Sese028001.SettlementTransactionCondition13Code {
        BPSS = 1
        NOMC = 2
        SPST = 3
        SPDL = 4
        PHYS = 5
        DLWM = 6
        DIRT = 7
        CLEN = 8
    }
    class ISO20022.Sese028001.SettlementTransactionCondition35Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.SettlementTransactionCondition35Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese028001.SettlementTypeAndAdditionalParameters12 {
        + CmonId  : String
        + Pmt  : String
        + SctiesMvmntTp  : String
    }
    class ISO20022.Sese028001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese028001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese028001.SupplementaryData1 *-- ISO20022.Sese028001.SupplementaryDataEnvelope1
    class ISO20022.Sese028001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese028001.TerminationDate6Choice {
        + Cd  : ISO20022.Sese028001.DateCode18Choice
        + Dt  : ISO20022.Sese028001.DateAndDateTime2Choice
    }
    ISO20022.Sese028001.TerminationDate6Choice *-- ISO20022.Sese028001.DateCode18Choice
    ISO20022.Sese028001.TerminationDate6Choice *-- ISO20022.Sese028001.DateAndDateTime2Choice
    class ISO20022.Sese028001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese028001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese028001.DateAndDateTime2Choice
    }
    ISO20022.Sese028001.TradeDate8Choice *-- ISO20022.Sese028001.TradeDateCode3Choice
    ISO20022.Sese028001.TradeDate8Choice *-- ISO20022.Sese028001.DateAndDateTime2Choice
    class ISO20022.Sese028001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.TradeDateCode3Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.TradeTransactionCondition4Code {
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
    class ISO20022.Sese028001.TradeTransactionCondition5Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.TradeTransactionCondition5Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese028001.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese028001.TypeOfPrice29Choice {
        + Prtry  : ISO20022.Sese028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese028001.TypeOfPrice29Choice *-- ISO20022.Sese028001.GenericIdentification30
    class ISO20022.Sese028001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese028001.YieldedOrValueType2Choice {
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

## Value ISO20022.Sese028001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese028001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese028001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese028001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese028001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese028001.AmountAndDirection21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese028001.AmountAndDirection47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese028001.ForeignExchangeTerms23||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(Amt))|

---

## Value ISO20022.Sese028001.AmountAndDirection88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese028001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese028001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese028001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese028001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese028001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese028001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Sese028001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Sese028001.CashParties42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAgt|ISO20022.Sese028001.PartyIdentificationAndAccount224||XmlElement()||
|+|Cdtr|ISO20022.Sese028001.PartyIdentificationAndAccount223||XmlElement()||
|+|DbtrAgt|ISO20022.Sese028001.PartyIdentificationAndAccount224||XmlElement()||
|+|Dbtr|ISO20022.Sese028001.PartyIdentificationAndAccount223||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese028001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese028001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese028001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese028001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese028001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese028001.DateCode18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese028001.DateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Sese028001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxAllgmtNtfctn|ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxAllgmtNtfctn))|

---

## Enum ISO20022.Sese028001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Sese028001.FinancialInstrumentAttributes111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese028001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Sese028001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese028001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese028001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Sese028001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Sese028001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Sese028001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese028001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese028001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese028001.Number22Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese028001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese028001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese028001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese028001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese028001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese028001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese028001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese028001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese028001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese028001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese028001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese028001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese028001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese028001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese028001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese028001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.InterestComputationMethod2Code


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

## Value ISO20022.Sese028001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.LegalFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAN|Int32||XmlEnum("""FRAN""")|1|

---

## Value ISO20022.Sese028001.LegalFramework3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese028001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese028001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese028001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese028001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Sese028001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Sese028001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese028001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese028001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese028001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese028001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese028001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese028001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese028001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.OtherAmounts32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CsmptnTax|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|WhldgTax|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|TxTax|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|StmpDty|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|Othr|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|LclTax|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|TradAmt|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|ChrgsFees|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese028001.AmountAndDirection47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CsmptnTax),validElement(WhldgTax),validElement(TxTax),validElement(StmpDty),validElement(Othr),validElement(LclBrkrComssn),validElement(LclTax),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese028001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese028001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese028001.OtherParties34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgt|ISO20022.Sese028001.PartyIdentification136||XmlElement()||
|+|TradRgltr|ISO20022.Sese028001.PartyIdentification136||XmlElement()||
|+|StockXchg|ISO20022.Sese028001.PartyIdentification136||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese028001.PartyIdentification136||XmlElement()||
|+|Invstr|ISO20022.Sese028001.PartyIdentification149||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validElement(Invstr))|

---

## Value ISO20022.Sese028001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese028001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese028001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese028001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028001.PartyIdentification133Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese028001.GenericIdentification36||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028001.NameAndAddress5||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese028001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese028001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese028001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese028001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese028001.PartyIdentification315


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentificationAndAccount196


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese028001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese028001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese028001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentificationAndAccount223


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese028001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyIdentificationAndAccount224


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese028001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese028001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese028001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese028001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese028001.PartyIdentification133Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese028001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.PartyTextInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese028001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese028001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese028001.PostalAddress1


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

## Value ISO20022.Sese028001.Price10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese028001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese028001.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese028001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese028001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese028001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese028001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese028001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese028001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese028001.Price7||XmlElement()||
|+|Mkt|ISO20022.Sese028001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese028001.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese028001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese028001.QuantityAndAccount116


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Sese028001.SafeKeepingPlace5||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese028001.QuantityBreakdown62>||XmlElement()||
|+|CshAcct|ISO20022.Sese028001.CashAccountIdentification9Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese028001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese028001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese028001.PartyIdentification144||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese028001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SttlmQty))|

---

## Value ISO20022.Sese028001.QuantityBreakdown62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese028001.TypeOfPrice29Choice||XmlElement()||
|+|LotPric|ISO20022.Sese028001.Price7||XmlElement()||
|+|LotDtTm|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese028001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Sese028001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Sese028001.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.RateName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese028001.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Sese028001.RateType35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Enum ISO20022.Sese028001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese028001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.RepurchaseType13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.RepurchaseType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|

---

## Value ISO20022.Sese028001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese028001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese028001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese028001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese028001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese028001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese028001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Sese028001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese028001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLegNrrtv|String||XmlElement()||
|+|TermntnTxAmt|ISO20022.Sese028001.AmountAndDirection21||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese028001.AmountAndDirection21||XmlElement()||
|+|TxCallDely|String||XmlElement()||
|+|RpRate|ISO20022.Sese028001.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Sese028001.RateName1||XmlElement()||
|+|IntrstPmt|String||XmlElement()||
|+|MtrtyDtMod|String||XmlElement()||
|+|LglFrmwk|ISO20022.Sese028001.LegalFramework3Choice||XmlElement()||
|+|RateTp|ISO20022.Sese028001.RateType35Choice||XmlElement()||
|+|TermntnDt|ISO20022.Sese028001.TerminationDate6Choice||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|SctiesFincgUnqTxIdr|String||XmlElement()||
|+|SctiesFincgTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TermntnTxAmt),validElement(AcrdIntrstAmt),validPattern("""TxCallDely""",TxCallDely,"""[0-9]{3}"""),validElement(RpRate),validElement(VarblRateSpprt),validElement(LglFrmwk),validElement(RateTp),validElement(TermntnDt),validPattern("""SctiesFincgUnqTxIdr""",SctiesFincgUnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Sese028001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese028001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese028001.SecuritiesSettlementTransactionAllegementNotificationV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese028001.SupplementaryData1>||XmlElement()||
|+|OthrBizPties|ISO20022.Sese028001.OtherParties34||XmlElement()||
|+|OthrAmts|ISO20022.Sese028001.OtherAmounts32||XmlElement()||
|+|SttlmAmt|ISO20022.Sese028001.AmountAndDirection88||XmlElement()||
|+|CshPties|ISO20022.Sese028001.CashParties42||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese028001.SettlementParties126||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese028001.SettlementParties126||XmlElement()||
|+|SttlmParams|ISO20022.Sese028001.SettlementDetails187||XmlElement()||
|+|SctiesFincgDtls|ISO20022.Sese028001.SecuritiesFinancingTransactionDetails55||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese028001.QuantityAndAccount116||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese028001.FinancialInstrumentAttributes111||XmlElement()||
|+|FinInstrmId|ISO20022.Sese028001.SecurityIdentification19||XmlElement()||
|+|TradDtls|ISO20022.Sese028001.SecuritiesTradeDetails144||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|SttlmTpAndAddtlParams|ISO20022.Sese028001.SettlementTypeAndAdditionalParameters12||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(SctiesFincgDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validElement(SttlmTpAndAddtlParams))|

---

## Value ISO20022.Sese028001.SecuritiesTradeDetails144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese028001.TypeOfPrice29Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese028001.TradeTransactionCondition5Choice>||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese028001.Price10||XmlElement()||
|+|SttlmDt|ISO20022.Sese028001.SettlementDate17Choice||XmlElement()||
|+|TradDt|ISO20022.Sese028001.TradeDate8Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese028001.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese028001.PlaceOfTradeIdentification1||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(DealPric),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Sese028001.SecuritiesTransactionType24Code


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

## Value ISO20022.Sese028001.SecuritiesTransactionType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese028001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese028001.SettlementDate17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese028001.SettlementDateCode7Choice||XmlElement()||
|+|Dt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese028001.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese028001.SettlementDateCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.SettlementDetails187


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmpDtyTaxBsis|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese028001.SecuritiesRTGS4Choice||XmlElement()||
|+|RpTp|ISO20022.Sese028001.RepurchaseType13Choice||XmlElement()||
|+|Regn|ISO20022.Sese028001.Registration9Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese028001.MarketClientSide6Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese028001.CashSettlementSystem4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese028001.BeneficialOwnership4Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese028001.SettlementTransactionCondition35Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese028001.SecuritiesTransactionType45Choice||XmlElement()||
|+|HldInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmpDtyTaxBsis),validElement(SctiesRTGS),validElement(RpTp),validElement(Regn),validElement(MktClntSd),validElement(CshClrSys),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp))|

---

## Value ISO20022.Sese028001.SettlementParties126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese028001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty4|ISO20022.Sese028001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty3|ISO20022.Sese028001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty2|ISO20022.Sese028001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty1|ISO20022.Sese028001.PartyIdentificationAndAccount196||XmlElement()||
|+|Dpstry|ISO20022.Sese028001.PartyIdentification315||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese028001.SettlementTransactionCondition13Code


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

## Value ISO20022.Sese028001.SettlementTransactionCondition35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Value ISO20022.Sese028001.SettlementTypeAndAdditionalParameters12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmonId|String||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese028001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese028001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese028001.TerminationDate6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Sese028001.DateCode18Choice||XmlElement()||
|+|Dt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Sese028001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese028001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese028001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese028001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.TradeTransactionCondition4Code


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

## Value ISO20022.Sese028001.TradeTransactionCondition5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese028001.TypeOfIdentification1Code


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

## Enum ISO20022.Sese028001.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese028001.TypeOfPrice29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese028001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese028001.YieldedOrValueType2Choice


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

