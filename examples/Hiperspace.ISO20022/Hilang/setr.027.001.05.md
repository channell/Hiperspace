# setr.027.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Setr027001.AccountIdentification55Choice {
        + PrtryAcct  : ISO20022.Setr027001.SimpleIdentificationInformation2
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Setr027001.AccountIdentification55Choice *-- ISO20022.Setr027001.SimpleIdentificationInformation2
    class ISO20022.Setr027001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr027001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr027001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Setr027001.Agreement5 {
        + MrgnRatio  : Decimal
        + DlvryTp  : String
        + StartDt  : DateTime
        + ClsgTp  : String
        + Ccy  : String
        + Dt  : DateTime
        + Desc  : String
    }
    class ISO20022.Setr027001.AlternatePartyIdentification10 {
        + AltrnId  : String
        + Ctry  : String
        + TpOfId  : ISO20022.Setr027001.IdentificationType42Choice
    }
    ISO20022.Setr027001.AlternatePartyIdentification10 *-- ISO20022.Setr027001.IdentificationType42Choice
    class ISO20022.Setr027001.AlternatePartyIdentification8 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Setr027001.IdentificationType43Choice
    }
    ISO20022.Setr027001.AlternatePartyIdentification8 *-- ISO20022.Setr027001.IdentificationType43Choice
    class ISO20022.Setr027001.AmountAndDirection28 {
        + ValDt  : ISO20022.Setr027001.DateAndDateTime1Choice
        + FXDtls  : ISO20022.Setr027001.ForeignExchangeTerms18
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + StmpDtyInd  : String
        + AcrdIntrstInd  : String
    }
    ISO20022.Setr027001.AmountAndDirection28 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    ISO20022.Setr027001.AmountAndDirection28 *-- ISO20022.Setr027001.ForeignExchangeTerms18
    ISO20022.Setr027001.AmountAndDirection28 *-- ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr027001.AmountAndDirection28 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.AmountAndDirection29 {
        + FXDtls  : ISO20022.Setr027001.ForeignExchangeTerms18
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Setr027001.AmountAndDirection29 *-- ISO20022.Setr027001.ForeignExchangeTerms18
    ISO20022.Setr027001.AmountAndDirection29 *-- ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr027001.AmountAndDirection29 *-- ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr027001.AmountAndDirection5 {
        + CdtDbt  : String
        + Amt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr027001.AmountAndDirection5 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.AmountOrPercentageRange1 {
        + Term  : global::System.Collections.Generic.List~ISO20022.Setr027001.Term1~
        + Opr  : String
    }
    ISO20022.Setr027001.AmountOrPercentageRange1 *-- ISO20022.Setr027001.Term1
    class ISO20022.Setr027001.AmountOrRate1Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr027001.AmountOrRate1Choice *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.AmountOrRate2Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr027001.AmountOrRate2Choice *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.Appearance1Code {
        GLOB = 1
        TMPG = 2
        DLBE = 3
        DFBE = 4
        BENT = 5
        LIMI = 6
        NDEL = 7
        DELI = 8
    }
    class ISO20022.Setr027001.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Setr027001.AutomaticBorrowing6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.AutomaticBorrowing6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.BeneficialOwnership4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Setr027001.BlockTrade4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.BlockTrade4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.BorrowingReason1Code {
        MMPP = 1
        TTTP = 2
        SFCT = 3
    }
    class ISO20022.Setr027001.BorrowingReason2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.BorrowingReason2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.BusinessProcessType1Code {
        DPLX = 1
        IDEL = 2
        THRU = 3
        PROP = 4
        RSAL = 5
        PRAC = 6
        NISP = 7
        ISUP = 8
    }
    class ISO20022.Setr027001.BusinessProcessType2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.BusinessProcessType2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.CalculationType1Code {
        WRST = 1
        TRYL = 2
        TTDT = 3
        TXQV = 4
        SPLL = 5
        SHLF = 6
        SEMI = 7
        PRYL = 8
        PRCL = 9
        NXPT = 10
        PNAV = 11
        NXRF = 12
        YTMA = 13
        MARK = 14
        LGAL = 15
        LSYR = 16
        LSQR = 17
        LSMT = 18
        LSCL = 19
        NVFL = 20
        FLAS = 21
        GVEQ = 22
        TRGR = 23
        CUYI = 24
        CMPD = 25
        CLOS = 26
        CHCL = 27
        YTNC = 28
        BOOK = 29
        AVMA = 30
        ISSU = 31
        ANNU = 32
        AFTX = 33
    }
    class ISO20022.Setr027001.CallIn1Code {
        CFCC = 1
        CFST = 2
        CFAV = 3
    }
    class ISO20022.Setr027001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Setr027001.CashMarginOrder1Code {
        MRGC = 1
        MRGO = 2
        CASH = 3
    }
    class ISO20022.Setr027001.CashParties33 {
        + Intrmy  : ISO20022.Setr027001.PartyIdentificationAndAccount148
        + CdtrAgt  : ISO20022.Setr027001.PartyIdentificationAndAccount148
        + Cdtr  : ISO20022.Setr027001.PartyIdentificationAndAccount148
        + DbtrAgt  : ISO20022.Setr027001.PartyIdentificationAndAccount148
        + Dbtr  : ISO20022.Setr027001.PartyIdentificationAndAccount148
    }
    ISO20022.Setr027001.CashParties33 *-- ISO20022.Setr027001.PartyIdentificationAndAccount148
    ISO20022.Setr027001.CashParties33 *-- ISO20022.Setr027001.PartyIdentificationAndAccount148
    ISO20022.Setr027001.CashParties33 *-- ISO20022.Setr027001.PartyIdentificationAndAccount148
    ISO20022.Setr027001.CashParties33 *-- ISO20022.Setr027001.PartyIdentificationAndAccount148
    ISO20022.Setr027001.CashParties33 *-- ISO20022.Setr027001.PartyIdentificationAndAccount148
    class ISO20022.Setr027001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Setr027001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.CashSettlementSystem4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.CentralCounterPartyEligibility4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.ChargeTaxBasis1Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Setr027001.ChargeTaxBasisType2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.ChargeTaxBasisType2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Setr027001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Setr027001.ClassificationType32Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.Clearing5 {
        + ClrSgmt  : ISO20022.Setr027001.PartyIdentification127Choice
        + ClrMmb  : global::System.Collections.Generic.List~ISO20022.Setr027001.PartyIdentificationAndAccount149~
    }
    ISO20022.Setr027001.Clearing5 *-- ISO20022.Setr027001.PartyIdentification127Choice
    ISO20022.Setr027001.Clearing5 *-- ISO20022.Setr027001.PartyIdentificationAndAccount149
    class ISO20022.Setr027001.ClearingAccountType1Code {
        LIPR = 1
        CLIE = 2
        HOUS = 3
    }
    class ISO20022.Setr027001.ClearingSide1Code {
        BORW = 1
        LEND = 2
        SELL = 3
        BUYI = 4
    }
    class ISO20022.Setr027001.ClosingDate4Choice {
        + Cd  : ISO20022.Setr027001.Date3Choice
        + Dt  : ISO20022.Setr027001.DateAndDateTime2Choice
    }
    ISO20022.Setr027001.ClosingDate4Choice *-- ISO20022.Setr027001.Date3Choice
    ISO20022.Setr027001.ClosingDate4Choice *-- ISO20022.Setr027001.DateAndDateTime2Choice
    class ISO20022.Setr027001.ClosingType1Code {
        OPEN = 1
        FLEX = 2
        TERM = 3
        OVER = 4
    }
    class ISO20022.Setr027001.CollateralType3Code {
        OTHR = 1
        GBBK = 2
        BOND = 3
        STCF = 4
        INSU = 5
        PHYS = 6
        SECU = 7
        CASH = 8
    }
    class ISO20022.Setr027001.CollateralType4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.CollateralType4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Commission24 {
        + VATRate  : Decimal
        + TtlVATAmt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + TtlComssn  : ISO20022.Setr027001.AmountAndDirection29
        + ClctnDt  : DateTime
        + RcptId  : ISO20022.Setr027001.PartyIdentification117
        + Comssn  : ISO20022.Setr027001.AmountOrRate2Choice
        + Tp  : ISO20022.Setr027001.CommissionType6Choice
    }
    ISO20022.Setr027001.Commission24 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    ISO20022.Setr027001.Commission24 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.Commission24 *-- ISO20022.Setr027001.PartyIdentification117
    ISO20022.Setr027001.Commission24 *-- ISO20022.Setr027001.AmountOrRate2Choice
    ISO20022.Setr027001.Commission24 *-- ISO20022.Setr027001.CommissionType6Choice
    class ISO20022.Setr027001.CommissionType6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.CommissionType6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.CommissionType9Code {
        PBOC = 1
        DFDP = 2
        BRKR = 3
        PWEU = 4
        PWCD = 5
        PERU = 6
        FLAT = 7
        PERN = 8
        SOFT = 9
        STEP = 10
        CLDI = 11
    }
    class ISO20022.Setr027001.ConfirmationParties6 {
        + TradBnfcryPty  : ISO20022.Setr027001.ConfirmationPartyDetails10
        + AffrmgPty  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + CMUCtrPty  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + CMUPty  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + ExctgBrkr  : ISO20022.Setr027001.ConfirmationPartyDetails9
        + ClrFirm  : ISO20022.Setr027001.ConfirmationPartyDetails9
        + StepOutFirm  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + StepInFirm  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + IntrdcgFirm  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + BrkrOfCdt  : ISO20022.Setr027001.ConfirmationPartyDetails8
        + Lndr  : ISO20022.Setr027001.ConfirmationPartyDetails7
        + Sellr  : ISO20022.Setr027001.ConfirmationPartyDetails7
        + Brrwr  : ISO20022.Setr027001.ConfirmationPartyDetails7
        + Buyr  : ISO20022.Setr027001.ConfirmationPartyDetails7
    }
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails10
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails9
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails9
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails8
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails7
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails7
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails7
    ISO20022.Setr027001.ConfirmationParties6 *-- ISO20022.Setr027001.ConfirmationPartyDetails7
    class ISO20022.Setr027001.ConfirmationPartyDetails10 {
        + PtyCpcty  : ISO20022.Setr027001.TradingPartyCapacity3Choice
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + CshDtls  : ISO20022.Setr027001.AccountIdentification55Choice
        + SfkpgAcct  : ISO20022.Setr027001.SecuritiesAccount35
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.TradingPartyCapacity3Choice
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.PartyTextInformation5
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.AccountIdentification55Choice
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.SecuritiesAccount35
    ISO20022.Setr027001.ConfirmationPartyDetails10 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.ConfirmationPartyDetails7 {
        + TradgPtyCpcty  : ISO20022.Setr027001.TradingPartyCapacity4Choice
        + InvstrCpcty  : ISO20022.Setr027001.InvestorCapacity4Choice
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.ConfirmationPartyDetails7 *-- ISO20022.Setr027001.TradingPartyCapacity4Choice
    ISO20022.Setr027001.ConfirmationPartyDetails7 *-- ISO20022.Setr027001.InvestorCapacity4Choice
    ISO20022.Setr027001.ConfirmationPartyDetails7 *-- ISO20022.Setr027001.PartyTextInformation5
    ISO20022.Setr027001.ConfirmationPartyDetails7 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.ConfirmationPartyDetails7 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.ConfirmationPartyDetails8 {
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.ConfirmationPartyDetails8 *-- ISO20022.Setr027001.PartyTextInformation5
    ISO20022.Setr027001.ConfirmationPartyDetails8 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.ConfirmationPartyDetails8 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.ConfirmationPartyDetails9 {
        + InvstrPrtcnAssoctnMmbsh  : String
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.ConfirmationPartyDetails9 *-- ISO20022.Setr027001.PartyTextInformation5
    ISO20022.Setr027001.ConfirmationPartyDetails9 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.ConfirmationPartyDetails9 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Setr027001.CurrencyToBuyOrSell1Choice {
        + CcyToSell  : String
        + CcyToBuy  : String
    }
    class ISO20022.Setr027001.Date3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Date3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.DateAndDateTime1Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr027001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr027001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Setr027001.DateTimePeriod1Choice {
        + DtTmRg  : ISO20022.Setr027001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Setr027001.DateTimePeriod1Choice *-- ISO20022.Setr027001.DateTimePeriod1
    class ISO20022.Setr027001.DateTimePeriod2 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Setr027001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Setr027001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Setr027001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Setr027001.DeliveryType2Code {
        HOIC = 1
        TRIP = 2
        FREE = 3
        APMT = 4
    }
    class ISO20022.Setr027001.DocumentNumber17Choice {
        + PrtryNb  : ISO20022.Setr027001.GenericIdentification30
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Setr027001.DocumentNumber17Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Setr027001.EUCapitalGainType3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + EUCptlGn  : String
    }
    ISO20022.Setr027001.EUCapitalGainType3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Setr027001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Setr027001.ExposureType18Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.ExposureType18Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.ExposureType3Code {
        TBAS = 1
        RVPO = 2
        BFWD = 3
        TRCP = 4
        SWPT = 5
        SLOA = 6
        SLEB = 7
        SCRP = 8
        SCIR = 9
        SCIE = 10
        SBSC = 11
        REPO = 12
        PAYM = 13
        OTCD = 14
        OPTN = 15
        LIQU = 16
        FUTR = 17
        FORX = 18
        FORW = 19
        FIXI = 20
        EXTD = 21
        EXPT = 22
        EQUS = 23
        EQPT = 24
        CRTL = 25
        CRSP = 26
        CRPR = 27
        CRDS = 28
        COMM = 29
        CCIR = 30
    }
    class ISO20022.Setr027001.FXStandingInstruction4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.FXStandingInstruction4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.FinancialInstrumentAttributes124 {
        + FinInstrmAttrAddtlDtls  : String
        + CtrctSz  : ISO20022.Setr027001.FinancialInstrumentQuantity18Choice
        + FaceAmt  : Decimal
        + MinExrcblMltplQty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + MinExrcblQty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + MinNmnlQty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + TaxblIncmPerShr  : ISO20022.Setr027001.Price14
        + ConvsPric  : ISO20022.Setr027001.Price14
        + SbcptPric  : ISO20022.Setr027001.Price14
        + ExrcPric  : ISO20022.Setr027001.Price14
        + YldVar  : String
        + RedYldImpct  : String
        + OddCpnInd  : String
        + WarrtAttchdOnDlvry  : String
        + PutblInd  : String
        + CllblInd  : String
        + CvrdInd  : String
        + VarblRateInd  : String
        + ConvtblInd  : String
        + VrsnNb  : ISO20022.Setr027001.Number1Choice
        + PoolNb  : ISO20022.Setr027001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Setr027001.Number1Choice
        + PctgOfDebtClms  : Decimal
        + IndxRateBsis  : Decimal
        + NxtIntrstRate  : Decimal
        + IntrstRate  : Decimal
        + EndFctr  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + PrvsFctr  : Decimal
        + NxtFctrDt  : DateTime
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + ConvsDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + CpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnTp  : ISO20022.Setr027001.OptionType6Choice
        + OptnStyle  : ISO20022.Setr027001.OptionStyle10Choice
        + ClssfctnTp  : ISO20022.Setr027001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Setr027001.Frequency23Choice
        + PmtFrqcy  : ISO20022.Setr027001.Frequency23Choice
        + RegnForm  : ISO20022.Setr027001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Setr027001.InterestComputationMethodFormat4Choice
        + CertNb  : String
        + Ratg  : ISO20022.Setr027001.Rating1
        + PlcOfListg  : ISO20022.Setr027001.MarketIdentification3Choice
    }
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.FinancialInstrumentQuantity18Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Number1Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.GenericIdentification37
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Number1Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.OptionType6Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.OptionStyle10Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.ClassificationType32Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Frequency23Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Frequency23Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.FormOfSecurity6Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.InterestComputationMethodFormat4Choice
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.Rating1
    ISO20022.Setr027001.FinancialInstrumentAttributes124 *-- ISO20022.Setr027001.MarketIdentification3Choice
    class ISO20022.Setr027001.FinancialInstrumentQuantity18Choice {
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Setr027001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Setr027001.FinancialInstrumentStipulations4 {
        + PerptlInd  : String
        + EscrwdInd  : String
        + PreFnddInd  : String
        + PutblInd  : String
        + ConvtblInd  : String
        + CllblInd  : String
        + PricRg  : ISO20022.Setr027001.AmountOrPercentageRange1
        + OverAlltmtRate  : Decimal
        + OverAlltmtAmt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + XprtnDt  : DateTime
        + PricSrc  : String
        + WhlPoolInd  : String
        + SbstitnLft  : Decimal
        + SbstitnFrqcy  : String
        + Sctr  : String
        + PricFrqcy  : String
        + RstrctdInd  : String
        + Pdctn  : String
        + MinQty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + PmtFrqcy  : String
        + MinIncrmt  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + MaxSbstitn  : Decimal
        + MinDnmtn  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + IsseSz  : Decimal
        + IssrId  : String
        + IsseDt  : String
        + MtrtyDt  : String
        + LookBck  : Decimal
        + InsrdInd  : String
        + Hrcut  : Decimal
        + CstmDt  : ISO20022.Setr027001.DateTimePeriod2
        + Ccy  : String
        + TxConds  : String
        + AutoRinvstmt  : Decimal
        + AltrntvMinTaxInd  : String
        + Purp  : String
        + AmtsblInd  : String
        + CpnRg  : ISO20022.Setr027001.AmountOrPercentageRange1
        + Ratg  : ISO20022.Setr027001.Rating1
        + YldRg  : ISO20022.Setr027001.AmountOrPercentageRange1
        + Geogcs  : String
    }
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.AmountOrPercentageRange1
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.DateTimePeriod2
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.AmountOrPercentageRange1
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.Rating1
    ISO20022.Setr027001.FinancialInstrumentStipulations4 *-- ISO20022.Setr027001.AmountOrPercentageRange1
    class ISO20022.Setr027001.ForeignExchangeTerms18 {
        + ConvtdAmt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Setr027001.ForeignExchangeTerms18 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Setr027001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.FormOfSecurity6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Frequency1Code {
        INDA = 1
        ADHO = 2
        DAIL = 3
        WEEK = 4
        MIAN = 5
        QURT = 6
        MNTH = 7
        YEAR = 8
    }
    class ISO20022.Setr027001.Frequency23Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Frequency23Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.FutureAndOptionContractType1Code {
        EXFU = 1
        INDX = 2
        ORDY = 3
    }
    class ISO20022.Setr027001.FutureOrOptionDetails3 {
        + SprdTx  : String
        + LastTx  : String
        + OptnRghts  : ISO20022.Setr027001.OptionRight2Choice
        + IssePric  : ISO20022.Setr027001.Price14
        + Ratg  : global::System.Collections.Generic.List~ISO20022.Setr027001.Rating1~
        + Ratio  : global::System.Collections.Generic.List~ISO20022.Setr027001.UnderlyingRatio2~
        + FrstDealgDt  : ISO20022.Setr027001.DateAndDateTime1Choice
        + CtrctSttlmMnth  : String
        + Purp  : String
        + MinTradgPricgIncrmt  : Decimal
        + NearTermPosLmt  : Decimal
        + PosLmt  : Decimal
        + StrpblInd  : String
        + Apprnc  : String
        + AnncmntDt  : DateTime
        + MinSz  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + FutrDt  : DateTime
        + UnitOfMeasr  : String
        + LastDlvryDt  : DateTime
        + FutrAndOptnCtrctTp  : String
    }
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.OptionRight2Choice
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.Rating1
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.UnderlyingRatio2
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    ISO20022.Setr027001.FutureOrOptionDetails3 *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    class ISO20022.Setr027001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Setr027001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr027001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr027001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr027001.GenericIdentification7 {
        + Inf  : String
        + Issr  : String
    }
    class ISO20022.Setr027001.IdentificationReference15Choice {
        + UnqTxIdr  : String
        + CollTxId  : String
        + CmplcId  : String
        + CmonId  : String
        + IndxId  : String
        + ScndryAllcnId  : String
        + IndvAllcnId  : String
        + AllcnId  : String
        + BlckId  : String
        + PoolId  : String
        + ClntOrdrLkId  : String
        + MktInfrstrctrTxId  : String
        + ExctgPtyTxId  : String
        + InstgPtyTxId  : String
    }
    class ISO20022.Setr027001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Setr027001.IdentificationType42Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.IdentificationType42Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.IdentificationType43Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Setr027001.IdentificationType43Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.InterestComputationMethod1Code {
        A014 = 1
        A013 = 2
        A012 = 3
        A011 = 4
        A010 = 5
        A009 = 6
        A008 = 7
        A007 = 8
        A006 = 9
        A005 = 10
        A004 = 11
        A003 = 12
        A002 = 13
        A001 = 14
    }
    class ISO20022.Setr027001.InterestComputationMethod2Code {
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
    class ISO20022.Setr027001.InterestComputationMethod3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.InterestComputationMethod3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.InterestComputationMethodFormat4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.InterestType2Code {
        XINT = 1
        CINT = 2
    }
    class ISO20022.Setr027001.InvestorCapacity4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.InvestorCapacity4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.LegalFramework1Code {
        FRAN = 1
    }
    class ISO20022.Setr027001.LendingTransactionMethod1Code {
        EXTR = 1
        ODTR = 2
    }
    class ISO20022.Setr027001.LendingTransactionMethod2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.LendingTransactionMethod2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.LetterOfGuarantee4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.LetterOfGuarantee4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Linkages76 {
        + Ref  : ISO20022.Setr027001.IdentificationReference15Choice
        + MsgNb  : ISO20022.Setr027001.DocumentNumber17Choice
    }
    ISO20022.Setr027001.Linkages76 *-- ISO20022.Setr027001.IdentificationReference15Choice
    ISO20022.Setr027001.Linkages76 *-- ISO20022.Setr027001.DocumentNumber17Choice
    class ISO20022.Setr027001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Setr027001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.MarketClientSide6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Setr027001.MarketIdentification93 {
        + Tp  : ISO20022.Setr027001.MarketType18Choice
        + Id  : ISO20022.Setr027001.MarketIdentification3Choice
    }
    ISO20022.Setr027001.MarketIdentification93 *-- ISO20022.Setr027001.MarketType18Choice
    ISO20022.Setr027001.MarketIdentification93 *-- ISO20022.Setr027001.MarketIdentification3Choice
    class ISO20022.Setr027001.MarketIdentification97 {
        + Tp  : ISO20022.Setr027001.MarketType8Choice
        + Id  : ISO20022.Setr027001.MarketIdentification3Choice
    }
    ISO20022.Setr027001.MarketIdentification97 *-- ISO20022.Setr027001.MarketType8Choice
    ISO20022.Setr027001.MarketIdentification97 *-- ISO20022.Setr027001.MarketIdentification3Choice
    class ISO20022.Setr027001.MarketType18Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.MarketType18Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Setr027001.MarketType6Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
    }
    class ISO20022.Setr027001.MarketType8Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.MarketType8Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Setr027001.MatchingStatus27Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.MatchingStatus27Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.ModificationCancellationAllowed4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.ModificationCancellationAllowed4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.NameAndAddress13 {
        + Adr  : ISO20022.Setr027001.PostalAddress8
        + Nm  : String
    }
    ISO20022.Setr027001.NameAndAddress13 *-- ISO20022.Setr027001.PostalAddress8
    class ISO20022.Setr027001.NameAndAddress5 {
        + Adr  : ISO20022.Setr027001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr027001.NameAndAddress5 *-- ISO20022.Setr027001.PostalAddress1
    class ISO20022.Setr027001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.NettingEligibility4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Number1Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification7
        + NbId  : String
    }
    ISO20022.Setr027001.Number1Choice *-- ISO20022.Setr027001.GenericIdentification7
    class ISO20022.Setr027001.Number24Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification36
        + NbId  : String
    }
    ISO20022.Setr027001.Number24Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.NumberCount1Choice {
        + TtlNb  : ISO20022.Setr027001.TotalNumber1
        + CurInstrNb  : String
    }
    ISO20022.Setr027001.NumberCount1Choice *-- ISO20022.Setr027001.TotalNumber1
    class ISO20022.Setr027001.Operation1Code {
        ANDD = 1
        ORRR = 2
        TILL = 3
    }
    class ISO20022.Setr027001.Operator1Code {
        EQAL = 1
        GREQ = 2
        GREA = 3
        SMEQ = 4
        SMAL = 5
    }
    class ISO20022.Setr027001.OptionRight1Code {
        EXPI = 1
        RENO = 2
        ASGN = 3
        EXER = 4
    }
    class ISO20022.Setr027001.OptionRight2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.OptionRight2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.OptionStyle10Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.OptionStyle10Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.OptionStyle4Code {
        BERM = 1
        EURO = 2
        AMER = 3
    }
    class ISO20022.Setr027001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Setr027001.OptionType6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.OptionType6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Order24 {
        + AddtlTradInstrPrcgInf  : String
        + AddtlPhysOrRegnDtls  : ISO20022.Setr027001.RegistrationParameters3
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Setr027001.Reporting6Choice~
        + YldTp  : ISO20022.Setr027001.YieldCalculation7
        + CallInTp  : String
        + MtchSts  : ISO20022.Setr027001.MatchingStatus27Choice
        + CptlGnTp  : ISO20022.Setr027001.EUCapitalGainType3Choice
        + ChrgTaxBsisTp  : ISO20022.Setr027001.ChargeTaxBasisType2Choice
        + DerivCvrd  : String
        + PosFct  : String
        + OrdrOrgtrElgblty  : String
        + CcyToBuyOrSell  : ISO20022.Setr027001.CurrencyToBuyOrSell1Choice
        + TradRgltryCondsTp  : String
        + AcrdIntrstPctg  : Decimal
        + AcrdIntrstAmt  : ISO20022.Setr027001.AmountAndDirection29
        + IntrstTp  : String
        + GvUpNbOfDays  : Decimal
        + NbOfDaysAcrd  : Decimal
        + Comssn  : ISO20022.Setr027001.Commission24
        + CshMrgn  : String
        + TpOfPric  : ISO20022.Setr027001.TypeOfPrice47Choice
        + DealPric  : ISO20022.Setr027001.Price14
        + GrssTradAmt  : ISO20022.Setr027001.AmountAndDirection29
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Setr027001.QuantityBreakdown76~
        + ConfQty  : ISO20022.Setr027001.Quantity6Choice
        + PrtlFillDtls  : global::System.Collections.Generic.List~ISO20022.Setr027001.PartialFill4~
        + NAVDt  : ISO20022.Setr027001.DateAndDateTime1Choice
        + SttlmDt  : ISO20022.Setr027001.SettlementDate16Choice
        + PrcgDt  : ISO20022.Setr027001.TradeDate7Choice
        + TradDt  : ISO20022.Setr027001.TradeDate7Choice
        + TradOrgtnDt  : DateTime
        + OrdrBookgDt  : DateTime
        + PlcOfTrad  : ISO20022.Setr027001.MarketIdentification93
        + PreAdvc  : String
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Setr027001.TradeTransactionCondition9Choice~
        + TradTxTp  : ISO20022.Setr027001.TradeType4Choice
        + Pmt  : String
        + Sd  : String
        + ListId  : global::System.Collections.Generic.List~String~
        + ScndryClntOrdrId  : global::System.Collections.Generic.List~String~
        + ClntOrdrId  : global::System.Collections.Generic.List~String~
        + OrdrId  : global::System.Collections.Generic.List~String~
        + BizPrcTp  : ISO20022.Setr027001.BusinessProcessType2Choice
    }
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.RegistrationParameters3
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.Reporting6Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.YieldCalculation7
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.MatchingStatus27Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.EUCapitalGainType3Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.ChargeTaxBasisType2Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.CurrencyToBuyOrSell1Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.Commission24
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.TypeOfPrice47Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.QuantityBreakdown76
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.Quantity6Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.PartialFill4
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.SettlementDate16Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.TradeDate7Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.TradeDate7Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.MarketIdentification93
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.TradeTransactionCondition9Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.TradeType4Choice
    ISO20022.Setr027001.Order24 *-- ISO20022.Setr027001.BusinessProcessType2Choice
    class ISO20022.Setr027001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Setr027001.OtherAmounts16 {
        + OddLotFee  : String
        + DiffInPric  : ISO20022.Setr027001.AmountAndDirection29
        + ClrBrkrComssn  : ISO20022.Setr027001.AmountAndDirection29
        + RmngBookVal  : ISO20022.Setr027001.AmountAndDirection29
        + RmngFaceVal  : ISO20022.Setr027001.AmountAndDirection29
        + NetMktVal  : ISO20022.Setr027001.AmountAndDirection29
        + BrrwgFee  : ISO20022.Setr027001.AmountAndDirection29
        + BrrwgIntrstAmt  : ISO20022.Setr027001.AmountAndDirection29
        + RmnrtnAmt  : ISO20022.Setr027001.AmountAndDirection29
        + RmnrtnAmtReq  : String
        + MktMmbFeeAmt  : ISO20022.Setr027001.AmountAndDirection29
        + ShrdBrkrgAmt  : ISO20022.Setr027001.AmountAndDirection29
        + LclTaxCtrySpcfc4  : ISO20022.Setr027001.AmountAndDirection29
        + LclTaxCtrySpcfc3  : ISO20022.Setr027001.AmountAndDirection29
        + LclTaxCtrySpcfc2  : ISO20022.Setr027001.AmountAndDirection29
        + LclTaxCtrySpcfc1  : ISO20022.Setr027001.AmountAndDirection29
        + AcrdCptlstnAmt  : ISO20022.Setr027001.AmountAndDirection29
        + BookVal  : ISO20022.Setr027001.AmountAndDirection29
        + OrgnlCcyAmt  : ISO20022.Setr027001.AmountAndDirection29
        + ConvtdAmt  : ISO20022.Setr027001.AmountAndDirection29
        + MtchgConfFee  : ISO20022.Setr027001.AmountAndDirection29
        + CsmptnTax  : ISO20022.Setr027001.AmountAndDirection29
        + NetGnLoss  : ISO20022.Setr027001.AmountAndDirection29
        + WhldgTax  : ISO20022.Setr027001.AmountAndDirection29
        + ValAddedTax  : ISO20022.Setr027001.AmountAndDirection29
        + TxTax  : ISO20022.Setr027001.AmountAndDirection29
        + TrfTax  : ISO20022.Setr027001.AmountAndDirection29
        + StockXchgTax  : ISO20022.Setr027001.AmountAndDirection29
        + StmpDty  : ISO20022.Setr027001.AmountAndDirection29
        + SpclCncssn  : ISO20022.Setr027001.AmountAndDirection29
        + RgltryAmt  : ISO20022.Setr027001.AmountAndDirection29
        + Othr  : ISO20022.Setr027001.AmountAndDirection29
        + Mrgn  : ISO20022.Setr027001.AmountAndDirection29
        + LclBrkrComssn  : ISO20022.Setr027001.AmountAndDirection29
        + LclTax  : ISO20022.Setr027001.AmountAndDirection29
        + PmtLevyTax  : ISO20022.Setr027001.AmountAndDirection29
        + IsseDscntAllwnc  : ISO20022.Setr027001.AmountAndDirection29
        + ExctgBrkrAmt  : ISO20022.Setr027001.AmountAndDirection29
        + CtryNtlFdrlTax  : ISO20022.Setr027001.AmountAndDirection29
        + ChrgsFees  : ISO20022.Setr027001.AmountAndDirection29
    }
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.OtherAmounts16 *-- ISO20022.Setr027001.AmountAndDirection29
    class ISO20022.Setr027001.OtherIdentification1 {
        + Tp  : ISO20022.Setr027001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Setr027001.OtherIdentification1 *-- ISO20022.Setr027001.IdentificationSource3Choice
    class ISO20022.Setr027001.OtherParties32 {
        + QlfdFrgnIntrmy  : ISO20022.Setr027001.PartyIdentificationAndAccount151
        + TrptyAgt  : ISO20022.Setr027001.PartyIdentificationAndAccount154
        + TradRgltr  : ISO20022.Setr027001.PartyIdentificationAndAccount152
        + StockXchg  : ISO20022.Setr027001.PartyIdentificationAndAccount152
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Setr027001.PartyIdentificationAndAccount150~
    }
    ISO20022.Setr027001.OtherParties32 *-- ISO20022.Setr027001.PartyIdentificationAndAccount151
    ISO20022.Setr027001.OtherParties32 *-- ISO20022.Setr027001.PartyIdentificationAndAccount154
    ISO20022.Setr027001.OtherParties32 *-- ISO20022.Setr027001.PartyIdentificationAndAccount152
    ISO20022.Setr027001.OtherParties32 *-- ISO20022.Setr027001.PartyIdentificationAndAccount152
    ISO20022.Setr027001.OtherParties32 *-- ISO20022.Setr027001.PartyIdentificationAndAccount150
    class ISO20022.Setr027001.OtherPrices5 {
        + RefPric  : ISO20022.Setr027001.PriceInformation28
        + RptdPric  : ISO20022.Setr027001.Price14
        + IndxPric  : ISO20022.Setr027001.Price14
        + OthrPric  : ISO20022.Setr027001.Price14
        + Bchmk  : ISO20022.Setr027001.Price14
        + AllMktsWghtdAvrg  : ISO20022.Setr027001.Price14
        + BchmkWghtdAvrg  : ISO20022.Setr027001.Price14
        + NtnlGrss  : ISO20022.Setr027001.Price14
        + NetUdscld  : ISO20022.Setr027001.Price14
        + NetDscld  : ISO20022.Setr027001.Price14
        + MrkdDwn  : ISO20022.Setr027001.Price14
        + MrkdUp  : ISO20022.Setr027001.Price14
        + MktBrkrComssn  : ISO20022.Setr027001.Price14
        + Tx  : ISO20022.Setr027001.Price14
        + Max  : ISO20022.Setr027001.Price14
    }
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.PriceInformation28
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.OtherPrices5 *-- ISO20022.Setr027001.Price14
    class ISO20022.Setr027001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Setr027001.PartialFill4 {
        + MtchIncrmtQty  : ISO20022.Setr027001.QuantityOrAmount2Choice
        + RmngQty  : ISO20022.Setr027001.QuantityOrAmount2Choice
        + PrevslyExctdQty  : ISO20022.Setr027001.QuantityOrAmount2Choice
        + OrgnlOrdrdQty  : ISO20022.Setr027001.QuantityOrAmount2Choice
        + PlcOfTrad  : ISO20022.Setr027001.MarketIdentification97
        + TradDt  : ISO20022.Setr027001.TradeDate7Choice
        + DealPric  : ISO20022.Setr027001.Price14
        + ConfQty  : ISO20022.Setr027001.Quantity6Choice
    }
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.QuantityOrAmount2Choice
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.QuantityOrAmount2Choice
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.QuantityOrAmount2Choice
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.QuantityOrAmount2Choice
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.MarketIdentification97
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.TradeDate7Choice
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.PartialFill4 *-- ISO20022.Setr027001.Quantity6Choice
    class ISO20022.Setr027001.PartyIdentification116Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Setr027001.NameAndAddress13
        + AnyBIC  : String
    }
    ISO20022.Setr027001.PartyIdentification116Choice *-- ISO20022.Setr027001.NameAndAddress13
    class ISO20022.Setr027001.PartyIdentification117 {
        + NmAndAdr  : ISO20022.Setr027001.NameAndAddress13
        + PrtryId  : ISO20022.Setr027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Setr027001.PartyIdentification117 *-- ISO20022.Setr027001.NameAndAddress13
    ISO20022.Setr027001.PartyIdentification117 *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.PartyIdentification117Choice {
        + NmAndAdr  : ISO20022.Setr027001.NameAndAddress13
        + PrtryId  : ISO20022.Setr027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Setr027001.PartyIdentification117Choice *-- ISO20022.Setr027001.NameAndAddress13
    ISO20022.Setr027001.PartyIdentification117Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.PartyIdentification118 {
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification116Choice
    }
    ISO20022.Setr027001.PartyIdentification118 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentification118 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentification118 *-- ISO20022.Setr027001.PartyIdentification116Choice
    class ISO20022.Setr027001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Setr027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Setr027001.PartyIdentification127Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.PartyIdentification245Choice {
        + NmAndAdr  : ISO20022.Setr027001.NameAndAddress5
        + PrtryId  : ISO20022.Setr027001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Setr027001.PartyIdentification245Choice *-- ISO20022.Setr027001.NameAndAddress5
    ISO20022.Setr027001.PartyIdentification245Choice *-- ISO20022.Setr027001.GenericIdentification1
    class ISO20022.Setr027001.PartyIdentificationAndAccount148 {
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation2
        + TaxAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.PartyTextInformation2
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentificationAndAccount148 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount149 {
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + PrcgId  : String
        + ClrAcct  : ISO20022.Setr027001.SecuritiesAccount20
        + Sd  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount149 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentificationAndAccount149 *-- ISO20022.Setr027001.SecuritiesAccount20
    ISO20022.Setr027001.PartyIdentificationAndAccount149 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentificationAndAccount149 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount150 {
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + CtryOfRes  : String
        + PrcgId  : String
        + CshAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + SfkpgAcct  : String
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount150 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentificationAndAccount150 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentificationAndAccount150 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount150 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount151 {
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + PrcgId  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount151 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentificationAndAccount151 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentificationAndAccount151 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount152 {
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification10
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + PrcgId  : String
        + Id  : ISO20022.Setr027001.PartyIdentification245Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount152 *-- ISO20022.Setr027001.AlternatePartyIdentification10
    ISO20022.Setr027001.PartyIdentificationAndAccount152 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentificationAndAccount152 *-- ISO20022.Setr027001.PartyIdentification245Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount154 {
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification10
        + AddtlInf  : ISO20022.Setr027001.PartyTextInformation1
        + PrcgId  : String
        + CshAcct  : ISO20022.Setr027001.CashAccountIdentification5Choice
        + SfkpgAcct  : String
        + Id  : ISO20022.Setr027001.PartyIdentification245Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount154 *-- ISO20022.Setr027001.AlternatePartyIdentification10
    ISO20022.Setr027001.PartyIdentificationAndAccount154 *-- ISO20022.Setr027001.PartyTextInformation1
    ISO20022.Setr027001.PartyIdentificationAndAccount154 *-- ISO20022.Setr027001.CashAccountIdentification5Choice
    ISO20022.Setr027001.PartyIdentificationAndAccount154 *-- ISO20022.Setr027001.PartyIdentification245Choice
    class ISO20022.Setr027001.PartyIdentificationAndAccount155 {
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Setr027001.AlternatePartyIdentification8
        + AddtlInf  : String
        + Id  : ISO20022.Setr027001.PartyIdentification117Choice
    }
    ISO20022.Setr027001.PartyIdentificationAndAccount155 *-- ISO20022.Setr027001.AlternatePartyIdentification8
    ISO20022.Setr027001.PartyIdentificationAndAccount155 *-- ISO20022.Setr027001.PartyIdentification117Choice
    class ISO20022.Setr027001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Setr027001.PartyTextInformation2 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Setr027001.PartyTextInformation5 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Setr027001.PositionEffect2Code {
        CLOA = 1
        FIFO = 2
        ROLL = 3
        CLOS = 4
        OPEN = 5
    }
    class ISO20022.Setr027001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr027001.PostalAddress8 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr027001.Price14 {
        + Tp  : String
        + Val  : ISO20022.Setr027001.PriceRateOrAmount3Choice
    }
    ISO20022.Setr027001.Price14 *-- ISO20022.Setr027001.PriceRateOrAmount3Choice
    class ISO20022.Setr027001.PriceInformation28 {
        + SrcOfPric  : ISO20022.Setr027001.MarketIdentification93
        + PricClctnPrd  : ISO20022.Setr027001.DateTimePeriod1Choice
        + QtnDt  : ISO20022.Setr027001.DateAndDateTime1Choice
        + Val  : ISO20022.Setr027001.Price14
    }
    ISO20022.Setr027001.PriceInformation28 *-- ISO20022.Setr027001.MarketIdentification93
    ISO20022.Setr027001.PriceInformation28 *-- ISO20022.Setr027001.DateTimePeriod1Choice
    ISO20022.Setr027001.PriceInformation28 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    ISO20022.Setr027001.PriceInformation28 *-- ISO20022.Setr027001.Price14
    class ISO20022.Setr027001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Setr027001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Setr027001.PriceRateOrAmount3Choice *-- ISO20022.Setr027001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Setr027001.PriceValueType7Code {
        ACTU = 1
        PRCT = 2
        VACT = 3
        FICT = 4
        TEDY = 5
        TEDP = 6
        ABSO = 7
        PEUN = 8
        SPRE = 9
        YIEL = 10
        PARV = 11
        PREM = 12
        DISC = 13
    }
    class ISO20022.Setr027001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Setr027001.PriorityNumeric4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.PurposeCode9Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.PurposeCode9Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Quantity6Choice {
        + OrgnlAndCurFace  : ISO20022.Setr027001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Setr027001.Quantity6Choice *-- ISO20022.Setr027001.OriginalAndCurrentQuantities1
    ISO20022.Setr027001.Quantity6Choice *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    class ISO20022.Setr027001.QuantityBreakdown76 {
        + LotPric  : ISO20022.Setr027001.Price14
        + LotDtTm  : ISO20022.Setr027001.DateAndDateTime1Choice
        + LotQty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + LotNb  : ISO20022.Setr027001.GenericIdentification37
    }
    ISO20022.Setr027001.QuantityBreakdown76 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.QuantityBreakdown76 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    ISO20022.Setr027001.QuantityBreakdown76 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.QuantityBreakdown76 *-- ISO20022.Setr027001.GenericIdentification37
    class ISO20022.Setr027001.QuantityOrAmount2Choice {
        + Amt  : ISO20022.Setr027001.ActiveCurrencyAndAmount
        + Qty  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Setr027001.QuantityOrAmount2Choice *-- ISO20022.Setr027001.ActiveCurrencyAndAmount
    ISO20022.Setr027001.QuantityOrAmount2Choice *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    class ISO20022.Setr027001.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Setr027001.RateName1 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Setr027001.RateOrAbsoluteValue1Choice {
        + AbsVal  : Decimal
        + RateVal  : Decimal
    }
    class ISO20022.Setr027001.RateOrName1Choice {
        + RateNm  : ISO20022.Setr027001.RateName1
        + Rate  : ISO20022.Setr027001.Rate2
    }
    ISO20022.Setr027001.RateOrName1Choice *-- ISO20022.Setr027001.RateName1
    ISO20022.Setr027001.RateOrName1Choice *-- ISO20022.Setr027001.Rate2
    class ISO20022.Setr027001.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Setr027001.RateType35Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.RateType35Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Rating1 {
        + ValId  : String
        + ValDt  : DateTime
        + RatgSchme  : String
    }
    class ISO20022.Setr027001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Setr027001.Registration9Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Registration9Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.RegistrationParameters3 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Setr027001.SecuritiesCertificate3~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Setr027001.DateAndDateTime1Choice
        + CertfctnId  : String
    }
    ISO20022.Setr027001.RegistrationParameters3 *-- ISO20022.Setr027001.SecuritiesCertificate3
    ISO20022.Setr027001.RegistrationParameters3 *-- ISO20022.Setr027001.DateAndDateTime1Choice
    class ISO20022.Setr027001.RegulatoryStipulations1 {
        + Stiptns  : global::System.Collections.Generic.List~String~
        + Ctry  : String
    }
    class ISO20022.Setr027001.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Setr027001.Reporting6Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Reporting6Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.RepurchaseType22Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.RepurchaseType22Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Setr027001.Restriction5Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Restriction5Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Revaluation3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.Revaluation3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Reversible1Code {
        CABK = 1
        FIXD = 2
        REVL = 3
    }
    class ISO20022.Setr027001.Reversible2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.Reversible2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SecuritiesAccount20 {
        + Nm  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Setr027001.SecuritiesAccount35 {
        + Nm  : String
        + Tp  : ISO20022.Setr027001.PurposeCode9Choice
        + Id  : String
    }
    ISO20022.Setr027001.SecuritiesAccount35 *-- ISO20022.Setr027001.PurposeCode9Choice
    class ISO20022.Setr027001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Setr027001.SecuritiesCertificate3 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Setr027001.SecuritiesFinancing12 {
        + ExCpn  : String
        + PrdcPmt  : String
        + RollOver  : String
        + MinDtForCallBck  : DateTime
        + Rvsbl  : ISO20022.Setr027001.Reversible2Choice
        + SctiesLndgTp  : ISO20022.Setr027001.SecuritiesLendingType2Choice
        + EndFctr  : Decimal
        + EndNbOfDaysAcrd  : Decimal
        + AcrdIntrstTax  : String
        + StdCollAmt  : ISO20022.Setr027001.AmountAndDirection5
        + NbOfDaysLndgBrrwg  : ISO20022.Setr027001.Number24Choice
        + DvddRatio  : ISO20022.Setr027001.Rate2
        + StdCollRatio  : ISO20022.Setr027001.Rate2
        + BrrwgRate  : ISO20022.Setr027001.Rate2
        + IntrstRate  : ISO20022.Setr027001.Rate2
        + CtrctTermsModChngd  : String
        + CollTp  : ISO20022.Setr027001.CollateralType4Choice
        + BrrwgRsn  : ISO20022.Setr027001.BorrowingReason2Choice
        + LndgWthColl  : String
        + LndgTxMtd  : ISO20022.Setr027001.LendingTransactionMethod2Choice
        + FincgAgrmt  : ISO20022.Setr027001.Agreement5
        + TtlNbOfCollInstrs  : String
        + ClsgAmtPerPcsOfColl  : ISO20022.Setr027001.AmountAndDirection5
        + PrmAmt  : ISO20022.Setr027001.AmountAndDirection5
        + FrftAmt  : ISO20022.Setr027001.AmountAndDirection5
        + AcrdIntrstPctg  : Decimal
        + AcrdIntrstAmt  : ISO20022.Setr027001.AmountAndDirection5
        + TxCallDely  : String
        + CllblTradInd  : String
        + SprdRate  : ISO20022.Setr027001.SpreadRate1
        + PricgRate  : ISO20022.Setr027001.RateOrName1Choice
        + SctiesHrcut  : ISO20022.Setr027001.Rate2
        + StockLnMrgn  : ISO20022.Setr027001.Rate2
        + RpRate  : ISO20022.Setr027001.Rate2
        + VarblRateSpprt  : ISO20022.Setr027001.RateName1
        + IntrstCmptnMtd  : ISO20022.Setr027001.InterestComputationMethod3Choice
        + LglFrmwk  : String
        + Rvaltn  : ISO20022.Setr027001.Revaluation3Choice
        + RateTp  : ISO20022.Setr027001.RateType35Choice
        + RateChngDt  : DateTime
    }
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Reversible2Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.SecuritiesLendingType2Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Number24Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.CollateralType4Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.BorrowingReason2Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.LendingTransactionMethod2Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Agreement5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.SpreadRate1
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.RateOrName1Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Rate2
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.RateName1
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.InterestComputationMethod3Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.Revaluation3Choice
    ISO20022.Setr027001.SecuritiesFinancing12 *-- ISO20022.Setr027001.RateType35Choice
    class ISO20022.Setr027001.SecuritiesLendingType1Code {
        CABK = 1
        RENW = 2
        NWRG = 3
    }
    class ISO20022.Setr027001.SecuritiesLendingType2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SecuritiesLendingType2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.SecuritiesRTGS4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SecuritiesTradeConfirmationV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Setr027001.SupplementaryData1~
        + RgltryStiptns  : ISO20022.Setr027001.RegulatoryStipulations1
        + TwoLegTxDtls  : ISO20022.Setr027001.TwoLegTransactionDetails5
        + OthrBizPties  : ISO20022.Setr027001.OtherParties32
        + OthrPrics  : global::System.Collections.Generic.List~ISO20022.Setr027001.OtherPrices5~
        + OthrAmts  : global::System.Collections.Generic.List~ISO20022.Setr027001.OtherAmounts16~
        + SttlmAmt  : ISO20022.Setr027001.AmountAndDirection28
        + ClrDtls  : ISO20022.Setr027001.Clearing5
        + CshPties  : ISO20022.Setr027001.CashParties33
        + RcvgSttlmPties  : ISO20022.Setr027001.SettlementParties59
        + DlvrgSttlmPties  : ISO20022.Setr027001.SettlementParties59
        + StgSttlmInstr  : ISO20022.Setr027001.StandingSettlementInstruction13
        + SttlmParams  : ISO20022.Setr027001.SettlementDetails213
        + ConfPties  : global::System.Collections.Generic.List~ISO20022.Setr027001.ConfirmationParties6~
        + Stiptns  : ISO20022.Setr027001.FinancialInstrumentStipulations4
        + UndrlygFinInstrm  : global::System.Collections.Generic.List~ISO20022.Setr027001.UnderlyingFinancialInstrument7~
        + FinInstrmAttrbts  : ISO20022.Setr027001.FinancialInstrumentAttributes124
        + FinInstrmId  : ISO20022.Setr027001.SecurityIdentification19
        + TradDtls  : ISO20022.Setr027001.Order24
        + Refs  : global::System.Collections.Generic.List~ISO20022.Setr027001.Linkages76~
        + NbCnt  : ISO20022.Setr027001.NumberCount1Choice
        + Id  : ISO20022.Setr027001.TransactiontIdentification4
    }
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.SupplementaryData1
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.RegulatoryStipulations1
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.TwoLegTransactionDetails5
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.OtherParties32
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.OtherPrices5
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.OtherAmounts16
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.AmountAndDirection28
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.Clearing5
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.CashParties33
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.SettlementParties59
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.SettlementParties59
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.StandingSettlementInstruction13
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.SettlementDetails213
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.ConfirmationParties6
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.FinancialInstrumentStipulations4
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.UnderlyingFinancialInstrument7
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.FinancialInstrumentAttributes124
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.SecurityIdentification19
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.Order24
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.Linkages76
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.NumberCount1Choice
    ISO20022.Setr027001.SecuritiesTradeConfirmationV05 *-- ISO20022.Setr027001.TransactiontIdentification4
    class ISO20022.Setr027001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Setr027001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Setr027001.SecurityIdentification19 *-- ISO20022.Setr027001.OtherIdentification1
    class ISO20022.Setr027001.SettlementDate16Choice {
        + Cd  : ISO20022.Setr027001.SettlementDateCode12Choice
        + Dt  : ISO20022.Setr027001.DateAndDateTime1Choice
    }
    ISO20022.Setr027001.SettlementDate16Choice *-- ISO20022.Setr027001.SettlementDateCode12Choice
    ISO20022.Setr027001.SettlementDate16Choice *-- ISO20022.Setr027001.DateAndDateTime1Choice
    class ISO20022.Setr027001.SettlementDate5Code {
        WISS = 1
        TBAT = 2
        WHID = 3
        WDIS = 4
        SELL = 5
        TFIV = 6
        TFOR = 7
        TTRE = 8
        TTWO = 9
        TONE = 10
        NXTD = 11
        CASH = 12
        REGU = 13
    }
    class ISO20022.Setr027001.SettlementDateCode12Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementDateCode12Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementDetails213 {
        + ElgblForColl  : String
        + ModCxlAllwd  : ISO20022.Setr027001.ModificationCancellationAllowed4Choice
        + RtrLeg  : String
        + LttrOfGrnt  : ISO20022.Setr027001.LetterOfGuarantee4Choice
        + AutomtcBrrwg  : ISO20022.Setr027001.AutomaticBorrowing6Choice
        + Trckg  : ISO20022.Setr027001.Tracking4Choice
        + StmpDtyTaxBsis  : ISO20022.Setr027001.GenericIdentification30
        + StmpDtyInd  : String
        + TaxCpcty  : ISO20022.Setr027001.TaxCapacityParty4Choice
        + SttlmSysMtd  : ISO20022.Setr027001.SettlementSystemMethod4Choice
        + SttlgCpcty  : ISO20022.Setr027001.SettlingCapacity9Choice
        + SctiesRTGS  : ISO20022.Setr027001.SecuritiesRTGS4Choice
        + LglRstrctns  : ISO20022.Setr027001.Restriction5Choice
        + RpTp  : ISO20022.Setr027001.RepurchaseType22Choice
        + Regn  : ISO20022.Setr027001.Registration9Choice
        + NetgElgblty  : ISO20022.Setr027001.NettingEligibility4Choice
        + MktClntSd  : ISO20022.Setr027001.MarketClientSide6Choice
        + CcyToBuyOrSell  : ISO20022.Setr027001.CurrencyToBuyOrSell1Choice
        + FxStgInstr  : ISO20022.Setr027001.FXStandingInstruction4Choice
        + XpsrTp  : ISO20022.Setr027001.ExposureType18Choice
        + CshClrSys  : ISO20022.Setr027001.CashSettlementSystem4Choice
        + CCPElgblty  : ISO20022.Setr027001.CentralCounterPartyEligibility4Choice
        + BlckTrad  : ISO20022.Setr027001.BlockTrade4Choice
        + BnfclOwnrsh  : ISO20022.Setr027001.BeneficialOwnership4Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Setr027001.SettlementTransactionCondition31Choice~
        + SttlmInstrGnrtn  : ISO20022.Setr027001.SettlementInstructionGeneration2Choice
        + Prty  : ISO20022.Setr027001.PriorityNumeric4Choice
        + HldInd  : String
        + SttlmTxTp  : ISO20022.Setr027001.SettlementTransactionType3Choice
    }
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.ModificationCancellationAllowed4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.LetterOfGuarantee4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.AutomaticBorrowing6Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.Tracking4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.GenericIdentification30
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.TaxCapacityParty4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SettlementSystemMethod4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SettlingCapacity9Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SecuritiesRTGS4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.Restriction5Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.RepurchaseType22Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.Registration9Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.NettingEligibility4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.MarketClientSide6Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.CurrencyToBuyOrSell1Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.FXStandingInstruction4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.ExposureType18Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.CashSettlementSystem4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.CentralCounterPartyEligibility4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.BlockTrade4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.BeneficialOwnership4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SettlementTransactionCondition31Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SettlementInstructionGeneration2Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.PriorityNumeric4Choice
    ISO20022.Setr027001.SettlementDetails213 *-- ISO20022.Setr027001.SettlementTransactionType3Choice
    class ISO20022.Setr027001.SettlementInstructionGeneration1Code {
        NOGE = 1
        GENS = 2
    }
    class ISO20022.Setr027001.SettlementInstructionGeneration2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementInstructionGeneration2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementParties59 {
        + Pty5  : ISO20022.Setr027001.PartyIdentificationAndAccount155
        + Pty4  : ISO20022.Setr027001.PartyIdentificationAndAccount155
        + Pty3  : ISO20022.Setr027001.PartyIdentificationAndAccount155
        + Pty2  : ISO20022.Setr027001.PartyIdentificationAndAccount155
        + Pty1  : ISO20022.Setr027001.PartyIdentificationAndAccount155
        + Dpstry  : ISO20022.Setr027001.PartyIdentification118
    }
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentificationAndAccount155
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentificationAndAccount155
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentificationAndAccount155
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentificationAndAccount155
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentificationAndAccount155
    ISO20022.Setr027001.SettlementParties59 *-- ISO20022.Setr027001.PartyIdentification118
    class ISO20022.Setr027001.SettlementStandingInstructionDatabase1Code {
        VEND = 1
        BRKR = 2
        INTE = 3
    }
    class ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Setr027001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementSystemMethod4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementTransactionCondition31Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementTransactionCondition31Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementTransactionCondition7Code {
        UNEX = 1
        SPST = 2
        SPDL = 3
        SPCS = 4
        CSDP = 5
        PHYS = 6
        KNOC = 7
        FRCL = 8
        EXER = 9
        DRAW = 10
        DLWM = 11
        DIRT = 12
        CLEN = 13
        ASGN = 14
    }
    class ISO20022.Setr027001.SettlementTransactionType3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlementTransactionType3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.SettlementTransactionType7Code {
        OFIT = 1
        GUAR = 2
        TURN = 3
        TRVO = 4
        TRPO = 5
        TRAD = 6
        TBAC = 7
        SYND = 8
        SECL = 9
        SECB = 10
        SBBK = 11
        RVPO = 12
        RPTO = 13
        RODE = 14
        REPU = 15
        RELE = 16
        REDI = 17
        REAL = 18
        PORT = 19
        PLAC = 20
        PAIR = 21
        OWNI = 22
        OWNE = 23
        NSYN = 24
        NETT = 25
        MKUP = 26
        MKDW = 27
        ISSU = 28
        INSP = 29
        FCTA = 30
        CONV = 31
        COLO = 32
        COLI = 33
        BSBK = 34
    }
    class ISO20022.Setr027001.SettlingCapacity1Code {
        SPRI = 1
        SAGE = 2
        CUST = 3
    }
    class ISO20022.Setr027001.SettlingCapacity9Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.SettlingCapacity9Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.Side3Code {
        OPEX = 1
        BORW = 2
        LEND = 3
        SSEX = 4
        SESH = 5
        SEPL = 6
        BUMI = 7
        TWOS = 8
        UNDI = 9
        OPPO = 10
        DEFI = 11
        CSHE = 12
        CRSH = 13
        CROS = 14
        SELL = 15
        BUYI = 16
    }
    class ISO20022.Setr027001.SimpleIdentificationInformation2 {
        + Id  : String
    }
    class ISO20022.Setr027001.SpreadRate1 {
        + RateOrAmt  : ISO20022.Setr027001.AmountOrRate1Choice
        + Sgn  : String
    }
    ISO20022.Setr027001.SpreadRate1 *-- ISO20022.Setr027001.AmountOrRate1Choice
    class ISO20022.Setr027001.StandingSettlementInstruction13 {
        + OthrRcvgSttlmPties  : ISO20022.Setr027001.SettlementParties59
        + OthrDlvrgSttlmPties  : ISO20022.Setr027001.SettlementParties59
        + Vndr  : ISO20022.Setr027001.PartyIdentification117Choice
        + SttlmStgInstrDB  : ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice
    }
    ISO20022.Setr027001.StandingSettlementInstruction13 *-- ISO20022.Setr027001.SettlementParties59
    ISO20022.Setr027001.StandingSettlementInstruction13 *-- ISO20022.Setr027001.SettlementParties59
    ISO20022.Setr027001.StandingSettlementInstruction13 *-- ISO20022.Setr027001.PartyIdentification117Choice
    ISO20022.Setr027001.StandingSettlementInstruction13 *-- ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice
    class ISO20022.Setr027001.SupplementaryData1 {
        + Envlp  : ISO20022.Setr027001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Setr027001.SupplementaryData1 *-- ISO20022.Setr027001.SupplementaryDataEnvelope1
    class ISO20022.Setr027001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Setr027001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TaxCapacityParty4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Setr027001.Term1 {
        + Val  : ISO20022.Setr027001.RateOrAbsoluteValue1Choice
        + Oprtr  : String
    }
    ISO20022.Setr027001.Term1 *-- ISO20022.Setr027001.RateOrAbsoluteValue1Choice
    class ISO20022.Setr027001.TotalNumber1 {
        + TtlOfLkdInstrs  : String
        + CurInstrNb  : String
    }
    class ISO20022.Setr027001.Tracking4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Setr027001.Tracking4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TradeDate7Choice {
        + Val  : ISO20022.Setr027001.TradingDateCode2Choice
        + Dt  : ISO20022.Setr027001.DateAndDateTime1Choice
    }
    ISO20022.Setr027001.TradeDate7Choice *-- ISO20022.Setr027001.TradingDateCode2Choice
    ISO20022.Setr027001.TradeDate7Choice *-- ISO20022.Setr027001.DateAndDateTime1Choice
    class ISO20022.Setr027001.TradeDate8Choice {
        + DtCd  : ISO20022.Setr027001.TradeDateCode3Choice
        + Dt  : ISO20022.Setr027001.DateAndDateTime2Choice
    }
    ISO20022.Setr027001.TradeDate8Choice *-- ISO20022.Setr027001.TradeDateCode3Choice
    ISO20022.Setr027001.TradeDate8Choice *-- ISO20022.Setr027001.DateAndDateTime2Choice
    class ISO20022.Setr027001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TradeDateCode3Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TradeRegulatoryConditions1Code {
        USOL = 1
        SOLI = 2
    }
    class ISO20022.Setr027001.TradeTransactionCondition2Code {
        GTDL = 1
        SPEX = 2
        SPCU = 3
        SPPR = 4
        CAST = 5
        SECR = 6
        SCCR = 7
        SERT = 8
        SCRT = 9
        SCBN = 10
        SEBN = 11
        SECN = 12
        SPCC = 13
    }
    class ISO20022.Setr027001.TradeTransactionCondition9Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TradeTransactionCondition9Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TradeType3Code {
        FUTR = 1
        FUOP = 2
        OPTN = 3
        FBBT = 4
        BOSU = 5
        OFIT = 6
        BORE = 7
        LABO = 8
        BOEN = 9
        BOST = 10
        ISSU = 11
        EMTR = 12
        GUAR = 13
        AGEN = 14
        VWAP = 15
        RISK = 16
        BRBR = 17
        TRAD = 18
        PROG = 19
        PRAL = 20
        LIST = 21
        IPOO = 22
        INDX = 23
        BSKT = 24
    }
    class ISO20022.Setr027001.TradeType4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TradeType4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TradingCapacity4Code {
        TAGT = 1
        SINT = 2
        RMKT = 3
        MLTF = 4
        MKTM = 5
        INFI = 6
        BAGN = 7
        PRAG = 8
        OAGN = 9
        CAGN = 10
        AGEN = 11
        PROP = 12
        RISP = 13
        CPRN = 14
        PRIN = 15
    }
    class ISO20022.Setr027001.TradingCapacity6Code {
        PRIN = 1
        PRAG = 2
        OAGN = 3
        CPRN = 4
        CAGN = 5
        BAGN = 6
        AGEN = 7
    }
    class ISO20022.Setr027001.TradingDate1Code {
        VARI = 1
    }
    class ISO20022.Setr027001.TradingDateCode2Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TradingDateCode2Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TradingPartyCapacity3Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Setr027001.TradingPartyCapacity3Choice *-- ISO20022.Setr027001.GenericIdentification36
    class ISO20022.Setr027001.TradingPartyCapacity4Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TradingPartyCapacity4Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.TransactiontIdentification4 {
        + TxId  : String
    }
    class ISO20022.Setr027001.TwoLegTransactionDetails5 {
        + TwoLegTxTp  : ISO20022.Setr027001.TwoLegTransactionType4Choice
        + PrcgDt  : ISO20022.Setr027001.TradeDate7Choice
        + ClsgSttlmAmt  : ISO20022.Setr027001.AmountAndDirection5
        + ClsgDt  : ISO20022.Setr027001.ClosingDate4Choice
        + EndPric  : ISO20022.Setr027001.Price14
        + ScndLegNrrtv  : String
        + OthrAmts  : global::System.Collections.Generic.List~ISO20022.Setr027001.OtherAmounts16~
        + GrssTradAmt  : ISO20022.Setr027001.AmountAndDirection29
        + ClsgLegId  : String
        + OpngLegId  : String
        + TradDt  : ISO20022.Setr027001.TradeDate8Choice
    }
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.TwoLegTransactionType4Choice
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.TradeDate7Choice
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.AmountAndDirection5
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.ClosingDate4Choice
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.Price14
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.OtherAmounts16
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.AmountAndDirection29
    ISO20022.Setr027001.TwoLegTransactionDetails5 *-- ISO20022.Setr027001.TradeDate8Choice
    class ISO20022.Setr027001.TwoLegTransactionType4Choice {
        + SctiesFincgDtls  : ISO20022.Setr027001.SecuritiesFinancing12
        + FutrOrOptnDtls  : ISO20022.Setr027001.FutureOrOptionDetails3
    }
    ISO20022.Setr027001.TwoLegTransactionType4Choice *-- ISO20022.Setr027001.SecuritiesFinancing12
    ISO20022.Setr027001.TwoLegTransactionType4Choice *-- ISO20022.Setr027001.FutureOrOptionDetails3
    class ISO20022.Setr027001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Setr027001.TypeOfIdentification2Code {
        TXID = 1
        FIIN = 2
        CORP = 3
        CHTY = 4
        ARNU = 5
    }
    class ISO20022.Setr027001.TypeOfPrice3Code {
        RDAV = 1
        PARV = 2
        NET1 = 3
        NET2 = 4
        GREX = 5
        AVOV = 6
        AVER = 7
    }
    class ISO20022.Setr027001.TypeOfPrice47Choice {
        + Prtry  : ISO20022.Setr027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr027001.TypeOfPrice47Choice *-- ISO20022.Setr027001.GenericIdentification30
    class ISO20022.Setr027001.UnderlyingFinancialInstrument7 {
        + Attrbts  : ISO20022.Setr027001.FinancialInstrumentAttributes124
        + Id  : ISO20022.Setr027001.SecurityIdentification19
    }
    ISO20022.Setr027001.UnderlyingFinancialInstrument7 *-- ISO20022.Setr027001.FinancialInstrumentAttributes124
    ISO20022.Setr027001.UnderlyingFinancialInstrument7 *-- ISO20022.Setr027001.SecurityIdentification19
    class ISO20022.Setr027001.UnderlyingRatio2 {
        + RltdFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Setr027001.SecurityIdentification19~
        + UndrlygQtyNmrtr  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
        + UndrlygQtyDnmtr  : ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Setr027001.UnderlyingRatio2 *-- ISO20022.Setr027001.SecurityIdentification19
    ISO20022.Setr027001.UnderlyingRatio2 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr027001.UnderlyingRatio2 *-- ISO20022.Setr027001.FinancialInstrumentQuantity1Choice
    class ISO20022.Setr027001.UnitOfMeasure1Code {
        ACRE = 1
        SQIN = 2
        SQFO = 3
        SQYA = 4
        SQMI = 5
        SMIL = 6
        SCMT = 7
        SMET = 8
        ARES = 9
        HECT = 10
        SQKI = 11
        YARD = 12
        KMET = 13
        MILE = 14
        USPI = 15
        GBPI = 16
        USQA = 17
        GBQA = 18
        USOU = 19
        GBOU = 20
        MILI = 21
        CELI = 22
        LITR = 23
        MMET = 24
        CMET = 25
        METR = 26
        PUND = 27
        KILO = 28
        INCH = 29
        GRAM = 30
        USGA = 31
        GBGA = 32
        FOOT = 33
        TONS = 34
        PIEC = 35
    }
    class ISO20022.Setr027001.YieldCalculation7 {
        + ClctnDt  : DateTime
        + ValPrd  : ISO20022.Setr027001.DateTimePeriod1Choice
        + ValDt  : DateTime
        + RedPric  : ISO20022.Setr027001.Price14
        + ClctnTp  : String
        + Val  : Decimal
    }
    ISO20022.Setr027001.YieldCalculation7 *-- ISO20022.Setr027001.DateTimePeriod1Choice
    ISO20022.Setr027001.YieldCalculation7 *-- ISO20022.Setr027001.Price14
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

## Value ISO20022.Setr027001.AccountIdentification55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryAcct|ISO20022.Setr027001.SimpleIdentificationInformation2||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(PrtryAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Setr027001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr027001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Setr027001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Setr027001.Agreement5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnRatio|Decimal||XmlElement()||
|+|DlvryTp|String||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|ClsgTp|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr027001.AlternatePartyIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|TpOfId|ISO20022.Setr027001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(TpOfId))|

---

## Value ISO20022.Setr027001.AlternatePartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Setr027001.IdentificationType43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Setr027001.AmountAndDirection28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|FXDtls|ISO20022.Setr027001.ForeignExchangeTerms18||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Setr027001.AmountAndDirection29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Setr027001.ForeignExchangeTerms18||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Setr027001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Setr027001.AmountAndDirection5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Setr027001.AmountOrPercentageRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|global::System.Collections.Generic.List<ISO20022.Setr027001.Term1>||XmlElement()||
|+|Opr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Term""",Term),validListMax("""Term""",Term,10),validElement(Term))|

---

## Value ISO20022.Setr027001.AmountOrRate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Setr027001.AmountOrRate2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Enum ISO20022.Setr027001.Appearance1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GLOB|Int32||XmlEnum("""GLOB""")|1|
||TMPG|Int32||XmlEnum("""TMPG""")|2|
||DLBE|Int32||XmlEnum("""DLBE""")|3|
||DFBE|Int32||XmlEnum("""DFBE""")|4|
||BENT|Int32||XmlEnum("""BENT""")|5|
||LIMI|Int32||XmlEnum("""LIMI""")|6|
||NDEL|Int32||XmlEnum("""NDEL""")|7|
||DELI|Int32||XmlEnum("""DELI""")|8|

---

## Enum ISO20022.Setr027001.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Setr027001.AutomaticBorrowing6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Setr027001.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Setr027001.BlockTrade4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.BorrowingReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MMPP|Int32||XmlEnum("""MMPP""")|1|
||TTTP|Int32||XmlEnum("""TTTP""")|2|
||SFCT|Int32||XmlEnum("""SFCT""")|3|

---

## Value ISO20022.Setr027001.BorrowingReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.BusinessProcessType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DPLX|Int32||XmlEnum("""DPLX""")|1|
||IDEL|Int32||XmlEnum("""IDEL""")|2|
||THRU|Int32||XmlEnum("""THRU""")|3|
||PROP|Int32||XmlEnum("""PROP""")|4|
||RSAL|Int32||XmlEnum("""RSAL""")|5|
||PRAC|Int32||XmlEnum("""PRAC""")|6|
||NISP|Int32||XmlEnum("""NISP""")|7|
||ISUP|Int32||XmlEnum("""ISUP""")|8|

---

## Value ISO20022.Setr027001.BusinessProcessType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.CalculationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WRST|Int32||XmlEnum("""WRST""")|1|
||TRYL|Int32||XmlEnum("""TRYL""")|2|
||TTDT|Int32||XmlEnum("""TTDT""")|3|
||TXQV|Int32||XmlEnum("""TXQV""")|4|
||SPLL|Int32||XmlEnum("""SPLL""")|5|
||SHLF|Int32||XmlEnum("""SHLF""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||PRYL|Int32||XmlEnum("""PRYL""")|8|
||PRCL|Int32||XmlEnum("""PRCL""")|9|
||NXPT|Int32||XmlEnum("""NXPT""")|10|
||PNAV|Int32||XmlEnum("""PNAV""")|11|
||NXRF|Int32||XmlEnum("""NXRF""")|12|
||YTMA|Int32||XmlEnum("""YTMA""")|13|
||MARK|Int32||XmlEnum("""MARK""")|14|
||LGAL|Int32||XmlEnum("""LGAL""")|15|
||LSYR|Int32||XmlEnum("""LSYR""")|16|
||LSQR|Int32||XmlEnum("""LSQR""")|17|
||LSMT|Int32||XmlEnum("""LSMT""")|18|
||LSCL|Int32||XmlEnum("""LSCL""")|19|
||NVFL|Int32||XmlEnum("""NVFL""")|20|
||FLAS|Int32||XmlEnum("""FLAS""")|21|
||GVEQ|Int32||XmlEnum("""GVEQ""")|22|
||TRGR|Int32||XmlEnum("""TRGR""")|23|
||CUYI|Int32||XmlEnum("""CUYI""")|24|
||CMPD|Int32||XmlEnum("""CMPD""")|25|
||CLOS|Int32||XmlEnum("""CLOS""")|26|
||CHCL|Int32||XmlEnum("""CHCL""")|27|
||YTNC|Int32||XmlEnum("""YTNC""")|28|
||BOOK|Int32||XmlEnum("""BOOK""")|29|
||AVMA|Int32||XmlEnum("""AVMA""")|30|
||ISSU|Int32||XmlEnum("""ISSU""")|31|
||ANNU|Int32||XmlEnum("""ANNU""")|32|
||AFTX|Int32||XmlEnum("""AFTX""")|33|

---

## Enum ISO20022.Setr027001.CallIn1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CFCC|Int32||XmlEnum("""CFCC""")|1|
||CFST|Int32||XmlEnum("""CFST""")|2|
||CFAV|Int32||XmlEnum("""CFAV""")|3|

---

## Value ISO20022.Setr027001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Enum ISO20022.Setr027001.CashMarginOrder1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MRGC|Int32||XmlEnum("""MRGC""")|1|
||MRGO|Int32||XmlEnum("""MRGO""")|2|
||CASH|Int32||XmlEnum("""CASH""")|3|

---

## Value ISO20022.Setr027001.CashParties33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Setr027001.PartyIdentificationAndAccount148||XmlElement()||
|+|CdtrAgt|ISO20022.Setr027001.PartyIdentificationAndAccount148||XmlElement()||
|+|Cdtr|ISO20022.Setr027001.PartyIdentificationAndAccount148||XmlElement()||
|+|DbtrAgt|ISO20022.Setr027001.PartyIdentificationAndAccount148||XmlElement()||
|+|Dbtr|ISO20022.Setr027001.PartyIdentificationAndAccount148||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Setr027001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Setr027001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Setr027001.ChargeTaxBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Value ISO20022.Setr027001.ChargeTaxBasisType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Setr027001.Clearing5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrSgmt|ISO20022.Setr027001.PartyIdentification127Choice||XmlElement()||
|+|ClrMmb|global::System.Collections.Generic.List<ISO20022.Setr027001.PartyIdentificationAndAccount149>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSgmt),validRequired("""ClrMmb""",ClrMmb),validList("""ClrMmb""",ClrMmb),validElement(ClrMmb))|

---

## Enum ISO20022.Setr027001.ClearingAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LIPR|Int32||XmlEnum("""LIPR""")|1|
||CLIE|Int32||XmlEnum("""CLIE""")|2|
||HOUS|Int32||XmlEnum("""HOUS""")|3|

---

## Enum ISO20022.Setr027001.ClearingSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BORW|Int32||XmlEnum("""BORW""")|1|
||LEND|Int32||XmlEnum("""LEND""")|2|
||SELL|Int32||XmlEnum("""SELL""")|3|
||BUYI|Int32||XmlEnum("""BUYI""")|4|

---

## Value ISO20022.Setr027001.ClosingDate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Setr027001.Date3Choice||XmlElement()||
|+|Dt|ISO20022.Setr027001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Enum ISO20022.Setr027001.ClosingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|
||FLEX|Int32||XmlEnum("""FLEX""")|2|
||TERM|Int32||XmlEnum("""TERM""")|3|
||OVER|Int32||XmlEnum("""OVER""")|4|

---

## Enum ISO20022.Setr027001.CollateralType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||GBBK|Int32||XmlEnum("""GBBK""")|2|
||BOND|Int32||XmlEnum("""BOND""")|3|
||STCF|Int32||XmlEnum("""STCF""")|4|
||INSU|Int32||XmlEnum("""INSU""")|5|
||PHYS|Int32||XmlEnum("""PHYS""")|6|
||SECU|Int32||XmlEnum("""SECU""")|7|
||CASH|Int32||XmlEnum("""CASH""")|8|

---

## Value ISO20022.Setr027001.CollateralType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.Commission24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VATRate|Decimal||XmlElement()||
|+|TtlVATAmt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlComssn|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ClctnDt|DateTime||XmlElement()||
|+|RcptId|ISO20022.Setr027001.PartyIdentification117||XmlElement()||
|+|Comssn|ISO20022.Setr027001.AmountOrRate2Choice||XmlElement()||
|+|Tp|ISO20022.Setr027001.CommissionType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlVATAmt),validElement(TtlComssn),validElement(RcptId),validElement(Comssn),validElement(Tp))|

---

## Value ISO20022.Setr027001.CommissionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.CommissionType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PBOC|Int32||XmlEnum("""PBOC""")|1|
||DFDP|Int32||XmlEnum("""DFDP""")|2|
||BRKR|Int32||XmlEnum("""BRKR""")|3|
||PWEU|Int32||XmlEnum("""PWEU""")|4|
||PWCD|Int32||XmlEnum("""PWCD""")|5|
||PERU|Int32||XmlEnum("""PERU""")|6|
||FLAT|Int32||XmlEnum("""FLAT""")|7|
||PERN|Int32||XmlEnum("""PERN""")|8|
||SOFT|Int32||XmlEnum("""SOFT""")|9|
||STEP|Int32||XmlEnum("""STEP""")|10|
||CLDI|Int32||XmlEnum("""CLDI""")|11|

---

## Value ISO20022.Setr027001.ConfirmationParties6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradBnfcryPty|ISO20022.Setr027001.ConfirmationPartyDetails10||XmlElement()||
|+|AffrmgPty|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|CMUCtrPty|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|CMUPty|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|ExctgBrkr|ISO20022.Setr027001.ConfirmationPartyDetails9||XmlElement()||
|+|ClrFirm|ISO20022.Setr027001.ConfirmationPartyDetails9||XmlElement()||
|+|StepOutFirm|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|StepInFirm|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|IntrdcgFirm|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|BrkrOfCdt|ISO20022.Setr027001.ConfirmationPartyDetails8||XmlElement()||
|+|Lndr|ISO20022.Setr027001.ConfirmationPartyDetails7||XmlElement()||
|+|Sellr|ISO20022.Setr027001.ConfirmationPartyDetails7||XmlElement()||
|+|Brrwr|ISO20022.Setr027001.ConfirmationPartyDetails7||XmlElement()||
|+|Buyr|ISO20022.Setr027001.ConfirmationPartyDetails7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradBnfcryPty),validElement(AffrmgPty),validElement(CMUCtrPty),validElement(CMUPty),validElement(ExctgBrkr),validElement(ClrFirm),validElement(StepOutFirm),validElement(StepInFirm),validElement(IntrdcgFirm),validElement(BrkrOfCdt),validElement(Lndr),validElement(Sellr),validElement(Brrwr),validElement(Buyr))|

---

## Value ISO20022.Setr027001.ConfirmationPartyDetails10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Setr027001.TradingPartyCapacity3Choice||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|CshDtls|ISO20022.Setr027001.AccountIdentification55Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Setr027001.SecuritiesAccount35||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AddtlInf),validElement(AltrnId),validElement(CshDtls),validElement(SfkpgAcct),validElement(Id))|

---

## Value ISO20022.Setr027001.ConfirmationPartyDetails7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgPtyCpcty|ISO20022.Setr027001.TradingPartyCapacity4Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Setr027001.InvestorCapacity4Choice||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradgPtyCpcty),validElement(InvstrCpcty),validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.ConfirmationPartyDetails8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.ConfirmationPartyDetails9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstrPrtcnAssoctnMmbsh|String||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Enum ISO20022.Setr027001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Setr027001.CurrencyToBuyOrSell1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validChoice(CcyToSell,CcyToBuy))|

---

## Value ISO20022.Setr027001.Date3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.DateAndDateTime1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr027001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr027001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.DateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmRg|ISO20022.Setr027001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTmRg),validChoice(DtTmRg,ToDtTm,FrDtTm))|

---

## Value ISO20022.Setr027001.DateTimePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Setr027001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Setr027001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Setr027001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Setr027001.DeliveryType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HOIC|Int32||XmlEnum("""HOIC""")|1|
||TRIP|Int32||XmlEnum("""TRIP""")|2|
||FREE|Int32||XmlEnum("""FREE""")|3|
||APMT|Int32||XmlEnum("""APMT""")|4|

---

## Type ISO20022.Setr027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTradConf|ISO20022.Setr027001.SecuritiesTradeConfirmationV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTradConf))|

---

## Value ISO20022.Setr027001.DocumentNumber17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Setr027001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Value ISO20022.Setr027001.EUCapitalGainType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|EUCptlGn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,EUCptlGn))|

---

## Enum ISO20022.Setr027001.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Enum ISO20022.Setr027001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Setr027001.ExposureType18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.ExposureType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TBAS|Int32||XmlEnum("""TBAS""")|1|
||RVPO|Int32||XmlEnum("""RVPO""")|2|
||BFWD|Int32||XmlEnum("""BFWD""")|3|
||TRCP|Int32||XmlEnum("""TRCP""")|4|
||SWPT|Int32||XmlEnum("""SWPT""")|5|
||SLOA|Int32||XmlEnum("""SLOA""")|6|
||SLEB|Int32||XmlEnum("""SLEB""")|7|
||SCRP|Int32||XmlEnum("""SCRP""")|8|
||SCIR|Int32||XmlEnum("""SCIR""")|9|
||SCIE|Int32||XmlEnum("""SCIE""")|10|
||SBSC|Int32||XmlEnum("""SBSC""")|11|
||REPO|Int32||XmlEnum("""REPO""")|12|
||PAYM|Int32||XmlEnum("""PAYM""")|13|
||OTCD|Int32||XmlEnum("""OTCD""")|14|
||OPTN|Int32||XmlEnum("""OPTN""")|15|
||LIQU|Int32||XmlEnum("""LIQU""")|16|
||FUTR|Int32||XmlEnum("""FUTR""")|17|
||FORX|Int32||XmlEnum("""FORX""")|18|
||FORW|Int32||XmlEnum("""FORW""")|19|
||FIXI|Int32||XmlEnum("""FIXI""")|20|
||EXTD|Int32||XmlEnum("""EXTD""")|21|
||EXPT|Int32||XmlEnum("""EXPT""")|22|
||EQUS|Int32||XmlEnum("""EQUS""")|23|
||EQPT|Int32||XmlEnum("""EQPT""")|24|
||CRTL|Int32||XmlEnum("""CRTL""")|25|
||CRSP|Int32||XmlEnum("""CRSP""")|26|
||CRPR|Int32||XmlEnum("""CRPR""")|27|
||CRDS|Int32||XmlEnum("""CRDS""")|28|
||COMM|Int32||XmlEnum("""COMM""")|29|
||CCIR|Int32||XmlEnum("""CCIR""")|30|

---

## Value ISO20022.Setr027001.FXStandingInstruction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Setr027001.FinancialInstrumentAttributes124


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|CtrctSz|ISO20022.Setr027001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|MinExrcblMltplQty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MinExrcblQty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Setr027001.Price14||XmlElement()||
|+|ConvsPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|SbcptPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|ExrcPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|YldVar|String||XmlElement()||
|+|RedYldImpct|String||XmlElement()||
|+|OddCpnInd|String||XmlElement()||
|+|WarrtAttchdOnDlvry|String||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|CvrdInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|ConvtblInd|String||XmlElement()||
|+|VrsnNb|ISO20022.Setr027001.Number1Choice||XmlElement()||
|+|PoolNb|ISO20022.Setr027001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Setr027001.Number1Choice||XmlElement()||
|+|PctgOfDebtClms|Decimal||XmlElement()||
|+|IndxRateBsis|Decimal||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|EndFctr|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|NxtFctrDt|DateTime||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|CpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnTp|ISO20022.Setr027001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Setr027001.OptionStyle10Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Setr027001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Setr027001.Frequency23Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Setr027001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Setr027001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Setr027001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|CertNb|String||XmlElement()||
|+|Ratg|ISO20022.Setr027001.Rating1||XmlElement()||
|+|PlcOfListg|ISO20022.Setr027001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinExrcblMltplQty),validElement(MinExrcblQty),validElement(MinNmnlQty),validElement(TaxblIncmPerShr),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(VrsnNb),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(Ratg),validElement(PlcOfListg))|

---

## Value ISO20022.Setr027001.FinancialInstrumentQuantity18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Setr027001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Setr027001.FinancialInstrumentStipulations4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PerptlInd|String||XmlElement()||
|+|EscrwdInd|String||XmlElement()||
|+|PreFnddInd|String||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|ConvtblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|PricRg|ISO20022.Setr027001.AmountOrPercentageRange1||XmlElement()||
|+|OverAlltmtRate|Decimal||XmlElement()||
|+|OverAlltmtAmt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|PricSrc|String||XmlElement()||
|+|WhlPoolInd|String||XmlElement()||
|+|SbstitnLft|Decimal||XmlElement()||
|+|SbstitnFrqcy|String||XmlElement()||
|+|Sctr|String||XmlElement()||
|+|PricFrqcy|String||XmlElement()||
|+|RstrctdInd|String||XmlElement()||
|+|Pdctn|String||XmlElement()||
|+|MinQty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|PmtFrqcy|String||XmlElement()||
|+|MinIncrmt|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MaxSbstitn|Decimal||XmlElement()||
|+|MinDnmtn|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|IsseSz|Decimal||XmlElement()||
|+|IssrId|String||XmlElement()||
|+|IsseDt|String||XmlElement()||
|+|MtrtyDt|String||XmlElement()||
|+|LookBck|Decimal||XmlElement()||
|+|InsrdInd|String||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|CstmDt|ISO20022.Setr027001.DateTimePeriod2||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|TxConds|String||XmlElement()||
|+|AutoRinvstmt|Decimal||XmlElement()||
|+|AltrntvMinTaxInd|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|AmtsblInd|String||XmlElement()||
|+|CpnRg|ISO20022.Setr027001.AmountOrPercentageRange1||XmlElement()||
|+|Ratg|ISO20022.Setr027001.Rating1||XmlElement()||
|+|YldRg|ISO20022.Setr027001.AmountOrPercentageRange1||XmlElement()||
|+|Geogcs|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricRg),validElement(OverAlltmtAmt),validElement(MinQty),validElement(MinIncrmt),validElement(MinDnmtn),validPattern("""IssrId""",IssrId,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(CstmDt),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(CpnRg),validElement(Ratg),validElement(YldRg))|

---

## Value ISO20022.Setr027001.ForeignExchangeTerms18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConvtdAmt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ConvtdAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Setr027001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Setr027001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.Frequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDA|Int32||XmlEnum("""INDA""")|1|
||ADHO|Int32||XmlEnum("""ADHO""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||WEEK|Int32||XmlEnum("""WEEK""")|4|
||MIAN|Int32||XmlEnum("""MIAN""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||YEAR|Int32||XmlEnum("""YEAR""")|8|

---

## Value ISO20022.Setr027001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.FutureAndOptionContractType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXFU|Int32||XmlEnum("""EXFU""")|1|
||INDX|Int32||XmlEnum("""INDX""")|2|
||ORDY|Int32||XmlEnum("""ORDY""")|3|

---

## Value ISO20022.Setr027001.FutureOrOptionDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SprdTx|String||XmlElement()||
|+|LastTx|String||XmlElement()||
|+|OptnRghts|ISO20022.Setr027001.OptionRight2Choice||XmlElement()||
|+|IssePric|ISO20022.Setr027001.Price14||XmlElement()||
|+|Ratg|global::System.Collections.Generic.List<ISO20022.Setr027001.Rating1>||XmlElement()||
|+|Ratio|global::System.Collections.Generic.List<ISO20022.Setr027001.UnderlyingRatio2>||XmlElement()||
|+|FrstDealgDt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|CtrctSttlmMnth|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|MinTradgPricgIncrmt|Decimal||XmlElement()||
|+|NearTermPosLmt|Decimal||XmlElement()||
|+|PosLmt|Decimal||XmlElement()||
|+|StrpblInd|String||XmlElement()||
|+|Apprnc|String||XmlElement()||
|+|AnncmntDt|DateTime||XmlElement()||
|+|MinSz|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|FutrDt|DateTime||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|LastDlvryDt|DateTime||XmlElement()||
|+|FutrAndOptnCtrctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OptnRghts),validElement(IssePric),validList("""Ratg""",Ratg),validElement(Ratg),validList("""Ratio""",Ratio),validElement(Ratio),validElement(FrstDealgDt),validElement(MinSz))|

---

## Value ISO20022.Setr027001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr027001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.GenericIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.IdentificationReference15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnqTxIdr|String||XmlElement()||
|+|CollTxId|String||XmlElement()||
|+|CmplcId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|IndxId|String||XmlElement()||
|+|ScndryAllcnId|String||XmlElement()||
|+|IndvAllcnId|String||XmlElement()||
|+|AllcnId|String||XmlElement()||
|+|BlckId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|ClntOrdrLkId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|ExctgPtyTxId|String||XmlElement()||
|+|InstgPtyTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(UnqTxIdr,CollTxId,CmplcId,CmonId,IndxId,ScndryAllcnId,IndvAllcnId,AllcnId,BlckId,PoolId,ClntOrdrLkId,MktInfrstrctrTxId,ExctgPtyTxId,InstgPtyTxId))|

---

## Value ISO20022.Setr027001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.IdentificationType43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.InterestComputationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||A014|Int32||XmlEnum("""A014""")|1|
||A013|Int32||XmlEnum("""A013""")|2|
||A012|Int32||XmlEnum("""A012""")|3|
||A011|Int32||XmlEnum("""A011""")|4|
||A010|Int32||XmlEnum("""A010""")|5|
||A009|Int32||XmlEnum("""A009""")|6|
||A008|Int32||XmlEnum("""A008""")|7|
||A007|Int32||XmlEnum("""A007""")|8|
||A006|Int32||XmlEnum("""A006""")|9|
||A005|Int32||XmlEnum("""A005""")|10|
||A004|Int32||XmlEnum("""A004""")|11|
||A003|Int32||XmlEnum("""A003""")|12|
||A002|Int32||XmlEnum("""A002""")|13|
||A001|Int32||XmlEnum("""A001""")|14|

---

## Enum ISO20022.Setr027001.InterestComputationMethod2Code


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

## Value ISO20022.Setr027001.InterestComputationMethod3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.InterestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||XINT|Int32||XmlEnum("""XINT""")|1|
||CINT|Int32||XmlEnum("""CINT""")|2|

---

## Value ISO20022.Setr027001.InvestorCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.LegalFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAN|Int32||XmlEnum("""FRAN""")|1|

---

## Enum ISO20022.Setr027001.LendingTransactionMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXTR|Int32||XmlEnum("""EXTR""")|1|
||ODTR|Int32||XmlEnum("""ODTR""")|2|

---

## Value ISO20022.Setr027001.LendingTransactionMethod2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.LetterOfGuarantee4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Setr027001.Linkages76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|ISO20022.Setr027001.IdentificationReference15Choice||XmlElement()||
|+|MsgNb|ISO20022.Setr027001.DocumentNumber17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ref),validElement(MsgNb))|

---

## Enum ISO20022.Setr027001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Setr027001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Setr027001.MarketIdentification93


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr027001.MarketType18Choice||XmlElement()||
|+|Id|ISO20022.Setr027001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Setr027001.MarketIdentification97


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr027001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Setr027001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Setr027001.MarketType18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Enum ISO20022.Setr027001.MarketType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|

---

## Value ISO20022.Setr027001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Setr027001.MatchingStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.ModificationCancellationAllowed4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Setr027001.NameAndAddress13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr027001.PostalAddress8||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Setr027001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr027001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Setr027001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Setr027001.Number1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification7||XmlElement()||
|+|NbId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""NbId""",NbId,"""[0-9]{1,3}"""),validChoice(Prtry,NbId))|

---

## Value ISO20022.Setr027001.Number24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|NbId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""NbId""",NbId,"""[0-9]{1,4}"""),validChoice(Prtry,NbId))|

---

## Value ISO20022.Setr027001.NumberCount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNb|ISO20022.Setr027001.TotalNumber1||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNb),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""),validChoice(TtlNb,CurInstrNb))|

---

## Enum ISO20022.Setr027001.Operation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANDD|Int32||XmlEnum("""ANDD""")|1|
||ORRR|Int32||XmlEnum("""ORRR""")|2|
||TILL|Int32||XmlEnum("""TILL""")|3|

---

## Enum ISO20022.Setr027001.Operator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQAL|Int32||XmlEnum("""EQAL""")|1|
||GREQ|Int32||XmlEnum("""GREQ""")|2|
||GREA|Int32||XmlEnum("""GREA""")|3|
||SMEQ|Int32||XmlEnum("""SMEQ""")|4|
||SMAL|Int32||XmlEnum("""SMAL""")|5|

---

## Enum ISO20022.Setr027001.OptionRight1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXPI|Int32||XmlEnum("""EXPI""")|1|
||RENO|Int32||XmlEnum("""RENO""")|2|
||ASGN|Int32||XmlEnum("""ASGN""")|3|
||EXER|Int32||XmlEnum("""EXER""")|4|

---

## Value ISO20022.Setr027001.OptionRight2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.OptionStyle10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.OptionStyle4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BERM|Int32||XmlEnum("""BERM""")|1|
||EURO|Int32||XmlEnum("""EURO""")|2|
||AMER|Int32||XmlEnum("""AMER""")|3|

---

## Enum ISO20022.Setr027001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Setr027001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.Order24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlTradInstrPrcgInf|String||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Setr027001.RegistrationParameters3||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Setr027001.Reporting6Choice>||XmlElement()||
|+|YldTp|ISO20022.Setr027001.YieldCalculation7||XmlElement()||
|+|CallInTp|String||XmlElement()||
|+|MtchSts|ISO20022.Setr027001.MatchingStatus27Choice||XmlElement()||
|+|CptlGnTp|ISO20022.Setr027001.EUCapitalGainType3Choice||XmlElement()||
|+|ChrgTaxBsisTp|ISO20022.Setr027001.ChargeTaxBasisType2Choice||XmlElement()||
|+|DerivCvrd|String||XmlElement()||
|+|PosFct|String||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Setr027001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TradRgltryCondsTp|String||XmlElement()||
|+|AcrdIntrstPctg|Decimal||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|IntrstTp|String||XmlElement()||
|+|GvUpNbOfDays|Decimal||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|Comssn|ISO20022.Setr027001.Commission24||XmlElement()||
|+|CshMrgn|String||XmlElement()||
|+|TpOfPric|ISO20022.Setr027001.TypeOfPrice47Choice||XmlElement()||
|+|DealPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|GrssTradAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Setr027001.QuantityBreakdown76>||XmlElement()||
|+|ConfQty|ISO20022.Setr027001.Quantity6Choice||XmlElement()||
|+|PrtlFillDtls|global::System.Collections.Generic.List<ISO20022.Setr027001.PartialFill4>||XmlElement()||
|+|NAVDt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|SttlmDt|ISO20022.Setr027001.SettlementDate16Choice||XmlElement()||
|+|PrcgDt|ISO20022.Setr027001.TradeDate7Choice||XmlElement()||
|+|TradDt|ISO20022.Setr027001.TradeDate7Choice||XmlElement()||
|+|TradOrgtnDt|DateTime||XmlElement()||
|+|OrdrBookgDt|DateTime||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr027001.MarketIdentification93||XmlElement()||
|+|PreAdvc|String||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Setr027001.TradeTransactionCondition9Choice>||XmlElement()||
|+|TradTxTp|ISO20022.Setr027001.TradeType4Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|Sd|String||XmlElement()||
|+|ListId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ScndryClntOrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ClntOrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|BizPrcTp|ISO20022.Setr027001.BusinessProcessType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlPhysOrRegnDtls),validList("""Rptg""",Rptg),validElement(Rptg),validElement(YldTp),validElement(MtchSts),validElement(CptlGnTp),validElement(ChrgTaxBsisTp),validElement(CcyToBuyOrSell),validElement(AcrdIntrstAmt),validElement(Comssn),validElement(TpOfPric),validElement(DealPric),validElement(GrssTradAmt),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(ConfQty),validList("""PrtlFillDtls""",PrtlFillDtls),validElement(PrtlFillDtls),validElement(NAVDt),validElement(SttlmDt),validElement(PrcgDt),validElement(TradDt),validElement(PlcOfTrad),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(TradTxTp),validElement(BizPrcTp))|

---

## Value ISO20022.Setr027001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.OtherAmounts16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OddLotFee|String||XmlElement()||
|+|DiffInPric|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ClrBrkrComssn|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|RmngBookVal|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|RmngFaceVal|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|NetMktVal|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|BrrwgFee|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|BrrwgIntrstAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|RmnrtnAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|RmnrtnAmtReq|String||XmlElement()||
|+|MktMmbFeeAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ShrdBrkrgAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclTaxCtrySpcfc4|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclTaxCtrySpcfc3|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclTaxCtrySpcfc2|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclTaxCtrySpcfc1|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|AcrdCptlstnAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|BookVal|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|OrgnlCcyAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ConvtdAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|MtchgConfFee|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|CsmptnTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|NetGnLoss|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|WhldgTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ValAddedTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|TxTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|TrfTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|StockXchgTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|StmpDty|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|SpclCncssn|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|RgltryAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|Othr|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|Mrgn|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclBrkrComssn|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|LclTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|PmtLevyTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|IsseDscntAllwnc|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ChrgsFees|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DiffInPric),validElement(ClrBrkrComssn),validElement(RmngBookVal),validElement(RmngFaceVal),validElement(NetMktVal),validElement(BrrwgFee),validElement(BrrwgIntrstAmt),validElement(RmnrtnAmt),validElement(MktMmbFeeAmt),validElement(ShrdBrkrgAmt),validElement(LclTaxCtrySpcfc4),validElement(LclTaxCtrySpcfc3),validElement(LclTaxCtrySpcfc2),validElement(LclTaxCtrySpcfc1),validElement(AcrdCptlstnAmt),validElement(BookVal),validElement(OrgnlCcyAmt),validElement(ConvtdAmt),validElement(MtchgConfFee),validElement(CsmptnTax),validElement(NetGnLoss),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(SpclCncssn),validElement(RgltryAmt),validElement(Othr),validElement(Mrgn),validElement(LclBrkrComssn),validElement(LclTax),validElement(PmtLevyTax),validElement(IsseDscntAllwnc),validElement(ExctgBrkrAmt),validElement(CtryNtlFdrlTax),validElement(ChrgsFees))|

---

## Value ISO20022.Setr027001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr027001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr027001.OtherParties32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QlfdFrgnIntrmy|ISO20022.Setr027001.PartyIdentificationAndAccount151||XmlElement()||
|+|TrptyAgt|ISO20022.Setr027001.PartyIdentificationAndAccount154||XmlElement()||
|+|TradRgltr|ISO20022.Setr027001.PartyIdentificationAndAccount152||XmlElement()||
|+|StockXchg|ISO20022.Setr027001.PartyIdentificationAndAccount152||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Setr027001.PartyIdentificationAndAccount150>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QlfdFrgnIntrmy),validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Value ISO20022.Setr027001.OtherPrices5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefPric|ISO20022.Setr027001.PriceInformation28||XmlElement()||
|+|RptdPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|IndxPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|OthrPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|Bchmk|ISO20022.Setr027001.Price14||XmlElement()||
|+|AllMktsWghtdAvrg|ISO20022.Setr027001.Price14||XmlElement()||
|+|BchmkWghtdAvrg|ISO20022.Setr027001.Price14||XmlElement()||
|+|NtnlGrss|ISO20022.Setr027001.Price14||XmlElement()||
|+|NetUdscld|ISO20022.Setr027001.Price14||XmlElement()||
|+|NetDscld|ISO20022.Setr027001.Price14||XmlElement()||
|+|MrkdDwn|ISO20022.Setr027001.Price14||XmlElement()||
|+|MrkdUp|ISO20022.Setr027001.Price14||XmlElement()||
|+|MktBrkrComssn|ISO20022.Setr027001.Price14||XmlElement()||
|+|Tx|ISO20022.Setr027001.Price14||XmlElement()||
|+|Max|ISO20022.Setr027001.Price14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefPric),validElement(RptdPric),validElement(IndxPric),validElement(OthrPric),validElement(Bchmk),validElement(AllMktsWghtdAvrg),validElement(BchmkWghtdAvrg),validElement(NtnlGrss),validElement(NetUdscld),validElement(NetDscld),validElement(MrkdDwn),validElement(MrkdUp),validElement(MktBrkrComssn),validElement(Tx),validElement(Max))|

---

## Enum ISO20022.Setr027001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Setr027001.PartialFill4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtchIncrmtQty|ISO20022.Setr027001.QuantityOrAmount2Choice||XmlElement()||
|+|RmngQty|ISO20022.Setr027001.QuantityOrAmount2Choice||XmlElement()||
|+|PrevslyExctdQty|ISO20022.Setr027001.QuantityOrAmount2Choice||XmlElement()||
|+|OrgnlOrdrdQty|ISO20022.Setr027001.QuantityOrAmount2Choice||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr027001.MarketIdentification97||XmlElement()||
|+|TradDt|ISO20022.Setr027001.TradeDate7Choice||XmlElement()||
|+|DealPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|ConfQty|ISO20022.Setr027001.Quantity6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchIncrmtQty),validElement(RmngQty),validElement(PrevslyExctdQty),validElement(OrgnlOrdrdQty),validElement(PlcOfTrad),validElement(TradDt),validElement(DealPric),validElement(ConfQty))|

---

## Value ISO20022.Setr027001.PartyIdentification116Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Setr027001.NameAndAddress13||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Setr027001.PartyIdentification117


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr027001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr027001.PartyIdentification117Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr027001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Setr027001.PartyIdentification118


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification116Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Setr027001.PartyIdentification245Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr027001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Setr027001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount148


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|ClrAcct|ISO20022.Setr027001.SecuritiesAccount20||XmlElement()||
|+|Sd|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(ClrAcct),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount150


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(AddtlInf),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(CshAcct),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount151


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount152


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification10||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification245Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(AddtlInf),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount154


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification10||XmlElement()||
|+|AddtlInf|ISO20022.Setr027001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Setr027001.CashAccountIdentification5Choice||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification245Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(AddtlInf),validElement(CshAcct),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyIdentificationAndAccount155


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Setr027001.AlternatePartyIdentification8||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|Id|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr027001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.PartyTextInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.PartyTextInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Setr027001.PositionEffect2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLOA|Int32||XmlEnum("""CLOA""")|1|
||FIFO|Int32||XmlEnum("""FIFO""")|2|
||ROLL|Int32||XmlEnum("""ROLL""")|3|
||CLOS|Int32||XmlEnum("""CLOS""")|4|
||OPEN|Int32||XmlEnum("""OPEN""")|5|

---

## Value ISO20022.Setr027001.PostalAddress1


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

## Value ISO20022.Setr027001.PostalAddress8


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

## Value ISO20022.Setr027001.Price14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|ISO20022.Setr027001.PriceRateOrAmount3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Value ISO20022.Setr027001.PriceInformation28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrcOfPric|ISO20022.Setr027001.MarketIdentification93||XmlElement()||
|+|PricClctnPrd|ISO20022.Setr027001.DateTimePeriod1Choice||XmlElement()||
|+|QtnDt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|Val|ISO20022.Setr027001.Price14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrcOfPric),validElement(PricClctnPrd),validElement(QtnDt),validElement(Val))|

---

## Value ISO20022.Setr027001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr027001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Setr027001.PriceValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||VACT|Int32||XmlEnum("""VACT""")|3|
||FICT|Int32||XmlEnum("""FICT""")|4|
||TEDY|Int32||XmlEnum("""TEDY""")|5|
||TEDP|Int32||XmlEnum("""TEDP""")|6|
||ABSO|Int32||XmlEnum("""ABSO""")|7|
||PEUN|Int32||XmlEnum("""PEUN""")|8|
||SPRE|Int32||XmlEnum("""SPRE""")|9|
||YIEL|Int32||XmlEnum("""YIEL""")|10|
||PARV|Int32||XmlEnum("""PARV""")|11|
||PREM|Int32||XmlEnum("""PREM""")|12|
||DISC|Int32||XmlEnum("""DISC""")|13|

---

## Value ISO20022.Setr027001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Setr027001.PurposeCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.Quantity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Setr027001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Setr027001.QuantityBreakdown76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|LotDtTm|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|LotQty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotNb|ISO20022.Setr027001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Setr027001.QuantityOrAmount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr027001.ActiveCurrencyAndAmount||XmlElement()||
|+|Qty|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Qty),validChoice(Amt,Qty))|

---

## Value ISO20022.Setr027001.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.RateName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.RateOrAbsoluteValue1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AbsVal|Decimal||XmlElement()||
|+|RateVal|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AbsVal,RateVal))|

---

## Value ISO20022.Setr027001.RateOrName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|ISO20022.Setr027001.RateName1||XmlElement()||
|+|Rate|ISO20022.Setr027001.Rate2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateNm),validElement(Rate),validChoice(RateNm,Rate))|

---

## Enum ISO20022.Setr027001.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Setr027001.RateType35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.Rating1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValId|String||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|RatgSchme|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Setr027001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Setr027001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.RegistrationParameters3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Setr027001.SecuritiesCertificate3>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validElement(CertfctnDtTm))|

---

## Value ISO20022.Setr027001.RegulatoryStipulations1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Stiptns|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Stiptns""",Stiptns),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Setr027001.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Setr027001.Reporting6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.RepurchaseType22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.RepurchaseType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|
||ROLP|Int32||XmlEnum("""ROLP""")|4|
||CALL|Int32||XmlEnum("""CALL""")|5|
||RATE|Int32||XmlEnum("""RATE""")|6|
||PADJ|Int32||XmlEnum("""PADJ""")|7|
||PAIR|Int32||XmlEnum("""PAIR""")|8|

---

## Value ISO20022.Setr027001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.Revaluation3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Setr027001.Reversible1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CABK|Int32||XmlEnum("""CABK""")|1|
||FIXD|Int32||XmlEnum("""FIXD""")|2|
||REVL|Int32||XmlEnum("""REVL""")|3|

---

## Value ISO20022.Setr027001.Reversible2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.SecuritiesAccount20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.SecuritiesAccount35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Setr027001.PurposeCode9Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Setr027001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Value ISO20022.Setr027001.SecuritiesCertificate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.SecuritiesFinancing12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExCpn|String||XmlElement()||
|+|PrdcPmt|String||XmlElement()||
|+|RollOver|String||XmlElement()||
|+|MinDtForCallBck|DateTime||XmlElement()||
|+|Rvsbl|ISO20022.Setr027001.Reversible2Choice||XmlElement()||
|+|SctiesLndgTp|ISO20022.Setr027001.SecuritiesLendingType2Choice||XmlElement()||
|+|EndFctr|Decimal||XmlElement()||
|+|EndNbOfDaysAcrd|Decimal||XmlElement()||
|+|AcrdIntrstTax|String||XmlElement()||
|+|StdCollAmt|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|NbOfDaysLndgBrrwg|ISO20022.Setr027001.Number24Choice||XmlElement()||
|+|DvddRatio|ISO20022.Setr027001.Rate2||XmlElement()||
|+|StdCollRatio|ISO20022.Setr027001.Rate2||XmlElement()||
|+|BrrwgRate|ISO20022.Setr027001.Rate2||XmlElement()||
|+|IntrstRate|ISO20022.Setr027001.Rate2||XmlElement()||
|+|CtrctTermsModChngd|String||XmlElement()||
|+|CollTp|ISO20022.Setr027001.CollateralType4Choice||XmlElement()||
|+|BrrwgRsn|ISO20022.Setr027001.BorrowingReason2Choice||XmlElement()||
|+|LndgWthColl|String||XmlElement()||
|+|LndgTxMtd|ISO20022.Setr027001.LendingTransactionMethod2Choice||XmlElement()||
|+|FincgAgrmt|ISO20022.Setr027001.Agreement5||XmlElement()||
|+|TtlNbOfCollInstrs|String||XmlElement()||
|+|ClsgAmtPerPcsOfColl|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|PrmAmt|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|FrftAmt|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|AcrdIntrstPctg|Decimal||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|TxCallDely|String||XmlElement()||
|+|CllblTradInd|String||XmlElement()||
|+|SprdRate|ISO20022.Setr027001.SpreadRate1||XmlElement()||
|+|PricgRate|ISO20022.Setr027001.RateOrName1Choice||XmlElement()||
|+|SctiesHrcut|ISO20022.Setr027001.Rate2||XmlElement()||
|+|StockLnMrgn|ISO20022.Setr027001.Rate2||XmlElement()||
|+|RpRate|ISO20022.Setr027001.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Setr027001.RateName1||XmlElement()||
|+|IntrstCmptnMtd|ISO20022.Setr027001.InterestComputationMethod3Choice||XmlElement()||
|+|LglFrmwk|String||XmlElement()||
|+|Rvaltn|ISO20022.Setr027001.Revaluation3Choice||XmlElement()||
|+|RateTp|ISO20022.Setr027001.RateType35Choice||XmlElement()||
|+|RateChngDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rvsbl),validElement(SctiesLndgTp),validElement(StdCollAmt),validElement(NbOfDaysLndgBrrwg),validElement(DvddRatio),validElement(StdCollRatio),validElement(BrrwgRate),validElement(IntrstRate),validElement(CollTp),validElement(BrrwgRsn),validElement(LndgTxMtd),validElement(FincgAgrmt),validPattern("""TtlNbOfCollInstrs""",TtlNbOfCollInstrs,"""[0-9]{1,3}"""),validElement(ClsgAmtPerPcsOfColl),validElement(PrmAmt),validElement(FrftAmt),validElement(AcrdIntrstAmt),validPattern("""TxCallDely""",TxCallDely,"""[0-9]{1,3}"""),validElement(SprdRate),validElement(PricgRate),validElement(SctiesHrcut),validElement(StockLnMrgn),validElement(RpRate),validElement(VarblRateSpprt),validElement(IntrstCmptnMtd),validElement(Rvaltn),validElement(RateTp))|

---

## Enum ISO20022.Setr027001.SecuritiesLendingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CABK|Int32||XmlEnum("""CABK""")|1|
||RENW|Int32||XmlEnum("""RENW""")|2|
||NWRG|Int32||XmlEnum("""NWRG""")|3|

---

## Value ISO20022.Setr027001.SecuritiesLendingType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Setr027001.SecuritiesTradeConfirmationV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Setr027001.SupplementaryData1>||XmlElement()||
|+|RgltryStiptns|ISO20022.Setr027001.RegulatoryStipulations1||XmlElement()||
|+|TwoLegTxDtls|ISO20022.Setr027001.TwoLegTransactionDetails5||XmlElement()||
|+|OthrBizPties|ISO20022.Setr027001.OtherParties32||XmlElement()||
|+|OthrPrics|global::System.Collections.Generic.List<ISO20022.Setr027001.OtherPrices5>||XmlElement()||
|+|OthrAmts|global::System.Collections.Generic.List<ISO20022.Setr027001.OtherAmounts16>||XmlElement()||
|+|SttlmAmt|ISO20022.Setr027001.AmountAndDirection28||XmlElement()||
|+|ClrDtls|ISO20022.Setr027001.Clearing5||XmlElement()||
|+|CshPties|ISO20022.Setr027001.CashParties33||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Setr027001.SettlementParties59||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Setr027001.SettlementParties59||XmlElement()||
|+|StgSttlmInstr|ISO20022.Setr027001.StandingSettlementInstruction13||XmlElement()||
|+|SttlmParams|ISO20022.Setr027001.SettlementDetails213||XmlElement()||
|+|ConfPties|global::System.Collections.Generic.List<ISO20022.Setr027001.ConfirmationParties6>||XmlElement()||
|+|Stiptns|ISO20022.Setr027001.FinancialInstrumentStipulations4||XmlElement()||
|+|UndrlygFinInstrm|global::System.Collections.Generic.List<ISO20022.Setr027001.UnderlyingFinancialInstrument7>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Setr027001.FinancialInstrumentAttributes124||XmlElement()||
|+|FinInstrmId|ISO20022.Setr027001.SecurityIdentification19||XmlElement()||
|+|TradDtls|ISO20022.Setr027001.Order24||XmlElement()||
|+|Refs|global::System.Collections.Generic.List<ISO20022.Setr027001.Linkages76>||XmlElement()||
|+|NbCnt|ISO20022.Setr027001.NumberCount1Choice||XmlElement()||
|+|Id|ISO20022.Setr027001.TransactiontIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RgltryStiptns),validElement(TwoLegTxDtls),validElement(OthrBizPties),validList("""OthrPrics""",OthrPrics),validElement(OthrPrics),validList("""OthrAmts""",OthrAmts),validElement(OthrAmts),validElement(SttlmAmt),validElement(ClrDtls),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(StgSttlmInstr),validElement(SttlmParams),validRequired("""ConfPties""",ConfPties),validList("""ConfPties""",ConfPties),validElement(ConfPties),validElement(Stiptns),validList("""UndrlygFinInstrm""",UndrlygFinInstrm),validElement(UndrlygFinInstrm),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validList("""Refs""",Refs),validElement(Refs),validElement(NbCnt),validElement(Id))|

---

## Value ISO20022.Setr027001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Setr027001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Setr027001.SettlementDate16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Setr027001.SettlementDateCode12Choice||XmlElement()||
|+|Dt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Enum ISO20022.Setr027001.SettlementDate5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|
||TBAT|Int32||XmlEnum("""TBAT""")|2|
||WHID|Int32||XmlEnum("""WHID""")|3|
||WDIS|Int32||XmlEnum("""WDIS""")|4|
||SELL|Int32||XmlEnum("""SELL""")|5|
||TFIV|Int32||XmlEnum("""TFIV""")|6|
||TFOR|Int32||XmlEnum("""TFOR""")|7|
||TTRE|Int32||XmlEnum("""TTRE""")|8|
||TTWO|Int32||XmlEnum("""TTWO""")|9|
||TONE|Int32||XmlEnum("""TONE""")|10|
||NXTD|Int32||XmlEnum("""NXTD""")|11|
||CASH|Int32||XmlEnum("""CASH""")|12|
||REGU|Int32||XmlEnum("""REGU""")|13|

---

## Value ISO20022.Setr027001.SettlementDateCode12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.SettlementDetails213


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgblForColl|String||XmlElement()||
|+|ModCxlAllwd|ISO20022.Setr027001.ModificationCancellationAllowed4Choice||XmlElement()||
|+|RtrLeg|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Setr027001.LetterOfGuarantee4Choice||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Setr027001.AutomaticBorrowing6Choice||XmlElement()||
|+|Trckg|ISO20022.Setr027001.Tracking4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|TaxCpcty|ISO20022.Setr027001.TaxCapacityParty4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Setr027001.SettlementSystemMethod4Choice||XmlElement()||
|+|SttlgCpcty|ISO20022.Setr027001.SettlingCapacity9Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Setr027001.SecuritiesRTGS4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Setr027001.Restriction5Choice||XmlElement()||
|+|RpTp|ISO20022.Setr027001.RepurchaseType22Choice||XmlElement()||
|+|Regn|ISO20022.Setr027001.Registration9Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Setr027001.NettingEligibility4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Setr027001.MarketClientSide6Choice||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Setr027001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Setr027001.FXStandingInstruction4Choice||XmlElement()||
|+|XpsrTp|ISO20022.Setr027001.ExposureType18Choice||XmlElement()||
|+|CshClrSys|ISO20022.Setr027001.CashSettlementSystem4Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Setr027001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|BlckTrad|ISO20022.Setr027001.BlockTrade4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Setr027001.BeneficialOwnership4Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Setr027001.SettlementTransactionCondition31Choice>||XmlElement()||
|+|SttlmInstrGnrtn|ISO20022.Setr027001.SettlementInstructionGeneration2Choice||XmlElement()||
|+|Prty|ISO20022.Setr027001.PriorityNumeric4Choice||XmlElement()||
|+|HldInd|String||XmlElement()||
|+|SttlmTxTp|ISO20022.Setr027001.SettlementTransactionType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModCxlAllwd),validElement(LttrOfGrnt),validElement(AutomtcBrrwg),validElement(Trckg),validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SttlgCpcty),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(RpTp),validElement(Regn),validElement(NetgElgblty),validElement(MktClntSd),validElement(CcyToBuyOrSell),validElement(FxStgInstr),validElement(XpsrTp),validElement(CshClrSys),validElement(CCPElgblty),validElement(BlckTrad),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SttlmInstrGnrtn),validElement(Prty),validElement(SttlmTxTp))|

---

## Enum ISO20022.Setr027001.SettlementInstructionGeneration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOGE|Int32||XmlEnum("""NOGE""")|1|
||GENS|Int32||XmlEnum("""GENS""")|2|

---

## Value ISO20022.Setr027001.SettlementInstructionGeneration2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.SettlementParties59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Setr027001.PartyIdentificationAndAccount155||XmlElement()||
|+|Pty4|ISO20022.Setr027001.PartyIdentificationAndAccount155||XmlElement()||
|+|Pty3|ISO20022.Setr027001.PartyIdentificationAndAccount155||XmlElement()||
|+|Pty2|ISO20022.Setr027001.PartyIdentificationAndAccount155||XmlElement()||
|+|Pty1|ISO20022.Setr027001.PartyIdentificationAndAccount155||XmlElement()||
|+|Dpstry|ISO20022.Setr027001.PartyIdentification118||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Setr027001.SettlementStandingInstructionDatabase1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||BRKR|Int32||XmlEnum("""BRKR""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|

---

## Value ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Setr027001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.SettlementTransactionCondition31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.SettlementTransactionCondition7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNEX|Int32||XmlEnum("""UNEX""")|1|
||SPST|Int32||XmlEnum("""SPST""")|2|
||SPDL|Int32||XmlEnum("""SPDL""")|3|
||SPCS|Int32||XmlEnum("""SPCS""")|4|
||CSDP|Int32||XmlEnum("""CSDP""")|5|
||PHYS|Int32||XmlEnum("""PHYS""")|6|
||KNOC|Int32||XmlEnum("""KNOC""")|7|
||FRCL|Int32||XmlEnum("""FRCL""")|8|
||EXER|Int32||XmlEnum("""EXER""")|9|
||DRAW|Int32||XmlEnum("""DRAW""")|10|
||DLWM|Int32||XmlEnum("""DLWM""")|11|
||DIRT|Int32||XmlEnum("""DIRT""")|12|
||CLEN|Int32||XmlEnum("""CLEN""")|13|
||ASGN|Int32||XmlEnum("""ASGN""")|14|

---

## Value ISO20022.Setr027001.SettlementTransactionType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.SettlementTransactionType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OFIT|Int32||XmlEnum("""OFIT""")|1|
||GUAR|Int32||XmlEnum("""GUAR""")|2|
||TURN|Int32||XmlEnum("""TURN""")|3|
||TRVO|Int32||XmlEnum("""TRVO""")|4|
||TRPO|Int32||XmlEnum("""TRPO""")|5|
||TRAD|Int32||XmlEnum("""TRAD""")|6|
||TBAC|Int32||XmlEnum("""TBAC""")|7|
||SYND|Int32||XmlEnum("""SYND""")|8|
||SECL|Int32||XmlEnum("""SECL""")|9|
||SECB|Int32||XmlEnum("""SECB""")|10|
||SBBK|Int32||XmlEnum("""SBBK""")|11|
||RVPO|Int32||XmlEnum("""RVPO""")|12|
||RPTO|Int32||XmlEnum("""RPTO""")|13|
||RODE|Int32||XmlEnum("""RODE""")|14|
||REPU|Int32||XmlEnum("""REPU""")|15|
||RELE|Int32||XmlEnum("""RELE""")|16|
||REDI|Int32||XmlEnum("""REDI""")|17|
||REAL|Int32||XmlEnum("""REAL""")|18|
||PORT|Int32||XmlEnum("""PORT""")|19|
||PLAC|Int32||XmlEnum("""PLAC""")|20|
||PAIR|Int32||XmlEnum("""PAIR""")|21|
||OWNI|Int32||XmlEnum("""OWNI""")|22|
||OWNE|Int32||XmlEnum("""OWNE""")|23|
||NSYN|Int32||XmlEnum("""NSYN""")|24|
||NETT|Int32||XmlEnum("""NETT""")|25|
||MKUP|Int32||XmlEnum("""MKUP""")|26|
||MKDW|Int32||XmlEnum("""MKDW""")|27|
||ISSU|Int32||XmlEnum("""ISSU""")|28|
||INSP|Int32||XmlEnum("""INSP""")|29|
||FCTA|Int32||XmlEnum("""FCTA""")|30|
||CONV|Int32||XmlEnum("""CONV""")|31|
||COLO|Int32||XmlEnum("""COLO""")|32|
||COLI|Int32||XmlEnum("""COLI""")|33|
||BSBK|Int32||XmlEnum("""BSBK""")|34|

---

## Enum ISO20022.Setr027001.SettlingCapacity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPRI|Int32||XmlEnum("""SPRI""")|1|
||SAGE|Int32||XmlEnum("""SAGE""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|

---

## Value ISO20022.Setr027001.SettlingCapacity9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.Side3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEX|Int32||XmlEnum("""OPEX""")|1|
||BORW|Int32||XmlEnum("""BORW""")|2|
||LEND|Int32||XmlEnum("""LEND""")|3|
||SSEX|Int32||XmlEnum("""SSEX""")|4|
||SESH|Int32||XmlEnum("""SESH""")|5|
||SEPL|Int32||XmlEnum("""SEPL""")|6|
||BUMI|Int32||XmlEnum("""BUMI""")|7|
||TWOS|Int32||XmlEnum("""TWOS""")|8|
||UNDI|Int32||XmlEnum("""UNDI""")|9|
||OPPO|Int32||XmlEnum("""OPPO""")|10|
||DEFI|Int32||XmlEnum("""DEFI""")|11|
||CSHE|Int32||XmlEnum("""CSHE""")|12|
||CRSH|Int32||XmlEnum("""CRSH""")|13|
||CROS|Int32||XmlEnum("""CROS""")|14|
||SELL|Int32||XmlEnum("""SELL""")|15|
||BUYI|Int32||XmlEnum("""BUYI""")|16|

---

## Value ISO20022.Setr027001.SimpleIdentificationInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.SpreadRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateOrAmt|ISO20022.Setr027001.AmountOrRate1Choice||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateOrAmt))|

---

## Value ISO20022.Setr027001.StandingSettlementInstruction13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRcvgSttlmPties|ISO20022.Setr027001.SettlementParties59||XmlElement()||
|+|OthrDlvrgSttlmPties|ISO20022.Setr027001.SettlementParties59||XmlElement()||
|+|Vndr|ISO20022.Setr027001.PartyIdentification117Choice||XmlElement()||
|+|SttlmStgInstrDB|ISO20022.Setr027001.SettlementStandingInstructionDatabase4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrRcvgSttlmPties),validElement(OthrDlvrgSttlmPties),validElement(Vndr),validElement(SttlmStgInstrDB))|

---

## Value ISO20022.Setr027001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Setr027001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Setr027001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Setr027001.Term1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Setr027001.RateOrAbsoluteValue1Choice||XmlElement()||
|+|Oprtr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Value ISO20022.Setr027001.TotalNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlOfLkdInstrs|String||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TtlOfLkdInstrs""",TtlOfLkdInstrs,"""[0-9]{3}"""),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Setr027001.Tracking4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Setr027001.TradeDate7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Setr027001.TradingDateCode2Choice||XmlElement()||
|+|Dt|ISO20022.Setr027001.DateAndDateTime1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Dt),validChoice(Val,Dt))|

---

## Value ISO20022.Setr027001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Setr027001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Setr027001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Setr027001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.TradeRegulatoryConditions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USOL|Int32||XmlEnum("""USOL""")|1|
||SOLI|Int32||XmlEnum("""SOLI""")|2|

---

## Enum ISO20022.Setr027001.TradeTransactionCondition2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GTDL|Int32||XmlEnum("""GTDL""")|1|
||SPEX|Int32||XmlEnum("""SPEX""")|2|
||SPCU|Int32||XmlEnum("""SPCU""")|3|
||SPPR|Int32||XmlEnum("""SPPR""")|4|
||CAST|Int32||XmlEnum("""CAST""")|5|
||SECR|Int32||XmlEnum("""SECR""")|6|
||SCCR|Int32||XmlEnum("""SCCR""")|7|
||SERT|Int32||XmlEnum("""SERT""")|8|
||SCRT|Int32||XmlEnum("""SCRT""")|9|
||SCBN|Int32||XmlEnum("""SCBN""")|10|
||SEBN|Int32||XmlEnum("""SEBN""")|11|
||SECN|Int32||XmlEnum("""SECN""")|12|
||SPCC|Int32||XmlEnum("""SPCC""")|13|

---

## Value ISO20022.Setr027001.TradeTransactionCondition9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.TradeType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FUTR|Int32||XmlEnum("""FUTR""")|1|
||FUOP|Int32||XmlEnum("""FUOP""")|2|
||OPTN|Int32||XmlEnum("""OPTN""")|3|
||FBBT|Int32||XmlEnum("""FBBT""")|4|
||BOSU|Int32||XmlEnum("""BOSU""")|5|
||OFIT|Int32||XmlEnum("""OFIT""")|6|
||BORE|Int32||XmlEnum("""BORE""")|7|
||LABO|Int32||XmlEnum("""LABO""")|8|
||BOEN|Int32||XmlEnum("""BOEN""")|9|
||BOST|Int32||XmlEnum("""BOST""")|10|
||ISSU|Int32||XmlEnum("""ISSU""")|11|
||EMTR|Int32||XmlEnum("""EMTR""")|12|
||GUAR|Int32||XmlEnum("""GUAR""")|13|
||AGEN|Int32||XmlEnum("""AGEN""")|14|
||VWAP|Int32||XmlEnum("""VWAP""")|15|
||RISK|Int32||XmlEnum("""RISK""")|16|
||BRBR|Int32||XmlEnum("""BRBR""")|17|
||TRAD|Int32||XmlEnum("""TRAD""")|18|
||PROG|Int32||XmlEnum("""PROG""")|19|
||PRAL|Int32||XmlEnum("""PRAL""")|20|
||LIST|Int32||XmlEnum("""LIST""")|21|
||IPOO|Int32||XmlEnum("""IPOO""")|22|
||INDX|Int32||XmlEnum("""INDX""")|23|
||BSKT|Int32||XmlEnum("""BSKT""")|24|

---

## Value ISO20022.Setr027001.TradeType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr027001.TradingCapacity4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAGT|Int32||XmlEnum("""TAGT""")|1|
||SINT|Int32||XmlEnum("""SINT""")|2|
||RMKT|Int32||XmlEnum("""RMKT""")|3|
||MLTF|Int32||XmlEnum("""MLTF""")|4|
||MKTM|Int32||XmlEnum("""MKTM""")|5|
||INFI|Int32||XmlEnum("""INFI""")|6|
||BAGN|Int32||XmlEnum("""BAGN""")|7|
||PRAG|Int32||XmlEnum("""PRAG""")|8|
||OAGN|Int32||XmlEnum("""OAGN""")|9|
||CAGN|Int32||XmlEnum("""CAGN""")|10|
||AGEN|Int32||XmlEnum("""AGEN""")|11|
||PROP|Int32||XmlEnum("""PROP""")|12|
||RISP|Int32||XmlEnum("""RISP""")|13|
||CPRN|Int32||XmlEnum("""CPRN""")|14|
||PRIN|Int32||XmlEnum("""PRIN""")|15|

---

## Enum ISO20022.Setr027001.TradingCapacity6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||PRAG|Int32||XmlEnum("""PRAG""")|2|
||OAGN|Int32||XmlEnum("""OAGN""")|3|
||CPRN|Int32||XmlEnum("""CPRN""")|4|
||CAGN|Int32||XmlEnum("""CAGN""")|5|
||BAGN|Int32||XmlEnum("""BAGN""")|6|
||AGEN|Int32||XmlEnum("""AGEN""")|7|

---

## Enum ISO20022.Setr027001.TradingDate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Value ISO20022.Setr027001.TradingDateCode2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.TradingPartyCapacity3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.TradingPartyCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.TransactiontIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr027001.TwoLegTransactionDetails5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TwoLegTxTp|ISO20022.Setr027001.TwoLegTransactionType4Choice||XmlElement()||
|+|PrcgDt|ISO20022.Setr027001.TradeDate7Choice||XmlElement()||
|+|ClsgSttlmAmt|ISO20022.Setr027001.AmountAndDirection5||XmlElement()||
|+|ClsgDt|ISO20022.Setr027001.ClosingDate4Choice||XmlElement()||
|+|EndPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|ScndLegNrrtv|String||XmlElement()||
|+|OthrAmts|global::System.Collections.Generic.List<ISO20022.Setr027001.OtherAmounts16>||XmlElement()||
|+|GrssTradAmt|ISO20022.Setr027001.AmountAndDirection29||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|OpngLegId|String||XmlElement()||
|+|TradDt|ISO20022.Setr027001.TradeDate8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TwoLegTxTp),validElement(PrcgDt),validElement(ClsgSttlmAmt),validElement(ClsgDt),validElement(EndPric),validList("""OthrAmts""",OthrAmts),validElement(OthrAmts),validElement(GrssTradAmt),validElement(TradDt))|

---

## Value ISO20022.Setr027001.TwoLegTransactionType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgDtls|ISO20022.Setr027001.SecuritiesFinancing12||XmlElement()||
|+|FutrOrOptnDtls|ISO20022.Setr027001.FutureOrOptionDetails3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgDtls),validElement(FutrOrOptnDtls),validChoice(SctiesFincgDtls,FutrOrOptnDtls))|

---

## Enum ISO20022.Setr027001.TypeOfIdentification1Code


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

## Enum ISO20022.Setr027001.TypeOfIdentification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||CORP|Int32||XmlEnum("""CORP""")|3|
||CHTY|Int32||XmlEnum("""CHTY""")|4|
||ARNU|Int32||XmlEnum("""ARNU""")|5|

---

## Enum ISO20022.Setr027001.TypeOfPrice3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDAV|Int32||XmlEnum("""RDAV""")|1|
||PARV|Int32||XmlEnum("""PARV""")|2|
||NET1|Int32||XmlEnum("""NET1""")|3|
||NET2|Int32||XmlEnum("""NET2""")|4|
||GREX|Int32||XmlEnum("""GREX""")|5|
||AVOV|Int32||XmlEnum("""AVOV""")|6|
||AVER|Int32||XmlEnum("""AVER""")|7|

---

## Value ISO20022.Setr027001.TypeOfPrice47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr027001.UnderlyingFinancialInstrument7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Attrbts|ISO20022.Setr027001.FinancialInstrumentAttributes124||XmlElement()||
|+|Id|ISO20022.Setr027001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Attrbts),validElement(Id))|

---

## Value ISO20022.Setr027001.UnderlyingRatio2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdFinInstrmId|global::System.Collections.Generic.List<ISO20022.Setr027001.SecurityIdentification19>||XmlElement()||
|+|UndrlygQtyNmrtr|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|UndrlygQtyDnmtr|ISO20022.Setr027001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RltdFinInstrmId""",RltdFinInstrmId),validElement(RltdFinInstrmId),validElement(UndrlygQtyNmrtr),validElement(UndrlygQtyDnmtr))|

---

## Enum ISO20022.Setr027001.UnitOfMeasure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACRE|Int32||XmlEnum("""ACRE""")|1|
||SQIN|Int32||XmlEnum("""SQIN""")|2|
||SQFO|Int32||XmlEnum("""SQFO""")|3|
||SQYA|Int32||XmlEnum("""SQYA""")|4|
||SQMI|Int32||XmlEnum("""SQMI""")|5|
||SMIL|Int32||XmlEnum("""SMIL""")|6|
||SCMT|Int32||XmlEnum("""SCMT""")|7|
||SMET|Int32||XmlEnum("""SMET""")|8|
||ARES|Int32||XmlEnum("""ARES""")|9|
||HECT|Int32||XmlEnum("""HECT""")|10|
||SQKI|Int32||XmlEnum("""SQKI""")|11|
||YARD|Int32||XmlEnum("""YARD""")|12|
||KMET|Int32||XmlEnum("""KMET""")|13|
||MILE|Int32||XmlEnum("""MILE""")|14|
||USPI|Int32||XmlEnum("""USPI""")|15|
||GBPI|Int32||XmlEnum("""GBPI""")|16|
||USQA|Int32||XmlEnum("""USQA""")|17|
||GBQA|Int32||XmlEnum("""GBQA""")|18|
||USOU|Int32||XmlEnum("""USOU""")|19|
||GBOU|Int32||XmlEnum("""GBOU""")|20|
||MILI|Int32||XmlEnum("""MILI""")|21|
||CELI|Int32||XmlEnum("""CELI""")|22|
||LITR|Int32||XmlEnum("""LITR""")|23|
||MMET|Int32||XmlEnum("""MMET""")|24|
||CMET|Int32||XmlEnum("""CMET""")|25|
||METR|Int32||XmlEnum("""METR""")|26|
||PUND|Int32||XmlEnum("""PUND""")|27|
||KILO|Int32||XmlEnum("""KILO""")|28|
||INCH|Int32||XmlEnum("""INCH""")|29|
||GRAM|Int32||XmlEnum("""GRAM""")|30|
||USGA|Int32||XmlEnum("""USGA""")|31|
||GBGA|Int32||XmlEnum("""GBGA""")|32|
||FOOT|Int32||XmlEnum("""FOOT""")|33|
||TONS|Int32||XmlEnum("""TONS""")|34|
||PIEC|Int32||XmlEnum("""PIEC""")|35|

---

## Value ISO20022.Setr027001.YieldCalculation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClctnDt|DateTime||XmlElement()||
|+|ValPrd|ISO20022.Setr027001.DateTimePeriod1Choice||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|RedPric|ISO20022.Setr027001.Price14||XmlElement()||
|+|ClctnTp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValPrd),validElement(RedPric))|

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

