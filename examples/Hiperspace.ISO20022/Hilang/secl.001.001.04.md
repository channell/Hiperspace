# secl.001.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Secl001001.AccountIdentification26 {
        + Prtry  : ISO20022.Secl001001.SimpleIdentificationInformation4
    }
    ISO20022.Secl001001.AccountIdentification26 *-- ISO20022.Secl001001.SimpleIdentificationInformation4
    class ISO20022.Secl001001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Secl001001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Secl001001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Secl001001.AlternatePartyIdentification4 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Secl001001.IdentificationType6Choice
    }
    ISO20022.Secl001001.AlternatePartyIdentification4 *-- ISO20022.Secl001001.IdentificationType6Choice
    class ISO20022.Secl001001.AlternatePartyIdentification8 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Secl001001.IdentificationType43Choice
    }
    ISO20022.Secl001001.AlternatePartyIdentification8 *-- ISO20022.Secl001001.IdentificationType43Choice
    class ISO20022.Secl001001.AmountAndDirection21 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Secl001001.AmountAndDirection21 *-- ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Secl001001.AmountAndDirection27 {
        + FXDtls  : ISO20022.Secl001001.ForeignExchangeTerms17
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Secl001001.ActiveCurrencyAndAmount
    }
    ISO20022.Secl001001.AmountAndDirection27 *-- ISO20022.Secl001001.ForeignExchangeTerms17
    ISO20022.Secl001001.AmountAndDirection27 *-- ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Secl001001.AmountAndDirection27 *-- ISO20022.Secl001001.ActiveCurrencyAndAmount
    class ISO20022.Secl001001.Clearing7 {
        + NonGrntedTrad  : ISO20022.Secl001001.NonGuaranteedTrade4
        + GrntedTrad  : String
        + ClrSgmt  : ISO20022.Secl001001.PartyIdentification253Choice
        + SttlmNetgElgblCd  : String
    }
    ISO20022.Secl001001.Clearing7 *-- ISO20022.Secl001001.NonGuaranteedTrade4
    ISO20022.Secl001001.Clearing7 *-- ISO20022.Secl001001.PartyIdentification253Choice
    class ISO20022.Secl001001.ClearingAccountType1Code {
        LIPR = 1
        CLIE = 2
        HOUS = 3
    }
    class ISO20022.Secl001001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Secl001001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Secl001001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Secl001001.DateCode20Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Secl001001.DateCode20Choice *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.DateFormat66Choice {
        + DtCd  : ISO20022.Secl001001.DateCode20Choice
        + Dt  : DateTime
    }
    ISO20022.Secl001001.DateFormat66Choice *-- ISO20022.Secl001001.DateCode20Choice
    class ISO20022.Secl001001.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Secl001001.DeliveringPartiesAndAccount22 {
        + SctiesSttlmSys  : String
        + Pty2  : ISO20022.Secl001001.PartyIdentificationAndAccount229
        + Pty1  : ISO20022.Secl001001.PartyIdentificationAndAccount229
        + Dpstry  : ISO20022.Secl001001.PartyIdentification255Choice
    }
    ISO20022.Secl001001.DeliveringPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentificationAndAccount229
    ISO20022.Secl001001.DeliveringPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentificationAndAccount229
    ISO20022.Secl001001.DeliveringPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentification255Choice
    class ISO20022.Secl001001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Secl001001.ForeignExchangeTerms17 {
        + RsltgAmt  : ISO20022.Secl001001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Secl001001.ForeignExchangeTerms17 *-- ISO20022.Secl001001.ActiveCurrencyAndAmount
    class ISO20022.Secl001001.GenericIdentification189 {
        + Tp  : ISO20022.Secl001001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Secl001001.GenericIdentification189 *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Secl001001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Secl001001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Secl001001.IdentificationType43Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Secl001001.IdentificationType43Choice *-- ISO20022.Secl001001.GenericIdentification36
    class ISO20022.Secl001001.IdentificationType6Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Secl001001.IdentificationType6Choice *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Secl001001.MarketIdentification84 {
        + Tp  : ISO20022.Secl001001.MarketType8Choice
        + Id  : ISO20022.Secl001001.MarketIdentification1Choice
    }
    ISO20022.Secl001001.MarketIdentification84 *-- ISO20022.Secl001001.MarketType8Choice
    ISO20022.Secl001001.MarketIdentification84 *-- ISO20022.Secl001001.MarketIdentification1Choice
    class ISO20022.Secl001001.MarketIdentification85 {
        + Tp  : ISO20022.Secl001001.MarketType9Choice
        + Id  : ISO20022.Secl001001.MarketIdentification1Choice
    }
    ISO20022.Secl001001.MarketIdentification85 *-- ISO20022.Secl001001.MarketType9Choice
    ISO20022.Secl001001.MarketIdentification85 *-- ISO20022.Secl001001.MarketIdentification1Choice
    class ISO20022.Secl001001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Secl001001.MarketType5Code {
        EXCH = 1
        OTCO = 2
    }
    class ISO20022.Secl001001.MarketType8Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Secl001001.MarketType8Choice *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.MarketType9Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Secl001001.MarketType9Choice *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.NameAndAddress13 {
        + Adr  : ISO20022.Secl001001.PostalAddress8
        + Nm  : String
    }
    ISO20022.Secl001001.NameAndAddress13 *-- ISO20022.Secl001001.PostalAddress8
    class ISO20022.Secl001001.NameAndAddress5 {
        + Adr  : ISO20022.Secl001001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Secl001001.NameAndAddress5 *-- ISO20022.Secl001001.PostalAddress1
    class ISO20022.Secl001001.NameAndAddress6 {
        + Adr  : ISO20022.Secl001001.PostalAddress2
        + Nm  : String
    }
    ISO20022.Secl001001.NameAndAddress6 *-- ISO20022.Secl001001.PostalAddress2
    class ISO20022.Secl001001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Secl001001.NettingEligible1Code {
        AGFS = 1
        NETT = 2
        GROS = 3
    }
    class ISO20022.Secl001001.NonGuaranteedTrade4 {
        + RcvgPties  : ISO20022.Secl001001.ReceivingPartiesAndAccount22
        + DlvrgPties  : ISO20022.Secl001001.DeliveringPartiesAndAccount22
        + TradCtrPtyClrMmbId  : ISO20022.Secl001001.PartyIdentification253Choice
        + TradCtrPtyMmbId  : ISO20022.Secl001001.PartyIdentification253Choice
    }
    ISO20022.Secl001001.NonGuaranteedTrade4 *-- ISO20022.Secl001001.ReceivingPartiesAndAccount22
    ISO20022.Secl001001.NonGuaranteedTrade4 *-- ISO20022.Secl001001.DeliveringPartiesAndAccount22
    ISO20022.Secl001001.NonGuaranteedTrade4 *-- ISO20022.Secl001001.PartyIdentification253Choice
    ISO20022.Secl001001.NonGuaranteedTrade4 *-- ISO20022.Secl001001.PartyIdentification253Choice
    class ISO20022.Secl001001.OtherIdentification1 {
        + Tp  : ISO20022.Secl001001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Secl001001.OtherIdentification1 *-- ISO20022.Secl001001.IdentificationSource3Choice
    class ISO20022.Secl001001.PartyIdentification253Choice {
        + PrtryId  : ISO20022.Secl001001.GenericIdentification36
        + BIC  : String
    }
    ISO20022.Secl001001.PartyIdentification253Choice *-- ISO20022.Secl001001.GenericIdentification36
    class ISO20022.Secl001001.PartyIdentification254Choice {
        + NmAndAdr  : ISO20022.Secl001001.NameAndAddress6
        + PrtryId  : ISO20022.Secl001001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Secl001001.PartyIdentification254Choice *-- ISO20022.Secl001001.NameAndAddress6
    ISO20022.Secl001001.PartyIdentification254Choice *-- ISO20022.Secl001001.GenericIdentification36
    class ISO20022.Secl001001.PartyIdentification255Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Secl001001.NameAndAddress5
        + BIC  : String
    }
    ISO20022.Secl001001.PartyIdentification255Choice *-- ISO20022.Secl001001.NameAndAddress5
    class ISO20022.Secl001001.PartyIdentification256Choice {
        + NmAndAdr  : ISO20022.Secl001001.NameAndAddress13
        + PrtryId  : ISO20022.Secl001001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Secl001001.PartyIdentification256Choice *-- ISO20022.Secl001001.NameAndAddress13
    ISO20022.Secl001001.PartyIdentification256Choice *-- ISO20022.Secl001001.GenericIdentification36
    class ISO20022.Secl001001.PartyIdentificationAndAccount227 {
        + ClrAcct  : ISO20022.Secl001001.SecuritiesAccount18
        + AddtlInf  : ISO20022.Secl001001.PartyTextInformation1
        + AltrnId  : ISO20022.Secl001001.AlternatePartyIdentification4
        + Id  : ISO20022.Secl001001.PartyIdentification254Choice
    }
    ISO20022.Secl001001.PartyIdentificationAndAccount227 *-- ISO20022.Secl001001.SecuritiesAccount18
    ISO20022.Secl001001.PartyIdentificationAndAccount227 *-- ISO20022.Secl001001.PartyTextInformation1
    ISO20022.Secl001001.PartyIdentificationAndAccount227 *-- ISO20022.Secl001001.AlternatePartyIdentification4
    ISO20022.Secl001001.PartyIdentificationAndAccount227 *-- ISO20022.Secl001001.PartyIdentification254Choice
    class ISO20022.Secl001001.PartyIdentificationAndAccount229 {
        + CtctPrsn  : ISO20022.Secl001001.ContactIdentification2
        + SubAcct  : ISO20022.Secl001001.SubAccount4
        + PrcgDt  : ISO20022.Secl001001.DateAndDateTime2Choice
        + PrcgId  : String
        + AcctId  : String
        + PtyId  : ISO20022.Secl001001.PartyIdentification254Choice
    }
    ISO20022.Secl001001.PartyIdentificationAndAccount229 *-- ISO20022.Secl001001.ContactIdentification2
    ISO20022.Secl001001.PartyIdentificationAndAccount229 *-- ISO20022.Secl001001.SubAccount4
    ISO20022.Secl001001.PartyIdentificationAndAccount229 *-- ISO20022.Secl001001.DateAndDateTime2Choice
    ISO20022.Secl001001.PartyIdentificationAndAccount229 *-- ISO20022.Secl001001.PartyIdentification254Choice
    class ISO20022.Secl001001.PartyIdentificationAndAccount230 {
        + AddtlInf  : ISO20022.Secl001001.PartyTextInformation1
        + PrcgId  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Secl001001.AlternatePartyIdentification8
        + Id  : ISO20022.Secl001001.PartyIdentification256Choice
    }
    ISO20022.Secl001001.PartyIdentificationAndAccount230 *-- ISO20022.Secl001001.PartyTextInformation1
    ISO20022.Secl001001.PartyIdentificationAndAccount230 *-- ISO20022.Secl001001.AlternatePartyIdentification8
    ISO20022.Secl001001.PartyIdentificationAndAccount230 *-- ISO20022.Secl001001.PartyIdentification256Choice
    class ISO20022.Secl001001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Secl001001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Secl001001.PostalAddress2 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCdId  : String
        + StrtNm  : String
    }
    class ISO20022.Secl001001.PostalAddress8 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Secl001001.Price14 {
        + Tp  : String
        + Val  : ISO20022.Secl001001.PriceRateOrAmount3Choice
    }
    ISO20022.Secl001001.Price14 *-- ISO20022.Secl001001.PriceRateOrAmount3Choice
    class ISO20022.Secl001001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Secl001001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Secl001001.PriceRateOrAmount3Choice *-- ISO20022.Secl001001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Secl001001.PriceValueType7Code {
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
    class ISO20022.Secl001001.ReceivingPartiesAndAccount22 {
        + SctiesSttlmSys  : String
        + Pty2  : ISO20022.Secl001001.PartyIdentificationAndAccount229
        + Pty1  : ISO20022.Secl001001.PartyIdentificationAndAccount229
        + Dpstry  : ISO20022.Secl001001.PartyIdentification255Choice
    }
    ISO20022.Secl001001.ReceivingPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentificationAndAccount229
    ISO20022.Secl001001.ReceivingPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentificationAndAccount229
    ISO20022.Secl001001.ReceivingPartiesAndAccount22 *-- ISO20022.Secl001001.PartyIdentification255Choice
    class ISO20022.Secl001001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Secl001001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Secl001001.SafekeepingPlaceFormat43Choice {
        + Prtry  : ISO20022.Secl001001.GenericIdentification189
        + TpAndId  : ISO20022.Secl001001.SafekeepingPlaceTypeAndAnyBICIdentifier4
        + Ctry  : String
        + Id  : ISO20022.Secl001001.SafekeepingPlaceTypeAndText1
    }
    ISO20022.Secl001001.SafekeepingPlaceFormat43Choice *-- ISO20022.Secl001001.GenericIdentification189
    ISO20022.Secl001001.SafekeepingPlaceFormat43Choice *-- ISO20022.Secl001001.SafekeepingPlaceTypeAndAnyBICIdentifier4
    ISO20022.Secl001001.SafekeepingPlaceFormat43Choice *-- ISO20022.Secl001001.SafekeepingPlaceTypeAndText1
    class ISO20022.Secl001001.SafekeepingPlaceTypeAndAnyBICIdentifier4 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Secl001001.SafekeepingPlaceTypeAndText1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Secl001001.SecuritiesAccount18 {
        + Nm  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Secl001001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Secl001001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Secl001001.SecuritiesAccount19 *-- ISO20022.Secl001001.GenericIdentification30
    class ISO20022.Secl001001.SecurityIdentification48 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Secl001001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Secl001001.SecurityIdentification48 *-- ISO20022.Secl001001.OtherIdentification1
    class ISO20022.Secl001001.Settlement2 {
        + Dpstry  : ISO20022.Secl001001.PartyIdentification255Choice
        + SttlmAmt  : ISO20022.Secl001001.AmountAndDirection27
    }
    ISO20022.Secl001001.Settlement2 *-- ISO20022.Secl001001.PartyIdentification255Choice
    ISO20022.Secl001001.Settlement2 *-- ISO20022.Secl001001.AmountAndDirection27
    class ISO20022.Secl001001.Side1Code {
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
    class ISO20022.Secl001001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Secl001001.Status5Code {
        PDNG = 1
        PACK = 2
        REJT = 3
    }
    class ISO20022.Secl001001.SubAccount4 {
        + Chrtc  : String
        + Nm  : String
        + Id  : ISO20022.Secl001001.AccountIdentification26
    }
    ISO20022.Secl001001.SubAccount4 *-- ISO20022.Secl001001.AccountIdentification26
    class ISO20022.Secl001001.SupplementaryData1 {
        + Envlp  : ISO20022.Secl001001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Secl001001.SupplementaryData1 *-- ISO20022.Secl001001.SupplementaryDataEnvelope1
    class ISO20022.Secl001001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Secl001001.TradeLeg11 {
        + SfkpgAcct  : ISO20022.Secl001001.SecuritiesAccount19
        + SfkpgPlc  : ISO20022.Secl001001.SafekeepingPlaceFormat43Choice
        + TradPstngCd  : String
        + TradgCpcty  : String
        + TradgPtyAcct  : ISO20022.Secl001001.SecuritiesAccount19
        + TradRegnOrgn  : String
        + TradgPty  : ISO20022.Secl001001.PartyIdentification253Choice
        + Brkr  : ISO20022.Secl001001.PartyIdentificationAndAccount230
        + DerivRltdTrad  : String
        + TradTp  : String
        + PlcOfListg  : ISO20022.Secl001001.MarketIdentification85
        + PlcOfTrad  : ISO20022.Secl001001.MarketIdentification84
        + AcrdIntrstAmt  : ISO20022.Secl001001.AmountAndDirection21
        + GrssAmt  : ISO20022.Secl001001.AmountAndDirection21
        + DealPric  : ISO20022.Secl001001.Price14
        + TradQty  : ISO20022.Secl001001.FinancialInstrumentQuantity1Choice
        + BuySellInd  : String
        + TradgCcy  : String
        + FinInstrmId  : ISO20022.Secl001001.SecurityIdentification48
        + SttlmDt  : ISO20022.Secl001001.DateFormat66Choice
        + TxDtTm  : DateTime
        + TradDt  : DateTime
        + Sts  : String
        + AllcnId  : String
        + OrdrId  : String
        + UnqTxIdr  : String
        + TradExctnId  : String
        + TradId  : String
        + TradLegId  : String
    }
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.SecuritiesAccount19
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.SafekeepingPlaceFormat43Choice
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.SecuritiesAccount19
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.PartyIdentification253Choice
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.PartyIdentificationAndAccount230
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.MarketIdentification85
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.MarketIdentification84
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.AmountAndDirection21
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.AmountAndDirection21
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.Price14
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.FinancialInstrumentQuantity1Choice
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.SecurityIdentification48
    ISO20022.Secl001001.TradeLeg11 *-- ISO20022.Secl001001.DateFormat66Choice
    class ISO20022.Secl001001.TradeLegNotificationV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Secl001001.SupplementaryData1~
        + SttlmDtls  : ISO20022.Secl001001.Settlement2
        + TradLegDtls  : ISO20022.Secl001001.TradeLeg11
        + ClrDtls  : ISO20022.Secl001001.Clearing7
        + NonClrMmb  : ISO20022.Secl001001.PartyIdentificationAndAccount227
        + DlvryAcct  : ISO20022.Secl001001.SecuritiesAccount19
        + ClrAcct  : ISO20022.Secl001001.SecuritiesAccount18
        + ClrMmb  : ISO20022.Secl001001.PartyIdentification253Choice
    }
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.SupplementaryData1
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.Settlement2
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.TradeLeg11
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.Clearing7
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.PartyIdentificationAndAccount227
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.SecuritiesAccount19
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.SecuritiesAccount18
    ISO20022.Secl001001.TradeLegNotificationV04 *-- ISO20022.Secl001001.PartyIdentification253Choice
    class ISO20022.Secl001001.TradePosting1Code {
        NETT = 1
        GROS = 2
    }
    class ISO20022.Secl001001.TradeType1Code {
        LKTR = 1
        GUTR = 2
        COTR = 3
        BKTR = 4
        OFBK = 5
        OOBK = 6
    }
    class ISO20022.Secl001001.TradingCapacity5Code {
        AGEN = 1
        RISP = 2
        PRIN = 3
    }
    class ISO20022.Secl001001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Secl001001.TypeOfIdentification2Code {
        TXID = 1
        FIIN = 2
        CORP = 3
        CHTY = 4
        ARNU = 5
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

## Value ISO20022.Secl001001.AccountIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.SimpleIdentificationInformation4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Secl001001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Secl001001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Secl001001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Secl001001.AlternatePartyIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Secl001001.IdentificationType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Secl001001.AlternatePartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Secl001001.IdentificationType43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Secl001001.AmountAndDirection21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Secl001001.AmountAndDirection27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Secl001001.ForeignExchangeTerms17||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Secl001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Secl001001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Secl001001.Clearing7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonGrntedTrad|ISO20022.Secl001001.NonGuaranteedTrade4||XmlElement()||
|+|GrntedTrad|String||XmlElement()||
|+|ClrSgmt|ISO20022.Secl001001.PartyIdentification253Choice||XmlElement()||
|+|SttlmNetgElgblCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonGrntedTrad),validElement(ClrSgmt))|

---

## Enum ISO20022.Secl001001.ClearingAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LIPR|Int32||XmlEnum("""LIPR""")|1|
||CLIE|Int32||XmlEnum("""CLIE""")|2|
||HOUS|Int32||XmlEnum("""HOUS""")|3|

---

## Value ISO20022.Secl001001.ContactIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Secl001001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Secl001001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Secl001001.DateCode20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.DateFormat66Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Secl001001.DateCode20Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Secl001001.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Secl001001.DeliveringPartiesAndAccount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmSys|String||XmlElement()||
|+|Pty2|ISO20022.Secl001001.PartyIdentificationAndAccount229||XmlElement()||
|+|Pty1|ISO20022.Secl001001.PartyIdentificationAndAccount229||XmlElement()||
|+|Dpstry|ISO20022.Secl001001.PartyIdentification255Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Type ISO20022.Secl001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradLegNtfctn|ISO20022.Secl001001.TradeLegNotificationV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradLegNtfctn))|

---

## Value ISO20022.Secl001001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Secl001001.ForeignExchangeTerms17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Secl001001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Secl001001.GenericIdentification189


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Secl001001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Secl001001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Secl001001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.IdentificationType43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.IdentificationType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Secl001001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Secl001001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Secl001001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Secl001001.MarketIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Secl001001.MarketType9Choice||XmlElement()||
|+|Id|ISO20022.Secl001001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Secl001001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Enum ISO20022.Secl001001.MarketType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||OTCO|Int32||XmlEnum("""OTCO""")|2|

---

## Value ISO20022.Secl001001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.MarketType9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Secl001001.NameAndAddress13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Secl001001.PostalAddress8||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Secl001001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Secl001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Secl001001.NameAndAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Secl001001.PostalAddress2||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Secl001001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Enum ISO20022.Secl001001.NettingEligible1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGFS|Int32||XmlEnum("""AGFS""")|1|
||NETT|Int32||XmlEnum("""NETT""")|2|
||GROS|Int32||XmlEnum("""GROS""")|3|

---

## Value ISO20022.Secl001001.NonGuaranteedTrade4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgPties|ISO20022.Secl001001.ReceivingPartiesAndAccount22||XmlElement()||
|+|DlvrgPties|ISO20022.Secl001001.DeliveringPartiesAndAccount22||XmlElement()||
|+|TradCtrPtyClrMmbId|ISO20022.Secl001001.PartyIdentification253Choice||XmlElement()||
|+|TradCtrPtyMmbId|ISO20022.Secl001001.PartyIdentification253Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgPties),validElement(DlvrgPties),validElement(TradCtrPtyClrMmbId),validElement(TradCtrPtyMmbId))|

---

## Value ISO20022.Secl001001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Secl001001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Secl001001.PartyIdentification253Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Secl001001.GenericIdentification36||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,BIC))|

---

## Value ISO20022.Secl001001.PartyIdentification254Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Secl001001.NameAndAddress6||XmlElement()||
|+|PrtryId|ISO20022.Secl001001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Secl001001.PartyIdentification255Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Secl001001.NameAndAddress5||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""BIC""",BIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,BIC))|

---

## Value ISO20022.Secl001001.PartyIdentification256Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Secl001001.NameAndAddress13||XmlElement()||
|+|PrtryId|ISO20022.Secl001001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Secl001001.PartyIdentificationAndAccount227


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrAcct|ISO20022.Secl001001.SecuritiesAccount18||XmlElement()||
|+|AddtlInf|ISO20022.Secl001001.PartyTextInformation1||XmlElement()||
|+|AltrnId|ISO20022.Secl001001.AlternatePartyIdentification4||XmlElement()||
|+|Id|ISO20022.Secl001001.PartyIdentification254Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrAcct),validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Secl001001.PartyIdentificationAndAccount229


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Secl001001.ContactIdentification2||XmlElement()||
|+|SubAcct|ISO20022.Secl001001.SubAccount4||XmlElement()||
|+|PrcgDt|ISO20022.Secl001001.DateAndDateTime2Choice||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|PtyId|ISO20022.Secl001001.PartyIdentification254Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(SubAcct),validElement(PrcgDt),validElement(PtyId))|

---

## Value ISO20022.Secl001001.PartyIdentificationAndAccount230


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Secl001001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Secl001001.AlternatePartyIdentification8||XmlElement()||
|+|Id|ISO20022.Secl001001.PartyIdentification256Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validElement(Id))|

---

## Value ISO20022.Secl001001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Secl001001.PostalAddress1


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

## Value ISO20022.Secl001001.PostalAddress2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCdId|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Secl001001.PostalAddress8


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

## Value ISO20022.Secl001001.Price14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|ISO20022.Secl001001.PriceRateOrAmount3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Value ISO20022.Secl001001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Secl001001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Secl001001.PriceValueType7Code


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

## Value ISO20022.Secl001001.ReceivingPartiesAndAccount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmSys|String||XmlElement()||
|+|Pty2|ISO20022.Secl001001.PartyIdentificationAndAccount229||XmlElement()||
|+|Pty1|ISO20022.Secl001001.PartyIdentificationAndAccount229||XmlElement()||
|+|Dpstry|ISO20022.Secl001001.PartyIdentification255Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Secl001001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Secl001001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Secl001001.SafekeepingPlaceFormat43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Secl001001.GenericIdentification189||XmlElement()||
|+|TpAndId|ISO20022.Secl001001.SafekeepingPlaceTypeAndAnyBICIdentifier4||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Secl001001.SafekeepingPlaceTypeAndText1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Secl001001.SafekeepingPlaceTypeAndAnyBICIdentifier4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Secl001001.SafekeepingPlaceTypeAndText1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Secl001001.SecuritiesAccount18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Secl001001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Secl001001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Secl001001.SecurityIdentification48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Secl001001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Secl001001.Settlement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dpstry|ISO20022.Secl001001.PartyIdentification255Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Secl001001.AmountAndDirection27||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dpstry),validElement(SttlmAmt))|

---

## Enum ISO20022.Secl001001.Side1Code


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

## Value ISO20022.Secl001001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Secl001001.Status5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PDNG|Int32||XmlEnum("""PDNG""")|1|
||PACK|Int32||XmlEnum("""PACK""")|2|
||REJT|Int32||XmlEnum("""REJT""")|3|

---

## Value ISO20022.Secl001001.SubAccount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Secl001001.AccountIdentification26||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Secl001001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Secl001001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Secl001001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Secl001001.TradeLeg11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgAcct|ISO20022.Secl001001.SecuritiesAccount19||XmlElement()||
|+|SfkpgPlc|ISO20022.Secl001001.SafekeepingPlaceFormat43Choice||XmlElement()||
|+|TradPstngCd|String||XmlElement()||
|+|TradgCpcty|String||XmlElement()||
|+|TradgPtyAcct|ISO20022.Secl001001.SecuritiesAccount19||XmlElement()||
|+|TradRegnOrgn|String||XmlElement()||
|+|TradgPty|ISO20022.Secl001001.PartyIdentification253Choice||XmlElement()||
|+|Brkr|ISO20022.Secl001001.PartyIdentificationAndAccount230||XmlElement()||
|+|DerivRltdTrad|String||XmlElement()||
|+|TradTp|String||XmlElement()||
|+|PlcOfListg|ISO20022.Secl001001.MarketIdentification85||XmlElement()||
|+|PlcOfTrad|ISO20022.Secl001001.MarketIdentification84||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Secl001001.AmountAndDirection21||XmlElement()||
|+|GrssAmt|ISO20022.Secl001001.AmountAndDirection21||XmlElement()||
|+|DealPric|ISO20022.Secl001001.Price14||XmlElement()||
|+|TradQty|ISO20022.Secl001001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|BuySellInd|String||XmlElement()||
|+|TradgCcy|String||XmlElement()||
|+|FinInstrmId|ISO20022.Secl001001.SecurityIdentification48||XmlElement()||
|+|SttlmDt|ISO20022.Secl001001.DateFormat66Choice||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
|+|Sts|String||XmlElement()||
|+|AllcnId|String||XmlElement()||
|+|OrdrId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradExctnId|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|TradLegId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgAcct),validElement(SfkpgPlc),validElement(TradgPtyAcct),validElement(TradgPty),validElement(Brkr),validElement(PlcOfListg),validElement(PlcOfTrad),validElement(AcrdIntrstAmt),validElement(GrssAmt),validElement(DealPric),validElement(TradQty),validPattern("""TradgCcy""",TradgCcy,"""[A-Z]{3,3}"""),validElement(FinInstrmId),validElement(SttlmDt),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Aspect ISO20022.Secl001001.TradeLegNotificationV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Secl001001.SupplementaryData1>||XmlElement()||
|+|SttlmDtls|ISO20022.Secl001001.Settlement2||XmlElement()||
|+|TradLegDtls|ISO20022.Secl001001.TradeLeg11||XmlElement()||
|+|ClrDtls|ISO20022.Secl001001.Clearing7||XmlElement()||
|+|NonClrMmb|ISO20022.Secl001001.PartyIdentificationAndAccount227||XmlElement()||
|+|DlvryAcct|ISO20022.Secl001001.SecuritiesAccount19||XmlElement()||
|+|ClrAcct|ISO20022.Secl001001.SecuritiesAccount18||XmlElement()||
|+|ClrMmb|ISO20022.Secl001001.PartyIdentification253Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SttlmDtls),validElement(TradLegDtls),validElement(ClrDtls),validElement(NonClrMmb),validElement(DlvryAcct),validElement(ClrAcct),validElement(ClrMmb))|

---

## Enum ISO20022.Secl001001.TradePosting1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETT|Int32||XmlEnum("""NETT""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Enum ISO20022.Secl001001.TradeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LKTR|Int32||XmlEnum("""LKTR""")|1|
||GUTR|Int32||XmlEnum("""GUTR""")|2|
||COTR|Int32||XmlEnum("""COTR""")|3|
||BKTR|Int32||XmlEnum("""BKTR""")|4|
||OFBK|Int32||XmlEnum("""OFBK""")|5|
||OOBK|Int32||XmlEnum("""OOBK""")|6|

---

## Enum ISO20022.Secl001001.TradingCapacity5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||RISP|Int32||XmlEnum("""RISP""")|2|
||PRIN|Int32||XmlEnum("""PRIN""")|3|

---

## Enum ISO20022.Secl001001.TypeOfIdentification1Code


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

## Enum ISO20022.Secl001001.TypeOfIdentification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||CORP|Int32||XmlEnum("""CORP""")|3|
||CHTY|Int32||XmlEnum("""CHTY""")|4|
||ARNU|Int32||XmlEnum("""ARNU""")|5|

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

