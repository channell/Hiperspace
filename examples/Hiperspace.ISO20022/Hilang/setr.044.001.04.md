# setr.044.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Setr044001.AccountIdentification55Choice {
        + PrtryAcct  : ISO20022.Setr044001.SimpleIdentificationInformation2
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Setr044001.AccountIdentification55Choice *-- ISO20022.Setr044001.SimpleIdentificationInformation2
    class ISO20022.Setr044001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr044001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr044001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Setr044001.AffirmationReason2 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.UnaffirmedReason3Choice
    }
    ISO20022.Setr044001.AffirmationReason2 *-- ISO20022.Setr044001.UnaffirmedReason3Choice
    class ISO20022.Setr044001.AffirmationReason2Choice {
        + NoSpcfdRsn  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.AffirmationReason2~
    }
    ISO20022.Setr044001.AffirmationReason2Choice *-- ISO20022.Setr044001.AffirmationReason2
    class ISO20022.Setr044001.AffirmationStatus11Choice {
        + PrtrySts  : ISO20022.Setr044001.ProprietaryStatusAndReason6
        + Uaffrmd  : ISO20022.Setr044001.AffirmationReason2Choice
        + Affrmd  : ISO20022.Setr044001.ProprietaryReason4
    }
    ISO20022.Setr044001.AffirmationStatus11Choice *-- ISO20022.Setr044001.ProprietaryStatusAndReason6
    ISO20022.Setr044001.AffirmationStatus11Choice *-- ISO20022.Setr044001.AffirmationReason2Choice
    ISO20022.Setr044001.AffirmationStatus11Choice *-- ISO20022.Setr044001.ProprietaryReason4
    class ISO20022.Setr044001.AllegementMatchingReason2 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.AllegementReason2Choice
    }
    ISO20022.Setr044001.AllegementMatchingReason2 *-- ISO20022.Setr044001.AllegementReason2Choice
    class ISO20022.Setr044001.AllegementReason1Code {
        ALG1 = 1
    }
    class ISO20022.Setr044001.AllegementReason2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.AllegementReason2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.AlternatePartyIdentification8 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Setr044001.IdentificationType43Choice
    }
    ISO20022.Setr044001.AlternatePartyIdentification8 *-- ISO20022.Setr044001.IdentificationType43Choice
    class ISO20022.Setr044001.AmountAndDirection29 {
        + FXDtls  : ISO20022.Setr044001.ForeignExchangeTerms18
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Setr044001.AmountAndDirection29 *-- ISO20022.Setr044001.ForeignExchangeTerms18
    ISO20022.Setr044001.AmountAndDirection29 *-- ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr044001.AmountAndDirection29 *-- ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr044001.AmountOrRate2Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Setr044001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr044001.AmountOrRate2Choice *-- ISO20022.Setr044001.ActiveCurrencyAndAmount
    class ISO20022.Setr044001.AwaitingAffirmationReason1Code {
        WAFF = 1
    }
    class ISO20022.Setr044001.AwaitingAffirmationReason2 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.AwaitingAffirmationReason2Choice
    }
    ISO20022.Setr044001.AwaitingAffirmationReason2 *-- ISO20022.Setr044001.AwaitingAffirmationReason2Choice
    class ISO20022.Setr044001.AwaitingAffirmationReason2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.AwaitingAffirmationReason2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.AwaitingCancellationReason1Code {
        WCAN = 1
    }
    class ISO20022.Setr044001.AwaitingCancellationReason2 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.AwaitingCancellationReason2Choice
    }
    ISO20022.Setr044001.AwaitingCancellationReason2 *-- ISO20022.Setr044001.AwaitingCancellationReason2Choice
    class ISO20022.Setr044001.AwaitingCancellationReason2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.AwaitingCancellationReason2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.BusinessProcessType1Code {
        DPLX = 1
        IDEL = 2
        THRU = 3
        PROP = 4
        RSAL = 5
        PRAC = 6
        NISP = 7
        ISUP = 8
    }
    class ISO20022.Setr044001.BusinessProcessType2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.BusinessProcessType2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.CalculationType1Code {
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
    class ISO20022.Setr044001.CallIn1Code {
        CFCC = 1
        CFST = 2
        CFAV = 3
    }
    class ISO20022.Setr044001.CancellationProcessingStatus10Choice {
        + PrtrySts  : ISO20022.Setr044001.ProprietaryStatusAndReason6
        + CxlCmpltd  : ISO20022.Setr044001.ProprietaryReason4
        + CxlReqd  : ISO20022.Setr044001.ProprietaryReason4
        + CxlPdg  : ISO20022.Setr044001.CancellationReason39Choice
    }
    ISO20022.Setr044001.CancellationProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryStatusAndReason6
    ISO20022.Setr044001.CancellationProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.CancellationProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.CancellationProcessingStatus10Choice *-- ISO20022.Setr044001.CancellationReason39Choice
    class ISO20022.Setr044001.CancellationReason39Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.AwaitingCancellationReason2~
        + NoSpcfdRsn  : String
    }
    ISO20022.Setr044001.CancellationReason39Choice *-- ISO20022.Setr044001.AwaitingCancellationReason2
    class ISO20022.Setr044001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Setr044001.CashMarginOrder1Code {
        MRGC = 1
        MRGO = 2
        CASH = 3
    }
    class ISO20022.Setr044001.ChargeTaxBasis1Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Setr044001.ChargeTaxBasisType2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.ChargeTaxBasisType2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.Commission25 {
        + VATRate  : Decimal
        + TtlVATAmt  : ISO20022.Setr044001.ActiveCurrencyAndAmount
        + TtlComssn  : ISO20022.Setr044001.AmountAndDirection29
        + ClctnDt  : DateTime
        + RcptId  : ISO20022.Setr044001.PartyIdentification267
        + Comssn  : ISO20022.Setr044001.AmountOrRate2Choice
        + Tp  : ISO20022.Setr044001.CommissionType6Choice
    }
    ISO20022.Setr044001.Commission25 *-- ISO20022.Setr044001.ActiveCurrencyAndAmount
    ISO20022.Setr044001.Commission25 *-- ISO20022.Setr044001.AmountAndDirection29
    ISO20022.Setr044001.Commission25 *-- ISO20022.Setr044001.PartyIdentification267
    ISO20022.Setr044001.Commission25 *-- ISO20022.Setr044001.AmountOrRate2Choice
    ISO20022.Setr044001.Commission25 *-- ISO20022.Setr044001.CommissionType6Choice
    class ISO20022.Setr044001.CommissionType6Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.CommissionType6Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.CommissionType9Code {
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
    class ISO20022.Setr044001.ConfirmationParties9 {
        + TradBnfcryPty  : ISO20022.Setr044001.ConfirmationPartyDetails14
        + AffrmgPty  : ISO20022.Setr044001.ConfirmationPartyDetails14
        + ExctgBrkr  : ISO20022.Setr044001.ConfirmationPartyDetails16
        + ClrFirm  : ISO20022.Setr044001.ConfirmationPartyDetails16
        + StepOutFirm  : ISO20022.Setr044001.ConfirmationPartyDetails11
        + StepInFirm  : ISO20022.Setr044001.ConfirmationPartyDetails11
        + IntrdcgFirm  : ISO20022.Setr044001.ConfirmationPartyDetails14
        + BrkrOfCdt  : ISO20022.Setr044001.ConfirmationPartyDetails14
        + Lndr  : ISO20022.Setr044001.ConfirmationPartyDetails12
        + Sellr  : ISO20022.Setr044001.ConfirmationPartyDetails12
        + Brrwr  : ISO20022.Setr044001.ConfirmationPartyDetails12
        + Buyr  : ISO20022.Setr044001.ConfirmationPartyDetails12
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Setr044001.PartyIdentificationAndAccount220~
    }
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails14
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails14
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails16
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails16
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails11
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails11
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails14
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails14
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails12
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails12
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails12
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.ConfirmationPartyDetails12
    ISO20022.Setr044001.ConfirmationParties9 *-- ISO20022.Setr044001.PartyIdentificationAndAccount220
    class ISO20022.Setr044001.ConfirmationPartyDetails11 {
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.ConfirmationPartyDetails11 *-- ISO20022.Setr044001.PartyTextInformation5
    ISO20022.Setr044001.ConfirmationPartyDetails11 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.ConfirmationPartyDetails11 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.ConfirmationPartyDetails12 {
        + TradgPtyCpcty  : ISO20022.Setr044001.TradingPartyCapacity4Choice
        + InvstrCpcty  : ISO20022.Setr044001.InvestorCapacity4Choice
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.ConfirmationPartyDetails12 *-- ISO20022.Setr044001.TradingPartyCapacity4Choice
    ISO20022.Setr044001.ConfirmationPartyDetails12 *-- ISO20022.Setr044001.InvestorCapacity4Choice
    ISO20022.Setr044001.ConfirmationPartyDetails12 *-- ISO20022.Setr044001.PartyTextInformation5
    ISO20022.Setr044001.ConfirmationPartyDetails12 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.ConfirmationPartyDetails12 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.ConfirmationPartyDetails14 {
        + PtyCpcty  : ISO20022.Setr044001.TradingPartyCapacity3Choice
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + CshDtls  : ISO20022.Setr044001.AccountIdentification55Choice
        + SfkpgAcct  : ISO20022.Setr044001.SecuritiesAccount35
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.TradingPartyCapacity3Choice
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.PartyTextInformation5
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.AccountIdentification55Choice
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.SecuritiesAccount35
    ISO20022.Setr044001.ConfirmationPartyDetails14 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.ConfirmationPartyDetails16 {
        + InvstrPrtcnAssoctnMmbsh  : String
        + PtyCpcty  : ISO20022.Setr044001.TradingPartyCapacity3Choice
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation5
        + PrcgId  : String
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + CshDtls  : ISO20022.Setr044001.AccountIdentification55Choice
        + SfkpgAcct  : ISO20022.Setr044001.SecuritiesAccount35
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.TradingPartyCapacity3Choice
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.PartyTextInformation5
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.AccountIdentification55Choice
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.SecuritiesAccount35
    ISO20022.Setr044001.ConfirmationPartyDetails16 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Setr044001.CurrencyToBuyOrSell1Choice {
        + CcyToSell  : String
        + CcyToBuy  : String
    }
    class ISO20022.Setr044001.DateAndDateTime1Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr044001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Setr044001.DateTimePeriod1Choice {
        + DtTmRg  : ISO20022.Setr044001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Setr044001.DateTimePeriod1Choice *-- ISO20022.Setr044001.DateTimePeriod1
    class ISO20022.Setr044001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Setr044001.DocumentNumber17Choice {
        + PrtryNb  : ISO20022.Setr044001.GenericIdentification30
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Setr044001.DocumentNumber17Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Setr044001.EUCapitalGainType3Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + EUCptlGn  : String
    }
    ISO20022.Setr044001.EUCapitalGainType3Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Setr044001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Setr044001.ForeignExchangeTerms18 {
        + ConvtdAmt  : ISO20022.Setr044001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Setr044001.ForeignExchangeTerms18 *-- ISO20022.Setr044001.ActiveCurrencyAndAmount
    class ISO20022.Setr044001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr044001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr044001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr044001.IdentificationReference16Choice {
        + UnqTxIdr  : String
        + CollTxId  : String
        + CxlReqId  : String
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
    class ISO20022.Setr044001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Setr044001.IdentificationType43Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Setr044001.IdentificationType43Choice *-- ISO20022.Setr044001.GenericIdentification36
    class ISO20022.Setr044001.InstructionProcessingReason3Choice {
        + NoSpcfdRsn  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.RejectionReason67~
    }
    ISO20022.Setr044001.InstructionProcessingReason3Choice *-- ISO20022.Setr044001.RejectionReason67
    class ISO20022.Setr044001.InstructionProcessingReason4Choice {
        + NoSpcfdRsn  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.RepairReason14~
    }
    ISO20022.Setr044001.InstructionProcessingReason4Choice *-- ISO20022.Setr044001.RepairReason14
    class ISO20022.Setr044001.InterestType2Code {
        XINT = 1
        CINT = 2
    }
    class ISO20022.Setr044001.InvestorCapacity4Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.InvestorCapacity4Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.Linkages77 {
        + Ref  : ISO20022.Setr044001.IdentificationReference16Choice
        + MsgNb  : ISO20022.Setr044001.DocumentNumber17Choice
    }
    ISO20022.Setr044001.Linkages77 *-- ISO20022.Setr044001.IdentificationReference16Choice
    ISO20022.Setr044001.Linkages77 *-- ISO20022.Setr044001.DocumentNumber17Choice
    class ISO20022.Setr044001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Setr044001.MarketIdentification93 {
        + Tp  : ISO20022.Setr044001.MarketType18Choice
        + Id  : ISO20022.Setr044001.MarketIdentification3Choice
    }
    ISO20022.Setr044001.MarketIdentification93 *-- ISO20022.Setr044001.MarketType18Choice
    ISO20022.Setr044001.MarketIdentification93 *-- ISO20022.Setr044001.MarketIdentification3Choice
    class ISO20022.Setr044001.MarketIdentification97 {
        + Tp  : ISO20022.Setr044001.MarketType8Choice
        + Id  : ISO20022.Setr044001.MarketIdentification3Choice
    }
    ISO20022.Setr044001.MarketIdentification97 *-- ISO20022.Setr044001.MarketType8Choice
    ISO20022.Setr044001.MarketIdentification97 *-- ISO20022.Setr044001.MarketIdentification3Choice
    class ISO20022.Setr044001.MarketType18Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.MarketType18Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Setr044001.MarketType6Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
    }
    class ISO20022.Setr044001.MarketType8Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.MarketType8Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.MatchingReason5Choice {
        + NoSpcfdRsn  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.AllegementMatchingReason2~
    }
    ISO20022.Setr044001.MatchingReason5Choice *-- ISO20022.Setr044001.AllegementMatchingReason2
    class ISO20022.Setr044001.MatchingReason6Choice {
        + NoSpcfdRsn  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.UnmatchedReason23~
    }
    ISO20022.Setr044001.MatchingReason6Choice *-- ISO20022.Setr044001.UnmatchedReason23
    class ISO20022.Setr044001.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Setr044001.MatchingStatus27Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.MatchingStatus27Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.MatchingStatus35Choice {
        + PrtrySts  : ISO20022.Setr044001.ProprietaryStatusAndReason6
        + Umtchd  : ISO20022.Setr044001.MatchingReason6Choice
        + MtchgAllgd  : ISO20022.Setr044001.MatchingReason5Choice
        + MtchdWthTlrnce  : ISO20022.Setr044001.ProprietaryReason4
        + Mtchd  : ISO20022.Setr044001.ProprietaryReason4
    }
    ISO20022.Setr044001.MatchingStatus35Choice *-- ISO20022.Setr044001.ProprietaryStatusAndReason6
    ISO20022.Setr044001.MatchingStatus35Choice *-- ISO20022.Setr044001.MatchingReason6Choice
    ISO20022.Setr044001.MatchingStatus35Choice *-- ISO20022.Setr044001.MatchingReason5Choice
    ISO20022.Setr044001.MatchingStatus35Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.MatchingStatus35Choice *-- ISO20022.Setr044001.ProprietaryReason4
    class ISO20022.Setr044001.NameAndAddress13 {
        + Adr  : ISO20022.Setr044001.PostalAddress8
        + Nm  : String
    }
    ISO20022.Setr044001.NameAndAddress13 *-- ISO20022.Setr044001.PostalAddress8
    class ISO20022.Setr044001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Setr044001.Order23 {
        + AcrdIntrstAmt  : ISO20022.Setr044001.AmountAndDirection29
        + AddtlTradInstrPrcgInf  : String
        + AddtlPhysOrRegnDtls  : ISO20022.Setr044001.RegistrationParameters3
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Setr044001.Reporting6Choice~
        + YldTp  : ISO20022.Setr044001.YieldCalculation7
        + CallInTp  : String
        + MtchSts  : ISO20022.Setr044001.MatchingStatus27Choice
        + CptlGnTp  : ISO20022.Setr044001.EUCapitalGainType3Choice
        + ChrgTaxBsisTp  : ISO20022.Setr044001.ChargeTaxBasisType2Choice
        + DerivCvrd  : String
        + PosFct  : String
        + OrdrOrgtrElgblty  : String
        + CcyToBuyOrSell  : ISO20022.Setr044001.CurrencyToBuyOrSell1Choice
        + TradRgltryCondsTp  : String
        + AcrdIntrstPctg  : Decimal
        + IntrstTp  : String
        + GvUpNbOfDays  : Decimal
        + NbOfDaysAcrd  : Decimal
        + Comssn  : ISO20022.Setr044001.Commission25
        + CshMrgn  : String
        + TpOfPric  : ISO20022.Setr044001.TypeOfPrice47Choice
        + DealPric  : ISO20022.Setr044001.Price14
        + GrssTradAmt  : ISO20022.Setr044001.AmountAndDirection29
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Setr044001.QuantityBreakdown76~
        + ConfQty  : ISO20022.Setr044001.Quantity6Choice
        + PrtlFillDtls  : global::System.Collections.Generic.List~ISO20022.Setr044001.PartialFill4~
        + NAVDt  : ISO20022.Setr044001.DateAndDateTime1Choice
        + SttlmDt  : ISO20022.Setr044001.SettlementDate16Choice
        + PrcgDt  : ISO20022.Setr044001.TradeDate7Choice
        + TradDt  : ISO20022.Setr044001.TradeDate7Choice
        + TradOrgtnDt  : DateTime
        + OrdrBookgDt  : DateTime
        + PlcOfTrad  : ISO20022.Setr044001.MarketIdentification93
        + PreAdvc  : String
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Setr044001.TradeTransactionCondition9Choice~
        + TradTxTp  : ISO20022.Setr044001.TradeType4Choice
        + Pmt  : String
        + Sd  : String
        + FinInstrmId  : ISO20022.Setr044001.SecurityIdentification19
        + ListId  : global::System.Collections.Generic.List~String~
        + ScndryClntOrdrId  : global::System.Collections.Generic.List~String~
        + ClntOrdrId  : global::System.Collections.Generic.List~String~
        + OrdrId  : global::System.Collections.Generic.List~String~
        + BizPrcTp  : ISO20022.Setr044001.BusinessProcessType2Choice
    }
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.AmountAndDirection29
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.RegistrationParameters3
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.Reporting6Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.YieldCalculation7
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.MatchingStatus27Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.EUCapitalGainType3Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.ChargeTaxBasisType2Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.CurrencyToBuyOrSell1Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.Commission25
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.TypeOfPrice47Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.Price14
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.AmountAndDirection29
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.QuantityBreakdown76
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.Quantity6Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.PartialFill4
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.DateAndDateTime1Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.SettlementDate16Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.TradeDate7Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.TradeDate7Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.MarketIdentification93
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.TradeTransactionCondition9Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.TradeType4Choice
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.SecurityIdentification19
    ISO20022.Setr044001.Order23 *-- ISO20022.Setr044001.BusinessProcessType2Choice
    class ISO20022.Setr044001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Setr044001.OtherIdentification1 {
        + Tp  : ISO20022.Setr044001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Setr044001.OtherIdentification1 *-- ISO20022.Setr044001.IdentificationSource3Choice
    class ISO20022.Setr044001.PartialFill4 {
        + MtchIncrmtQty  : ISO20022.Setr044001.QuantityOrAmount2Choice
        + RmngQty  : ISO20022.Setr044001.QuantityOrAmount2Choice
        + PrevslyExctdQty  : ISO20022.Setr044001.QuantityOrAmount2Choice
        + OrgnlOrdrdQty  : ISO20022.Setr044001.QuantityOrAmount2Choice
        + PlcOfTrad  : ISO20022.Setr044001.MarketIdentification97
        + TradDt  : ISO20022.Setr044001.TradeDate7Choice
        + DealPric  : ISO20022.Setr044001.Price14
        + ConfQty  : ISO20022.Setr044001.Quantity6Choice
    }
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.QuantityOrAmount2Choice
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.QuantityOrAmount2Choice
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.QuantityOrAmount2Choice
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.QuantityOrAmount2Choice
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.MarketIdentification97
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.TradeDate7Choice
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.Price14
    ISO20022.Setr044001.PartialFill4 *-- ISO20022.Setr044001.Quantity6Choice
    class ISO20022.Setr044001.PartyIdentification240Choice {
        + NmAndAdr  : ISO20022.Setr044001.NameAndAddress13
        + PrtryId  : ISO20022.Setr044001.GenericIdentification36
        + BIC  : String
    }
    ISO20022.Setr044001.PartyIdentification240Choice *-- ISO20022.Setr044001.NameAndAddress13
    ISO20022.Setr044001.PartyIdentification240Choice *-- ISO20022.Setr044001.GenericIdentification36
    class ISO20022.Setr044001.PartyIdentification244Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Setr044001.NameAndAddress13
        + BIC  : String
    }
    ISO20022.Setr044001.PartyIdentification244Choice *-- ISO20022.Setr044001.NameAndAddress13
    class ISO20022.Setr044001.PartyIdentification267 {
        + NmAndAdr  : ISO20022.Setr044001.NameAndAddress13
        + PrtryId  : ISO20022.Setr044001.GenericIdentification36
        + BIC  : String
    }
    ISO20022.Setr044001.PartyIdentification267 *-- ISO20022.Setr044001.NameAndAddress13
    ISO20022.Setr044001.PartyIdentification267 *-- ISO20022.Setr044001.GenericIdentification36
    class ISO20022.Setr044001.PartyIdentification268 {
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation1
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + Id  : ISO20022.Setr044001.PartyIdentification244Choice
    }
    ISO20022.Setr044001.PartyIdentification268 *-- ISO20022.Setr044001.PartyTextInformation1
    ISO20022.Setr044001.PartyIdentification268 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.PartyIdentification268 *-- ISO20022.Setr044001.PartyIdentification244Choice
    class ISO20022.Setr044001.PartyIdentificationAndAccount218 {
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + AddtlInf  : String
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.PartyIdentificationAndAccount218 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.PartyIdentificationAndAccount218 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.PartyIdentificationAndAccount220 {
        + AltrnId  : ISO20022.Setr044001.AlternatePartyIdentification8
        + AddtlInf  : ISO20022.Setr044001.PartyTextInformation1
        + CtryOfRes  : String
        + PrcgId  : String
        + CshAcct  : ISO20022.Setr044001.CashAccountIdentification5Choice
        + SfkpgAcct  : String
        + Id  : ISO20022.Setr044001.PartyIdentification240Choice
    }
    ISO20022.Setr044001.PartyIdentificationAndAccount220 *-- ISO20022.Setr044001.AlternatePartyIdentification8
    ISO20022.Setr044001.PartyIdentificationAndAccount220 *-- ISO20022.Setr044001.PartyTextInformation1
    ISO20022.Setr044001.PartyIdentificationAndAccount220 *-- ISO20022.Setr044001.CashAccountIdentification5Choice
    ISO20022.Setr044001.PartyIdentificationAndAccount220 *-- ISO20022.Setr044001.PartyIdentification240Choice
    class ISO20022.Setr044001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Setr044001.PartyTextInformation5 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Setr044001.PendingProcessing2Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.AwaitingAffirmationReason2~
        + NoSpcfdRsn  : String
    }
    ISO20022.Setr044001.PendingProcessing2Choice *-- ISO20022.Setr044001.AwaitingAffirmationReason2
    class ISO20022.Setr044001.PositionEffect2Code {
        CLOA = 1
        FIFO = 2
        ROLL = 3
        CLOS = 4
        OPEN = 5
    }
    class ISO20022.Setr044001.PostalAddress8 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr044001.Price14 {
        + Tp  : String
        + Val  : ISO20022.Setr044001.PriceRateOrAmount3Choice
    }
    ISO20022.Setr044001.Price14 *-- ISO20022.Setr044001.PriceRateOrAmount3Choice
    class ISO20022.Setr044001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Setr044001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Setr044001.PriceRateOrAmount3Choice *-- ISO20022.Setr044001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Setr044001.PriceValueType7Code {
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
    class ISO20022.Setr044001.ProcessingStatus98Choice {
        + PrtrySts  : ISO20022.Setr044001.ProprietaryStatusAndReason6
        + Trtd  : ISO20022.Setr044001.ProprietaryReason4
        + TradgSspdByStockXchg  : ISO20022.Setr044001.ProprietaryReason4
        + StgInstr  : ISO20022.Setr044001.ProprietaryReason4
        + SttlmInstrSnt  : ISO20022.Setr044001.ProprietaryReason4
        + Rjctd  : ISO20022.Setr044001.InstructionProcessingReason3Choice
        + RcvdAtIntrmy  : ISO20022.Setr044001.ProprietaryReason4
        + PdgPrcg  : ISO20022.Setr044001.PendingProcessing2Choice
        + OpnOrdr  : ISO20022.Setr044001.ProprietaryReason4
        + NoInstr  : ISO20022.Setr044001.ProprietaryReason4
        + InRpr  : ISO20022.Setr044001.InstructionProcessingReason4Choice
        + Gnrtd  : ISO20022.Setr044001.ProprietaryReason4
        + Futr  : ISO20022.Setr044001.ProprietaryReason4
        + FullyExctdConfSnt  : ISO20022.Setr044001.ProprietaryReason4
        + ForcdRjctn  : ISO20022.Setr044001.ProprietaryReason4
        + Done  : ISO20022.Setr044001.ProprietaryReason4
        + DfltActn  : ISO20022.Setr044001.ProprietaryReason4
        + AlrdyMtchdAndAffrmd  : ISO20022.Setr044001.ProprietaryReason4
        + AckdAccptd  : ISO20022.Setr044001.ProprietaryReason4
    }
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryStatusAndReason6
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.InstructionProcessingReason3Choice
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.PendingProcessing2Choice
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.InstructionProcessingReason4Choice
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProcessingStatus98Choice *-- ISO20022.Setr044001.ProprietaryReason4
    class ISO20022.Setr044001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Setr044001.GenericIdentification30
    }
    ISO20022.Setr044001.ProprietaryReason4 *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Setr044001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Setr044001.GenericIdentification30
    }
    ISO20022.Setr044001.ProprietaryStatusAndReason6 *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ProprietaryStatusAndReason6 *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.PurposeCode9Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.PurposeCode9Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.Quantity6Choice {
        + OrgnlAndCurFace  : ISO20022.Setr044001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Setr044001.Quantity6Choice *-- ISO20022.Setr044001.OriginalAndCurrentQuantities1
    ISO20022.Setr044001.Quantity6Choice *-- ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
    class ISO20022.Setr044001.QuantityBreakdown76 {
        + LotPric  : ISO20022.Setr044001.Price14
        + LotDtTm  : ISO20022.Setr044001.DateAndDateTime1Choice
        + LotQty  : ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
        + LotNb  : ISO20022.Setr044001.GenericIdentification37
    }
    ISO20022.Setr044001.QuantityBreakdown76 *-- ISO20022.Setr044001.Price14
    ISO20022.Setr044001.QuantityBreakdown76 *-- ISO20022.Setr044001.DateAndDateTime1Choice
    ISO20022.Setr044001.QuantityBreakdown76 *-- ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
    ISO20022.Setr044001.QuantityBreakdown76 *-- ISO20022.Setr044001.GenericIdentification37
    class ISO20022.Setr044001.QuantityOrAmount2Choice {
        + Amt  : ISO20022.Setr044001.ActiveCurrencyAndAmount
        + Qty  : ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
    }
    ISO20022.Setr044001.QuantityOrAmount2Choice *-- ISO20022.Setr044001.ActiveCurrencyAndAmount
    ISO20022.Setr044001.QuantityOrAmount2Choice *-- ISO20022.Setr044001.FinancialInstrumentQuantity1Choice
    class ISO20022.Setr044001.RegistrationParameters3 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Setr044001.SecuritiesCertificate3~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Setr044001.DateAndDateTime1Choice
        + CertfctnId  : String
    }
    ISO20022.Setr044001.RegistrationParameters3 *-- ISO20022.Setr044001.SecuritiesCertificate3
    ISO20022.Setr044001.RegistrationParameters3 *-- ISO20022.Setr044001.DateAndDateTime1Choice
    class ISO20022.Setr044001.RejectionReason52Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.RejectionReason52Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.RejectionReason67 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.RejectionReason52Choice
    }
    ISO20022.Setr044001.RejectionReason67 *-- ISO20022.Setr044001.RejectionReason52Choice
    class ISO20022.Setr044001.RejectionReason78Code {
        ICAG = 1
        ICUS = 2
        DEPT = 3
        OTHR = 4
        INDT = 5
        FAIL = 6
        DFLT = 7
        GAMN = 8
        ACRU = 9
        XRAT = 10
        RESU = 11
        DISE = 12
        DISC = 13
        CPTY = 14
        CADI = 15
        SIDE = 16
        EQTY = 17
        PRIC = 18
        INPR = 19
        EXLI = 20
        UKWN = 21
        OPTY = 22
        OPNM = 23
        INIR = 24
        VASU = 25
        ULNK = 26
        TXST = 27
        TQNP = 28
        TQHI = 29
        TNIU = 30
        TNAR = 31
        TERM = 32
        SETS = 33
        SETR = 34
        SAFE = 35
        RSPR = 36
        RERT = 37
        REPP = 38
        REPO = 39
        CTRA = 40
        REFE = 41
        QUNP = 42
        PLCE = 43
        ODNP = 44
        NCRR = 45
        NARR = 46
        INNA = 47
        IIND = 48
        IEXE = 49
        FORF = 50
        FEEE = 51
        DTRD = 52
        DSEC = 53
        DQUA = 54
        DMON = 55
        DDEA = 56
        DDAT = 57
        COMC = 58
        CADE = 59
        BUSE = 60
        ASTM = 61
    }
    class ISO20022.Setr044001.RepairReason14 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.RepairReason19Choice
    }
    ISO20022.Setr044001.RepairReason14 *-- ISO20022.Setr044001.RepairReason19Choice
    class ISO20022.Setr044001.RepairReason19Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.RepairReason19Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.RepairReason7Code {
        VASU = 1
        ULNK = 2
        TXST = 3
        TERM = 4
        SETS = 5
        SETR = 6
        SAFE = 7
        RTGS = 8
        RSPR = 9
        RERT = 10
        REPP = 11
        REPO = 12
        CTRA = 13
        PLCE = 14
        PHYS = 15
        NRGN = 16
        NRGM = 17
        NCRR = 18
        NARR = 19
        LEOG = 20
        INNA = 21
        IIND = 22
        IEXE = 23
        ICUS = 24
        ICAG = 25
        FORF = 26
        FEEE = 27
        DTRD = 28
        DSEC = 29
        DQUA = 30
        DMON = 31
        DEPT = 32
        DDEA = 33
        DDAT = 34
        COMC = 35
        CASY = 36
        CASH = 37
        CADE = 38
        BUSE = 39
        BATC = 40
        ADEA = 41
    }
    class ISO20022.Setr044001.ReplacementProcessingStatus10Choice {
        + PrtrySts  : ISO20022.Setr044001.ProprietaryStatusAndReason6
        + ModReqd  : ISO20022.Setr044001.ProprietaryReason4
        + Rjctd  : ISO20022.Setr044001.ProprietaryReason4
        + RcvdAtStockXchg  : ISO20022.Setr044001.ProprietaryReason4
        + RcvdAtIntrmy  : ISO20022.Setr044001.ProprietaryReason4
        + Pdg  : ISO20022.Setr044001.ProprietaryReason4
        + PrtlRplcmntAccptd  : ISO20022.Setr044001.ProprietaryReason4
        + InRpr  : ISO20022.Setr044001.ProprietaryReason4
        + Dnd  : ISO20022.Setr044001.ProprietaryReason4
        + Cmpltd  : ISO20022.Setr044001.ProprietaryReason4
        + Accptd  : ISO20022.Setr044001.ProprietaryReason4
    }
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryStatusAndReason6
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    ISO20022.Setr044001.ReplacementProcessingStatus10Choice *-- ISO20022.Setr044001.ProprietaryReason4
    class ISO20022.Setr044001.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Setr044001.Reporting6Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.Reporting6Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.SecuritiesAccount35 {
        + Nm  : String
        + Tp  : ISO20022.Setr044001.PurposeCode9Choice
        + Id  : String
    }
    ISO20022.Setr044001.SecuritiesAccount35 *-- ISO20022.Setr044001.PurposeCode9Choice
    class ISO20022.Setr044001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Setr044001.SecuritiesCertificate3 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Setr044001.SupplementaryData1~
        + RcvgSttlmPties  : ISO20022.Setr044001.SettlementParties121
        + DlvrgSttlmPties  : ISO20022.Setr044001.SettlementParties121
        + ConfPties  : global::System.Collections.Generic.List~ISO20022.Setr044001.ConfirmationParties9~
        + CtrPtyTradgDtls  : ISO20022.Setr044001.Order23
        + PtyTradgDtls  : ISO20022.Setr044001.Order23
        + CxlPrcgSts  : ISO20022.Setr044001.CancellationProcessingStatus10Choice
        + RplcmntPrcgSts  : ISO20022.Setr044001.ReplacementProcessingStatus10Choice
        + MtchgSts  : ISO20022.Setr044001.MatchingStatus35Choice
        + PrcgSts  : ISO20022.Setr044001.ProcessingStatus98Choice
        + AffirmSts  : ISO20022.Setr044001.AffirmationStatus11Choice
        + Refs  : global::System.Collections.Generic.List~ISO20022.Setr044001.Linkages77~
        + Id  : ISO20022.Setr044001.TransactiontIdentification4
    }
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.SupplementaryData1
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.SettlementParties121
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.SettlementParties121
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.ConfirmationParties9
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.Order23
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.Order23
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.CancellationProcessingStatus10Choice
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.ReplacementProcessingStatus10Choice
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.MatchingStatus35Choice
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.ProcessingStatus98Choice
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.AffirmationStatus11Choice
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.Linkages77
    ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04 *-- ISO20022.Setr044001.TransactiontIdentification4
    class ISO20022.Setr044001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Setr044001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Setr044001.SecurityIdentification19 *-- ISO20022.Setr044001.OtherIdentification1
    class ISO20022.Setr044001.SettlementDate16Choice {
        + Cd  : ISO20022.Setr044001.SettlementDateCode12Choice
        + Dt  : ISO20022.Setr044001.DateAndDateTime1Choice
    }
    ISO20022.Setr044001.SettlementDate16Choice *-- ISO20022.Setr044001.SettlementDateCode12Choice
    ISO20022.Setr044001.SettlementDate16Choice *-- ISO20022.Setr044001.DateAndDateTime1Choice
    class ISO20022.Setr044001.SettlementDate5Code {
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
    class ISO20022.Setr044001.SettlementDateCode12Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.SettlementDateCode12Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.SettlementParties121 {
        + Pty5  : ISO20022.Setr044001.PartyIdentificationAndAccount218
        + Pty4  : ISO20022.Setr044001.PartyIdentificationAndAccount218
        + Pty3  : ISO20022.Setr044001.PartyIdentificationAndAccount218
        + Pty2  : ISO20022.Setr044001.PartyIdentificationAndAccount218
        + Pty1  : ISO20022.Setr044001.PartyIdentificationAndAccount218
        + Dpstry  : ISO20022.Setr044001.PartyIdentification268
    }
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentificationAndAccount218
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentificationAndAccount218
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentificationAndAccount218
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentificationAndAccount218
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentificationAndAccount218
    ISO20022.Setr044001.SettlementParties121 *-- ISO20022.Setr044001.PartyIdentification268
    class ISO20022.Setr044001.Side3Code {
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
    class ISO20022.Setr044001.SimpleIdentificationInformation2 {
        + Id  : String
    }
    class ISO20022.Setr044001.SupplementaryData1 {
        + Envlp  : ISO20022.Setr044001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Setr044001.SupplementaryData1 *-- ISO20022.Setr044001.SupplementaryDataEnvelope1
    class ISO20022.Setr044001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Setr044001.TradeDate7Choice {
        + Val  : ISO20022.Setr044001.TradingDateCode2Choice
        + Dt  : ISO20022.Setr044001.DateAndDateTime1Choice
    }
    ISO20022.Setr044001.TradeDate7Choice *-- ISO20022.Setr044001.TradingDateCode2Choice
    ISO20022.Setr044001.TradeDate7Choice *-- ISO20022.Setr044001.DateAndDateTime1Choice
    class ISO20022.Setr044001.TradeRegulatoryConditions1Code {
        USOL = 1
        SOLI = 2
    }
    class ISO20022.Setr044001.TradeTransactionCondition9Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.TradeTransactionCondition9Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.TradeType3Code {
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
    class ISO20022.Setr044001.TradeType4Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.TradeType4Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.TradingCapacity4Code {
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
    class ISO20022.Setr044001.TradingCapacity6Code {
        PRIN = 1
        PRAG = 2
        OAGN = 3
        CPRN = 4
        CAGN = 5
        BAGN = 6
        AGEN = 7
    }
    class ISO20022.Setr044001.TradingDate1Code {
        VARI = 1
    }
    class ISO20022.Setr044001.TradingDateCode2Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.TradingDateCode2Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.TradingPartyCapacity3Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Setr044001.TradingPartyCapacity3Choice *-- ISO20022.Setr044001.GenericIdentification36
    class ISO20022.Setr044001.TradingPartyCapacity4Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.TradingPartyCapacity4Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.TransactiontIdentification4 {
        + TxId  : String
    }
    class ISO20022.Setr044001.TypeOfIdentification2Code {
        TXID = 1
        FIIN = 2
        CORP = 3
        CHTY = 4
        ARNU = 5
    }
    class ISO20022.Setr044001.TypeOfPrice3Code {
        RDAV = 1
        PARV = 2
        NET1 = 3
        NET2 = 4
        GREX = 5
        AVOV = 6
        AVER = 7
    }
    class ISO20022.Setr044001.TypeOfPrice47Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.TypeOfPrice47Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.UnaffirmedReason1Code {
        NAFF = 1
    }
    class ISO20022.Setr044001.UnaffirmedReason3Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.UnaffirmedReason3Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.UnmatchedReason23 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Setr044001.UnmatchedReason32Choice
    }
    ISO20022.Setr044001.UnmatchedReason23 *-- ISO20022.Setr044001.UnmatchedReason32Choice
    class ISO20022.Setr044001.UnmatchedReason32Choice {
        + Prtry  : ISO20022.Setr044001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr044001.UnmatchedReason32Choice *-- ISO20022.Setr044001.GenericIdentification30
    class ISO20022.Setr044001.UnmatchedReason4Code {
        CLSE = 1
        ENFC = 2
        LTME = 3
        CUFC = 4
        INTT = 5
        LWCO = 6
        TRTR = 7
        OPLI = 8
        BOIA = 9
        TRTE = 10
        TRSA = 11
        OLID = 12
        MADA = 13
        DBNM = 14
        TACS = 15
        CATI = 16
        DEAS = 17
        ACRS = 18
        SHAI = 19
        ACRU = 20
        SCRA = 21
        COID = 22
        SDAT = 23
        TACR = 24
        BOFE = 25
        OTHI = 26
        COAX = 27
        BORT = 28
        POSE = 29
        VASU = 30
        TXST = 31
        TERM = 32
        SETS = 33
        SETR = 34
        SAFE = 35
        RTGS = 36
        RSPR = 37
        RERT = 38
        REPP = 39
        REPO = 40
        REPA = 41
        PODU = 42
        PLCE = 43
        PHYS = 44
        NARR = 45
        MCAN = 46
        LEOG = 47
        LATE = 48
        FORF = 49
        EXEC = 50
        DTRD = 51
        DSEC = 52
        DQUA = 53
        DMON = 54
        DEPT = 55
        DELN = 56
        DEAL = 57
        DDEA = 58
        DDAT = 59
        CPCA = 60
        CMIS = 61
        CHAR = 62
        CADE = 63
        ADEA = 64
    }
    class ISO20022.Setr044001.YieldCalculation7 {
        + ClctnDt  : DateTime
        + ValPrd  : ISO20022.Setr044001.DateTimePeriod1Choice
        + ValDt  : DateTime
        + RedPric  : ISO20022.Setr044001.Price14
        + ClctnTp  : String
        + Val  : Decimal
    }
    ISO20022.Setr044001.YieldCalculation7 *-- ISO20022.Setr044001.DateTimePeriod1Choice
    ISO20022.Setr044001.YieldCalculation7 *-- ISO20022.Setr044001.Price14
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

## Value ISO20022.Setr044001.AccountIdentification55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryAcct|ISO20022.Setr044001.SimpleIdentificationInformation2||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(PrtryAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Setr044001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr044001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Setr044001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Setr044001.AffirmationReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.UnaffirmedReason3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Setr044001.AffirmationReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.AffirmationReason2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(NoSpcfdRsn,Rsn))|

---

## Value ISO20022.Setr044001.AffirmationStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Setr044001.ProprietaryStatusAndReason6||XmlElement()||
|+|Uaffrmd|ISO20022.Setr044001.AffirmationReason2Choice||XmlElement()||
|+|Affrmd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(Uaffrmd),validElement(Affrmd),validChoice(PrtrySts,Uaffrmd,Affrmd))|

---

## Value ISO20022.Setr044001.AllegementMatchingReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.AllegementReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Setr044001.AllegementReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALG1|Int32||XmlEnum("""ALG1""")|1|

---

## Value ISO20022.Setr044001.AllegementReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.AlternatePartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Setr044001.IdentificationType43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Setr044001.AmountAndDirection29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Setr044001.ForeignExchangeTerms18||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Setr044001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Setr044001.AmountOrRate2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr044001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Enum ISO20022.Setr044001.AwaitingAffirmationReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WAFF|Int32||XmlEnum("""WAFF""")|1|

---

## Value ISO20022.Setr044001.AwaitingAffirmationReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.AwaitingAffirmationReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Setr044001.AwaitingAffirmationReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.AwaitingCancellationReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WCAN|Int32||XmlEnum("""WCAN""")|1|

---

## Value ISO20022.Setr044001.AwaitingCancellationReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.AwaitingCancellationReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Setr044001.AwaitingCancellationReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.BusinessProcessType1Code


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

## Value ISO20022.Setr044001.BusinessProcessType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.CalculationType1Code


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

## Enum ISO20022.Setr044001.CallIn1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CFCC|Int32||XmlEnum("""CFCC""")|1|
||CFST|Int32||XmlEnum("""CFST""")|2|
||CFAV|Int32||XmlEnum("""CFAV""")|3|

---

## Value ISO20022.Setr044001.CancellationProcessingStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Setr044001.ProprietaryStatusAndReason6||XmlElement()||
|+|CxlCmpltd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|CxlReqd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|CxlPdg|ISO20022.Setr044001.CancellationReason39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(CxlCmpltd),validElement(CxlReqd),validElement(CxlPdg),validChoice(PrtrySts,CxlCmpltd,CxlReqd,CxlPdg))|

---

## Value ISO20022.Setr044001.CancellationReason39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.AwaitingCancellationReason2>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Setr044001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Enum ISO20022.Setr044001.CashMarginOrder1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MRGC|Int32||XmlEnum("""MRGC""")|1|
||MRGO|Int32||XmlEnum("""MRGO""")|2|
||CASH|Int32||XmlEnum("""CASH""")|3|

---

## Enum ISO20022.Setr044001.ChargeTaxBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Value ISO20022.Setr044001.ChargeTaxBasisType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.Commission25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VATRate|Decimal||XmlElement()||
|+|TtlVATAmt|ISO20022.Setr044001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlComssn|ISO20022.Setr044001.AmountAndDirection29||XmlElement()||
|+|ClctnDt|DateTime||XmlElement()||
|+|RcptId|ISO20022.Setr044001.PartyIdentification267||XmlElement()||
|+|Comssn|ISO20022.Setr044001.AmountOrRate2Choice||XmlElement()||
|+|Tp|ISO20022.Setr044001.CommissionType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlVATAmt),validElement(TtlComssn),validElement(RcptId),validElement(Comssn),validElement(Tp))|

---

## Value ISO20022.Setr044001.CommissionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.CommissionType9Code


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

## Value ISO20022.Setr044001.ConfirmationParties9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradBnfcryPty|ISO20022.Setr044001.ConfirmationPartyDetails14||XmlElement()||
|+|AffrmgPty|ISO20022.Setr044001.ConfirmationPartyDetails14||XmlElement()||
|+|ExctgBrkr|ISO20022.Setr044001.ConfirmationPartyDetails16||XmlElement()||
|+|ClrFirm|ISO20022.Setr044001.ConfirmationPartyDetails16||XmlElement()||
|+|StepOutFirm|ISO20022.Setr044001.ConfirmationPartyDetails11||XmlElement()||
|+|StepInFirm|ISO20022.Setr044001.ConfirmationPartyDetails11||XmlElement()||
|+|IntrdcgFirm|ISO20022.Setr044001.ConfirmationPartyDetails14||XmlElement()||
|+|BrkrOfCdt|ISO20022.Setr044001.ConfirmationPartyDetails14||XmlElement()||
|+|Lndr|ISO20022.Setr044001.ConfirmationPartyDetails12||XmlElement()||
|+|Sellr|ISO20022.Setr044001.ConfirmationPartyDetails12||XmlElement()||
|+|Brrwr|ISO20022.Setr044001.ConfirmationPartyDetails12||XmlElement()||
|+|Buyr|ISO20022.Setr044001.ConfirmationPartyDetails12||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Setr044001.PartyIdentificationAndAccount220>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradBnfcryPty),validElement(AffrmgPty),validElement(ExctgBrkr),validElement(ClrFirm),validElement(StepOutFirm),validElement(StepInFirm),validElement(IntrdcgFirm),validElement(BrkrOfCdt),validElement(Lndr),validElement(Sellr),validElement(Brrwr),validElement(Buyr),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Value ISO20022.Setr044001.ConfirmationPartyDetails11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr044001.ConfirmationPartyDetails12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgPtyCpcty|ISO20022.Setr044001.TradingPartyCapacity4Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Setr044001.InvestorCapacity4Choice||XmlElement()||
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradgPtyCpcty),validElement(InvstrCpcty),validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr044001.ConfirmationPartyDetails14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Setr044001.TradingPartyCapacity3Choice||XmlElement()||
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|CshDtls|ISO20022.Setr044001.AccountIdentification55Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Setr044001.SecuritiesAccount35||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AddtlInf),validElement(AltrnId),validElement(CshDtls),validElement(SfkpgAcct),validElement(Id))|

---

## Value ISO20022.Setr044001.ConfirmationPartyDetails16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstrPrtcnAssoctnMmbsh|String||XmlElement()||
|+|PtyCpcty|ISO20022.Setr044001.TradingPartyCapacity3Choice||XmlElement()||
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation5||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|CshDtls|ISO20022.Setr044001.AccountIdentification55Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Setr044001.SecuritiesAccount35||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AddtlInf),validElement(AltrnId),validElement(CshDtls),validElement(SfkpgAcct),validElement(Id))|

---

## Enum ISO20022.Setr044001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Setr044001.CurrencyToBuyOrSell1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validChoice(CcyToSell,CcyToBuy))|

---

## Value ISO20022.Setr044001.DateAndDateTime1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr044001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.DateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmRg|ISO20022.Setr044001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTmRg),validChoice(DtTmRg,ToDtTm,FrDtTm))|

---

## Enum ISO20022.Setr044001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Setr044001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTradConfStsAdvc|ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTradConfStsAdvc))|

---

## Value ISO20022.Setr044001.DocumentNumber17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Setr044001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Value ISO20022.Setr044001.EUCapitalGainType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|EUCptlGn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,EUCptlGn))|

---

## Enum ISO20022.Setr044001.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Setr044001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Setr044001.ForeignExchangeTerms18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConvtdAmt|ISO20022.Setr044001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ConvtdAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr044001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr044001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.IdentificationReference16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnqTxIdr|String||XmlElement()||
|+|CollTxId|String||XmlElement()||
|+|CxlReqId|String||XmlElement()||
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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(UnqTxIdr,CollTxId,CxlReqId,CmplcId,CmonId,IndxId,ScndryAllcnId,IndvAllcnId,AllcnId,BlckId,PoolId,ClntOrdrLkId,MktInfrstrctrTxId,ExctgPtyTxId,InstgPtyTxId))|

---

## Value ISO20022.Setr044001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.IdentificationType43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.InstructionProcessingReason3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.RejectionReason67>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(NoSpcfdRsn,Rsn))|

---

## Value ISO20022.Setr044001.InstructionProcessingReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.RepairReason14>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(NoSpcfdRsn,Rsn))|

---

## Enum ISO20022.Setr044001.InterestType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||XINT|Int32||XmlEnum("""XINT""")|1|
||CINT|Int32||XmlEnum("""CINT""")|2|

---

## Value ISO20022.Setr044001.InvestorCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.Linkages77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|ISO20022.Setr044001.IdentificationReference16Choice||XmlElement()||
|+|MsgNb|ISO20022.Setr044001.DocumentNumber17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ref),validElement(MsgNb))|

---

## Value ISO20022.Setr044001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Setr044001.MarketIdentification93


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr044001.MarketType18Choice||XmlElement()||
|+|Id|ISO20022.Setr044001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Setr044001.MarketIdentification97


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr044001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Setr044001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Setr044001.MarketType18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Enum ISO20022.Setr044001.MarketType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|

---

## Value ISO20022.Setr044001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.MatchingReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.AllegementMatchingReason2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(NoSpcfdRsn,Rsn))|

---

## Value ISO20022.Setr044001.MatchingReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.UnmatchedReason23>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(NoSpcfdRsn,Rsn))|

---

## Enum ISO20022.Setr044001.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Setr044001.MatchingStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.MatchingStatus35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Setr044001.ProprietaryStatusAndReason6||XmlElement()||
|+|Umtchd|ISO20022.Setr044001.MatchingReason6Choice||XmlElement()||
|+|MtchgAllgd|ISO20022.Setr044001.MatchingReason5Choice||XmlElement()||
|+|MtchdWthTlrnce|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Mtchd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(Umtchd),validElement(MtchgAllgd),validElement(MtchdWthTlrnce),validElement(Mtchd),validChoice(PrtrySts,Umtchd,MtchgAllgd,MtchdWthTlrnce,Mtchd))|

---

## Value ISO20022.Setr044001.NameAndAddress13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr044001.PostalAddress8||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr044001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Setr044001.Order23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcrdIntrstAmt|ISO20022.Setr044001.AmountAndDirection29||XmlElement()||
|+|AddtlTradInstrPrcgInf|String||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Setr044001.RegistrationParameters3||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Setr044001.Reporting6Choice>||XmlElement()||
|+|YldTp|ISO20022.Setr044001.YieldCalculation7||XmlElement()||
|+|CallInTp|String||XmlElement()||
|+|MtchSts|ISO20022.Setr044001.MatchingStatus27Choice||XmlElement()||
|+|CptlGnTp|ISO20022.Setr044001.EUCapitalGainType3Choice||XmlElement()||
|+|ChrgTaxBsisTp|ISO20022.Setr044001.ChargeTaxBasisType2Choice||XmlElement()||
|+|DerivCvrd|String||XmlElement()||
|+|PosFct|String||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Setr044001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TradRgltryCondsTp|String||XmlElement()||
|+|AcrdIntrstPctg|Decimal||XmlElement()||
|+|IntrstTp|String||XmlElement()||
|+|GvUpNbOfDays|Decimal||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|Comssn|ISO20022.Setr044001.Commission25||XmlElement()||
|+|CshMrgn|String||XmlElement()||
|+|TpOfPric|ISO20022.Setr044001.TypeOfPrice47Choice||XmlElement()||
|+|DealPric|ISO20022.Setr044001.Price14||XmlElement()||
|+|GrssTradAmt|ISO20022.Setr044001.AmountAndDirection29||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Setr044001.QuantityBreakdown76>||XmlElement()||
|+|ConfQty|ISO20022.Setr044001.Quantity6Choice||XmlElement()||
|+|PrtlFillDtls|global::System.Collections.Generic.List<ISO20022.Setr044001.PartialFill4>||XmlElement()||
|+|NAVDt|ISO20022.Setr044001.DateAndDateTime1Choice||XmlElement()||
|+|SttlmDt|ISO20022.Setr044001.SettlementDate16Choice||XmlElement()||
|+|PrcgDt|ISO20022.Setr044001.TradeDate7Choice||XmlElement()||
|+|TradDt|ISO20022.Setr044001.TradeDate7Choice||XmlElement()||
|+|TradOrgtnDt|DateTime||XmlElement()||
|+|OrdrBookgDt|DateTime||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr044001.MarketIdentification93||XmlElement()||
|+|PreAdvc|String||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Setr044001.TradeTransactionCondition9Choice>||XmlElement()||
|+|TradTxTp|ISO20022.Setr044001.TradeType4Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|Sd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Setr044001.SecurityIdentification19||XmlElement()||
|+|ListId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ScndryClntOrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ClntOrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OrdrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|BizPrcTp|ISO20022.Setr044001.BusinessProcessType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcrdIntrstAmt),validElement(AddtlPhysOrRegnDtls),validList("""Rptg""",Rptg),validElement(Rptg),validElement(YldTp),validElement(MtchSts),validElement(CptlGnTp),validElement(ChrgTaxBsisTp),validElement(CcyToBuyOrSell),validElement(Comssn),validElement(TpOfPric),validElement(DealPric),validElement(GrssTradAmt),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(ConfQty),validList("""PrtlFillDtls""",PrtlFillDtls),validElement(PrtlFillDtls),validElement(NAVDt),validElement(SttlmDt),validElement(PrcgDt),validElement(TradDt),validElement(PlcOfTrad),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(TradTxTp),validElement(FinInstrmId),validElement(BizPrcTp))|

---

## Value ISO20022.Setr044001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr044001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr044001.PartialFill4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtchIncrmtQty|ISO20022.Setr044001.QuantityOrAmount2Choice||XmlElement()||
|+|RmngQty|ISO20022.Setr044001.QuantityOrAmount2Choice||XmlElement()||
|+|PrevslyExctdQty|ISO20022.Setr044001.QuantityOrAmount2Choice||XmlElement()||
|+|OrgnlOrdrdQty|ISO20022.Setr044001.QuantityOrAmount2Choice||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr044001.MarketIdentification97||XmlElement()||
|+|TradDt|ISO20022.Setr044001.TradeDate7Choice||XmlElement()||
|+|DealPric|ISO20022.Setr044001.Price14||XmlElement()||
|+|ConfQty|ISO20022.Setr044001.Quantity6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchIncrmtQty),validElement(RmngQty),validElement(PrevslyExctdQty),validElement(OrgnlOrdrdQty),validElement(PlcOfTrad),validElement(TradDt),validElement(DealPric),validElement(ConfQty))|

---

## Value ISO20022.Setr044001.PartyIdentification240Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr044001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Setr044001.GenericIdentification36||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BIC))|

---

## Value ISO20022.Setr044001.PartyIdentification244Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Setr044001.NameAndAddress13||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,BIC))|

---

## Value ISO20022.Setr044001.PartyIdentification267


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr044001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Setr044001.GenericIdentification36||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr044001.PartyIdentification268


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation1||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification244Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr044001.PartyIdentificationAndAccount218


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Setr044001.PartyIdentificationAndAccount220


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Setr044001.AlternatePartyIdentification8||XmlElement()||
|+|AddtlInf|ISO20022.Setr044001.PartyTextInformation1||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|CshAcct|ISO20022.Setr044001.CashAccountIdentification5Choice||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Id|ISO20022.Setr044001.PartyIdentification240Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validElement(AddtlInf),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(CshAcct),validElement(Id))|

---

## Value ISO20022.Setr044001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.PartyTextInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.PendingProcessing2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Setr044001.AwaitingAffirmationReason2>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Setr044001.PositionEffect2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLOA|Int32||XmlEnum("""CLOA""")|1|
||FIFO|Int32||XmlEnum("""FIFO""")|2|
||ROLL|Int32||XmlEnum("""ROLL""")|3|
||CLOS|Int32||XmlEnum("""CLOS""")|4|
||OPEN|Int32||XmlEnum("""OPEN""")|5|

---

## Value ISO20022.Setr044001.PostalAddress8


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

## Value ISO20022.Setr044001.Price14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|ISO20022.Setr044001.PriceRateOrAmount3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Value ISO20022.Setr044001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr044001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Setr044001.PriceValueType7Code


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

## Value ISO20022.Setr044001.ProcessingStatus98Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Setr044001.ProprietaryStatusAndReason6||XmlElement()||
|+|Trtd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|TradgSspdByStockXchg|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|StgInstr|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|SttlmInstrSnt|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Rjctd|ISO20022.Setr044001.InstructionProcessingReason3Choice||XmlElement()||
|+|RcvdAtIntrmy|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|PdgPrcg|ISO20022.Setr044001.PendingProcessing2Choice||XmlElement()||
|+|OpnOrdr|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|NoInstr|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|InRpr|ISO20022.Setr044001.InstructionProcessingReason4Choice||XmlElement()||
|+|Gnrtd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Futr|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|FullyExctdConfSnt|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|ForcdRjctn|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Done|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|DfltActn|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|AlrdyMtchdAndAffrmd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|AckdAccptd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(Trtd),validElement(TradgSspdByStockXchg),validElement(StgInstr),validElement(SttlmInstrSnt),validElement(Rjctd),validElement(RcvdAtIntrmy),validElement(PdgPrcg),validElement(OpnOrdr),validElement(NoInstr),validElement(InRpr),validElement(Gnrtd),validElement(Futr),validElement(FullyExctdConfSnt),validElement(ForcdRjctn),validElement(Done),validElement(DfltActn),validElement(AlrdyMtchdAndAffrmd),validElement(AckdAccptd),validChoice(PrtrySts,Trtd,TradgSspdByStockXchg,StgInstr,SttlmInstrSnt,Rjctd,RcvdAtIntrmy,PdgPrcg,OpnOrdr,NoInstr,InRpr,Gnrtd,Futr,FullyExctdConfSnt,ForcdRjctn,Done,DfltActn,AlrdyMtchdAndAffrmd,AckdAccptd))|

---

## Value ISO20022.Setr044001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Setr044001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Setr044001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Setr044001.PurposeCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.Quantity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Setr044001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Setr044001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Setr044001.QuantityBreakdown76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotPric|ISO20022.Setr044001.Price14||XmlElement()||
|+|LotDtTm|ISO20022.Setr044001.DateAndDateTime1Choice||XmlElement()||
|+|LotQty|ISO20022.Setr044001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotNb|ISO20022.Setr044001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Setr044001.QuantityOrAmount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr044001.ActiveCurrencyAndAmount||XmlElement()||
|+|Qty|ISO20022.Setr044001.FinancialInstrumentQuantity1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Qty),validChoice(Amt,Qty))|

---

## Value ISO20022.Setr044001.RegistrationParameters3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Setr044001.SecuritiesCertificate3>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Setr044001.DateAndDateTime1Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validElement(CertfctnDtTm))|

---

## Value ISO20022.Setr044001.RejectionReason52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.RejectionReason67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.RejectionReason52Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Setr044001.RejectionReason78Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICAG|Int32||XmlEnum("""ICAG""")|1|
||ICUS|Int32||XmlEnum("""ICUS""")|2|
||DEPT|Int32||XmlEnum("""DEPT""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||INDT|Int32||XmlEnum("""INDT""")|5|
||FAIL|Int32||XmlEnum("""FAIL""")|6|
||DFLT|Int32||XmlEnum("""DFLT""")|7|
||GAMN|Int32||XmlEnum("""GAMN""")|8|
||ACRU|Int32||XmlEnum("""ACRU""")|9|
||XRAT|Int32||XmlEnum("""XRAT""")|10|
||RESU|Int32||XmlEnum("""RESU""")|11|
||DISE|Int32||XmlEnum("""DISE""")|12|
||DISC|Int32||XmlEnum("""DISC""")|13|
||CPTY|Int32||XmlEnum("""CPTY""")|14|
||CADI|Int32||XmlEnum("""CADI""")|15|
||SIDE|Int32||XmlEnum("""SIDE""")|16|
||EQTY|Int32||XmlEnum("""EQTY""")|17|
||PRIC|Int32||XmlEnum("""PRIC""")|18|
||INPR|Int32||XmlEnum("""INPR""")|19|
||EXLI|Int32||XmlEnum("""EXLI""")|20|
||UKWN|Int32||XmlEnum("""UKWN""")|21|
||OPTY|Int32||XmlEnum("""OPTY""")|22|
||OPNM|Int32||XmlEnum("""OPNM""")|23|
||INIR|Int32||XmlEnum("""INIR""")|24|
||VASU|Int32||XmlEnum("""VASU""")|25|
||ULNK|Int32||XmlEnum("""ULNK""")|26|
||TXST|Int32||XmlEnum("""TXST""")|27|
||TQNP|Int32||XmlEnum("""TQNP""")|28|
||TQHI|Int32||XmlEnum("""TQHI""")|29|
||TNIU|Int32||XmlEnum("""TNIU""")|30|
||TNAR|Int32||XmlEnum("""TNAR""")|31|
||TERM|Int32||XmlEnum("""TERM""")|32|
||SETS|Int32||XmlEnum("""SETS""")|33|
||SETR|Int32||XmlEnum("""SETR""")|34|
||SAFE|Int32||XmlEnum("""SAFE""")|35|
||RSPR|Int32||XmlEnum("""RSPR""")|36|
||RERT|Int32||XmlEnum("""RERT""")|37|
||REPP|Int32||XmlEnum("""REPP""")|38|
||REPO|Int32||XmlEnum("""REPO""")|39|
||CTRA|Int32||XmlEnum("""CTRA""")|40|
||REFE|Int32||XmlEnum("""REFE""")|41|
||QUNP|Int32||XmlEnum("""QUNP""")|42|
||PLCE|Int32||XmlEnum("""PLCE""")|43|
||ODNP|Int32||XmlEnum("""ODNP""")|44|
||NCRR|Int32||XmlEnum("""NCRR""")|45|
||NARR|Int32||XmlEnum("""NARR""")|46|
||INNA|Int32||XmlEnum("""INNA""")|47|
||IIND|Int32||XmlEnum("""IIND""")|48|
||IEXE|Int32||XmlEnum("""IEXE""")|49|
||FORF|Int32||XmlEnum("""FORF""")|50|
||FEEE|Int32||XmlEnum("""FEEE""")|51|
||DTRD|Int32||XmlEnum("""DTRD""")|52|
||DSEC|Int32||XmlEnum("""DSEC""")|53|
||DQUA|Int32||XmlEnum("""DQUA""")|54|
||DMON|Int32||XmlEnum("""DMON""")|55|
||DDEA|Int32||XmlEnum("""DDEA""")|56|
||DDAT|Int32||XmlEnum("""DDAT""")|57|
||COMC|Int32||XmlEnum("""COMC""")|58|
||CADE|Int32||XmlEnum("""CADE""")|59|
||BUSE|Int32||XmlEnum("""BUSE""")|60|
||ASTM|Int32||XmlEnum("""ASTM""")|61|

---

## Value ISO20022.Setr044001.RepairReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.RepairReason19Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Setr044001.RepairReason19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.RepairReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VASU|Int32||XmlEnum("""VASU""")|1|
||ULNK|Int32||XmlEnum("""ULNK""")|2|
||TXST|Int32||XmlEnum("""TXST""")|3|
||TERM|Int32||XmlEnum("""TERM""")|4|
||SETS|Int32||XmlEnum("""SETS""")|5|
||SETR|Int32||XmlEnum("""SETR""")|6|
||SAFE|Int32||XmlEnum("""SAFE""")|7|
||RTGS|Int32||XmlEnum("""RTGS""")|8|
||RSPR|Int32||XmlEnum("""RSPR""")|9|
||RERT|Int32||XmlEnum("""RERT""")|10|
||REPP|Int32||XmlEnum("""REPP""")|11|
||REPO|Int32||XmlEnum("""REPO""")|12|
||CTRA|Int32||XmlEnum("""CTRA""")|13|
||PLCE|Int32||XmlEnum("""PLCE""")|14|
||PHYS|Int32||XmlEnum("""PHYS""")|15|
||NRGN|Int32||XmlEnum("""NRGN""")|16|
||NRGM|Int32||XmlEnum("""NRGM""")|17|
||NCRR|Int32||XmlEnum("""NCRR""")|18|
||NARR|Int32||XmlEnum("""NARR""")|19|
||LEOG|Int32||XmlEnum("""LEOG""")|20|
||INNA|Int32||XmlEnum("""INNA""")|21|
||IIND|Int32||XmlEnum("""IIND""")|22|
||IEXE|Int32||XmlEnum("""IEXE""")|23|
||ICUS|Int32||XmlEnum("""ICUS""")|24|
||ICAG|Int32||XmlEnum("""ICAG""")|25|
||FORF|Int32||XmlEnum("""FORF""")|26|
||FEEE|Int32||XmlEnum("""FEEE""")|27|
||DTRD|Int32||XmlEnum("""DTRD""")|28|
||DSEC|Int32||XmlEnum("""DSEC""")|29|
||DQUA|Int32||XmlEnum("""DQUA""")|30|
||DMON|Int32||XmlEnum("""DMON""")|31|
||DEPT|Int32||XmlEnum("""DEPT""")|32|
||DDEA|Int32||XmlEnum("""DDEA""")|33|
||DDAT|Int32||XmlEnum("""DDAT""")|34|
||COMC|Int32||XmlEnum("""COMC""")|35|
||CASY|Int32||XmlEnum("""CASY""")|36|
||CASH|Int32||XmlEnum("""CASH""")|37|
||CADE|Int32||XmlEnum("""CADE""")|38|
||BUSE|Int32||XmlEnum("""BUSE""")|39|
||BATC|Int32||XmlEnum("""BATC""")|40|
||ADEA|Int32||XmlEnum("""ADEA""")|41|

---

## Value ISO20022.Setr044001.ReplacementProcessingStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Setr044001.ProprietaryStatusAndReason6||XmlElement()||
|+|ModReqd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Rjctd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|RcvdAtStockXchg|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|RcvdAtIntrmy|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Pdg|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|PrtlRplcmntAccptd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|InRpr|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Dnd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Cmpltd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
|+|Accptd|ISO20022.Setr044001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(ModReqd),validElement(Rjctd),validElement(RcvdAtStockXchg),validElement(RcvdAtIntrmy),validElement(Pdg),validElement(PrtlRplcmntAccptd),validElement(InRpr),validElement(Dnd),validElement(Cmpltd),validElement(Accptd),validChoice(PrtrySts,ModReqd,Rjctd,RcvdAtStockXchg,RcvdAtIntrmy,Pdg,PrtlRplcmntAccptd,InRpr,Dnd,Cmpltd,Accptd))|

---

## Enum ISO20022.Setr044001.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Setr044001.Reporting6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.SecuritiesAccount35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Setr044001.PurposeCode9Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Setr044001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Value ISO20022.Setr044001.SecuritiesCertificate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Setr044001.SecuritiesTradeConfirmationStatusAdviceV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Setr044001.SupplementaryData1>||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Setr044001.SettlementParties121||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Setr044001.SettlementParties121||XmlElement()||
|+|ConfPties|global::System.Collections.Generic.List<ISO20022.Setr044001.ConfirmationParties9>||XmlElement()||
|+|CtrPtyTradgDtls|ISO20022.Setr044001.Order23||XmlElement()||
|+|PtyTradgDtls|ISO20022.Setr044001.Order23||XmlElement()||
|+|CxlPrcgSts|ISO20022.Setr044001.CancellationProcessingStatus10Choice||XmlElement()||
|+|RplcmntPrcgSts|ISO20022.Setr044001.ReplacementProcessingStatus10Choice||XmlElement()||
|+|MtchgSts|ISO20022.Setr044001.MatchingStatus35Choice||XmlElement()||
|+|PrcgSts|ISO20022.Setr044001.ProcessingStatus98Choice||XmlElement()||
|+|AffirmSts|ISO20022.Setr044001.AffirmationStatus11Choice||XmlElement()||
|+|Refs|global::System.Collections.Generic.List<ISO20022.Setr044001.Linkages77>||XmlElement()||
|+|Id|ISO20022.Setr044001.TransactiontIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validList("""ConfPties""",ConfPties),validElement(ConfPties),validElement(CtrPtyTradgDtls),validElement(PtyTradgDtls),validElement(CxlPrcgSts),validElement(RplcmntPrcgSts),validElement(MtchgSts),validElement(PrcgSts),validElement(AffirmSts),validRequired("""Refs""",Refs),validList("""Refs""",Refs),validElement(Refs),validElement(Id))|

---

## Value ISO20022.Setr044001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Setr044001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Setr044001.SettlementDate16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Setr044001.SettlementDateCode12Choice||XmlElement()||
|+|Dt|ISO20022.Setr044001.DateAndDateTime1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Enum ISO20022.Setr044001.SettlementDate5Code


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

## Value ISO20022.Setr044001.SettlementDateCode12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.SettlementParties121


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Setr044001.PartyIdentificationAndAccount218||XmlElement()||
|+|Pty4|ISO20022.Setr044001.PartyIdentificationAndAccount218||XmlElement()||
|+|Pty3|ISO20022.Setr044001.PartyIdentificationAndAccount218||XmlElement()||
|+|Pty2|ISO20022.Setr044001.PartyIdentificationAndAccount218||XmlElement()||
|+|Pty1|ISO20022.Setr044001.PartyIdentificationAndAccount218||XmlElement()||
|+|Dpstry|ISO20022.Setr044001.PartyIdentification268||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Setr044001.Side3Code


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

## Value ISO20022.Setr044001.SimpleIdentificationInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Setr044001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Setr044001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr044001.TradeDate7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Setr044001.TradingDateCode2Choice||XmlElement()||
|+|Dt|ISO20022.Setr044001.DateAndDateTime1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Dt),validChoice(Val,Dt))|

---

## Enum ISO20022.Setr044001.TradeRegulatoryConditions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USOL|Int32||XmlEnum("""USOL""")|1|
||SOLI|Int32||XmlEnum("""SOLI""")|2|

---

## Value ISO20022.Setr044001.TradeTransactionCondition9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.TradeType3Code


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

## Value ISO20022.Setr044001.TradeType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.TradingCapacity4Code


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

## Enum ISO20022.Setr044001.TradingCapacity6Code


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

## Enum ISO20022.Setr044001.TradingDate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Value ISO20022.Setr044001.TradingDateCode2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.TradingPartyCapacity3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.TradingPartyCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.TransactiontIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Setr044001.TypeOfIdentification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||CORP|Int32||XmlEnum("""CORP""")|3|
||CHTY|Int32||XmlEnum("""CHTY""")|4|
||ARNU|Int32||XmlEnum("""ARNU""")|5|

---

## Enum ISO20022.Setr044001.TypeOfPrice3Code


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

## Value ISO20022.Setr044001.TypeOfPrice47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.UnaffirmedReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAFF|Int32||XmlEnum("""NAFF""")|1|

---

## Value ISO20022.Setr044001.UnaffirmedReason3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr044001.UnmatchedReason23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Setr044001.UnmatchedReason32Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Setr044001.UnmatchedReason32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr044001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr044001.UnmatchedReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLSE|Int32||XmlEnum("""CLSE""")|1|
||ENFC|Int32||XmlEnum("""ENFC""")|2|
||LTME|Int32||XmlEnum("""LTME""")|3|
||CUFC|Int32||XmlEnum("""CUFC""")|4|
||INTT|Int32||XmlEnum("""INTT""")|5|
||LWCO|Int32||XmlEnum("""LWCO""")|6|
||TRTR|Int32||XmlEnum("""TRTR""")|7|
||OPLI|Int32||XmlEnum("""OPLI""")|8|
||BOIA|Int32||XmlEnum("""BOIA""")|9|
||TRTE|Int32||XmlEnum("""TRTE""")|10|
||TRSA|Int32||XmlEnum("""TRSA""")|11|
||OLID|Int32||XmlEnum("""OLID""")|12|
||MADA|Int32||XmlEnum("""MADA""")|13|
||DBNM|Int32||XmlEnum("""DBNM""")|14|
||TACS|Int32||XmlEnum("""TACS""")|15|
||CATI|Int32||XmlEnum("""CATI""")|16|
||DEAS|Int32||XmlEnum("""DEAS""")|17|
||ACRS|Int32||XmlEnum("""ACRS""")|18|
||SHAI|Int32||XmlEnum("""SHAI""")|19|
||ACRU|Int32||XmlEnum("""ACRU""")|20|
||SCRA|Int32||XmlEnum("""SCRA""")|21|
||COID|Int32||XmlEnum("""COID""")|22|
||SDAT|Int32||XmlEnum("""SDAT""")|23|
||TACR|Int32||XmlEnum("""TACR""")|24|
||BOFE|Int32||XmlEnum("""BOFE""")|25|
||OTHI|Int32||XmlEnum("""OTHI""")|26|
||COAX|Int32||XmlEnum("""COAX""")|27|
||BORT|Int32||XmlEnum("""BORT""")|28|
||POSE|Int32||XmlEnum("""POSE""")|29|
||VASU|Int32||XmlEnum("""VASU""")|30|
||TXST|Int32||XmlEnum("""TXST""")|31|
||TERM|Int32||XmlEnum("""TERM""")|32|
||SETS|Int32||XmlEnum("""SETS""")|33|
||SETR|Int32||XmlEnum("""SETR""")|34|
||SAFE|Int32||XmlEnum("""SAFE""")|35|
||RTGS|Int32||XmlEnum("""RTGS""")|36|
||RSPR|Int32||XmlEnum("""RSPR""")|37|
||RERT|Int32||XmlEnum("""RERT""")|38|
||REPP|Int32||XmlEnum("""REPP""")|39|
||REPO|Int32||XmlEnum("""REPO""")|40|
||REPA|Int32||XmlEnum("""REPA""")|41|
||PODU|Int32||XmlEnum("""PODU""")|42|
||PLCE|Int32||XmlEnum("""PLCE""")|43|
||PHYS|Int32||XmlEnum("""PHYS""")|44|
||NARR|Int32||XmlEnum("""NARR""")|45|
||MCAN|Int32||XmlEnum("""MCAN""")|46|
||LEOG|Int32||XmlEnum("""LEOG""")|47|
||LATE|Int32||XmlEnum("""LATE""")|48|
||FORF|Int32||XmlEnum("""FORF""")|49|
||EXEC|Int32||XmlEnum("""EXEC""")|50|
||DTRD|Int32||XmlEnum("""DTRD""")|51|
||DSEC|Int32||XmlEnum("""DSEC""")|52|
||DQUA|Int32||XmlEnum("""DQUA""")|53|
||DMON|Int32||XmlEnum("""DMON""")|54|
||DEPT|Int32||XmlEnum("""DEPT""")|55|
||DELN|Int32||XmlEnum("""DELN""")|56|
||DEAL|Int32||XmlEnum("""DEAL""")|57|
||DDEA|Int32||XmlEnum("""DDEA""")|58|
||DDAT|Int32||XmlEnum("""DDAT""")|59|
||CPCA|Int32||XmlEnum("""CPCA""")|60|
||CMIS|Int32||XmlEnum("""CMIS""")|61|
||CHAR|Int32||XmlEnum("""CHAR""")|62|
||CADE|Int32||XmlEnum("""CADE""")|63|
||ADEA|Int32||XmlEnum("""ADEA""")|64|

---

## Value ISO20022.Setr044001.YieldCalculation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClctnDt|DateTime||XmlElement()||
|+|ValPrd|ISO20022.Setr044001.DateTimePeriod1Choice||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|RedPric|ISO20022.Setr044001.Price14||XmlElement()||
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

